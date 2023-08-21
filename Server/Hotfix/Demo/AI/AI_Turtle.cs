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

        public  void SendReward(AIComponent aiComponent)
        {
            Unit unit = aiComponent.GetParent<Unit>();
            List<Unit> units = UnitHelper.GetUnitList( aiComponent.DomainScene(), unit.Position, UnitType.Player, 3f );

            int itemNumber = units.Count / 5;  
            itemNumber = Mathf.Max( itemNumber, 1 );
            for (int i = 0; i < units.Count; i++)
            {
                units[i].GetComponent<BagComponent>().OnAddItemData( $"{16000312};{itemNumber}", $"{ItemGetWay.Turtle}_{TimeHelper.ServerNow()}" );
            }
        }

        public async ETTask TurtleReport(AIComponent aiComponent)
        {
            //上报胜利
            Unit unit = aiComponent.GetParent<Unit>();
            long activtiyserverid = DBHelper.GetActivityServerId(unit.DomainZone());
            M2A_TurtleReportRequest request = new M2A_TurtleReportRequest() { TurtleId = unit.ConfigId };
            A2M_TurtleReportResponse a2M_TurtleSupport = (A2M_TurtleReportResponse)await ActorMessageSenderComponent.Instance.Call
                    (activtiyserverid, request);

            int index = ConfigHelper.TurtleList.IndexOf(unit.ConfigId);
            ServerMessageHelper.SendBroadMessage(aiComponent.DomainZone(), NoticeType.Notice, $"{index + 1}号选手获得了本次小龟大赛的最终胜利");

            //移除所有小龟
            List<Unit> units = UnitHelper.GetUnitList(unit.DomainScene(), UnitType.Npc);
            UnitComponent unitComponent = unit.GetParent<UnitComponent>();
            for (int i = units.Count - 1; i >= 0; i--)
            {
                if (ConfigHelper.TurtleList.Contains(units[i].ConfigId))
                {
                    units[i].GetComponent<AIComponent>().Stop_2();
                    unitComponent.Remove(units[i].Id);
                }
            }
        }

        public override async ETTask Execute(AIComponent aiComponent, AIConfig aiConfig, ETCancellationToken cancellationToken)
        {
            int lastState = 0;
            Unit unit = aiComponent.GetParent<Unit>();

            Log.Console($"AI_Turtle:Execute ");

            while (true)
            {
                if (Vector3.Distance(unit.Position, aiComponent.TargetPoint[0]) < 0.5f)
                {
                    //小龟到达终点，给支持玩家发送奖励
                    Log.Console($"AI_Turtle:move: {unit.Id}  到达终点");
                    TurtleReport( aiComponent ).Coroutine();
                    break;
                }

                int state = RandomHelper.RandFloat01() >= 0.5f ? 1 : 2;
                if (state == 1 || lastState == 0)
                {
                    Log.Console($"AI_Turtle:move: {unit.Id}   {state}   {lastState}");
                    unit.FindPathMoveToAsync(aiComponent.TargetPoint[0], cancellationToken, true).Coroutine();
                }
                else
                {
                    Log.Console($"AI_Turtle:stop: {unit.Id}   {state}   {lastState}");
                    unit.Stop(0);
                }
                if (state!= lastState && lastState != 0)
                {
                    unit.GetComponent<NumericComponent>().ApplyValue( NumericType.Now_TurtleAI, state);
                    //切换状态
                    SendReward(aiComponent);
                }
               
                bool timeRet = await TimerComponent.Instance.WaitAsync(10000, cancellationToken);
                if (!timeRet)
                {
                    Log.Console("AI_Turtle被打断！！" );
                    return;
                }
                lastState = state;
            }
        }
    }
}
