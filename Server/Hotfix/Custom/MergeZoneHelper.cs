using SharpCompress.Common;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ET
{

    //合区
    public static class MergeZoneHelper
    {


        public static async ETTask QueryTodayAccount()
        {
            var startZoneConfig = StartZoneConfigCategory.Instance.Get(202);
            Game.Scene.GetComponent<DBComponent>().InitDatabase(startZoneConfig);

            long serverNow = TimeHelper.ServerNow();
            int todayNumber = ComHelp.GetDayByTime(serverNow);  
            string tipinfo = string.Empty;  
            List<DBCenterAccountInfo> dBAccountInfos_new = await Game.Scene.GetComponent<DBComponent>().Query<DBCenterAccountInfo>(202, d => d.Id > 0);
            foreach (var entity in dBAccountInfos_new)
            {
                if (entity.CreateTime == 0)
                {
                    continue;
                }

                int accountDay = ComHelp.GetDayByTime(entity.CreateTime);
                if (todayNumber!= accountDay)
                {
                    continue;
                }

                if(entity.Password!="3" && entity.Password != "4")
                {
                    continue;

                }

                string head = entity.Account.Substring(0, 3);
                if (head == "170" || head == "171" || head == "162" || head == "165" || head == "167" || head == "192")
                {
                    tipinfo += $"{entity.Account} \n";
                }
            }

            LogHelper.PaiMaiInfo(tipinfo);
        }


        public static async ETTask QueryTaptapAccount()
        {
            var startZoneConfig = StartZoneConfigCategory.Instance.Get(202);
            Game.Scene.GetComponent<DBComponent>().InitDatabase(startZoneConfig);

            long serverNow = TimeHelper.ServerNow();
            int todayNumber = ComHelp.GetDayByTime(serverNow);
            string tipinfo = string.Empty;
            List<DBCenterAccountInfo> dBAccountInfos_new = await Game.Scene.GetComponent<DBComponent>().Query<DBCenterAccountInfo>(202, d => d.Id > 0);
          
            Dictionary<int, long> DayCreateNumber = new Dictionary<int, long>();    
            
            foreach (var entity in dBAccountInfos_new)
            {
                if (entity.CreateTime == 0)
                {
                    continue;
                }

                int accountDay = ComHelp.GetDayByTime(entity.CreateTime);
               
                if (entity.Password != "6" )
                {
                    continue;

                }

                if(!DayCreateNumber.ContainsKey(accountDay))
                {
                    DayCreateNumber.Add(accountDay, 0);
                }

                DayCreateNumber[accountDay]++;
            }

            var sortedDictionary = DayCreateNumber.OrderBy(kvp => kvp.Key).ToDictionary(kvp => kvp.Key, kvp => kvp.Value);

            foreach (var item in sortedDictionary)
            {
                tipinfo += $"{item.Key}    {item.Value} \n";
            }

            LogHelper.PaiMaiInfo(tipinfo);
        }

        public static async ETTask QueryRecharge()
        {
            int number_1 = 0;
            int number_2 = 0;
            var startZoneConfig = StartZoneConfigCategory.Instance.Get(202);
            Game.Scene.GetComponent<DBComponent>().InitDatabase(startZoneConfig);
            List<DBCenterAccountInfo> dBAccountInfos_new = await Game.Scene.GetComponent<DBComponent>().Query<DBCenterAccountInfo>(202, d => d.Id > 0);
            foreach (var entity in dBAccountInfos_new)
            {
                long sigleRecharge = 0;

                for (int i = 0; i < entity.PlayerInfo.RechargeInfos.Count; i++)
                {
                    //5月份
                    if (entity.PlayerInfo.RechargeInfos[i].Time > 1732982400000 && entity.PlayerInfo.RechargeInfos[i].Time < 1735574400000)
                    {
                        if (entity.Password == "6")
                        {
                            number_2 += entity.PlayerInfo.RechargeInfos[i].Amount;
                        }
                        else
                        {
                            number_1 += entity.PlayerInfo.RechargeInfos[i].Amount;
                        }
                        sigleRecharge += entity.PlayerInfo.RechargeInfos[i].Amount;
                    }
                }

                if (sigleRecharge > 30000)
                {
                    Log.Warning($"sigleRecharge > 50000: {sigleRecharge}");
                }
            }
        }


        public static async ETTask QueryRecharge_2()
        {

            ListComponent<int> mergezones = new ListComponent<int>() { 81, 202 };
            for (int i = 0; i < mergezones.Count; i++)
            {
                var startZoneConfig = StartZoneConfigCategory.Instance.Get(mergezones[i]);
                Game.Scene.GetComponent<DBComponent>().InitDatabase(startZoneConfig);
            }

            List<DBAccountInfo> dBAccountInfos = await Game.Scene.GetComponent<DBComponent>().Query<DBAccountInfo>(81, d => d.Id > 0);
            for (int i = 0; i < dBAccountInfos.Count; i++)
            {
                if (dBAccountInfos[i].UserList.Contains(2283301304216387584)
                    || dBAccountInfos[i].UserList.Contains(2291096446520328192)
                    || dBAccountInfos[i].DeleteUserList.Contains(2283301304216387584)
                    || dBAccountInfos[i].DeleteUserList.Contains(2291096446520328192))
                {
                    Log.Warning($"sigleRecharge > 50000: {dBAccountInfos[i].Account}");
                }
            }


            List<DBCenterAccountInfo> dBAccountInfos_new = await Game.Scene.GetComponent<DBComponent>().Query<DBCenterAccountInfo>(202, d => d.Id > 0);
            foreach (var entity in dBAccountInfos_new)
            {
                long sigleRecharge = 0;

                for (int i = 0; i < entity.PlayerInfo.RechargeInfos.Count; i++)
                {
                    //一月份
                    if (entity.PlayerInfo.RechargeInfos[i].UserId == 2283301304216387584
                        || entity.PlayerInfo.RechargeInfos[i].UserId == 2291096446520328192)
                    {
                        Log.Warning($"sigleRecharge > 50000: {entity.Account}");
                    }
                }

                if (sigleRecharge > 30000)
                {
                    Log.Warning($"sigleRecharge > 50000: {sigleRecharge}");
                }
            }
        }

        public static async ETTask QueryCard(string card)
        {
            var startZoneConfig = StartZoneConfigCategory.Instance.Get(202);
            Game.Scene.GetComponent<DBComponent>().InitDatabase(startZoneConfig);
            List<DBCenterAccountInfo> dBAccountInfos_new = await Game.Scene.GetComponent<DBComponent>().Query<DBCenterAccountInfo>(202, d => d.Id > 0);
            foreach (var entity in dBAccountInfos_new)
            {
                if (entity.PlayerInfo != null && entity.PlayerInfo.IdCardNo ==card)
                {
                    Log.Console(entity.Account);
                }
            }
        }

        public static async ETTask QueryOrderInfo(string dingdan)
        {
            var startZoneConfig = StartZoneConfigCategory.Instance.Get(202);
            Game.Scene.GetComponent<DBComponent>().InitDatabase(startZoneConfig);
            List<DBCenterAccountInfo> dBAccountInfos_new = await Game.Scene.GetComponent<DBComponent>().Query<DBCenterAccountInfo>(202, d => d.Id > 0);
            foreach (var entity in dBAccountInfos_new)
            {
                if (entity.PlayerInfo == null)
                {
                    continue;
                }
                List<RechargeInfo> rechargeInfos = entity.PlayerInfo.RechargeInfos;
                for (int i = 0; i < rechargeInfos.Count; i++)
                {
                    if (string.IsNullOrEmpty(rechargeInfos[i].OrderInfo))
                    {
                        continue;
                    }
                    if (rechargeInfos[i].OrderInfo.Equals(dingdan))
                    {
                        Console.WriteLine($"{entity.Account}");
                        Log.Warning($"{dingdan}   {entity.Account}");
                    }
                }
            }
        }

        public static async ETTask QueryGongzuoshi(int zone)
        {
            ListComponent<int> mergezones = new ListComponent<int>() { zone };
            for (int i = 0; i < mergezones.Count; i++)
            {
                var startZoneConfig = StartZoneConfigCategory.Instance.Get(mergezones[i]);
                Game.Scene.GetComponent<DBComponent>().InitDatabase(startZoneConfig);
            }


            Dictionary<string, List<long>> accountGold = new Dictionary<string, List<long>>();
            List<DBAccountInfo> dBAccountInfos = await Game.Scene.GetComponent<DBComponent>().Query<DBAccountInfo>(zone, d => d.Id > 0);

            for(  int i = 0; i < dBAccountInfos.Count; i++ )
            {
                if (dBAccountInfos[i].UserList.Count < 2)
                {
                    continue;
                }
                accountGold.Add(dBAccountInfos[i].Account, new List<long>());

                string gold = string.Empty;
                string level = string.Empty;
                string task = string.Empty;
                for (int user = 0; user < dBAccountInfos[i].UserList.Count; user++)
                {
                    List< UserInfoComponent> userInfoComponentlist = await Game.Scene.GetComponent<DBComponent>().Query<UserInfoComponent>(zone, d => d.Id == dBAccountInfos[i].UserList[user]);
                    if (userInfoComponentlist.Count == 0)
                    {
                        continue;
                    }

                    List<DataCollationComponent> dataCollationComponents = await Game.Scene.GetComponent<DBComponent>().Query<DataCollationComponent>(zone, d => d.Id == dBAccountInfos[i].UserList[user]);
                    if (dataCollationComponents.Count == 0)
                    {
                        continue;
                    }

                    accountGold[dBAccountInfos[i].Account].Add(userInfoComponentlist[0].UserInfo.Gold);

                    gold += $"{userInfoComponentlist[0].UserInfo.Gold}_";
                    level += $"{userInfoComponentlist[0].UserInfo.Lv}_";
                    task += $"{dataCollationComponents[0].MainTask}_";
                }

                if (gold == string.Empty || accountGold[dBAccountInfos[i].Account].Count < 2)
                {
                    continue;
                }

                Log.Warning($"区：{zone}  \t账号：{dBAccountInfos[i].Account}       \t等级：{level}   \t金币：{gold}   \t任务:{task}");
            }
        }


        //查询被那个id购买过的记录
        public static async ETTask QueryGongzuoshi_2(int zone, long buyId)
        {
            ListComponent<int> mergezones = new ListComponent<int>() { zone };
            for (int i = 0; i < mergezones.Count; i++)
            {
                var startZoneConfig = StartZoneConfigCategory.Instance.Get(mergezones[i]);
                Game.Scene.GetComponent<DBComponent>().InitDatabase(startZoneConfig);
            }


            List<DataCollationComponent> dataCollationComponents = await Game.Scene.GetComponent<DBComponent>().Query<DataCollationComponent>(zone, d => d.Id > 0);
            for (int i = 0; i < dataCollationComponents.Count; i++)
            {
            }

        }

        public static async ETTask QueryGold(int zone)
        {
            ListComponent<int> mergezones = new ListComponent<int>() { zone };
            for (int i = 0; i < mergezones.Count; i++)
            {
                var startZoneConfig = StartZoneConfigCategory.Instance.Get(mergezones[i]);
                Game.Scene.GetComponent<DBComponent>().InitDatabase(startZoneConfig);
            }

            Dictionary<long, UserInfoComponent> UserinfoComponetDict = new Dictionary<long, UserInfoComponent>();
            List<UserInfoComponent> userInfoComponents = await Game.Scene.GetComponent<DBComponent>().Query<UserInfoComponent>(zone, d => d.Id > 0);
            foreach (var entity in userInfoComponents)
            {
                UserinfoComponetDict.Add(entity.Id, entity as UserInfoComponent);
                if ((entity.UserInfo.Gold > 1000000 || entity.UserInfo.Diamond > 10000) && entity.UserInfo.RobotId == 0)
                {
                   // Log.Warning($"Gold:{entity.UserInfo.Gold}  Diamond:{entity.UserInfo.Diamond}  ID:{entity.Id}  Account:{entity.Account} Name: {entity.UserInfo.Name}  Lv:{entity.UserInfo.Lv} ");
                }

                if (entity.RemoteAddress != null && entity.RemoteAddress.Contains("39.153.233.46"))
                {
                    //Log.Warning($"Gold:{entity.Id} ");
                }
               
                if (entity.UserInfo.Name.Contains("南宫") || entity.UserInfo.Name.Contains("世家"))
                {
                    //Log.Warning($"南宫:   {entity.Id}  {entity.UserInfo.Lv}\t  {entity.UserInfo.Name}\t   {entity.UserInfo.Combat}");
                }

                if (entity.UserInfo.Combat < 0 || entity.UserInfo.Combat > 10000000)
                {
                    //Log.Warning($"Combat < 0:   {entity.Id}  {entity.UserInfo.Lv}\t  {entity.UserInfo.Name}\t   {entity.DeviceName}");
                }

                if (entity.UserInfo.Occ == 3 && (entity.UserInfo.Lv >= 22 ))
                {
                    Log.Warning($"Occ == 3:   {entity.Id}  \t{entity.UserInfo.Lv}  \t{entity.UserInfo.Name}   \t{entity.UserInfo.Combat}");
                }
            }

            Dictionary<long, NumericComponent> NumericComponentDict = new Dictionary<long, NumericComponent>();
            List<NumericComponent> NumericComponents = await Game.Scene.GetComponent<DBComponent>().Query<NumericComponent>(zone, d => d.Id > 0);
            foreach (var entity in NumericComponents)
            {
                NumericComponentDict.Add(entity.Id, entity as NumericComponent);
            }

            List<PetComponent> petComponents = await Game.Scene.GetComponent<DBComponent>().Query<PetComponent>(zone, d => d.Id > 0);
            foreach (var entity in petComponents)
            {
                string shenshou = string.Empty;
                for (int pet = 0; pet < entity.RolePetInfos.Count; pet++)
                {
                    if (entity.RolePetInfos[pet].ConfigId == 2000001)
                    {
                        shenshou += "2000001 ";
                    }
                    if (entity.RolePetInfos[pet].ConfigId == 2000002)
                    {
                        shenshou += "2000002 ";
                    }
                    if (entity.RolePetInfos[pet].ConfigId == 2000003)
                    {
                        shenshou += "2000003 ";
                    }
                }

                if (string.IsNullOrEmpty(shenshou))
                {
                    continue;
                }

                UserInfoComponent userInfo = UserinfoComponetDict[entity.Id];
                string servername = ServerHelper.GetGetServerItem(false, zone).ServerName;

                string userName = userInfo.UserInfo.Name;
                int userlv = userInfo.UserInfo.Lv;
                long recharget = NumericComponentDict[entity.Id].GetAsLong(NumericType.RechargeNumber);
                long diamond = userInfo.UserInfo.Diamond;

                Log.Warning($"{servername} 玩家:{userName}  等级: {userlv}  充值额度:{recharget}  当前钻石{diamond}  拥有神兽:{shenshou}");
            }
        }

        public static async ETTask QueryAccount(int newzone, long userid)
        {
            ListComponent<int> mergezones = new ListComponent<int>() { newzone };
            for (int i = 0; i < mergezones.Count; i++)
            {
                var startZoneConfig = StartZoneConfigCategory.Instance.Get(mergezones[i]);
                Game.Scene.GetComponent<DBComponent>().InitDatabase(startZoneConfig);
            }

            List<DBAccountInfo> dBAccountInfos_new = await Game.Scene.GetComponent<DBComponent>().Query<DBAccountInfo>(newzone, d => d.Id > 0);
            foreach (var entity in dBAccountInfos_new)
            {
                if (entity.UserList.Contains(userid))
                {
                    Log.Debug(entity.Account);
                }
            }
        }

        public static async ETTask MergeZoneUnion(int oldzone, int newzone)
        {
            ListComponent<int> mergezones = new ListComponent<int>() { oldzone, newzone };
            for (int i = 0; i < mergezones.Count; i++)
            {
                var startZoneConfig = StartZoneConfigCategory.Instance.Get(mergezones[i]);
                Game.Scene.GetComponent<DBComponent>().InitDatabase(startZoneConfig);
            }

            List<DBUnionInfo> dBUnionInfo_new = await Game.Scene.GetComponent<DBComponent>().Query<DBUnionInfo>(oldzone, d => d.Id > 0);
            foreach (var entity in dBUnionInfo_new)
            {
                Log.Console($"合并家族: {newzone} {entity.Id}");
                await Game.Scene.GetComponent<DBComponent>().Save(newzone, entity);
            }

            List<DBUnionManager> DBUnionManager_new = await Game.Scene.GetComponent<DBComponent>().Query<DBUnionManager>(newzone, d => d.Id == newzone);
            List<DBUnionManager> DBUnionManager_old = await Game.Scene.GetComponent<DBComponent>().Query<DBUnionManager>(newzone, d => d.Id == oldzone);
            if (DBUnionManager_new.Count >= 0)
            {

            }
            Log.Console($"合并家族完成！:");
        }

        //Parameters=31_30   31区合并到30区
        public static async ETTask MergeZone(int oldzone, int newzone)
        {
            ListComponent<int> mergezones = new ListComponent<int>() { oldzone, newzone };
            for (int i = 0; i < mergezones.Count; i++)
            {
                var startZoneConfig = StartZoneConfigCategory.Instance.Get(mergezones[i]);
                Game.Scene.GetComponent<DBComponent>().InitDatabase(startZoneConfig);
            }

            //同时满足以下规则,数据将被清理
            //1.未充值
            //2.角色20级以内
            //3.10天内未登陆游戏
            long serverNow = TimeHelper.ServerNow();
            List<long> invalidPlayers = new List<long>();

            ///记录玩家等级
            ///Parameters=31_30   31区合并到30区   oldzone合并到newzone
            Dictionary<long, int> userLevel = new Dictionary<long, int>();
            List<UserInfoComponent> olduserInfoComponents_0 = await Game.Scene.GetComponent<DBComponent>().Query<UserInfoComponent>(oldzone, d => d.Id > 0);

            int validLv = 20;
            if (olduserInfoComponents_0.Count > 40000)
            {
                validLv = 25;
            }

            foreach (var oldentity in olduserInfoComponents_0)
            {
                if (!userLevel.ContainsKey(oldentity.Id))
                {
                    userLevel.Add(oldentity.Id, oldentity.UserInfo.Lv);
                }

                if (oldentity.UserInfo.RobotId > 0)
                {
                    invalidPlayers.Add(oldentity.Id);
                    continue;
                }

                if (oldentity.UserInfo.Lv >= validLv)
                {
                    continue;
                }
                List<NumericComponent> numericComponentlist = await Game.Scene.GetComponent<DBComponent>().Query<NumericComponent>(oldzone, d => d.Id == oldentity.Id);
                if (numericComponentlist == null || numericComponentlist.Count == 0)
                {
                    continue;
                }
                if (numericComponentlist[0].GetAsLong(NumericType.RechargeNumber) > 0)
                {
                    continue;
                }
                if (serverNow - numericComponentlist[0].GetAsLong(NumericType.LastGameTime) < TimeHelper.OneDay * 10)
                {
                    continue;
                }
                invalidPlayers.Add( oldentity.Id );
                //Log.Console($"移除玩家： {oldentity.UserInfo.Name}  {oldentity.UserInfo.Lv}   {numericComponentlist[0].GetAsLong(NumericType.RechargeNumber)}  {TimeInfo.Instance.ToDateTime(numericComponentlist[0].GetAsLong(NumericType.LastGameTime)).ToString()}");
                //Log.Warning($"移除玩家： {oldentity.UserInfo.Name}  {oldentity.UserInfo.Lv}   {numericComponentlist[0].GetAsLong(NumericType.RechargeNumber)}  {TimeInfo.Instance.ToDateTime(numericComponentlist[0].GetAsLong(NumericType.LastGameTime)).ToString()}");
            }
            Log.Console($"不参与合区的玩家数量 {invalidPlayers.Count}");

            //ActivityComponent
            List<ActivityComponent> activityComponents = await Game.Scene.GetComponent<DBComponent>().Query<ActivityComponent>(oldzone, d => d.Id > 0);
            long dbcount = 0;
            int onecount = 1000;
            foreach (var entity in activityComponents)
            {
                if (invalidPlayers.Contains(entity.Id))
                {
                    continue;
                }

                dbcount++;
                if (dbcount % onecount == 0)
                {
                    await TimerComponent.Instance.WaitFrameAsync();
                }
                await Game.Scene.GetComponent<DBComponent>().Save(newzone, entity);
            }
            Log.Console("ActivityComponent Complelte");

            //BagComponent
            dbcount = 0;
            List<BagComponent> bagComponents = await Game.Scene.GetComponent<DBComponent>().Query<BagComponent>(oldzone, d => d.Id > 0);
            foreach (var entity in bagComponents)
            {
                if (invalidPlayers.Contains(entity.Id))
                {
                    continue;
                }
                dbcount++;
                if (dbcount % onecount == 0)
                {
                    await TimerComponent.Instance.WaitFrameAsync();
                }
                await Game.Scene.GetComponent<DBComponent>().Save(newzone, entity);
            }
            await TimerComponent.Instance.WaitFrameAsync();
            Log.Console("BagComponent Complelte");
            //ChengJiuComponen
            dbcount = 0;
            List<ChengJiuComponent> chengJiuComponents = await Game.Scene.GetComponent<DBComponent>().Query<ChengJiuComponent>(oldzone, d => d.Id > 0);
            foreach (var entity in chengJiuComponents)
            {
                if (invalidPlayers.Contains(entity.Id))
                {
                    continue;
                }
                dbcount++;
                if (dbcount % onecount == 0)
                {
                    await TimerComponent.Instance.WaitFrameAsync();
                }
                await Game.Scene.GetComponent<DBComponent>().Save(newzone, entity);
            }
            Log.Console("ChengJiuComponent Complelte");
            //DBAccountInfo.  问清楚规则 不能全部合并
            dbcount = 0;
            List<DBAccountInfo> dBAccountInfos_old = await Game.Scene.GetComponent<DBComponent>().Query<DBAccountInfo>(oldzone, d => d.Id > 0);
            List<DBAccountInfo> dBAccountInfos_new = await Game.Scene.GetComponent<DBComponent>().Query<DBAccountInfo>(newzone, d => d.Id > 0);
            foreach (var entity in dBAccountInfos_old)
            {
                if (entity.Password.Equals(ComHelp.RobotPassWord))
                {
                    continue;
                }

                bool allremove = true;
                for (int i = 0; i < entity.UserList.Count; i++)
                {
                    if (!invalidPlayers.Contains(entity.UserList[i]))
                    {
                        allremove = false;
                        break;
                    }
                }
                if (allremove)
                {
                    continue;
                }

                dbcount++;
                if (dbcount % onecount == 0)
                {
                    await TimerComponent.Instance.WaitFrameAsync();
                }

                List<DBAccountInfo> dBAccountInfos = await Game.Scene.GetComponent<DBComponent>().Query<DBAccountInfo>(newzone, d => d.Id == entity.Id);
                if (dBAccountInfos.Count > 0)
                {
                    if (entity.UserList.Count > 0 && !dBAccountInfos[0].UserList.Contains(entity.UserList[0]))
                    {
                        dBAccountInfos[0].UserList.AddRange(entity.UserList);
                        dBAccountInfos[0].BagInfoList.AddRange(entity.BagInfoList);
                    }

                    await Game.Scene.GetComponent<DBComponent>().Save(newzone, dBAccountInfos[0]);
                }
                else
                {
                    await Game.Scene.GetComponent<DBComponent>().Save(newzone, entity);
                }
            }
            Log.Console("DBAccountInfo Complelte");

            //DBDayActivityInfo  活动相关也要特殊处理
            List<DBDayActivityInfo> dBDayActivityInfos_old = await Game.Scene.GetComponent<DBComponent>().Query<DBDayActivityInfo>(oldzone, d => d.Id > 0);
            List<DBDayActivityInfo> dBDayActivityInfos_new = await Game.Scene.GetComponent<DBComponent>().Query<DBDayActivityInfo>(newzone, d => d.Id > 0);
            foreach (var newentity in dBDayActivityInfos_new)
            {
                if (newentity.Id != newzone)
                {
                    continue;
                }

                newentity.AddGuessPlayerList(dBDayActivityInfos_old[0].GuessPlayerList);
                newentity.AddGuessRewardList(dBDayActivityInfos_old[0].GuessRewardList);
                await Game.Scene.GetComponent<DBComponent>().Save(newzone, newentity);
            }

            //DBFriendInfo
            dbcount = 0;
            List<DBFriendInfo> dBFriendInfos = await Game.Scene.GetComponent<DBComponent>().Query<DBFriendInfo>(oldzone, d => d.Id > 0);
            foreach (var entity in dBFriendInfos)
            {
                if (invalidPlayers.Contains(entity.Id))
                {
                    continue;
                }

                dbcount++;
                if (dbcount % onecount == 0)
                {
                    await TimerComponent.Instance.WaitFrameAsync();
                }
                await Game.Scene.GetComponent<DBComponent>().Save(newzone, entity);
            }
            Log.Console("DBFriendInfo Complelte");

            //DBMailInfo 邮件
            dbcount = 0;
            List<DBMailInfo> dBMailInfos = await Game.Scene.GetComponent<DBComponent>().Query<DBMailInfo>(oldzone, d => d.Id > 0);
            foreach (var entity in dBMailInfos)
            {
                if (invalidPlayers.Contains(entity.Id))
                {
                    continue;
                }

                dbcount++;
                if (dbcount % onecount == 0)
                {
                    await TimerComponent.Instance.WaitFrameAsync();
                }
                int lv = 0;
                userLevel.TryGetValue(entity.Id, out lv);

                List<BagInfo> rewardlist = ConfigHelper.GetHeQuReward(lv);
                if (rewardlist!=null && rewardlist.Count > 0)
                {
                    MailInfo mailInfo = new MailInfo();
                    mailInfo.Status = 0;
                    mailInfo.Context = "合区补偿";
                    mailInfo.Title = "合区补偿";
                    mailInfo.MailId = IdGenerater.Instance.GenerateId();
                    mailInfo.ItemList.AddRange(rewardlist);
                    entity.MailInfoList.Add(mailInfo);
                }

                await Game.Scene.GetComponent<DBComponent>().Save(newzone, entity);
            }

            Log.Console("DBMailInfo Complelte");

            //DBPaiMainInfo 拍卖，也合并过来，要着重测试
            //List<DBPaiMainInfo> dBPaiMainInfos_old = await Game.Scene.GetComponent<DBComponent>().Query<DBPaiMainInfo>(oldzone, d => d.Id > 0);
            List<DBPaiMainInfo> dBPaiMainInfos_new = await Game.Scene.GetComponent<DBComponent>().Query<DBPaiMainInfo>(newzone, d => d.Id > 0);
            List<long> paimaishangjiaIds = new List<long>() 
            {
                PaiMaiHelper.Instance.GetPaiMaiId(1),
                PaiMaiHelper.Instance.GetPaiMaiId(2),
                PaiMaiHelper.Instance.GetPaiMaiId(3),
                PaiMaiHelper.Instance.GetPaiMaiId(4),
            };
            foreach (var entityNew in dBPaiMainInfos_new)
            {
                if (!paimaishangjiaIds.Contains( entityNew.Id) )
                {
                    continue;
                }
                bool have = false;
                List<DBPaiMainInfo> dBPaiMainInfos_old = await Game.Scene.GetComponent<DBComponent>().Query<DBPaiMainInfo>(oldzone, d => d.Id == entityNew.Id);
                if (dBPaiMainInfos_old == null || dBPaiMainInfos_old.Count == 0)
                {
                    continue;
                }
                List<PaiMaiItemInfo> oldlist_0 = dBPaiMainInfos_old[0].PaiMaiItemInfos;
                if (oldlist_0.Count > 0)
                {
                    for (int i = 0; i < entityNew.PaiMaiItemInfos.Count; i++)
                    {
                        if (entityNew.PaiMaiItemInfos[i].Id == oldlist_0[0].Id)
                        {
                            have = true;
                            break;
                        }
                    }
                }
                if (!have)
                {
                    entityNew.PaiMaiItemInfos.AddRange(oldlist_0);
                }

                await Game.Scene.GetComponent<DBComponent>().Save(newzone, entityNew);
            }

            dbcount = 0;
            List<DBPopularizeInfo> dBPopularizeInfos = await Game.Scene.GetComponent<DBComponent>().Query<DBPopularizeInfo>(oldzone, d => d.Id > 0);
            foreach (var entity in dBPopularizeInfos)
            {
                if (invalidPlayers.Contains(entity.Id))
                {
                    continue;
                }

                dbcount++;
                if (dbcount % onecount == 0)
                {
                    await TimerComponent.Instance.WaitFrameAsync();
                }
                await Game.Scene.GetComponent<DBComponent>().Save(newzone, entity);
            }
            Log.Console("DBPopularizeInfo Complelte");

            //DBRankInfo 排行榜  。 
            List<DBRankInfo> dBRankInfos_old = await Game.Scene.GetComponent<DBComponent>().Query<DBRankInfo>(oldzone, d => d.Id == (long)oldzone);
            List<DBRankInfo> dBRankInfos_new = await Game.Scene.GetComponent<DBComponent>().Query<DBRankInfo>(newzone, d => d.Id == (long)newzone);
            if(dBRankInfos_old.Count > 0 && dBRankInfos_new.Count > 0)
            {
                DBRankInfo entity = dBRankInfos_new[0];

                List<RankingInfo> rankingInfos_new = entity.rankingInfos;
                List<RankingInfo> rankingInfos_old = dBRankInfos_old[0].rankingInfos;

                bool havemerge = false; 
                for (int i = 0; i < rankingInfos_new.Count; i++)
                {
                    for (int j = 0; j < rankingInfos_old.Count; j++ )
                    {
                        if (rankingInfos_new[i].UserId == rankingInfos_old[j].UserId)
                        {
                            havemerge = true;
                            break;
                        }
                    }
                }
                if (havemerge)
                {
                    Log.Console($"排行榜已合并！");
                }
                else
                {
                    rankingInfos_new.AddRange(rankingInfos_old);
                    rankingInfos_new.Sort(delegate (RankingInfo a, RankingInfo b)
                    {
                        return (int)b.Combat - (int)a.Combat;
                    });
                    int maxnumber = Math.Min(500, rankingInfos_new.Count);
                    entity.rankingInfos = rankingInfos_new.GetRange(0, maxnumber);

                    List<KeyValuePairLong> rankingTrial_new = entity.rankingTrial;
                    List<KeyValuePairLong> rankingTrial_old = dBRankInfos_old[0].rankingTrial;
                    rankingTrial_new.AddRange(rankingTrial_old);
                    rankingTrial_new.Sort(delegate (KeyValuePairLong a, KeyValuePairLong b)
                    {
                        if (b.Value2 == a.Value2)
                        {
                            return (int)b.Value2 - (int)a.Value2;
                        }
                        else
                        {
                            return (int)b.Value - (int)a.Value;
                        }
                    });
                    maxnumber = Math.Min(rankingTrial_new.Count, 100);
                    entity.rankingTrial = rankingTrial_new.GetRange(0, maxnumber);

                    List<KeyValuePairLong> rankSeasonTower_new = entity.rankSeasonTower;
                    List<KeyValuePairLong> rankSeasonTower_old = dBRankInfos_old[0].rankSeasonTower;
                    rankSeasonTower_new.AddRange(rankSeasonTower_old);
                    rankSeasonTower_new.Sort(delegate (KeyValuePairLong a, KeyValuePairLong b)
                    {
                        if (b.Value2 == a.Value2)
                        {
                            return (int)a.Value - (int)b.Value;
                        }
                        else
                        {
                            return (int)b.Value2 - (int)a.Value2;
                        }
                    });
                    maxnumber = Math.Min(rankSeasonTower_new.Count, 100);
                    entity.rankSeasonTower = rankSeasonTower_new.GetRange(0, maxnumber);

                    //阵营相关的都要重置
                    await Game.Scene.GetComponent<DBComponent>().Save(newzone, entity);
                }
            }

            //DBServerInfo   服务器的一些公用内容
            List<DBServerInfo> dBServerInfos_old = await Game.Scene.GetComponent<DBComponent>().Query<DBServerInfo>(oldzone, d => d.Id > 0);
            List<DBServerInfo> dBServerInfos_new = await Game.Scene.GetComponent<DBComponent>().Query<DBServerInfo>(newzone, d => d.Id > 0);
            foreach (var entity in dBServerInfos_new)
            {
                if (entity.Id != newzone)
                {
                    continue;
                }
                await Game.Scene.GetComponent<DBComponent>().Save(newzone, entity);
            }

            ///全服邮件(不需要处理)
            ///DBServerMailInfo

            List<DBUnionInfo> dBUnionInfo_old = await Game.Scene.GetComponent<DBComponent>().Query<DBUnionInfo>(oldzone, d => d.Id > 0);
            foreach (var entity in dBUnionInfo_old)
            {
                await Game.Scene.GetComponent<DBComponent>().Save(newzone, entity);
            }
            Log.Console($"DBUnionInfo Complelte");

            //合并捐献总金额
            List<DBUnionManager> dBUnionManager_old = await Game.Scene.GetComponent<DBComponent>().Query<DBUnionManager>(oldzone, d => d.Id == (long)oldzone);
            List<DBUnionManager> dBUnionManager_new = await Game.Scene.GetComponent<DBComponent>().Query<DBUnionManager>(newzone, d => d.Id == (long)newzone);
            if (dBUnionManager_old.Count > 0 && dBUnionManager_new.Count > 0)
            {
                DBUnionManager oldentity = dBUnionManager_old[0];
                DBUnionManager newentity = dBUnionManager_new[0];

                Log.Console($"合并家族捐献资金: {oldentity.TotalDonation} {newentity.TotalDonation}");
                newentity.TotalDonation += oldentity.TotalDonation;

                if(oldentity.SignupUnions.Count > 0 && !newentity.SignupUnions.Contains(oldentity.SignupUnions[0]))
                {
                    Log.Console($"合并家族战报名列表: {oldentity.SignupUnions[0]}");
                    newentity.SignupUnions.AddRange(oldentity.SignupUnions);

                    List<RankingInfo> rankingDonation_old = oldentity.rankingDonation;
                    List<RankingInfo> rankingDonation_new = newentity.rankingDonation;

                    rankingDonation_new.AddRange(rankingDonation_old);
                    rankingDonation_new.Sort(delegate (RankingInfo a, RankingInfo b)
                    {
                        return (int)b.Combat - (int)a.Combat;
                    });
                    int number = Math.Min(rankingDonation_new.Count, 20);
                    rankingDonation_new = rankingDonation_new.GetRange(0, number);
                    newentity.rankingDonation = rankingDonation_new;
                }

                await Game.Scene.GetComponent<DBComponent>().Save(newzone, newentity);
            }
            dbcount = 0;

            try
            {
                List<DataCollationComponent> datacollationComponents = await Game.Scene.GetComponent<DBComponent>().Query<DataCollationComponent>(oldzone, d => d.Id > 0);
                foreach (var entity in datacollationComponents)
                {
                    if (invalidPlayers.Contains(entity.Id))
                    {
                        continue;
                    }

                    dbcount++;
                    if (dbcount % onecount == 0)
                    {
                        await TimerComponent.Instance.WaitFrameAsync();
                    }
                    await Game.Scene.GetComponent<DBComponent>().Save(newzone, entity);
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.ToString());
            }
            Log.Console("DataCollationComponent Complelte");

            //EnergyComponent 正能量组件
            dbcount = 0;
            List<EnergyComponent> db_energyComponents = await Game.Scene.GetComponent<DBComponent>().Query<EnergyComponent>(oldzone, d => d.Id > 0);
            foreach (var entity in db_energyComponents)
            {
                if (invalidPlayers.Contains(entity.Id))
                {
                    continue;
                }

                dbcount++;
                if (dbcount % onecount == 0)
                {
                    await TimerComponent.Instance.WaitFrameAsync();
                }
                await Game.Scene.GetComponent<DBComponent>().Save(newzone, entity);
            }

            dbcount = 0;
            List<JiaYuanComponent> jiayuanComponents = await Game.Scene.GetComponent<DBComponent>().Query<JiaYuanComponent>(oldzone, d => d.Id > 0);
            foreach (var entity in jiayuanComponents)
            {
                if (invalidPlayers.Contains(entity.Id))
                {
                    continue;
                }

                dbcount++;
                if (dbcount % onecount == 0)
                {
                    await TimerComponent.Instance.WaitFrameAsync();
                }
                await Game.Scene.GetComponent<DBComponent>().Save(newzone, entity);
            }
            Log.Console("JiaYuanComponent Complelte");

            //NumericComponent  数值组件
            dbcount = 0;
            List<NumericComponent> numericComponents = await Game.Scene.GetComponent<DBComponent>().Query<NumericComponent>(oldzone, d => d.Id > 0);
            foreach (var entity in numericComponents)
            {
                if (invalidPlayers.Contains(entity.Id))
                {
                    continue;
                }
                dbcount++;
                if (dbcount % onecount == 0)
                {
                    await TimerComponent.Instance.WaitFrameAsync();
                }
                await Game.Scene.GetComponent<DBComponent>().Save(newzone, entity);
            }
            Log.Console("NumericComponent Complelte");

            //PetComponent  宠物组件
            dbcount = 0;
            List<PetComponent> petComponents = await Game.Scene.GetComponent<DBComponent>().Query<PetComponent>(oldzone, d => d.Id > 0);
            foreach (var entity in petComponents)
            {
                if (invalidPlayers.Contains(entity.Id))
                {
                    continue;
                }
                dbcount++;
                if (dbcount % onecount == 0)
                {
                    await TimerComponent.Instance.WaitFrameAsync();
                }
                await Game.Scene.GetComponent<DBComponent>().Save(newzone, entity);
            }
            Log.Console("PetComponent Complelte");

            //RechargeComponent  充值记录组件
            dbcount = 0;
            List<RechargeComponent> rechargeComponents = await Game.Scene.GetComponent<DBComponent>().Query<RechargeComponent>(oldzone, d => d.Id > 0);
            foreach (var entity in rechargeComponents)
            {
                if (invalidPlayers.Contains(entity.Id))
                {
                    continue;
                }
                dbcount++;
                if (dbcount % onecount == 0)
                {
                    await TimerComponent.Instance.WaitFrameAsync();
                }
                await Game.Scene.GetComponent<DBComponent>().Save(newzone, entity);
            }
            Log.Console("DBPopularizeInfo Complelte");
            //ReddotComponent  红点组件
            dbcount = 0;
            List<ReddotComponent> reddotComponents = await Game.Scene.GetComponent<DBComponent>().Query<ReddotComponent>(oldzone, d => d.Id > 0);
            foreach (var entity in reddotComponents)
            {
                if (invalidPlayers.Contains(entity.Id))
                {
                    continue;
                }
                dbcount++;
                if (dbcount % onecount == 0)
                {
                    await TimerComponent.Instance.WaitFrameAsync();
                }
                await Game.Scene.GetComponent<DBComponent>().Save(newzone, entity);
            }
            Log.Console("ReddotComponent Complelte");


            //ShoujiComponent  收集大厅
            dbcount = 0;
            List<ShoujiComponent> shoujiComponents = await Game.Scene.GetComponent<DBComponent>().Query<ShoujiComponent>(oldzone, d => d.Id > 0);
            foreach (var entity in shoujiComponents)
            {
                if (invalidPlayers.Contains(entity.Id))
                {
                    continue;
                }
                dbcount++;
                if (dbcount % onecount == 0)
                {
                    await TimerComponent.Instance.WaitFrameAsync();
                }
                await Game.Scene.GetComponent<DBComponent>().Save(newzone, entity);
            }
            Log.Console("ShoujiComponent Complelte");

            //SkillSetComponent  技能
            dbcount = 0;
            List<SkillSetComponent> skillSetComponents = await Game.Scene.GetComponent<DBComponent>().Query<SkillSetComponent>(oldzone, d => d.Id > 0);
            foreach (var entity in skillSetComponents)
            {
                if (invalidPlayers.Contains(entity.Id))
                {
                    continue;
                }
                dbcount++;
                if (dbcount % onecount == 0)
                {
                    await TimerComponent.Instance.WaitFrameAsync();
                }
                await Game.Scene.GetComponent<DBComponent>().Save(newzone, entity);
            }
            Log.Console("SkillSetComponent Complelte");

            //TaskComponent  renw组件
            dbcount = 0;
            List<TaskComponent> taskComponents = await Game.Scene.GetComponent<DBComponent>().Query<TaskComponent>(oldzone, d => d.Id > 0);
            foreach (var entity in taskComponents)
            {
                if (invalidPlayers.Contains(entity.Id))
                {
                    continue;
                }
                dbcount++;
                if (dbcount % onecount == 0)
                {
                    await TimerComponent.Instance.WaitFrameAsync();
                }
                await Game.Scene.GetComponent<DBComponent>().Save(newzone, entity);
            }
            Log.Console("TaskComponent Complelte");

            dbcount = 0;
            List<TitleComponent> titleComponents = await Game.Scene.GetComponent<DBComponent>().Query<TitleComponent>(oldzone, d => d.Id > 0);
            foreach (var entity in titleComponents)
            {
                if (invalidPlayers.Contains(entity.Id))
                {
                    continue;
                }
                dbcount++;
                if (dbcount % onecount == 0)
                {
                    await TimerComponent.Instance.WaitFrameAsync();
                }
                await Game.Scene.GetComponent<DBComponent>().Save(newzone, entity);
            }
            Log.Console("TitleComponent Complelte");

            //UserInfoComponent  玩家信息
            dbcount = 0;
            Dictionary<string, UserInfoComponent> newuserinfoList = new Dictionary<string, UserInfoComponent>();
            //先初始化新的玩家列表
            List<UserInfoComponent> newuserInfoComponents = await Game.Scene.GetComponent<DBComponent>().Query<UserInfoComponent>(newzone, d => d.Id > 0);
            foreach (var entity in newuserInfoComponents)
            {
                if (entity.UserInfo == null || string.IsNullOrEmpty(entity.UserInfo.Name))
                {
                    Log.Debug("entity.UserInfo == null:  " + entity.Id);
                    continue;
                }

                if (!newuserinfoList.ContainsKey(entity.UserInfo.Name))
                {
                    newuserinfoList.Add(entity.UserInfo.Name, entity);
                }
            }
            Log.Console("newuserinfoList Complelte");

            int maxServerId = 0;
            List<DBServerMailInfo> dBServerMailInfos = await Game.Scene.GetComponent<DBComponent>().Query<DBServerMailInfo>(newzone, d => d.Id == newzone);
            if (dBServerMailInfos.Count > 0)
            {
                foreach ((int id, ServerMailItem ServerItem) in dBServerMailInfos[0].ServerMailList)
                {
                    if (id >= maxServerId)
                    {
                        maxServerId = id;
                    }
                }
            }
            Log.Console($"maxServerId {maxServerId}");

            List<UserInfoComponent> olduserInfoComponents = await Game.Scene.GetComponent<DBComponent>().Query<UserInfoComponent>(oldzone, d => d.Id > 0);
            foreach (var oldentity in olduserInfoComponents)
            {
                if (invalidPlayers.Contains(oldentity.Id))
                {
                    continue;
                }

                dbcount++;
                if (dbcount % onecount == 0)
                {
                    Log.Console("合区补偿改名卡");
                    await TimerComponent.Instance.WaitFrameAsync();
                }

                if (oldentity.UserInfo == null || string.IsNullOrEmpty(oldentity.UserInfo.Name))
                {
                    continue;
                }
                if (newuserinfoList.ContainsKey(oldentity.UserInfo.Name))
                {
                    //合服账号名称规则，A：流星 25级 B 流星 30级 则B流星 名字沿用，A自动发放一个改名卡 （规则 等级高 > 战力高 > id在前）
                    long renameId = 0;
                    UserInfoComponent newentity = newuserinfoList[oldentity.UserInfo.Name];
                    if (oldentity.UserInfo.Lv > newentity.UserInfo.Lv)
                    {
                        renameId = newentity.Id;
                        newentity.UserInfo.Name += oldzone.ToString();
                        await Game.Scene.GetComponent<DBComponent>().Save(newzone, newentity);
                    }
                    else
                    {
                        renameId = oldentity.Id;
                        oldentity.UserInfo.Name += oldzone.ToString();
                    }

                    List<DBMailInfo> renamedBMailInfos = await Game.Scene.GetComponent<DBComponent>().Query<DBMailInfo>(oldzone, d => d.Id == renameId);
                    if (renamedBMailInfos.Count > 0)
                    {
                        MailInfo mailInfo = new MailInfo();
                        mailInfo.Status = 0;
                        mailInfo.Context = "合区补偿改名卡";
                        mailInfo.Title = "合区补偿";
                        mailInfo.MailId = IdGenerater.Instance.GenerateId();
                        BagInfo reward = new BagInfo();
                        reward.ItemID = 10010036;
                        reward.ItemNum = 1;
                        reward.GetWay = $"{ItemGetWay.System}_{TimeHelper.ServerNow()}";
                        mailInfo.ItemList.Add(reward);
                        renamedBMailInfos[0].MailInfoList.Add(mailInfo);

                        await Game.Scene.GetComponent<DBComponent>().Save(newzone, renamedBMailInfos[0]);
                    }
                }

                if (maxServerId > 0 && maxServerId > oldentity.UserInfo.ServerMailIdCur)
                {
                    oldentity.UserInfo.ServerMailIdCur = maxServerId;
                }
                await Game.Scene.GetComponent<DBComponent>().Save(newzone, oldentity);
            }

            Log.Console("MergeZone Complelte");
        }
    }
}
