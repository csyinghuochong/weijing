using UnityEngine;

namespace ET
{

    [AIHandler]
    public class AI_JingLing : AAIHandler
    {

        public override bool Check(AIComponent aiComponent, AIConfig aiConfig)
        {
            return true;
        }

        public static Vector3 GetFollowPosition(Unit unit, Unit master)
        {
            Vector3 dir = (unit.Position - master.Position).normalized;
            Vector3 tar = master.Position + dir * Vector3.forward * 1.5f;
            return tar;
        }

        public override async ETTask Execute(AIComponent aiComponent, AIConfig aiConfig, ETCancellationToken cancellationToken)
        {
            Unit unit = aiComponent.GetParent<Unit>();
            long unitId = unit.GetComponent<NumericComponent>().GetAsLong(NumericType.MasterId);
            Unit master = aiComponent.DomainScene().GetComponent<UnitComponent>().Get(unitId);

            while (true)
            {
                long nowspeed = master.GetComponent<NumericComponent>().GetAsLong(NumericType.Now_Speed);
                int errorCode = unit.GetComponent<StateComponent>().CanMove();
                float distacne = Vector3.Distance(unit.Position, master.Position);

                if (errorCode == ErrorCore.ERR_Success && distacne > 1.5f)
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