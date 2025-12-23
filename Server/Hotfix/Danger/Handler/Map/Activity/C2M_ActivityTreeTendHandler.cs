using MongoDB.Driver.Core.Servers;
using System;
using System.Collections.Generic;

namespace ET
{

    [ActorMessageHandler]
    public class C2M_ActivityTreeTendHandler : AMActorLocationRpcHandler<Unit, C2M_ActivityTreeTendRequest, M2C_ActivityTreeTendResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_ActivityTreeTendRequest request, M2C_ActivityTreeTendResponse response, Action reply)
        {
            BagComponent bagComponent = unit.GetComponent<BagComponent>();
            int lower = 0;
            int upper = 0;
            for (int i = request.CostList.Count - 1; i >= 0; i--)
            {
                int itemid = request.CostList[i].ItemID;
                int usenum = request.CostList[i].ItemNum;

                ActivityConfigHelper.ActivityTreeCostItem.TryGetValue(itemid, out var costitemcomponent);
                if (costitemcomponent == default)
                {
                    request.CostList.RemoveAt(i);
                    continue;
                }
                if (usenum == 0 || itemid == 0)
                {
                    request.CostList.RemoveAt(i);
                    continue;
                }

                if (bagComponent.GetItemNumber(itemid) < usenum)
                {
                    response.Error = ErrorCode.ERR_ItemNotEnoughError;
                    reply();
                    continue;
                }

                lower += usenum * costitemcomponent.Item1;
                upper += usenum * costitemcomponent.Item2;
            }

            int addscore = RandomHelper.RandomNumber(lower, upper + 1);
            ActivityTreeTendItem activityTreeTendItem =  ActivityConfigHelper.GetActivityTreeTendItem(addscore);

            List<RewardItem> droplist = new List<RewardItem>();
            DropHelper.DropIDToDropItem_2(activityTreeTendItem.Reward, droplist);

            if (bagComponent.GetBagLeftCell() < droplist.Count)
            {
                response.Error = ErrorCode.ERR_BagIsFull;
                reply();
                return;
            }

            bool checkitem =  bagComponent.OnCostItemData(request.CostList, ItemLocType.ItemLocBag, ItemGetWay.Activity);
            if (!checkitem)
            {
                response.Error = ErrorCode.ERR_ItemNotEnoughError;
                reply();
                return;
            }

            bagComponent.OnAddItemData(droplist, string.Empty, $"{ItemGetWay.Activity}_{TimeHelper.ServerNow()}");

            ActivityComponent activityComponent = unit.GetComponent<ActivityComponent>();
            long oldtreevalue = activityComponent.ActivityV1Info.GrowthTreeValue;
            int oldstage = ActivityConfigHelper.GetActivityTreeStageItem(oldtreevalue);
            activityComponent.ActivityV1Info.GrowthTreeValue += addscore;
            long newtreevalue = activityComponent.ActivityV1Info.GrowthTreeValue;
            int newstate = ActivityConfigHelper.GetActivityTreeStageItem(newtreevalue);

            if (oldstage != newstate)
            {
                //发送邮件奖励
                ActivityTreeStageItem activityTreeStageItem = ActivityConfigHelper.ActivityTreeStageDesc[oldstage];

                MailInfo mailInfo = new MailInfo();
                mailInfo.Status = 0;
                mailInfo.Title = "成长树活动奖励";
                mailInfo.MailId = IdGenerater.Instance.GenerateId();

                mailInfo.Context = $"成长树达到 {activityTreeStageItem.Name},获得如下奖励";
                string[] needList = activityTreeStageItem.Reward.Split('@');
                for (int k = 0; k < needList.Length; k++)
                {
                    string[] itemInfo = needList[k].Split(';');
                    if (itemInfo.Length < 2)
                    {
                        continue;
                    }
                    int itemId = int.Parse(itemInfo[0]);
                    int itemNum = int.Parse(itemInfo[1]);
                    mailInfo.ItemList.Add(new BagInfo() { ItemID = itemId, ItemNum = itemNum, GetWay = $"{ItemGetWay.Activity}_{TimeHelper.ServerNow()}" });
                }
                MailHelp.SendUserMail(unit.DomainZone(), unit.Id, mailInfo).Coroutine();
            }

            response.ActivityV1Info = activityComponent.ActivityV1Info; 
            reply();
            await ETTask.CompletedTask;
        }
    }
}

