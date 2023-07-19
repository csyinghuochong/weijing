using System;
using System.Collections.Generic;

namespace ET
{

    [ActorMessageHandler]
    public  class C2M_JiaYuanStoreHandler : AMActorLocationRpcHandler<Unit, C2M_JiaYuanStoreRequest, M2C_JiaYuanStoreResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_JiaYuanStoreRequest request, M2C_JiaYuanStoreResponse response, Action reply)
        {
            int hourseId = request.HorseId;
            int leftCell = unit.GetComponent<BagComponent>().GetStoreLeftCell(hourseId);
            if (leftCell<= 0)
            {
                response.Error = ErrorCore.ERR_BagIsFull;     //错误码:仓库已满
                reply();
                return;
            }
            M2C_RoleBagUpdate m2c_bagUpdate = new M2C_RoleBagUpdate();

            List <BagInfo> bagInfos = unit.GetComponent<BagComponent>().BagItemList;

            List<BagInfo> itemList = new List<BagInfo>();
            
            // 家园种子仓库
            if ((ItemLocType)hourseId >= ItemLocType.JianYuanWareHouse1 && (ItemLocType)hourseId <= ItemLocType.JianYuanWareHouse4)
            {
                itemList = ItemHelper.GetSeedList(bagInfos);
            }
            // 家园藏宝图仓库_存藏宝图的
            else if ((ItemLocType)hourseId == ItemLocType.JianYuanTreasureMapStorage1)
            {
                itemList = ItemHelper.GetTreasureMapList(bagInfos);
            } 
            // 家园藏宝图仓库_存生活材料的
            else if ((ItemLocType)hourseId == ItemLocType.JianYuanTreasureMapStorage2)
            {
                itemList = ItemHelper.GetTreasureMapList2(bagInfos);
            }
            
            for (int i = 0; i < itemList.Count; i++)
            {
                unit.GetComponent<BagComponent>().OnChangeItemLoc(itemList[i], (ItemLocType)hourseId, ItemLocType.ItemLocBag);
                m2c_bagUpdate.BagInfoUpdate.Add(itemList[i]);
                leftCell--;
                if (leftCell <= 0)
                {
                    break;
                }
            }
            MessageHelper.SendToClient(unit, m2c_bagUpdate);

            reply();
            await ETTask.CompletedTask;
        }
    }
}
