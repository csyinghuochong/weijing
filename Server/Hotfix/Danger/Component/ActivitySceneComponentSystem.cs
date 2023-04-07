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
            self.MapIdList.Add(DBHelper.GetGateServerId(self.DomainZone()));
            self.MapIdList.Add(DBHelper.GetPaiMaiServerId(self.DomainZone()));
            self.MapIdList.Add(DBHelper.GetRankServerId(self.DomainZone()));
            self.MapIdList.Add(DBHelper.GetFubenCenterId(self.DomainZone()));
            self.MapIdList.Add(DBHelper.GetArenaServerId(self.DomainZone()));
            self.MapIdList.Add(DBHelper.GetBattleServerId(self.DomainZone()));

            self.InitDayActivity().Coroutine();
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
  
            if (self.DBDayActivityInfo.LastHour != dateTime.Hour)
            {
                self.DBDayActivityInfo.LastHour = dateTime.Hour;
                self.NoticeActivityUpdate_Hour(dateTime.DayOfWeek, dateTime.Hour).Coroutine();
            }

            if (self.DomainZone() == 3 && dateTime.Hour == 12) //通知中心服
            {
                self.TeamUpdateHandler().Coroutine();
            }

            self.SaveDB();
        }

        public static async ETTask TeamUpdateHandler(this ActivitySceneComponent self)
        { 
            DateTime dateTime = TimeHelper.DateTimeNow();

            //if (dateTime.Hour == 16 && (dateTime.Minute == 20 || dateTime.Minute == 21))
            //{
            //    Log.Debug($"更新世界等级: {self.DomainZone()}");
            //    A2A_ActivityUpdateResponse m2m_TrasferUnitResponse = (A2A_ActivityUpdateResponse)await ActorMessageSenderComponent.Instance.Call
            //             (DBHelper.GetRankServerId(self.DomainZone()), new A2A_ActivityUpdateRequest() { ActivityType = 12, OpenDay = 1 });
            //}

            //通知中心刷新序列号
            long centerid = DBHelper.GetAccountCenter();
            A2A_ActivityUpdateResponse m2m_TrasferUnitResponse = (A2A_ActivityUpdateResponse)await ActorMessageSenderComponent.Instance.Call
                         (centerid, new A2A_ActivityUpdateRequest() { ActivityType = 0 });
        }

        public static async ETTask InitDayActivity(this ActivitySceneComponent self)
        {
            int zone = self.DomainZone();
            long dbCacheId = DBHelper.GetDbCacheId(zone);
            await TimerComponent.Instance.WaitAsync(zone * 200);
            D2G_GetComponent d2GGetUnit = (D2G_GetComponent)await ActorMessageSenderComponent.Instance.Call(dbCacheId, new G2D_GetComponent() { UnitId = self.DomainZone(), Component = DBHelper.DBDayActivityInfo });
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
            int openServerDay = DBHelper.GetOpenServerDay(zone);
            Log.Debug($" openserverDay_1 {zone}  {openServerDay}");
            if (self.DBDayActivityInfo.WeeklyTask == 0)
            {
                self.DBDayActivityInfo.WeeklyTask = TaskHelp.GetWeeklyTaskId();
            }
            self.DBDayActivityInfo.MysteryItemInfos =  MysteryShopHelper.InitMysteryItemInfos( openServerDay);
            self.SaveDB();

            //每日活动
            self.Timer = TimerComponent.Instance.NewRepeatedTimer(TimeHelper.Minute * 4 + self.DomainZone() * 600, TimerType.ActivityTimer, self);
        }

        public static  void SaveDB(this ActivitySceneComponent self)
        {
            DBHelper.SaveComponent(self.DomainZone(), self.DomainZone(), self.DBDayActivityInfo).Coroutine();
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
                return ErrorCore.ERR_Success;
            }
            return ErrorCore.ERR_ItemNotEnoughError;
        }

        public static async ETTask NoticeActivityUpdate_Hour(this ActivitySceneComponent self, DayOfWeek dayOfWeek, int hour)
        {
            int openServerDay =  DBHelper.GetOpenServerDay(self.DomainZone());
            for (int i = 0; i < self.MapIdList.Count; i++)
            {
                A2A_ActivityUpdateResponse m2m_TrasferUnitResponse = (A2A_ActivityUpdateResponse)await ActorMessageSenderComponent.Instance.Call
                        (self.MapIdList[i], new A2A_ActivityUpdateRequest() { ActivityType = hour, OpenDay = openServerDay });
            }

            if (hour == 0)
            {
                Log.Debug($"神秘商品刷新: {self.DomainZone()}");
                self.DBDayActivityInfo.MysteryItemInfos = MysteryShopHelper.InitMysteryItemInfos(openServerDay);
            }
            if (hour == 0 && dayOfWeek == DayOfWeek.Monday)
            {
                self.DBDayActivityInfo.WeeklyTask = TaskHelp.GetWeeklyTaskId();
            }
        }
    }
}
