using System;
using System.Collections.Generic;
using System.Linq;

namespace ET
{
    [Timer(TimerType.RankeTimer)]
    public class RankeTimer : ATimer<RankSceneComponent>
    {
        public override void Run(RankSceneComponent self)
        {
            try
            {
                self.SaveDB().Coroutine();
            }
            catch (Exception e)
            {
                Log.Error($"move timer error: {self.Id}\n{e}");
            }
        }
    }

    [ObjectSystem]
    public class RankSceneComponentAwakeSystem : AwakeSystem<RankSceneComponent>
    {
        public override void Awake(RankSceneComponent self)
        {
            self.InitServerInfo().Coroutine();
            self.InitDBRankInfo().Coroutine();

            self.Timer = TimerComponent.Instance.NewRepeatedTimer(TimeHelper.Minute * 5 + self.DomainZone() * 1000, TimerType.RankeTimer, self);
        }
    }


    [ObjectSystem]
    public class RankSceneComponentDestroySystem : DestroySystem<RankSceneComponent>
    {

        public override void Destroy(RankSceneComponent self)
        { 
            TimerComponent.Instance.Remove(ref self.Timer);
        }
    }

    public static class RankSceneComponentSystem
    {
        public static async ETTask InitServerInfo(this RankSceneComponent self)
        {
            DBServerInfo dBServerInfo = null;
            long dbCacheId = DBHelper.GetDbCacheId(self.DomainZone());
            D2G_GetComponent d2GGetUnit = (D2G_GetComponent)await ActorMessageSenderComponent.Instance.Call(dbCacheId, new G2D_GetComponent() { UnitId = self.DomainZone(), Component = DBHelper.DBServerInfo });
            if (d2GGetUnit.Component != null)
            {
                dBServerInfo = d2GGetUnit.Component as DBServerInfo;
            }
            if (dBServerInfo == null)
            {
                dBServerInfo = new DBServerInfo();
                dBServerInfo.Id = self.DomainZone();
            }
            //初始化参数
            self.DBServerInfo = dBServerInfo;
            self.UpdateExchangeGold(DBHelper.GetOpenServerDay(self.DomainZone()));
            //上午重启不刷新世界等级
            DateTime dateTime = TimeHelper.DateTimeNow();
            if (self.DBServerInfo.ServerInfo.WorldLv == 0|| dateTime.Hour >= 12)
            {
                self.UpdateWorldLv();
            }
            self.BroadcastWorldLv().Coroutine();
        }

        public static void UpdateWorldLv(this RankSceneComponent self)
        {
            //第二天并且超过12点才刷新
            int openserverDay = DBHelper.GetOpenServerDay(self.DomainZone());
            int worldLv = WorldLvHelper.GetWorldLv(openserverDay);
            self.DBServerInfo.ServerInfo.WorldLv = worldLv;
            Log.Debug($"UpdateWorldLv: {self.DomainZone()} {worldLv}");
        }

        public static async ETTask BroadcastWorldLv(this RankSceneComponent self)
        {           
            //延迟刷新，以免有些服务器还没启动
            await TimerComponent.Instance.WaitAsync(self.DomainZone() * 300);

            long fubenCenterId = DBHelper.GetFubenCenterId(self.DomainZone());
            R2F_WorldLvUpdateRequest request    = new R2F_WorldLvUpdateRequest() {  ServerInfo = self.DBServerInfo.ServerInfo };
            F2R_WorldLvUpdateResponse response = (F2R_WorldLvUpdateResponse)await ActorMessageSenderComponent.Instance.Call(fubenCenterId, request);
        }

        public static void OnHour12Update(this RankSceneComponent self)
        {
            self.UpdateWorldLv();
            self.BroadcastWorldLv().Coroutine();
        }

