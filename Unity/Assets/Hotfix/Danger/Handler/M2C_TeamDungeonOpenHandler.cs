namespace ET
{

    [MessageHandler]
    public class M2C_TeamDungeonOpenHandler : AMHandler<M2C_TeamDungeonOpenResult>
    {
        protected override void  Run(Session session, M2C_TeamDungeonOpenResult message)
        {
            RunAsync(session.ZoneScene()).Coroutine();
        }

        private async ETTask RunAsync(Scene zoneScene)
        {
#if NOT_UNITY
            AccountInfoComponent accountInfoComponent = zoneScene.GetComponent<AccountInfoComponent>();
            if (accountInfoComponent.Password == ComHelp.RobotPassWord)
            {
                TeamComponent teamComponent = zoneScene.GetComponent<TeamComponent>();
                TeamInfo teamInfo = teamComponent.GetSelfTeam();
                int totalTimes = int.Parse(GlobalValueConfigCategory.Instance.Get(19).Value);
                int times = zoneScene.GetComponent<UserInfoComponent>().GetTeamDungeonTimes();
                if (totalTimes - times <= 0)
                {
                    return;
                }

                int errorCode = await EnterFubenHelp.RequestTransfer(zoneScene, (int)SceneTypeEnum.TeamDungeon, 0);
                zoneScene.GetComponent<BehaviourComponent>().ChangeBehaviour(BehaviourType.Behaviour_ZhuiJi);
                return;
            }
#else
            EventType.RecvTeamDungeonOpen.Instance.ZoneScene = zoneScene;
            EventSystem.Instance.PublishClass(EventType.RecvTeamDungeonOpen.Instance);
            await ETTask.CompletedTask;
#endif
        }

    }
}
