using System;
using System.Collections.Generic;

namespace ET
{
    [ActorMessageHandler]
    public class Actor_FubenEnergySkillHandler : AMActorLocationRpcHandler<Unit, Actor_FubenEnergySkillRequest, Actor_FubenEnergySkillResponse>
    {

        protected override async ETTask Run(Unit unit, Actor_FubenEnergySkillRequest request, Actor_FubenEnergySkillResponse response, Action reply)
        {
            //扣除对应道具
            bool costStatus = unit.GetComponent<BagComponent>().OnCostItemData("12000006;5");

            if (costStatus)
            {
                List<int> skills = new List<int>();
                foreach ((long id, Entity value) in unit.GetParent<UnitComponent>().Children)
                {
                    int e_skillid = value.GetComponent<UnitInfoComponent>().EnergySkillId;
                    if (e_skillid != 0)
                    {
                        skills.Add(e_skillid);
                    }
                }
                C2M_SkillCmd cmd = new C2M_SkillCmd();
                cmd.SkillID = skills[RandomHelper.RandomNumber(0, skills.Count)];
                cmd.TargetAngle = 0;
                cmd.TargetID = unit.Id;
                unit.GetComponent<SkillManagerComponent>().OnUseSkill(cmd, true);
            }
            else {
                response.Error = ErrorCore.ERR_ItemNotEnoughError;
            }
            reply();
            await ETTask.CompletedTask;
        }
    }
}
