
namespace ET
{

    [MessageHandler]
    public class M2C_TeamUpdateHandler : AMHandler<M2C_TeamUpdateResult>
    {

        protected override void  Run(Session session, M2C_TeamUpdateResult message)
        {
            TeamComponent teamComponent = session.ZoneScene().GetComponent<TeamComponent>();
            teamComponent.OnRecvTeamUpdate(message);

            EventType.RecvTeamUpdate.Instance.ZoneScene = session.ZoneScene();
            EventSystem.Instance.PublishClass(EventType.RecvTeamUpdate.Instance);
        }
    }
}
