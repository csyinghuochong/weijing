using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace ET
{

    [ActorMessageHandler]
    public class C2M_JiaYuanMakeHandler : AMActorLocationRpcHandler<Unit, C2M_JiaYuanMakeRequest, M2C_JiaYuanMakeResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_JiaYuanMakeRequest request, M2C_JiaYuanMakeResponse response, Action reply)
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
            int makeid = EquipMakeConfigCategory.Instance.GetCanMakeId(itemIdList);
            JiaYuanComponent jiaYuanComponent = unit.GetComponent<JiaYuanComponent>();
            if (makeid > 0 && !jiaYuanComponent.LearnMakeIds_3.Contains(makeid))
            {
                jiaYuanComponent.LearnMakeIds_3.Add(makeid);
                getItemid = EquipMakeConfigCategory.Instance.Get(makeid).MakeItemID;
            }

            if (makeid == 0)
            {
                //随机
                int randLvMax = Mathf.CeilToInt(totallv * 1f / 4);
                int randLv = RandomHelper.RandomNumber((int)(randLvMax * 0.5f), randLvMax + 1);
                getItemid = ItemConfigCategory.Instance.GetFoodId(randLv);
                if (getItemid == 0)
                {
                    reply();
                    return;
                }
            }
            
            for (int i = 0; i < huishouList.Count; i++)
            {
                bagComponent.OnCostItemData(huishouList[i],1);
            }
            bagComponent.OnAddItemData($"{getItemid};1", $"{ItemGetWay.JiaYuanGather}_{TimeHelper.ServerNow()}");
            response.LearnMakeIds = jiaYuanComponent.LearnMakeIds_3;
            reply();
            await ETTask.CompletedTask;
        }
    }
}
