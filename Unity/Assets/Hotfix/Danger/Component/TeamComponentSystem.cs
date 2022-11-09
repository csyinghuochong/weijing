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

            C2T_TeamDungeonAgreeRequest c2M_SkillSet = new C2T_TeamDungeonAgreeRequest() { TeamId = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.UserId, TeamPlayerInfo = m2C_Team };
            T2C_TeamDungeonAgreeResponse m2C_SkillSet = (T2C_TeamDungeonAgreeResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(c2M_SkillSet);
            return m2C_SkillSet.Error;
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

        public static async ETTask<int> SendTeamApply(this TeamComponent self, long teamId, int fubenId = 0)
        {
            try
            {
                TeamInfo teamInfo = self.ZoneScene().GetComponent<TeamComponent>().GetSelfTeam();
                if (teamInfo != null && teamInfo.SceneId != 0)
                {
                    EventType.CommonHintError.Instance.errorValue = ErrorCore.ERR_IsHaveTeam;
                    EventSystem.Instance.PublishClass(EventType.CommonHintError.Instance);
                    return ErrorCore.ERR_IsHaveTeam;
                }

                if (fubenId != 0)
                {
                    UserInfoComponent userInfoComponent = self.ZoneScene().GetComponent<UserInfoComponent>();
                    SceneConfig sceneConfig = SceneConfigCategory.Instance.Get(fubenId);
                    //判断等级
                    if (userInfoComponent.UserInfo.Lv < sceneConfig.EnterLv)
                    {
                        EventType.CommonHintError.Instance.errorValue = ErrorCore.ERR_LevelIsNot;
                        EventSystem.Instance.PublishClass(EventType.CommonHintError.Instance);
                        return ErrorCore.ERR_LevelIsNot;
                    }
                    //判断次数
                    if (userInfoComponent.UserInfo.TeamDungeonTimes >= int.Parse(GlobalValueConfigCategory.Instance.Get(19).Value))
                    {
                        EventType.CommonHintError.Instance.errorValue = ErrorCore.ERR_TimesIsNot;
                        EventSystem.Instance.PublishClass(EventType.CommonHintError.Instance);
                        return ErrorCore.ERR_TimesIsNot;
                    }

                }

                C2T_TeamDungeonApplyRequest c2M_ItemHuiShouRequest = new C2T_TeamDungeonApplyRequest()
                {
                    TeamId = teamId,
                    TeamPlayerInfo = UnitHelper.GetSelfTeamPlayerInfo(self.ZoneScene())
                };
                T2C_TeamDungeonApplyResponse r2c_roleEquip = (T2C_TeamDungeonApplyResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(c2M_ItemHuiShouRequest);
                return r2c_roleEquip.Error;
            }
            catch (Exception e)
            {
                Log.Error(e);
                return ErrorCore.ERR_NetWorkError;
            }
        }

        public static TeamInfo GetCanJoinTeam(this TeamComponent self, int sceneId)
        {
            List<TeamInfo> teamList = new List<TeamInfo>();
            for (int i = 0; i < self.TeamList.Count; i++)
            {
                TeamInfo teamInfo = self.TeamList[i];
                if (teamInfo.SceneId == sceneId && teamInfo.PlayerList.Count < 3)
                {
                    teamList.Add(teamInfo);
                }
            }
            if (teamList.Count > 0)
            {
                return teamList[RandomHelper.RandomNumber(0, teamList.Count)];
            }
            else
            {
                return null;
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
                if (teamInfo==null || teamInfo.PlayerList[0].UserID != userInfoComponent.UserInfo.UserId)
                {
                    return ErrorCore.ERR_IsNotLeader;
                }

                int totalTimes = int.Parse(GlobalValueConfigCategory.Instance.Get(19).Value);
                int times = self.ZoneScene().GetComponent<UserInfoComponent>().GetTeamDungeonTimes();
                if (totalTimes - times <= 0)
                {
                    return ErrorCore.ERR_TimesIsNot;
                }
                SceneConfig sceneConfig = SceneConfigCategory.Instance.Get(teamInfo.SceneId);
                if (teamInfo.PlayerList.Count < sceneConfig.PlayerLimit)
                {
                    return ErrorCore.ERR_PlayerIsNot;
                }

                C2T_TeamDungeonOpenRequest c2M_ItemHuiShouRequest = new C2T_TeamDungeonOpenRequest() { UserID = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.UserId };
                T2C_TeamDungeonOpenResponse r2c_roleEquip = (T2C_TeamDungeonOpenResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(c2M_ItemHuiShouRequest);
                return r2c_roleEquip.Error;
            }
            catch (Exception e)
            {
                Log.Error(e);
                return ErrorCore.ERR_NetWorkError;
            }
        }

        //创建组队副本
        public static async ETTask<int> RequestTeamDungeonCreate(this TeamComponent self, int fubenId)
        {
            try
            {
                int totalTimes = int.Parse(GlobalValueConfigCategory.Instance.Get(19).Value);
                int times = self.ZoneScene().GetComponent<UserInfoComponent>().GetTeamDungeonTimes();
                if (totalTimes - times <= 0)
                {
                    return ErrorCore.ERR_TimesIsNot;
                }

                UserInfoComponent userInfoComponent = self.ZoneScene().GetComponent<UserInfoComponent>();
                SceneConfig sceneConfig = SceneConfigCategory.Instance.Get(fubenId);
                if (userInfoComponent.UserInfo.Lv < sceneConfig.CreateLv)
                {
                    return ErrorCore.ERR_LevelIsNot;
                }

                //有队伍非队长返回
                TeamInfo teamInfo = self.ZoneScene().GetComponent<TeamComponent>().GetSelfTeam();
                if (teamInfo != null)
                {
                    if (teamInfo.SceneId == fubenId)
                    {
                        return ErrorCore.ERR_IsHaveTeam;
                    }
                    if (teamInfo.PlayerList[0].UserID != self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.UserId)
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
                }

                C2T_TeamDungeonCreateRequest c2M_ItemHuiShouRequest = new C2T_TeamDungeonCreateRequest()
                {
                    FubenId = fubenId,
                    TeamPlayerInfo = UnitHelper.GetSelfTeamPlayerInfo(self.ZoneScene())
                };
                //创建队伍
                T2C_TeamDungeonCreateResponse r2c_roleEquip = (T2C_TeamDungeonCreateResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(c2M_ItemHuiShouRequest);
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
