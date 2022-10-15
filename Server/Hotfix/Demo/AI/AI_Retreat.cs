using UnityEngine;

namespace ET
{
    [AIHandler]
    public class AI_Retreat : AAIHandler
    {

        public override bool Check(AIComponent aiComponent, AIConfig aiConfig)
        {
            Unit unit = aiComponent.GetParent<Unit>();
            float distance =  PositionHelper.Distance2D(unit.GetComponent<HeroDataComponent>().GetBornPostion(), unit.Position);
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
            Vector3 bornVector3 = unit.GetComponent<HeroDataComponent>().GetBornPostion();

            while (true)
            {

                if (unit.GetComponent<StateComponent>().CanMove())
                {
                    unit.FindPathMoveToAsync(bornVector3, cancellationToken, true).Coroutine();
                }
                bool timeRet = await TimerComponent.Instance.WaitAsync(1000, cancellationToken);
                if (!timeRet || Vector3.Distance(bornVector3, unit.Position) < 0.5f)
                {
                    aiComponent.IsRetreat = false;
                    return;
                }
            }
        }
    }
}
