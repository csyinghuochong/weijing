namespace ET
{
    [MessageHandler]
    public class M2C_UnionInviteHandler : AMHandler<M2C_UnionInviteMessage>
    {
        protected override void Run(Session session, M2C_UnionInviteMessage message)
        {
            EventType.UnionInvite.Instance.M2C_UnionInviteMessage = message;
            EventType.UnionInvite.Instance.ZoneScene = session.ZoneScene();
            EventSystem.Instance.PublishClass(EventType.UnionInvite.Instance);
        }
    }
}
