
namespace ET
{
    [MessageHandler]
    public class M2C_TeamDungeonSettlementHandler : AMHandler<M2C_TeamDungeonSettlement>
    {

#if NOT_UNITY
        private void  OnRobotExit(Session session)
        {
            Scene zoneScene = session.ZoneScene();
            EnterFubenHelp.RequestQuitFuben(zoneScene);
            zoneScene.GetComponent<BehaviourComponent>().TargetID = 0;
            zoneScene.GetComponent<BehaviourComponent>().ChangeBehaviour(BehaviourType.Behaviour_TeamDungeon);
        }
#endif

        protected override  void Run(Session session, M2C_TeamDungeonSettlement message)
        {
            EventType.TeamDungeonSettlement.Instance.Scene = session.DomainScene();
            EventType.TeamDungeonSettlement.Instance.m2C_FubenSettlement = message;

#if NOT_UNITY
			MapComponent mapComponent = session.ZoneScene().GetComponent<MapComponent>();
			if ( mapComponent.SceneTypeEnum == SceneTypeEnum.TeamDungeon)
			{
                OnRobotExit(session);
            }
#endif
            EventSystem.Instance.PublishClass(EventType.TeamDungeonSettlement.Instance);
        }
    }
}