        public static void OnZeroClockUpdate(this RankSceneComponent self)
        {
            //更新服务器拍卖行数据
            //TimeHelper. self.OpenServiceTime
            self.UpdateExchangeGold(DBHelper.GetOpenServerDay(self.DomainZone()));
            self.SendCombatReward().Coroutine();
            self.SendPetReward().Coroutine();
        }

        //更新兑换金币
        public static void UpdateExchangeGold(this RankSceneComponent self, int dayTime)
        {
            int duihuan_baseGold = 650;       //基础兑换值
            float duihuanPro = 0.05f;
            //最多计算20天后的物价
            if (dayTime > 30)
            {
                dayTime = 30;
            }

            //计算物价
            int duihuanDay = dayTime;
            if (duihuanDay >= 30) {
                duihuanDay = 30;
            }
            duihuanPro = duihuanPro * duihuanDay;
            /*
            if (dayTime > 0 && dayTime <= 7)
            {
                duihuanPro = duihuanPro * dayTime;
            }

            //计算物价
            if (dayTime > 7 && dayTime <= 18)
            {
                duihuanPro = 7 * 0.05f + (dayTime - 7) * 0.1f;
            }

            //计算物价
            if (dayTime > 18)
            {
                duihuanPro = 7 * 0.15f + 11 * 0.1f + (dayTime - 18) * 0.05f;
            }
            */

            int nowDuiHuanGold = (int)(duihuan_baseGold + duihuan_baseGold * duihuanPro);

            //随机值5%浮动
            Random random = new Random();
            float duihuan_randomValue = random.Next(10);
            duihuan_randomValue = duihuan_randomValue / 100f;
            if (duihuan_randomValue >= 0.1f) {
                duihuan_randomValue = 0.1f;
            }
            int duihuan_nowGold = (int)((float)nowDuiHuanGold * (0.95f + duihuan_randomValue));

            Log.Info("今日货币兑换值:" + duihuan_nowGold + " dayTime = " + dayTime);
            //最低不能低于昨天的兑换值
            if (duihuan_nowGold >= self.DBServerInfo.ServerInfo.ExChangeGold)
            {
                if (duihuan_nowGold < 500)
                {
                    duihuan_nowGold = 500;
                }
                self.DBServerInfo.ServerInfo.ExChangeGold = duihuan_nowGold;
                Log.Info("更新货币兑换值:" + self.DBServerInfo.ServerInfo.ExChangeGold);
            }
        }

        public static async ETTask InitDBRankInfo(this RankSceneComponent self)
        {
            long dbCacheId = DBHelper.GetDbCacheId(self.DomainZone());
            D2G_GetComponent d2GGetUnit = (D2G_GetComponent)await ActorMessageSenderComponent.Instance.Call(dbCacheId, new G2D_GetComponent() { UnitId = self.DomainZone(), Component = DBHelper.DBRankInfo });

            if (d2GGetUnit.Component == null)
            {
                DBRankInfo dBRankInfo = new DBRankInfo();
                dBRankInfo.Id = self.DomainZone();
                self.DBRankInfo = dBRankInfo;
            }
            else
            {
                self.DBRankInfo = d2GGetUnit.Component as DBRankInfo;
            }
            self.UpdateRankPetList();
        }

