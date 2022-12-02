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
            long maxPilao = self.GetParent<Unit>().GetMaxPiLao();
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
            unit.GetComponent<UserInfoComponent>().UpdateRoleData(UserDataType.FangRong, (coefficient * lingDiConfig.HoureExp).ToString(), notice);
            unit.GetComponent<UserInfoComponent>().UpdateRoleData(UserDataType.RongYu, (coefficient * lingDiConfig.HoureHonor).ToString(), notice);
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

        public static int GetTiLiIndex(this UserInfoComponent self, int hour_1)
        {
            if (hour_1 <6)
            {
                return 1;
            }
            if (hour_1 < 12)
            {
                return 2;
            }
            if (hour_1 < 20)
            {
                return 3;
            }
            return 4;
        }

        public static int GetTiLiTimes(this UserInfoComponent self, int hour_1, int hour_2)
        {
            int index_1 = self.GetTiLiIndex(hour_1);
            int index_2 = self.GetTiLiIndex(hour_2);
            if (index_1 > index_2)
            {
                return 0;
            }
            return index_2 - index_1;   
        }

        public static void  OnLogin(this UserInfoComponent self, string remoteIp)
        {
            //跨天登录，则重新请求
            self.RemoteAddress = remoteIp;
            Unit unit = self.GetParent<Unit>();
            long currentTime = TimeHelper.ServerNow();
            DateTime dateTime = TimeInfo.Instance.ToDateTime(currentTime);
            long lastLoginTime =  self.LastLoginTime;
            if (lastLoginTime != 0)
            {
                DateTime lastdateTime = TimeInfo.Instance.ToDateTime(lastLoginTime);
                int hour_1, hour_2 = 0;
                if (dateTime.Day != lastdateTime.Day)
                {
                    hour_1 = lastdateTime.Hour;
                    hour_2 = (dateTime.Day - lastdateTime.Day) * 24 + dateTime.Hour;
                    if (hour_2 - hour_1 >= 24)
                    {
                        self.RecoverPiLao(120, false);
                    }
                    else
                    {
                        int tiliTimes = self.GetTiLiTimes(lastdateTime.Hour, 24) + self.GetTiLiTimes(0, dateTime.Hour);
                        tiliTimes = Math.Min(tiliTimes, 4);
                        self.RecoverPiLao(tiliTimes * 30, false);
                    }

                    Log.Debug($"OnZeroClockUpdate [登录刷新]: {unit.Id}");
                    self.OnZeroClockUpdate(false);
                    unit.GetComponent<TaskComponent>().OnZeroClockUpdate(false);
                    unit.GetComponent<EnergyComponent>().OnResetEnergyInfo();
                    unit.GetComponent<HeroDataComponent>().OnZeroClockUpdate(false);
                    unit.GetComponent<ActivityComponent>().OnZeroClockUpdate(self.UserInfo.Lv);
                }
                else
                {
                    hour_1 = lastdateTime.Hour;
                    hour_2 = dateTime.Minute;

                    int tiliTimes = self.GetTiLiTimes(lastdateTime.Hour, dateTime.Hour);
                    tiliTimes = Math.Min(tiliTimes, 4);
                    self.RecoverPiLao(tiliTimes * 30, false);
                }
            }

            unit.GetComponent<TaskComponent>().OnLogin();
            unit.GetComponent<HeroDataComponent>().OnLogin();
            unit.GetComponent<DBSaveComponent>().OnLogin();
            unit.GetComponent<RechargeComponent>().OnLogin();
            if (lastLoginTime != 0)
            {
                self.CheckTiLi();
                self.OnCheckLingDi(currentTime - lastLoginTime);
            }

            self.LastLoginTime = currentTime;
            self.UserName = self.UserInfo.Name;
        }

        /// <summary>
        /// 0 6 12 20点各刷新30点体力
        /// </summary>
        /// <param name="self"></param>
        /// <param name="notice"></param>
        public static void OnHourUpdate(this UserInfoComponent self, int hour, bool notice)
        {
            if (hour ==0 || hour == 6 || hour == 12 || hour == 20)
            {
                self.RecoverPiLao(30, notice);
            }
        }

        public static void RecoverPiLao(this UserInfoComponent self, int addValue, bool notice)
        {
            Unit unit = self.GetParent<Unit>();
            Log.Debug($"RecoverPiLao [恢复体力] {unit.Id} {addValue}");
            long recoverPiLao = self.GetParent<Unit>().GetMaxPiLao() - self.UserInfo.PiLao;
            recoverPiLao = Math.Min(recoverPiLao, addValue);
            self.UpdateRoleData(UserDataType.PiLao, recoverPiLao.ToString(), notice);
        }

        public static void OnZeroClockUpdate(this UserInfoComponent self, bool notice)
        {
            int updatevalue = int.Parse(GlobalValueConfigCategory.Instance.Get(10).Value) - self.UserInfo.Vitality;
            self.UpdateRoleData(UserDataType.Vitality, updatevalue.ToString(), notice);
            self.UpdateRoleData(UserDataType.HuoYue, (0 - self.UserInfo.HuoYue).ToString(), notice);
            self.GetParent<Unit>().GetComponent<NumericComponent>().ApplyValue(NumericType.ZeroClock, 1,  notice);
            self.UserInfo.DayFubenTimes.Clear();
            self.UserInfo.ChouKaRewardIds.Clear();
            self.UserInfo.MysteryItems.Clear();
            self.LastLoginTime = TimeHelper.ServerNow();
        }

        public static UserInfo GetUserInfo(this UserInfoComponent self)
        {
            return self.UserInfo;
        }

        /// <summary>
        /// 杀怪经验
        /// </summary>
        /// <param name="self"></param>
        /// <param name="beKill"></param>
        public static  void OnKillUnit(this UserInfoComponent self, Unit beKill, int sceneType, int sceneId)
        {
            Unit main = self.GetParent<Unit>();
            if (beKill.Type != UnitType.Monster)
            {
                return;
            }
            int sonType = MonsterConfigCategory.Instance.Get(beKill.ConfigId).MonsterSonType;
            if (sceneType == SceneTypeEnum.LocalDungeon && sonType == 55)
            {
                self.OnAddChests(sceneId, beKill.ConfigId);
            }

            bool drop = true;
            if (ComHelp.IsSingleFuben(sceneType))
            {
                drop = main.GetComponent<UserInfoComponent>().UserInfo.PiLao > 0 || beKill.IsBoss();
            }
            if (!drop)
            {
                return;
            }

            MonsterConfig mCof = MonsterConfigCategory.Instance.Get(beKill.ConfigId);
            float expcoefficient = 1f;
            int addexp = (int)(expcoefficient * mCof.Exp);
            self.UpdateRoleData(UserDataType.Exp, addexp.ToString());
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

        public static int GetMysteryBuy(this UserInfoComponent self, int mysteryId)
        {
            for (int i = 0; i < self.UserInfo.MysteryItems.Count; i++)
            {
                if (self.UserInfo.MysteryItems[i].KeyId == mysteryId)
                {
                    return (int)self.UserInfo.MysteryItems[i].Value;
                }
            }
            return 0;
        }

        public static void OnMysteryBuy(this UserInfoComponent self, MysteryItemInfo itemInfo)
        {
            for (int i = 0; i < self.UserInfo.MysteryItems.Count; i++)
            {
                if (self.UserInfo.MysteryItems[i].KeyId == itemInfo.MysteryId)
                {
                    self.UserInfo.MysteryItems[i].Value += 1;
                    return;
                }
            }
            self.UserInfo.MysteryItems.Add(new KeyValuePairInt() { KeyId = itemInfo.MysteryId, Value = 1 });
        }

        //需要通知客户端
        public static  void UpdateRoleData(this UserInfoComponent self, UserDataType Type, string value,  bool notice = true)
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
                    unit.GetComponent<NumericComponent>().ApplyChange(null, NumericType.PointRemain, int.Parse(value) * 5, 0);
                    unit.GetComponent<TaskComponent>().OnUpdateLevel(self.UserInfo.Lv);
                    unit.GetComponent<ChengJiuComponent>().OnUpdateLevel(self.UserInfo.Lv);
                    self.UpdateRoleData(UserDataType.Sp, value, notice);
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
                case UserDataType.MaoXianExp:
                    unit.GetComponent<NumericComponent>().ApplyChange(null, NumericType.MaoXianExp, long.Parse(value), 0);
                    break;
                case UserDataType.Recharge:
                    RechargeHelp.SendDiamondToUnit(unit, int.Parse(value));
                    break;
                case UserDataType.PiLao:
                    int maxValue = unit.IsYueKaStates() ? int.Parse(GlobalValueConfigCategory.Instance.Get(26).Value) : int.Parse(GlobalValueConfigCategory.Instance.Get(10).Value);
                    long newValue = long.Parse(value) + self.UserInfo.PiLao;
                    newValue = Math.Min(Math.Max(0, newValue), maxValue);
                    self.UserInfo.PiLao = newValue;
                    saveValue = self.UserInfo.PiLao.ToString();
                    break;
                case UserDataType.HuoYue:
                    self.UserInfo.HuoYue += long.Parse(value);
                    saveValue = self.UserInfo.HuoYue.ToString();
                    break;
                case UserDataType.DungeonTimes:
                    unit.GetComponent<NumericComponent>().ApplyValue(NumericType.TeamDungeonTimes, unit.GetTeamDungeonTimes() - 1);
                    self.UserInfo.DayFubenTimes.Clear();
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
        }

        public static async ETTask UpdateRankInfo(this UserInfoComponent self)
        {
            Unit unit = self.GetParent<Unit>();
            if (unit.IsRobot())
            {
                return;
            }
            long mapInstanceId = StartSceneConfigCategory.Instance.GetBySceneName(self.DomainZone(), Enum.GetName(SceneType.Rank)).InstanceId;
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
                            CampId = unit.GetComponent<NumericComponent>().GetAsInt(NumericType.CampId),
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
            if (self.UserInfo.Lv >= GlobalValueConfigCategory.Instance.Get(41).Value2
                || self.UserInfo.Lv >= serverInfo.WorldLv)
            {
                return;
            }
            ExpConfig xiulianconf1 =  ExpConfigCategory.Instance.Get(self.UserInfo.Lv);
            long upNeedExp = xiulianconf1.UpExp;

            if (self.UserInfo.Exp >= upNeedExp)
            {
                self.UserInfo.Exp -= upNeedExp;
                self.UpdateRoleData(UserDataType.Lv, "1", notice);
            }
        }
