using UnityEngine;

namespace ET
{

    [AIHandler]
    public class AI_Follow : AAIHandler
    {

        public override bool Check(AIComponent aiComponent, AIConfig aiConfig)
        {
            Unit unit = aiComponent.GetParent<Unit>();
            long masterid = unit.GetComponent<NumericComponent>().GetAsLong(NumericType.MasterId);
            Unit master = aiComponent.UnitComponent.Get(masterid);
           
            if (master == null)
            {
                return false;
            }
            
            float distance = Vector3.Distance(unit.Position, master.Position);
            if (distance > aiComponent.ActRange)    //超出追击距离，返回
            {
                aiComponent.TargetID = 0;
                return true;
            }

            long mastaerAttackId = master.GetComponent<AttackRecordComponent>().AttackingId;
            Unit enemyUnit = aiComponent.UnitComponent.Get(mastaerAttackId);
            if (enemyUnit == null || !enemyUnit.IsCanBeAttack())
            {
                mastaerAttackId = master.GetComponent<AttackRecordComponent>().BeAttackId;
                enemyUnit = aiComponent.UnitComponent.Get(mastaerAttackId);
            }
            if (enemyUnit == null || !enemyUnit.IsCanBeAttack())
            {
                enemyUnit = aiComponent.UnitComponent.Get(aiComponent.TargetID);
            }
            if (enemyUnit == null ||  !unit.IsCanAttackUnit(enemyUnit))
            {
                aiComponent.TargetID = 0;
                return true;
            }
            distance = Vector3.Distance(unit.Position, enemyUnit.Position);

            ///1
            aiComponent.TargetID = enemyUnit.Id;
            ///2
            //if (distance < aiComponent.ActRange)
            //{
            //    aiComponent.TargetID = enemyUnit.Id;
            //}
            //else
            //{
            //    aiComponent.TargetID = 0;
            //}
            return aiComponent.TargetID == 0;
        }

        public static Vector3 GetFollowPosition(Unit unit, Unit master)
        {
            //Vector3 cur = unit.Position;
            //Vector3 tar = master.Position;
            //Vector3 dir = (cur - tar).normalized;
            //tar = tar + (1f * dir);
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
            /*
            while (true)
            {
                float distacne = Vector3.Distance(unit.Position, master.Position);
                if (distacne > 6f)
                {
                    Vector3 nextTarget = GetFollowPosition(unit, master);
                    unit.GetComponent<NumericComponent>().Set(NumericType.Now_Speed, 60000);
                    unit.FindPathMoveToAsync(nextTarget, cancellationToken, false).Coroutine();
                }
                
                else if (distacne > 1.1f)
                {
                    Vector3 nextTarget = GetFollowPosition(unit, master);
                    unit.GetComponent<NumericComponent>().Set(NumericType.Now_Speed, 30000);
                    unit.FindPathMoveToAsync(nextTarget, cancellationToken, false).Coroutine();
                }
                
                bool timeRet = await TimerComponent.Instance.WaitAsync(100, cancellationToken);
                if (!timeRet)
                {
                    return;
                }
            }
            */
            while (true) 
            {
                long nowspeed = 60000;
                if (master!=null && !master.IsDisposed)
                {
                    nowspeed = master.GetComponent<NumericComponent>().GetAsLong(NumericType.Now_Speed);
                }
                int errorCode = unit.GetComponent<StateComponent>().CanMove();
                float distacne = Vector3.Distance(unit.Position, master.Position);

                if (errorCode == ErrorCode.ERR_Success && distacne > 1.5f)
                {
                    nowspeed = (long)(nowspeed * distacne / 2f);
                }
                else
                {
                    nowspeed = 0;
                }

                if (nowspeed > 0)
                {
                    Vector3 nextTarget = GetFollowPosition(unit, master);
                    unit.GetComponent<NumericComponent>().Set(NumericType.Now_Speed, nowspeed);
                    unit.FindPathMoveToAsync(nextTarget, cancellationToken, false).Coroutine();
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