namespace ET
{
    [Event]
    public class Team_OnTeamDungeonOpen : AEventClass<EventType.RecvTeamDungeonOpen>
    {
        protected override void Run(object cls)
        {
            EventType.RecvTeamDungeonOpen args = (EventType.RecvTeamDungeonOpen)cls;
            RunAsync(args).Coroutine();
        }

        private async ETTask RunAsync(EventType.RecvTeamDungeonOpen args)
        {
            Scene zoneScene = args.ZoneScene;
            await TimerComponent.Instance.WaitAsync(RandomHelper.RandomNumber(2000, 4000));
            EnterFubenHelp.RequestTransfer(zoneScene, (int)SceneTypeEnum.TeamDungeon, 0).Coroutine();
        }
    }
}
