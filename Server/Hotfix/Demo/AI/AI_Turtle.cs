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

        public void SendReward(AIComponent aiComponent)
        {

            //每次切换状态有50%概率发送奖励
            if (RandomHelper.RandFloat01() > 0.5f) {
                return;
            }

            //unit获取
            Unit unit = aiComponent.GetParent<Unit>();
            List<Unit> units = UnitHelper.GetUnitList( aiComponent.DomainScene(), unit.Position, UnitType.Player, 3f );

            int dropid = GlobalValueConfigCategory.Instance.Get(99).Value2;

            List<string> rewardName = new List<string>();   
            for (int i = 0; i < units.Count; i++)
            {
                //每个人获得道具的概率是20%
                if (RandomHelper.RandFloat01() <= 0.2f)
                {

                    List<RewardItem> droplist = new List<RewardItem>();
                    DropHelper.DropIDToDropItem_2(dropid, droplist);

                    bool sucess = units[i].GetComponent<BagComponent>().OnAddItemData(droplist, string.Empty, $"{ItemGetWay.Turtle}_{TimeHelper.ServerNow()}");
                    if (!sucess)
                    {
                        units[i].GetComponent<UserInfoComponent>().UpdateRoleData(UserDataType.Message, "背包已满！");
                    }
                    rewardName.Add(units[i].GetComponent<UserInfoComponent>().UserInfo.Name);
                }
            }

            MessageHelper.Broadcast(unit, new M2C_TurtleRewardMessage() {  UnitID = unit.Id, PlayerName = rewardName });
        }

        public async ETTask TurtleReport(AIComponent aiComponent)
        {
           
            //上报胜利
            Unit unit = aiComponent.GetParent<Unit>();
            long activtiyserverid = DBHelper.GetActivityServerId(unit.DomainZone());
            M2A_TurtleReportRequest request = new M2A_TurtleReportRequest() { TurtleId = unit.ConfigId };
            A2M_TurtleReportResponse a2M_TurtleSupport = (A2M_TurtleReportResponse)await ActorMessageSenderComponent.Instance.Call
                    (activtiyserverid, request);

            if (unit.IsDisposed)
            {
                return;
            }
            int index = ConfigHelper.TurtleList.IndexOf(unit.ConfigId);
            ServerMessageHelper.SendBroadMessage(aiComponent.DomainZone(), NoticeType.Notice, $"{index + 1}{ConfigHelper.TurtleWinNotice}");

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

            int round = 0;
            while (true)
            {
                if (Vector3.Distance(unit.Position, aiComponent.TargetPoint[0]) < 0.5f)
                {
                    //小龟到达终点，给支持玩家发送奖励
                    unit.Stop(0);
                    unit.GetComponent<NumericComponent>().ApplyValue(NumericType.Now_TurtleAI, 3);
                    TurtleReport( aiComponent ).Coroutine();
                    break;
                }

                //十秒钟切换一次状态
                if (round == 0 || round >= 10)
                {
                    round = 0;
                    NpcConfig npcConfig = NpcConfigCategory.Instance.Get(unit.ConfigId);
                    float moverate = npcConfig.NpcPar[1] * 0.0001f;
                    int state = RandomHelper.RandFloat01() >= moverate ? 1 : 2; //1移动 2停止
                    if (state == 1 || lastState == 0)
                    {
                        unit.FindPathMoveToAsync(aiComponent.TargetPoint[0], cancellationToken, true).Coroutine();
                        unit.GetComponent<NumericComponent>().ApplyValue(NumericType.Now_TurtleAI, 1);
                    }
                    else
                    {
                        unit.Stop(0);
                        unit.GetComponent<NumericComponent>().ApplyValue(NumericType.Now_TurtleAI, 2);
                    }

                    if (state != lastState && lastState != 0)
                    {
                        //切换状态
                        SendReward(aiComponent);
                    }

                    lastState = state;
                }

                round++;
                bool timeRet = await TimerComponent.Instance.WaitAsync(1000, cancellationToken);
                if (!timeRet)
                {
                    return;
                }
            }
        }
    }
}
