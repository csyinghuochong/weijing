namespace ET
{

    [MessageHandler]
    public class M2C_TeamDungeonPrepareHandler : AMHandler<M2C_TeamDungeonPrepareResult>
    {
        protected override void Run(Session session, M2C_TeamDungeonPrepareResult message)
        {
            Scene zoneScene = session.ZoneScene();
            EventType.RecvTeamDungeonPrepare.Instance.ZoneScene = zoneScene;
            EventType.RecvTeamDungeonPrepare.Instance.PrepareResult = message;
            EventSystem.Instance.PublishClass(EventType.RecvTeamDungeonPrepare.Instance);

            if (message.ErrorCode == ErrorCore.ERR_Success)
            {
                RunAsync(zoneScene).Coroutine();
            }
        }

        private async ETTask RunAsync(Scene zoneScene)
        {
            Log.Debug("所有人都准好好了");
            await TimerComponent.Instance.WaitAsync(1000);
            EnterFubenHelp.RequestTransfer(zoneScene, (int)SceneTypeEnum.TeamDungeon, 0).Coroutine();
        }
    }
}
