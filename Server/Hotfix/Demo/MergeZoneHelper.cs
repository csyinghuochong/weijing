using System.Collections.Generic;

namespace ET
{

    //合区
    public static class MergeZoneHelper
    {

        public static async ETTask QueryRecharge()
        {
            var startZoneConfig = StartZoneConfigCategory.Instance.Get(202);
            Game.Scene.GetComponent<DBComponent>().InitDatabase(startZoneConfig);
            int number = 0;
            List<DBCenterAccountInfo> dBAccountInfos_new = await Game.Scene.GetComponent<DBComponent>().Query<DBCenterAccountInfo>(202, d => d.Id > 0);
            foreach (var entity in dBAccountInfos_new)
            {
                for (int i = 0; i < entity.PlayerInfo.RechargeInfos.Count;i++)
                {
                    number += entity.PlayerInfo.RechargeInfos[i].Amount;
                }
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
            Log.Debug("ActivityComponent Complelte");

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
            Log.Debug("ChengJiuComponent Complelte");

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
            Log.Debug("DBAccountInfo Complelte");

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
            Log.Debug("DBMailInfo Complelte");

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
                entity.rankingInfos = rankingInfos_new.GetRange(0, rankingInfos_new.Count > ComHelp.RankNumber ? ComHelp.RankNumber : rankingInfos_new.Count);
                
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
            Log.Debug("EnergyComponent Complelte");

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
            Log.Debug("NumericComponent Complelte");

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
            Log.Debug("PetComponent Complelte");

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
            Log.Debug("RechargeComponent Complelte");

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
            Log.Debug("ReddotComponent Complelte");

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
            Log.Debug("ShoujiComponent Complelte");

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
            Log.Debug("SkillSetComponent Complelte");

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
            Log.Debug("TaskComponent Complelte");

            //UserInfoComponent  玩家信息
            dbcount = 0;
            List<UserInfoComponent> userInfoComponents = await Game.Scene.GetComponent<DBComponent>().Query<UserInfoComponent>(oldzone, d => d.Id > 0);
            foreach (var entity in userInfoComponents)
            {
                dbcount++;
                if (dbcount % onecount == 0)
                {
                    await TimerComponent.Instance.WaitFrameAsync();
                }
                await Game.Scene.GetComponent<DBComponent>().Save<UserInfoComponent>(newzone, entity);
            }
            Log.Debug("UserInfoComponent Complelte");
        }
    }
}
