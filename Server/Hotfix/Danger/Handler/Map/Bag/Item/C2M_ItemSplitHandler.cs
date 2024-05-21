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
                response.Error = ErrorCode.ERR_ItemUseError;
                reply();
                return;
            }

            long splitNumber = 0;
            try
            {
                splitNumber = long.Parse(request.OperatePar);
            }
            catch (Exception ex)
            {
                Log.Error(ex.ToString());
                Log.Error($"C2M_ItemSplitRequest 1");
                response.Error = ErrorCode.ERR_ModifyData;
                reply();
                return;
            }
            
            if (splitNumber <= 0 )
            {
                Log.Error($"C2M_ItemSplitRequest 2");
                response.Error = ErrorCode.ERR_ModifyData;
                reply();
                return;
            }

            if (splitNumber >= useBagInfo.ItemNum )
            {
                Log.Error($"C2M_ItemSplitRequest 3");
                response.Error = ErrorCode.ERR_ModifyData;
                reply();
                return;
            }
            if (splitNumber >= 100000)
            {
                Log.Error($"C2M_ItemSplitRequest 4");
                response.Error = ErrorCode.ERR_ModifyData;
                reply();
                return;
            }

            useBagInfo.ItemNum -= (int)splitNumber;
            if (useBagInfo.ItemNum <= 0)
            {
                Log.Error($"C2M_ItemSplitRequest 5");
                response.Error = ErrorCode.ERR_ModifyData;
                reply();
                return;
            }
            unit.GetComponent<BagComponent>().OnAddItemDataNewCell(useBagInfo, (int)splitNumber);
            LogHelper.LogWarning($"道具拆分 {unit.DomainZone()} {unit.Id} {splitNumber}", true);

            M2C_RoleBagUpdate m2c_bagUpdate = new M2C_RoleBagUpdate();
            m2c_bagUpdate.BagInfoUpdate.Add(useBagInfo);
            MessageHelper.SendToClient(unit, m2c_bagUpdate);
            reply();
            await ETTask.CompletedTask;
        }
    }
}