        public static async ETTask UpdateCombat(this RankSceneComponent self)
        {
            Log.Debug($"UpdateCombatUpdateCombat: {self.DomainZone()}");
            self.DomainScene().RemoveComponent<UnitComponent>();
            self.DomainScene().AddComponent<UnitComponent>();
            List<RankingInfo> rankingInfoList = new List<RankingInfo>();
            for (int i = self.DBRankInfo.rankingInfos.Count - 1; i >=0; i--)
            {
                rankingInfoList.Add(self.DBRankInfo.rankingInfos[i]);
            }

            for (int i = rankingInfoList.Count - 1; i >= 0; i--)
            {
                RankingInfo rankingInfo = rankingInfoList[i];

                Unit unit = UnitFactory.Create(self.DomainScene(), rankingInfo.UserId, UnitType.Player);
                await DBHelper.AddDataComponent<UserInfoComponent>(unit, rankingInfo.UserId, DBHelper.UserInfoComponent);
                await DBHelper.AddDataComponent<NumericComponent>(unit, rankingInfo.UserId, DBHelper.NumericComponent);
                await DBHelper.AddDataComponent<TaskComponent>(unit, rankingInfo.UserId, DBHelper.TaskComponent);
                await DBHelper.AddDataComponent<ShoujiComponent>(unit, rankingInfo.UserId, DBHelper.ShoujiComponent);
                await DBHelper.AddDataComponent<BagComponent>(unit, rankingInfo.UserId, DBHelper.BagComponent);
                await DBHelper.AddDataComponent<ChengJiuComponent>(unit, rankingInfo.UserId, DBHelper.ChengJiuComponent);
                await DBHelper.AddDataComponent<PetComponent>(unit, rankingInfo.UserId, DBHelper.PetComponent);
                await DBHelper.AddDataComponent<SkillSetComponent>(unit, rankingInfo.UserId, DBHelper.SkillSetComponent);
                await DBHelper.AddDataComponent<EnergyComponent>(unit, rankingInfo.UserId, DBHelper.EnergyComponent);
                await DBHelper.AddDataComponent<ActivityComponent>(unit, rankingInfo.UserId, DBHelper.ActivityComponent);
                await DBHelper.AddDataComponent<RechargeComponent>(unit, rankingInfo.UserId, DBHelper.RechargeComponent);
                await DBHelper.AddDataComponent<ReddotComponent>(unit, rankingInfo.UserId, DBHelper.ReddotComponent);
                await DBHelper.AddDataComponent<TitleComponent>(unit, rankingInfo.UserId, DBHelper.TitleComponent);
                await DBHelper.AddDataComponent<JiaYuanComponent>(unit, rankingInfo.UserId, DBHelper.JiaYuanComponent);
                Function_Fight.GetInstance().UnitUpdateProperty_Base(unit, false, false);

                RankingInfo rankPetInfo = new RankingInfo();
                UserInfoComponent userInfoComponent = unit.GetComponent<UserInfoComponent>();
                rankPetInfo.UserId = userInfoComponent.UserInfo.UserId;
                rankPetInfo.PlayerName = userInfoComponent.UserInfo.Name;
                rankPetInfo.PlayerLv = userInfoComponent.UserInfo.Lv;
                rankPetInfo.Combat = userInfoComponent.UserInfo.Combat;
                rankPetInfo.Occ = userInfoComponent.UserInfo.Occ;

                self.OnRecvRankUpdate(unit.GetComponent<NumericComponent>().GetAsInt(NumericType.CampId), rankPetInfo);
                unit.GetParent<UnitComponent>().Remove(unit.Id);
            }
        }

        public static async ETTask SaveDB(this RankSceneComponent self)
        {
            long dbCacheId = DBHelper.GetDbCacheId(self.DomainZone());
           
            await ActorMessageSenderComponent.Instance.Call(dbCacheId, new M2D_SaveComponent() { UnitId = self.DomainZone(), EntityByte = MongoHelper.ToBson(self.DBRankInfo), ComponentType = DBHelper.DBRankInfo });
            await ActorMessageSenderComponent.Instance.Call(dbCacheId, new M2D_SaveComponent() { UnitId = self.DomainZone(), EntityByte = MongoHelper.ToBson(self.DBServerInfo), ComponentType = DBHelper.DBServerInfo });
        }

        /// <summary>
        /// 清空捐献榜
        /// </summary>
        /// <param name="self"></param>
        public static void ResetDonation(this RankSceneComponent self)
        {
            self.DBRankInfo.rankingDonation.Clear();
        }

