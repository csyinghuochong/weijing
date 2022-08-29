using System;
using System.Collections.Generic;

namespace ET
{

    [ObjectSystem]
    public class UserInfoComponentAwakeSystem : AwakeSystem<UserInfoComponent>
    {
        public override void Awake(UserInfoComponent self)
        {

        }
    }

    public static class UserInfoComponentSystem
    {

#if SERVER
        public static void Check(this UserInfoComponent self)
        {
            self.TotalOnLineTime++;
            self.LingDiOnLine++;
            if (self.LingDiOnLine > 60)
            {
                self.LingDiOnLine = 0;
                self.OnRongyuChanChu(1, true);
            }
        }

        public static void CheckTiLi(this UserInfoComponent self)
        {
            long maxPilao = self.GetMaxPiLao(self.GetParent<Unit>().GetComponent<NumericComponent>());
            self.UserInfo.PiLao = Math.Min( maxPilao, self.UserInfo.PiLao );
        }

        public static void OnCheckLingDi(this UserInfoComponent self, long intervalTime)
        { 
            int minute = (int)intervalTime / 60000;
            self.LingDiOnLine += minute;
            self.OnRongyuChanChu(self.LingDiOnLine / 60, false);
            self.LingDiOnLine %= 60;
        }

        public static void OnRongyuChanChu(this UserInfoComponent self, int coefficient, bool notice)
        {
            if (coefficient == 0)
            {
                return;
            }
            Unit unit = self.GetParent<Unit>();
            int lingdiLv = unit.GetComponent<NumericComponent>().GetAsInt(NumericType.Ling_DiLv);
            LingDiConfig lingDiConfig = LingDiConfigCategory.Instance.Get(lingdiLv);

            //unit.GetComponent<UserInfoComponent>().UpdateRoleData(UserDataType.Exp, (coefficient *lingDiConfig.HoureExp).ToString(), notice).Coroutine();
            unit.GetComponent<UserInfoComponent>().UpdateRoleData(UserDataType.FangRong, (coefficient * lingDiConfig.HoureExp).ToString(), notice).Coroutine();
            unit.GetComponent<UserInfoComponent>().UpdateRoleData(UserDataType.RongYu, (coefficient * lingDiConfig.HoureHonor).ToString(), notice).Coroutine();
        }

        public static void OpenAll(this UserInfoComponent self)
        {
            self.UserInfo.FubenPassList.Clear();

            Dictionary<int, ChapterConfig> keyValuePairs = ChapterConfigCategory.Instance.GetAll();
            foreach (var item in keyValuePairs)
            {
                self.UserInfo.FubenPassList.Add( new FubenPassInfo()
                { 
                     FubenId  = item.Key,
                     Difficulty = (int)FubenDifficulty.DiYu
                });
            }
        }

        public static async ETTask OnLogin(this UserInfoComponent self, string remoteIp)
        {
            //跨天登录，则重新请求
            self.RemoteAddress = remoteIp;
            Unit unit = self.GetParent<Unit>();
            long currentTime = TimeHelper.ServerNow();
            DateTime dateTime = TimeInfo.Instance.ToDateTime(currentTime);
            long lastLoginTime = self.LastLoginTime;
            int updateType = 0;
            if (lastLoginTime != 0)
            {
                DateTime lastdateTime = TimeInfo.Instance.ToDateTime(lastLoginTime);
                updateType = dateTime.Day != lastdateTime.Day ? 0: (dateTime.Hour != lastdateTime.Hour && dateTime.Hour == 12 ? 12 : -1);
            }

            if (updateType == 0)
            {
                Log.ILog.Info($"task_updateTask1: { self.UserInfo.UserId}");
                self.OnZeroClockUpdate(false);
                unit.GetComponent<TaskComponent>().OnZeroClockUpdate(false);
                unit.GetComponent<EnergyComponent>().OnResetEnergyInfo();
                unit.GetComponent<HeroDataComponent>().OnZeroClockUpdate(false);
                unit.GetComponent<ActivityComponent>().OnZeroClockUpdate(self.UserInfo.Lv);
            }
            if (updateType == 12)
            {
                self.OnHour12Update(false);
            }

            unit.GetComponent<TaskComponent>().OnLogin();
            unit.GetComponent<HeroDataComponent>().OnLogin();
            unit.GetComponent<DBSaveComponent>().OnLogin();

            if (lastLoginTime != 0)
            {
                self.CheckTiLi();
                self.OnCheckLingDi(currentTime - lastLoginTime);
            }

            self.LastLoginTime = currentTime;
            UserInfo userInfo = self.UserInfo;
            long gateSeesionId = unit.GetComponent<UnitGateComponent>().GateSessionActorId;

            //聊天服注册
            long chatServerId = StartSceneConfigCategory.Instance.GetBySceneName(unit.DomainZone(), Enum.GetName(SceneType.Chat)).InstanceId;
            A2M_ChangeStatusResponse g_SendChatRequest = (A2M_ChangeStatusResponse)await ActorMessageSenderComponent.Instance.Call
                (chatServerId, new M2A_ChangeStatusRequest()
                {
                    SceneType = (int)SceneType.Chat,
                    UnitId = 1,
                    UserID = unit.GetComponent<UserInfoComponent>().UserInfo.UserId,
                    UnionId = userInfo.UnionId,
                    GateSessionId = gateSeesionId
                });
        }

