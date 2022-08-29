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

                switch (request.ComponentType)
                {
                    case DBHelper.UserInfoComponent:
                        await db.Save<UserInfoComponent>(request.Component as UserInfoComponent);
                        break;
                    case DBHelper.BagComponent:
                        await db.Save<BagComponent>(request.Component as BagComponent);
                        break;
                    case DBHelper.TaskComponent:
                        await db.Save<TaskComponent>(request.Component as TaskComponent);
                        break;
                    case DBHelper.ChengJiuComponent:
                        await db.Save<ChengJiuComponent>(request.Component as ChengJiuComponent);
                        break;
                    case DBHelper.PetComponent:
                        await db.Save<PetComponent>(request.Component as PetComponent);
                        break;
                    case DBHelper.SkillSetComponent:
                        await db.Save<SkillSetComponent>(request.Component as SkillSetComponent);
                        break;
                    case DBHelper.EnergyComponent:
                        await db.Save<EnergyComponent>(request.Component as EnergyComponent);
                        break;
                    case DBHelper.ActivityComponent:
                        await db.Save<ActivityComponent>(request.Component as ActivityComponent);
                        break;
                    case DBHelper.NumericComponent:
                        await db.Save<NumericComponent>(request.Component as NumericComponent);
                        break;
                    case DBHelper.RechargeComponent:
                        await db.Save<RechargeComponent>(request.Component as RechargeComponent);
                        break;
                    case DBHelper.ReddotComponent:
                        await db.Save<ReddotComponent>(request.Component as ReddotComponent);
                        break;
                    case DBHelper.ShoujiComponent:
                        await db.Save<ShoujiComponent>(request.Component as ShoujiComponent);
                        break;
                    case DBHelper.DBFriendInfo:
                        await db.Save<DBFriendInfo>(request.Component as DBFriendInfo);
                        break;
                    case DBHelper.DBMailInfo:
                        await db.Save<DBMailInfo>(request.Component as DBMailInfo);
                        break;
                    case DBHelper.DBServerInfo:
                        await db.Save<DBServerInfo>(request.Component as DBServerInfo);
                        break;
                    case DBHelper. DBAccountInfo:
                        await db.Save<DBAccountInfo>(request.Component as DBAccountInfo);
                        break;
                    case DBHelper.DBRankInfo:
                        await db.Save<DBRankInfo>(request.Component as DBRankInfo);
                        break;
                    case DBHelper.DBPaiMainInfo:
                        await db.Save<DBPaiMainInfo>(request.Component as DBPaiMainInfo);
                        break;
                    case DBHelper.DBDayActivityInfo:
                        await db.Save<DBDayActivityInfo>(request.Component as DBDayActivityInfo);
                        break;
                    case DBHelper.DBUnionInfo:
                        await db.Save<DBUnionInfo>(request.Component as DBUnionInfo);
                        break;
                    case DBHelper.DBCenterAccountInfo:
                        await db.Save<DBCenterAccountInfo>(request.Component as DBCenterAccountInfo);
                        break;
                }
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