using System;
using System.Collections.Generic;
using UnityEngine;

namespace ET
{

    [ActorMessageHandler]
    public class C2M_ChouKaRequestHandler : AMActorLocationRpcHandler<Unit, C2M_ChouKaRequest, M2C_ChouKaResponse>
    {

        protected override async ETTask Run(Unit unit, C2M_ChouKaRequest request, M2C_ChouKaResponse response, Action reply)
        {
            BagComponent bagComponent = unit.GetComponent<BagComponent>();
            UserInfo userInfo = unit.GetComponent<UserInfoComponent>().UserInfo;
            // 判断背包和仓库是否能够装满
            if (bagComponent.GetLeftSpace() + bagComponent.GetChouKaLeftSpace() < request.ChouKaType)
            {
                response.Error = ErrorCode.ERR_BagIsFull;
                reply();
                return;
            }
            if (!TakeCardConfigCategory.Instance.Contain(request.ChapterId))
            {
                response.Error = ErrorCode.ERR_NetWorkError;
                reply();
                return;
            }

            NumericComponent numericComponent = unit.GetComponent<NumericComponent>();

            bool mianfei = false;
            long cdTime = long.Parse(GlobalValueConfigCategory.Instance.Get(request.ChouKaType == 1 ? 35:36).Value) * 1000;
            
            long lastTime = unit.GetComponent<NumericComponent>().GetAsLong(request.ChouKaType == 1 ? NumericType.ChouKaOneTime: NumericType.ChouKaTenTime);
            mianfei = TimeHelper.ServerNow() - lastTime >= cdTime;

            TakeCardConfig takeCardConfig = TakeCardConfigCategory.Instance.Get(request.ChapterId);
            int needZuanshi = request.ChouKaType == 1 ? takeCardConfig.ZuanShiNum : takeCardConfig.ZuanShiNum_Ten;
            int totalTimes = numericComponent.GetAsInt(NumericType.ChouKa);
            if (totalTimes >= 250)
            {
                needZuanshi = Mathf.CeilToInt(needZuanshi * 0.8f);
            }

            if (!mianfei && userInfo.Diamond < needZuanshi)
            {
                response.Error = ErrorCode.ERR_DiamondNotEnoughError;
                reply();
                return;
            }

            int dropid = TakeCardConfigCategory.Instance.Get(request.ChapterId).DropID;
            List<RewardItem> droplist = new List<RewardItem>();
            for (int i = 0; i < request.ChouKaType; i++)
            {
                DropHelper.DropIDToDropItem_2(dropid, droplist);
            }
            for (int i = 0; i < droplist.Count; i++)
            {
                if (droplist[i].ItemID == 0)
                {
                    Log.Error($"抽卡[道具为0]： {unit.Id} {droplist[i].ItemID}");
                }
            }
            
            LogHelper.LogWarning($"抽卡： {unit.Id} {droplist.Count}", true);
            
            // 判断背包是否能装下，不能的话剩下的放抽卡仓库
            int bagLeftSpace = bagComponent.GetLeftSpace();
            if (bagLeftSpace < droplist.Count)
            {
                List<RewardItem> putInBag = new List<RewardItem>();
                List<RewardItem> putInChouKa = new List<RewardItem>();
                int i = 0;
                foreach (RewardItem item in droplist)
                {
                    if (i < bagLeftSpace)
                    {
                        putInBag.Add(item);
                    }
                    else
                    {
                        putInChouKa.Add(item);
                    }

                    i++;
                }

                // 放入背包
                bagComponent.OnAddItemData(putInBag, string.Empty, $"{ItemGetWay.ChouKa}_{TimeHelper.ServerNow()}");
                // 放入抽卡仓库
                bagComponent.OnAddItemData(putInChouKa, string.Empty, $"{ItemGetWay.ChouKa}_{TimeHelper.ServerNow()}",
                    UseLocType: ItemLocType.ChouKaWarehouse);
            }
            else
            {
                bagComponent.OnAddItemData(droplist, string.Empty, $"{ItemGetWay.ChouKa}_{TimeHelper.ServerNow()}");
            }

            unit.GetComponent<NumericComponent>().ApplyChange(null, NumericType.ChouKa, request.ChouKaType, 0);
            if (mianfei)
            {
                unit.GetComponent<NumericComponent>().ApplyValue(request.ChouKaType == 1 ? NumericType.ChouKaOneTime : NumericType.ChouKaTenTime, TimeHelper.ServerNow());
            }
            else
            {
                unit.GetComponent<UserInfoComponent>().UpdateRoleMoneySub(UserDataType.Diamond, (needZuanshi * -1).ToString(), true, ItemGetWay.ChouKa);
            }
            if (request.ChouKaType == 10)
            {
                unit.GetComponent<ChengJiuComponent>().OnChouKaTen();
            }
            unit.GetComponent<TaskComponent>().TriggerTaskCountryEvent(TaskCountryTargetType.ChouKa_1016, 0, request.ChouKaType);
            unit.GetComponent<DataCollationComponent>().OnChouKa(request.ChouKaType);
            response.RewardList = droplist;
            reply();
            await ETTask.CompletedTask;
        }
    }
}
