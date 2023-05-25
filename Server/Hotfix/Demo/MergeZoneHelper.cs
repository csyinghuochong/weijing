using System;
using System.Collections.Generic;

namespace ET
{

    //合区
    public static class MergeZoneHelper
    {

        public static async ETTask QueryRecharge()
        {
            int number = 0;
            var startZoneConfig = StartZoneConfigCategory.Instance.Get(202);
            Game.Scene.GetComponent<DBComponent>().InitDatabase(startZoneConfig);
            List<DBCenterAccountInfo> dBAccountInfos_new = await Game.Scene.GetComponent<DBComponent>().Query<DBCenterAccountInfo>(202, d => d.Id > 0);
            foreach (var entity in dBAccountInfos_new)
            {
                for (int i = 0; i < entity.PlayerInfo.RechargeInfos.Count; i++)
                {
                    number += entity.PlayerInfo.RechargeInfos[i].Amount;
                }
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
                if ((entity.UserInfo.Gold > 1000000 || entity.UserInfo.Diamond > 10000))
                {
                    //Log.Warning($"Gold:{entity.UserInfo.Gold}  Diamond:{entity.UserInfo.Diamond}  ID:{entity.Id}  Account:{entity.Account} Name: {entity.UserInfo.Name}  Lv:{entity.UserInfo.Lv} ");
                }

                if (entity.RemoteAddress!= null && entity.RemoteAddress.Contains("39.153.233.46"))
                {
                    Log.Warning($"Gold:{entity.Id} ");
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
                int userlv = userInfo.UserInfo.Lv ;
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
                await Game.Scene.GetComponent<DBComponent>().Save<DBUnionInfo>(newzone, entity);
            }

            List<DBUnionManager> DBUnionManager_new = await Game.Scene.GetComponent<DBComponent>().Query<DBUnionManager>(newzone, d => d.Id == newzone);
            List<DBUnionManager> DBUnionManager_old = await Game.Scene.GetComponent<DBComponent>().Query<DBUnionManager>(newzone, d => d.Id == oldzone);
            if (DBUnionManager_new.Count >= 0)
            { 
                
            }
            Log.Console($"合并家族完成！:");
        }

        public static async ETTask MergeZone(int oldzone, int newzone)
        {
            ListComponent<int> mergezones = new ListComponent<int>() { oldzone, newzone };
            for (int i = 0; i < mergezones.Count; i++)
            {
                var startZoneConfig = StartZoneConfigCategory.Instance.Get(mergezones[i]);
                Game.Scene.GetComponent<DBComponent>().InitDatabase(startZoneConfig);
            }
           
            //ActivityComponent
            List<ActivityComponent> activityComponents = await Game.Scene.GetComponent<DBComponent>().Query<ActivityComponent>(oldzone, d => d.Id > 0);
            long dbcount = 0;
            int onecount = 50;
            foreach (var entity in activityComponents)
            {
                dbcount++;
                if (dbcount % onecount == 0)
                {
                    await TimerComponent.Instance.WaitFrameAsync();
                }
                await Game.Scene.GetComponent<DBComponent>().Save<ActivityComponent>(newzone, entity);
            }

            List<DBUnionInfo> dBUnionInfo_new = await Game.Scene.GetComponent<DBComponent>().Query<DBUnionInfo>(oldzone, d => d.Id > 0);
            foreach (var entity in dBUnionInfo_new)
            {
                Log.Console($"合并家族: {newzone} {entity.Id}");
                await Game.Scene.GetComponent<DBComponent>().Save<DBUnionInfo>(newzone, entity);
            }

            //BagComponent
            dbcount = 0;
            List<BagComponent> bagComponents = await Game.Scene.GetComponent<DBComponent>().Query<BagComponent>(oldzone, d => d.Id > 0);
            foreach (var entity in bagComponents)
            {
                dbcount++;
                if (dbcount % onecount == 0)
                {
                    await TimerComponent.Instance.WaitFrameAsync();
                }
                await Game.Scene.GetComponent<DBComponent>().Save<BagComponent>(newzone, entity);
            }
            await TimerComponent.Instance.WaitFrameAsync();

            //ChengJiuComponen
            dbcount = 0;
            List<ChengJiuComponent> chengJiuComponents = await Game.Scene.GetComponent<DBComponent>().Query<ChengJiuComponent>(oldzone, d => d.Id > 0);
            foreach (var entity in chengJiuComponents)
            {
                dbcount++;
                if (dbcount % onecount == 0)
                {
                    await TimerComponent.Instance.WaitFrameAsync();
                }
                await Game.Scene.GetComponent<DBComponent>().Save<ChengJiuComponent>(newzone, entity);
            }

            //DBAccountInfo.  问清楚规则 不能全部合并
            dbcount = 0;
            List<DBAccountInfo> dBAccountInfos_old = await Game.Scene.GetComponent<DBComponent>().Query<DBAccountInfo>(oldzone, d => d.Id > 0);
            List<DBAccountInfo> dBAccountInfos_new = await Game.Scene.GetComponent<DBComponent>().Query<DBAccountInfo>(newzone, d => d.Id > 0);
            foreach (var entity in dBAccountInfos_old)
            {
                dbcount++;
                if (dbcount % onecount == 0)
                {
                    await TimerComponent.Instance.WaitFrameAsync();
                }

                List<DBAccountInfo> dBAccountInfos = await Game.Scene.GetComponent<DBComponent>().Query<DBAccountInfo>(newzone, d => d.Id == entity.Id);
                if (dBAccountInfos.Count > 0)
                {
                    dBAccountInfos[0].UserList.AddRange(entity.UserList);
                    await Game.Scene.GetComponent<DBComponent>().Save<DBAccountInfo>(newzone, dBAccountInfos[0]);
                }
                else
                {
                    await Game.Scene.GetComponent<DBComponent>().Save<DBAccountInfo>(newzone, entity);
                }
            }

            //DBDayActivityInfo  活动相关也要特殊处理
            List<DBDayActivityInfo> dBDayActivityInfos_old = await Game.Scene.GetComponent<DBComponent>().Query<DBDayActivityInfo>(oldzone, d => d.Id > 0);
            List<DBDayActivityInfo> dBDayActivityInfos_new = await Game.Scene.GetComponent<DBComponent>().Query<DBDayActivityInfo>(newzone, d => d.Id > 0);
            foreach (var entity in dBDayActivityInfos_new)
            {
                if (entity.Id != newzone)
                {
                    continue;
                }
                entity.ZhanQuReveives.AddRange(dBDayActivityInfos_old[0].ZhanQuReveives);
                await Game.Scene.GetComponent<DBComponent>().Save<DBDayActivityInfo>(newzone, entity);
            }

            //DBFriendInfo
            dbcount = 0;
            List<DBFriendInfo> dBFriendInfos = await Game.Scene.GetComponent<DBComponent>().Query<DBFriendInfo>(oldzone, d => d.Id > 0);
            foreach (var entity in dBFriendInfos)
            {
                dbcount++;
                if (dbcount % onecount == 0)
                {
                    await TimerComponent.Instance.WaitFrameAsync();
                }
                await Game.Scene.GetComponent<DBComponent>().Save<DBFriendInfo>(newzone, entity);
            }
            Log.Debug("DBFriendInfo Complelte");

            //DBMailInfo 邮件
            dbcount = 0;
            List<DBMailInfo> dBMailInfos = await Game.Scene.GetComponent<DBComponent>().Query<DBMailInfo>(oldzone, d => d.Id > 0);
            foreach (var entity in dBMailInfos)
            {
                dbcount++;
                if (dbcount % onecount == 0)
                {
                    await TimerComponent.Instance.WaitFrameAsync();
                }
                await Game.Scene.GetComponent<DBComponent>().Save<DBMailInfo>(newzone, entity);
            }

            //DBPaiMainInfo 拍卖，也合并过来，要着重测试
            List<DBPaiMainInfo> dBPaiMainInfos_old = await Game.Scene.GetComponent<DBComponent>().Query<DBPaiMainInfo>(oldzone, d => d.Id > 0);
            List<DBPaiMainInfo> dBPaiMainInfos_new = await Game.Scene.GetComponent<DBComponent>().Query<DBPaiMainInfo>(newzone, d => d.Id > 0);
            foreach (var entity in dBPaiMainInfos_new)
            {
                if (entity.Id != newzone)
                {
                    continue;
                }
                entity.PaiMaiItemInfos.AddRange(dBPaiMainInfos_old[0].PaiMaiItemInfos);
                await Game.Scene.GetComponent<DBComponent>().Save<DBPaiMainInfo>(newzone, entity);
            }

            //DBRankInfo 排行榜  。 
            List<DBRankInfo> dBRankInfos_old = await Game.Scene.GetComponent<DBComponent>().Query<DBRankInfo>(oldzone, d => d.Id > 0);
            List<DBRankInfo> dBRankInfos_new = await Game.Scene.GetComponent<DBComponent>().Query<DBRankInfo>(newzone, d => d.Id > 0);
            foreach (var entity in dBRankInfos_new)
            {
                if (entity.Id != newzone)
                {
                    continue;
                }

                List<RankingInfo> rankingInfos_new = entity.rankingInfos;
                List<RankingInfo> rankingInfos_old = dBRankInfos_old[0].rankingInfos;
                rankingInfos_new.AddRange(rankingInfos_old);
                rankingInfos_new.Sort(delegate (RankingInfo a, RankingInfo b)
                {
                    return (int)b.Combat - (int)a.Combat;
                });
                int maxnumber = Math.Min(500, rankingInfos_new.Count);
                entity.rankingInfos = rankingInfos_new.GetRange(0, maxnumber);
                
                //阵营相关的都要重置
                await Game.Scene.GetComponent<DBComponent>().Save<DBRankInfo>(newzone, entity);
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
                await Game.Scene.GetComponent<DBComponent>().Save<DBServerInfo>(newzone, entity);
            }

            //EnergyComponent 正能量组件
            dbcount = 0;
            List<EnergyComponent> db_energyComponents = await Game.Scene.GetComponent<DBComponent>().Query<EnergyComponent>(oldzone, d => d.Id > 0);
            foreach (var entity in db_energyComponents)
            {
                dbcount++;
                if (dbcount % onecount == 0)
                {
                    await TimerComponent.Instance.WaitFrameAsync();
                }
                await Game.Scene.GetComponent<DBComponent>().Save<EnergyComponent>(newzone, entity);
            }

            //NumericComponent  数值组件
            dbcount = 0;
            List<NumericComponent> numericComponents = await Game.Scene.GetComponent<DBComponent>().Query<NumericComponent>(oldzone, d => d.Id > 0);
            foreach (var entity in numericComponents)
            {
                dbcount++;
                if (dbcount % onecount == 0)
                {
                    await TimerComponent.Instance.WaitFrameAsync();
                }
                await Game.Scene.GetComponent<DBComponent>().Save<NumericComponent>(newzone, entity);
            }

            //PetComponent  宠物组件
            dbcount = 0;
            List<PetComponent> petComponents = await Game.Scene.GetComponent<DBComponent>().Query<PetComponent>(oldzone, d => d.Id > 0);
            foreach (var entity in petComponents)
            {
                dbcount++;
                if (dbcount % onecount == 0)
                {
                    await TimerComponent.Instance.WaitFrameAsync();
                }
                await Game.Scene.GetComponent<DBComponent>().Save<PetComponent>(newzone, entity);
            }

            //RechargeComponent  充值记录组件
            dbcount = 0;
            List<RechargeComponent> rechargeComponents = await Game.Scene.GetComponent<DBComponent>().Query<RechargeComponent>(oldzone, d => d.Id > 0);
            foreach (var entity in rechargeComponents)
            {
                dbcount++;
                if (dbcount % onecount == 0)
                {
                    await TimerComponent.Instance.WaitFrameAsync();
                }
                await Game.Scene.GetComponent<DBComponent>().Save<RechargeComponent>(newzone, entity);
            }

            //ReddotComponent  红点组件
            dbcount = 0;
            List<ReddotComponent> reddotComponents = await Game.Scene.GetComponent<DBComponent>().Query<ReddotComponent>(oldzone, d => d.Id > 0);
            foreach (var entity in reddotComponents)
            {
                dbcount++;
                if (dbcount % onecount == 0)
                {
                    await TimerComponent.Instance.WaitFrameAsync();
                }
                await Game.Scene.GetComponent<DBComponent>().Save<ReddotComponent>(newzone, entity);
            }

            //ShoujiComponent  收集大厅
            dbcount = 0;
            List<ShoujiComponent> shoujiComponents = await Game.Scene.GetComponent<DBComponent>().Query<ShoujiComponent>(oldzone, d => d.Id > 0);
            foreach (var entity in shoujiComponents)
            {
                dbcount++;
                if (dbcount % onecount == 0)
                {
                    await TimerComponent.Instance.WaitFrameAsync();
                }
                await Game.Scene.GetComponent<DBComponent>().Save<ShoujiComponent>(newzone, entity);
            }

            //SkillSetComponent  技能
            dbcount = 0;
            List<SkillSetComponent> skillSetComponents = await Game.Scene.GetComponent<DBComponent>().Query<SkillSetComponent>(oldzone, d => d.Id > 0);
            foreach (var entity in skillSetComponents)
            {
                dbcount++;
                if (dbcount % onecount == 0)
                {
                    await TimerComponent.Instance.WaitFrameAsync();
                }
                await Game.Scene.GetComponent<DBComponent>().Save<SkillSetComponent>(newzone, entity);
            }
            Log.Console("SkillSetComponent Complelte");

            //TaskComponent  renw组件
            dbcount = 0;
            List<TaskComponent> taskComponents = await Game.Scene.GetComponent<DBComponent>().Query<TaskComponent>(oldzone, d => d.Id > 0);
            foreach (var entity in taskComponents)
            {
                dbcount++;
                if (dbcount % onecount == 0)
                {
                    await TimerComponent.Instance.WaitFrameAsync();
                }
                await Game.Scene.GetComponent<DBComponent>().Save<TaskComponent>(newzone, entity);
            }
            Log.Console("TaskComponent Complelte");

            //UserInfoComponent  玩家信息
            dbcount = 0;

            Dictionary<string, UserInfoComponent> newuserinfoList = new Dictionary<string, UserInfoComponent>();
            //先初始化新的玩家列表
            List<UserInfoComponent> newuserInfoComponents = await Game.Scene.GetComponent<DBComponent>().Query<UserInfoComponent>(newzone, d => d.Id > 0);
            foreach (var entity in newuserInfoComponents)
            {
                if (!newuserinfoList.ContainsKey(entity.UserInfo.Name))
                {
                    newuserinfoList.Add(entity.UserInfo.Name, entity);
                }
            }

            List<UserInfoComponent> olduserInfoComponents = await Game.Scene.GetComponent<DBComponent>().Query<UserInfoComponent>(oldzone, d => d.Id > 0);
            foreach (var oldentity in olduserInfoComponents)
            {
                dbcount++;
                if (dbcount % onecount == 0)
                {
                    await TimerComponent.Instance.WaitFrameAsync();
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
                        await Game.Scene.GetComponent<DBComponent>().Save<UserInfoComponent>(newzone, newentity);
                    }
                    else
                    {
                        renameId = oldentity.Id;
                        oldentity.UserInfo.Name += oldzone.ToString();
                    }

                    List<DBMailInfo> renamedBMailInfos = await Game.Scene.GetComponent<DBComponent>().Query<DBMailInfo>(oldzone, d => d.Id  == renameId);
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

                        await Game.Scene.GetComponent<DBComponent>().Save<DBMailInfo>(newzone, renamedBMailInfos[0]);
                    }
                }
                await Game.Scene.GetComponent<DBComponent>().Save<UserInfoComponent>(newzone, oldentity);
            }