        public static void UpdateRankList(this RankSceneComponent self, RankingInfo rankingInfo)
        {
            bool have = false;

            long oldNo1 = 0;
            long newNo1 = 0;
           
            for (int i = 0; i < self.DBRankInfo.rankingInfos.Count; i++)
            {
                RankingInfo rankingInfoTemp = self.DBRankInfo.rankingInfos[i];
                if (i == 0)
                {
                    oldNo1 = rankingInfoTemp.UserId;
                }

                if (rankingInfoTemp.UserId == rankingInfo.UserId)
                {
                    self.DBRankInfo.rankingInfos[i] = rankingInfo;
                    have = true;
                    break;
                }
            }

            if (!have)
            {
                if (self.DBRankInfo.rankingInfos.Count < 500)
                {
                    self.DBRankInfo.rankingInfos.Add(rankingInfo);
                }
                else
                {
                    if (self.DBRankInfo.rankingInfos.LastOrDefault().Combat < rankingInfo.Combat)
                    {
                        self.DBRankInfo.rankingInfos[self.DBRankInfo.rankingInfos.Count - 1] = rankingInfo;
                    }
                }
            }
            self.DBRankInfo.rankingInfos.Sort(delegate (RankingInfo a, RankingInfo b)
            {
                return (int)b.Combat - (int)a.Combat;
            });

            newNo1 = self.DBRankInfo.rankingInfos[0].UserId;
            if (oldNo1 == newNo1)
            {
                //self.UpdateRankNo1(newNo1).Coroutine();
            }
            else
            {
                self.UpdateRankNo1(oldNo1).Coroutine();
                self.UpdateRankNo1(newNo1).Coroutine();
            }
        }

        /// <summary>
        /// 通知排行榜第一刷新
        /// </summary>
        public static async ETTask UpdateRankNo1(this RankSceneComponent self, long userId)
        {
            int zone = self.DomainZone();
            if (DBHelper.GetOpenServerDay(zone) < 3)
            {
                return;
            }
            int rankId = self.GetCombatRank(userId);
            if (rankId <= 0)
            {
                return;
            }

            //通知玩家
            long gateServerId = DBHelper.GetGateServerId(zone);
            G2T_GateUnitInfoResponse g2M_UpdateUnitResponse = (G2T_GateUnitInfoResponse)await ActorMessageSenderComponent.Instance.Call
               (gateServerId, new T2G_GateUnitInfoRequest()
               {
                   UserID = userId
               });
            if (g2M_UpdateUnitResponse.PlayerState == (int)PlayerState.Game && g2M_UpdateUnitResponse.SessionInstanceId > 0)
            {
                R2M_RankNo1Message r2M_RechargeRequest = new R2M_RankNo1Message() { RankId = rankId };
                ActorLocationSenderComponent.Instance.Send(g2M_UpdateUnitResponse.UnitId, r2M_RechargeRequest);
            }
        }

        public static int GetPetRank(this RankSceneComponent self, long userId)
        {
            for (int i = 0; i < self.DBRankInfo.rankingPets.Count; i++)
            {
                RankPetInfo rankPetInfo = self.DBRankInfo.rankingPets[i];
                if (rankPetInfo.UserId == userId)
                {
                    return rankPetInfo.RankId;
                }

            }
            return 0;
        }

        public static int GetCombatRank(this RankSceneComponent self, long usrerId)
        {
            for (int i = 0; i < self.DBRankInfo.rankingInfos.Count; i++)
            {
                if (self.DBRankInfo.rankingInfos[i].UserId == usrerId)
                {
                    return i + 1;
                }
            }
            return 0;
        }

