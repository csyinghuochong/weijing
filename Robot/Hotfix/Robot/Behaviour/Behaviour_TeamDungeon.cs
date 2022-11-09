namespace ET
{

    //组队副本
    public class Behaviour_TeamDungeon : BehaviourHandler
    {

        public override int BehaviourId()
        {
            return BehaviourType.Behaviour_TeamDungeon;
        }

        public override bool Check(BehaviourComponent aiComponent, AIConfig aiConfig)
        {
            if (aiComponent.NewBehaviour == BehaviourType.Behaviour_TeamDungeon)
            {
                return true;
            }
            return false;
        }

        public override async ETTask Execute(BehaviourComponent aiComponent, AIConfig aiConfig, ETCancellationToken cancellationToken)
        {
            Scene zoneScene = aiComponent.ZoneScene();
            TeamComponent teamComponent = zoneScene.GetComponent<TeamComponent>();
            UserInfo userInfo = zoneScene.GetComponent<UserInfoComponent>().UserInfo;
            Log.ILog.Debug("Behaviour_TeamDungeon: Enter");
            while (true)
            {
                //获取队伍列表
                bool ret = true;
                int errorCode = await teamComponent.RequestTeamDungeonList();
                TeamInfo selfTeam = teamComponent.GetSelfTeam();
                if (selfTeam != null)
                {
                    ret = await TimerComponent.Instance.WaitAsync(60000, cancellationToken);
                    if (!ret)
                    {
                        Log.ILog.Debug("Behaviour_TeamDungeon: Exit1");
                        return;
                    }
                    continue;
                }

                TeamInfo teamInfo = teamComponent.GetCanJoinTeam(aiComponent.RobotConfig.BehaviourID);
                if (teamInfo != null)
                {
                    errorCode = await teamComponent.SendTeamApply(teamInfo.TeamId, teamInfo.SceneId);
                }

                if (errorCode != 0)
                {
                    Log.Info($"Behaviour_TeamDungeon: Execute {errorCode}");
                }

                // 因为协程可能被中断，任何协程都要传入cancellationToken，判断如果是中断则要返回
                ret = await TimerComponent.Instance.WaitAsync(2000, cancellationToken);
                if (!ret)
                {
                    Log.ILog.Debug("Behaviour_TeamDungeon: Exit1");
                    return;
                }
            }
        }
    }
}
