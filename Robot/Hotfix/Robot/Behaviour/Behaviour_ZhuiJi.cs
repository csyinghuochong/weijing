using UnityEngine;

namespace ET
{
    //追击
    public class Behaviour_ZhuiJi : BehaviourHandler
    {
        public override int BehaviourId()
        {
            return BehaviourType.Behaviour_ZhuiJi;
        }

        public override bool Check(BehaviourComponent aiComponent, AIConfig aiConfig)
        {
            return aiComponent.NewBehaviour == BehaviourId();
        }

        public override async ETTask Execute(BehaviourComponent aiComponent, AIConfig aiConfig, ETCancellationToken cancellationToken)
        {
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(aiComponent.ZoneScene());
            long instanceId = unit.InstanceId;
            Log.Debug("Behaviour_ZhuiJi: Enter");

            while (true)
            {
                if (instanceId != unit.InstanceId)
                {
                    return;
                }
                Unit target = unit.DomainScene().GetComponent<UnitComponent>().Get(aiComponent.TargetID);
                if (target != null && Vector3.Distance(target.Position, unit.Position) > aiComponent.ActDistance)
                {
                    Vector3 dir = unit.Position - target.Position;
                    Vector3 ttt = target.Position + dir.normalized * (aiComponent.ActDistance - 1f);
                    ttt.x += unit.Id % 10 * 0.05f * (unit.Id % 2 == 0 ? 1 : -1);
                    ttt.z += unit.Id % 10 * 0.05f * (unit.Id % 2 == 0 ? 1 : -1);
                    unit.MoveToAsync2(ttt, false).Coroutine();
                }
                else
                {
                    target = AIHelp.GetNearestEnemy(unit);
                    aiComponent.TargetID = target!= null ? target.Id : 0;
                }
                if (target == null)
                {
                    aiComponent.TargetID = 0;
                    aiComponent.ChangeBehaviour(BehaviourType.Behaviour_Target);
                    return;
                }
                
                bool timeRet = await TimerComponent.Instance.WaitAsync(500, cancellationToken);
                if (!timeRet)
                {
                    Log.Debug("Behaviour_ZhuiJi: Exit1");
                    return;
                }
            }
        }
    }
}
