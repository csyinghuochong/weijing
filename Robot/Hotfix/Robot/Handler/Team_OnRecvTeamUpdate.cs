using System;

namespace ET
{
    [Event]
    public class Team_OnRecvTeamUpdate : AEventClass<EventType.RecvTeamUpdate>
    {
        protected override void Run(object cls)
        {
            EventType.RecvTeamUpdate args = (EventType.RecvTeamUpdate)cls;
            TeamInfo teamInfo = args.ZoneScene.GetComponent<TeamComponent>().GetSelfTeam();
            if (teamInfo == null)
            {
                Log.Debug("队伍解算");
                RobotManagerComponent robotManager = args.ZoneScene.GetParent<RobotManagerComponent>();
                robotManager.RemoveRobot(args.ZoneScene).Coroutine();
            }

        }
    }
}
