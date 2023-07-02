using System.Collections.Generic;
using UnityEngine;

namespace ET
{
    [AIHandler]
    public class AI_Retreat : AAIHandler
    {

        /// <summary>
        /// boss范围圈内最近的敌人
        /// </summary>
        /// <param name="main"></param>
        /// <param name="bornpos"></param>
        /// <param name="maxdis"></param>
        /// <returns></returns>
        public Unit GetHaveEnemy(AIComponent aIComponent, Vector3 bornpos, float maxdis)
        {
            Unit nearest = null;
            Unit main = aIComponent.Unit;
            List<Unit> units = aIComponent.UnitComponent.GetAll();
            for (int i = 0; i < units.Count; i++)
            {
                Unit unit = units[i];
                if (unit.IsDisposed || main.Id == unit.Id)
                {
                    continue;
                }

                float dd = PositionHelper.Distance2D(bornpos, unit.Position);
                if (dd > maxdis)
                {
                    continue;
                }
                if (!main.IsCanAttackUnit(unit, false))
                {
                    continue;
                }
                nearest = unit;
                break;
            }
            return nearest;
        }


        public override bool Check(AIComponent aiComponent, AIConfig aiConfig)
        {
            //Unit unit = aiComponent.GetParent<Unit>();
            Vector3 posVec3 = aiComponent.Unit.GetBornPostion();
            float distance =  PositionHelper.Distance2D(posVec3, aiComponent.Unit.Position);
            if (aiComponent.Unit.IsBoss())
            {
                Unit enemy = GetHaveEnemy(aiComponent, posVec3, aiComponent.ChaseRange);
                //if (enemy == null)
                //{
                //    aiComponent.TargetID = 0;
                //}
                //return distance >= aiComponent.ChaseRange || aiComponent.TargetID == 0;
                return distance >= aiComponent.ChaseRange && enemy == null;
            }
            else
            {
                return distance >= aiComponent.ChaseRange;
            }
        }

        public override async ETTask Execute(AIComponent aiComponent, AIConfig aiConfig, ETCancellationToken cancellationToken)
        {
            Unit unit = aiComponent.GetParent<Unit>();
            if (unit.IsBoss())
            {
                unit.GetComponent<NumericComponent>().ApplyValue(NumericType.BossInCombat, 0);
                unit.GetComponent<AttackRecordComponent>().ClearBeAttack();
            }
            aiComponent.TargetID = 0;
            aiComponent.IsRetreat = true;
            List<Unit> units = UnitHelper.GetUnitList(unit.DomainScene(), UnitType.Player);
            for (int i = 0; i < units.Count; i++)
            {
                units[i].GetComponent<BuffManagerComponent>().OnRemoveBuffByUnit(unit.Id);
            }
            Vector3 bornVector3 = unit.GetBornPostion();

            while (true)
            {
                if (unit.GetComponent<StateComponent>().CanMove()== ErrorCore.ERR_Success)
                {
                    unit.FindPathMoveToAsync(bornVector3, cancellationToken, false).Coroutine();
                }
                bool timeRet = await TimerComponent.Instance.WaitAsync(1000, cancellationToken);
                if (timeRet && Vector3.Distance(bornVector3, unit.Position) < 0.5f && !unit.IsDisposed)
                {
                    NumericComponent numericComponent = unit.GetComponent<NumericComponent>();
                    if (numericComponent.GetAsInt(NumericType.Now_Dead) == 0)
                    {
                        long max_hp = numericComponent.GetAsLong(NumericType.Now_MaxHp);
                        numericComponent.ApplyValue(NumericType.Now_Hp, max_hp);
                    }
                    aiComponent.IsRetreat = false;
                }

                if (!timeRet)
                {
                    aiComponent.IsRetreat = false;
                }

                //返回出生点
                if (!aiComponent.IsRetreat && unit.IsBoss())
                {
                    SkillManagerComponent skillManagerComponent = unit.GetComponent<SkillManagerComponent>();
                    skillManagerComponent?.OnFinish(true);
                }
                if (!aiComponent.IsRetreat)
                {
                    return;
                }
            }
        }
    }
}
