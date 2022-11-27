using UnityEngine;


namespace ET
{

    [AIHandler]
    public class AI_Tower : AAIHandler
    {

        public override bool Check(AIComponent aiComponent, AIConfig aiConfig)
        {
            return true;
        }

        public override async ETTask Execute(AIComponent aiComponent, AIConfig aiConfig, ETCancellationToken cancellationToken)
        {
            Unit unit = aiComponent.GetParent<Unit>();
            MonsterConfig monsterCof = MonsterConfigCategory.Instance.Get(unit.ConfigId);

            for (int i = 0; i < 100000; ++i)
            {
                if (unit.IsDisposed)
                    return;

                C2M_SkillCmd cmd = new C2M_SkillCmd();
                cmd.SkillID = monsterCof.ActSkillID;
                //技能释放角度
                cmd.TargetAngle = int.Parse(monsterCof.AIParameter);

                //触发技能
                unit.GetComponent<SkillManagerComponent>().OnUseSkill(cmd, true);
                bool timeRet = await TimerComponent.Instance.WaitAsync(1000, cancellationToken);
                if (!timeRet)
                {
                    return;
                }
            }
        }

    }

}