using System;
using UnityEngine;


namespace ET
{
    public class Behaviour_Retreat : BehaviourHandler
    {
        public override int BehaviourId()
        {
            return BehaviourType.Behaviour_Retreat;
        }

        public override bool Check(BehaviourComponent aiComponent, AIConfig aiConfig)
        {
            return aiComponent.NewBehaviour == BehaviourId();
        }

        public override async ETTask Execute(BehaviourComponent aiComponent, AIConfig aiConfig, ETCancellationToken cancellationToken)
        {
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(aiComponent.ZoneScene());
            Vector3 targetPosition = aiComponent.TargetPosition;
            //Console.WriteLine($"Behaviour_Retreat: Execute");
            while (true)
            {
                if (unit.IsDisposed)
                {
                    return;
                }

                if (Vector3.Distance(unit.Position, targetPosition) > 1f)
                {
                    unit.MoveToAsync2(targetPosition).Coroutine();
                }
                else
                {
                    aiComponent.TargetID = 0;
                    aiComponent.ChangeBehaviour(BehaviourType.Behaviour_Target);
                }

                bool timeRet = await TimerComponent.Instance.WaitAsync(1000, cancellationToken);
                if (!timeRet)
                {
                    return;
                }
            }

        }
    }
}
