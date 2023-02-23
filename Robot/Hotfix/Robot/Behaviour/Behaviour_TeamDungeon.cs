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
            return aiComponent.NewBehaviour == BehaviourId();
        }

        public override async ETTask Execute(BehaviourComponent aiComponent, AIConfig aiConfig, ETCancellationToken cancellationToken)
        {
            Scene zoneScene = aiComponent.ZoneScene();
            TeamComponent teamComponent = zoneScene.GetComponent<TeamComponent>();
            await zoneScene.GetComponent<BagComponent>().CheckEquipList();
            Log.Debug("Behaviour_TeamDungeon: Enter");
            while (true)
            {
                //获取队伍列表
                int errorCode = await teamComponent.RequestTeamDungeonList();
                string[] teamId = aiComponent.MessageValue.Split('_');
                TeamInfo teamInfo = teamComponent.GetTeamInfo(long.Parse(teamId[1]));
                if (teamInfo != null)
                {
                    errorCode = await teamComponent.SendTeamApply(teamInfo.TeamId, teamInfo.SceneId, teamInfo.FubenType, teamInfo.PlayerList[0].PlayerLv);
                }
                if (errorCode != 0)
                {
                    Log.Debug($"Behaviour_TeamDungeon: Execute {errorCode}");
                }
                // 因为协程可能被中断，任何协程都要传入cancellationToken，判断如果是中断则要返回
                bool ret = await TimerComponent.Instance.WaitAsync(5 * TimeHelper.Minute, cancellationToken);
                if (ret)
                {
                    aiComponent.Exit();
                    return;
                }
                else
                {
                    Log.Debug("Behaviour_TeamDungeon: Exit1");
                    return;
                }
            }
        }
    }
}
