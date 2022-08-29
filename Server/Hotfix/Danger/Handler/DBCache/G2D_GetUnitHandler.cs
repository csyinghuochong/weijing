using System;
using System.Collections.Generic;

namespace ET
{
    public class G2D_GetUnitHandler : AMActorRpcHandler<Scene, G2D_GetUnit,D2G_GetUnit>
    {
        protected override async ETTask Run(Scene scene, G2D_GetUnit request, D2G_GetUnit response, Action reply)
        {
            try
            {
                DBCacheComponent db = scene.Domain.GetComponent<DBCacheComponent>();
                List<Entity> Components = new List<Entity>();

                Components.Add(await db.Query<UserInfoComponent>(request.CharacterId));
                Components.Add(await db.Query<BagComponent>(request.CharacterId));
                Components.Add(await db.Query<TaskComponent>(request.CharacterId));
                Components.Add(await db.Query<ChengJiuComponent>(request.CharacterId));
                Components.Add(await db.Query<PetComponent>(request.CharacterId));
                Components.Add(await db.Query<SkillSetComponent>(request.CharacterId));
                Components.Add(await db.Query<EnergyComponent>(request.CharacterId));
                Components.Add(await db.Query<ActivityComponent>(request.CharacterId));
                Components.Add(await db.Query<ShoujiComponent>(request.CharacterId));
         
                response.Components = Components;
                reply();
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