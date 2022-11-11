namespace ET
{
    [MessageHandler]
    public class M2C_TeamDungeonApplyHandler : AMHandler<M2C_TeamDungeonApplyResult>
    {
        protected override void  Run(Session session, M2C_TeamDungeonApplyResult message)
        {
            RunAsync(session, message).Coroutine();
            
        }

        private async ETTask RunAsync(Session session, M2C_TeamDungeonApplyResult message)
        {
#if NOT_UNITY
            AccountInfoComponent accountInfoComponent = session.ZoneScene().GetComponent<AccountInfoComponent>();
            if (accountInfoComponent.Password == ComHelp.RobotPassWord)
            {
                await session.ZoneScene().GetComponent<TeamComponent>().AgreeTeamApply(message.TeamPlayerInfo, 1);
                return;
            }
#endif
            session.ZoneScene().GetComponent<TeamComponent>().OnRecvTeamApply(message.TeamPlayerInfo);
            await ETTask.CompletedTask;
        }
    }
}
