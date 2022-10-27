using UnityEngine;


namespace ET
{

    [AIHandler]
    public class AI_Transfer : AAIHandler
    {
        public override bool Check(AIComponent aiComponent, AIConfig aiConfig)
        {
            Unit unit = aiComponent.GetParent<Unit>();
            return true;
        }

        public override async ETTask Execute(AIComponent aiComponent, AIConfig aiConfig, ETCancellationToken cancellationToken)
        {
            await ETTask.CompletedTask;
            Unit unit = aiComponent.GetParent<Unit>();
            unit.Stop(0);
            unit.SetBornPosition(unit.Position);
            aiComponent.AIConfigId = int.Parse(aiConfig.NodeParams);
        }
    }
}
