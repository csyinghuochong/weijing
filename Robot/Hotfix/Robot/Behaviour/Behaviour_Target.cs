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
            Vector3 targetPosition = new Vector3(9.96f, 0.05f, -1.8f);

            while (true)
            {
                if (Vector3.Distance(unit.Position, targetPosition) > 1f)
                {
                    unit.MoveToAsync2(targetPosition).Coroutine();
                }
                else
                {
                    aiComponent.ChangeBehaviour(BehaviourType.Behaviour_ZhuiJi);
                    return;
                }

                bool timeRet = await TimerComponent.Instance.WaitAsync(2000, cancellationToken);
                if (!timeRet)
                {
                    Log.ILog.Debug("Behaviour_Target: Exit1");
                    return;
                }
            }

        }
    }
}
