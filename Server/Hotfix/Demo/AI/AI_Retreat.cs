using System.Collections.Generic;
using UnityEngine;

namespace ET
{
    [AIHandler]
    public class AI_Retreat : AAIHandler
    {

        public override bool Check(AIComponent aiComponent, AIConfig aiConfig)
        {
            Unit unit = aiComponent.GetParent<Unit>();
            float distance =  PositionHelper.Distance2D(unit.GetBornPostion(), unit.Position);
            return distance >= aiComponent.ChaseRange;
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
                if (!timeRet || Vector3.Distance(bornVector3, unit.Position) < 0.5f)
                {
                    aiComponent.IsRetreat = false;
                    long max_hp = unit.GetComponent<NumericComponent>().GetAsLong(NumericType.Now_MaxHp);
                    NumericComponent numericComponent = unit.GetComponent<NumericComponent>();
                    numericComponent.ApplyValue(NumericType.Now_Dead, 0);
                    numericComponent.NumericDic[NumericType.Now_Hp] = 0;
                    numericComponent.ApplyChange(null, NumericType.Now_Hp, max_hp, 0);
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
