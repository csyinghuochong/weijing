using System;


namespace ET
{

    [MessageHandler]
    public class M2C_RankRunRaceRewardHandler : AMHandler<M2C_RankRunRaceReward>
    {
        protected override void Run(Session session, M2C_RankRunRaceReward message)
        {
            EventType.RunRaceRewardInfo.Instance.M2CRankRunRaceReward = message;
            EventType.RunRaceRewardInfo.Instance.ZonScene = session.ZoneScene();
            EventSystem.Instance.PublishClass(EventType.RunRaceRewardInfo.Instance);
        }
    }
}
