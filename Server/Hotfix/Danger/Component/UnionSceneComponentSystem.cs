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

    [ObjectSystem]
    public class UnionSceneComponentAwakeSystem : AwakeSystem<UnionSceneComponent>
    {
        public override void Awake(UnionSceneComponent self)
        {
            self.OnAwake().Coroutine();
        }
    }

    public static class UnionSceneComponentSystem
    {

        public static async ETTask OnAwake(this UnionSceneComponent self)
        {
            await self.InitServerInfo();

            self.Timer = TimerComponent.Instance.NewRepeatedTimer(TimeHelper.Minute * 5 + self.DomainZone() * 1200, TimerType.UnionTimer, self);
        }

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
                return ErrorCode.ERR_Union_Not_Exist;
            }

            if (dBUnionInfo.UnionInfo.ApplyList.Contains(unitid))
            {
                dBUnionInfo.UnionInfo.ApplyList.Remove(unitid);
            }
            //判断玩家是否已经有家族了
            NumericComponent numericComponent_0 = await DBHelper.GetComponentCache<NumericComponent>(self.DomainZone(), unitid);
            if (numericComponent_0.GetAsLong(NumericType.UnionId_0) > 0)
            {
                return ErrorCode.ERR_PlayerHaveUnion;
            }

            //判断家族人数是否已满
            //获取家族等级
            UnionConfig unionCof = UnionConfigCategory.Instance.Get(dBUnionInfo.UnionInfo.Level);
            //判断家族成员是否已达上限
            if (replyCode == 1 && dBUnionInfo.UnionInfo.UnionPlayerList.Count >= unionCof.PeopleNum)
            {
                return ErrorCode.ERR_Union_PeopleMax;
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
                bool operateSucess = false; 
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
                    if (m2G_RechargeResponse.Error == ErrorCode.ERR_Success)
                    {
                        operateSucess = true;
                    }
                    else
                    {
                        Log.Warning($"加入帮会失败: {self.DomainZone()} {g2M_UpdateUnitResponse.UnitId}");
                    }
                }
                else
                {
                    operateSucess = true;
                    long dbCacheId = DBHelper.GetDbCacheId(self.DomainZone());
                    D2G_GetComponent d2GGet = (D2G_GetComponent)await ActorMessageSenderComponent.Instance.Call(dbCacheId, new G2D_GetComponent() { UnitId = unitid, Component = DBHelper.NumericComponent });
                    NumericComponent numericComponent = d2GGet.Component as NumericComponent;
                    numericComponent.Set(NumericType.UnionId_0, unionid, false);
                    D2M_SaveComponent d2GSave = (D2M_SaveComponent)await ActorMessageSenderComponent.Instance.Call(dbCacheId, new M2D_SaveComponent() { UnitId = unitid, EntityByte = MongoHelper.ToBson(numericComponent), ComponentType = DBHelper.NumericComponent });

                    d2GGet = (D2G_GetComponent)await ActorMessageSenderComponent.Instance.Call(dbCacheId, new G2D_GetComponent() { UnitId = unitid, Component = DBHelper.UserInfoComponent });
                    UserInfoComponent userInfoComponent = d2GGet.Component as UserInfoComponent;
                    userInfoComponent.UserInfo.UnionName = dBUnionInfo.UnionInfo.UnionName;
                    d2GSave = (D2M_SaveComponent)await ActorMessageSenderComponent.Instance.Call(dbCacheId, new M2D_SaveComponent() { UnitId = unitid, EntityByte = MongoHelper.ToBson(userInfoComponent), ComponentType = DBHelper.UserInfoComponent });
                }

                if (operateSucess)
                {
                    dBUnionInfo.UnionInfo.UnionPlayerList.Add(new UnionPlayerInfo()
                    {
                        UserID = unitid,
                    });
                }
            }

            DBHelper.SaveComponent(self.DomainZone(), unionid, dBUnionInfo).Coroutine();
            return ErrorCode.ERR_Success;
        }

        public static void OnZeroClockUpdate(this UnionSceneComponent self)
        {
            self.DBUnionManager.rankingDonation.Clear();
            self.UnionBossList.Clear();
        }

        public static void OnUnionBoss(this UnionSceneComponent self)
        {
            Log.Console("家族boss");
            foreach ((long unionid, long instanceid) in self.UnionFubens)
            {
                Scene scene = self.GetChild<Scene>(unionid);
                if (scene == null)
                {
                    Log.Debug($"{self.DomainZone()} {unionid} scene == null");
                    continue;
                }

                self.GenerateUnionBoss(scene, unionid);
            }
        }

        public static async ETTask CheckWinUnion(this UnionSceneComponent self, Scene fubnescene, int minite)
        {
            Vector3 initPosi = new Vector3(-73.3f, 0f, -9f);
            Dictionary<long, int> map = new Dictionary<long, int>();


            List<Unit> units = UnitHelper.GetAliveUnitList(fubnescene, UnitType.Player);
            for (int i = 0; i < units.Count; i++)
            {
                if (Vector3.Distance(initPosi, units[i].Position) > 20)
                {
                    continue;
                }
                long unionId = units[i].GetUnionId();

                if (!map.ContainsKey(unionId))
                {
                    map.Add(unionId, 0);
                }
                map[unionId] += 1;
            }

            long winunionid = 0;
            int playernumber = 0;
            string unionplayerNumber = $"{self.DomainZone()} 占领区人数: ";
            foreach ((long unioid, int number) in map)
            {
                if (number > playernumber)
                {
                    winunionid = unioid;
                    playernumber = number;
                }

                unionplayerNumber = unionplayerNumber +  $"{unioid}:{playernumber}  ";
            }

            for (int i = 0; i < units.Count; i++)
            {
                if (winunionid == units[i].GetUnionId() && winunionid != 0)
                {
                    units[i].GetComponent<NumericComponent>().ApplyValue(NumericType.UnionRaceWin, 1, true, false);
                }
                else
                {
                    units[i].GetComponent<NumericComponent>().ApplyValue(NumericType.UnionRaceWin, 0, true, false);
                }
            }
            self.WinUnionId = winunionid;

            if (minite == 0)
            {
                Log.Warning(unionplayerNumber);
                Log.Warning($"胜利家族:  {self.DomainZone()} {winunionid}");
            }

            DBUnionInfo dBUnionInfo = await self.GetDBUnionInfo(winunionid);
            if (dBUnionInfo != null)
            {
                ServerMessageHelper.SendBroadMessage(self.DomainZone(), NoticeType.Notice, $"恭喜 <color=#{ComHelp.QualityReturnColor(2)}>{dBUnionInfo.UnionInfo.UnionName}</color>家族占领了家族争霸赛地图!");
            }
        }

        public static void OnJoinUnionRace(this UnionSceneComponent self, long unionid, long unitid)
        {
            List<long> unitids = null;
            self.UnionRaceUnits.TryGetValue(unionid, out unitids);
            if (unitids == null)
            {
                self.UnionRaceUnits.Add(unionid, new List<long>());
            }
            self.UnionRaceUnits[unionid].Add(unitid);
        }

        public static async ETTask OnCheckWinUnion(this UnionSceneComponent self)
        {
            int minite = (int)((FunctionHelp.GetCloseTime(1044) - FunctionHelp.GetOpenTime(1044)) / 60);
            /////进程9
            Log.Console($"家族争霸赛开始！！:{self.DomainZone()}  {minite}");
            Log.Warning($"家族争霸赛开始！！:{self.DomainZone()}  {minite}");
            for (int i = minite - 1; i >= 0; i--)
            {
                await TimerComponent.Instance.WaitAsync(60 * 1000);
                Log.Console($"家族争霸赛检测！！: {self.DomainZone()}  {i}");

                Scene fubnescene = self.GetChild<Scene>(self.UnionRaceSceneId);
                if (fubnescene == null)
                {
                    break;
                }
                self.CheckWinUnion(fubnescene, i).Coroutine();
            }

            self.OnUnionRaceOver().Coroutine();
        }

        public static async ETTask OnUnionRaceOver(this UnionSceneComponent self)
        {
            long serverTime = TimeHelper.ServerNow();
           
            Log.Console($"家族争霸赛结束！！:{self.DomainZone()}");
            Log.Warning($"家族争霸赛结束！！: {self.DomainZone()}");
            int allwinunits = 0;
            int allfailunits = 0;
            foreach ((long unionid, List<long> unitids) in self.UnionRaceUnits)
            {
                for (int i = 0; i < unitids.Count; i++)
                {
                    if (unionid == self.WinUnionId)
                    {
                        allwinunits++;
                    }
                    else
                    {
                        allfailunits++;
                    }    
                }
            }

            long allJiangjin =(long) (0.8f * (self.DBUnionManager.TotalDonation + self.GetBaseJiangJin()));
            allwinunits = Math.Max(allwinunits, 10);
            allfailunits = Math.Max(allfailunits, 10);

            int winJingJin = (int)(allJiangjin * 0.6f / allwinunits);
            int failJiangJin = (int)(allJiangjin * 0.4f / allfailunits);

            Log.Console("家族战发放奖励");
            Log.Warning($"allwinunits: {allwinunits}   allfailunits: {allfailunits}  winJingJin: {winJingJin} failJiangJin:{failJiangJin} winunionid: {self.WinUnionId} allJiangjin:{allJiangjin}");

            
            long mailServerId = DBHelper.GetMailServerId(self.DomainZone());
            foreach (( long unionid, List<long> unitids ) in self.UnionRaceUnits )
            {
                for (int i = 0; i < unitids.Count; i++)
                {
                    MailInfo mailInfo = new MailInfo();
                    mailInfo.Status = 0;
                    mailInfo.Title = "家族争霸赛奖励";
                    mailInfo.MailId = IdGenerater.Instance.GenerateId();
                  
                    if (unionid == self.WinUnionId)
                    {
                        mailInfo.Context = "发送家族争霸赛胜利奖励";
                        Log.Warning($"发送奖励胜利！！: {self.DomainZone()} {unitids[i]}");
                        mailInfo.ItemList.Add(new BagInfo() { ItemID = 1, ItemNum = winJingJin,  GetWay = $"{ItemGetWay.UnionRace}_{serverTime}" });
                    }
                    else
                    {
                        mailInfo.Context = "发送家族争霸赛失败奖励";
                        Log.Warning($"发送奖励失败！！: {self.DomainZone()} {unitids[i]}");
                        mailInfo.ItemList.Add(new BagInfo() { ItemID = 1, ItemNum = failJiangJin, GetWay = $"{ItemGetWay.UnionRace}_{serverTime}" });
                    }

                    //MailHelp.SendUserMail(self.DomainZone(), unitids[i], mailInfo).Coroutine();
                    E2M_EMailSendResponse g_EMailSendResponse = (E2M_EMailSendResponse)await ActorMessageSenderComponent.Instance.Call
                                         (mailServerId, new M2E_EMailSendRequest()
                                         {
                                             Id = unitids[i],
                                             MailInfo = mailInfo,
                                             GetWay = ItemGetWay.UnionRace,
                                         });
                    if (g_EMailSendResponse.Error != ErrorCode.ERR_Success)
                    {
                        Log.Warning($"家族战发送奖励失败: {unitids[i]}");
                    }
                }
            }

            await TimerComponent.Instance.WaitAsync(1000);

            Scene fubnescene = self.GetChild<Scene>(self.UnionRaceSceneId);
            if (fubnescene != null)
            {
                List<Unit> units = UnitHelper.GetUnitList(fubnescene, UnitType.Player);
                M2C_UnionRaceInfoResult m2C_Battle = new M2C_UnionRaceInfoResult();
                m2C_Battle.SceneType = SceneTypeEnum.UnionRace;
                for (int i = 0; i < units.Count; i++)
                {
                    MessageHelper.SendToClient(units[i], m2C_Battle);
                }
            }

            //通知家族争霸赛地图开始踢人
            await TimerComponent.Instance.WaitAsync(TimeHelper.Minute);
            fubnescene = self.GetChild<Scene>(self.UnionRaceSceneId);
            if (fubnescene != null)
            {
                Actor_TransferRequest actor_Transfer = new Actor_TransferRequest()
                {
                    SceneType = SceneTypeEnum.MainCityScene,
                };
                List<Unit> units = UnitHelper.GetUnitList(fubnescene, UnitType.Player);
                for (int i = 0; i < units.Count; i++)
                {
                    TransferHelper.TransferUnit(units[i], actor_Transfer).Coroutine();
                }

                await TimerComponent.Instance.WaitAsync(RandomHelper.RandomNumber(1000, 2000));
                TransferHelper.NoticeFubenCenter(fubnescene, 2).Coroutine();
                fubnescene.Dispose();
            }
          
            self.DBUnionManager.SignupUnions.Clear();
            self.DBUnionManager.LastWeakDonation = self.DBUnionManager.TotalDonation;
            self.DBUnionManager.TotalDonation = (long)((self.GetBaseJiangJin() + self.DBUnionManager.TotalDonation )  * 0.2f);
            self.DBUnionManager.WinUnionId = self.WinUnionId;
            self.DBUnionManager.UnionRaceTime ++;
            self.UnionRaceUnits.Clear();
            self.SaveDB();
        }

        public static long GetBaseJiangJin(this UnionSceneComponent self)
        {
            if (self.DBUnionManager.UnionRaceTime == 0)
            {
                return 10000000;
            }
            if (self.DBUnionManager.UnionRaceTime == 1)
            {
                return 5000000;
            }
            return 3000000;
        }

        public static async ETTask OnUnionRaceBegin(this UnionSceneComponent self)
        {
            self.GenerateUnionRace();
            self.OnCheckWinUnion().Coroutine();
            await TimerComponent.Instance.WaitAsync(RandomHelper.RandomNumber(0, 1000));

            ///////
            //long chatServerId = DBHelper.GetChatServerId(self.DomainZone());
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
        }

        public static void GenerateUnionBoss(this UnionSceneComponent self, Scene scene , long unionid)
        {
            //获取开服天数
            int openDay = ServerHelper.GetOpenServerDay(false, self.DomainZone());
            
            int monsterID = 72000021;
            //根据开服天数创建怪物
            if (openDay >= 2)
            {
                monsterID = 72000022;
            }
            if (openDay >= 4)
            {
                monsterID = 72000023;
            }
            if (openDay >= 6)
            {
                monsterID = 72000024;
            }
            if (openDay >= 8)
            {
                monsterID = 72000025;
            }

            long serverTime = TimeHelper.ServerNow();
            Vector3 initPosi = new Vector3(0f, 0.5f, 0f);
            SceneConfig sceneConfig = SceneConfigCategory.Instance.Get(2000009);
            Unit unitMonster = UnitFactory.CreateMonster(scene, monsterID, initPosi, new CreateMonsterInfo()
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
        
        /// <summary>
        /// 家族boss击杀
        /// </summary>
        /// <param name="self"></param>
        /// <param name="scene"></param>
        /// <param name="defend"></param>
        public static void OnKillEvent(this UnionSceneComponent self, Scene scene,Unit defend)
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
                mailInfo.Title = "家族入侵怪物奖励";
                mailInfo.MailId = IdGenerater.Instance.GenerateId();

                mailInfo.ItemList.Add(new BagInfo() { ItemID = 1, ItemNum = 100, GetWay = $"{ItemGetWay.UnionBoss}_{serverTime}" });
                MailHelp.SendUserMail(self.DomainZone(), players[i].Id, mailInfo).Coroutine();
            }
        }

        public static void GenerateUnionRace(this UnionSceneComponent self)
        {
            long fubenid = IdGenerater.Instance.GenerateId();
            long fubenInstanceId = IdGenerater.Instance.GenerateInstanceId();

            SceneConfig sceneConfigs = SceneConfigCategory.Instance.Get(2000008);
            Scene fubnescene = SceneFactory.Create(self, fubenid, fubenInstanceId, self.DomainZone(), "UnionRace" + sceneConfigs.Id.ToString(), SceneType.Map);
            MapComponent mapComponent = fubnescene.GetComponent<MapComponent>();
            mapComponent.SetMapInfo(sceneConfigs.MapType, sceneConfigs.Id, 0);
            mapComponent.NavMeshId = sceneConfigs.MapID;
            Game.Scene.GetComponent<RecastPathComponent>().Update(mapComponent.NavMeshId);
            fubnescene.AddComponent<YeWaiRefreshComponent>().SceneId = 2000008;
            FubenHelp.CreateMonsterList(fubnescene, sceneConfigs.CreateMonster);
            FubenHelp.CreateMonsterList(fubnescene, sceneConfigs.CreateMonsterPosi);
            TransferHelper.NoticeFubenCenter(fubnescene, 1).Coroutine();
            self.UnionRaceSceneId = fubenid;
            self.UnionRaceSceneInstanceId = fubenInstanceId;    
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
            mapComponent.NavMeshId = SceneConfigCategory.Instance.Get(unionsceneid).MapID;
            Game.Scene.GetComponent<RecastPathComponent>().Update(mapComponent.NavMeshId);
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
                    self.GenerateUnionBoss(fubnescene, unionid);
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
