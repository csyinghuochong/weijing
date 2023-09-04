using System;

namespace ET
{
    [MessageHandler]
    public class M2C_RankDemonHandler: AMHandler<M2C_RankDemonMessage>
    {
        protected override void Run(Session session, M2C_RankDemonMessage message)
        {
            Log.ILog.Debug(message.ToString());
            EventType.RankDemonInfo.Instance.M2CRankDemonMessage = message;
            EventType.RankDemonInfo.Instance.ZoneScene = session.ZoneScene();
            EventSystem.Instance.PublishClass(EventType.RankDemonInfo.Instance);
        }
    }
}