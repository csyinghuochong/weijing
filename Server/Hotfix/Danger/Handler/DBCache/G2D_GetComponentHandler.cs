using System;

namespace ET
{
    public class G2D_GetComponentHandler : AMActorRpcHandler<Scene, G2D_GetComponent,D2G_GetComponent>
    {
        protected override async ETTask Run(Scene scene, G2D_GetComponent request, D2G_GetComponent response, Action reply)
        {
            try
            {
                DBCacheComponent db = scene.Domain.GetComponent<DBCacheComponent>();
                Entity entity = await db.Get(request.UnitId, request.Component);
                response.Component = entity;
                
                reply();
                await ETTask.CompletedTask;
            }
            catch (Exception e)
            {
                response.Error = ErrorCore.ERR_Error;
                response.Message = e.ToString();
                reply();
            }
        }
    }
}