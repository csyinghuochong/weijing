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
                Vector3 nextTarget = JiaYuanHelper.GetRandomPos();
                unit.FindPathMoveToAsync(nextTarget, cancellationToken).Coroutine();

                bool timeRet = await TimerComponent.Instance.WaitAsync(20000, cancellationToken);
                if (!timeRet)
                {
                    return;
                }
            }
        }
    }
}