        public static void UpdateCampRankList(this RankSceneComponent self, int campId, RankingInfo rankingInfo)
        {
            if (campId == 0)
            {
                return;
            }

            //清除在其他阵营的排名
            List<RankingInfo> rankList = campId == 1 ? self.DBRankInfo.rankingCamp2 : self.DBRankInfo.rankingCamp1;
            for (int i = rankList.Count - 1; i >= 0; i--)
            {
                if (rankList[i].UserId == rankingInfo.UserId)
                {
                    rankList.RemoveAt(i);
                    break;
                }
            }

            bool have = false;
            rankList = campId == 1 ? self.DBRankInfo.rankingCamp1 : self.DBRankInfo.rankingCamp2;
            for (int i = 0; i < rankList.Count; i++)
            {
                if (rankList[i].UserId == rankingInfo.UserId)
                {
                    rankList[i] = rankingInfo;
                    have = true;
                    break;
                }
            }

            if (!have)
            {
                if (rankList.Count < ComHelp.CampRankNumber)
                {
                    rankList.Add(rankingInfo);
                }
                else
                {
                    if (rankList.LastOrDefault().Combat < rankingInfo.Combat)
                    {
                        rankList[rankList.Count - 1] = rankingInfo;
                    }
                }
            }
            rankList.Sort(delegate (RankingInfo a, RankingInfo b)
            {
                return (int)b.Combat - (int)a.Combat;
            });
        }

        public static void UpdateWorldLevel(this RankSceneComponent self, RankingInfo rankingInfo)
        {
            ServerInfo serverInfo = self.DBServerInfo.ServerInfo;
            //if (rankingInfo.PlayerLv < serverInfo.WorldLv)
            //{
            //    return;
            //}
            if (serverInfo.RankingInfo == null)
            {
                serverInfo.RankingInfo = rankingInfo;
                self.BroadcastWorldLv().Coroutine();
                return;
            }
            if (serverInfo.RankingInfo.PlayerLv < rankingInfo.PlayerLv)
            {
                serverInfo.RankingInfo = rankingInfo;
                self.BroadcastWorldLv().Coroutine();
            }
        }

        public static void OnRecvRankUpdate(this RankSceneComponent self, int campId, RankingInfo rankingInfo)
        {
            self.UpdateWorldLevel(rankingInfo);
            self.UpdateRankList(rankingInfo);
            self.UpdateCampRankList(campId, rankingInfo);
            //response.RankList.AddRange(rankComponent.DBRankInfo.rankingInfos.GetRange(0, 50)); 
        }

        public static void UpdateRankPetList(this RankSceneComponent self)
        {
            //读机器人配置表
            if (self.DBRankInfo.rankingPets.Count > 0)
            {
                return;
            }
            List<int> allPet = new List<int>() { 1000101, 1000201 , 1000301 , 1000401 , 1000501 ,1000601, 1000701};
            for (int i = 0; i < ComHelp.PetRankNumber; i++)
            {
                int[] indexs = RandomHelper.GetRandoms(3, 0, allPet.Count);
                List<int> pets = new List<int>();
                for (int p = 0; p < indexs.Length; p++)
                {
                    pets.Add(allPet[p]);
                }
                self.DBRankInfo.rankingPets.Add(new RankPetInfo() { UserId = IdGenerater.Instance.GenerateId(), TeamName = "机器人:" + (i + 1) + "的队伍", RankId = i + 1, PlayerName = "机器人:" + (i + 1), PetUId = new List<long>() { 0, 0, 0 }, PetConfigId = pets });
            }
        }