#endif

        public static long GetMakeTime(this UserInfoComponent self, int makeId)
        {
            List<KeyValuePairInt> makeList = self.UserInfo.MakeIdList;
            for (int i = 0; i < makeList.Count; i++)
            {
                if (makeList[i].KeyId == makeId)
                {
                    return makeList[i].Value;
                }
            }
            return 0;
        }

        public static void OnMakeItem(this UserInfoComponent self, int makeId)
        {
            EquipMakeConfig equipMakeConfig = EquipMakeConfigCategory.Instance.Get(makeId);
            List<KeyValuePairInt> makeList = self.UserInfo.MakeIdList;

            bool have = false;
            long endTime = TimeHelper.ServerNow() + equipMakeConfig.MakeTime * 1000; 
            for (int i = 0; i < makeList.Count; i++)
            {
                if (makeList[i].KeyId == makeId)
                {
                    makeList[i].Value = endTime;
                    have = true;
                }
            }
            if (!have)
            {
                self.UserInfo.MakeIdList.Add(new KeyValuePairInt() { KeyId = makeId, Value = endTime });
            }
        }

        public static void OnAddChests(this UserInfoComponent self, int fubenId, int monsterId)
        {
            bool have = false;
            List<KeyValuePair> chestList = self.UserInfo.OpenChestList;
            for (int i = 0; i < chestList.Count; i++)
            {
                if (chestList[i].KeyId == fubenId)
                {
                    chestList[i].Value += ($"_{monsterId}");
                    have = true;
                }
            }
            if (!have)
            {
                self.UserInfo.OpenChestList.Add(new KeyValuePair(){ KeyId= fubenId, Value = monsterId.ToString() });
            }    
        }

        public static bool IsCheskOpen(this UserInfoComponent self, int fubenId, int monsterId)
        {
            List<KeyValuePair> chestList = self.UserInfo.OpenChestList;
            for (int i = 0; i < chestList.Count; i++)
            {
                if (chestList[i].KeyId == fubenId)
                {
                    return chestList[i].Value.Contains(monsterId.ToString());
                }
            }
            return false;
        }

        public static void OnCleanBossCD(this UserInfoComponent self)
        {
            self.UserInfo.MonsterRevives.Clear();
        }

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
                    return "0";
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
