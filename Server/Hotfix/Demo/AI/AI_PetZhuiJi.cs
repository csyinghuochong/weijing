using UnityEngine;

namespace ET
{

    [AIHandler]
    public class AI_PetZhuiJi : AAIHandler
    {

        public override bool Check(AIComponent aiComponent, AIConfig aiConfig)
        {
            Unit nearest = AIHelp.GetNearestEnemy(aiComponent.GetParent<Unit>());
            if (nearest == null)
            {
                aiComponent.TargetID = 0;
                return false;
            }
            aiComponent.TargetID = nearest.Id;

            //获取范敌人是否在攻击范围内
            float distance = Vector3.Distance(nearest.Position, aiComponent.GetParent<Unit>().Position);
            bool zhuiji = distance >= aiComponent.ActDistance && distance <= aiComponent.ActRange && aiComponent.CanChange();
            return zhuiji;
        }

        public override async ETTask Execute(AIComponent aiComponent, AIConfig aiConfig, ETCancellationToken cancellationToken)
        {
            //Log.Debug("开始追击");
            //获取附近最近距离的目标进行追击
            Unit unit = aiComponent.GetParent<Unit>();
            while (true)
            {
                Unit target = unit.DomainScene().GetComponent<UnitComponent>().Get(aiComponent.TargetID);
                if (target != null)
                {
                    Vector3 dir = unit.Position - target.Position;
                    Vector3 ttt = target.Position + dir.normalized * 0.5f;
                    unit.FindPathMoveToAsync(ttt, cancellationToken, true).Coroutine();
                }
               
                bool timeRet = await TimerComponent.Instance.WaitAsync(1000, cancellationToken);
                if (!timeRet)
                {
                    return;
                }
            }

        }
    }
}
