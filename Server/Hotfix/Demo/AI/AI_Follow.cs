using UnityEngine;

namespace ET
{

    [AIHandler]
    public class AI_Follow : AAIHandler
    {

        public override bool Check(AIComponent aiComponent, AIConfig aiConfig)
        {
            Unit unit = aiComponent.GetParent<Unit>();
            long unitId = unit.GetComponent<NumericComponent>().GetAsLong(NumericType.Master_ID);
            Unit master = aiComponent.DomainScene().GetComponent<UnitComponent>().Get(unitId);
            if (master == null)
            {
                return false;
            }
            
            float distance = Vector3.Distance(unit.Position, master.Position);
            if (distance > aiComponent.ActRange)
            {
                aiComponent.TargetID = 0;
                return true;
            }
            Unit nearest = AIHelp.GetNearestEnemy(unit);
            if (nearest == null)
            {
                aiComponent.TargetID = 0;
                return true;
            }
            distance = Vector3.Distance(unit.Position, nearest.Position);
            if (distance < aiComponent.ActRange)
            {
                aiComponent.TargetID = nearest.Id;
            }
            else
            {
                aiComponent.TargetID = 0;
            }

            return aiComponent.TargetID == 0;
        }

        public static Vector3 GetFollowPosition(Unit ai, Unit master)
        {
            Vector3 cur = ai.Position;
            Vector3 tar = master.Position;
            Vector3 dir = (cur - tar).normalized;
            tar = tar + (1f * dir);
            return tar;
        }


        public override async ETTask Execute(AIComponent aiComponent, AIConfig aiConfig, ETCancellationToken cancellationToken)
        {
            Unit unit = aiComponent.GetParent<Unit>();
            long unitId = unit.GetComponent<NumericComponent>().GetAsLong(NumericType.Master_ID);
            Unit master = aiComponent.DomainScene().GetComponent<UnitComponent>().Get(unitId);

            while (true)
            {
                if (Vector3.Distance(unit.Position, master.Position) > 1.1f)
                {
                    Vector3 nextTarget = GetFollowPosition(unit, master);
                    unit.FindPathMoveToAsync(nextTarget, cancellationToken, true).Coroutine();
                }

                bool timeRet = await TimerComponent.Instance.WaitAsync(500, cancellationToken);
                if (!timeRet)
                {
                    return;
                }
            }
        }
    }
}