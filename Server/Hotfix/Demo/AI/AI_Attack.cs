using UnityEngine;

namespace ET
{

    [AIHandler]
    public class AI_Attack: AAIHandler
    {

        public override bool Check(AIComponent aiComponent, AIConfig aiConfig)
        {
            Unit target = aiComponent.DomainScene().GetComponent<UnitComponent>().Get(aiComponent.TargetID);
            if (target == null || target.IsDisposed)
            {
                aiComponent.TargetID = 0;
                return false;
            }

            float distance = Vector3.Distance(target.Position, aiComponent.GetParent<Unit>().Position);
            return distance <= aiComponent.ActDistance;
        }

        public override async ETTask Execute(AIComponent aiComponent, AIConfig aiConfig, ETCancellationToken cancellationToken)
        {
            Unit unit = aiComponent.GetParent<Unit>();
            //unit.Stop(-1);

            for (int i = 0; i < 100000; ++i)
            {
                long rigidityEndTime = 0;
                int skillId = aiComponent.GetActSkillId();

                Unit target = unit.DomainScene().GetComponent<UnitComponent>().Get(aiComponent.TargetID);
                if (target == null || !target.IsCanBeAttack())
                {
                    aiComponent.TargetID = 0;
                    return;
                }
                if (unit.GetComponent<SkillManagerComponent>().IsCanUseSkill (skillId) == ErrorCore.ERR_Success)
                {
                    Vector3 direction = target.Position - unit.Position;
                    float ange = Mathf.Rad2Deg(Mathf.Atan2(direction.x, direction.z));
                    C2M_SkillCmd cmd = aiComponent.c2M_SkillCmd;
                    //触发技能
                    cmd.TargetID = target.Id;
                    cmd.SkillID = skillId;
                    cmd.TargetAngle = Mathf.FloorToInt(ange);
                    cmd.TargetDistance = Vector3.Distance(unit.Position, target.Position);
                    unit.GetComponent<SkillManagerComponent>().OnUseSkill(cmd, true);
                    rigidityEndTime = (long)(SkillConfigCategory.Instance.Get(cmd.SkillID).SkillRigidity * 1000) + TimeHelper.ServerNow();
                }
                if (rigidityEndTime > unit.GetComponent<StateComponent>().RigidityEndTime)
                {
                    unit.GetComponent<StateComponent>().RigidityEndTime = rigidityEndTime;
                }

                // 因为协程可能被中断，任何协程都要传入cancellationToken，判断如果是中断则要返回
                bool timeRet = await TimerComponent.Instance.WaitAsync(1000, cancellationToken);
                if (!timeRet)
                {
                    return;
                }
            }
        }
    }
}