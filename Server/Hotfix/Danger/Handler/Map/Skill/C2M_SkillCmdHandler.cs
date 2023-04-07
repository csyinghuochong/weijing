
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
                //int horseId = unit.GetComponent<NumericComponent>().GetAsInt(NumericType.HorseRide);
                unit.GetComponent<NumericComponent>().ApplyValue(NumericType.HorseRide, 0);
                M2C_SkillCmd m2C_SkillCmd = unit.GetComponent<SkillManagerComponent>().OnUseSkill(request, true);
                if (request.ItemId > 0 && m2C_SkillCmd.Error == ErrorCore.ERR_Success)
                {
                    unit.GetComponent<BagComponent>().OnCostItemData($"{request.ItemId};1");

                    if (ConfigHelper.ChengJiuLianJin.Contains(request.ItemId))
                    {
                        unit.GetComponent<ChengJiuComponent>().TriggerEvent(ChengJiuTargetEnum.BattleUseItem_214, 0, 1);
                    }
                }
                response.Error = m2C_SkillCmd.Error;
                response.Message = m2C_SkillCmd.Message;
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