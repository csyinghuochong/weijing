using System;
using System.Collections.Generic;
using UnityEngine;

namespace ET
{
    [Timer(TimerType.UnionTimer)]
    public class UnionTimer : ATimer<UnionSceneComponent>
    {
        public override void Run(UnionSceneComponent self)
        {
            try
            {
                self.SaveDB();
            }
            catch (Exception e)
            {
                Log.Error($"move timer error: {self.Id}\n{e}");
            }
        }
    }

    [Timer(TimerType.UnionBossTimer)]
    public class UnionBossTimer : ATimer<UnionSceneComponent>
    {
        public override void Run(UnionSceneComponent self)
        {
            try
            {
                self.OnUnionBoss();
            }
            catch (Exception e)
            {
                Log.Error($"move timer error: {self.Id}\n{e}");
            }
        }
    }
    
    [Timer(TimerType.UnionRaceTimer)]
    public class UnionRaceTimer : ATimer<UnionSceneComponent>
    {
        public override void Run(UnionSceneComponent self)
        {
            try
            {
                self.OnUnionRaceBegin().Coroutine();
            }
            catch (Exception e)
            {
                Log.Error($"move timer error: {self.Id}\n{e}");
            }
        }
    }

    /// <summary>
    /// 定时刷新的暂时都作为活动来处理
    /// </summary>
    [ObjectSystem]
    public class UnionSceneComponentAwakeSystem : AwakeSystem<UnionSceneComponent>
    {
        public override void Awake(UnionSceneComponent self)
        {
            self.InitServerInfo().Coroutine();
            self.GetUnionRaceId().Coroutine();
           
            self.OnZeroClockUpdate();
            self.Timer = TimerComponent.Instance.NewRepeatedTimer(TimeHelper.Minute * 5 + self.DomainZone() * 1200, TimerType.UnionTimer, self);
        }
    }

    public static class UnionSceneComponentSystem
    {

        public static int GetDonationRank(this UnionSceneComponent self, long usrerId)
        {
            for (int i = 0; i < self.DBUnionManager.rankingDonation.Count; i++)
            {
                if (self.DBUnionManager.rankingDonation[i].UserId == usrerId)
                {
                    return i + 1;
                }
            }
            return 0;
        }

        public static async ETTask InitServerInfo(this UnionSceneComponent self)
        {
            DBUnionManager dBServerInfo = await DBHelper.GetComponentCache<DBUnionManager>(self.DomainZone(), self.DomainZone());
            if (dBServerInfo == null)
            {
                dBServerInfo = self.AddChildWithId<DBUnionManager>((long)self.DomainZone());
            }
            //初始化参数
            self.DBUnionManager = dBServerInfo;
        }

