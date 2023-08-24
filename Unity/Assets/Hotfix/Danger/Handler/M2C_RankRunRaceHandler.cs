using System;


namespace ET
{

    [MessageHandler]
    public class M2C_RankRunRaceHandler : AMHandler<M2C_RankRunRaceMessage>
    {
        protected override void Run(Session session, M2C_RankRunRaceMessage message)
        {
            session.ZoneScene().GetComponent<BattleMessageComponent>().M2C_RankRunRaceMessage = message;

            Log.Debug("接受消息 抛出事件。显示排名列表");
        }
    }
}
