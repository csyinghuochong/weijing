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
            while (true)
            {
                bool timeRet = await TimerComponent.Instance.WaitAsync(5000, cancellationToken);
                if (!timeRet)
                {
                    return;
                }
            }
        }
    }
}
