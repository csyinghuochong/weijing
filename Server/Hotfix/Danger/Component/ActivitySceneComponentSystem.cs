using System;

namespace ET
{

    [Timer(TimerType.ActivityTimer)]
    public class ActivityTimer : ATimer<ActivitySceneComponent>
    {
        public override void Run(ActivitySceneComponent self)
        {
            try
            {
                self.OnCheck();
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
    public class ActivitySceneComponentAwakeSystem : AwakeSystem<ActivitySceneComponent>
    {
        public override void Awake(ActivitySceneComponent self)
        {
            self.MapIdList.Clear();
;
            self.MapIdList.Add(StartSceneConfigCategory.Instance.GetBySceneName(self.DomainZone(), "Gate1").InstanceId);
            self.MapIdList.Add(StartSceneConfigCategory.Instance.GetBySceneName(self.DomainZone(), "PaiMai").InstanceId);
            self.MapIdList.Add(StartSceneConfigCategory.Instance.GetBySceneName(self.DomainZone(), "Rank").InstanceId);

            self.InitDayActivity().Coroutine();

            //每日活动
            self.Timer = TimerComponent.Instance.NewRepeatedTimer(60000, TimerType.ActivityTimer, self);
        }
    }

    [ObjectSystem]
    public class ActivitySceneComponentDestroySystem : DestroySystem<ActivitySceneComponent>
    {

        public override void Destroy(ActivitySceneComponent self)
        {
            TimerComponent.Instance.Remove(ref self.Timer);
        }
    }

    public static class ActivitySceneComponentSystem
    {
        public static void OnCheck(this ActivitySceneComponent self)
        {
            DateTime dateTime = TimeHelper.DateTimeNow();
  
            if (self.DBDayActivityInfo.Day != dateTime.Day)
            {
                self.DBDayActivityInfo.Day = dateTime.Day;
                self.NoticeActivityUpdate_Day().Coroutine();
            }
            if (self.DBDayActivityInfo.LastHour != dateTime.Hour)
            {
                self.DBDayActivityInfo.LastHour = dateTime.Hour;
                self.NoticeActivityUpdate_Hour(dateTime.Hour).Coroutine();
            }
            self.SaveDB().Coroutine();
        }

        public static async ETTask InitDayActivity(this ActivitySceneComponent self)
        {
            int zone = self.DomainZone();
            long dbCacheId = DBHelper.GetDbCacheId(zone);
            long openServerTime = await DBHelper.GetOpenServerTime(zone);
            D2G_GetComponent d2GGetUnit = (D2G_GetComponent)await ActorMessageSenderComponent.Instance.Call(dbCacheId, new G2D_GetComponent() { CharacterId = self.DomainZone(), Component = DBHelper.DBDayActivityInfo });
            if (d2GGetUnit.Component == null)
            {
                self.DBDayActivityInfo = new DBDayActivityInfo();
                self.DBDayActivityInfo.Id = self.DomainZone();
            }
            else
            {
                self.DBDayActivityInfo = d2GGetUnit.Component as DBDayActivityInfo;
                self.DBDayActivityInfo.Id = self.DomainZone();
            }
          
            self.DBDayActivityInfo.MysteryItemInfos = self.DBDayActivityInfo.MysteryItemInfos.Count == 0 ? MysteryShopHelper.InitMysteryItemInfos(self.DomainScene(), openServerTime) : self.DBDayActivityInfo.MysteryItemInfos;
            self.DBDayActivityInfo.Day = TimeHelper.DateTimeNow().Day;
            self.SaveDB().Coroutine();
        }

        public static async ETTask SaveDB(this ActivitySceneComponent self)
        {
            long dbCacheId = DBHelper.GetDbCacheId(self.DomainZone());
            D2M_SaveComponent d2GSave = (D2M_SaveComponent)await ActorMessageSenderComponent.Instance.Call(dbCacheId, new M2D_SaveComponent() { CharacterId = self.DomainZone(), Component = self.DBDayActivityInfo, ComponentType = DBHelper.DBDayActivityInfo });
        }

        public static int OnMysteryBuyRequest(this ActivitySceneComponent self, MysteryItemInfo mysteryInfo)
        {

            for (int i = 0; i < self.DBDayActivityInfo.MysteryItemInfos.Count; i++)
            {
                MysteryItemInfo mysteryItemInfo1 = self.DBDayActivityInfo.MysteryItemInfos[i];

                if (mysteryItemInfo1.ItemID != mysteryInfo.ItemID)
                {
                    continue;
                }
                if (mysteryItemInfo1.ItemNumber < mysteryInfo.ItemNumber)
                {
                    return ErrorCore.ERR_ItemNotEnoughError;
                }

                mysteryItemInfo1.ItemNumber -= mysteryInfo.ItemNumber;
                break;
            }

            return ErrorCore.ERR_Success;
        }

        public static async ETTask NoticeActivityUpdate_Hour(this ActivitySceneComponent self, int hour)
        {
            for (int i = 0; i < self.MapIdList.Count; i++)
            {
                M2A_ActivityUpdateResponse m2m_TrasferUnitResponse = (M2A_ActivityUpdateResponse)await ActorMessageSenderComponent.Instance.Call
                        (self.MapIdList[i], new A2M_ActivityUpdateRequest() { ActivityType = hour });
            }
        }

        /// <summary> 
        /// 零點刷新通知
        /// </summary>
        /// <param name="self"></param>
        /// <returns></returns>
        public static async ETTask NoticeActivityUpdate_Day(this ActivitySceneComponent self)
        {
            long openServerTime = await DBHelper.GetOpenServerTime(self.DomainZone());
            for (int i = 0; i < self.MapIdList.Count; i++)
            {
                M2A_ActivityUpdateResponse m2m_TrasferUnitResponse = (M2A_ActivityUpdateResponse)await ActorMessageSenderComponent.Instance.Call
                        (self.MapIdList[i], new A2M_ActivityUpdateRequest() { ActivityType = 0 });
            }
            self.DBDayActivityInfo.MysteryItemInfos = MysteryShopHelper.InitMysteryItemInfos(self.DomainScene(), openServerTime);
        }

    }
}
