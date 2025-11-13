using MongoDB.Driver.Linq;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ET
{
    public static class ConsoleHelper
    {

        //新的账号： wxoVumu0idnDSrvRw9NfgxY4iRVz2Y  实名都不一样
        /// <summary>
        /// archive 181 3173035082982162432 2       //wxoVumu0kGTgy4EmcNn9FJPYduhJDo 你
        /// </summary>
        /// <param name="content"></param>
        /// <returns></returns>
        public static async ETTask ArchiveConsoleHandler(string content)
        {
            await ETTask.CompletedTask;
            Console.WriteLine($"request.Context:  ArchiveConsoleHandler: {content}");
#if SERVER
            string[] ss = content.Split(" ");
            if (ss.Length < 4)
            {
                Log.Console($"C must zone");
                return;
            }

            int zone = int.Parse(ss[1]);
            long unitid = long.Parse(ss[2]);
            int day = int.Parse(ss[3]);
            ArchiveHelper.OnArchiveHandler(zone, unitid, day).Coroutine();
#endif
        }


        public static async ETTask OnStopServer(List<int> zoneList)
        {
            await ETTask.CompletedTask;
#if SERVER
            await TimerComponent.Instance.WaitAsync(1 * TimeHelper.Minute);
            for (int i = 0; i < zoneList.Count; i++)
            {
                List<long> mapids = new List<long>()
                            {
                                 StartSceneConfigCategory.Instance.GetBySceneName(zoneList[i], "PaiMai").InstanceId,
                                 StartSceneConfigCategory.Instance.GetBySceneName(zoneList[i], "Rank").InstanceId,
                                 StartSceneConfigCategory.Instance.GetBySceneName(zoneList[i], "Union").InstanceId,
                            };

                for (int map = 0; map < mapids.Count; map++)
                {
                    A2A_ServerMessageRResponse m2m_TrasferUnitResponse = (A2A_ServerMessageRResponse)await ActorMessageSenderComponent.Instance.Call
                            (mapids[map], new A2A_ServerMessageRequest() { MessageType = NoticeType.StopSever });
                }
            }

            await TimerComponent.Instance.WaitAsync(10 * TimeHelper.Minute);
            for (int i = 0; i < zoneList.Count; i++)
            {
                List<long> mapids = new List<long>()
                            {
                                 StartSceneConfigCategory.Instance.GetBySceneName(zoneList[i], "PaiMai").InstanceId,
                                 StartSceneConfigCategory.Instance.GetBySceneName(zoneList[i], "Rank").InstanceId,
                                 StartSceneConfigCategory.Instance.GetBySceneName(zoneList[i], "Union").InstanceId,
                            };

                for (int map = 0; map < mapids.Count; map++)
                {
                    A2A_ServerMessageRResponse m2m_TrasferUnitResponse = (A2A_ServerMessageRResponse)await ActorMessageSenderComponent.Instance.Call
                            (mapids[map], new A2A_ServerMessageRequest() { MessageType = NoticeType.StopSever });
                }
            }

            Log.Warning("数据落地！");
            Log.Console("数据落地！");
            Console.WriteLine("数据落地！");
#endif
        }


        public static async ETTask StopServerConsoleHandler(string content)
        {
            await ETTask.CompletedTask;
#if SERVER

            string[] ss = content.Split(" ");
            if (ss.Length < 4)
            {
                Log.Console($"C must zone");
                return;
            }
            //stopserver 0 0 tcg452241 0 
            //stopserver 0 /  0[停] 0[开] 0[序] 0
            List<int> zoneList = new List<int> { };
            if (ss[1] == "0")
            {
                zoneList = ServerMessageHelper.GetAllZone();
            }
            else
            {
                zoneList.Add(int.Parse(ss[1]));
            }

            if (ss[2] == "0")  //0全部广播停服维护 1开服  2序列号 
            {
                for (int i = 0; i < zoneList.Count; i++)
                {
                    Log.Console($"zoneList111: {zoneList[i]} ");

                    long chatServerId = StartSceneConfigCategory.Instance.GetBySceneName(zoneList[i], "Chat").InstanceId;
                    A2A_ServerMessageRResponse g_SendChatRequest = (A2A_ServerMessageRResponse)await ActorMessageSenderComponent.Instance.Call
                        (chatServerId, new A2A_ServerMessageRequest()
                        {
                            MessageType = NoticeType.StopSever,
                            MessageValue = "停服维护"
                        });
                }
            }

            long accountServerId = StartSceneConfigCategory.Instance.AccountCenterConfig.InstanceId;
            A2A_ServerMessageRResponse response = (A2A_ServerMessageRResponse)await ActorMessageSenderComponent.Instance.Call
                (accountServerId, new A2A_ServerMessageRequest()
                {
                    MessageType = NoticeType.StopSever,
                    MessageValue = $"{ss[2]}_{ss[3]}"
                });

            if (ss[2] == "0")  //0全部广播停服维护 十分钟后数据落地
            {
                OnStopServer(zoneList).Coroutine();
            }

#endif
        }

        public static Dictionary<long, int> ShaiCha(Dictionary<long, int> dic, int showNum, out int minValue)
        {

            //排序
            dic = dic.OrderByDescending(o => o.Value).ToDictionary(p => p.Key, o => o.Value);
            int num = 0;
            int minValueNum = 0;
            foreach (long unitID in dic.Keys)
            {
                num++;

                if (num == dic.Count || num == showNum)
                {
                    minValueNum = dic[unitID];
                }

                if (num > showNum)
                {
                    dic.Remove(unitID);
                }
            }
            minValue = minValueNum;
            return dic;

        }

        public static async ETTask ServerRankConsoleHandler(string content)
        {
            await ETTask.CompletedTask;
            string[] chaxunInfo = content.Split(" ");
            if (chaxunInfo[0] != "serverrank")
            {
                return;
            }
#if SERVER
            int zone = int.Parse(chaxunInfo[1]);
            int pyzone = StartZoneConfigCategory.Instance.Get(zone).PhysicZone;
            long dbCacheId = DBHelper.GetDbCacheId(pyzone);

            Dictionary<long, int> dic = new Dictionary<long, int>();
            int lowCombat = 0;

            //查询全部玩家
            List<UserInfoComponent> userinfoComponentList = await Game.Scene.GetComponent<DBComponent>().Query<UserInfoComponent>(pyzone, d => d.Id > 0);
            for (int i = 0; i < userinfoComponentList.Count; i++)
            {
                UserInfoComponent userInfoComponent = userinfoComponentList[i];
                if (userInfoComponent.UserInfo.RobotId != 0)
                {
                    //continue;
                }


                if (userInfoComponent.UserInfo.Lv < 1)
                {
                    continue;
                }

                int combatFight = userInfoComponent.UserInfo.Combat;
                if (combatFight < lowCombat)
                {
                    continue;
                }

                dic.Add(userInfoComponent.UserInfo.UserId, combatFight);

                if (dic.Count >= 100)
                {

                    //开始筛查
                    dic = ShaiCha(dic, 10, out lowCombat);

                }
            }

            //开始筛查
            dic = ShaiCha(dic, 10, out lowCombat);

            Log.Debug($"服务器注册人数: {userinfoComponentList.Count}");

            foreach (long unitID in dic.Keys)
            {
                List<UserInfoComponent> userinfoComponentSing = await Game.Scene.GetComponent<DBComponent>().Query<UserInfoComponent>(pyzone, d => d.Id > 0 && d.UserInfo.UserId == unitID);
                if (userinfoComponentSing.Count > 0)
                {

                    //获取充值的数值组件
                    List<NumericComponent> numericComponent = await Game.Scene.GetComponent<DBComponent>().Query<NumericComponent>(pyzone, d => d.Id > 0 && d.Id == unitID);
                    string showStr = $"{userinfoComponentSing[0].UserInfo.Name} 战力:{userinfoComponentSing[0].UserInfo.Combat}金币:{userinfoComponentSing[0].UserInfo.Gold} 钻石:{userinfoComponentSing[0].UserInfo.Diamond} 职业{userinfoComponentSing[0].UserInfo.Occ}-{userinfoComponentSing[0].UserInfo.OccTwo} 充值:{numericComponent[0].GetAsInt(NumericType.RechargeNumber)}";
                    Log.Debug($"{showStr}");
                }
            }

#endif
        }

        //attribute 0 10   //所有区排行榜前10的属性点
        public static async ETTask AttributeConsoleHandler(string content)
        {
            Console.WriteLine($"request.Context:  AttributeConsoleHandler: {content}");
            string[] chaxunInfo = content.Split(" ");

            if (chaxunInfo.Length != 3)
            {
                Console.WriteLine($"C must have have zone");
                Log.Warning($"C must have have zone");
                return;
            }

            int zone = int.Parse(chaxunInfo[1]);
            int rankNumber = int.Parse(chaxunInfo[2]);

#if SERVER
            List<int> zonlist = new List<int> { };
            if (zone == 0)
            {
                zonlist = ServerMessageHelper.GetAllZone();
            }
            else
            {
                zonlist.Add(zone);
            }

            for (int i = 0; i < zonlist.Count; i++)
            {
                int pyzone = StartZoneConfigCategory.Instance.Get(zonlist[i]).PhysicZone;

                List<DBRankInfo> dBRankInfos = await Game.Scene.GetComponent<DBComponent>().Query<DBRankInfo>(pyzone, d => d.Id == pyzone);

                if (dBRankInfos == null || dBRankInfos.Count == 0)
                {
                    continue;
                }

                string levelInfo = $"{pyzone} 区排名前{rankNumber} 玩家属性点：";

                List<RankingInfo> rankingList = dBRankInfos[0].rankingInfos;


                for (int rank = 0; rank < rankNumber; rank++)
                {
                    if (rank >= rankingList.Count)
                    {
                        break;
                    }

                    long unitid = rankingList[rank].UserId;

                    List<UserInfoComponent> userinfoComponentlist = await Game.Scene.GetComponent<DBComponent>().Query<UserInfoComponent>(pyzone, d => d.Id == unitid);
                    if (userinfoComponentlist.Count == 0)
                    {
                        continue;
                    }
                    List<NumericComponent> unumericComponentlist = await Game.Scene.GetComponent<DBComponent>().Query<NumericComponent>(pyzone, d => d.Id == unitid);
                    if (userinfoComponentlist.Count == 0)
                    {
                        continue;
                    }
                    //public const int PointLiLiang = 3042;
                    //public const int PointZhiLi = 3043;
                    //public const int PointTiZhi = 3044;
                    //public const int PointNaiLi = 3045;
                    //public const int PointMinJie = 3046;

                    levelInfo += $"\t排名:{rank + 1} \t玩家: {userinfoComponentlist[0].UserName} \t职业: {userinfoComponentlist[0].UserInfo.Occ} " +
                        $"\t第二职业: {userinfoComponentlist[0].UserInfo.OccTwo} \t力量: {unumericComponentlist[0].GetAsInt(NumericType.PointLiLiang)} " +
                        $"\t智力: {unumericComponentlist[0].GetAsInt(NumericType.PointZhiLi)} \t体质: {unumericComponentlist[0].GetAsInt(NumericType.PointTiZhi)} " +
                        $"\t耐力: {unumericComponentlist[0].GetAsInt(NumericType.PointNaiLi)} \t敏捷: {unumericComponentlist[0].GetAsInt(NumericType.PointMinJie)} ";
                }

                LogHelper.GongZuoShi(levelInfo);
            }
#endif

            await ETTask.CompletedTask;
        }


        public static async ETTask ClearChatConsoleHandler(string content)
        {
            Console.WriteLine($"request.Context:  ClearChatConsoleHandler: {content}");
            await ETTask.CompletedTask;
            string[] chaxunInfo = content.Split(" ");
           
            if (chaxunInfo.Length != 2)
            {
                Console.WriteLine($"C must have have zone");
                Log.Warning($"C must have have zone");
                return;
            }

            int zone = int.Parse(chaxunInfo[1]);
            long chatServerId = StartSceneConfigCategory.Instance.GetBySceneName(zone, "Chat").InstanceId;
            A2A_ServerMessageRResponse g_SendChatRequest = (A2A_ServerMessageRResponse)await ActorMessageSenderComponent.Instance.Call
                (chatServerId, new A2A_ServerMessageRequest()
                {
                    MessageType = NoticeType.ClearChat,
                    MessageValue = "清空聊天"
                });
        }

        public static async ETTask JinYanConsoleHandler(string content)
        {
            Console.WriteLine($"request.Context:  JinYanConsoleHandler: {content}");
            await ETTask.CompletedTask;
            string[] chaxunInfo = content.Split(" ");

            if (chaxunInfo.Length != 3)
            {
                Console.WriteLine($"C must have have zone");
                Log.Warning($"C must have have zone");
                return;
            }

            int zone = int.Parse(chaxunInfo[1]);
            long chatServerId = StartSceneConfigCategory.Instance.GetBySceneName(zone, "Chat").InstanceId;
            A2A_ServerMessageRResponse g_SendChatRequest = (A2A_ServerMessageRResponse)await ActorMessageSenderComponent.Instance.Call
                (chatServerId, new A2A_ServerMessageRequest()
                {
                    MessageType = NoticeType.JinYan,
                    MessageValue = content
                });
        }

        /// <summary>
        /// 查询排名前几的玩家充值   rechargechaXun 0 3  (所有区前三的玩家充值)
        /// </summary>
        /// <param name="content"></param>
        /// <returns></returns>
        public static async ETTask RechargeChaXunConsoleHandler(string content)
        {
            Console.WriteLine($"request.Context:  RechargeChaXunConsoleHandler: {content}");
            await ETTask.CompletedTask;
            string[] chaxunInfo = content.Split(" ");
            if (chaxunInfo[0] != "rechargechaXun")
            {
                Console.WriteLine($"C must have recharge zone");
                Log.Warning($"C must have recharge zone");
                return;
            }
            if (chaxunInfo.Length != 3)
            {
                Console.WriteLine($"C must have have zone");
                Log.Warning($"C must have have zone");
                return;
            }

#if SERVER
            int zone = int.Parse(chaxunInfo[1]);
            List<int> zonlist = new List<int> { };
            if (zone == 0)
            {
                zonlist = ServerMessageHelper.GetAllZone();
            }
            else
            {
                zonlist.Add(zone);
            }
            long rankNumber = long.Parse(chaxunInfo[2]);
            for (int i = 0; i < zonlist.Count; i++)
            {
                int pyzone = StartZoneConfigCategory.Instance.Get(zonlist[i]).PhysicZone;
                
                List<DBRankInfo> dBRankInfos = await Game.Scene.GetComponent<DBComponent>().Query<DBRankInfo>(pyzone, d => d.Id == pyzone);

                if (dBRankInfos == null || dBRankInfos.Count == 0)
                {
                    continue;
                }

                string levelInfo = $"{pyzone} 区排名前{rankNumber} 玩家充值：";

                List<RankingInfo> rankingList = dBRankInfos[0].rankingInfos;
                

                for (int rank = 0; rank < rankNumber; rank++)
                {
                    if (rank >= rankingList.Count)
                    {
                        break;
                    }

                    long unitid = rankingList[rank].UserId;

                    List<UserInfoComponent> userinfoComponentlist = await Game.Scene.GetComponent<DBComponent>().Query<UserInfoComponent>(pyzone, d => d.Id == unitid);
                    if (userinfoComponentlist.Count == 0)
                    {
                        continue;
                    }
                    List<NumericComponent> unumericComponentlist = await Game.Scene.GetComponent<DBComponent>().Query<NumericComponent>(pyzone, d => d.Id == unitid);
                    if (userinfoComponentlist.Count == 0)
                    {
                        continue;
                    }

                    levelInfo += $"排名: {rank+1}   \t玩家：{userinfoComponentlist[0].UserName}   \t充值：{unumericComponentlist[0].GetAsInt(NumericType.RechargeNumber)}      \t";
                }


                LogHelper.GongZuoShi(levelInfo);
            }
#endif
        }

        /// <summary>
        /// 全部玩家拍卖所得金币列表
        /// </summary>
        /// <param name="content"></param>
        /// <returns></returns>
        public static async ETTask PaiMaiConsoleHandler(string content)
        {
            Console.WriteLine($"request.Context:  PaiMaiConsoleHandler: {content}");
            await ETTask.CompletedTask;
            string[] chaxunInfo = content.Split(" ");
            if (chaxunInfo[0] != "paimai")
            {
                Console.WriteLine($"C must have paimai zone");
                Log.Warning($"C must have paimai zone");
                return;
            }
            if (chaxunInfo.Length != 3)
            {
                Console.WriteLine($"C must have paimai zone");
                Log.Warning($"C must have paimai zone");
                return;
            }
#if SERVER
            int zone = int.Parse(chaxunInfo[1]);
            List<int> zonlist = new List<int> { };
            if (zone == 0)
            {
                zonlist = ServerMessageHelper.GetAllZone();
            }
            else
            {
                zonlist.Add(zone);
            }
            long maxGold = long.Parse(chaxunInfo[2]);
            for (int i = 0; i < zonlist.Count; i++)
            {
                int pyzone = StartZoneConfigCategory.Instance.Get(zonlist[i]).PhysicZone;
                long dbCacheId = DBHelper.GetDbCacheId(pyzone);

                List<KeyValuePairLong> allpaimai = new List<KeyValuePairLong>();    
                string levelInfo = $"{pyzone}区玩家拍卖金币>{maxGold}列表： \n";
                List<DataCollationComponent> userinfoComponentList = await Game.Scene.GetComponent<DBComponent>().Query<DataCollationComponent>(pyzone, d => d.PaiMaiGold > maxGold);
                for (int userinfo = 0; userinfo < userinfoComponentList.Count; userinfo++)
                {
                    DataCollationComponent dataComponent = userinfoComponentList[userinfo];
                    //if (GMHelp.GmAccount.Contains(dataComponent.Account))
                    //{
                    //    continue;
                    //}

                    allpaimai.Add( new KeyValuePairLong() { KeyId = dataComponent.Id, Value = dataComponent.PaiMaiGold } );
                }
                
                allpaimai.Sort(delegate (KeyValuePairLong a, KeyValuePairLong b)
                {
                    return (int)(a.Value - b.Value);   
                });

                for (int paimaigold = 0; paimaigold < allpaimai.Count; paimaigold++)
                {
                    KeyValuePairLong pairLong = allpaimai[paimaigold];

                    List<UserInfoComponent> userinfoComponentlist = await Game.Scene.GetComponent<DBComponent>().Query<UserInfoComponent>(pyzone, d => d.Id == pairLong.KeyId);
                    if (userinfoComponentlist == null || userinfoComponentlist.Count == 0)
                    {
                        return;
                    }
                    UserInfoComponent userInfoComponent = userinfoComponentlist[0]; 
                    levelInfo += $"{userInfoComponent.UserInfo.Name}   \t拍卖获得金币:{pairLong.Value}   \t账号:{userInfoComponent.Account}   \t钻石:{userInfoComponent.UserInfo.Diamond}  \t金币:{userInfoComponent.UserInfo.Gold} \n";
                }

                LogHelper.GongZuoShi(levelInfo);
            }
#endif
        }


        /// <summary>
        /// 今日拍卖所得金币列表
        /// </summary>
        /// <param name="content"></param>
        /// <returns></returns>
        public static async ETTask PaiMai2_ConsoleHandler(string content)
        {
            Console.WriteLine($"request.Context:  PaiMaiConsoleHandler: {content}");
            await ETTask.CompletedTask;
            string[] chaxunInfo = content.Split(" ");
            if (chaxunInfo[0] != "paimai2")
            {
                Console.WriteLine($"C must have paimai zone");
                Log.Warning($"C must have paimai zone");
                return;
            }
            if (chaxunInfo.Length != 3)
            {
                Console.WriteLine($"C must have paimai zone");
                Log.Warning($"C must have paimai zone");
                return;
            }
#if SERVER
            int zone = int.Parse(chaxunInfo[1]);
            List<int> zonlist = new List<int> { };
            if (zone == 0)
            {
                zonlist = ServerMessageHelper.GetAllZone();
            }
            else
            {
                zonlist.Add(zone);
            }
            long maxGold = long.Parse(chaxunInfo[2]);
            string levelInfo = string.Empty;
            for (int i = 0; i < zonlist.Count; i++)
            {
                int pyzone = StartZoneConfigCategory.Instance.Get(zonlist[i]).PhysicZone;
                long dbCacheId = DBHelper.GetDbCacheId(pyzone);

                List<KeyValuePairLong> allpaimai = new List<KeyValuePairLong>();
                levelInfo  +=  $"{pyzone}区玩家拍卖金币>{maxGold}列表： \n";
                List<DataCollationComponent> userinfoComponentList = await Game.Scene.GetComponent<DBComponent>().Query<DataCollationComponent>(pyzone, d => d.PaiMaiGold > maxGold);
                for (int userinfo = 0; userinfo < userinfoComponentList.Count; userinfo++)
                {
                    DataCollationComponent dataComponent = userinfoComponentList[userinfo];
                    //if (GMHelp.GmAccount.Contains(dataComponent.Account))
                    //{
                    //    continue;
                    //}
                    if (dataComponent.PaiMaiGold < maxGold)
                    {
                        continue;
                    }

                    allpaimai.Add(new KeyValuePairLong() { KeyId = dataComponent.Id, Value = dataComponent.PaiMaiGold });
                }

                allpaimai.Sort(delegate (KeyValuePairLong a, KeyValuePairLong b)
                {
                    return (int)(a.Value - b.Value);
                });

                for (int paimaigold = 0; paimaigold < allpaimai.Count; paimaigold++)
                {
                    KeyValuePairLong pairLong = allpaimai[paimaigold];

                    List<UserInfoComponent> userinfoComponentlist = await Game.Scene.GetComponent<DBComponent>().Query<UserInfoComponent>(pyzone, d => d.Id == pairLong.KeyId);
                    if (userinfoComponentlist == null || userinfoComponentlist.Count == 0)
                    {
                        return;
                    }
                    UserInfoComponent userInfoComponent = userinfoComponentlist[0];
                    levelInfo += $"{userInfoComponent.UserInfo.Name}   \t拍卖获得金币:{pairLong.Value}   \t账号:{userInfoComponent.Account}   \t钻石:{userInfoComponent.UserInfo.Diamond}  \t金币:{userInfoComponent.UserInfo.Gold} \n";
                }
            }
            LogHelper.PaiMai2Info(levelInfo);
#endif
        }

        //gongzuoshi所有在线
        public static async ETTask GongZuoShi1_ConsoleHandler(string content)
        {
            Console.WriteLine($"request.Context:  GongZuoShiConsoleHandler: {content}");
            await ETTask.CompletedTask;
            string[] chaxunInfo = content.Split(" ");
            if (chaxunInfo.Length != 2)
            {
                Console.WriteLine($"C must have gongzuoshi zone");
                Log.Warning($"C must have gongzuoshi zone");
                return;
            }

#if SERVER

            int zone = int.Parse(chaxunInfo[1]);
            List<int> zonlist = new List<int> { };
            if (zone == 0)
            {
                zonlist = ServerMessageHelper.GetAllZone();
            }
            else
            {
                zonlist.Add(zone);
            }

            //1.游戏总时长超过180分钟
            //2.击败BOSS数量小于3
            //3.游戏内成就4個擊殺boss都沒完成 10000002-10000005
            //4.手机登录
            //5.当前体力小于50
            //6.今日在线时间超过120分钟
            //7.主线任务完成不超过10个
            //8.拍卖行收益总共超过100万
            long serverNow = TimeHelper.ServerNow();
            int curDate = ComHelp.GetDayByTime(serverNow);

            Dictionary<string, int> accountNumber = new Dictionary<string, int>();

            for (int i = 0; i < zonlist.Count; i++)
            {
                int pyzone = StartZoneConfigCategory.Instance.Get(zonlist[i]).PhysicZone;

                long dbCacheId = DBHelper.GetDbCacheId(pyzone);

                string gongzuoshiInfo = $"{pyzone}区在线账号列表1： \n";


                long gateServerId = StartSceneConfigCategory.Instance.GetBySceneName(pyzone, "Gate1").InstanceId;
                G2G_UnitListResponse g2M_UpdateUnitResponse = (G2G_UnitListResponse)await ActorMessageSenderComponent.Instance.Call
                    (gateServerId, new G2G_UnitListRequest() { });

                Console.WriteLine($"{pyzone}区 在线人数:{g2M_UpdateUnitResponse.UnitList.Count}");
                for (int userinfo = 0; userinfo < g2M_UpdateUnitResponse.UnitList.Count; userinfo++)
                {
                    long unitId = g2M_UpdateUnitResponse.UnitList[userinfo];

                    List<UserInfoComponent> userinfoComponentList = await Game.Scene.GetComponent<DBComponent>().Query<UserInfoComponent>(pyzone, d => d.Id == unitId);
                    if (userinfoComponentList == null || userinfoComponentList.Count == 0)
                    {
                        continue;
                    }
                    UserInfoComponent userInfoComponent = userinfoComponentList[0];

                    if (GMHelp.GmAccount.Contains(userInfoComponent.Account))
                    {
                        continue;
                    }

                    //击败boss>3返回
                    //击败boss>3返回
                    int killmonsterNumber = ComHelp.KillBoss_Lv_Number(userInfoComponent.UserInfo.MonsterRevives, userInfoComponent.UserInfo.Lv);
                    //if (killmonsterNumber >= 3)
                    //{
                    //    continue;
                    //}
                    //当前体力>50返回
                    //if (userInfoComponent.UserInfo.PiLao > 50)
                    //{
                    //    continue;
                    //}

                    //if (curDate != ComHelp.GetDayByTime(userInfoComponent.LastLoginTime))
                    //{
                    //    continue;
                    //}


                    //非手机登录返回
                    //if (string.IsNullOrEmpty(userInfoComponent.Account) || userInfoComponent.Account[0] != '1')
                    //{
                    //    continue;
                    //}

                    List<DataCollationComponent> dataCollations = await Game.Scene.GetComponent<DBComponent>().Query<DataCollationComponent>(pyzone, d => d.Id == userInfoComponent.Id);
                    if (dataCollations == null || dataCollations.Count == 0)
                    {
                        continue;
                    }
                    dataCollations[0].TodayOnLine = userInfoComponent.TodayOnLine;
                    //游戏总时长超过180分钟返回
                    //暂时不写

                    //今日在线时间超过120分钟返回
                    //if (dataCollations[0].TodayOnLine < 120)
                    //{
                    //    continue;
                    //}

                    //拍卖行收益总小于100万返回
                    //if (dataCollations[0].GetCostByType(ItemGetWay.PaiMaiBuy) < 1000000)
                    //{
                    //    continue;
                    //}

                    List<ChengJiuComponent> chengJiuComponents = await Game.Scene.GetComponent<DBComponent>().Query<ChengJiuComponent>(pyzone, d => d.Id == userInfoComponent.Id);
                    if (chengJiuComponents == null || chengJiuComponents.Count == 0)
                    {
                        continue;
                    }

                    int chengjiuTask = 0;
                    //3.游戏内成就4個擊殺boss都沒完成 10000002 - 10000005
                    //if (chengJiuComponents[0].ChengJiuCompleteList.Contains(10000002)
                    //    || chengJiuComponents[0].ChengJiuCompleteList.Contains(10000003)
                    //    || chengJiuComponents[0].ChengJiuCompleteList.Contains(10000004)
                    //    || chengJiuComponents[0].ChengJiuCompleteList.Contains(10000005))
                    //{
                    //    continue;
                    //}
                    if (chengJiuComponents[0].ChengJiuCompleteList.Contains(10000002))
                    {
                        chengjiuTask++;
                    }
                    if (chengJiuComponents[0].ChengJiuCompleteList.Contains(10000003))
                    {
                        chengjiuTask++;
                    }
                    if (chengJiuComponents[0].ChengJiuCompleteList.Contains(10000004))
                    {
                        chengjiuTask++;
                    }
                    if (chengJiuComponents[0].ChengJiuCompleteList.Contains(10000005))
                    {
                        chengjiuTask++;
                    }


                    List<TaskComponent> taskComponents = await Game.Scene.GetComponent<DBComponent>().Query<TaskComponent>(pyzone, d => d.Id == userInfoComponent.Id);
                    if (taskComponents == null || taskComponents.Count == 0)
                    {
                        continue;
                    }
                    //if (taskComponents[0].GetMainTaskNumber() > 10)
                    //{
                    //    continue;
                    //}


                    List<DBCenterAccountInfo> accoutResult = await Game.Scene.GetComponent<DBComponent>().Query<DBCenterAccountInfo>(202, _account => _account.Account == userInfoComponent.Account);
                    if (accoutResult == null || accoutResult.Count == 0)
                    {
                        continue;
                    }
                    if (accoutResult[0].AccountType == 2)
                    {
                        continue;
                    }

                    string idcard = string.Empty;
                    if (accoutResult[0].PlayerInfo != null)
                    {
                        idcard = accoutResult[0].PlayerInfo.IdCardNo;
                    }

                    //等级 充值  活跃度 体力 当前金币   成就点数  当前主线任务
                    gongzuoshiInfo += $"账号: {userInfoComponent.Account}  \t名称：{userInfoComponent.UserInfo.Name}  \t等级:{userInfoComponent.UserInfo.Lv}   \t充值:{dataCollations[0].Recharge}" +
                            $"\t体力:{userInfoComponent.UserInfo.PiLao}  \t金币:{userInfoComponent.UserInfo.Gold}   \t成就值:{chengJiuComponents[0].TotalChengJiuPoint}   \t拍卖消耗:{dataCollations[0].GetCostByType(ItemGetWay.PaiMaiBuy)}" +
                            $"\t当前主线:{dataCollations[0].MainTask}  \t角色天数:{userInfoComponent.GetCrateDay()}  \t金币获取:{dataCollations[0].GoldGet}  \t金币消耗:{dataCollations[0].GoldCost}   \t成就任务:{chengjiuTask}" + 
                            $"\t金币获取总值:{dataCollations[0].GetGoldGetTotal()}  \t金币消耗总值:{dataCollations[0].GetGoldCostTotal()} 今日在线:{dataCollations[0].TodayOnLine}  \t击杀boos:{killmonsterNumber} \t设备:{dataCollations[0].GetDeviceID()}" +
                            $"\tIP:{userInfoComponent.RemoteAddress}  身份证:{idcard} \n";
                    
                    if (!accountNumber.ContainsKey(userInfoComponent.Account))
                    {
                        accountNumber.Add(userInfoComponent.Account, 0);
                    }
                    accountNumber[userInfoComponent.Account]++;
                }
                LogHelper.GongZuoShi(gongzuoshiInfo);
            }

            //string fenhaoTip = string.Empty;
            //foreach ((string account, int number) in accountNumber)
            //{
            //    if (number >= 3)  //三次以上封账号封设备id
            //    {
            //        fenhaoTip += ($"封号： {account}");
            //        List<DBCenterAccountInfo> accoutResult = await Game.Scene.GetComponent<DBComponent>().Query<DBCenterAccountInfo>(202, _account => _account.Account == account);
            //        if (accoutResult != null && accoutResult.Count > 0)
            //        {
            //            accoutResult[0].AccountType = 2;
            //            Game.Scene.GetComponent<DBComponent>().Save<DBCenterAccountInfo>(202, accoutResult[0]).Coroutine();
            //        }
            //    }
            //}
            //LogHelper.PaiMaiInfo(fenhaoTip);
#endif
        }

        //gongzuoshi2 踢所有在线（成就4任务）
        public static async ETTask GongZuoShi2_ConsoleHandler(string content)
        {
            Console.WriteLine($"request.Context:  GongZuoShiConsoleHandler: {content}");
            await ETTask.CompletedTask;
            string[] chaxunInfo = content.Split(" ");
            if (chaxunInfo.Length != 2)
            {
                Console.WriteLine($"C must have gongzuoshi zone");
                Log.Warning($"C must have gongzuoshi zone");
                return;
            }

#if SERVER

            int zone = int.Parse(chaxunInfo[1]);
            List<int> zonlist = new List<int> { };
            if (zone == 0)
            {
                zonlist = ServerMessageHelper.GetAllZone();
            }
            else
            {
                zonlist.Add(zone);
            }

            //1.游戏总时长超过180分钟
            //2.击败BOSS数量小于3
            //3.游戏内成就点数小于50点  改成游戏内成就点数小于100点 且 4个成就=0
            //4.手机登录
            //5.当前体力小于50
            //6.今日在线时间超过120分钟
            //7.主线任务完成不超过10个
            //8.拍卖行收益总共超过100万

            long serverNow = TimeHelper.ServerNow();
            int curDate = ComHelp.GetDayByTime(serverNow);
           
            Dictionary<string, List<long>> accountNumber = new Dictionary<string, List<long>>();  
            for (int i = 0; i < zonlist.Count; i++)
            {
                int pyzone = StartZoneConfigCategory.Instance.Get(zonlist[i]).PhysicZone;

                long dbCacheId = DBHelper.GetDbCacheId(pyzone);

                string gongzuoshiInfo = $"{pyzone}区疑似工作室在线账号列表2： \n";


                long gateServerId = StartSceneConfigCategory.Instance.GetBySceneName(pyzone, "Gate1").InstanceId;
                G2G_UnitListResponse g2M_UpdateUnitResponse = (G2G_UnitListResponse)await ActorMessageSenderComponent.Instance.Call
                    (gateServerId, new G2G_UnitListRequest() { });

                Console.WriteLine($"{pyzone}区 在线人数:{g2M_UpdateUnitResponse.UnitList.Count}");
                for (int userinfo = 0; userinfo < g2M_UpdateUnitResponse.UnitList.Count; userinfo++)
                {
                    long unitId = g2M_UpdateUnitResponse.UnitList[userinfo];

                    List<UserInfoComponent> userinfoComponentList = await Game.Scene.GetComponent<DBComponent>().Query<UserInfoComponent>(pyzone, d => d.Id == unitId);
                    if(userinfoComponentList == null || userinfoComponentList.Count == 0)
                    {
                        continue;
                    }

                    UserInfoComponent userInfoComponent = userinfoComponentList[0];
                    if (userInfoComponent.UserInfo.RobotId != 0)
                    {
                        continue;
                    }

                    if (GMHelp.GmAccount.Contains(userInfoComponent.Account))
                    {
                        continue;
                    }

                    //击败boss>3返回
                    int killmonsterNumber = ComHelp.KillBoss_Lv_Number(userInfoComponent.UserInfo.MonsterRevives, userInfoComponent.UserInfo.Lv);
                    if (killmonsterNumber >= 3)
                    {
                        continue;
                    }

                    //当前体力>50返回
                    if (userInfoComponent.UserInfo.PiLao > 50)
                    {
                        continue;
                    }

                    //if (curDate != ComHelp.GetDayByTime(userInfoComponent.LastLoginTime))
                    //{
                    //    continue;
                    //}

                    //非手机登录返回
                    //if (string.IsNullOrEmpty(userInfoComponent.Account) || userInfoComponent.Account[0] != '1')
                    //{
                    //    continue;
                    //}

                    List<DataCollationComponent> dataCollations = await Game.Scene.GetComponent<DBComponent>().Query<DataCollationComponent>(pyzone, d => d.Id == userInfoComponent.Id);
                    if (dataCollations == null || dataCollations.Count == 0)
                    {
                        continue;
                    }
                    dataCollations[0].TodayOnLine = userInfoComponent.TodayOnLine;
                    //游戏总时长超过180分钟返回
                    //暂时不写

                    //今日在线时间超过120分钟返回
                    if (dataCollations[0].TodayOnLine < 120)
                    {
                        continue;
                    }
                    if (dataCollations[0].TotalOnLine < 200)
                    {
                        continue;
                    }

                    //拍卖行收益总小于100万返回
                    //if (dataCollations[0].GetCostByType(ItemGetWay.PaiMaiBuy) < 1000000)
                    //{
                    //    continue;
                    //}

                    List<ChengJiuComponent> chengJiuComponents = await Game.Scene.GetComponent<DBComponent>().Query<ChengJiuComponent>(pyzone, d => d.Id == userInfoComponent.Id);
                    if (chengJiuComponents == null || chengJiuComponents.Count == 0)
                    {
                        continue;
                    }

                    //游戏内成就点数>50点返回
                    //if (chengJiuComponents[0].TotalChengJiuPoint > 50)
                    //{
                    //    continue;
                    //}
                    //3.游戏内成就4個擊殺boss都沒完成 10000002 - 10000005
                    if (chengJiuComponents[0].ChengJiuCompleteList.Contains(10000002)
                        || chengJiuComponents[0].ChengJiuCompleteList.Contains(10000003)
                        || chengJiuComponents[0].ChengJiuCompleteList.Contains(10000004)
                        || chengJiuComponents[0].ChengJiuCompleteList.Contains(10000005))
                    {
                        continue;
                    }


                    List<TaskComponent> taskComponents = await Game.Scene.GetComponent<DBComponent>().Query<TaskComponent>(pyzone, d => d.Id == userInfoComponent.Id);
                    if (taskComponents == null || taskComponents.Count == 0)
                    {
                        continue;
                    }

                    if (taskComponents[0].GetMainTaskNumber() > 10)
                    {
                        continue;
                    }

                    List<DBCenterAccountInfo> accoutResult = await Game.Scene.GetComponent<DBComponent>().Query<DBCenterAccountInfo>(202, _account => _account.Account == userInfoComponent.Account);
                    if (accoutResult == null || accoutResult.Count == 0)
                    {
                        continue;
                    }
                    if (accoutResult[0].AccountType == 2)
                    {
                        continue;
                    }

                    List<DBAccountInfo> accoutResult_2 = await Game.Scene.GetComponent<DBComponent>().Query<DBAccountInfo>(pyzone, _account => _account.Account == userInfoComponent.Account);
                    if (accoutResult_2 != null && accoutResult_2.Count > 0 && accoutResult_2[0].BanUserList != null && accoutResult_2[0].BanUserList.Contains(userInfoComponent.Id))
                    {
                        continue;
                    }
                    string idcard = string.Empty;
                    if (accoutResult[0].PlayerInfo != null)
                    {
                        idcard = accoutResult[0].PlayerInfo.IdCardNo;
                    }

                    //等级 充值  活跃度 体力 当前金币   成就点数  当前主线任务
                    gongzuoshiInfo += $"账号: {userInfoComponent.Account}  \t名称：{userInfoComponent.UserInfo.Name}  \t等级:{userInfoComponent.UserInfo.Lv}   \t充值:{dataCollations[0].Recharge}" +
                        $"\t体力:{userInfoComponent.UserInfo.PiLao}  \t金币:{userInfoComponent.UserInfo.Gold}   \t成就值:{chengJiuComponents[0].TotalChengJiuPoint}   \t拍卖消耗:{dataCollations[0].GetCostByType(ItemGetWay.PaiMaiBuy)}" +
                        $"\t当前主线:{dataCollations[0].MainTask}  \t角色天数:{userInfoComponent.GetCrateDay()}  \t金币获取:{dataCollations[0].GoldGet}  \t金币消耗:{dataCollations[0].GoldCost} " +
                        $"\t金币获取总值:{dataCollations[0].GetGoldGetTotal()}  \t金币消耗总值:{dataCollations[0].GetGoldCostTotal()} 今日在线:{dataCollations[0].TodayOnLine}  \t击杀boos:{killmonsterNumber} \t设备:{dataCollations[0].GetDeviceID()}" +
                        $"\tIP:{userInfoComponent.RemoteAddress}  身份证:{idcard} \n";
                    
                    
                    if (!accountNumber.ContainsKey(userInfoComponent.Account))
                    {
                        accountNumber.Add(userInfoComponent.Account, new List<long>());
                    }
                    accountNumber[userInfoComponent.Account].Add(userInfoComponent.Id);
                }
                LogHelper.GongZuoShi(gongzuoshiInfo);
            }


            string fenhaoTip = string.Empty;
            foreach ((string account, List<long> unitids) in accountNumber)
            {
                if (unitids.Count >= 3 && !account.Contains("testcn"))  //三次以上封账号封设备id
                {
                    fenhaoTip += ($"封号： {account}");
                    List<DBCenterAccountInfo> accoutResult = await Game.Scene.GetComponent<DBComponent>().Query<DBCenterAccountInfo>(202, _account => _account.Account == account);
                    if (accoutResult != null && accoutResult.Count > 0)
                    {
                        accoutResult[0].AccountType = 2;
                        accoutResult[0].BanTime = serverNow;
                        Game.Scene.GetComponent<DBComponent>().Save<DBCenterAccountInfo>(202, accoutResult[0]).Coroutine();
                    }
                    continue;
                }

                if (unitids.Count == 0)
                {
                    continue;
                }

                for (int i = 0; i < unitids.Count; i++)
                {
                    int unitzone = UnitIdStruct.GetUnitZone(unitids[i]);
                    int pyzone = StartZoneConfigCategory.Instance.Get(unitzone).PhysicZone;
                    fenhaoTip += $"封角色:{pyzone}   {account}   {unitids[i]}";
                    List<DBAccountInfo> accoutResult = await Game.Scene.GetComponent<DBComponent>().Query<DBAccountInfo>(pyzone, _account => _account.Account == account);
                    if (accoutResult != null && accoutResult.Count > 0)
                    {
                        if (!accoutResult[0].BanUserList.Contains(unitids[i]))
                        {
                            accoutResult[0].BanUserList.Add(unitids[i]);
                            accoutResult[0].BanUserTime[unitids[i]] = serverNow;
                            
                            Game.Scene.GetComponent<DBComponent>().Save<DBAccountInfo>(pyzone, accoutResult[0]).Coroutine();
                        }
                    }
                    Console.WriteLine($"踢玩家下线: {account}  {unitids[i]}");
                    DisconnectHelper.KickPlayer(pyzone, unitids[i]).Coroutine();
                }
            }
            LogHelper.GongZuoShi(fenhaoTip);
#endif
        }

        //检测全服数据 + 封号   
        public static async ETTask GongZuoshi3_ConsoleHandler(string content)
        {
            Console.WriteLine($"request.Context:  AllOnLineConsoleHandler: {content}");
            await ETTask.CompletedTask;
            string[] chaxunInfo = content.Split(" ");
            if (chaxunInfo.Length != 2)
            {
                Console.WriteLine($"C must have allonline zone");
                Log.Warning($"C must have allonline zone");
                return;
            }

#if SERVER
            //1.游戏总时长超过180分钟
            //2.击败BOSS数量小于3
            //3.游戏内成就点数小于50点  改成游戏内成就点数小于100点 且 4个成就=0
            //4.手机登录
            //5.当前体力小于50
            //6.今日在线时间超过120分钟
            //7.主线任务完成不超过10个
            //8.拍卖行收益总共超过100万
            int zone = int.Parse(chaxunInfo[1]);
            List<int> zonlist = new List<int> { };
            if (zone == 0)
            {
                zonlist = ServerMessageHelper.GetAllZone();
            }
            else
            {
                zonlist.Add(zone);
            }

            long serverNow = TimeHelper.ServerNow();
            int curDate = ComHelp.GetDayByTime(serverNow);
            Dictionary<string, List<long>> accountNumber = new Dictionary<string, List<long>>();

            for (int i = 0; i < zonlist.Count; i++)
            {
                int pyzone = StartZoneConfigCategory.Instance.Get(zonlist[i]).PhysicZone;
                if (ComHelp.IsZhuBoZone(pyzone))
                {
                    continue;
                }

                long dbCacheId = DBHelper.GetDbCacheId(pyzone);
                long gateServerId = DBHelper.GetGateServerId(pyzone);

                string gongzuoshiInfo = $"{pyzone}区工作室全部玩家列表3： \n";
                List<UserInfoComponent> userinfoComponentList = await Game.Scene.GetComponent<DBComponent>().Query<UserInfoComponent>(pyzone, d => d.Id > 0);
                for (int userinfo = 0; userinfo < userinfoComponentList.Count; userinfo++)
                {
                    UserInfoComponent userInfoComponent = userinfoComponentList[userinfo];
                    if (userInfoComponent.UserInfo.RobotId != 0)
                    {
                        continue;
                    }
                    if (GMHelp.GmAccount.Contains(userInfoComponent.Account))
                    {
                        continue;
                    }


                    //击败boss>3返回
                    //击败boss>3返回
                    int killmonsterNumber = ComHelp.KillBoss_Lv_Number(userInfoComponent.UserInfo.MonsterRevives, userInfoComponent.UserInfo.Lv);
                    if (killmonsterNumber >= 3)
                    {
                        continue;
                    }

                    //当前体力>50返回
                    if (userInfoComponent.UserInfo.PiLao > 50)
                    {
                        continue;
                    }
                    //if (curDate != ComHelp.GetDayByTime(userInfoComponent.LastLoginTime))
                    //{
                    //    continue;
                    //}
                    //非手机登录返回
                    //if (string.IsNullOrEmpty(userInfoComponent.Account) || userInfoComponent.Account[0] != '1')
                    //{
                    //    continue;
                    //}

                    List<DataCollationComponent> dataCollations = await Game.Scene.GetComponent<DBComponent>().Query<DataCollationComponent>(pyzone, d => d.Id == userInfoComponent.Id);
                    if (dataCollations == null || dataCollations.Count == 0)
                    {
                        continue;
                    }
                    dataCollations[0].TodayOnLine = userInfoComponent.TodayOnLine;
                    //游戏总时长超过180分钟返回
                    //暂时不写

                    //今日在线时间超过120分钟返回
                    if (dataCollations[0].TodayOnLine < 120)
                    {
                        continue;
                    }
                    if (dataCollations[0].TotalOnLine < 200)
                    {
                        continue;
                    }

                    //拍卖行收益总小于100万返回
                    //if (dataCollations[0].GetCostByType(ItemGetWay.PaiMaiBuy) < 1000000)
                    //{
                    //    continue;
                    //}

                    List<ChengJiuComponent> chengJiuComponents = await Game.Scene.GetComponent<DBComponent>().Query<ChengJiuComponent>(pyzone, d => d.Id == userInfoComponent.Id);
                    if (chengJiuComponents == null || chengJiuComponents.Count == 0)
                    {
                        continue;
                    }

                    ////游戏内成就点数>50点返回
                    //if (chengJiuComponents[0].TotalChengJiuPoint > 50)
                    //{
                    //    continue;
                    //}
                    //3.游戏内成就4個擊殺boss都沒完成 10000002 - 10000005
                    if (chengJiuComponents[0].ChengJiuCompleteList.Contains(10000002)
                        || chengJiuComponents[0].ChengJiuCompleteList.Contains(10000003)
                        || chengJiuComponents[0].ChengJiuCompleteList.Contains(10000004)
                        || chengJiuComponents[0].ChengJiuCompleteList.Contains(10000005))
                    {
                        continue;
                    }

                    List<TaskComponent> taskComponents = await Game.Scene.GetComponent<DBComponent>().Query<TaskComponent>(pyzone, d => d.Id == userInfoComponent.Id);
                    if (taskComponents == null || taskComponents.Count == 0)
                    {
                        continue;
                    }

                    if (taskComponents[0].GetMainTaskNumber() > 10)
                    {
                        continue;
                    }

                    List<DBCenterAccountInfo> accoutResult = await Game.Scene.GetComponent<DBComponent>().Query<DBCenterAccountInfo>(202, _account => _account.Account == userInfoComponent.Account);
                    if (accoutResult == null || accoutResult.Count == 0)
                    {
                        continue;
                    }
                    if (accoutResult[0].AccountType == 2)
                    {
                        continue;
                    }

                    List<DBAccountInfo> accoutResult_2 = await Game.Scene.GetComponent<DBComponent>().Query<DBAccountInfo>(pyzone, _account => _account.Account == userInfoComponent.Account);
                    if (accoutResult_2 != null && accoutResult_2.Count > 0 && accoutResult_2[0].BanUserList!=null && accoutResult_2[0].BanUserList.Contains(userInfoComponent.Id))
                    {
                        continue;
                    }

                    string idcard = string.Empty;
                    if (accoutResult[0].PlayerInfo != null)
                    {
                        idcard = accoutResult[0].PlayerInfo.IdCardNo;
                    }

                    //等级 充值  活跃度 体力 当前金币   成就点数  当前主线任务
                    gongzuoshiInfo += $"账号: {userInfoComponent.Account}  \t名称：{userInfoComponent.UserInfo.Name}  \t等级:{userInfoComponent.UserInfo.Lv}   \t充值:{dataCollations[0].Recharge}" +
                            $"\t体力:{userInfoComponent.UserInfo.PiLao}  \t金币:{userInfoComponent.UserInfo.Gold}   \t成就值:{chengJiuComponents[0].TotalChengJiuPoint}   \t拍卖消耗:{dataCollations[0].GetCostByType(ItemGetWay.PaiMaiBuy)}" +
                            $"\t当前主线:{dataCollations[0].MainTask}  \t角色天数:{userInfoComponent.GetCrateDay()}  \t金币获取:{dataCollations[0].GoldGet}  \t金币消耗:{dataCollations[0].GoldCost} " +
                            $"\t金币获取总值:{dataCollations[0].GetGoldGetTotal()}  \t金币消耗总值:{dataCollations[0].GetGoldCostTotal()} 今日在线:{dataCollations[0].TodayOnLine}  \t击杀boos:{killmonsterNumber} \t设备:{dataCollations[0].GetDeviceID()}" +
                            $"\tIP:{userInfoComponent.RemoteAddress}  身份证:{idcard} \n";
                    

                    if (!accountNumber.ContainsKey(userInfoComponent.Account))
                    {
                        accountNumber.Add(userInfoComponent.Account, new List<long>());
                    }
                    accountNumber[userInfoComponent.Account].Add(userInfoComponent.Id);
                }

                LogHelper.GongZuoShi(gongzuoshiInfo);
            }

            string fenhaoTip = string.Empty;
            foreach ((string account, List<long> unitids) in accountNumber)
            {
                if (unitids.Count >= 3 && !account.Contains("testcn"))  //三次以上封账号封设备id
                {
                    fenhaoTip += ($"封号： {account}");
                    List<DBCenterAccountInfo> accoutResult = await Game.Scene.GetComponent<DBComponent>().Query<DBCenterAccountInfo>(202, _account => _account.Account == account);
                    if (accoutResult != null && accoutResult.Count > 0)
                    {
                        accoutResult[0].AccountType = 2;
                        accoutResult[0].BanTime = serverNow;
                        Game.Scene.GetComponent<DBComponent>().Save<DBCenterAccountInfo>(202, accoutResult[0]).Coroutine();
                    }
                    continue;
                }

                if (unitids.Count == 0)
                {
                    continue;
                }

                for (int i = 0; i < unitids.Count; i++)
                {
                    int unitzone = UnitIdStruct.GetUnitZone(unitids[i]);
                    int pyzone = StartZoneConfigCategory.Instance.Get(unitzone).PhysicZone;
                    fenhaoTip += $"封角色:{pyzone}   {account}   {unitids[i]}";
                    List<DBAccountInfo> accoutResult = await Game.Scene.GetComponent<DBComponent>().Query<DBAccountInfo>(pyzone, _account => _account.Account == account);
                    if (accoutResult != null && accoutResult.Count > 0)
                    {
                        if (!accoutResult[0].BanUserList.Contains(unitids[i]))
                        {
                            accoutResult[0].BanUserList.Add(unitids[i]);
                            accoutResult[0].BanUserTime[unitids[i]] = serverNow;
                            
                            Game.Scene.GetComponent<DBComponent>().Save<DBAccountInfo>(pyzone, accoutResult[0]).Coroutine();
                        }
                    }

                    DisconnectHelper.KickPlayer(pyzone, unitids[i]).Coroutine();
                }
            }
            LogHelper.GongZuoShi(fenhaoTip);
#endif
        }

        //封号-拍卖自己的玩家列表
        public static async ETTask GongZuoshi4_ConsoleHandler(string content)
        {
            Console.WriteLine($"request.Context:  GongZuoshi4_ConsoleHandler: {content}");
            await ETTask.CompletedTask;
            string[] chaxunInfo = content.Split(" ");
            if (chaxunInfo.Length != 3)
            {
                Console.WriteLine($"C must have allonline zone");
                Log.Warning($"C must have allonline zone");
                return;
            }

#if SERVER
            int zone = int.Parse(chaxunInfo[1]);
            //List<int> zonlist = new List<int> { };
            //if (zone == 0)
            //{
            //    zonlist = ServerMessageHelper.GetAllZone();
            //}
            //else
            //{
            //    zonlist.Add(zone);
            //}
            long unitId = long.Parse(chaxunInfo[2]);
            List<DataCollationComponent> dataCollationComponents = await Game.Scene.GetComponent<DBComponent>().Query<DataCollationComponent>(zone, d => d.Id == unitId);
            if (dataCollationComponents == null || dataCollationComponents.Count == 0)
            {
                Console.WriteLine($"查询为空:{content}");
                return;
            }

            long serverNow = TimeHelper.ServerNow();
            List<KeyValuePairLong> buyselflist = new List<KeyValuePairLong>() ; ;// dataCollationComponents[0].BuySelfPlayer;

            string gongzuoshiInfo = string.Empty;
            string allpaimaiInfo = string.Empty;    
            for ( int i = 0; i < buyselflist.Count; i++ )
            {
                // 1 手机登录
                // 2 角色等级大于10级，低于40级。
                // 3 成就任务<=2
                // 4 主线任务完成少于40
                // 5 充值低于30
                // 6 游戏总的在线时间大于180分钟
                long userid = buyselflist[i].KeyId;
                List<UserInfoComponent> userinfoComponentList = await Game.Scene.GetComponent<DBComponent>().Query<UserInfoComponent>(zone, d => d.Id  == userid);
                if (userinfoComponentList == null || userinfoComponentList.Count == 0)
                {
                    Console.WriteLine($"查询为空1:{userid}");
                    allpaimaiInfo += $" {userid}已删除  \n";
                    continue;
                }

                UserInfoComponent userInfoComponent = userinfoComponentList[0];
                if (userInfoComponent.UserInfo.RobotId != 0)
                {
                    continue;
                }
                if (GMHelp.GmAccount.Contains(userInfoComponent.Account))
                {
                    continue;
                }
                if(userInfoComponent.UserInfo.Lv > 40)
                {
                    Console.WriteLine($"查询为空2:{userid}");
                    allpaimaiInfo += $"{userInfoComponent.Account}  {userInfoComponent.UserInfo.Name}    等级>40  \n";
                    continue;
                }
                
                List<DataCollationComponent> dataCollations = await Game.Scene.GetComponent<DBComponent>().Query<DataCollationComponent>(zone, d => d.Id == userInfoComponent.Id);
                if (dataCollations == null || dataCollations.Count == 0)
                {
                    Console.WriteLine($"查询为空3:{userid}");
                    continue;
                }
                //游戏总时长超过180分钟返回
                //暂时不写
                //今日在线时间超过120分钟返回
               
                //if (dataCollations[0].TotalOnLine < 180)
                //{
                //    Console.WriteLine($"查询为空4:{userid}");
                //    allpaimaiInfo += $"{userInfoComponent.Account}  {userInfoComponent.UserInfo.Name}    TotalOnLine<180  \n";
                //    continue;
                //}

                //拍卖行收益总小于100万返回
                //if (dataCollations[0].GetCostByType(ItemGetWay.PaiMaiBuy) < 1000000)
                //{
                //    continue;
                //}

                List<ChengJiuComponent> chengJiuComponents = await Game.Scene.GetComponent<DBComponent>().Query<ChengJiuComponent>(zone, d => d.Id == userInfoComponent.Id);
                if (chengJiuComponents == null || chengJiuComponents.Count == 0)
                {
                    Console.WriteLine($"查询为空5:{userid}");
                    continue;
                }

                ////游戏内成就点数>50点返回
                //if (chengJiuComponents[0].TotalChengJiuPoint > 50)
                //{
                //    continue;
                //}
                //3.游戏内成就4個擊殺boss都沒完成 10000002 - 10000005
                int taskNumber = 0;
                if (chengJiuComponents[0].ChengJiuCompleteList.Contains(10000002))
                {
                    taskNumber++;
                }
                if (chengJiuComponents[0].ChengJiuCompleteList.Contains(10000003))
                {
                    taskNumber++;
                }  if (chengJiuComponents[0].ChengJiuCompleteList.Contains(10000004))
                {
                    taskNumber++;
                }
                if (chengJiuComponents[0].ChengJiuCompleteList.Contains(10000005))
                {
                    taskNumber++;
                }

                if (taskNumber > 2)
                {
                    Console.WriteLine($"查询为空6:{userid}");
                    allpaimaiInfo += $"{userInfoComponent.Account}  {userInfoComponent.UserInfo.Name}   taskNumber>2  \n";
                    continue;
                }

                List<TaskComponent> taskComponents = await Game.Scene.GetComponent<DBComponent>().Query<TaskComponent>(zone, d => d.Id == userInfoComponent.Id);
                if (taskComponents == null || taskComponents.Count == 0)
                {
                    Console.WriteLine($"查询为空7:{userid}");
                    continue;
                }

                if (taskComponents[0].GetMainTaskNumber() > 40)
                {
                    Console.WriteLine($"查询为空8:{userid}");
                    allpaimaiInfo += $"{userInfoComponent.Account}  {userInfoComponent.UserInfo.Name}   ainTask>40  \n";
                    continue;
                }

                List<DBCenterAccountInfo> accoutResult = await Game.Scene.GetComponent<DBComponent>().Query<DBCenterAccountInfo>(202, _account => _account.Account == userInfoComponent.Account);
                if (accoutResult == null || accoutResult.Count == 0)
                {
                    Console.WriteLine($"查询为空9:{userid}");
                    continue;
                }
                if (accoutResult[0].Account.Contains("testcn"))
                {
                    continue;
                }

                if (accoutResult[0].AccountType == 2 || accoutResult[0].GetTotalRecharge() > 30)
                {
                    Console.WriteLine($"查询为空10:{userid}");
                    allpaimaiInfo += $"{userInfoComponent.Account}  {userInfoComponent.UserInfo.Name}   已封号  \n";
                    continue;
                }

                //if (accoutResult[0].Password != "3" || accoutResult[0].Password != "4")
                //{
                //    continue;
                //}

                List<DBAccountInfo> accoutResult_2 = await Game.Scene.GetComponent<DBComponent>().Query<DBAccountInfo>(zone, _account => _account.Account == userInfoComponent.Account);
                if (accoutResult_2 != null && accoutResult_2.Count > 0 && accoutResult_2[0].BanUserList!=null && accoutResult_2[0].BanUserList.Contains(userInfoComponent.Id))
                {
                    Console.WriteLine($"查询为空11:{userid}");
                    continue;
                }

                gongzuoshiInfo += $"账号: {userInfoComponent.Account}  \t名称：{userInfoComponent.UserInfo.Name}  \t等级:{userInfoComponent.UserInfo.Lv}   \t充值:{dataCollations[0].Recharge}" +
                        $"\t体力:{userInfoComponent.UserInfo.PiLao}  \t金币:{userInfoComponent.UserInfo.Gold}   \t成就值:{chengJiuComponents[0].TotalChengJiuPoint}   \t拍卖消耗:{dataCollations[0].GetCostByType(ItemGetWay.PaiMaiBuy)}" +
                        $"\t当前主线:{dataCollations[0].MainTask}  \t角色天数:{userInfoComponent.GetCrateDay()}  \t金币获取:{dataCollations[0].GoldGet}  \t金币消耗:{dataCollations[0].GoldCost} " +
                        $"\t金币获取总值:{dataCollations[0].GetGoldGetTotal()}  \t金币消耗总值:{dataCollations[0].GetGoldCostTotal()} 今日在线:{dataCollations[0].TodayOnLine}  \t击杀boos:{taskNumber} \t设备:{dataCollations[0].GetDeviceID()}" +
                        $"\tIP:{userInfoComponent.RemoteAddress}  \n";
               
                if (accoutResult != null && accoutResult.Count > 0)
                {
                    accoutResult[0].AccountType = 2;
                    accoutResult[0].BanTime = serverNow;
                    Game.Scene.GetComponent<DBComponent>().Save<DBCenterAccountInfo>(202, accoutResult[0]).Coroutine();
                }
            }
            LogHelper.GongZuoShi($"列表: {allpaimaiInfo}");
            LogHelper.GongZuoShi($"封号: {gongzuoshiInfo}");
#endif
        }


        //检测所有被封的账号
        public static async ETTask GongZuoshi5_ConsoleHandler(string content)
        {
            await ETTask.CompletedTask;
#if SERVER


            string gongzuoshiInfo = string.Empty;

            List<DBCenterAccountInfo> accoutResult = await Game.Scene.GetComponent<DBComponent>().Query<DBCenterAccountInfo>(202, _account => _account.Id > 0);
            for ( int i = 0; i < accoutResult.Count; i++ )
            {
                if (accoutResult[i].AccountType != 2)
                {
                    continue;
                }

                string accout = accoutResult[i].Account;

                int maxLv = 0;
                int maxZone = 0;
                string maxName = string.Empty;


                List<int> zonlist = ServerMessageHelper.GetAllZone();
                for ( int zoneindex = 0; zoneindex < zonlist.Count; zoneindex++  )
                { 
                    int pyzoneid = zonlist[zoneindex]; 

                    List<DBAccountInfo> dBAccountInfos = await Game.Scene.GetComponent<DBComponent>().Query<DBAccountInfo>(pyzoneid, _account => _account.Account == accout);
                    if (dBAccountInfos == null || dBAccountInfos.Count == 0)
                    {
                        continue;
                    }

                    List<long> userlist = dBAccountInfos[0].UserList;
                   
                    for ( int userindex = 0; userindex < userlist.Count; userindex++ )
                    { 
                        long userid = userlist[userindex];   
                        List<UserInfoComponent> userInfoComponents  = await  Game.Scene.GetComponent<DBComponent>().Query<UserInfoComponent>(pyzoneid, d => d.Id == userid);
                        if (userInfoComponents == null || userInfoComponents.Count == 0)
                        {
                            continue;
                        }

                        if (userInfoComponents[0].UserInfo.Lv > maxLv)
                        {
                            maxLv = userInfoComponents[0].UserInfo.Lv;
                            maxName = userInfoComponents[0].UserInfo.Name;
                            maxZone = pyzoneid;
                        }
                    }
                }


                if (string.IsNullOrEmpty(maxName))
                {
                    continue;
                }

                gongzuoshiInfo += $"账号最大等级:{accout} \t区：{maxZone}  \t角色：{maxName}   \t:等级：{maxLv}  \n";
            }

            LogHelper.PaiMaiInfo(gongzuoshiInfo);
#endif

        }


        /// <summary>
        /// 通过ip和设备号查询
        /// </summary>
        /// <param name="content"></param>
        /// <returns></returns>
        public static async ETTask GongZuoshi6_ConsoleHandler(string content)
        {
            await ETTask.CompletedTask;
            string[] chaxunInfo = content.Split(" ");
            if (chaxunInfo[0] != "gongzuoshi6")
            {
                Console.WriteLine($"C must have gold zone");
                Log.Warning($"C must have gold zone");
                return;
            }
            if (chaxunInfo.Length != 3)
            {
                Console.WriteLine($"C must have gold zone");
                Log.Warning($"C must have gold zone");
                return;
            }
#if SERVER

            List<int> zonlist = ServerMessageHelper.GetAllZone();
            string chaxunip = chaxunInfo[1];
            string deviceid = chaxunInfo[2];

            string gongzuoshiInfo = "查询相同Ip和设备:   \n";

            for (int i = 0; i < zonlist.Count; i++)
            {
                int pyzone = StartZoneConfigCategory.Instance.Get(zonlist[i]).PhysicZone;

                long dbCacheId = DBHelper.GetDbCacheId(pyzone);

                List<UserInfoComponent> userinfoComponentList = await Game.Scene.GetComponent<DBComponent>().Query<UserInfoComponent>(pyzone, d => d.Id > 0);
                for (int userinfo = 0; userinfo < userinfoComponentList.Count; userinfo++)
                {
                    UserInfoComponent userInfoComponent = userinfoComponentList[userinfo];
                    if (userInfoComponent.UserInfo.RobotId != 0)
                    {
                        continue;
                    }
                    if (string.IsNullOrEmpty(userInfoComponent.RemoteAddress))
                    {
                        continue;
                    }

                    if (chaxunip!= "0" && !userInfoComponent.RemoteAddress.Contains(chaxunip))
                    {
                        continue;
                    }

                    List<DataCollationComponent> dataCollationComponents = await Game.Scene.GetComponent<DBComponent>().Query<DataCollationComponent>(pyzone, d => d.Id == userInfoComponent.Id);
                    if (dataCollationComponents == null || dataCollationComponents.Count == 0)
                    {
                        continue;
                    }

                    if (deviceid!= "0" &&  dataCollationComponents[0].DeviceID!= deviceid)
                    {
                        continue;
                    }

                    gongzuoshiInfo += $"区:{pyzone}   \t账号:{userInfoComponent.Account}  \t角色:{userInfoComponent.UserInfo.Name}  \n";
                }

            }
            LogHelper.GongZuoShi(gongzuoshiInfo);
#endif
        }


        /// <summary>
        /// 通过身份证号封号
        /// </summary>  gongzuoshi7 127&128
        /// <param name="content"></param>
        /// <param name="chaxun"></param>
        /// <returns></returns>
        public static async ETTask GongZuoshi7_ConsoleHandler(string content)
        {
            Console.WriteLine($"request.Context:  GongZuoshi4_ConsoleHandler: {content}");
            await ETTask.CompletedTask;
            string[] chaxunInfo = content.Split(" ");
            if (chaxunInfo.Length != 3)
            {
                Console.WriteLine($"C must have allonline zone");
                Log.Warning($"C must have allonline zone");
                return;
            }

#if SERVER
            int zone = int.Parse(chaxunInfo[1]);
            List<string> idcardList = chaxunInfo[2].Split('&').ToList();

            //List<int> zonlist = new List<int> { };
            //if (zone == 0)
            //{
            //    zonlist = ServerMessageHelper.GetAllZone();
            //}
            //else
            //{
            //    zonlist.Add(zone);
            //}
            long serverTime = TimeHelper.ServerNow();
            string tipInfo = string.Empty;
            List<DBCenterAccountInfo> accoutResult = await Game.Scene.GetComponent<DBComponent>().Query<DBCenterAccountInfo>(202, _account => _account.Id > 0);
            for(int i = 0; i < accoutResult.Count; i++)
            {
                if (accoutResult[i].Account.Contains("testcn"))
                {
                    continue;
                }
                if (accoutResult[i].AccountType == 2)
                {
                    continue;
                }
                if (accoutResult[i].PlayerInfo==null)
                {
                    continue;
                }
                if (!string.IsNullOrEmpty(accoutResult[i].PlayerInfo.IdCardNo) 
                    && idcardList.Contains(accoutResult[i].PlayerInfo.IdCardNo))
                {
                    accoutResult[i].AccountType = 2;
                    accoutResult[i].BanTime = serverTime;

                    tipInfo += $"封号: {accoutResult[i].Account} \n";
                    await Game.Scene.GetComponent<DBComponent>().Save<DBCenterAccountInfo>(202, accoutResult[i]);
                }
            }

            LogHelper.GongZuoShi(tipInfo);
#endif
        }


        //检测冒险家积分是否作弊
        public static async ETTask GongZuoshi8_ConsoleHandler(string content)
        {
            await ETTask.CompletedTask;
#if SERVER

            Dictionary<long, long> roleRecharge = new Dictionary<long, long>();

            List<DBCenterAccountInfo> accoutResult = await Game.Scene.GetComponent<DBComponent>().Query<DBCenterAccountInfo>(202, _account => _account.Id > 0);
            for (int i = 0; i < accoutResult.Count; i++)
            {
                if (accoutResult[i].AccountType == 2)
                {
                    continue;
                }
                if (accoutResult[i].PlayerInfo == null)
                {
                    continue;
                }

                List<RechargeInfo> rechargeInfoList = accoutResult[i].PlayerInfo.RechargeInfos;

                for (int recharge = 0; recharge < rechargeInfoList.Count; recharge++)
                {
                    RechargeInfo rechargeInfo = rechargeInfoList[recharge];

                    if (!roleRecharge.ContainsKey(rechargeInfo.UserId))
                    {
                        roleRecharge.Add(rechargeInfo.UserId,0);
                    }

                    roleRecharge[rechargeInfo.UserId] += rechargeInfo.Amount;
                }
            }

            List<int> zonlist = ServerMessageHelper.GetAllZone();

            string gongzuoshiInfo = "冒险家积分异常列表： \n";
            for (int zoneindex = 0; zoneindex < zonlist.Count; zoneindex++)
            {
                int pyzoneid = zonlist[zoneindex];

                List<NumericComponent> numericComponents = await Game.Scene.GetComponent<DBComponent>().Query<NumericComponent>(pyzoneid, _account => _account.Id > 0);
                for (int numIndex = 0; numIndex < numericComponents.Count; numIndex++)
                {
                    NumericComponent numericComponent = numericComponents[numIndex];
                    long rechargetNumber = 0;
                    roleRecharge.TryGetValue(numericComponent.Id, out rechargetNumber);

                    long rechargeExp = numericComponent.GetAsLong(NumericType.RechargeNumber);
                    long maoxianTotal = rechargeExp * 10 + numericComponent.GetAsLong(NumericType.MaoXianExp);

                    if ( rechargeExp > 1000 && rechargeExp > rechargetNumber * 2)
                    { 
                        
                        List<UserInfoComponent> userInfoComponents = await Game.Scene.GetComponent<DBComponent>().Query<UserInfoComponent>(pyzoneid, _account => _account.Id == numericComponent.Id);
                        if (userInfoComponents == null || userInfoComponents.Count == 0)
                        {
                            continue;
                        }

                      
                        //服务器名称  角色名称 等级  充值积分总数 充值记录总数  当前金币
                        gongzuoshiInfo += $"区:{pyzoneid}  \t角色名称:{userInfoComponents[0].UserName}  \t等级:{userInfoComponents[0].UserInfo.Lv}   \t充值积分总数:{maoxianTotal} \t充值记录总数:{rechargetNumber}  当前金币：{userInfoComponents[0].UserInfo.Gold}  \n";
                    }
                }
            }

            LogHelper.PaiMaiInfo(gongzuoshiInfo);
#endif

        }


        /// <summary>
        /// 通过ip实现封号功能  目前只封在线玩家
        /// </summary> gongzuoshi9 0 128&127
        /// <param name="content"></param>
        /// <returns></returns>
        public static async ETTask GongZuoshi9_ConsoleHandler(string content)
        {
            Console.WriteLine($"request.Context:  GongZuoshi9_ConsoleHandler: {content}");
            await ETTask.CompletedTask;
            string[] chaxunInfo = content.Split(" ");


            if (chaxunInfo.Length != 3)
            {
                Console.WriteLine($"C must have allonline zone");
                Log.Warning($"C must have allonline zone");
                return;
            }

#if SERVER
            List<int> zonlist = ServerMessageHelper.GetAllZone();
            List<string> idcardList = chaxunInfo[2].Split('&').ToList();
            List<long> accountIdlist = new List<long>();

            for (int i = 0; i < zonlist.Count; i++)
            {
                int pyzone = StartZoneConfigCategory.Instance.Get(zonlist[i]).PhysicZone;

                long dbCacheId = DBHelper.GetDbCacheId(pyzone);
                Console.WriteLine($"检测: {pyzone}  ");

                List <UserInfoComponent> userinfoComponentList = await Game.Scene.GetComponent<DBComponent>().Query<UserInfoComponent>(pyzone, d => d.Id > 0);
                for (int userinfo = 0; userinfo < userinfoComponentList.Count; userinfo++)
                {
                    UserInfoComponent userInfoComponent = userinfoComponentList[userinfo];
                    if (userInfoComponent.UserInfo.RobotId != 0)
                    {
                        continue;
                    }
                    if (string.IsNullOrEmpty(userInfoComponent.RemoteAddress))
                    {
                        continue;
                    }
                    //220.202.201.103:32361
                    string[] ipaddres = userInfoComponent.RemoteAddress.Split(':');
                    if (ipaddres.Length != 2 || string.IsNullOrEmpty(ipaddres[0]))
                    {
                        continue;
                    }
                    if (idcardList.Contains(ipaddres[0]) && !accountIdlist.Contains(userInfoComponent.UserInfo.AccInfoID))
                    {
                        accountIdlist.Add(userInfoComponent.UserInfo.AccInfoID);
                        Console.WriteLine($"封ip: {pyzone}  {userInfoComponent.UserInfo.AccInfoID}");
                    }
                }

            }

            string gongzuoshiInfo = "封号:   \n";
            long serverTime = TimeHelper.ServerNow();

            for (int i = 0; i < accountIdlist.Count; i++)
            {
                List<DBCenterAccountInfo> accoutResult = await Game.Scene.GetComponent<DBComponent>().Query<DBCenterAccountInfo>(202, _account => _account.Id == accountIdlist[i]);

                if(accoutResult ==null || accoutResult.Count  == 0) 
                {
                    continue;
                }
                if (accoutResult[0].Account.Contains("testcn"))
                {
                    continue;
                }
                if (accoutResult[0].AccountType == 2)
                {
                    continue;
                }
                if (accoutResult[0].PlayerInfo == null)
                {
                    continue;
                }

                accoutResult[0].AccountType = 2;
                accoutResult[0].BanTime = serverTime;

                gongzuoshiInfo += $"封号: {accoutResult[0].Account} \n";

                await Game.Scene.GetComponent<DBComponent>().Save<DBCenterAccountInfo>(202, accoutResult[0]);
            }

            LogHelper.GongZuoShi(gongzuoshiInfo);
#endif 
        }


        //shenshou 0
        public static async ETTask ShenshouConsoleHandler(string content)
        {
            Console.WriteLine($"request.Context:  ShenshouConsoleHandler: {content}");
            await ETTask.CompletedTask;
            string[] chaxunInfo = content.Split(" ");

            if (chaxunInfo.Length != 2)
            {
                Console.WriteLine($"C must have shenshou zone");
                Log.Warning($"C must have shenshou zone");
                return;
            }

#if SERVER
            int zone = int.Parse(chaxunInfo[1]);
            List<int> zonlist = new List<int> { };
            if (zone == 0)
            {
                zonlist = ServerMessageHelper.GetAllZone();
            }
            else
            {
                zonlist.Add(zone);
            }

            string levelInfo = string.Empty;

            for (int i = 0; i < zonlist.Count; i++)
            {
                int pyzone = StartZoneConfigCategory.Instance.Get(zonlist[i]).PhysicZone;

                long dbCacheId = DBHelper.GetDbCacheId(pyzone);
                List<PetComponent> petComponents = await Game.Scene.GetComponent<DBComponent>().Query<PetComponent>(pyzone, d => d.Id > 0);
                if (petComponents.Count == 0 || petComponents == null)
                {
                    continue;
                }

                for ( int pet = 0; pet < petComponents.Count; pet++ )
                {
                    PetComponent petComponent = petComponents[pet]; 
                    int shenshouNumber = petComponent.GetShenShouNumber();
                    if (shenshouNumber <= 0)
                    {
                        continue;
                    }

                    List<UserInfoComponent> userinfoComponents = await Game.Scene.GetComponent<DBComponent>().Query<UserInfoComponent>(pyzone, d => d.Id == petComponent.Id);
                    if (userinfoComponents.Count == 0 || userinfoComponents == null)
                    {
                        continue;
                    }
                    UserInfoComponent userInfoComponent = userinfoComponents[0];

                    //List<DBCenterAccountInfo> accoutResult = await Game.Scene.GetComponent<DBComponent>().Query<DBCenterAccountInfo>(202, _account => _account.Account == userInfoComponent.Account);
                    //if (accoutResult == null || accoutResult.Count == 0)
                    //{
                    //    continue;
                    //}
                    //if (accoutResult[0].AccountType == 2)
                    //{
                    //    continue;
                    //}

                    List<NumericComponent> NumericComponentlist = await Game.Scene.GetComponent<DBComponent>().Query<NumericComponent>(pyzone, d => d.Id == petComponent.Id);
                    if (NumericComponentlist == null || NumericComponentlist.Count == 0)
                    {
                        continue;
                    }
                    int recharge = NumericComponentlist[0].GetAsInt(NumericType.RechargeNumber);

                    levelInfo = levelInfo + $"区:{pyzone}   \t账号：{userInfoComponent.Account}  \t玩家:{userInfoComponent.UserInfo.Name}  \t神兽数量:{shenshouNumber}   \t等级:{userInfoComponent.UserInfo.Lv} \t钻石:{userInfoComponent.UserInfo.Diamond}  \t充值:{recharge} \n";

                }

            }


            LogHelper.GongZuoShi(levelInfo);
#endif
        }

            //gold  diamond
            public static async ETTask GoldConsoleHandler(string content, string chaxun)
        {
            Console.WriteLine($"request.Context:  GoldConsoleHandler: {content}");
            await ETTask.CompletedTask;
            string[] chaxunInfo = content.Split(" ");
            if (chaxunInfo[0] != chaxun)
            {
                Console.WriteLine($"C must have gold zone");
                Log.Warning($"C must have gold zone");
                return;
            }
            if (chaxunInfo.Length != 3)
            {
                Console.WriteLine($"C must have gold zone");
                Log.Warning($"C must have gold zone");
                return;
            }
#if SERVER
            int zone = int.Parse(chaxunInfo[1]);
            List<int> zonlist = new List<int> { };
            if (zone == 0)
            {
                zonlist = ServerMessageHelper.GetAllZone();
            }
            else
            {
                zonlist.Add(zone);
            }
            long maxGold = long.Parse(chaxunInfo[2]);
            for (int i = 0; i < zonlist.Count; i++)
            {
                int pyzone = StartZoneConfigCategory.Instance.Get(zonlist[i]).PhysicZone;

                long dbCacheId = DBHelper.GetDbCacheId(pyzone);

                string levelInfo = $"{pyzone}区玩家{chaxun}>{maxGold}列表： \n";
                List<UserInfoComponent> userinfoComponentList = await Game.Scene.GetComponent<DBComponent>().Query<UserInfoComponent>(pyzone, d => d.Id > 0);
                for (int userinfo = 0; userinfo < userinfoComponentList.Count; userinfo++)
                {
                    UserInfoComponent userInfoComponent = userinfoComponentList[userinfo];
                    if (userInfoComponent.UserInfo.RobotId != 0 )
                    {
                        continue;
                    }
                    //if (userInfoComponent.UserInfo.Lv > 40)
                    //{
                    //    continue;
                    //}

                    if (GMHelp.GmAccount.Contains(userInfoComponent.Account))
                    {
                        continue;
                    }

                    if (chaxun == "gold")
                    {
                        long baggold = userInfoComponent.UserInfo.Gold;
                        long mailgold = 0;
                        List<DBMailInfo> dBMailInfolist = await Game.Scene.GetComponent<DBComponent>().Query<DBMailInfo>(pyzone, d => d.Id == userInfoComponent.Id);
                        if (dBMailInfolist == null || dBMailInfolist.Count == 0)
                        {
                            continue;
                        }
                        DBMailInfo dBMailInfo = dBMailInfolist[0];
                        for (int mail = 0; mail < dBMailInfo.MailInfoList.Count; mail++)
                        {
                            MailInfo mailInfo = dBMailInfo.MailInfoList[mail];  

                            if (mailInfo.ItemList.Count <1)
                            {
                                continue;
                            }
                            if (mailInfo.ItemList[0].ItemID == 1)
                            {
                                mailgold += mailInfo.ItemList[0].ItemNum;
                            }
                        }

                        if (baggold + mailgold < maxGold)
                        {
                            continue;
                        }

                        List<NumericComponent> NumericComponentlist = await Game.Scene.GetComponent<DBComponent>().Query<NumericComponent>(pyzone, d => d.Id == userInfoComponent.Id);
                        if (NumericComponentlist == null || NumericComponentlist.Count == 0)
                        {
                            continue;
                        }

                        List<DBCenterAccountInfo> accoutResult = await Game.Scene.GetComponent<DBComponent>().Query<DBCenterAccountInfo>(202, _account => _account.Account == userInfoComponent.Account);
                        if (accoutResult == null || accoutResult.Count == 0)
                        {
                            continue;
                        }
                        if (accoutResult[0].AccountType == 2)
                        {
                            continue;
                        }

                        int recharge = NumericComponentlist[0].GetAsInt(NumericType.RechargeNumber);
                        //if (recharge > 200)
                        //{ 
                        //    continue; 
                        //}
                      
                        levelInfo = levelInfo + $"区:{pyzone}   账号：{userInfoComponent.Account}  \t玩家:{userInfoComponent.UserInfo.Name}  \t等级:{userInfoComponent.UserInfo.Lv}  \t金币:{baggold}   \t:邮箱金币:{mailgold}  \t充值:{recharge} \n";
                    }
                    if (chaxun == "diamond")
                    {
                        if (userInfoComponent.UserInfo.Diamond < maxGold)
                        {
                            continue;
                        }

                        List<DBCenterAccountInfo> accoutResult = await Game.Scene.GetComponent<DBComponent>().Query<DBCenterAccountInfo>(202, _account => _account.Account == userInfoComponent.Account);
                        if (accoutResult == null || accoutResult.Count == 0)
                        {
                            continue;
                        }
                        if (accoutResult[0].AccountType == 2)
                        {
                            continue;
                        }

                        List<NumericComponent> NumericComponentlist = await Game.Scene.GetComponent<DBComponent>().Query<NumericComponent>(pyzone, d => d.Id == userInfoComponent.Id);
                        if (NumericComponentlist == null || NumericComponentlist.Count == 0)
                        {
                            continue;
                        }
                        int recharge = NumericComponentlist[0].GetAsInt(NumericType.RechargeNumber);

                        levelInfo = levelInfo + $"区:{pyzone}   账号：{userInfoComponent.Account} 玩家:{userInfoComponent.UserInfo.Name} 等级:{userInfoComponent.UserInfo.Lv} 钻石:{userInfoComponent.UserInfo.Diamond} 充值:{recharge} \n";
                    }
                }

                LogHelper.GongZuoShi(levelInfo);
            }
#endif
        }

        public static async ETTask LevelConsoleHandler(string content)
        {
            await ETTask.CompletedTask;
            string[] chaxunInfo = content.Split(" ");
            if (chaxunInfo[0] != "level")
            {
                Log.Console($"C must have level zone");
                Log.Warning($"C must have level zone");
                return;
            }
            if (chaxunInfo.Length != 2)
            {
                Log.Console($"C must have level zone");
                Log.Warning($"C must have level zone");
                return;
            }
#if SERVER
            int zone = int.Parse(chaxunInfo[1]);
            List<int> zonlist = new List<int> { };
            if (zone == 0)
            {
                zonlist = ServerMessageHelper.GetAllZone();
            }
            else
            {
                zonlist.Add(zone);
            }

            for (int i = 0; i < zonlist.Count; i++)
            {
                int pyzone = StartZoneConfigCategory.Instance.Get(zonlist[i]).PhysicZone;

                long dbCacheId = DBHelper.GetDbCacheId(pyzone);

                Dictionary<int, int> levelPlayerCount = new Dictionary<int, int>();

                List<UserInfoComponent> userinfoComponentList = await Game.Scene.GetComponent<DBComponent>().Query<UserInfoComponent>(pyzone, d => d.Id > 0);
                for (int userinfo = 0; userinfo < userinfoComponentList.Count; userinfo++)
                {
                    UserInfoComponent userInfoComponent = userinfoComponentList[userinfo];
                    if (userInfoComponent.UserInfo.RobotId != 0)
                    {
                        continue;
                    }

                    if (!levelPlayerCount.ContainsKey(userInfoComponent.UserInfo.Lv))
                    {
                        levelPlayerCount.Add(userInfoComponent.UserInfo.Lv, 1);
                    }
                    else
                    {
                        levelPlayerCount[userInfoComponent.UserInfo.Lv]++;
                    }

                }

                string levelInfo = $"{pyzone}区玩家等级列表： \n";
                for (int level = 1; level <= 65; level++)
                {
                    int levelnumber = 0;
                    levelPlayerCount.TryGetValue(level, out levelnumber);
                    levelInfo = levelInfo + $"等级:{level}  人数:{levelnumber}  \n";
                }

                LogHelper.LogWarning(levelInfo, true);
            }
#endif
        }

        public static void KickOutConsoleHandler(string content)
        {
            //kickout 1    1
            string[] chaxunInfo = content.Split(" ");
            if (chaxunInfo[0] != "kickout")
            {
                return;
            }
#if SERVER
            int zone = int.Parse(chaxunInfo[1]);
            int pyzone = StartZoneConfigCategory.Instance.Get(zone).PhysicZone;
            long unitid = long.Parse(chaxunInfo[2]);

            DisconnectHelper.KickPlayer(pyzone, unitid).Coroutine();
#endif
        }

        public static async ETTask CombatConsoleHandler(string content)
        {
            await ETTask.CompletedTask;
            string[] ss = content.Split(" ");
            string zoneid = ss[1];
#if SERVER
            List<int> zoneList = ServerMessageHelper.GetAllZone();
            for (int i = 0; i < zoneList.Count; i++)
            {
                long rankServerId = StartSceneConfigCategory.Instance.GetBySceneName(zoneList[i], "Rank").InstanceId;
                await ServerMessageHelper.SendServerMessage(rankServerId, NoticeType.RankRefresh, String.Empty);
                await TimerComponent.Instance.WaitAsync(10000);
            }
#endif
        }
        
        public static async ETTask<string> ChaXunConsoleHandler(string content)
        {
            await ETTask.CompletedTask;
            //chaxun 1 ""
            string[] chaxunInfo = content.Split(" ");
            if (chaxunInfo[0] != "chaxun")
            {
                return string.Empty;
            }

#if SERVER
            int zone = int.Parse(chaxunInfo[1]);
            int pyzone = StartZoneConfigCategory.Instance.Get(zone).PhysicZone;
            long dbCacheId = DBHelper.GetDbCacheId(pyzone);

            //查询全区金币异常
            if (chaxunInfo.Length == 2)
            {
                List<UserInfoComponent> userinfoComponentList = await Game.Scene.GetComponent<DBComponent>().Query<UserInfoComponent>(pyzone, d => d.Id > 0);
                for (int i = 0; i < userinfoComponentList.Count; i++)
                {
                    UserInfoComponent userInfoComponent = userinfoComponentList[i];
                    if (userInfoComponent.UserInfo.RobotId != 0)
                    {
                        continue;
                    }
                    long gold = userInfoComponent.UserInfo.Gold;
                    long diamond = userInfoComponent.UserInfo.Diamond;

                    if (gold > 1000000 || diamond > 10000)
                    {
                        long unitId = userinfoComponentList[0].Id;

                        List<BagComponent> baginfoInfoList = await Game.Scene.GetComponent<DBComponent>().Query<BagComponent>(pyzone, d => d.Id == unitId);

                        int occ = userInfoComponent.UserInfo.Occ;
                        int occTwo = userInfoComponent.UserInfo.OccTwo;

                        List<BagInfo> bagInfosAll = baginfoInfoList[0].GetAllItems(occ, occTwo);

                        string infolist = $"{userInfoComponent.UserInfo.Name}:  \n";
                        infolist = infolist + $"金币： {gold} \n";
                        infolist = infolist + $"钻石： {diamond} \n";

                        for (int b = 0; b < bagInfosAll.Count; b++)
                        {
                            infolist = infolist + $"{bagInfosAll[b].ItemID};{bagInfosAll[b].ItemNum}\n";
                        }
                        LogHelper.LogWarning(infolist);
                    }
                }
            }

            //查询单个玩家
            if (chaxunInfo.Length == 3)
            {
                LogHelper.LogDebug($"name: {chaxunInfo[2]}");
                List<UserInfoComponent> userinfoComponentList = await Game.Scene.GetComponent<DBComponent>().Query<UserInfoComponent>(pyzone, d => d.Id > 0 && d.UserInfo.Name == chaxunInfo[2]);
                if (userinfoComponentList.Count == 0)
                {
                    return string.Empty;
                }
                long unitId = userinfoComponentList[0].Id;
                IActorResponse reqEnter = (M2G_RequestEnterGameState)await MessageHelper.CallLocationActor(unitId, new G2M_RequestEnterGameState()
                {
                    GateSessionActorId = -1
                });
                if (reqEnter.Error != ErrorCode.ERR_Success)
                {
                    Console.WriteLine("玩家不在线！");
                    return "玩家不在线！";
                }
                else
                {
                    Console.WriteLine(reqEnter.Message);
                    return reqEnter.Message;
                }
            }

#endif
            return string.Empty;
        }

        public static async ETTask<int> ReloadDllConsoleHandler(string content)
        {
            await ETTask.CompletedTask;
            string[] ss = content.Split(" ");

            if (ss.Length != 3)
            {
                return ErrorCode.ERR_Parameter;
            }

            int loadType = int.Parse(ss[1]);
            string LoadValue = ss[2];
#if SERVER
            //Game.EventSystem.Add(DllHelper.GetHotfixAssembly());
            //Game.EventSystem.Load();

            List<StartProcessConfig> listprogress = StartProcessConfigCategory.Instance.GetAll().Values.ToList();
            Log.Console("C2M_Reload_a: listprogress " + listprogress.Count);
            Log.Warning("C2M_Reload_a: listprogress " + listprogress.Count);
            for (int i = 0; i < listprogress.Count; i++)
            {
                List<StartSceneConfig> processScenes = StartSceneConfigCategory.Instance.GetByProcess(listprogress[i].Id);
                if (processScenes.Count == 0)  // || listprogress[i].Id == 203)
                {
                    continue;
                }

                StartSceneConfig startSceneConfig = processScenes[0];
                Log.Console("C2M_Reload_a: processScenes " + startSceneConfig);
                Log.Warning("C2M_Reload_a: processScenes " + startSceneConfig);
                try
                {
                    long mapInstanceId = StartSceneConfigCategory.Instance.GetBySceneName(startSceneConfig.Zone, startSceneConfig.Name).InstanceId;
                    A2G_Reload createUnit = (A2G_Reload)await ActorMessageSenderComponent.Instance.Call(
                        mapInstanceId, new G2A_Reload() { LoadType = loadType, LoadValue = LoadValue });

                    if (createUnit.Error != ErrorCode.ERR_Success)
                    {
                        Log.Console("C2M_Reload_a: error " + startSceneConfig);
                        Log.Warning("C2M_Reload_a: error " + startSceneConfig);
                    }
                }
                catch (Exception ex)
                {
                    Log.Error(ex);
                }
            }
#endif
            return ErrorCode.ERR_Success;
        }

        /// <summary>
        /// 服务器黑名单. 全服有大于40级的不封号
        /// </summary>
        /// <param name="content"></param>
        /// <returns></returns>
        public static async ETTask<int> BlackConsoleHandler(string content)
        {
            await ETTask.CompletedTask;
#if SERVER
            string[] chaxunInfo = content.Split(" ");
            int zone = int.Parse(chaxunInfo[1]);
            int pyzone = StartZoneConfigCategory.Instance.Get(zone).PhysicZone;
            string userName = chaxunInfo[2];  //角色名或者账号
            List<UserInfoComponent> accountInfoList = await Game.Scene.GetComponent<DBComponent>().Query<UserInfoComponent>(pyzone, d => d.UserInfo.Name == userName || d.Account == userName);
            if (accountInfoList == null || accountInfoList.Count == 0)
            {
                return ErrorCode.ERR_NotFindAccount;
            }

            List<DBCenterAccountInfo> accoutResult = await Game.Scene.GetComponent<DBComponent>().Query<DBCenterAccountInfo>(202, _account => _account.Id == accountInfoList[0].UserInfo.AccInfoID);
            if (accoutResult == null || accoutResult.Count == 0)
            {
                return ErrorCode.ERR_NotFindAccount;
            }
            if (accoutResult[0].AccountType == 2)
            {
                return ErrorCode.ERR_NotFindAccount;
            }
            if (accoutResult[0].Account.Contains("testcn"))
            {
                return ErrorCode.ERR_NotFindAccount;
            }

            string accout = accountInfoList[0].Account;
            List<int> zonlist = ServerMessageHelper.GetAllZone();
            for (int zoneindex = 0; zoneindex < zonlist.Count; zoneindex++)
            {
                int pyzoneid = zonlist[zoneindex];

                List<DBAccountInfo> dBAccountInfos = await Game.Scene.GetComponent<DBComponent>().Query<DBAccountInfo>(pyzoneid, _account => _account.Account == accout);
                if (dBAccountInfos == null || dBAccountInfos.Count == 0)
                {
                    continue;
                }

                List<long> userlist = dBAccountInfos[0].UserList;

                for (int userindex = 0; userindex < userlist.Count; userindex++)
                {
                    long userid = userlist[userindex];
                    List<UserInfoComponent> userInfoComponents = await Game.Scene.GetComponent<DBComponent>().Query<UserInfoComponent>(pyzoneid, d => d.Id == userid);
                    if (userInfoComponents == null || userInfoComponents.Count == 0)
                    {
                        continue;
                    }

                    if (userInfoComponents[0].UserInfo.Lv > 40)
                    {
                       return ErrorCode.ERR_Success;
                    }
                }
            }


            accoutResult[0].AccountType = 2;
            accoutResult[0].BanTime = TimeHelper.ServerNow();
            Game.Scene.GetComponent<DBComponent>().Save<DBCenterAccountInfo>(202, accoutResult[0]).Coroutine();
#endif
            return ErrorCode.ERR_Success;
        }


        /// <summary>
        /// 服务器黑名单. 全服有大于40级的不封号
        /// </summary>  black2 tcg 10
        /// <param name="content"></param>
        /// <returns></returns>
        public static async ETTask<int> Black2_ConsoleHandler(string content)
        {
            await ETTask.CompletedTask;
#if SERVER
            string[] chaxunInfo = content.Split(" ");
            if (chaxunInfo.Length != 3)
            {
                Console.WriteLine($"Error: {content}");
                return ErrorCode.ERR_NetWorkError;
            }

            string accout = chaxunInfo[1];  //者账号
            int lelimit = int.Parse(chaxunInfo[2]);
            
            List<DBCenterAccountInfo> accoutResult = await Game.Scene.GetComponent<DBComponent>().Query<DBCenterAccountInfo>(202, _account => _account.Account == accout);
            if (accoutResult == null || accoutResult.Count == 0)
            {
                return ErrorCode.ERR_NotFindAccount;
            }
            if (accoutResult[0].AccountType == 2)
            {
                return ErrorCode.ERR_NotFindAccount;
            }
            if (accoutResult[0].Account.Contains("testcn"))
            {
                return ErrorCode.ERR_NotFindAccount;
            }

            List<int> zonlist = ServerMessageHelper.GetAllZone();
            for (int zoneindex = 0; zoneindex < zonlist.Count; zoneindex++)
            {
                int pyzoneid = zonlist[zoneindex];

                List<DBAccountInfo> dBAccountInfos = await Game.Scene.GetComponent<DBComponent>().Query<DBAccountInfo>(pyzoneid, _account => _account.Account == accout);
                if (dBAccountInfos == null || dBAccountInfos.Count == 0)
                {
                    continue;
                }

                List<long> userlist = dBAccountInfos[0].UserList;

                for (int userindex = 0; userindex < userlist.Count; userindex++)
                {
                    long userid = userlist[userindex];
                    List<UserInfoComponent> userInfoComponents = await Game.Scene.GetComponent<DBComponent>().Query<UserInfoComponent>(pyzoneid, d => d.Id == userid);
                    if (userInfoComponents == null || userInfoComponents.Count == 0)
                    {
                        continue;
                    }

                    if (userInfoComponents[0].UserInfo.Lv > lelimit)
                    {
                        return ErrorCode.ERR_Success;
                    }
                }
            }

            accoutResult[0].AccountType = 2;
            accoutResult[0].BanTime = TimeHelper.ServerNow();
            Game.Scene.GetComponent<DBComponent>().Save<DBCenterAccountInfo>(202, accoutResult[0]).Coroutine();
#endif
            return ErrorCode.ERR_Success;
        }

        public static async ETTask<int> MailConsoleHandler(string content)
        {
            await ETTask.CompletedTask;
            //mail 区服(0所有区服  1指定区服)  玩家ID(0所有玩家)  道具 邮件类型 参数 管理员
            //mail 0 0 1;1 2 “6” tt
            string[] mailInfo = content.Split(" ");
            if (mailInfo[0] != "mail" && mailInfo.Length < 6)
            {
                Log.Console("邮件发送失败！");
                Log.Warning("邮件发送失败！");
                return ErrorCode.ERR_Parameter;
            }
            try
            {
                int mailtype = int.Parse(mailInfo[4]);
            }
            catch (Exception ex)
            {
                Log.Console("邮件发送失败！" + ex.ToString());
                Log.Warning("邮件发送失败！" + ex.ToString());
                return ErrorCode.ERR_Parameter;
            }

#if SERVER
            //全服邮件
            if (mailInfo[1] == "0")
            {
                if (mailInfo.Length < 7 && mailInfo[6] != DllHelper.Admin)
                {
                    Log.Console("发送全服邮件0！");
                    return ErrorCode.ERR_Parameter;
                }
                Log.Console("发送全服邮件1！");
            }
            List<int> zoneList = new List<int> { };
            if (mailInfo[1] == "0")
            {
                zoneList = ServerMessageHelper.GetAllZone();
            }
            else
            {
                zoneList.Add(int.Parse(mailInfo[1]));
            }

            for (int i = 0; i < zoneList.Count; i++)
            {
                try
                {
                    int pyzone = StartZoneConfigCategory.Instance.Get(zoneList[i]).PhysicZone;
                    Console.WriteLine($"邮件； {zoneList[i]} {pyzone} {content}");
                    long gateServerId = StartSceneConfigCategory.Instance.GetBySceneName(pyzone, "EMail").InstanceId;
                    E2M_GMEMailSendResponse g2M_UpdateUnitResponse = (E2M_GMEMailSendResponse)await ActorMessageSenderComponent.Instance.Call
                        (gateServerId, new M2E_GMEMailSendRequest()
                        {
                            UserName = mailInfo[2],
                            Itemlist = mailInfo[3],
                            Title = mailInfo[5],
                            ActorId = zoneList[i],
                            MailType = int.Parse(mailInfo[4]),
                        });
                    if (g2M_UpdateUnitResponse.Error == ErrorCode.ERR_Success)
                    {
                        Log.Console($"邮件发送成功！：{pyzone}区");
                    }
                    else
                    {
                        Log.Console($"邮件发送失败！：{pyzone}区：" + g2M_UpdateUnitResponse.Message);
                    }
                }
                catch (Exception ex)
                {
                    Log.Console("邮件发送异常！： " + ex.ToString());
                }
            }
#endif

            return ErrorCode.ERR_Success;
        }

        public static async ETTask<int> Mail2ConsoleHandler(string content)
        {
            await ETTask.CompletedTask;
            //mail 区服(0所有区服  1指定区服)  玩家ID(0所有玩家)  道具 邮件类型 参数 管理员
            //mail 0 0 1;1 2 “6” tt
            string[] mailInfo = content.Split(" ");
            if (mailInfo[0] != "mail" && mailInfo.Length < 6)
            {
                Log.Console("邮件发送失败！");
                Log.Warning("邮件发送失败！");
                return ErrorCode.ERR_Parameter;
            }
            try
            {
                int mailtype = int.Parse(mailInfo[4]);
            }
            catch (Exception ex)
            {
                Log.Console("邮件发送失败！" + ex.ToString());
                Log.Warning("邮件发送失败！" + ex.ToString());
                return ErrorCode.ERR_Parameter;
            }

#if SERVER
            //全服邮件
            if (mailInfo[1] == "0")
            {
                if (mailInfo.Length < 7 && mailInfo[6] != DllHelper.Admin)
                {
                    Log.Console("发送全服邮件0！");
                    return ErrorCode.ERR_Parameter;
                }
                Log.Console("发送全服邮件1！");
            }
            List<int> zoneList = new List<int> { };
            if (mailInfo[1] == "0")
            {
                zoneList = ServerMessageHelper.GetAllZone();
            }
            else
            {
                zoneList.Add(int.Parse(mailInfo[1]));
            }

            for (int i = 0; i < zoneList.Count; i++)
            {
                try
                {
                    int pyzone = StartZoneConfigCategory.Instance.Get(zoneList[i]).PhysicZone;
                    long gateServerId = StartSceneConfigCategory.Instance.GetBySceneName(pyzone, "EMail").InstanceId;
                    E2M_GMEMailSendResponse g2M_UpdateUnitResponse = (E2M_GMEMailSendResponse)await ActorMessageSenderComponent.Instance.Call
                        (gateServerId, new M2E_GMEMailSendRequest()
                        {
                            UserName = mailInfo[2],
                            Itemlist = mailInfo[3],
                            Title = mailInfo[5],
                            ActorId = zoneList[i],
                            MailType = int.Parse(mailInfo[4]),
                        });
                    if (g2M_UpdateUnitResponse.Error == ErrorCode.ERR_Success)
                    {
                        Log.Console($"邮件发送成功！：{pyzone}区");
                    }
                    else
                    {
                        Log.Console($"邮件发送失败！：{pyzone}区：" + g2M_UpdateUnitResponse.Message);
                    }
                }
                catch (Exception ex)
                {
                    Log.Console("邮件发送异常！： " + ex.ToString());
                }
            }
#endif

            return ErrorCode.ERR_Success;
        }
    }
}
