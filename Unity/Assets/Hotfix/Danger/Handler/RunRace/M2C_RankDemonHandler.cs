using System;


namespace ET
{

    [MessageHandler]
    public class M2C_RankDemonHandler : AMHandler<M2C_RankRunRaceMessage>
    {
        protected override void Run(Session session, M2C_RankRunRaceMessage message)
        {
            Log.ILog.Debug(message.ToString());
        }
    }
}