        /// <summary>
        /// 中午12点刷新体力
        /// </summary>
        /// <param name="self"></param>
        /// <param name="notice"></param>
        public static void OnHour12Update(this UserInfoComponent self, bool notice)
        {
            long recoverPiLao = self.GetMaxPiLao(self.GetParent<Unit>().GetComponent<NumericComponent>()) - self.UserInfo.PiLao;
            recoverPiLao = Math.Min(recoverPiLao, 40);
            self.UpdateRoleData(UserDataType.PiLao, recoverPiLao.ToString(), notice).Coroutine();
        }

        public static void OnZeroClockUpdate(this UserInfoComponent self, bool notice)
        {
            int updatevalue = int.Parse(GlobalValueConfigCategory.Instance.Get(10).Value) - self.UserInfo.Vitality;
            self.UpdateRoleData(UserDataType.Vitality, updatevalue.ToString(), notice).Coroutine();
            self.UpdateRoleData(UserDataType.HuoYue, (0 - self.UserInfo.HuoYue).ToString(), notice).Coroutine();
            self.UpdateRoleData(UserDataType.TeamDungeonTimes,"0", notice).Coroutine();
            self.OnHour12Update(notice);
            self.GetParent<Unit>().GetComponent<NumericComponent>().ApplyValue(NumericType.ZeroClock, 1,  notice);
            self.LastLoginTime = TimeHelper.ServerNow();
            self.UserInfo.DayFubenTimes.Clear();
            self.UserInfo.ChouKaRewardIds.Clear();
        }

        public static UserInfo GetUserInfo(this UserInfoComponent self)
        {
            return self.UserInfo;
        }

        public static  void OnKillUnit(this UserInfoComponent self, Unit beKill)
        {
            UnitInfoComponent unitInfoComponent = beKill.GetComponent<UnitInfoComponent>();
            if (unitInfoComponent.Type != UnitType.Monster)
            {
                return;
            }
            if (unitInfoComponent.GetMonsterType() != (int)MonsterTypeEnum.Boss && self.UserInfo.PiLao <= 0)
            {
                return;
            }
            MonsterConfig mCof = MonsterConfigCategory.Instance.Get(beKill.GetComponent<UnitInfoComponent>().UnitCondigID);
            float expcoefficient = 3f;
            int addexp = (int)(expcoefficient * mCof.Exp);
            self.UpdateRoleData(UserDataType.Exp, addexp.ToString()).Coroutine();
        }

        public static void  UpdateRoleDataBroadcast(this UserInfoComponent self, UserDataType Type, string value)
        {
            Unit unit = self.GetParent<Unit>();
            M2C_RoleDataBroadcast m2C_BroadcastRoleData = self.m2C_RoleDataBroadcast;
            m2C_BroadcastRoleData.UnitId = unit.Id;
            m2C_BroadcastRoleData.UpdateType = (int)Type;
            m2C_BroadcastRoleData.UpdateTypeValue = value;
            MessageHelper.Broadcast(unit, m2C_BroadcastRoleData);
        }

