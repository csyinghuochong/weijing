using UnityEngine;

namespace ET
{

    [AIHandler]
    public class AI_JingLing : AAIHandler
    {

        public override bool Check(AIComponent aiComponent, AIConfig aiConfig)
        {
            return true;
        }

        public static Vector3 GetFollowPosition(Unit unit, Unit master)
        {
            Vector3 dir = (unit.Position - master.Position).normalized;
            Vector3 tar = master.Position + dir * Vector3.forward;
            return tar;
        }

        public override async ETTask Execute(AIComponent aiComponent, AIConfig aiConfig, ETCancellationToken cancellationToken)
        {
            Unit unit = aiComponent.GetParent<Unit>();
            long unitId = unit.GetComponent<NumericComponent>().GetAsLong(NumericType.MasterId);
            Unit master = aiComponent.DomainScene().GetComponent<UnitComponent>().Get(unitId);

            while (true)
            {
                float distacne = Vector3.Distance(unit.Position, master.Position);
                if (distacne > 6f)
                {
                    Vector3 nextTarget = GetFollowPosition(unit, master);
                    unit.GetComponent<NumericComponent>().Set(NumericType.Now_Speed, 60000);
                    unit.FindPathMoveToAsync(nextTarget, cancellationToken, false).Coroutine();
                }
                else if (distacne > 1.1f)
                {
                    Vector3 nextTarget = GetFollowPosition(unit, master);
                    unit.GetComponent<NumericComponent>().Set(NumericType.Now_Speed, 30000);
                    unit.FindPathMoveToAsync(nextTarget, cancellationToken, false).Coroutine();
                }

                await TimerComponent.Instance.WaitAsync(200, cancellationToken);
            }
        }
    }
}