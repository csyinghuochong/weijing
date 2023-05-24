using System;
using System.Collections.Generic;

namespace ET
{
    [ActorMessageHandler]
    public class C2M_ItemInheritSelectHandler : AMActorLocationRpcHandler<Unit, C2M_ItemInheritSelectRequest, M2C_ItemInheritSelectResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_ItemInheritSelectRequest request, M2C_ItemInheritSelectResponse response, Action reply)
        {
            BagInfo bagInfo = unit.GetComponent<BagComponent>().GetItemByLoc(ItemLocType.ItemLocBag, request.OperateBagID);
            if (bagInfo == null)
            {
                response.Error = ErrorCore.ERR_ItemNotExist;
                reply();
                return;
            }
            bagInfo.InheritSkills = unit.GetComponent<BagComponent>().InheritSkills;

            //通知客户端背包道具发生改变
            M2C_RoleBagUpdate m2c_bagUpdate = new M2C_RoleBagUpdate();
            m2c_bagUpdate.BagInfoUpdate = new List<BagInfo>();
            m2c_bagUpdate.BagInfoUpdate.Add(bagInfo);
            MessageHelper.SendToClient(unit, m2c_bagUpdate);

            reply();
            await ETTask.CompletedTask;
        }
    }
}
