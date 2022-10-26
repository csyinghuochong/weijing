
namespace ET
{
    [MessageHandler]
    public class M2C_TeamPickMessageHandler : AMHandler<M2C_TeamPickMessage>
    {
        protected override void Run(Session session, M2C_TeamPickMessage message)
        {
            Log.Debug("M2C_TeamPickMessageHandler");
            EventType.TeamPickNotice.Instance.m2C_TeamPickMessage = message;
            EventType.TeamPickNotice.Instance.ZoneScene = session.ZoneScene();
            EventSystem.Instance.PublishClass(EventType.TeamPickNotice.Instance);
        }
    }
}
