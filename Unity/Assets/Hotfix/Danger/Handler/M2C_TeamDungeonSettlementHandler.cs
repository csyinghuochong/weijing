
namespace ET
{
    [MessageHandler]
    public class M2C_TeamDungeonSettlementHandler : AMHandler<M2C_TeamDungeonSettlement>
    {

        protected override  void Run(Session session, M2C_TeamDungeonSettlement message)
        {
            EventType.TeamDungeonSettlement.Instance.Scene = session.DomainScene();
            EventType.TeamDungeonSettlement.Instance.m2C_FubenSettlement = message;

            TeamComponent teamComponent = session.DomainScene().GetComponent<TeamComponent>();
            teamComponent.FubenOpen = false;
            EventSystem.Instance.PublishClass(EventType.TeamDungeonSettlement.Instance);
        }
    }
}