            dbcount = 0;
            List<TitleComponent> titleComponents = await Game.Scene.GetComponent<DBComponent>().Query<TitleComponent>(oldzone, d => d.Id > 0);
            foreach (var entity in titleComponents)
            {
                dbcount++;
                if (dbcount % onecount == 0)
                {
                    await TimerComponent.Instance.WaitFrameAsync();
                }
                await Game.Scene.GetComponent<DBComponent>().Save<TitleComponent>(newzone, entity);
            }

            dbcount = 0;
            List<JiaYuanComponent> jiayuanComponents = await Game.Scene.GetComponent<DBComponent>().Query<JiaYuanComponent>(oldzone, d => d.Id > 0);
            foreach (var entity in jiayuanComponents)
            {
                dbcount++;
                if (dbcount % onecount == 0)
                {
                    await TimerComponent.Instance.WaitFrameAsync();
                }
                await Game.Scene.GetComponent<DBComponent>().Save<JiaYuanComponent>(newzone, entity);
            }
            Log.Console("JiaYuanComponent Complelte");

            dbcount = 0;
            List<DBPopularizeInfo> dBPopularizeInfos = await Game.Scene.GetComponent<DBComponent>().Query<DBPopularizeInfo>(oldzone, d => d.Id > 0);
            foreach (var entity in dBPopularizeInfos)
            {
                dbcount++;
                if (dbcount % onecount == 0)
                {
                    await TimerComponent.Instance.WaitFrameAsync();
                }
                await Game.Scene.GetComponent<DBComponent>().Save<DBPopularizeInfo>(newzone, entity);
            }
            System.Console.WriteLine("DBPopularizeInfo Complelte");
        }
    }
}
