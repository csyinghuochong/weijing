using System;
using System.Collections.Generic;

namespace ET
{

    [ActorMessageHandler]
    public class C2M_ItemSplitHandler : AMActorLocationRpcHandler<Unit, C2M_ItemSplitRequest, M2C_ItemSplitResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_ItemSplitRequest request, M2C_ItemSplitResponse response, Action reply)
        {
            long bagInfoID = request.OperateBagID;
            BagInfo useBagInfo = unit.GetComponent<BagComponent>().GetItemByLoc(ItemLocType.ItemLocBag, bagInfoID);
            if (useBagInfo == null)
            {
                response.Error = ErrorCore.ERR_ItemUseError;
                reply();
                return;
            }

            int splitNumber = int.Parse(request.OperatePar);
            if (splitNumber <= 0 )
            {
                response.Error = ErrorCore.ERR_ModifyData;
                reply();
                return;
            }

            if (splitNumber >= useBagInfo.ItemNum - 1)
            {
                reply();
                return;
            }

            useBagInfo.ItemNum -= splitNumber;
            unit.GetComponent<BagComponent>().OnAddItemDataNewCell(useBagInfo.ItemID, splitNumber, useBagInfo.GetWay);

            M2C_RoleBagUpdate m2c_bagUpdate = new M2C_RoleBagUpdate();
            m2c_bagUpdate.BagInfoUpdate.Add(useBagInfo);
            MessageHelper.SendToClient(unit, m2c_bagUpdate);
            reply();
            await ETTask.CompletedTask;
        }
    }
}