        //需要通知客户端
        public static  async ETTask UpdateRoleData(this UserInfoComponent self, UserDataType Type, string value,  bool notice = true)
        {
            Unit unit = self.GetParent<Unit>();
            string saveValue = "";
            switch (Type)
            {
                case UserDataType.FangRong:
                    LingDiHelp.OnAddLingDiExp(unit, int.Parse(value), notice);
                    break;
                //名字应该在改名的协议处理
                case UserDataType.Name:
                    self.UserInfo.Name = value;
                    saveValue = self.UserInfo.Name;
                    break;
                case UserDataType.Exp:
                    self.Role_AddExp(long.Parse(value), notice);
                    saveValue = self.UserInfo.Exp.ToString();
                    break;
                case UserDataType.Lv:
                    self.UserInfo.Lv += int.Parse(value);
                    saveValue = self.UserInfo.Lv.ToString();
                    long maxHp = unit.GetComponent<NumericComponent>().GetAsLong((int)NumericType.Now_MaxHp);
                    unit.GetComponent<NumericComponent>().ApplyValue(NumericType.Now_Hp, maxHp, false);
                    unit.GetComponent<NumericComponent>().ApplyChange(null,NumericType.PointRemain, int.Parse(value) * 5, 0);
                    unit.GetComponent<TaskComponent>().OnUpdateLevel(self.UserInfo.Lv);
                    unit.GetComponent<ChengJiuComponent>().OnUpdateLevel(self.UserInfo.Lv);
                    self.UpdateRoleData(UserDataType.Sp, value,notice).Coroutine();
                    self.UpdateRankInfo().Coroutine();
                    break;
                case UserDataType.Sp:
                    self.UserInfo.Sp += int.Parse(value);
                    saveValue = self.UserInfo.Sp.ToString();
                    break;
                case UserDataType.Gold:
                    self.UserInfo.Gold += long.Parse(value);
                    saveValue = self.UserInfo.Gold.ToString();
                    unit.GetComponent<ChengJiuComponent>().OnGetGold(int.Parse(value));
                    unit.GetComponent<TaskComponent>().OnCostCoin(int.Parse(value));
                    break;
                case UserDataType.RongYu:
                    self.UserInfo.RongYu += long.Parse(value);
                    saveValue = self.UserInfo.RongYu.ToString();
                    break;
                case UserDataType.Diamond:
                    self.UserInfo.Diamond += long.Parse(value);
                    self.UserInfo.Diamond = Math.Max(self.UserInfo.Diamond, 0);
                    saveValue = self.UserInfo.Diamond.ToString();
                    break;
                case UserDataType.Occ:
                    break;
                case UserDataType.PiLao:
                    int maxValue = self.IsYueKaStates(unit.GetComponent<NumericComponent>()) ? int.Parse(GlobalValueConfigCategory.Instance.Get(26).Value) : int.Parse(GlobalValueConfigCategory.Instance.Get(10).Value);
                    long newValue = long.Parse(value) + self.UserInfo.PiLao;
                    newValue = Math.Min(Math.Max(0, newValue), maxValue);
                    self.UserInfo.PiLao = newValue;
                    saveValue = self.UserInfo.PiLao.ToString();
                    break;
                case UserDataType.HuoYue:
                    self.UserInfo.HuoYue += long.Parse(value);
                    saveValue = self.UserInfo.HuoYue.ToString();
                    break;
                case UserDataType.TeamDungeonTimes:
                    self.UserInfo.TeamDungeonTimes = int.Parse(value);
                    saveValue = self.UserInfo.TeamDungeonTimes.ToString();
                    break;
                case UserDataType.Union:
                    self.UserInfo.UnionId = long.Parse(value);
                    saveValue = self.UserInfo.UnionId.ToString();
                    break;
                case UserDataType.UnionName:
                    self.UserInfo.UnionName = value;
                    saveValue = self.UserInfo.UnionName;
                    break;
                case UserDataType.Combat:
                    self.UserInfo.Combat = int.Parse(value);
                    saveValue = self.UserInfo.Combat.ToString();
                    self.UpdateRankInfo().Coroutine();
                    break;
                case UserDataType.Vitality:
                    maxValue = int.Parse(GlobalValueConfigCategory.Instance.Get(10).Value);
                    long addValue = long.Parse(value);
                    if (self.UserInfo.Vitality + addValue > maxValue)
                    {
                        addValue = maxValue - self.UserInfo.Vitality;
                    }
                    self.UserInfo.Vitality += (int)addValue;
                    saveValue = self.UserInfo.Vitality.ToString();
                    break;
            }

            //发送更新值
            if (notice)
            {
                M2C_RoleDataUpdate m2C_RoleDataUpdate1 = self.m2C_RoleDataUpdate;
                m2C_RoleDataUpdate1.UpdateType = (int)Type;
                m2C_RoleDataUpdate1.UpdateTypeValue = saveValue;
                MessageHelper.SendToClient(self.GetParent<Unit>(), m2C_RoleDataUpdate1);
            }
            await ETTask.CompletedTask;
        }

