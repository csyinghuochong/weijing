using UnityEngine;

namespace ET
{

    [AIHandler]
    public class AI_Pasture : AAIHandler
    {
        public override bool Check(AIComponent aiComponent, AIConfig aiConfig)
        {
            return true;
        }

        public override async ETTask Execute(AIComponent aiComponent, AIConfig aiConfig, ETCancellationToken cancellationToken)
        {
            Unit unit = aiComponent.GetParent<Unit>();

            for (int i = 0; i < 100000; ++i)
            {
                Vector3 nextTarget;
                if (unit.Type == UnitType.Pasture)
                {
                    nextTarget = JiaYuanHelper.GetRandomPos();
                }
                else
                {
                    nextTarget = JiaYuanHelper.JiaYuanPetPosition[RandomHelper.RandomNumber(0, JiaYuanHelper.JiaYuanPetPosition.Count)];
                }
                unit.FindPathMoveToAsync(nextTarget, cancellationToken).Coroutine();
                long waitTime = RandomHelper.RandomNumber(40000, 100000);
                bool timeRet = await TimerComponent.Instance.WaitAsync(waitTime, cancellationToken);
                if (!timeRet)
                {
                    return;
                }
            }
        }
    }
}