
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
                M2C_SkillCmd m2C_SkillCmd = entity.GetComponent<SkillManagerComponent>().OnUseSkill(request, true);
                if (item > 0 && m2C_SkillCmd.Error == ErrorCore.ERR_Success)
                {
                    entity.GetComponent<BagComponent>().OnCostItemData($"{item};1");
                }
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