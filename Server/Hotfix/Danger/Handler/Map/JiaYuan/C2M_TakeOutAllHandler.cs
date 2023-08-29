using System;
using System.Collections.Generic;

namespace ET
{
    [ActorMessageHandler]
    public class C2M_TakeOutAllHandler: AMActorLocationRpcHandler<Unit, C2M_TakeOutAllRequest, M2C_TakeOutAllResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_TakeOutAllRequest request, M2C_TakeOutAllResponse response, Action reply)
        {
            int hourseId = request.HorseId;
            int leftBagSpace = unit.GetComponent<BagComponent>().GetLeftSpace();
            if (leftBagSpace <= 0)
            {
                response.Error = ErrorCode.ERR_BagIsFull; //错误码:仓库已满
                reply();
                return;
            }

            List<BagInfo> storeLists = new List<BagInfo>();
            M2C_RoleBagUpdate m2c_bagUpdate = new M2C_RoleBagUpdate();

            // 要值传递!!!，上课教的都忘了
            storeLists.AddRange(unit.GetComponent<BagComponent>().GetItemByLoc((ItemLocType)hourseId));

            for (int i = 0; i < storeLists.Count; i++)
            {
                unit.GetComponent<BagComponent>().OnChangeItemLoc(storeLists[i], ItemLocType.ItemLocBag, (ItemLocType)hourseId);
                m2c_bagUpdate.BagInfoUpdate.Add(storeLists[i]);
                leftBagSpace--;
                if (leftBagSpace <= 0)
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