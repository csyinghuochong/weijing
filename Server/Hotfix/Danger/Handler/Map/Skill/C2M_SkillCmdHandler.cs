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
                int juexingid = 0;
                int occtwo = unit.GetComponent<UserInfoComponent>().UserInfo.OccTwo;
                if (occtwo != 0)
                {
                    OccupationTwoConfig occupationConfig = OccupationTwoConfigCategory.Instance.Get(occtwo);
                    juexingid = occupationConfig.JueXingSkill[7];
                }
                if (juexingid == request.SkillID)
                {
                    if (unit.GetComponent<NumericComponent>().GetAsLong(NumericType.JueXingAnger) < 500)
                    {
                        response.Error = ErrorCode.Error_AngleNotEnough;
                        reply();
                        await ETTask.CompletedTask;
                        return;
                    }
                }

                unit.GetComponent<DBSaveComponent>().NoFindPath = 0;
                unit.GetComponent<NumericComponent>().ApplyValue(NumericType.HorseRide, 0, true, true);
                M2C_SkillCmd m2C_SkillCmd = unit.GetComponent<SkillManagerComponent>().OnUseSkill(request, true);

                if (m2C_SkillCmd.Error == ErrorCode.ERR_Success)
                {
                    if (request.ItemId > 0)
                    {
                        unit.GetComponent<BagComponent>().OnCostItemData($"{request.ItemId};1");

                        if (ConfigHelper.ChengJiuLianJin.Contains(request.ItemId))
                        {
                            unit.GetComponent<ChengJiuComponent>().TriggerEvent(ChengJiuTargetEnum.BattleUseItem_214, 0, 1);
                            unit.GetComponent<TaskComponent>().TriggerTaskEvent(TaskTargetType.BattleUseItem_30, 0, 1);
                            unit.GetComponent<TaskComponent>().TriggerTaskCountryEvent(TaskCountryTargetType.BattleUseItem_30, 0, 1);
                        }
                    }
                    if (juexingid == request.SkillID)
                    {
                        unit.GetComponent<NumericComponent>().ApplyValue(NumericType.JueXingAnger, 0);
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