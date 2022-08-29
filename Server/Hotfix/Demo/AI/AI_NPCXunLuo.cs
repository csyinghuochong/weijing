using UnityEngine;

namespace ET
{

    [AIHandler]
    public class AI_NPCXunLuo : AAIHandler
    {

        public override bool Check(AIComponent aiComponent, AIConfig aiConfig)
        {

            return true;
        }

        public override async ETTask Execute(AIComponent aiComponent, AIConfig aiConfig, ETCancellationToken cancellationToken)
        {
            Unit unit = aiComponent.GetParent<Unit>();
            NpcMoveComponent npcMoveComponent = unit.GetComponent<NpcMoveComponent>();
            while (true)
            {
                Vector3 nextTarget = npcMoveComponent.GetTargetPosition();
                await unit.FindPathMoveToAsync(nextTarget, cancellationToken);

                npcMoveComponent.UpdateMoveIndex();
                bool timeRet = await TimerComponent.Instance.WaitAsync(5000, cancellationToken);
                if (!timeRet)
                {
                    return;
                }

            }
        }
    }
}
