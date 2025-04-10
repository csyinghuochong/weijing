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
            await TimerComponent.Instance.WaitAsync(2000);
            Log.ILog.Debug("机器人同意进入副本！");
            C2M_TeamDungeonPrepareRequest   request = new C2M_TeamDungeonPrepareRequest() { TeamInfo = args.TeamInfo, Prepare = 1 };
            M2C_TeamDungeonPrepareResponse response = (M2C_TeamDungeonPrepareResponse)await zoneScene.GetComponent<SessionComponent>().Session.Call(request);
        }
    }
}
