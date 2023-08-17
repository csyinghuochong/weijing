using Alipay.AopSdk.Core.Domain;
using System.Collections.Generic;
using UnityEngine;

namespace ET
{

    /// <summary>
    /// 小龟大赛AI
    /// </summary>
    [AIHandler]
    public class AI_Turtle : AAIHandler
    {
        public override bool Check(AIComponent aiComponent, AIConfig aiConfig)
        {
            return true;
        }

        public async ETTask SendReward(AIComponent aiComponent)
        {
            await ETTask.CompletedTask;
        }

        public async ETTask TurtleReport(AIComponent aiComponent)
        {
            //上报胜利
            Unit unit = aiComponent.GetParent<Unit>();
            long activtiyserverid = DBHelper.GetActivityServerId(unit.DomainZone());
            M2A_TurtleReportRequest request = new M2A_TurtleReportRequest() { TurtleId = unit.ConfigId };
            A2M_TurtleReportResponse a2M_TurtleSupport = (A2M_TurtleReportResponse)await ActorMessageSenderComponent.Instance.Call
                    (activtiyserverid, request);

            //移除所有小龟
            List<Unit> units = UnitHelper.GetUnitList(unit.DomainScene(), UnitType.Monster);
            for (int i = units.Count - 1; i >= 0; i--)
            {
                if (ConfigHelper.TurtleList.Contains(units[i].ConfigId))
                {

                    unit.GetParent<UnitComponent>().Remove(units[i].Id);
                }
            }
        }

        public override async ETTask Execute(AIComponent aiComponent, AIConfig aiConfig, ETCancellationToken cancellationToken)
        {
            int lastState = 0;
            Unit unit = aiComponent.GetParent<Unit>();
            while (true)
            {
                if (Vector3.Distance(unit.Position, aiComponent.TargetPoint[0]) < 0.5f)
                {
                    //小龟到达终点，给支持玩家发送奖励
                    TurtleReport( aiComponent ).Coroutine();
                    break;
                }

                int state = RandomHelper.RandFloat01() >= 0.5f ? 1 : 2;
                if (state == 1 || lastState == 0)
                {
                    unit.FindPathMoveToAsync(aiComponent.TargetPoint[0], cancellationToken, true).Coroutine();
                }
                else
                {
                    unit.Stop(0);
                }
                if (state!= lastState && lastState != 0)
                {
                    unit.GetComponent<NumericComponent>().ApplyValue( NumericType.Now_TurtleAI, state);
                    //切换状态
                    SendReward(aiComponent).Coroutine();
                }
               
                bool timeRet = await TimerComponent.Instance.WaitAsync(10000, cancellationToken);
                if (!timeRet)
                {
                    //Log.Debug("AI_Turtle被打断！！" );
                    return;
                }
                lastState = state;
            }
        }
    }
}
