using UnityEngine;

namespace ET
{

    [AIHandler]
    public class AI_Follow : AAIHandler
    {

        public override bool Check(AIComponent aiComponent, AIConfig aiConfig)
        {
            Unit unit = aiComponent.GetParent<Unit>();
            long unitId = unit.GetComponent<NumericComponent>().GetAsLong(NumericType.MasterId);
            Unit master = aiComponent.DomainScene().GetComponent<UnitComponent>().Get(unitId);
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
            long mastaerAttackId = unit.GetComponent<AttackRecordComponent>().BeAttackId;
            Unit enemyUnit = aiComponent.DomainScene().GetComponent<UnitComponent>().Get(mastaerAttackId);
            if (enemyUnit == null || !enemyUnit.IsCanBeAttack())
            {
                mastaerAttackId = master.GetComponent<AttackRecordComponent>().AttackingId;
                enemyUnit = aiComponent.DomainScene().GetComponent<UnitComponent>().Get(mastaerAttackId);
            }
            if (enemyUnit == null || !enemyUnit.IsCanBeAttack())
            {
                mastaerAttackId = master.GetComponent<AttackRecordComponent>().BeAttackId;
                enemyUnit = aiComponent.DomainScene().GetComponent<UnitComponent>().Get(mastaerAttackId);
            }
            if (enemyUnit == null || !enemyUnit.IsCanBeAttack())
            {
                enemyUnit = aiComponent.DomainScene().GetComponent<UnitComponent>().Get(aiComponent.TargetID);
            }
            if (enemyUnit == null || !enemyUnit.IsCanBeAttack())
            {
                aiComponent.TargetID = 0;
                return true;
            }
            distance = Vector3.Distance(unit.Position, enemyUnit.Position);
            if (distance < aiComponent.ActRange)
            {
                aiComponent.TargetID = enemyUnit.Id;
            }
            else
            {
                aiComponent.TargetID = 0;
            }

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
            long unitId = unit.GetComponent<NumericComponent>().GetAsLong(NumericType.MasterId);
            Unit master = aiComponent.DomainScene().GetComponent<UnitComponent>().Get(unitId);

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

                bool timeRet = await TimerComponent.Instance.WaitAsync(500, cancellationToken);
                if (!timeRet)
                {
                    return;
                }
            }
        }
    }
}