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
                Entity entity = null;
                switch (request.Component)
                {
                    case DBHelper.UserInfoComponent:
                        entity = await db.Query<UserInfoComponent>(request.CharacterId);
                        break;
                    case DBHelper.BagComponent:
                        entity = await db.Query<BagComponent>(request.CharacterId);
                        break;
                    case DBHelper.TaskComponent:
                        entity = await db.Query<TaskComponent>(request.CharacterId);
                        break;
                    case DBHelper.ChengJiuComponent:
                        entity = await db.Query<ChengJiuComponent>(request.CharacterId);
                        break;
                    case DBHelper.PetComponent:
                        entity = await db.Query<PetComponent>(request.CharacterId);
                        break;
                    case DBHelper.SkillSetComponent:
                        entity = await db.Query<SkillSetComponent>(request.CharacterId);
                        break;
                    case DBHelper.EnergyComponent:
                        entity = await db.Query<EnergyComponent>(request.CharacterId);
                        break;
                    case DBHelper.ActivityComponent:
                        entity = await db.Query<ActivityComponent>(request.CharacterId);
                        break;
                    case DBHelper.NumericComponent:
                        entity = await db.Query<NumericComponent>(request.CharacterId);
                        break;
                    case DBHelper.RechargeComponent:
                        entity = await db.Query<RechargeComponent>(request.CharacterId);
                        break;
                    case DBHelper.ReddotComponent:
                        entity = await db.Query<ReddotComponent>(request.CharacterId);
                        break;
                    case DBHelper.ShoujiComponent:
                        entity = await db.Query<ShoujiComponent>(request.CharacterId);
                        break;
                    case DBHelper.DBFriendInfo:
                        entity = await db.Query<DBFriendInfo>(request.CharacterId);
                        break;
                    case DBHelper.DBMailInfo:
                        entity = await db.Query<DBMailInfo>(request.CharacterId);
                        break;
                    case DBHelper.DBServerInfo:
                        entity = await db.Query<DBServerInfo>(request.CharacterId);
                        break;
                    case DBHelper.DBAccountInfo:
                        entity = await db.Query<DBAccountInfo>(request.CharacterId);
                        break;
                    case DBHelper.DBRankInfo:
                        entity = await db.Query<DBRankInfo>(request.CharacterId);
                        break;
                    case DBHelper.DBPaiMainInfo:
                        entity = await db.Query<DBPaiMainInfo>(request.CharacterId);
                        break;
                    case DBHelper.DBDayActivityInfo:
                        entity = await db.Query<DBDayActivityInfo>(request.CharacterId);
                        break;
                    case DBHelper.DBUnionInfo:
                        entity = await db.Query<DBUnionInfo>(request.CharacterId);
                        break;
                    case DBHelper.DBCenterAccountInfo:
                        entity = await db.Query<DBCenterAccountInfo>(request.CharacterId);
                        break;
                }
                
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