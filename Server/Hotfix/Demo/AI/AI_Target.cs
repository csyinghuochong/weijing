using UnityEngine;

namespace ET
{
    [AIHandler]
    public class AI_Target : AAIHandler
    {
        private void InitTargetPoints(AIComponent aiComponent, AIConfig aiConfig)
        {
            Unit unit = aiComponent.GetParent<Unit>();
            string[] targetpoints = aiConfig.NodeParams.Split('@');
            for (int i = 0; i < targetpoints.Length; i++)
            {
                string[] potioninfo = targetpoints[i].Split(';');
                float x = int.Parse(potioninfo[0]) * 0.01f;
                float y = int.Parse(potioninfo[1]) * 0.01f;
                float z = int.Parse(potioninfo[2]) * 0.01f;
                aiComponent.TargetPoint.Add( new Vector3(x, y, z));
            }
            aiComponent.TargetIndex = 0;
        }

        public override bool Check(AIComponent aiComponent, AIConfig aiConfig)
        {
            if (aiComponent.TargetIndex == -1)
            {
                InitTargetPoints(aiComponent, aiConfig);
            }
            if (aiComponent.TargetIndex >= aiComponent.TargetPoint.Count)
            {
                return false;
            }
            if (aiComponent.TargetID != 0)
            {
                return false;
            }
            Unit unit = aiComponent.GetParent<Unit>();
            Unit nearest = AIHelp.GetNearestEnemy(unit);
            if (nearest!= null  && !aiComponent.IsRetreat
             && PositionHelper.Distance2D(unit, nearest) < aiComponent.ActRange)
            {
                aiComponent.TargetZhuiJi = unit.Position;
                aiComponent.TargetID = nearest.Id;
                return false;
            }
            
            float distance_1 = PositionHelper.Distance2D(aiComponent.TargetZhuiJi, unit.Position);
            Vector3 target = aiComponent.TargetPoint[aiComponent.TargetIndex];
            float distance_2 = Vector3.Distance(target, unit.Position);
            bool gotoTarget = distance_1 >= aiComponent.ChaseRange || distance_2 > 0.5;
            return gotoTarget;
        }

        public override async ETTask Execute(AIComponent aiComponent, AIConfig aiConfig, ETCancellationToken cancellationToken)
        {
            Unit unit = aiComponent.GetParent<Unit>();
            unit.Stop(0);

            while (true)
            {
                Vector3 target = aiComponent.TargetPoint[aiComponent.TargetIndex];
                float distance = Vector3.Distance(target, unit.Position);
                if (distance < 0.5f)
                {
                    aiComponent.TargetIndex++;
                }
                if (aiComponent.TargetIndex >= aiComponent.TargetPoint.Count)
                {
                    return;
                }
                if (unit.GetComponent<StateComponent>().CanMove())
                {
                   unit.FindPathMoveToAsync(target, cancellationToken, false).Coroutine();
                }
                bool timeRet = await TimerComponent.Instance.WaitAsync(20000, cancellationToken);
                if (!timeRet)
                {
                    return;
                }
            }
        }
    }
}