        public static void OnRecvPetRank(this RankSceneComponent self, M2R_PetRankUpdateRequest m2R_PetRankUpdateRequest)
        {
            RankPetInfo enemyRankPetInfo = null;
            RankPetInfo selfRankPetInfo = null;

            for (int i = 0; i < self.DBRankInfo.rankingPets.Count; i++)
            {
                RankPetInfo rankPetInfo = self.DBRankInfo.rankingPets[i];
                if (rankPetInfo.UserId == m2R_PetRankUpdateRequest.RankPetInfo.UserId)
                {
                    selfRankPetInfo = rankPetInfo;
                }
                if (rankPetInfo.UserId == m2R_PetRankUpdateRequest.EnemyId)
                {
                    enemyRankPetInfo = rankPetInfo;
                }
            }
            //没找到对方或者高于对方排名，不更新排名
            if (enemyRankPetInfo != null)
            {
                if (selfRankPetInfo != null)
                {
                    if (selfRankPetInfo.RankId > enemyRankPetInfo.RankId)
                    {
                        int selfRank = selfRankPetInfo.RankId;
                        selfRankPetInfo.RankId = enemyRankPetInfo.RankId;
                        enemyRankPetInfo.RankId = selfRank;
                    }
                }
                else
                {
                    m2R_PetRankUpdateRequest.RankPetInfo.RankId = enemyRankPetInfo.RankId;
                    self.DBRankInfo.rankingPets.Remove(enemyRankPetInfo);
                    self.DBRankInfo.rankingPets.Add(m2R_PetRankUpdateRequest.RankPetInfo);
                }
            }

            self.DBRankInfo.rankingPets.Sort(delegate (RankPetInfo a, RankPetInfo b)
            {
                return a.RankId - b.RankId;
            });
            for (int i = 0; i < self.DBRankInfo.rankingPets.Count; i++)
            {
                self.DBRankInfo.rankingPets[i].RankId = i + 1;
            }
        }

        public static List<RankPetInfo> GetRankPetList(this RankSceneComponent self, int rankNumber)
        {
            List<RankPetInfo> rankPetInfos = new List<RankPetInfo>();
            List<int> indexList = new List<int>();

            if (rankNumber >= 1 && rankNumber <= 4)
            {
                for (int i = 0; i < 4; i++)
                {
                    if (i != (rankNumber - 1))
                    {
                        indexList.Add(i);
                    }
                }
            }
            else
            {
                while (indexList.Count < 3)
                {
                    int index = 0;
                    if (rankNumber == 0)
                        index = RandomHelper.RandomNumber(self.DBRankInfo.rankingPets.Count - 10, self.DBRankInfo.rankingPets.Count);
                    else if (rankNumber > 10)
                        index = RandomHelper.RandomNumber(rankNumber - 11, rankNumber - 1);
                    else
                        index = RandomHelper.RandomNumber(0, rankNumber - 1);

                    if (!indexList.Contains(index))
                    {
                        indexList.Add(index);
                    }
                }
            }
            indexList.Sort();

            for (int i = 0; i < indexList.Count; i++)
            {
                rankPetInfos.Add(self.DBRankInfo.rankingPets[indexList[i]]);
            }

            return rankPetInfos;
        }

        public static void OnDeleteRole(this RankSceneComponent self, List<RankPetInfo> rankingInfos, long userId)
        {
            for (int i = rankingInfos.Count - 1; i >= 0; i--)
            {
                if (rankingInfos[i].UserId == userId)
                {
                    rankingInfos.RemoveAt(i);
                    break;
                }
            }
        }

        public static void  OnDeleteRole(this RankSceneComponent self, List<RankingInfo> rankingInfos, long userId)
        {
            for (int i = rankingInfos.Count - 1; i >= 0; i-- )
            {
                if (rankingInfos[i].UserId == userId)
                {
                    rankingInfos.RemoveAt(i);
                    break;
                }
            }
        }

