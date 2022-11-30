using System;
using System.Collections.Generic;

namespace ET
{
    public static class TeamSceneComponentSystem
    {

        public static void  CreateTeamDungeon(this TeamSceneComponent self, TeamInfo teamInfo)
        {
            //动态创建副本
            long fubenid = IdGenerater.Instance.GenerateId();
            long fubenInstanceId = IdGenerater.Instance.GenerateInstanceId();
            Scene fubnescene = SceneFactory.Create(self, fubenid, fubenInstanceId, self.DomainZone(), "TeamDungeon" + fubenid.ToString(), SceneType.Fuben);
            TeamDungeonComponent teamDungeonComponent = fubnescene.AddComponent<TeamDungeonComponent>();
            MapComponent mapComponent = fubnescene.GetComponent<MapComponent>();
            mapComponent.SetMapInfo((int)SceneTypeEnum.TeamDungeon, teamInfo.SceneId, 0);
            mapComponent.NavMeshId = SceneConfigCategory.Instance.Get(teamInfo.SceneId).MapID.ToString();
            teamDungeonComponent.TeamInfo = teamInfo;
            teamDungeonComponent.EnterTime = TimeHelper.ServerNow();
            teamInfo.FubenInstanceId = fubenInstanceId;
            teamInfo.FubenUUId = fubenid;
            Game.Scene.GetComponent<RecastPathComponent>().Update(int.Parse(mapComponent.NavMeshId));
            FubenHelp.CreateMonsterList(fubnescene, SceneConfigCategory.Instance.Get(teamInfo.SceneId).CreateMonster);
            TransferHelper.NoticeFubenCenter(fubnescene, 1).Coroutine();
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

        public static long GetTeamInfoId(this TeamSceneComponent self, long userId)
        {
            TeamInfo teamInfo = self.GetTeamInfo(userId);
            return teamInfo != null ? teamInfo.TeamId : 0;
        }

        public static TeamInfo CreateTeamInfo(this TeamSceneComponent self, TeamPlayerInfo teamPlayerInfo, int fubenId)
        {
            TeamInfo teamInfo = self.GetTeamInfo(teamPlayerInfo.UserID);
            if (teamInfo != null)
            {
                Log.Error($"teamInfo != null {teamPlayerInfo.UserID}");
                return teamInfo;
            }
            teamInfo = new TeamInfo() { TeamId = teamPlayerInfo.UserID, SceneId = fubenId };
            teamInfo.PlayerList.Add(teamPlayerInfo);
            self.TeamList.Add(teamInfo);
            return teamInfo;
        }

        public static async ETTask SyncTeamInfo(this TeamSceneComponent self, TeamInfo teamInfo, List<TeamPlayerInfo> userIds)
        {
            M2C_TeamUpdateResult m2C_HorseNoticeInfo = self.m2C_TeamUpdateResult;
            m2C_HorseNoticeInfo.TeamInfo = teamInfo;
            T2M_TeamUpdateRequest t2M_TeamUpdateRequest = self.t2M_TeamUpdateRequest;

            long gateServerId = DBHelper.GetGateServerId(self.DomainZone());
            for (int i = 0; i < userIds.Count; i++)
            {
                long userId = userIds[i].UserID;
                G2T_GateUnitInfoResponse g2M_UpdateUnitResponse = (G2T_GateUnitInfoResponse)await ActorMessageSenderComponent.Instance.Call
                    (gateServerId, new T2G_GateUnitInfoRequest()
                    {
                        UserID = userId
                    });

                if (g2M_UpdateUnitResponse.PlayerState == (int)PlayerState.Game && g2M_UpdateUnitResponse.SessionInstanceId > 0)
                {
                    t2M_TeamUpdateRequest.TeamId = self.GetTeamInfoId(userId);
                    MessageHelper.SendActor(g2M_UpdateUnitResponse.SessionInstanceId, m2C_HorseNoticeInfo);
                    MessageHelper.SendToLocationActor(userId, t2M_TeamUpdateRequest);
                }
            }
        }

        /// <summary>
        /// 离开队伍
        /// </summary>
        /// <param name="self"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        public static  void OnRecvUnitLeave(this TeamSceneComponent self, long userId, bool exitgame = false)
        {
            Log.Debug($"TeamSceneComponent Leave {userId} {exitgame}");
            TeamInfo teamInfo = self.GetTeamInfo(userId);
            if (teamInfo == null)
            {
                return;
            }
            //玩家Id
            List<TeamPlayerInfo> userIDList = new List<TeamPlayerInfo>();
            userIDList.AddRange(teamInfo.PlayerList);
            for (int i = userIDList.Count - 1; i >= 0; i--)
            {
                if (exitgame && userIDList[i].UserID == userId)
                {
                    userIDList.RemoveAt(i);
                }
            }

            for (int k = teamInfo.PlayerList.Count - 1; k >= 0; k--)
            {
                if (teamInfo.PlayerList[k].UserID == userId)
                {
                    teamInfo.PlayerList.RemoveAt(k);
                    break;
                }
            }

            if (teamInfo.PlayerList.Count == 0 || teamInfo.TeamId == userId)
            {
                self.TeamList.Remove(teamInfo);
            }

            self.SyncTeamInfo(teamInfo, userIDList).Coroutine();
        }

        /// <summary>
        /// 返回主城
        /// </summary>
        /// <param name="self"></param>
        /// <param name="unitId"></param>
        /// <returns></returns>
        public static void  OnUnitReturn(this TeamSceneComponent self, Scene fubnescene, long unitId)
        {
            TeamDungeonComponent teamDungeonComponent = fubnescene.GetComponent<TeamDungeonComponent>();
            if (teamDungeonComponent.IsHavePlayer())
            {
                return;
            }
            TeamInfo teamInfo = self.GetTeamInfo(unitId);
            if (teamInfo != null)
            {
                teamInfo.FubenUUId = 0;
                teamInfo.FubenInstanceId = 0;
            }
            Log.Debug($"TeamDungeonDispose {teamDungeonComponent.TeamInfo.TeamId}{fubnescene.InstanceId}");
            TransferHelper.NoticeFubenCenter(fubnescene, 2).Coroutine();
            fubnescene.Dispose();
        }

        /// <summary>
        /// 离开副本
        /// </summary>
        /// <param name="self"></param>
        /// <param name="unitId"></param>
        /// <returns></returns>
        public static void  OnUnitDisconnect(this TeamSceneComponent self, Scene fubnescene, long unitId)
        {
            TeamDungeonComponent teamDungeonComponent = fubnescene.GetComponent<TeamDungeonComponent>();
            TeamInfo teamInfo = self.GetTeamInfo(teamDungeonComponent.TeamInfo.TeamId);
            if (teamDungeonComponent.IsHavePlayer())
            {
                return;
            }
            if (teamInfo != null)
            {
                teamInfo.FubenUUId = 0;
                teamInfo.FubenInstanceId = 0;
            }
            Log.Debug($"TeamDungeonDispose {teamDungeonComponent.TeamInfo.TeamId}{fubnescene.InstanceId}");
            TransferHelper.NoticeFubenCenter(fubnescene, 2).Coroutine();
            fubnescene.Dispose();
        }
    }
}
