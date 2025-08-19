using System;
using UnityEngine;

namespace ET
{

    [AIHandler]
    public class AI_GhostMove : AAIHandler
    {

        public override bool Check(AIComponent aiComponent, AIConfig aiConfig)
        {
            if (aiComponent.LastAttackTime > 0)
            {
                return true;
            }

            Unit unit = aiComponent.GetParent<Unit>();
            long masterid = unit.GetComponent<NumericComponent>().GetAsLong(NumericType.MasterId);
            Unit master = aiComponent.UnitComponent.Get(masterid);

            float distance = Vector3.Distance(unit.Position, master.Position);
            return aiComponent.TargetID == 0 && distance < aiComponent.ActRange;
        }

        public override async ETTask Execute(AIComponent aiComponent, AIConfig aiConfig, ETCancellationToken cancellationToken)
        {
            aiComponent.TargetID = 0;

            Unit unit = aiComponent.GetParent<Unit>();
            NumericComponent numericComponent = unit.GetComponent<NumericComponent>();
            numericComponent.Set(NumericType.Extra_Buff_Speed_Add, 0);
            long masterid = numericComponent.GetAsLong(NumericType.MasterId);
            Unit master = aiComponent.UnitComponent.Get(masterid);

            while (true)
            {

                if (master != null && !master.IsDisposed)
                {
                    //随机坐标
                    float randomrange = aiComponent.ActRange;
                    Vector3 targetpos = AIHelp.GetRandomPointInRing(master.Position, 2, randomrange);

                    aiComponent.LastAttackTime = 0;
                    await unit.FindPathMoveToAsync(targetpos, cancellationToken, false);

                    if (cancellationToken.IsCancel())
                    {
                        break;
                    }
                    bool result = await TimerComponent.Instance.WaitAsync(500, cancellationToken);
                    if (!result)
                    {
                        break;
                    }
                }
            }
        }
    }
}