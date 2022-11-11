using UnityEngine;

namespace ET
{
    [AIHandler]
    public class AI_Target : AAIHandler
    {
        public override bool Check(AIComponent aiComponent, AIConfig aiConfig)
        {
            if (aiComponent.TargetID != 0)
            {
                return false;
            }
            if (aiComponent.TargetPoint.Count == 0)
            {
                return false;
            }
            Unit unit = aiComponent.GetParent<Unit>();
            Unit nearest = AIHelp.GetNearestEnemy(unit, aiComponent.ActRange);
            if (nearest!= null  && !aiComponent.IsRetreat)
            {
                aiComponent.TargetZhuiJi = unit.Position;
                aiComponent.TargetID = nearest.Id;
                return false;
            }
            return true;
        }

        public override async ETTask Execute(AIComponent aiComponent, AIConfig aiConfig, ETCancellationToken cancellationToken)
        {
            Unit unit = aiComponent.GetParent<Unit>();

            while (true)
            {
                if (aiComponent.TargetPoint.Count == 0)
                {
                    return;
                }
                Vector3 target = aiComponent.TargetPoint[0];
                float distance = Vector3.Distance(target, unit.Position);
                if (distance < 0.5f)
                {
                    aiComponent.TargetPoint.RemoveAt(0);
                    continue;
                }
                if (unit.GetComponent<StateComponent>().CanMove())
                {
                   unit.FindPathMoveToAsync(target, cancellationToken, false).Coroutine();
                }
                bool timeRet = await TimerComponent.Instance.WaitAsync(1000, cancellationToken);
                if (!timeRet)
                {
                    return;
                }
            }
        }
    }
}