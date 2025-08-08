using System;
using UnityEngine;

namespace ET
{

    [AIHandler]
    public class AI_GhostMove : AAIHandler
    {

        public override bool Check(AIComponent aiComponent, AIConfig aiConfig)
        {
            return aiComponent.LastAttackTime > 0;
        }

        public override async ETTask Execute(AIComponent aiComponent, AIConfig aiConfig, ETCancellationToken cancellationToken)
        {
            aiComponent.TargetID = 0;
            aiComponent.LastAttackTime = 0;

            Unit unit = aiComponent.GetParent<Unit>();
            NumericComponent numericComponent = unit.GetComponent<NumericComponent>();

            long masterid = numericComponent.GetAsLong(NumericType.MasterId);
            Unit master = aiComponent.UnitComponent.Get(masterid);

            if (master != null && !master.IsDisposed)
            {
                //随机坐标
                float randomrange = aiComponent.ActRange;
                float ran_x = RandomHelper.RandomNumberFloat(-1 * randomrange, randomrange) ;
                float ran_z = RandomHelper.RandomNumberFloat(-1 * randomrange, randomrange) ;
                //Vector3 targetpos = new Vector3(master.Position.x + ran_x, master.Position.y, master.Position.z + ran_z);
                Vector3 targetpos = AIHelp.GetRandomPointInRing(master.Position, 2, randomrange);
                aiComponent.IsGhostMove = true;
                await unit.FindPathMoveToAsync(targetpos, cancellationToken, false);
                aiComponent.IsGhostMove = false;
            }
            else
            {
                return;
            }
        }
    }
}