        public static async ETTask SendCombatReward(this RankSceneComponent self)
        {
            int zone = self.DomainZone();
            await TimerComponent.Instance.WaitAsync(zone * 500);
            DateTime dateTime = TimeHelper.DateTimeNow();
            if (!RankHelper.HaveReward(1, (int)dateTime.DayOfWeek))
            {
                return;
            }
            Log.Debug($"发放战力排行榜奖励： {zone}");
            long serverTime = TimeHelper.ServerNow();
            List<RankingInfo> rankingInfos = self.DBRankInfo.rankingInfos;
            long mailServerId = StartSceneConfigCategory.Instance.GetBySceneName(self.DomainZone(), Enum.GetName(SceneType.EMail)).InstanceId;
            for (int i = 0; i < rankingInfos.Count; i++)
            {
                RankRewardConfig rankRewardConfig = RankHelper.GetRankReward(i+1, 1);
                if (rankRewardConfig == null)
                {
                    continue;
                }
                MailInfo mailInfo = new MailInfo();

                mailInfo.Status = 0;
                mailInfo.Context = $"恭喜您获得排行榜第{i + 1}名奖励";
                mailInfo.Title = "排行榜奖励";
                mailInfo.MailId = IdGenerater.Instance.GenerateId();


                string[] needList = rankRewardConfig.RewardItems.Split('@');
                for (int k = 0; k < needList.Length; k++)
                {
                    string[] itemInfo = needList[k].Split(';');
                    if (itemInfo.Length < 2)
                    {
                        continue;
                    }
                    int itemId = int.Parse(itemInfo[0]);
                    int itemNum = int.Parse(itemInfo[1]);
                    mailInfo.ItemList.Add(new BagInfo() { ItemID = itemId, ItemNum = itemNum, GetWay = $"{ItemGetWay.RankReward}_{serverTime}" });
                }
                E2M_EMailSendResponse g_EMailSendResponse = (E2M_EMailSendResponse)await ActorMessageSenderComponent.Instance.Call
                      (mailServerId, new M2E_EMailSendRequest() 
                      { 
                          Id = rankingInfos[i].UserId,
                          MailInfo = mailInfo });
            }
        }

        public static async ETTask SendPetReward(this RankSceneComponent self)
        {
            int zone = self.DomainZone();
            await TimerComponent.Instance.WaitAsync(zone * 1000);
            DateTime dateTime = TimeHelper.DateTimeNow();
            if (!RankHelper.HaveReward(2, (int)dateTime.DayOfWeek))
            {
                return;
            }
            Log.Debug($"发放宠物排行榜奖励： {zone}");
            long serverTime = TimeHelper.ServerNow();
            List<RankPetInfo> rankingInfos = self.DBRankInfo.rankingPets;
            long mailServerId = StartSceneConfigCategory.Instance.GetBySceneName(self.DomainZone(), Enum.GetName(SceneType.EMail)).InstanceId;
            for (int i = 0; i < rankingInfos.Count; i++)
            {
                bool havePetUId = false;
                for (int k = 0; k < rankingInfos[i].PetUId.Count; k++)
                {
                    if (rankingInfos[i].PetUId[k] > 0)
                    {
                        havePetUId = true;
                        break;
                    }
                }
                if (!havePetUId)
                {
                    continue;
                }

                RankRewardConfig rankRewardConfig = RankHelper.GetRankReward(i + 1, 2);
                if (rankRewardConfig == null)
                {
                    continue;
                }

                MailInfo mailInfo = new MailInfo();

                mailInfo.Status = 0;
                mailInfo.Context = $"恭喜您获得排行榜第{i + 1}名奖励";
                mailInfo.Title = "排行榜奖励";
                mailInfo.MailId = IdGenerater.Instance.GenerateId();

                string[] needList = rankRewardConfig.RewardItems.Split('@');
                for (int k = 0; k < needList.Length; k++)
                {
                    string[] itemInfo = needList[k].Split(';');
                    if (itemInfo.Length < 2)
                    {
                        continue;
                    }
                    int itemId = int.Parse(itemInfo[0]);
                    int itemNum = int.Parse(itemInfo[1]);
                    mailInfo.ItemList.Add(new BagInfo() { ItemID = itemId, ItemNum = itemNum, GetWay = $"{ItemGetWay.RankReward}_{serverTime}" });
                }
                E2M_EMailSendResponse g_EMailSendResponse = (E2M_EMailSendResponse)await ActorMessageSenderComponent.Instance.Call
                      (mailServerId, new M2E_EMailSendRequest()
                      {
                          Id = rankingInfos[i].UserId,
                          MailInfo = mailInfo
                      });
            }
        }
    }
}
