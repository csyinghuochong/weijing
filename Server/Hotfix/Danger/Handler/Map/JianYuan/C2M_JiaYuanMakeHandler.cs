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

            if (huishouList.Count < 4)
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

            int getItemid = ItemConfigCategory.Instance.GetFoodId(Mathf.CeilToInt(totallv * 1f / 4));
            if (getItemid == 0)
            {

                reply();
                return;
            }

            int makeid = EquipMakeConfigCategory.Instance.GetMakeId(getItemid);
            EquipMakeConfig equipMakeConfig = EquipMakeConfigCategory.Instance.Get(makeid);
            string[] needitems = equipMakeConfig.NeedItems.Split('@');
            bool right = true;
            for (int i = 0; i < needitems.Length; i++)
            {
                int itemid = int.Parse(needitems[i].Split(';')[0]);
                if (!itemIdList.Contains(itemid))
                {
                    right = false;
                    break;
                }
            }

            JiaYuanComponent jiaYuanComponent = unit.GetComponent<JiaYuanComponent>();
            if (right && !jiaYuanComponent.LearnMakeIds_3.Contains(getItemid))
            {
                jiaYuanComponent.LearnMakeIds_3.Add(getItemid);
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
