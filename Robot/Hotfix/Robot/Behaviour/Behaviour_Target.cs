using System.Collections.Generic;
using UnityEngine;

namespace ET
{
    public class Behaviour_Target : BehaviourHandler
    {

        public override int BehaviourId()
        {
            return BehaviourType.Behaviour_Target;
        }

        public override bool Check(BehaviourComponent aiComponent, AIConfig aiConfig)
        {
            return aiComponent.NewBehaviour == BehaviourId();
        }

        public override async ETTask Execute(BehaviourComponent aiComponent, AIConfig aiConfig, ETCancellationToken cancellationToken)
        {

            Log.ILog.Debug("Behaviour_Target: Enter");
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(aiComponent.ZoneScene());
            Vector3 targetPosition = aiComponent.TargetPosition;

            while (true)
            {
                if (unit.IsDisposed)
                {
                    return;
                }
                Unit target = AIHelp.GetNearestEnemy(unit);
                if (target!=null)
                {
                    aiComponent.TargetID = target.Id;
                    aiComponent.ChangeBehaviour(BehaviourType.Behaviour_ZhuiJi);
                    return;
                }

                if (Vector3.Distance(unit.Position, targetPosition) > 1f)
                {
                    unit.MoveToAsync2(targetPosition).Coroutine();
                }
                
                bool timeRet = await TimerComponent.Instance.WaitAsync(1000, cancellationToken);
                if (!timeRet)
                {
                    Log.ILog.Debug("Behaviour_Target: Exit1");
                    return;
                }
            }

        }
    }
}
