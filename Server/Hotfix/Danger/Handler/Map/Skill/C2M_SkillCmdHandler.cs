using System;
using System.Collections.Generic;

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
                        return;
                    }
                }

                if (!SkillConfigCategory.Instance.Contain(request.SkillID))
                {
                    response.Error = ErrorCode.ERR_ModifyData;
                    reply();
                    return;
                }

                if (request.ItemId > 0)
                { 
                    if(unit.GetComponent<BagComponent>().GetItemNumber(request.ItemId) <= 0)
                    {
                        response.Error = ErrorCode.ERR_ModifyData;
                        reply();
                        return;
                    }
                    if (!ItemConfigCategory.Instance.Contain(request.ItemId))
                    {
                        response.Error = ErrorCode.ERR_ModifyData;
                        reply();
                        return;
                    }


                    ItemConfig itemConfig = ItemConfigCategory.Instance.Get(request.ItemId);
                    if (itemConfig.ItemSubType != 101 && itemConfig.ItemSubType != 110)
                    {
                        Console.WriteLine($"request.SkillID error:  {request.SkillID}");
                        response.Error = ErrorCode.ERR_ModifyData;
                        reply();
                        return;
                    }
                }

                SkillConfig skillConfig = SkillConfigCategory.Instance.Get(request.SkillID);
                if (unit.GetComponent<SkillSetComponent>().GetBySkillID(request.SkillID) == null
                    && request.SkillID != 60000011 && skillConfig.SkillActType!= 0 && request.ItemId == 0)
                {
                    Console.WriteLine($"request.SkillID==null:  {request.SkillID}   {unit.DomainZone()}  {unit.Id}");
                    response.Error = ErrorCode.ERR_ModifyData;
                    reply();
                    return;
                }

                unit.GetComponent<DBSaveComponent>().NoFindPath = 0;
                unit.GetComponent<NumericComponent>().ApplyValue(NumericType.HorseRide, 0, true, true);
                SkillManagerComponent skillManagerComponent = unit.GetComponent<SkillManagerComponent>();   
                M2C_SkillCmd m2C_SkillCmd = skillManagerComponent.OnUseSkill(request, true);

                if (skillManagerComponent.SkillSecond.ContainsKey(request.SkillID))
                {
                    int buffId = (int)SkillConfigCategory.Instance.BuffSecondSkill[skillManagerComponent.SkillSecond[request.SkillID]].KeyId;

                    List<Unit> allDefend = unit.GetParent<UnitComponent>().GetAll();
                    for (int defend = 0; defend < allDefend.Count; defend++)
                    {
                        BuffManagerComponent buffManagerComponent = allDefend[defend].GetComponent<BuffManagerComponent>();
                        if (buffManagerComponent == null || allDefend[defend].Id == request.TargetID || allDefend[defend].Id == unit.Id)
                        {
                            continue;
                        }
                        int buffNum = buffManagerComponent.GetBuffSourceNumber(unit.Id, buffId);
                        if (buffNum <= 0)
                        {
                            continue;
                        }
                        request.TargetID = allDefend[defend].Id;
                        buffManagerComponent.BuffRemoveByUnit(0, buffId);
                        unit.GetComponent<SkillManagerComponent>().OnUseSkill(request, false);
                    }
                }

                if (m2C_SkillCmd.Error == ErrorCode.ERR_Success)
                {
                    if (request.ItemId > 0)
                    {
                        unit.GetComponent<BagComponent>().OnCostItemData($"{request.ItemId};1");

                        if (ConfigHelper.ChengJiuLianJin.Contains(request.ItemId))
                        {
                            unit.GetComponent<ChengJiuComponent>().TriggerEvent(ChengJiuTargetEnum.BattleUseItem_214, 0, 1);
                            unit.GetComponent<TaskComponent>().TriggerTaskEvent(TaskTargetType.BattleUseItem_30, 0, 1);
                            unit.GetComponent<TaskComponent>().TriggerTaskCountryEvent(TaskTargetType.BattleUseItem_30, 0, 1);
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