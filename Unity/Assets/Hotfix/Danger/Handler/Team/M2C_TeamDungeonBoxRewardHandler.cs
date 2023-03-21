namespace ET
{
    [MessageHandler]
    public class M2C_TeamDungeonBoxRewardHandler : AMHandler<M2C_TeamDungeonBoxRewardResult>
    {
        protected override void  Run(Session session, M2C_TeamDungeonBoxRewardResult message)
        {
            EventType.TeamDungeonBoxReward.Instance.Scene = session.DomainScene();
            EventType.TeamDungeonBoxReward.Instance.m2C_FubenSettlement = message;
            EventSystem.Instance.PublishClass(EventType.TeamDungeonBoxReward.Instance);
        }
    }
}
