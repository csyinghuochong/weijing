namespace ET
{

    public class M2C_OneChallengeHandle : AMHandler<M2C_OneChallenge>
    {
        protected override void Run(Session session, M2C_OneChallenge message)
        {
            EventType.UIOneChallenge.Instance.ZoneScene = session.ZoneScene();
            EventType.UIOneChallenge.Instance.m2C_OneChallenge = message;
            EventSystem.Instance.PublishClass(EventType.UIOneChallenge.Instance);
        }
    }
}