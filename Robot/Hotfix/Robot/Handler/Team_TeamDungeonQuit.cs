namespace ET
{
    [Event]
    public class Team_TeamDungeonQuit : AEventClass<EventType.TeamDungeonQuit>
    {
        protected override void Run(object cls)
        {
            EventType.TeamDungeonQuit args = cls as EventType.TeamDungeonQuit;
            MapComponent mapComponent = args.ZoneScene.GetComponent<MapComponent>();
            if (mapComponent.SceneTypeEnum == SceneTypeEnum.TeamDungeon)
            {
                Scene zoneScene = args.ZoneScene;
                EnterFubenHelp.RequestQuitFuben(zoneScene);
                zoneScene.GetComponent<BehaviourComponent>().TargetID = 0;
                zoneScene.GetComponent<BehaviourComponent>().ChangeBehaviour(BehaviourType.Behaviour_TeamDungeon);
            }
        }
    }
}
