using UnityEngine;


namespace ET
{

    [AIHandler]
    public class AI_Transfer : AAIHandler
    {
        public override bool Check(AIComponent aiComponent, AIConfig aiConfig)
        {
            if (aiComponent.TargetIndex <= 0)
            {
                return false;
            }

            Unit unit = aiComponent.GetParent<Unit>();
            Vector3 target = aiComponent.TargetPoint[aiComponent.TargetIndex - 1];
            float distance = Vector3.Distance(target, unit.Position);
            return distance < 0.5f;
        }

        public override async ETTask Execute(AIComponent aiComponent, AIConfig aiConfig, ETCancellationToken cancellationToken)
        {
            await ETTask.CompletedTask;
            Unit unit = aiComponent.GetParent<Unit>();
            unit.Stop(0);
            unit.SetBornPosition(unit.Position);
            aiComponent.IsRetreat = false;
            aiComponent.AIConfigId = int.Parse(aiConfig.NodeParams);
        }
    }
}
