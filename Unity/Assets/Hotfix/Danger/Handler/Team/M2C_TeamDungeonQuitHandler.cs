namespace ET
{
    public class M2C_TeamDungeonQuitHandler : AMHandler<M2C_TeamDungeonQuitMessage>
    {
        protected override void Run(Session session, M2C_TeamDungeonQuitMessage message)
        {
            EventType.TeamDungeonQuit.Instance.m2C_Battle = message;
            EventType.TeamDungeonQuit.Instance.ZoneScene = session.ZoneScene();
            EventSystem.Instance.PublishClass(EventType.TeamDungeonQuit.Instance);
        }
    }
}
