using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{

    //组队副本
    public class Behaviour_TeamDungeon : BehaviourHandler
    {

        public override string BehaviourId()
        {
            return BehaviourType.Behaviour_TeamDungeon;
        }

        public override int Check(BehaviourComponent aiComponent, AIConfig aiConfig)
        {
            if (aiComponent.NewBehaviour == BehaviourType.Behaviour_TeamDungeon)
            {
                return 0;
            }
            return 1;
        }

        public override async ETTask Execute(BehaviourComponent aiComponent, AIConfig aiConfig, ETCancellationToken cancellationToken)
        {
            Scene zoneScene = aiComponent.ZoneScene();
            TeamComponent teamComponent = zoneScene.GetComponent<TeamComponent>();
            Log.ILog.Debug("Behaviour_TeamDungeon: Enter");
            while (true)
            {
                Log.ILog.Debug("Behaviour_TeamDungeon: Execute");

                //获取队伍列表
                int errorCode = await teamComponent.RequestTeamDungeonList();
                TeamInfo teamInfo = teamComponent.GetCanJoinTeam();
                if (teamInfo != null)
                {
                    //有可加入队伍再直接加入
                    errorCode = await teamComponent.SendTeamApply(teamInfo.TeamId, teamInfo.FubenId);
                }
                else
                {
                    //没有队伍则请求创建队伍
                    errorCode = await teamComponent.RequestTeamDungeonCreate(110001);
                }
                errorCode = await teamComponent.RequestTeamDungeonOpn();
                if (errorCode != 0)
                {
                    Log.Info($"Behaviour_TeamDungeon: Execute {errorCode}");
                }
                // 因为协程可能被中断，任何协程都要传入cancellationToken，判断如果是中断则要返回
                bool ret = await TimerComponent.Instance.WaitAsync(10000, cancellationToken);
                if (!ret)
                {
                    Log.ILog.Debug("Behaviour_TeamDungeon: Exit1");
                    return;
                }
            }
        }
    }
}
