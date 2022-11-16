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
            session.ZoneScene().GetComponent<TeamComponent>().OnRecvTeamApply(message.TeamPlayerInfo);
            await ETTask.CompletedTask;
        }
    }
}
