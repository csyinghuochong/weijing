using System;

namespace ET
{
    public class G2D_SaveUnitHandler : AMActorRpcHandler<Scene, M2D_SaveUnit,D2M_SaveUnit>
    {
        protected override async ETTask Run(Scene scene, M2D_SaveUnit request, D2M_SaveUnit response, Action reply)
        {
            try
            {
                UpdateUnitCacheAsync(scene, request, response).Coroutine();
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


        private async ETTask UpdateUnitCacheAsync(Scene scene, M2D_SaveUnit request, D2M_SaveUnit response)
        {
            DBCacheComponent unitCacheComponent = scene.Domain.GetComponent<DBCacheComponent>();
            using (ListComponent<Entity> entityList = ListComponent<Entity>.Create())
            {
                for (int index = 0; index < request.EntityTypes.Count; ++index)
                {
                    Type type = Game.EventSystem.GetType(request.EntityTypes[index]);
                    Entity entity = (Entity)MongoHelper.FromBson(type, request.EntityBytes[index]);
                    entityList.Add(entity);
                }
                await unitCacheComponent.AddOrUpdate(request.UnitId, entityList);
            }

            if (request.UnitId == 1603809198615887872)
            {
                Log.Debug($"缓存数据： {unitCacheComponent.UnitCaches.Count}") ;
            }
        }

    }
}