namespace ET
{
    public class Q2C_EnterGameHandler : AMHandler<Q2C_EnterGame>
    {
        protected override void Run(Session session, Q2C_EnterGame message)
        {
            EventType.QueueEnterGame.Instance.ZoneScene = session.ZoneScene();
            EventType.QueueEnterGame.Instance.Token = message.Token;
            EventSystem.Instance.PublishClass(EventType.QueueEnterGame.Instance);
        }
    }
}
