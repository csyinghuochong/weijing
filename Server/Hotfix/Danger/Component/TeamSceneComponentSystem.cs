using System;
using System.Collections.Generic;

namespace ET
{
    public static class TeamSceneComponentSystem
    {
        
        public static void OnDungeonOff(this TeamSceneComponent self, long userId)
        {
            TeamInfo teamInfo = self.GetTeamInfo(userId);
            if (teamInfo != null)
            {
                teamInfo.FubenInstanceId = 0;
            }
        }

        public static TeamInfo GetTeamInfo(this TeamSceneComponent self, long userId)
        {
            TeamInfo teamInfo = null;

            for (int i = 0; i < self.TeamList.Count; i++)
            {
                TeamInfo tempTeampInfo = self.TeamList[i];
                if (tempTeampInfo.TeamId == userId)
                {
                    teamInfo = tempTeampInfo;
                    break;
                }

                for (int k = tempTeampInfo.PlayerList.Count - 1; k >= 0; k--)
                {
                    if (tempTeampInfo.PlayerList[k].UserID == userId)
                    {
                        teamInfo = tempTeampInfo;
                        break;
                    }
                }
            }
            return teamInfo;
        }

        public static async ETTask OnRecvUnitLeave(this TeamSceneComponent self, long userId)
        {
            TeamInfo teamInfo = self.GetTeamInfo(userId);

            List<long> userIDList = new List<long>();
            for (int i = 0; i < teamInfo.PlayerList.Count; i++)
            {
                userIDList.Add(teamInfo.PlayerList[i].UserID);
            }

            
            for (int k = teamInfo.PlayerList.Count - 1; k >= 0; k--)
            {
                if (teamInfo.PlayerList[k].UserID == userId)
                {
                    teamInfo.PlayerList.RemoveAt(k);
                    break;
                }
            }

            //队长离开，选出新的队长
            if (teamInfo.PlayerList.Count == 0)
            {
                self.TeamList.Remove(teamInfo);
            }

            long gateServerId = StartSceneConfigCategory.Instance.GetBySceneName(self.DomainZone(), "Gate1").InstanceId;
            for (int i = 0; i < userIDList.Count; i++)
            {

                G2T_GateUnitInfoResponse g2M_UpdateUnitResponse = (G2T_GateUnitInfoResponse)await ActorMessageSenderComponent.Instance.Call
                    (gateServerId, new T2G_GateUnitInfoRequest()
                    {
                        UserID = userIDList[i]
                    });

                if (g2M_UpdateUnitResponse.PlayerState == (int)PlayerState.Game && g2M_UpdateUnitResponse.SessionInstanceId > 0)
                {
                    M2C_TeamUpdateResult m2C_HorseNoticeInfo = new M2C_TeamUpdateResult() { TeamInfo = teamInfo };
                    MessageHelper.SendActor(g2M_UpdateUnitResponse.SessionInstanceId, m2C_HorseNoticeInfo);
                }
            }
        }

        public static async ETTask OnUnitChangeStatus(this TeamSceneComponent self, M2A_ChangeStatusRequest request)
        {
            if (request.GateSessionId == 0)
            {
                long userId = request.UserID;
                TeamInfo teamInfo = null;

                for (int i = 0; i < self.TeamList.Count; i++)
                {
                    TeamInfo tempTeampInfo = self.TeamList[i];
                    if (tempTeampInfo.TeamId == userId)
                    {
                        teamInfo = tempTeampInfo;
                        if (teamInfo.PlayerList.Count > 0)
                        {
                            teamInfo.PlayerList.RemoveAt(0);
                        }
                        else
                        {
                            Log.Debug($"TeamScene UnitChangeStatus {request.UnitId}");
                        }
                        self.TeamList.Remove(teamInfo);
                        break;
                    }

                    for (int k = tempTeampInfo.PlayerList.Count - 1; k >= 0; k--)
                    {
                        if (tempTeampInfo.PlayerList[k].UserID == userId)
                        {
                            teamInfo = tempTeampInfo;
                            tempTeampInfo.PlayerList.RemoveAt(k);
                            break;
                        }
                    }

                    if (teamInfo != null)
                    {
                        break;
                    }
                }

                if (teamInfo != null)
                {
                    M2C_TeamUpdateResult m2C_HorseNoticeInfo = new M2C_TeamUpdateResult() { TeamInfo = teamInfo };
                    long gateServerId = StartSceneConfigCategory.Instance.GetBySceneName(self.DomainZone(), "Gate1").InstanceId;

                    if (teamInfo.TeamId == userId)
                    {
                        m2C_HorseNoticeInfo.TeamInfo = new TeamInfo();
                        m2C_HorseNoticeInfo.TeamInfo.TeamId = teamInfo.TeamId;
                    }

                    for (int i = 0; i < teamInfo.PlayerList.Count; i++)
                    {

                        G2T_GateUnitInfoResponse g2M_UpdateUnitResponse = (G2T_GateUnitInfoResponse)await ActorMessageSenderComponent.Instance.Call
                            (gateServerId, new T2G_GateUnitInfoRequest()
                            {
                                UserID = teamInfo.PlayerList[i].UserID
                            });

                        if (g2M_UpdateUnitResponse.PlayerState == (int)PlayerState.Game && g2M_UpdateUnitResponse.SessionInstanceId > 0)
                        {
                            MessageHelper.SendActor(g2M_UpdateUnitResponse.SessionInstanceId, m2C_HorseNoticeInfo);
                        }
                    }
                }
            }
        }
    }
}
