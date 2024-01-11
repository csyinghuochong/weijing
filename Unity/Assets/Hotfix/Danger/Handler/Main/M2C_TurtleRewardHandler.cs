using System;


namespace ET
{

    [MessageHandler]
    public class M2C_TurtleRewardHandler : AMHandler<M2C_TurtleRewardMessage>
    {
        protected override void Run(Session session, M2C_TurtleRewardMessage message)
        {
            EventType.TurtleReward.Instance.m2C_TurtleReward = message;
            EventType.TurtleReward.Instance.ZoneScene = session.ZoneScene();
            EventSystem.Instance.PublishClass(EventType.TurtleReward.Instance);
        }
    }
}
