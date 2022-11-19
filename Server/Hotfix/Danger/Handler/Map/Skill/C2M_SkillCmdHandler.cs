
using System;

namespace ET
{
    [ActorMessageHandler]
    public class C2M_SkillCmdHandler : AMActorLocationRpcHandler<Unit, C2M_SkillCmd, M2C_SkillCmd>
    {
        protected override async ETTask Run(Unit unit, C2M_SkillCmd request, M2C_SkillCmd response, Action reply)
        {
            try
            {
                int horseId = unit.GetComponent<NumericComponent>().GetAsInt(NumericType.Now_Horse);
                if (horseId > 0)
                {
                    unit.GetComponent<NumericComponent>().ApplyValue(NumericType.Now_Horse, 0);
                }
                if (request.ItemId == 0)
                {
                    unit.Stop(-1);
                }
                M2C_SkillCmd m2C_SkillCmd = unit.GetComponent<SkillManagerComponent>().OnUseSkill(request, true, false);
                if (request.ItemId > 0 && m2C_SkillCmd.Error == ErrorCore.ERR_Success)
                {
                    unit.GetComponent<BagComponent>().OnCostItemData($"{request.ItemId};1");
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