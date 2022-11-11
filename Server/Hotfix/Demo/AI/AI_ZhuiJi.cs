 using UnityEngine;

namespace ET
{

    [AIHandler]
    public class AI_ZhuiJi : AAIHandler
    {
        public override bool Check(AIComponent aiComponent, AIConfig aiConfig)
        {
            if (aiComponent.TargetID == 0 || aiComponent.IsRetreat)
            {
                return false;
            }
            Unit target = aiComponent.DomainScene().GetComponent<UnitComponent>().Get(aiComponent.TargetID);
            if (target == null)
            {
                aiComponent.TargetID = 0;
                return false;
            }
            //获取范敌人是否在攻击范围内
            float distance = Vector3.Distance(target.Position, aiComponent.GetParent<Unit>().Position);
            bool zhuiji = distance >= aiComponent.ActDistance && aiComponent.IsCanZhuiJi();
            return zhuiji;
        }

        public override async ETTask Execute(AIComponent aiComponent, AIConfig aiConfig, ETCancellationToken cancellationToken)
        {
            //获取附近最近距离的目标进行追击
            Unit unit = aiComponent.GetParent<Unit>();
            while (true)
            {
                Unit target = unit.DomainScene().GetComponent<UnitComponent>().Get(aiComponent.TargetID);
                if (target == null )
                {
                    aiComponent.TargetID = 0;
                    return;
                }

                if (unit.GetComponent<StateComponent>().CanMove())
                {
                    Vector3 dir = unit.Position - target.Position;
                    //Vector3 ttt = target.Position + dir.normalized * ((float)aiComponent.ActDistance - 0.2f);
                    //ttt.x += unit.Id % 10 * 0.05f * (unit.Id % 2 == 0 ? 1 : -1);
                    //ttt.z += unit.Id % 10 * 0.05f * (unit.Id % 2 == 0 ? 1 : -1);
                    float ange = Mathf.Rad2Deg(Mathf.Atan2(dir.x, dir.z));
                    float addg = unit.Id % 10 * (unit.Id % 2 == 0 ? 2 : -2);
                    Quaternion rotation = Quaternion.Euler(0, ange + addg, 0);
                    Vector3 ttt = target.Position + rotation * Vector3.forward * ((float)aiComponent.ActDistance - 0.2f);
                    unit.FindPathMoveToAsync(ttt, cancellationToken, false).Coroutine();
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
