using UnityEngine;

namespace ET
{
    [AIHandler]
    public class AI_Retreat : AAIHandler
    {

        public override bool Check(AIComponent aiComponent, AIConfig aiConfig)
        {
            float distance =  PositionHelper.Distance2D(aiComponent.BornPostion, aiComponent.GetParent<Unit>().Position);
            return distance >= aiComponent.ChaseRange;
        }

        public override async ETTask Execute(AIComponent aiComponent, AIConfig aiConfig, ETCancellationToken cancellationToken)
        {
            aiComponent.TargetID = 0;
            aiComponent.IsRetreat = true;
            Unit unit = aiComponent.GetParent<Unit>();
            unit.Stop(0);
            await unit.FindPathMoveToAsync(aiComponent.BornPostion, cancellationToken, true);
            aiComponent.IsRetreat = false;
        }
    }
}
