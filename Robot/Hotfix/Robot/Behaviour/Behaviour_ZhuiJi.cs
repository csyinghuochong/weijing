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
            return aiComponent.NewBehaviour == BehaviourType.Behaviour_ZhuiJi;
        }

        public override async ETTask Execute(BehaviourComponent aiComponent, AIConfig aiConfig, ETCancellationToken cancellationToken)
        {
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(aiComponent.ZoneScene());
            long instanceId = unit.InstanceId;
            Log.ILog.Debug("Behaviour_ZhuiJi: Enter");

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
                    Vector3 vector3 = target.Position + dir.normalized * (aiComponent.ActDistance - 2f);
                    //vector3 = vector3 + new Vector3(RandomHelper.RandFloat01() * 0.5f, 0f, RandomHelper.RandFloat01() * 0.5f);
                    unit.MoveToAsync2(vector3, false).Coroutine();
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
                    Log.ILog.Debug("Behaviour_ZhuiJi: Exit1");
                    return;
                }
            }
        }
    }
}
