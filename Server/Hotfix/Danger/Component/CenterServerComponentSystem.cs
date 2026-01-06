using System;
using System.Collections.Generic;
using System.Linq;

namespace ET
{

    [ObjectSystem]
    public class CenterSceneComponentSystemAwakeSystem : AwakeSystem<CenterServerComponent>
    {
        public override void Awake(CenterServerComponent self)
        {
            self.UpdateServerInfo().Coroutine();
        }
    }

    public static class CenterServerComponentSystem
    {
        public static async ETTask UpdateServerInfo(this CenterServerComponent self)
        {
            DBCenterServerInfo dBServerInfo = null;
            List<DBCenterServerInfo> result = await Game.Scene.GetComponent<DBComponent>().Query<DBCenterServerInfo>(self.DomainZone(), d => d.Id == self.DomainZone());
            if (result.Count == 0)
            {
                dBServerInfo = new DBCenterServerInfo();
                dBServerInfo.Id = self.DomainZone();
            }
            else
            {
                dBServerInfo = result[0];
            }

            if (dBServerInfo.V1ActivityList.Count == 0)
            {
                dBServerInfo.V1ActivityList = ActivityConfigHelper.RandomGenerateActivityList(0);
            }
            await Game.Scene.GetComponent<DBComponent>().Save(self.DomainZone(), dBServerInfo);

            await self.BroadcastActivityList(dBServerInfo);
        }

        public static async ETTask BroadcastActivityList(this CenterServerComponent self, DBCenterServerInfo dBServerInfo)
        {
            await TimerComponent.Instance.WaitAsync(TimeHelper.Second);

            Console.WriteLine($"BroadcastActivityList.WeeklyIndex:{dBServerInfo.WeeklyIndex}");

            List<StartProcessConfig> listprogress = StartProcessConfigCategory.Instance.GetAll().Values.ToList();
            for (int i = 0; i < listprogress.Count; i++)
            {
                List<StartSceneConfig> processScenes = StartSceneConfigCategory.Instance.GetByProcess(listprogress[i].Id);
                if (processScenes.Count == 0 || listprogress[i].Id == 203)  //机器人进程
                {
                    continue;
                }

                StartSceneConfig startSceneConfig = processScenes[0];
                long mapInstanceId = StartSceneConfigCategory.Instance.GetBySceneName(startSceneConfig.Zone, startSceneConfig.Name).InstanceId;
                A2R_Broadcast createUnit = (A2R_Broadcast)await ActorMessageSenderComponent.Instance.Call(
                    mapInstanceId, new R2A_Broadcast() { LoadType = 3, V1ActivityList = dBServerInfo.V1ActivityList });
            }
        }

        public static async ETTask UpdateWeeklyIndex(this CenterServerComponent self, System.DateTime dateTime)
        {
            List<DBCenterServerInfo> result = await Game.Scene.GetComponent<DBComponent>().Query<DBCenterServerInfo>(self.DomainZone(), d => d.Id == self.DomainZone());
            if (result.Count == 0)
            {
                return;
            }
            DBCenterServerInfo dBServerInfo = result[0];

            //每周刷新一次
            if (dateTime.DayOfWeek == System.DayOfWeek.Monday || dBServerInfo.V1ActivityList.Count == 0)
            {
                Console.WriteLine($"RandomGenerateActivityList.WeeklyIndex++:{dBServerInfo.WeeklyIndex}");
                dBServerInfo.WeeklyIndex++;
                if (dBServerInfo.WeeklyIndex >= 4)
                {
                    dBServerInfo.WeeklyIndex = 0;
                }

                dBServerInfo.V1ActivityList = ActivityConfigHelper.RandomGenerateActivityList(dBServerInfo.WeeklyIndex);
            }

            await Game.Scene.GetComponent<DBComponent>().Save(self.DomainZone(), dBServerInfo);
            await self.BroadcastActivityList(dBServerInfo);
        }

    }
}
