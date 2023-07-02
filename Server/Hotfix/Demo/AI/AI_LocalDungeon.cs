using UnityEngine;

namespace ET
{

    [AIHandler]
    public class AI_LocalDungeon : AAIHandler
    {
        public override bool Check(AIComponent aiComponent, AIConfig aiConfig)
        {
            if (aiComponent.TargetID != 0 || aiComponent.IsRetreat)
            {
                return false;
            }
            //Unit unit = aiComponent.GetParent<Unit>();
            Unit nearest = AIHelp.GetEnemyById(aiComponent.unit, aiComponent.LocalDungeonUnit, aiComponent.ActRange);
            if (nearest == null)
            {
                aiComponent.TargetID = 0;
                aiComponent.noCheckStatus = true;
                return false;
            }

            if (aiComponent.unit.IsBoss())
            {
                aiComponent.unit.GetComponent<NumericComponent>().ApplyValue(NumericType.BossInCombat, 1, true, true);
            }
            aiComponent.TargetID = nearest.Id;
            return aiComponent.TargetID > 0;
        }

        public override async ETTask Execute(AIComponent aiComponent, AIConfig aiConfig, ETCancellationToken cancellationToken)
        {
            while (true)
            {
                //等5秒原地延迟
                bool timeRet = await TimerComponent.Instance.WaitAsync(5000, cancellationToken);
                if (!timeRet)
                {
                    return;
                }
            }
        }

    }
}
