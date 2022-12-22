using System;
using System.Collections.Generic;

namespace ET
{
    public static class TeamComponentSystem
    {
        public static async ETTask AgreeTeamInvite(this TeamComponent self, M2C_TeamInviteResult m2C_Team)
        {
            C2T_TeamAgreeRequest c2M_SkillSet = new C2T_TeamAgreeRequest()
            {
                TeamPlayerInfo_1 = m2C_Team.TeamPlayerInfo,
                TeamPlayerInfo_2 = UnitHelper.GetSelfTeamPlayerInfo(self.ZoneScene())
            };
            T2C_TeamAgreeResponse m2C_SkillSet = (T2C_TeamAgreeResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(c2M_SkillSet);
        }

        public static void OnRecvTeamApply(this TeamComponent self, TeamPlayerInfo teamPlayerInfo)
        {
            bool have = false;
            for (int i = 0; i < self.ApplyList.Count; i++)
            {
                if (self.ApplyList[i].UserID == teamPlayerInfo.UserID)
                {
                    self.ApplyList[i] = teamPlayerInfo;
                    have = true;
                    break;
                }
            }
            if (!have && self.ApplyList.Count < 10)
            {
                self.ApplyList.Add(teamPlayerInfo);
            }

            self.ZoneScene().GetComponent<ReddotComponent>().AddReddont(ReddotType.TeamApply);
        }

        public static async ETTask<int> AgreeTeamApply(this TeamComponent self, TeamPlayerInfo m2C_Team, int code)
        {
            for (int i = self.ApplyList.Count - 1; i >= 0; i--)
            {
                if (self.ApplyList[i].UserID == m2C_Team.UserID)
                {
                    self.ApplyList.RemoveAt(i);
                    break;
                }
            }
            if (code == 0)
            {
                return ErrorCore.ERR_Success;
            }

            C2T_TeamDungeonAgreeRequest request = new C2T_TeamDungeonAgreeRequest() { TeamId = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.UserId, TeamPlayerInfo = m2C_Team };
            T2C_TeamDungeonAgreeResponse repose = (T2C_TeamDungeonAgreeResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(request);
            return repose.Error;
        }

        public static async ETTask SendLeaveRequest(this TeamComponent self)
        {
            //TeamInfo teamInfo = self.GetSelfTeam();
            //bool isLeader = teamInfo != null && teamInfo.TeamId == self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.UserId;
            MapComponent mapComponent = self.ZoneScene().GetComponent<MapComponent>();
            if (mapComponent.SceneTypeEnum == (int)SceneTypeEnum.TeamDungeon)
            {
                HintHelp.GetInstance().ShowHint("副本中不能离开队伍");
                return;
            }
            C2T_TeamLeaveRequest c2M_ItemHuiShouRequest = new C2T_TeamLeaveRequest() { UserId = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.UserId };
            T2C_TeamLeaveResponse r2c_roleEquip = (T2C_TeamLeaveResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(c2M_ItemHuiShouRequest);
        }

        public static async ETTask SendKickOutRequest(this TeamComponent self, long userId)
        {
            MapComponent mapComponent = self.ZoneScene().GetComponent<MapComponent>();
            if (mapComponent.SceneTypeEnum == (int)SceneTypeEnum.TeamDungeon)
            {
                HintHelp.GetInstance().ShowHint("副本中不能踢人");
                return;
            }

            C2T_TeamKickOutRequest c2M_ItemHuiShouRequest = new C2T_TeamKickOutRequest() { UserId = userId };
            T2C_TeamKickOutResponse r2c_roleEquip = (T2C_TeamKickOutResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(c2M_ItemHuiShouRequest);
        }

        /// <summary>
        /// 申请组队
        /// </summary>
        /// <param name="self"></param>
        /// <param name="teamId"></param>
        /// <param name="fubenId"></param>
        /// <returns></returns>
        public static async ETTask<int> SendTeamApply(this TeamComponent self, long teamId, int fubenId, int fubenType, int leaderLv)
        {
            try
            {
                if (fubenId == 0)
                {
                    return ErrorCore.ERR_TeamIsFull;
                }
                TeamInfo teamInfo = self.ZoneScene().GetComponent<TeamComponent>().GetSelfTeam();
                if (teamInfo != null && teamInfo.SceneId != 0)
                {
                    EventType.CommonHintError.Instance.errorValue = ErrorCore.ERR_IsHaveTeam;
                    EventSystem.Instance.PublishClass(EventType.CommonHintError.Instance);
                    return ErrorCore.ERR_IsHaveTeam;
                }
                if (fubenId != 0)
                {
                    int errorCode = self.CheckTimesAndLevel(fubenId, fubenType);
                    if (errorCode != 0)
                    {
                        return errorCode;
                    }
                }
                UserInfo userInfo = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo;
                if (fubenType == TeamFubenType.XieZhu && userInfo.Lv > leaderLv)
                {
                    return ErrorCore.ERR_TeamerLevelIsNot;
                }

                C2T_TeamDungeonApplyRequest request = new C2T_TeamDungeonApplyRequest()
                {
                    TeamId = teamId,
                    TeamPlayerInfo = UnitHelper.GetSelfTeamPlayerInfo(self.ZoneScene())
                };
                T2C_TeamDungeonApplyResponse response = (T2C_TeamDungeonApplyResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(request);
                return response.Error;
            }
            catch (Exception e)
            {
                Log.Error(e);
                return ErrorCore.ERR_NetWorkError;
            }
        }

        public static TeamInfo GetTeamInfo(this TeamComponent self, long teamId)
        {
            for (int i = 0; i < self.TeamList.Count; i++)
            {
                TeamInfo teamInfo = self.TeamList[i];
                if (teamInfo.TeamId == teamId)
                {
                    return teamInfo;
                }
            }
            return null;
        }

        public static TeamInfo GetSelfTeam(this TeamComponent self)
        {
            long userId = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.UserId;
   
            for (int i = 0; i < self.TeamList.Count; i++)
            {
                TeamInfo teamInfo = self.TeamList[i];
                for (int k = 0; k < teamInfo.PlayerList.Count; k++)
                {
                    if (teamInfo.PlayerList[k].UserID == userId)
                    {
                        return teamInfo;
                    }
                }
            }
            return null;
        }

        public static bool IsHaveTeam(this TeamComponent self)
        {
            return self.GetSelfTeam()!= null;
        }

        public static bool IsTeamLeader(this TeamComponent self)
        {
            TeamInfo teamInfo = self.GetSelfTeam();
            long myUserId = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.UserId;
            return teamInfo != null && teamInfo.PlayerList[0].UserID == myUserId;
        }

        public static void OnRecvTeamUpdate(this TeamComponent self, M2C_TeamUpdateResult message)
        {
            bool haveTeam = false;
            for (int i = self.TeamList.Count - 1; i >= 0; i--)
            {
                if (self.TeamList[i].TeamId != message.TeamInfo.TeamId)
                {
                    continue;
                }
                if (message.TeamInfo.PlayerList.Count == 0)
                {
                    self.TeamList.RemoveAt(i);
                }
                else
                {
                    self.TeamList[i] = message.TeamInfo;
                }
                haveTeam = true;
                break;
            }
            if (!haveTeam && message.TeamInfo.PlayerList.Count > 0)
            {
                self.TeamList.Add(message.TeamInfo);
            }

            HintHelp.GetInstance().DataUpdate(DataType.TeamUpdate);
        }

        //获取队伍列表
        public static async ETTask<int> RequestTeamDungeonList(this TeamComponent self)
        {
            try
            {
                C2T_TeamDungeonInfoRequest c2M_ItemHuiShouRequest = new C2T_TeamDungeonInfoRequest() { UserId = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.UserId };
                T2C_TeamDungeonInfoResponse r2c_roleEquip = (T2C_TeamDungeonInfoResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(c2M_ItemHuiShouRequest);
                self.TeamList = r2c_roleEquip.TeamList;
                return r2c_roleEquip.Error;
            }
            catch (Exception e)
            {
                Log.Error(e);
                return ErrorCore.ERR_NetWorkError;
            }
        }

        //开启组队副本
        public static async ETTask<int> RequestTeamDungeonOpen(this TeamComponent self)
        {
            try
            {
                TeamComponent teamComponent = self.ZoneScene().GetComponent<TeamComponent>();
                UserInfoComponent userInfoComponent = self.ZoneScene().GetComponent<UserInfoComponent>();
                TeamInfo teamInfo = teamComponent.GetSelfTeam();
                int errorCode = self.CheckTimesAndLevel(teamInfo.SceneId, teamInfo.FubenType);
                if (errorCode != ErrorCore.ERR_Success)
                {
                    return errorCode;
                }
                errorCode = self.CheckCanOpenFuben(teamInfo.SceneId, teamInfo.FubenType);
                if (errorCode != ErrorCore.ERR_Success)
                {
                    return errorCode;
                }
                SceneConfig sceneConfig = SceneConfigCategory.Instance.Get(teamInfo.SceneId);
                if (teamInfo.PlayerList.Count < sceneConfig.PlayerLimit)
                {
                    return ErrorCore.ERR_PlayerIsNot;
                }

                C2M_TeamDungeonOpenRequest c2M_ItemHuiShouRequest = new C2M_TeamDungeonOpenRequest() { UserID = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.UserId, FubenType = self.FubenType };
                M2C_TeamDungeonOpenResponse r2c_roleEquip = (M2C_TeamDungeonOpenResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(c2M_ItemHuiShouRequest);
                return r2c_roleEquip.Error;
            }
            catch (Exception e)
            {
                Log.Error(e);
                return ErrorCore.ERR_NetWorkError;
            }
        }

        public static int CheckTimesAndLevel(this TeamComponent self, int fubenId, int fubenType)
        {
            if (fubenType == TeamFubenType.Normal || fubenType == TeamFubenType.ShenYuan)
            {
                int totalTimes = int.Parse(GlobalValueConfigCategory.Instance.Get(19).Value);
                int times = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene()).GetTeamDungeonTimes();
                if (totalTimes - times <= 0)
                {
                    return ErrorCore.ERR_TimesIsNot;
                }
            }
            else
            {
                int totalTimes = int.Parse(GlobalValueConfigCategory.Instance.Get(19).Value);
                int times = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene()).GetTeamDungeonTimes();

                int totalTimes_2 = int.Parse(GlobalValueConfigCategory.Instance.Get(74).Value);
                int times_2 = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene()).GetTeamDungeonXieZhu();

                if (totalTimes - times <= 0 && totalTimes_2 - times_2 <= 0)
                {
                    return ErrorCore.ERR_TimesIsNot;
                }
            }

            UserInfoComponent userInfoComponent = self.ZoneScene().GetComponent<UserInfoComponent>();
            SceneConfig sceneConfig = SceneConfigCategory.Instance.Get(fubenId);
            if (userInfoComponent.UserInfo.Lv < sceneConfig.CreateLv)
            {
                return ErrorCore.ERR_LevelIsNot;
            }
            return ErrorCore.ERR_Success;
        }

        public static int CheckCanOpenFuben(this TeamComponent self, int fubenId, int fubenType)
        {
            SceneConfig sceneConfig = SceneConfigCategory.Instance.Get(fubenId);
            //有队伍非队长返回
            TeamInfo teamInfo = self.ZoneScene().GetComponent<TeamComponent>().GetSelfTeam();
            UserInfo userInfo = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo;
            if (teamInfo != null)
            {
                if (teamInfo != null && teamInfo.PlayerList[0].UserID != userInfo.UserId)
                {
                    return ErrorCore.ERR_IsNotLeader;
                }
                for (int i = 0; i < teamInfo.PlayerList.Count; i++)
                {
                    if (teamInfo.PlayerList[i].PlayerLv < sceneConfig.EnterLv)
                    {
                        return ErrorCore.ERR_TeamerLevelIsNot;
                    }
                }

                /*
                for (int i = 0; i < teamInfo.PlayerList.Count; i++)
                {
                    if (fubenType == TeamFubenType.XieZhu && teamInfo.PlayerList[i].PlayerLv < userInfo.Lv - 10)
                    {
                        return ErrorCore.ERR_TeamerLevelIsNot;
                    }
                }
                */
            }
            return ErrorCore.ERR_Success;
        }

        //创建组队副本
        public static async ETTask<int> RequestTeamDungeonCreate(this TeamComponent self, int fubenId, int fubenType)
        {
            try
            {
                TeamInfo teamInfo = self.GetSelfTeam();
                UserInfo userInfo = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo;
                if (teamInfo != null && teamInfo.SceneId != 0)
                {
                    return ErrorCore.ERR_IsNotLeader;
                }

                int errorCode = self.CheckTimesAndLevel(fubenId,  fubenType);
                if (errorCode != ErrorCore.ERR_Success)
                {
                    return errorCode;
                }
                errorCode = self.CheckCanOpenFuben(fubenId, fubenType);
                if (errorCode != ErrorCore.ERR_Success)
                {
                    return errorCode;
                }
               
                C2M_TeamDungeonCreateRequest c2M_ItemHuiShouRequest = new C2M_TeamDungeonCreateRequest()
                {
                    FubenId = fubenId,
                    FubenType = fubenType,  
                    TeamPlayerInfo = UnitHelper.GetSelfTeamPlayerInfo(self.ZoneScene())
                };
                //创建队伍
                M2C_TeamDungeonCreateResponse r2c_roleEquip = (M2C_TeamDungeonCreateResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(c2M_ItemHuiShouRequest);
                self.FubenType = r2c_roleEquip.FubenType;
                return r2c_roleEquip.Error;
            }
            catch (Exception e)
            {
                Log.Error(e);
                return ErrorCore.ERR_NetWorkError;
            }
        }

    }
}