        public static async ETTask<DBUnionInfo> GetDBUnionInfo(this UnionSceneComponent self, long unionId)
        {
            long dbCacheId = DBHelper.GetDbCacheId(self.DomainZone());
            D2G_GetComponent d2GSave = (D2G_GetComponent)await ActorMessageSenderComponent.Instance.Call(dbCacheId, new G2D_GetComponent() { UnitId = unionId, Component = DBHelper.DBUnionInfo });
            DBUnionInfo unionInfo = d2GSave.Component as DBUnionInfo;
            if (unionInfo == null)
            {
                return null;
            }
            return unionInfo;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="self"></param>
        /// <param name="unionid"></param>
        /// <param name="unitid"></param>
        /// <param name="replyCode">0拒绝  1同意</param>
        /// <returns></returns>
        public static async ETTask<int> OnJoinUinon(this UnionSceneComponent self, long unionid, long unitid, int replyCode)
        {
            DBUnionInfo dBUnionInfo = await self.GetDBUnionInfo(unionid);
            if (dBUnionInfo == null)
            {
                return ErrorCore.ERR_Union_Not_Exist;
            }

            //判断家族人数是否已满
            //获取家族等级
            UnionConfig unionCof = UnionConfigCategory.Instance.Get(dBUnionInfo.UnionInfo.Level);

            //判断家族成员是否已达上限
            if (dBUnionInfo.UnionInfo.UnionPlayerList.Count >= unionCof.PeopleNum) {
                return ErrorCore.ERR_Union_PeopleMax;
            }

            if (dBUnionInfo.UnionInfo.ApplyList.Contains(unitid))
            {
                dBUnionInfo.UnionInfo.ApplyList.Remove(unitid);
            }
            bool exist = false;
            for (int i = 0; i < dBUnionInfo.UnionInfo.UnionPlayerList.Count; i++)
            {
                if (dBUnionInfo.UnionInfo.UnionPlayerList[i].UserID == unitid)
                {
                    exist = true;
                }
            }
            if (!exist && replyCode == 1)
            {
                dBUnionInfo.UnionInfo.UnionPlayerList.Add(new UnionPlayerInfo()
                {
                    UserID = unitid,
                });

                //通知玩家
                long gateServerId = DBHelper.GetGateServerId(self.DomainZone());
                G2T_GateUnitInfoResponse g2M_UpdateUnitResponse = (G2T_GateUnitInfoResponse)await ActorMessageSenderComponent.Instance.Call
                   (gateServerId, new T2G_GateUnitInfoRequest()
                   {
                       UserID = unitid
                   });
                if (g2M_UpdateUnitResponse.PlayerState == (int)PlayerState.Game && g2M_UpdateUnitResponse.SessionInstanceId > 0)
                {
                    U2M_UnionApplyRequest r2M_RechargeRequest = new U2M_UnionApplyRequest() { UnionId = unionid, UnionName = dBUnionInfo.UnionInfo.UnionName };
                    M2U_UnionApplyResponse m2G_RechargeResponse = (M2U_UnionApplyResponse)await ActorLocationSenderComponent.Instance.Call(g2M_UpdateUnitResponse.UnitId, r2M_RechargeRequest);
                }
                else
                {
                    long dbCacheId = DBHelper.GetDbCacheId(self.DomainZone());
                    D2G_GetComponent d2GGet = (D2G_GetComponent)await ActorMessageSenderComponent.Instance.Call(dbCacheId, new G2D_GetComponent() { UnitId = unitid, Component = DBHelper.NumericComponent });
                    NumericComponent numericComponent = d2GGet.Component as NumericComponent;
                    numericComponent.Set(NumericType.UnionId_0, unionid, false);
                    D2M_SaveComponent d2GSave = (D2M_SaveComponent)await ActorMessageSenderComponent.Instance.Call(dbCacheId, new M2D_SaveComponent() { UnitId = unitid, EntityByte = MongoHelper.ToBson(numericComponent), ComponentType = DBHelper.NumericComponent });

                    d2GGet = (D2G_GetComponent)await ActorMessageSenderComponent.Instance.Call(dbCacheId, new G2D_GetComponent() { UnitId = unitid, Component = DBHelper.UserInfoComponent });
                    UserInfoComponent userInfoComponent = d2GGet.Component as UserInfoComponent;
                    userInfoComponent.UserInfo.UnionName = dBUnionInfo.UnionInfo.UnionName;
                    d2GSave =(D2M_SaveComponent)await ActorMessageSenderComponent.Instance.Call(dbCacheId, new M2D_SaveComponent() { UnitId = unitid, EntityByte = MongoHelper.ToBson(userInfoComponent), ComponentType = DBHelper.UserInfoComponent });
                }
            }

            DBHelper.SaveComponent(self.DomainZone(), unionid, dBUnionInfo).Coroutine();
            return ErrorCore.ERR_Success;
        }

        public static void OnZeroClockUpdate(this UnionSceneComponent self)
        {
            TimerComponent.Instance.Remove( ref self.BossTimer );
            self.UnionBossList.Clear();
            self.BeginBossTimer();
            self.BeginRaceTimer();
        }

        public static void BeginBossTimer(this UnionSceneComponent self)
        {
            DateTime dateTime = TimeHelper.DateTimeNow();
            long curTime = (dateTime.Hour * 60 + dateTime.Minute) * 60 + dateTime.Second;
            long openTime = FunctionHelp.BossOpenTime();
            if (curTime < openTime)
            {
                self.BossTimer = TimerComponent.Instance.NewOnceTimer(TimeHelper.ServerNow() + TimeHelper.Second *(openTime - curTime), TimerType.UnionBossTimer, self);
            }
            else
            { 
                
            }
        }

        public static void OnUnionBoss(this UnionSceneComponent self)
        {
            foreach ((long unionid, long instanceid) in self.UnionFubens)
            {
                Scene scene = self.GetChild<Scene>(unionid);
                if (scene == null)
                {
                    Log.Debug($"{self.DomainZone()} {unionid} scene == null");
                    continue;
                }

                self.OnUnionBoss(scene, unionid);
            }
        }

        public static void BeginRaceTimer(this UnionSceneComponent self)
        {
            DateTime dateTime = TimeHelper.DateTimeNow();
           
            long curTime = (dateTime.Hour * 60 + dateTime.Minute) * 60 + dateTime.Second;
            long openTime = FunctionHelp.RaceOpenTime();
            if (curTime < openTime)
            {
                self.RaceTimer = TimerComponent.Instance.NewOnceTimer(TimeHelper.ServerNow() + TimeHelper.Second * (openTime - curTime), TimerType.UnionRaceTimer, self);
            }
            else
            {

            }
        }

        public static void CheckWinUnion(this UnionSceneComponent self)
        {
            Vector3 initPosi = new Vector3(-73.3f, 0f, -9f);
            Dictionary<long, int> map = new Dictionary<long, int>();
            List<Unit> units = UnitHelper.GetAliveUnitList(self.UnionRaceScene, UnitType.Player);
            for (int i = 0; i < units.Count; i++)
            {
                if (Vector3.Distance(initPosi, units[i].Position) > 20)
                {
                    continue;
                }
                if (!map.ContainsKey(units[i].GetUnionId()))
                {
                    map.Add(units[i].GetUnionId(), 0);
                }
                map[units[i].GetUnionId()] += 1;
            }

            long winunionid = 0;
            int playernumber = 0;
            foreach ((long unioid, int number) in map)
            {
                if (number >= playernumber)
                {
                    winunionid = unioid;
                    playernumber = number;
                }
            }
            self.WinUnionId = winunionid;
            for (int i = 0; i < units.Count; i++)
            {
                if (winunionid == units[i].GetUnionId() && winunionid != 0)
                {
                    units[i].GetComponent<NumericComponent>().ApplyValue(NumericType.UnionRaceWin, 1, false, false);
                }
            }
        }

        public static async ETTask OnUnionRaceOver(this UnionSceneComponent self)
        {
            for (int i = 0; i < 2; i++)
            {
                await TimerComponent.Instance.WaitAsync(60 * 1000);
                self.CheckWinUnion();
            }

            long serverTime = TimeHelper.ServerNow();
            //通知家族争霸赛地图开始踢人
            List<Unit> units = UnitHelper.GetUnitList(self.UnionRaceScene, UnitType.Player);
            for (int i = 0; i < units.Count; i++)
            {
                if (units[i].Type != UnitType.Player)
                {
                    continue;
                }
                if (units[i].IsDisposed || units[i].IsRobot())
                {
                    continue;
                }
                if (self.WinUnionId == units[i].GetUnionId() && self.WinUnionId != 0)
                {
                    MailInfo mailInfo = new MailInfo();
                    mailInfo.Status = 0;
                    mailInfo.Title = "家族争霸赛奖励";
                    mailInfo.MailId = IdGenerater.Instance.GenerateId();

                    mailInfo.ItemList.Add(new BagInfo() { ItemID = 1, ItemNum = 100, GetWay = $"{ItemGetWay.UnionRace}_{serverTime}" });
                    MailHelp.SendUserMail(self.DomainZone(), units[i].Id, mailInfo).Coroutine();
                }
                TransferHelper.MainCityTransfer(units[i]).Coroutine();
            }

            self.DBUnionManager.WinUnionId = self.WinUnionId;
        }

        public static async ETTask OnUnionRaceBegin(this UnionSceneComponent self)
        {
            self.OnUnionRaceOver().Coroutine();
            await TimerComponent.Instance.WaitAsync(RandomHelper.RandomNumber(0, 1000));
            //long chatServerId = DBHelper.GetChatServerId( self.DomainZone() );
            //A2A_ServerMessageRResponse g_SendChatRequest = (A2A_ServerMessageRResponse)await ActorMessageSenderComponent.Instance.Call
            //    (chatServerId, new A2A_ServerMessageRequest()
            //    {
            //        MessageType = NoticeType.UnionRace,
            //    });
            List<UnionPlayerInfo> playerlist = new List<UnionPlayerInfo>();
            for (int i = 0; i < self.DBUnionManager.SignupUnions.Count; i++)
            {
                DBUnionInfo dBUnionInfo = await self.GetDBUnionInfo(self.DBUnionManager.SignupUnions[i]);
                if (dBUnionInfo == null)
                {
                    continue;
                }
                playerlist.AddRange(dBUnionInfo.UnionInfo.UnionPlayerList);
            }
            long gateServerId = DBHelper.GetGateServerId(self.DomainZone());
            M2C_HorseNoticeInfo m2C_HorseNoticeInfo = new M2C_HorseNoticeInfo()
            {
                NoticeType = NoticeType.UnionRace,
            };
            for (int i = 0; i < playerlist.Count; i++)
            {
                G2T_GateUnitInfoResponse g2M_UpdateUnitResponse = (G2T_GateUnitInfoResponse)await ActorMessageSenderComponent.Instance.Call
                 (gateServerId, new T2G_GateUnitInfoRequest()
                 {
                     UserID = playerlist[i].UserID
                 });
                if (g2M_UpdateUnitResponse.PlayerState == (int)PlayerState.Game && g2M_UpdateUnitResponse.SessionInstanceId > 0)
                {
                    MessageHelper.SendActor(g2M_UpdateUnitResponse.SessionInstanceId, m2C_HorseNoticeInfo);
                }
            }
            self.DBUnionManager.SignupUnions.Clear();
            self.DBUnionManager.rankingDonation.Clear();
            self.DBUnionManager.TotalDonation = 0;
        }

        public static void OnUnionBoss(this UnionSceneComponent self, Scene scene , long unionid)
        {
            long serverTime = TimeHelper.ServerNow();
            Vector3 initPosi = new Vector3(-73.3f, 0f, -9f);
            SceneConfig sceneConfig = SceneConfigCategory.Instance.Get(2000009);
            Unit unitMonster = UnitFactory.CreateMonster(scene, sceneConfig.BossId, initPosi, new CreateMonsterInfo()
            { Camp = CampEnum.CampMonster1, MasterID = 0, AttributeParams = String.Empty });

            if (self.UnionBossList.ContainsKey(unionid))
            {
                self.UnionBossList[unionid] = serverTime;
            }
            else
            {
                self.UnionBossList.Add(unionid, serverTime);
            }
        }

        public static void OnKillEvent(this UnionSceneComponent self, Scene scene,Unit defend, Unit attack)
        {
            SceneConfig sceneConfig = SceneConfigCategory.Instance.Get(2000009);
            if (defend.Type != UnitType.Monster || defend.ConfigId != sceneConfig.BossId)
            {
                return;
            }

            long serverTime = TimeHelper.ServerNow();
            List<Unit> players = UnitHelper.GetUnitList(scene, UnitType.Player);
            for (int i = 0; i < players.Count; i++)
            {
                MailInfo mailInfo = new MailInfo();
                mailInfo.Status = 0;
                mailInfo.Title = "家族BOSS奖励";
                mailInfo.MailId = IdGenerater.Instance.GenerateId();

                mailInfo.ItemList.Add(new BagInfo() { ItemID = 1, ItemNum = 100, GetWay = $"{ItemGetWay.UnionBoss}_{serverTime}" });
                MailHelp.SendUserMail(self.DomainZone(), players[i].Id, mailInfo).Coroutine();
            }
        }

        public static async ETTask GetUnionRaceId(this UnionSceneComponent self)
        {
            await TimerComponent.Instance.WaitAsync(60000 + self.DomainZone() * 100);
            long fubenid = IdGenerater.Instance.GenerateId();
            long fubenInstanceId = IdGenerater.Instance.GenerateInstanceId();

            SceneConfig sceneConfigs = SceneConfigCategory.Instance.Get(2000008);
            Scene fubnescene = SceneFactory.Create(self, fubenid, fubenInstanceId, self.DomainZone(), "UnionRace" + sceneConfigs.Id.ToString(), SceneType.Map);
            MapComponent mapComponent = fubnescene.GetComponent<MapComponent>();
            mapComponent.SetMapInfo(sceneConfigs.MapType, sceneConfigs.Id, 0);
            mapComponent.NavMeshId = sceneConfigs.MapID.ToString();
            Game.Scene.GetComponent<RecastPathComponent>().Update(int.Parse(mapComponent.NavMeshId));
            TransferHelper.NoticeFubenCenter(fubnescene, 1).Coroutine();
            self.UnionRaceScene = fubnescene;
        }

        public static long GetUnionFubenId(this UnionSceneComponent self, long unionid, long unitid)
        {
            //需要判读一下unitid 是否属于这个家族！
            if (self.UnionFubens.ContainsKey(unionid))
            {
                return self.UnionFubens[unionid];
            }
            int unionsceneid = 2000009;
            long fubenInstanceId = IdGenerater.Instance.GenerateInstanceId();
            Scene fubnescene = SceneFactory.Create(self, unionid, fubenInstanceId, self.DomainZone(), "Union" + unionid.ToString(), SceneType.Fuben);
           
            MapComponent mapComponent = fubnescene.GetComponent<MapComponent>();
            mapComponent.SetMapInfo((int)SceneTypeEnum.Union, unionsceneid, 0);
            mapComponent.NavMeshId = SceneConfigCategory.Instance.Get(unionsceneid).MapID.ToString();
            Game.Scene.GetComponent<RecastPathComponent>().Update(int.Parse(mapComponent.NavMeshId));
            FubenHelp.CreateNpc(fubnescene, unionsceneid);
            TransferHelper.NoticeFubenCenter(fubnescene, 1).Coroutine();
            self.UnionFubens.Add(unionid, fubenInstanceId);

            if (!self.UnionBossList.ContainsKey(unionid))
            {
                DateTime dateTime = TimeHelper.DateTimeNow();
                long curTime = (dateTime.Hour * 60 + dateTime.Minute) * 60 + dateTime.Second;
                long openTime = FunctionHelp.BossOpenTime();
                if (curTime >= openTime && curTime <= openTime + 300)
                {
                    self.OnUnionBoss(fubnescene, unionid);
                }
            }
           
            return fubenInstanceId;
        }

        public static  void SaveDB(this UnionSceneComponent self)
        {
            DBHelper.SaveComponent(self.DomainZone(), self.DomainZone(), self.DBUnionManager).Coroutine();
        }
    }
}