        public static async ETTask UpdateRankInfo(this UserInfoComponent self)
        {
            long mapInstanceId = StartSceneConfigCategory.Instance.GetBySceneName(self.DomainZone(), Enum.GetName(SceneType.Rank)).InstanceId;

            Unit unit = self.GetParent<Unit>();
            RankingInfo rankPetInfo = new RankingInfo();
            UserInfoComponent userInfoComponent = unit.GetComponent<UserInfoComponent>();
            rankPetInfo.UserId = userInfoComponent.UserInfo.UserId;
            rankPetInfo.PlayerName = userInfoComponent.UserInfo.Name;
            rankPetInfo.PlayerLv = userInfoComponent.UserInfo.Lv;
            rankPetInfo.Combat = userInfoComponent.UserInfo.Combat;
            rankPetInfo.Occ = userInfoComponent.UserInfo.Occ;
            R2M_RankUpdateResponse m2m_TrasferUnitResponse = (R2M_RankUpdateResponse)await ActorMessageSenderComponent.Instance.Call
                     (mapInstanceId, new M2R_RankUpdateRequest() 
                     {
                            CampId = unit.GetComponent<NumericComponent>().GetAsInt(NumericType.CampID),
                            RankingInfo = rankPetInfo
                     });
        }

        //增加经验
        public static void Role_AddExp(this UserInfoComponent self, long addValue, bool notice)
        {
            ServerInfo serverInfo = self.DomainScene().GetComponent<ServerInfoComponent>().ServerInfo;
            
            float expAdd = ComHelp.GetExpAdd(self.UserInfo.Lv, serverInfo);

            //读取数据
            self.UserInfo.Exp = self.UserInfo.Exp + (int)(addValue * (1.0f + expAdd));

            //判定是否升级
            if (self.UserInfo.Lv >= GlobalValueConfigCategory.Instance.Get(41).Value2)
            {
                return;
            }
            ExpConfig xiulianconf1 =  ExpConfigCategory.Instance.Get(self.UserInfo.Lv);
            long upNeedExp = xiulianconf1.UpExp;
            if (self.UserInfo.Exp >= upNeedExp)
            {
                self.UserInfo.Exp -= upNeedExp;
                self.UpdateRoleData(UserDataType.Lv,"1", notice).Coroutine();
            }
        }
#endif
        public static void OnAddRevive(this UserInfoComponent self, int monsterId, long reviveTime)
        {
            for (int i = 0; i < self.UserInfo.MonsterRevives.Count; i++)
            {
                if (self.UserInfo.MonsterRevives[i].KeyId == monsterId)
                {
                    self.UserInfo.MonsterRevives[i].Value = reviveTime.ToString();
                    return;
                }
            }
            self.UserInfo.MonsterRevives.Add(new KeyValuePair() { KeyId = monsterId, Value = reviveTime.ToString() });
        }

        public static long GetReviveTime(this UserInfoComponent self, int monsterId)
        {
            for (int i = 0; i < self.UserInfo.MonsterRevives.Count; i++)
            {
                if (self.UserInfo.MonsterRevives[i].KeyId == monsterId)
                {
                    return long.Parse(self.UserInfo.MonsterRevives[i].Value);
                }
            }
            return 0;
        }

        public static long GetSceneFubenTimes(this UserInfoComponent self, int sceneId)
        {
            for (int i = 0; i < self.UserInfo.DayFubenTimes.Count; i++)
            {
                if (self.UserInfo.DayFubenTimes[i].KeyId == sceneId)
                {
                    return self.UserInfo.DayFubenTimes[i].Value;
                }
            }
            return 0;
        }

        public static void AddSceneFubenTimes(this UserInfoComponent self, int sceneId)
        {
            for (int i = 0; i < self.UserInfo.DayFubenTimes.Count; i++)
            {
                if (self.UserInfo.DayFubenTimes[i].KeyId == sceneId)
                {
                    self.UserInfo.DayFubenTimes[i].Value++;
                    return;
                }
            }
            self.UserInfo.DayFubenTimes.Add(new KeyValuePairInt() { KeyId = sceneId, Value =1 });
        }

        public static int GetTeamDungeonTimes(this UserInfoComponent self)
        {
            return self.UserInfo.TeamDungeonTimes;
        }

