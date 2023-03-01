using UnityEngine;

namespace ET
{

    [AIHandler]
    public class AI_TargetRetreat : AAIHandler
    {
        public override bool Check(AIComponent aiComponent, AIConfig aiConfig)
        {
            Unit unit = aiComponent.GetParent<Unit>();
            if (aiComponent.TargetZhuiJi == Vector3.zero)
            {
                return false;
            }
            float distance = PositionHelper.Distance2D(aiComponent.TargetZhuiJi, unit.Position);
            return !aiComponent.IsRetreat && distance >= aiComponent.ChaseRange;
        }

        public override async ETTask Execute(AIComponent aiComponent, AIConfig aiConfig, ETCancellationToken cancellationToken)
        {
            Unit unit = aiComponent.GetParent<Unit>();
            if (unit.IsBoss())
            {
                unit.GetComponent<NumericComponent>().ApplyValue(NumericType.BossInCombat, 0);
                unit.GetComponent<AttackRecordComponent>().BeAttackPlayerList.Clear();
            }
            aiComponent.TargetID = 0;
            aiComponent.IsRetreat = true;
            unit.Stop(0);
            await ETTask.CompletedTask;
        }
    }
}
