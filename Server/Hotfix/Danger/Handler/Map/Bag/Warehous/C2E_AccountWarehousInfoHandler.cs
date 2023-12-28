using System;
using System.Collections.Generic;

namespace ET
{

    [ActorMessageHandler]
    public class C2E_AccountWarehousInfoHandler : AMActorRpcHandler<Scene, C2E_AccountWarehousInfoRequest, E2C_AccountWarehousInfoResponse>
    {
        protected override async ETTask Run(Scene scene, C2E_AccountWarehousInfoRequest request, E2C_AccountWarehousInfoResponse response, Action reply)
        {
            using (await CoroutineLockComponent.Instance.Wait(CoroutineLockType.LoginAccount, request.AccInfoID))
            {
                DBAccountInfo dBAccountWarehouse = await DBHelper.GetComponentCache<DBAccountInfo>(scene.DomainZone(), request.AccInfoID);
                response.BagInfos = dBAccountWarehouse.BagInfoList;
                reply();
            }
            await ETTask.CompletedTask;
        }
    }
}
