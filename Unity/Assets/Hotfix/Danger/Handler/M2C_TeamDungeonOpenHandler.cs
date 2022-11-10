namespace ET
{

    [MessageHandler]
    public class M2C_TeamDungeonOpenHandler : AMHandler<M2C_TeamDungeonOpenResult>
    {
        protected override void  Run(Session session, M2C_TeamDungeonOpenResult message)
        {
            Scene zoneScene = session.ZoneScene();
#if NOT_UNITY
            OnRobotEnterFuben(zoneScene).Coroutine();
#else
            EventType.RecvTeamDungeonOpen.Instance.ZoneScene = zoneScene;
            EventSystem.Instance.PublishClass(EventType.RecvTeamDungeonOpen.Instance);
#endif
        }

        private async ETTask OnRobotEnterFuben(Scene zoneScene)
        {
            AccountInfoComponent accountInfoComponent = zoneScene.GetComponent<AccountInfoComponent>();
            if (accountInfoComponent.Password == ComHelp.RobotPassWord)
            {
                await TimerComponent.Instance.WaitAsync(RandomHelper.RandomNumber(100, 500));
                EnterFubenHelp.RequestTransfer(zoneScene, (int)SceneTypeEnum.TeamDungeon, 0).Coroutine();
                return;
            }
        }

    }
}
