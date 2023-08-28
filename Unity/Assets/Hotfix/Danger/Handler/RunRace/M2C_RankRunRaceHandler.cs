using System;


namespace ET
{

    [MessageHandler]
    public class M2C_RankRunRaceHandler : AMHandler<M2C_RankRunRaceMessage>
    {
        protected override void Run(Session session, M2C_RankRunRaceMessage message)
        {
            session.ZoneScene().GetComponent<BattleMessageComponent>().M2C_RankRunRaceMessage = message;
            EventType.RunRaceInfo.Instance.M2CRankRunRaceMessage = message;
            EventType.RunRaceInfo.Instance.ZonScene = session.ZoneScene();
            EventSystem.Instance.PublishClass(EventType.RunRaceInfo.Instance);
        }
    }
}
