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

        /// <summary>
        /// 离开队伍
        /// </summary>
        /// <param name="self"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        public static async ETTask OnRecvUnitLeave(this TeamSceneComponent self, long userId, bool exitgame = false)
        {
            TeamInfo teamInfo = self.GetTeamInfo(userId);
            if (teamInfo == null)
            {
                return;
            }

            //玩家Id
            List<long> userIDList = new List<long>();
            for (int i = 0; i < teamInfo.PlayerList.Count; i++)
            {
                userIDList.Add(teamInfo.PlayerList[i].UserID);
            }
            if (exitgame && userIDList.Contains(userId))
            {
                userIDList.Remove(userId);
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
                teamInfo.PlayerList.Clear();
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

        /// <summary>
        /// 返回主城
        /// </summary>
        /// <param name="self"></param>
        /// <param name="unitId"></param>
        /// <returns></returns>
        public static void  OnUnitReturn(this TeamSceneComponent self, Scene fubnescene, long unitId)
        {
            if (!fubnescene.GetComponent<TeamDungeonComponent>().IsHavePlayer())
            {
                TeamInfo teamInfo = self.GetTeamInfo(unitId);
                if (teamInfo != null)
                {
                    teamInfo.FubenUUId = 0;
                    teamInfo.FubenInstanceId = 0;
                }
                TransferHelper.NoticeFubenCenter(fubnescene, 2).Coroutine();
                fubnescene.Dispose();
            }
        }

        /// <summary>
        /// 离开副本
        /// </summary>
        /// <param name="self"></param>
        /// <param name="unitId"></param>
        /// <returns></returns>
        public static void  OnUnitDisconnect(this TeamSceneComponent self, Scene fubnescene, long unitId)
        {
            self.OnRecvUnitLeave(unitId, true).Coroutine();
            if (!fubnescene.GetComponent<TeamDungeonComponent>().IsHavePlayer())
            {
                TeamInfo teamInfo = self.GetTeamInfo(unitId);
                if (teamInfo != null)
                {
                    teamInfo.FubenUUId = 0;
                    teamInfo.FubenInstanceId = 0;
                }
                TransferHelper.NoticeFubenCenter(fubnescene, 2).Coroutine();
                fubnescene.Dispose();
            }
        }
    }
}
