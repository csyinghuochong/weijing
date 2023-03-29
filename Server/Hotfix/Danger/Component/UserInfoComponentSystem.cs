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
            self.UpdateRoleData(UserDataType.FangRong, (coefficient * lingDiConfig.HoureExp).ToString(), notice);
            self.UpdateRoleData(UserDataType.RongYu, (coefficient * lingDiConfig.HoureHonor).ToString(), notice);
        }

        public static void OpenAll(this UserInfoComponent self)
        {
            self.UserInfo.FubenPassList.Clear();

            Dictionary<int, ChapterConfig> keyValuePairs = ChapterConfigCategory.Instance.GetAll();
            foreach (var item in keyValuePairs)
            {
                self.UserInfo.FubenPassList.Add(new FubenPassInfo()
                {
                    FubenId = item.Key,
                    Difficulty = (int)FubenDifficulty.DiYu
                });
            }
        }

        public static int GetTiLiIndex(this UserInfoComponent self, int hour_1)
        {
            if (hour_1 < 6)
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
            if (hour_1 < 24)
            {
                return 4;
            }
            return 5;
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

        public static void OnLogin(this UserInfoComponent self, string remoteIp, string deviceName)
        {
            //跨天登录，则重新请求
            self.RemoteAddress = remoteIp;
            self.DeviceName = deviceName;
            Unit unit = self.GetParent<Unit>();
            long currentTime = TimeHelper.ServerNow();
            DateTime dateTime = TimeInfo.Instance.ToDateTime(currentTime);
            long lastLoginTime = self.LastLoginTime;
            if (lastLoginTime != 0)
            {
                DateTime lastdateTime = TimeInfo.Instance.ToDateTime(lastLoginTime);
                int hour_1, hour_2 = 0;
                if (dateTime.Day != lastdateTime.Day)
                {
                    Log.Debug($"OnZeroClockUpdate [登录刷新]: {unit.Id}");
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
                    self.OnZeroClockUpdate(false);
                    unit.GetComponent<TaskComponent>().OnZeroClockUpdate(false);
                    unit.GetComponent<EnergyComponent>().OnResetEnergyInfo();
                    unit.GetComponent<HeroDataComponent>().OnZeroClockUpdate(false);
                    unit.GetComponent<ActivityComponent>().OnZeroClockUpdate(self.UserInfo.Lv);
                    unit.GetComponent<ChengJiuComponent>().OnZeroClockUpdate();
                    unit.GetComponent<JiaYuanComponent>().OnZeroClockUpdate();
                }
                else
                {
                    hour_1 = lastdateTime.Hour;
                    hour_2 = dateTime.Hour;

                    int tiliTimes = self.GetTiLiTimes(hour_1, hour_2);
                    tiliTimes = Math.Min(tiliTimes, 4);
                    self.RecoverPiLao(tiliTimes * 30, false);
                }
            }
            else
            {
                Log.Debug($"OnZeroClockUpdate [数据初始化]: {unit.Id}");
                unit.GetComponent<TaskComponent>().OnZeroClockUpdate(false);
            }

            unit.GetComponent<BagComponent>().OnLogin();
            unit.GetComponent<TaskComponent>().OnLogin();
            unit.GetComponent<HeroDataComponent>().OnLogin();
            unit.GetComponent<DBSaveComponent>().OnLogin();
            unit.GetComponent<RechargeComponent>().OnLogin();
            unit.GetComponent<PetComponent>().OnLogin();
            unit.GetComponent<ActivityComponent>().OnLogin(self.UserInfo.Lv);
            unit.GetComponent<TitleComponent>().OnCheckTitle(false);
            unit.GetComponent<ChengJiuComponent>().OnLogin();
            unit.GetComponent<JiaYuanComponent>().OnLogin();

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
            if (hour == 0 || hour == 6 || hour == 12 || hour == 20)
            {
                self.RecoverPiLao(30, notice);
            }

            LogHelper.CheckZuoBi(self.GetParent<Unit>());
        }

        public static void RecoverPiLao(this UserInfoComponent self, int addValue, bool notice)
        {
            Unit unit = self.GetParent<Unit>();
            Log.Debug($"RecoverPiLao [恢复体力] {unit.Id} {addValue}");
            long recoverPiLao = self.GetParent<Unit>().GetMaxPiLao() - self.UserInfo.PiLao;
            recoverPiLao = Math.Min(recoverPiLao, addValue);
            self.UpdateRoleData(UserDataType.PiLao, recoverPiLao.ToString(), notice);
            self.LastLoginTime = TimeHelper.ServerNow();
        }

        public static void OnZeroClockUpdate(this UserInfoComponent self, bool notice)
        {
            Unit unit = self.GetParent<Unit>();
            int updatevalue = unit.GetMaxHuoLi() - self.UserInfo.Vitality;
            self.UpdateRoleData(UserDataType.Vitality, updatevalue.ToString(), notice);
            updatevalue = ComHelp.GetMaxBaoShiDu() - self.UserInfo.BaoShiDu;
            self.UpdateRoleData(UserDataType.BaoShiDu, updatevalue.ToString(), notice);
            unit.GetComponent<NumericComponent>().ApplyValue(NumericType.ZeroClock, 1, notice);
            self.ClearDayData();
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
        public static void OnKillUnit(this UserInfoComponent self, Unit beKill, int sceneType, int sceneId)
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
            if (SceneConfigHelper.IsSingleFuben(sceneType))
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

        public static void UpdateRoleDataBroadcast(this UserInfoComponent self, UserDataType Type, string value)
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

        public static void OnMysteryBuy(this UserInfoComponent self, int mysteryId)
        {
            for (int i = 0; i < self.UserInfo.MysteryItems.Count; i++)
            {
                if (self.UserInfo.MysteryItems[i].KeyId == mysteryId)
                {
                    self.UserInfo.MysteryItems[i].Value += 1;
                    return;
                }
            }
            self.UserInfo.MysteryItems.Add(new KeyValuePairInt() { KeyId = mysteryId, Value = 1 });
        }

        //加金币
        public static void UpdateRoleMoneyAdd(this UserInfoComponent self, UserDataType Type, string value, bool notice, int getWay, string paramsifo = "")
        {
            Unit unit = self.GetParent<Unit>();
            long gold = long.Parse(value);
            if (gold < 0)
            {
                Log.Warning($"增加货币出错:{Type}  {unit.Id} {self.UserInfo.Name}  {value} {getWay}");
            }
            else
            {
                if (getWay != ItemGetWay.PickItem || gold > 1000)
                {
                    Log.Warning($"增加货币:{Type} {unit.Id} {self.UserInfo.Name}  {value} {getWay}");
                }
            }
            if (gold > 100000 || gold < -100000)
            {
                Log.Warning($"增加货币[大额]:{Type} {getWay} {unit.Id} {self.UserInfo.Name} {value}");
            }
            if (gold > 0 && getWay == ItemGetWay.PaiMaiSell)
            {
                unit.GetComponent<ChengJiuComponent>().TriggerEvent(ChengJiuTargetEnum.PaiMaiGetGoldNumber_217, 0, (int)gold);
            }

            self.UpdateRoleData(Type, value, notice);
        }

        //扣金币
        public static void UpdateRoleMoneySub(this UserInfoComponent self, UserDataType Type, string value, bool notice = true, int getWay = ItemGetWay.System, string paramsifo = "")
        {
            Unit unit = self.GetParent<Unit>();
            long gold = long.Parse(value);
            if (gold > 0)
            {
                Log.Warning($"扣除货币出错:{Type} {getWay} {unit.Id} {self.UserInfo.Name}  {value}");
            }
            else
            {
                Log.Warning($"扣除货币:{Type} {getWay} {unit.Id} {self.UserInfo.Name} {value}");
            }
            if (gold > 100000 || gold < -100000)
            {
                Log.Warning($"扣除货币[大额]:{Type} {getWay} {unit.Id} {self.UserInfo.Name} {value}");
            }

            self.UpdateRoleData(Type, value, notice);
        }

        //需要通知客户端
        public static void UpdateRoleData(this UserInfoComponent self, UserDataType Type, string value, bool notice = true)
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
                    long addDiamond = long.Parse(value);
                    self.UserInfo.Diamond += addDiamond;
                    self.UserInfo.Diamond = Math.Max(self.UserInfo.Diamond, 0);
                    saveValue = self.UserInfo.Diamond.ToString();
                    if (addDiamond < 0)
                    {
                        unit.GetComponent<ChengJiuComponent>().OnCostDiamond(addDiamond);
                    }
                    break;
                case UserDataType.JiaYuanFund:
                    self.UserInfo.JiaYuanFund += long.Parse(value);
                    saveValue = self.UserInfo.JiaYuanFund.ToString();
                    break;
                case UserDataType.Occ:
                    break;
                case UserDataType.MaoXianExp:
                    unit.GetComponent<NumericComponent>().ApplyChange(null, NumericType.MaoXianExp, long.Parse(value), 0);
                    break;
                case UserDataType.Recharge:
                    RechargeHelp.SendDiamondToUnit(unit, int.Parse(value), "道具");
                    break;
                case UserDataType.PiLao:
                    int maxValue = unit.IsYueKaStates() ? int.Parse(GlobalValueConfigCategory.Instance.Get(26).Value) : int.Parse(GlobalValueConfigCategory.Instance.Get(10).Value);
                    long newValue = long.Parse(value) + self.UserInfo.PiLao;
                    newValue = Math.Min(Math.Max(0, newValue), maxValue);
                    self.UserInfo.PiLao = newValue;
                    saveValue = self.UserInfo.PiLao.ToString();
                    break;
                case UserDataType.BaoShiDu:
                    long addValue = long.Parse(value);
                    newValue = self.UserInfo.BaoShiDu + (int)addValue;
                    newValue = Math.Min(Math.Max(0, newValue), ComHelp.GetMaxBaoShiDu());
                    self.UserInfo.BaoShiDu = (int)newValue;
                    saveValue = self.UserInfo.BaoShiDu.ToString();
                    if (self.UserInfo.BaoShiDu < 80)
                    {
                        unit.GetComponent<BuffManagerComponent>()?.BuffRemove(99001011);
                    }
                    break;
                case UserDataType.HuoYue:
                    break;
                case UserDataType.DungeonTimes:
                    unit.GetComponent<NumericComponent>().ApplyValue(NumericType.TeamDungeonTimes, unit.GetTeamDungeonTimes() - 1);
                    unit.GetComponent<NumericComponent>().ApplyValue(NumericType.TeamDungeonXieZhu, unit.GetTeamDungeonXieZhu() - 1);
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
                    if (notice)
                    {
                        unit.GetComponent<ChengJiuComponent>().TriggerEvent(ChengJiuTargetEnum.CombatToValue_211, 0, self.UserInfo.Combat);
                    }
                    break;
                case UserDataType.Vitality:
                    maxValue = unit.GetMaxHuoLi();
                    addValue = long.Parse(value);
                    newValue = self.UserInfo.Vitality + (int)addValue;
                    newValue = Math.Min(Math.Max(0, newValue), maxValue);
                    self.UserInfo.Vitality = (int)newValue;
                    saveValue = self.UserInfo.Vitality.ToString();
                    break;
                default:
                    saveValue = value;
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
            R2M_RankUpdateResponse Response = (R2M_RankUpdateResponse)await ActorMessageSenderComponent.Instance.Call
                     (mapInstanceId, new M2R_RankUpdateRequest()
                     {
                         CampId = unit.GetComponent<NumericComponent>().GetAsInt(NumericType.CampId),
                         RankingInfo = rankPetInfo
                     });
            if (unit.IsDisposed)
            {
                return;
            }
            unit.GetComponent<NumericComponent>().ApplyValue(NumericType.RankID, Response.RankId);
            unit.GetComponent<NumericComponent>().ApplyValue(NumericType.PetRankID, Response.PetRankId);
        }

        //增加经验
        public static void Role_AddExp(this UserInfoComponent self, long addValue, bool notice)
        {
            ServerInfo serverInfo = self.DomainScene().GetComponent<ServerInfoComponent>().ServerInfo;

            float expAdd = ComHelp.GetExpAdd(self.UserInfo.Lv, serverInfo);

            self.UserInfo.Exp = self.UserInfo.Exp + (int)(addValue * (1.0f + expAdd));
            //判定是否升级
            if (self.UserInfo.Lv >= serverInfo.WorldLv)
            {
                return;
            }
            ExpConfig xiulianconf1 = ExpConfigCategory.Instance.Get(self.UserInfo.Lv);
            long upNeedExp = xiulianconf1.UpExp;

            //等级达到上限,则无法获得经验
            if (self.UserInfo.Lv >= GlobalValueConfigCategory.Instance.Get(41).Value2 && self.UserInfo.Exp >= upNeedExp)
            {
                return;
            }

            if (self.UserInfo.Exp >= upNeedExp)
            {
                self.UserInfo.Exp -= upNeedExp;
                self.UpdateRoleData(UserDataType.Lv, "1", notice);
            }
        }

        public static int GetRandomMonsterId(this UserInfoComponent self)
        {
            List<KeyValuePairInt> dayMonster = self.UserInfo.DayMonsters;
            List<DayMonsters> dayMonsterConfig = GlobalValueConfigCategory.Instance.DayMonsterList;

            for (int i = 0; i < dayMonsterConfig.Count; i++)
            {
                if (RandomHelper.RandFloat01() > dayMonsterConfig[i].GaiLv)
                {
                    continue;
                }

                KeyValuePairInt keyValuePairInt = null;
                for (int d = 0; d < dayMonster.Count; d++)
                {
                    if (dayMonster[d].KeyId != dayMonsterConfig[i].MonsterId)
                    {
                        continue;
                    }
                    keyValuePairInt = dayMonster[d];
                }
                if (keyValuePairInt == null)
                {
                    keyValuePairInt = new KeyValuePairInt() { KeyId = dayMonsterConfig[i].MonsterId, Value = 0 };
                    dayMonster.Add(keyValuePairInt);
                }
                if (keyValuePairInt.Value < dayMonsterConfig[i].TotalNumber)
                {
                    keyValuePairInt.Value++;
                    return dayMonsterConfig[i].MonsterId;
                }
            }

            return 0;
        }

        public static int GetRandomJingLingId(this UserInfoComponent self)
        {
            List<DayJingLing> dayMonsterConfig = GlobalValueConfigCategory.Instance.DayJingLingList;
            List<int> dayMonster = self.UserInfo.DayJingLing;
            for(int i = 0; i < dayMonsterConfig.Count; i++)
            {
                if (RandomHelper.RandFloat01() > dayMonsterConfig[i].GaiLv)
                {
                    continue;
                }
                if (dayMonster.Count <= i)
                {
                    for (int d = dayMonster.Count; d < i+1; d++)
                    {
                        dayMonster.Add(0);
                    }
                }
                if (dayMonster[i] >= dayMonsterConfig[i].TotalNumber)
                {
                    continue;
                }

                dayMonster[i]++;
                int randomIndex = RandomHelper.RandomByWeight(dayMonsterConfig[i].Weights);
                return dayMonsterConfig[i].MonsterId[randomIndex];
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
                self.UserInfo.OpenChestList.Add(new KeyValuePair() { KeyId = fubenId, Value = monsterId.ToString() });
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

        public static void ClearFubenTimes(this UserInfoComponent self, int sceneId)
        {
            for (int i = 0; i < self.UserInfo.DayFubenTimes.Count; i++)
            {
                if (self.UserInfo.DayFubenTimes[i].KeyId == sceneId)
                {
                    self.UserInfo.DayFubenTimes[i].Value = 0;
                    break;
                }
            }
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
            self.UserInfo.DayFubenTimes.Add(new KeyValuePairInt() { KeyId = sceneId, Value = 1 });
        }

        public static void OnDayItemUse(this UserInfoComponent self, int itemId)
        {
            for (int i = 0; i < self.UserInfo.DayItemUse.Count; i++)
            {
                if (self.UserInfo.DayItemUse[i].KeyId == itemId)
                {
                    self.UserInfo.DayItemUse[i].Value += 1;
                    return;
                }
            }
            self.UserInfo.DayItemUse.Add(new KeyValuePairInt() { KeyId = itemId, Value = 1 });
        }

        public static int GetDayItemUse(this UserInfoComponent self, int mysteryId)
        {
            for (int i = 0; i < self.UserInfo.DayItemUse.Count; i++)
            {
                if (self.UserInfo.DayItemUse[i].KeyId == mysteryId)
                {
                    return (int)self.UserInfo.DayItemUse[i].Value;
                }
            }
            return 0;
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
                default:
                    return "0";
            }
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

        public static void ClearDayData(this UserInfoComponent self)
        {
            self.UserInfo.DayFubenTimes.Clear();
            self.UserInfo.ChouKaRewardIds.Clear();
            self.UserInfo.MysteryItems.Clear();
            self.UserInfo.DayItemUse.Clear();
            self.UserInfo.DayMonsters.Clear();
            self.UserInfo.DayJingLing.Clear();
        }

    }

}
