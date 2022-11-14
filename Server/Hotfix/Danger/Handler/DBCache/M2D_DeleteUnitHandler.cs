using System;

namespace ET
{
    public class M2D_DeleteUnitHandler : AMActorRpcHandler<Scene, M2D_DeleteUnit, D2M_DeleteUnit>
    {
        protected override async ETTask Run(Scene scene, M2D_DeleteUnit request, D2M_DeleteUnit response, Action reply)
        {
            DBCacheComponent unitCacheComponent = scene.GetComponent<DBCacheComponent>();
            unitCacheComponent.Delete(request.UnitId);
            reply();
            await ETTask.CompletedTask;
        }
    }
}
