
namespace ET
{
    [MessageHandler]
    public class M2C_TeamDungeonSettlementHandler : AMHandler<M2C_TeamDungeonSettlement>
    {

        private async ETTask OnRobotExit(Scene zonescene)
        {
            EnterFubenHelp.RequestQuitFuben(zonescene);
            await TimerComponent.Instance.WaitAsync(2000);
            zonescene.GetComponent<BehaviourComponent>().TargetID = 0;
            zonescene.GetComponent<BehaviourComponent>().ChangeBehaviour(BehaviourType.Behaviour_Stroll);
            zonescene.GetComponent<TeamComponent>().SendLeaveRequest().Coroutine();
            //退出队伍
        }

        protected override  void Run(Session session, M2C_TeamDungeonSettlement message)
        {
            EventType.TeamDungeonSettlement.Instance.Scene = session.DomainScene();
            EventType.TeamDungeonSettlement.Instance.m2C_FubenSettlement = message;

#if NOT_UNITY
			MapComponent mapComponent = session.ZoneScene().GetComponent<MapComponent>();
			if ( mapComponent.SceneTypeEnum == SceneTypeEnum.TeamDungeon)
			{
                OnRobotExit(session.ZoneScene()).Coroutine();
            }
#endif
            EventSystem.Instance.PublishClass(EventType.TeamDungeonSettlement.Instance);
        }
    }
}
