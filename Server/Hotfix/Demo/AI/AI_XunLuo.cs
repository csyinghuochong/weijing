using UnityEngine;

namespace ET
{

    /// <summary>
    /// 野外副本怪物AI
    /// </summary>
    [AIHandler]
    public class AI_XunLuo: AAIHandler
    {
        public override bool Check(AIComponent aiComponent, AIConfig aiConfig)
        {
            if (aiComponent.TargetID != 0 || aiComponent.IsRetreat)
            {
                return false;
            }
            Unit unit = aiComponent.GetParent<Unit>();
            Unit nearestEnemy = null;
            if (aiComponent.SceneTypeEnum == SceneTypeEnum.PetDungeon
                || aiComponent.SceneTypeEnum == SceneTypeEnum.PetTianTi)
            {
                nearestEnemy = AIHelp.GetNearestCell(unit);
            }
            else
            {
                nearestEnemy = AIHelp.GetNearestEnemy(unit, aiComponent.ActRange, true); ;
            } 
            if (nearestEnemy == null)
            {
                aiComponent.TargetID = 0;
                aiComponent.noCheckStatus = true;
                return true;
            }

            if ( unit.IsBoss())
            {
                unit.GetComponent<NumericComponent>().ApplyValue(NumericType.BossInCombat, 1, true, true);
            }
            aiComponent.TargetID = nearestEnemy.Id;
            return aiComponent.TargetID == 0;
        }


        public override async ETTask Execute(AIComponent aiComponent, AIConfig aiConfig, ETCancellationToken cancellationToken)
        {
            Unit unit = aiComponent.GetParent<Unit>();
            while (true)
            {
                if (aiComponent.PatrolRange > 0f)
                {
                    Vector3 initVec3 = unit.GetBornPostion();
                    float new_x = initVec3.x + RandomHelper.RandomNumberFloat(-1 * aiComponent.PatrolRange, aiComponent.PatrolRange);
                    float new_z = initVec3.z + RandomHelper.RandomNumberFloat(-1 * aiComponent.PatrolRange, aiComponent.PatrolRange);
                    Vector3 nextTarget = new Vector3(new_x, initVec3.y, new_z);

                    unit.FindPathMoveToAsync(nextTarget, cancellationToken, true).Coroutine();
                }
               
   
                bool timeRet = await TimerComponent.Instance.WaitAsync(10000, cancellationToken);
                if (!timeRet)
                {
                    //Log.Debug("巡逻被打断！！" );
                    return;
                }
            }
        }

    }
}