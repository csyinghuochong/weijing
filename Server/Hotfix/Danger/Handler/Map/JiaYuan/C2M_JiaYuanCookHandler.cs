using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace ET
{

    [ActorMessageHandler]
    public class C2M_JiaYuanCookHandler : AMActorLocationRpcHandler<Unit, C2M_JiaYuanCookRequest, M2C_JiaYuanCookResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_JiaYuanCookRequest request, M2C_JiaYuanCookResponse response, Action reply)
        {
            List<long> huishouList = request.BagInfoIds;
            BagComponent bagComponent = unit.GetComponent<BagComponent>();

            if (huishouList.Count < 2)
            {
                response.Error = ErrorCore.ERR_ItemNotEnoughError;
                reply();
                return;
            }

            int totallv = 0;
            List<int> itemIdList = new List<int>();
            for (int i = 0; i < huishouList.Count; i++)
            {
                BagInfo bagInfo = bagComponent.GetItemByLoc(ItemLocType.ItemLocBag, huishouList[i]);
                if (bagInfo == null)
                {
                    response.Error = ErrorCore.ERR_ItemNotEnoughError;
                    break;
                }
                ItemConfig itemConfig = ItemConfigCategory.Instance.Get(bagInfo.ItemID);
                totallv += (itemConfig.UseLv);
                itemIdList.Add(bagInfo.ItemID);
            }
            if (response.Error != ErrorCore.ERR_Success)
            {
                reply();
                return;
            }

            //激活逻辑
            int getItemid = 0;
            bool ifActiveMake = false;
            int makeid = EquipMakeConfigCategory.Instance.GetCanMakeId(itemIdList);
            JiaYuanComponent jiaYuanComponent = unit.GetComponent<JiaYuanComponent>();
            if (makeid > 0 )
            {
                if (RandomHelper.RandFloat01() >= 0.1f)
                {
                    //制作成功
                    jiaYuanComponent.LearnMakeIds_7.Add(makeid);
                    getItemid = EquipMakeConfigCategory.Instance.Get(makeid).MakeItemID;
                    ifActiveMake = true;

                    if (!jiaYuanComponent.LearnMakeIds_7.Contains(getItemid))
                    {
                        response.LearnId = getItemid;
                        jiaYuanComponent.LearnMakeIds_7.Add(getItemid);
                    }
                }
                else
                {
                    //制作失败
                    getItemid = 10036101;
                }
            }

            //随机
            if (makeid == 0 && ifActiveMake == false)
            {
                if (RandomHelper.RandFloat01() >= 0.5f)
                {
                    int randLvMax = Mathf.CeilToInt(totallv * 1f / 4);
                    int randLv = RandomHelper.RandomNumber((int)(randLvMax * 0.5f), randLvMax + 1);
                    if (randLv < 1) {
                        randLv = 1;
                    }
                    getItemid = ItemConfigCategory.Instance.GetFoodId(randLv);
                    if (getItemid == 0)
                    {
                        reply();
                        return;
                    }
                }
                else {
                    //制作失败
                    getItemid = 10036102;
                }
            }

            for (int i = 0; i < huishouList.Count; i++)
            {
                bagComponent.OnCostItemData(huishouList[i],1);
            }
            bagComponent.OnAddItemData($"{getItemid};1", $"{ItemGetWay.JiaYuanCook}_{TimeHelper.ServerNow()}");
            response.LearnMakeIds = jiaYuanComponent.LearnMakeIds_7;
            response.ItemId = getItemid;
            await DBHelper.SaveComponent(unit.DomainZone(), unit.Id, jiaYuanComponent);
            reply();
            await ETTask.CompletedTask;
        }
    }
}