        public static string GetGameSettingValue(this UserInfoComponent self, GameSettingEnum gameSettingEnum)
        {
            for (int i = 0; i < self.UserInfo.GameSettingInfos.Count; i++)
            {
                if (self.UserInfo.GameSettingInfos[i].KeyId == (int)gameSettingEnum)
                    return self.UserInfo.GameSettingInfos[i].Value;
            }
            switch (gameSettingEnum)
            {
                case GameSettingEnum.Music:
                    return "1";
                case GameSettingEnum.Sound:
                    return "0";
                case GameSettingEnum.YanGan:
                    return "1";
                case GameSettingEnum.MusicVolume:
                    return "1";
                case GameSettingEnum.SoundVolume:
                    return "1";
                case GameSettingEnum.FenBianlLv:
                    return "1";
                case GameSettingEnum.Shadow:
                    return "1";
                default:
                    return "0";
            }
        }

        public static void UpdateGameSetting(this UserInfoComponent self, List<KeyValuePair> gameSettingInfos)
        {
            for (int i = 0; i < gameSettingInfos.Count; i++)
            {
                bool exist = false;
                for (int k = 0; k < self.UserInfo.GameSettingInfos.Count; k++)
                {
                    if (self.UserInfo.GameSettingInfos[k].KeyId == gameSettingInfos[i].KeyId)
                    {
                        exist = true;
                        self.UserInfo.GameSettingInfos[k].Value = gameSettingInfos[i].Value;
                        break;
                    }
                }
                if (!exist)
                {
                    self.UserInfo.GameSettingInfos.Add(gameSettingInfos[i]);
                }
            }
        }

        public static FubenPassInfo GetPassInfoByID(this UserInfoComponent self, int levelid)
        {
            for (int i = 0; i < self.UserInfo.FubenPassList.Count; i++)
            {
                if (self.UserInfo.FubenPassList[i].FubenId == levelid)
                {
                    return self.UserInfo.FubenPassList[i];
                }
            }
            return null;
        }

        public static void OnFubenSettlement(this UserInfoComponent self, int levelid, int difficulty)
        {
            FubenPassInfo fubenPassInfo = null;
            for (int i = 0; i < self.UserInfo.FubenPassList.Count; i++)
            {
                if (self.UserInfo.FubenPassList[i].FubenId == levelid)
                {
                    fubenPassInfo = self.UserInfo.FubenPassList[i];
                }
            }
            if (fubenPassInfo == null)
            {
                fubenPassInfo = new FubenPassInfo();
                fubenPassInfo.FubenId = levelid;
                self.UserInfo.FubenPassList.Add(fubenPassInfo);
            }
            fubenPassInfo.Difficulty = (difficulty > fubenPassInfo.Difficulty) ? difficulty : fubenPassInfo.Difficulty;
        }

        public static bool IsLevelPassed(this UserInfoComponent self, int levelid)
        {
            for (int i = 0; i < self.UserInfo.FubenPassList.Count; i++)
            {
                if (self.UserInfo.FubenPassList[i].FubenId == levelid)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool IsYueKaStates(this UserInfoComponent self, NumericComponent numericComponent)
        {
            long xx = TimeHelper.ServerNow();
            return numericComponent.GetAsLong(NumericType.YueKa_EndTime) >= xx;
        }

        public static int GetMaxPiLao(this UserInfoComponent self, NumericComponent numericComponent)
        {
            bool isYueKa = self.IsYueKaStates(numericComponent);
            return int.Parse(GlobalValueConfigCategory.Instance.Get(isYueKa?26:10).Value);
        }

        public static void UpdateYueKaTime(this UserInfoComponent self)
        {
            long xx = TimeHelper.ServerNow();
            GlobalValueConfig globalValueConfig = GlobalValueConfigCategory.Instance.Get(24);
            long time = (long.Parse(globalValueConfig.Value)) * 24 * 60 * 60 * 1000;
            //self.UserInfo.YueKaEndTime = xx + time;
            NumericComponent numericComponent = self.GetParent<Unit>().GetComponent<NumericComponent>();
            numericComponent.ApplyValue( NumericType.YueKa_EndTime, xx + time);
        }

        public static bool IsChapterOpen(this UserInfoComponent self, int chapterid)
        {
            if (chapterid == 1)
            {
                return true;
            }
            if (!ChapterSectionConfigCategory.Instance.Contain(chapterid))
            {
                return false;
            }

            ChapterSectionConfig chapterSectionConfig = ChapterSectionConfigCategory.Instance.Get(chapterid - 1);
            int[] RandomArea = chapterSectionConfig.RandomArea;

            for (int i = 0; i < RandomArea.Length; i++)
            {
                if (!self.IsLevelPassed(RandomArea[i]))
                {
                    return false;
                }
            }
            return true;
        }

    }

}
