
namespace ET
{

    [MessageHandler]
    public class M2C_TeamUpdateHandler : AMHandler<M2C_TeamUpdateResult>
    {

        protected override void  Run(Session session, M2C_TeamUpdateResult message)
        {
            TeamComponent teamComponent = session.ZoneScene().GetComponent<TeamComponent>();
            teamComponent.OnRecvTeamUpdate(message);

#if !SERVER && NOT_UNITY
            TeamInfo teamInfo = session.ZoneScene().GetComponent<TeamComponent>().GetSelfTeam();
            if (teamInfo == null)
            {
                session.ZoneScene().Dispose();  
            }
#else
            Log.Debug("队伍结算"); 
#endif
        }

    }
}
