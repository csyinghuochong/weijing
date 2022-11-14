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

                Components.Add(await db.Get<UserInfoComponent>(request.CharacterId));
                Components.Add(await db.Get<BagComponent>(request.CharacterId));
                Components.Add(await db.Get<TaskComponent>(request.CharacterId));
                Components.Add(await db.Get<ChengJiuComponent>(request.CharacterId));
                Components.Add(await db.Get<PetComponent>(request.CharacterId));
                Components.Add(await db.Get<SkillSetComponent>(request.CharacterId));
                Components.Add(await db.Get<EnergyComponent>(request.CharacterId));
                Components.Add(await db.Get<ActivityComponent>(request.CharacterId));
                Components.Add(await db.Get<ShoujiComponent>(request.CharacterId));
         
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