using UnityEngine;

namespace ET
{

    [AIHandler]
    public class AI_Pull : AAIHandler
    {
        public override bool Check(AIComponent aiComponent, AIConfig aiConfig)
        {
            return aiComponent.TargetPoint.Count > 0;
        }

        public override async ETTask Execute(AIComponent aiComponent, AIConfig aiConfig, ETCancellationToken cancellationToken)
        {
            Unit unit = aiComponent.GetParent<Unit>();
            float limitDis = 0.5f;

            for (int i = 0; i < 10000; i++)
            {
                if (aiComponent.TargetPoint.Count == 0)
                {
                    break;
                }

                Vector3 targetPosition = aiComponent.TargetPoint[0];
                float distance = Vector3.Distance(unit.Position, targetPosition);
                using var list = ListComponent<Vector3>.Create();
                unit.Domain.GetComponent<MapComponent>().SearchPath(unit, targetPosition, list);
                if (distance >= limitDis && list.Count >= 2 && unit.GetComponent<StateComponent>().CanMove() == ErrorCore.ERR_Success)
                {
                    Vector3 dir = unit.Position - targetPosition;
                    float ange = Mathf.Rad2Deg(Mathf.Atan2(dir.x, dir.z));
                    float addg = unit.Id % 10 * (unit.Id % 2 == 0 ? 2 : -2);
                    Quaternion rotation = Quaternion.Euler(0, ange + addg, 0);
                    Vector3 ttt = targetPosition + rotation * Vector3.forward * (limitDis);
                    unit.FindPathMoveToAsync(ttt, cancellationToken, false).Coroutine();
                }

                bool timeRet = await TimerComponent.Instance.WaitAsync(200, cancellationToken);
                if (!timeRet)
                {
                    return;
                }
            }
        }
    }
}
