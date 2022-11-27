using UnityEngine;

namespace ET
{

    [AIHandler]
    public class AI_SceneBuff : AAIHandler
    {
        public override bool Check(AIComponent aiComponent, AIConfig aiConfig)
        {
            return true;
        }

        public override async ETTask Execute(AIComponent aiComponent, AIConfig aiConfig, ETCancellationToken cancellationToken)
        {
            Unit unit = aiComponent.GetParent<Unit>();
            MonsterConfig monsterCof = MonsterConfigCategory.Instance.Get(unit.ConfigId);
            SkillConfig skillConfig = SkillConfigCategory.Instance.Get(monsterCof.ActSkillID);

            bool remove = false;
            long instanceId = aiComponent.InstanceId;
            for (int i = 0; i < 100000; ++i)
            {
                Unit target = AIHelp.GetNearestEnemy(unit);

                //检测目标是否在技能范围
                if (!remove &&  target != null && Vector3.Distance(unit.Position, target.Position) <= skillConfig.SkillRangeSize)
                {
                    remove = true;
                    Vector3 direction = target.Position - unit.Position;
                    float ange = Mathf.Rad2Deg(Mathf.Atan2(direction.x, direction.z));

                    C2M_SkillCmd cmd = new C2M_SkillCmd();
                    cmd.SkillID = monsterCof.ActSkillID;
                    cmd.TargetID = target.Id;
                    cmd.TargetAngle = Mathf.FloorToInt(ange);
                    cmd.TargetDistance = Vector3.Distance(unit.Position, target.Position);
                    //触发技能
                    unit.GetComponent<SkillManagerComponent>().OnUseSkill(cmd, true);
                }

                await TimerComponent.Instance.WaitAsync(300, cancellationToken);
                if (instanceId != aiComponent.InstanceId)
                {
                    return;
                }
                if (remove)
                {
                    unit.DomainScene().GetComponent<UnitComponent>().Remove(unit.Id);
                    return;
                }
            }
        }
    }
}
