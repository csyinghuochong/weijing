namespace ET
{
    [MessageHandler]
    public class M2C_TeamInviteHandler : AMHandler<M2C_TeamInviteResult>
    {

        protected override void  Run(Session session, M2C_TeamInviteResult message)
        {
            EventType.RecvTeamInvite.Instance.ZoneScene = session.DomainScene();
            EventType.RecvTeamInvite.Instance.m2C_TeamInviteResult = message;
            EventSystem.Instance.PublishClass(EventType.RecvTeamInvite.Instance);
        }
    }
}
