using UnityEngine;

namespace ET
{


    /// <summary>
    /// 单人副本怪物AI
    /// </summary>
    [AIHandler]
    public class AI_LocalDungeon : AAIHandler
    {
        public override bool Check(AIComponent aiComponent, AIConfig aiConfig)
        {
            if (aiComponent.TargetID != 0 || aiComponent.IsRetreat)
            {
                return false;
            }
            Unit nearest = null;
            Unit unit = aiComponent.GetParent<Unit>();
            if (PositionHelper.Distance2D(unit, aiComponent.LocalDungeonUnit) <= aiComponent.ActRange)
            {
                nearest = aiComponent.LocalDungeonUnit;
            }
            if (nearest == null)
            {
                RolePetInfo rolePetInfo = aiComponent.LocalDungeonUnitPetComponent.GetFightPet();
                if (rolePetInfo != null)
                {
                    Unit pet = aiComponent.UnitComponent.Get(rolePetInfo.Id);
                    if (pet != null && PositionHelper.Distance2D(unit, pet) <= aiComponent.ActRange)
                    {
                        nearest = pet;
                    }
                }
            }
            
            if (nearest == null || !nearest.IsCanBeAttack())
            {
                aiComponent.TargetID = 0;
                aiComponent.noCheckStatus = true;
                return true;
            }

            if (aiComponent.Unit.IsBoss())
            {
                aiComponent.Unit.GetComponent<NumericComponent>().ApplyValue(NumericType.BossInCombat, 1, true, true);
            }
            aiComponent.TargetID = nearest.Id;
            return aiComponent.TargetID == 0;
        }

        public override async ETTask Execute(AIComponent aiComponent, AIConfig aiConfig, ETCancellationToken cancellationToken)
        {
            while (true)
            {
                //等5秒原地延迟
                bool timeRet = await TimerComponent.Instance.WaitAsync(5000, cancellationToken);
                if (!timeRet)
                {
                    return;
                }
            }
        }

    }
}
