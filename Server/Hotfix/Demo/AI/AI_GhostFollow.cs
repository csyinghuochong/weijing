
using System;
using UnityEngine;

namespace ET
{

    [AIHandler]
    public class AI_GhostFollow : AAIHandler
    {

        public override bool Check(AIComponent aiComponent, AIConfig aiConfig)
        {
            
            Unit unit = aiComponent.GetParent<Unit>();
            long masterid = unit.GetComponent<NumericComponent>().GetAsLong(NumericType.MasterId);
            Unit master = aiComponent.UnitComponent.Get(masterid);
            
            if (master == null)
            {
                aiComponent.TargetID = 0;
                return false;
            }

            float distance = Vector3.Distance(unit.Position, master.Position);
            if (distance > aiComponent.ActRange)    //超出追击距离，返回
            {
                aiComponent.TargetID = 0;
                return true;
            }

            Unit nearest = AIHelp.GetNearestEnemyInRange(master, master.Position, aiComponent.ActRange, unit.Position);
            if (nearest != null)
            {
                aiComponent.TargetID = nearest.Id;
            }

            return false;
        }

        public static Vector3 GetFollowPosition(Unit unit, Unit master)
        {
            Vector3 dir = unit.Position - master.Position;
            float ange = Mathf.Rad2Deg(Mathf.Atan2(dir.x, dir.z));
            float addg = unit.Id % 10 * (unit.Id % 2 == 0 ? 5 : -5);
            addg += RandomHelper.RandFloat() * 5f;
            Quaternion rotation = Quaternion.Euler(0, ange + addg, 0);
            Vector3 tar = master.Position + rotation * Vector3.forward;
            return tar;
        }

        public override async ETTask Execute(AIComponent aiComponent, AIConfig aiConfig, ETCancellationToken cancellationToken)
        {
            Unit unit = aiComponent.GetParent<Unit>();
            long masterid = unit.GetComponent<NumericComponent>().GetAsLong(NumericType.MasterId);
            Unit master = aiComponent.UnitComponent.Get(masterid);

            while (true)
            {
                long nowspeed = 60000;
                if (master != null && !master.IsDisposed)
                {
                    nowspeed = master.GetComponent<NumericComponent>().GetAsLong(NumericType.Now_Speed);
                }
                int errorCode = unit.GetComponent<StateComponent>().CanMove();
                float distacne = Vector3.Distance(unit.Position, master.Position);

                if (errorCode == ErrorCode.ERR_Success)
                {
                    if (distacne > 5f)
                    {
                        nowspeed = (long)(nowspeed * 2);
                    }
                    //if (distacne > 9f)
                    //{
                    //    nowspeed = (long)(nowspeed * 2);
                    //}
                }
                else
                {
                    nowspeed = 0;
                }

                //宠物移动速度限制
                if (nowspeed >= 150000)
                {
                    nowspeed = 150000;
                }

                if (nowspeed > 0)
                {
                    Vector3 nextTarget = GetFollowPosition(unit, master);
                    NumericComponent numericComponent = unit.GetComponent<NumericComponent>();
                    float addspeed = nowspeed * 0.0001f - numericComponent.GetAsFloat(NumericType.Base_Speed_Base);
                    numericComponent.Set(NumericType.Extra_Buff_Speed_Add, addspeed);
                    unit.FindPathMoveToAsync(nextTarget, cancellationToken, true).Coroutine();
                }
                bool result = await TimerComponent.Instance.WaitAsync(200, cancellationToken);
                if (!result)
                {
                    break;
                }

            }
        }
    }
}