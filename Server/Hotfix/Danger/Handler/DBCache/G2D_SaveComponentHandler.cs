using System;

namespace ET
{
    public class G2D_SaveComponentHandler : AMActorRpcHandler<Scene, M2D_SaveComponent,D2M_SaveComponent>
    {
        protected override async ETTask Run(Scene scene, M2D_SaveComponent request, D2M_SaveComponent response, Action reply)
        {
            try
            {
                DBCacheComponent db = scene.Domain.GetComponent<DBCacheComponent>();
                db.AddOrUpdate(request.UnitId, MongoHelper.Deserialize<Entity>(request.EntityByte)).Coroutine();
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