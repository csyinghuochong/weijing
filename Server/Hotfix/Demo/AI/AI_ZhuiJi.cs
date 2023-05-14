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

            long checktime = 200;
            switch (aiComponent.SceneTypeEnum)
            {
                case SceneTypeEnum.PetDungeon:
                case SceneTypeEnum.PetTianTi:
                    checktime = 100;
                    break;
                default:
                    checktime = 200;
                    break;
            }

            for (int i = 0; i < 10000; i++)
            {
                Unit target = unit.DomainScene().GetComponent<UnitComponent>().Get(aiComponent.TargetID);
                if (target != null)
                {
                    float distance = Vector3.Distance(unit.Position, target.Position);
                    if (distance < aiComponent.ActDistance)
                    {
                        unit.Stop(-1);
                    }
                    if (checktime == 100 && distance > aiComponent.ActDistance && unit.GetComponent<StateComponent>().CanMove() == ErrorCore.ERR_Success)
                    {
                        unit.FindPathMoveToAsync(target.Position, cancellationToken, false).Coroutine();
                    }
                    if (checktime == 200 && distance > aiComponent.ActDistance && unit.GetComponent<StateComponent>().CanMove() == ErrorCore.ERR_Success && i % 5 == 0)
                    {
                        //Vector3 dir = unit.Position - target.Position;
                        //float ange = Mathf.Rad2Deg(Mathf.Atan2(dir.x, dir.z));
                        //float addg = unit.Id % 10 * (unit.Id % 2 == 0 ? 2 : -2);
                        //Quaternion rotation = Quaternion.Euler(0, ange + addg, 0);
                        //Vector3 ttt = target.Position + rotation * Vector3.forward * ((float)aiComponent.ActDistance - 0.2f);
                        //unit.FindPathMoveToAsync(ttt, cancellationToken, false).Coroutine();
                        unit.FindPathMoveToAsync(target.Position, cancellationToken, false).Coroutine();
                    }
                }
                bool timeRet = await TimerComponent.Instance.WaitAsync(checktime, cancellationToken);
                if (!timeRet)
                {
                    return;
                }
            }
        }
    }


}
