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
            List<BagInfo> seedlist = ItemHelper.GetSeedList(bagInfos);
            for (int i = 0; i < seedlist.Count; i++)
            {
                unit.GetComponent<BagComponent>().OnChangeItemLoc(seedlist[i], (ItemLocType)hourseId, ItemLocType.ItemLocBag);
                m2c_bagUpdate.BagInfoUpdate.Add(seedlist[i]);
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
