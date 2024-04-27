namespace ET
{
    [MessageHandler]
    public class M2C_TeamDungeonApplyHandler : AMHandler<M2C_TeamDungeonApplyResult>
    {
        protected override void  Run(Session session, M2C_TeamDungeonApplyResult message)
        {
            bool blackroom = UnitHelper.IsBackRoom(session.ZoneScene());
            if (blackroom)
            {
                return;
            }
            session.ZoneScene().GetComponent<TeamComponent>().OnRecvTeamApply(message.TeamPlayerInfo);
        }

    }
}
