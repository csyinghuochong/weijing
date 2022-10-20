
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
                int item = request.ItemId;
                if (item > 0)
                {
                    entity.GetComponent<BagComponent>().OnCostItemData($"{item};1");
                }
                else
                {
                    entity.Stop(entity.GetComponent<MoveComponent>().IsArrived() ? 0 : -2);
                }
                M2C_SkillCmd m2C_SkillCmd = entity.GetComponent<SkillManagerComponent>().OnUseSkill(request, true);
                response.Error = m2C_SkillCmd.Error;
                response.CDEndTime = m2C_SkillCmd.CDEndTime;
                response.PublicCDTime = m2C_SkillCmd.PublicCDTime;

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