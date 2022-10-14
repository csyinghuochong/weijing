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
            Unit unit = aiComponent.GetParent<Unit>();
            if (aiComponent.IsBoss)
            {
                unit.GetComponent<NumericComponent>().ApplyValue(NumericType.BossInCombat, 0);
            }
            aiComponent.TargetID = 0;
            aiComponent.IsRetreat = true;
            unit.Stop(0);

            while (true)
            {
                if (unit.GetComponent<StateComponent>().CanMove())
                {
                    unit.FindPathMoveToAsync(aiComponent.BornPostion, cancellationToken, true).Coroutine();
                }
                bool timeRet = await TimerComponent.Instance.WaitAsync(1000, cancellationToken);
                if (!timeRet || Vector3.Distance(aiComponent.BornPostion, unit.Position) < 0.5f)
                {
                    aiComponent.IsRetreat = false;
                    return;
                }
            }
        }
    }
}
