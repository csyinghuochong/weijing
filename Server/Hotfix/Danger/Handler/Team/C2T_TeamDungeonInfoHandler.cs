using System;
using System.Collections.Generic;

namespace ET
{

    [ActorMessageHandler]
    public class C2T_TeamDungeonInfoHandler : AMActorRpcHandler<Scene, C2T_TeamDungeonInfoRequest, T2C_TeamDungeonInfoResponse>
    {

        protected override async ETTask Run(Scene scene, C2T_TeamDungeonInfoRequest request, T2C_TeamDungeonInfoResponse response, Action reply)
        {
            List<TeamInfo> teamInfos = new List<TeamInfo>();
            List<TeamInfo> teamList = scene.GetComponent<TeamSceneComponent>().TeamList;
            for (int i = teamList.Count - 1; i >= 0; i--)
            {
                TeamInfo teamInfo = teamList[i];

                if (teamInfo.PlayerList.Count == 0)
                {
                    teamList.RemoveAt(i);
                    continue;
                }
                if (teamInfo.FubenId != 0)
                {
                    teamInfos.Add(teamInfo);
                    continue;
                }
                for (int k = 0; k < teamInfo.PlayerList.Count; k++)
                {
                    if (teamInfo.PlayerList[k].UserID == request.UserId)
                    {
                        teamInfos.Add(teamInfo);
                        break;
                    }
                }
            }
            response.TeamList = teamInfos;

            reply();
            await ETTask.CompletedTask;
        }

    }
}
