using System;

namespace ET
{
    public class G2D_SaveUnitHandler : AMActorRpcHandler<Scene, M2D_SaveUnit,D2M_SaveUnit>
    {
        protected override async ETTask Run(Scene scene, M2D_SaveUnit request, D2M_SaveUnit response, Action reply)
        {
            try
            {
                DBCacheComponent db = scene.Domain.GetComponent<DBCacheComponent>();
               
                for (int i = 0; i < request.Components.Count; i++)
                {
                    string str =  request.Components[i].ToString();

                    if(str.Contains(DBHelper.UserInfoComponent))
                    {
                        await db.Save<UserInfoComponent>(request.Components[i] as UserInfoComponent);
                        continue;
                    }
                    if (str.Contains(DBHelper.BagComponent))
                    {
                        await db.Save<BagComponent>(request.Components[i] as BagComponent);
                        continue;
                    }
                    if (str.Contains(DBHelper.TaskComponent))
                    {
                        await db.Save<TaskComponent>(request.Components[i] as TaskComponent);
                        continue;
                    }
                    if (str.Contains(DBHelper.ChengJiuComponent))
                    {
                        await db.Save<ChengJiuComponent>(request.Components[i] as ChengJiuComponent);
                        continue;
                    }
                    if (str.Contains(DBHelper.PetComponent))
                    {
                        await db.Save<PetComponent>(request.Components[i] as PetComponent);
                        continue;
                    }
                    if (str.Contains(DBHelper.SkillSetComponent))
                    {
                        await db.Save<SkillSetComponent>(request.Components[i] as SkillSetComponent);
                        continue;
                    }
                    if (str.Contains(DBHelper.EnergyComponent))
                    {
                        await db.Save<EnergyComponent>(request.Components[i] as EnergyComponent);
                        continue;
                    }
                    if (str.Contains(DBHelper.ActivityComponent))
                    {
                        await db.Save<ActivityComponent>(request.Components[i] as ActivityComponent);
                        continue;
                    }
                    if (str.Contains(DBHelper.NumericComponent))
                    {
                        await db.Save<NumericComponent>(request.Components[i] as NumericComponent);
                        continue;
                    }
                    if (str.Contains(DBHelper.RechargeComponent))
                    {
                        await db.Save<RechargeComponent>(request.Components[i] as RechargeComponent);
                        continue;
                    }
                    if (str.Contains(DBHelper.ReddotComponent))
                    {
                        await db.Save<ReddotComponent>(request.Components[i] as ReddotComponent);
                        continue;
                    }
                    if (str.Contains(DBHelper.ShoujiComponent))
                    {
                        await db.Save<ShoujiComponent>(request.Components[i] as ShoujiComponent);
                        continue;
                    }
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