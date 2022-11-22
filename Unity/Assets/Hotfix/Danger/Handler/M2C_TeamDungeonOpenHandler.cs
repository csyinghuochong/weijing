namespace ET
{

    [MessageHandler]
    public class M2C_TeamDungeonOpenHandler : AMHandler<M2C_TeamDungeonOpenResult>
    {
        protected override void  Run(Session session, M2C_TeamDungeonOpenResult message)
        {
            Scene zoneScene = session.ZoneScene();

            EventType.RecvTeamDungeonOpen.Instance.ZoneScene = zoneScene;
            EventSystem.Instance.PublishClass(EventType.RecvTeamDungeonOpen.Instance);
        }
    }
}
