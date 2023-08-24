using System;


namespace ET
{

    [MessageHandler]
    public class M2C_RankRunRaceRewardHandler : AMHandler<M2C_RankRunRaceReward>
    {
        protected override void Run(Session session, M2C_RankRunRaceReward message)
        {
            Log.Debug("接受消息 抛出事件。调用 UICommonReward显示奖励 ");
        }
    }
}
