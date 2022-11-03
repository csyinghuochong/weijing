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
            if (aiComponent.NewBehaviour != BehaviourType.Behaviour_ZhuiJi)
            {
                return false;
            }
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(aiComponent.ZoneScene());
            Unit target = AIHelp.GetNearestEnemy(unit);
            if (target == null)
            { 
                return false;
            }

            aiComponent.TargetID = target.Id;
            float distance = PositionHelper.Distance2D(target, unit);
            if (distance < 3)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public override async ETTask Execute(BehaviourComponent aiComponent, AIConfig aiConfig, ETCancellationToken cancellationToken)
        {
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(aiComponent.ZoneScene());
            aiComponent.ZoneScene().GetComponent<SessionComponent>().Session.Send(new C2M_Stop());
            long instanceId = unit.InstanceId;
            Log.ILog.Debug("Behaviour_ZhuiJi: Enter");

            while (true)
            {
                if (instanceId != unit.InstanceId)
                {
                    return;
                }

                Unit target = unit.DomainScene().GetComponent<UnitComponent>().Get(aiComponent.TargetID);
                if (target != null)
                {
                    Vector3 dir = unit.Position - target.Position;
                    Vector3 vector3 = target.Position + dir.normalized * (1f - 0.5f);
                    vector3 = vector3 + new Vector3(RandomHelper.RandFloat01() * 0.5f, 0f, RandomHelper.RandFloat01() * 0.5f);
                    unit.MoveToAsync2(vector3).Coroutine();
                    //Log.ILog.Debug("Behaviour_ZhuiJi: Execute11111");
                }
                else
                {
                    //Log.ILog.Debug("Behaviour_ZhuiJi: Execute22222");
                    return;
                }
                
                bool timeRet = await TimerComponent.Instance.WaitAsync(2000, cancellationToken);
                if (!timeRet)
                {
                    Log.ILog.Debug("Behaviour_ZhuiJi: Exit1");
                    return;
                }
            }
        }
    }
}
