
using System;
using UnityEngine;

namespace ET
{
    [ActorMessageHandler]
    public class C2M_SkillCmdHandler : AMActorLocationRpcHandler<Unit, C2M_SkillCmd, M2C_SkillCmd>
    {
        protected override async ETTask Run(Unit entity, C2M_SkillCmd request, M2C_SkillCmd response, Action reply)
        {
            try
            {
                entity.Stop(entity.GetComponent<MoveComponent>().IsArrived() ? 0 : -2);
                (int, long) result =  entity.GetComponent<SkillManagerComponent>().OnUseSkill(request);
                response.Error = result.Item1;
                response.CDEndTime = result.Item2;

                reply();
                await ETTask.CompletedTask;
            }
            catch (Exception ex)
            {
                Log.Debug(ex.ToString());
            }
        }

    }
}