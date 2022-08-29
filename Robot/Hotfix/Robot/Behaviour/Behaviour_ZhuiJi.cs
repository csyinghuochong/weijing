using UnityEngine;

namespace ET
{
    //追击
    public class Behaviour_ZhuiJi : BehaviourHandler
    {
        public override string BehaviourId()
        {
            return BehaviourType.Behaviour_ZhuiJi;
        }

        public override int Check(BehaviourComponent aiComponent, AIConfig aiConfig)
        {
            if (aiComponent.NewBehaviour != BehaviourType.Behaviour_ZhuiJi)
            {
                return 1;
            }
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(aiComponent.ZoneScene());
            Unit target = AIHelp.GetNearestEnemy(unit);
            if (target == null)
            { 
                return 1;
            }

            aiComponent.TargetID = target.Id;
            float distance = PositionHelper.Distance2D(target, unit);
            if (distance < 1)
            {
                return 1;
            }
            else
            {
                return 0;
            }
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
