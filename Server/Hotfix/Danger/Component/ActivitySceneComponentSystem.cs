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
            self.OnBattleOpen = false;
            self.OnBattleClose = false;
            self.MapIdList.Clear();
            self.MapIdList.Add(DBHelper.GetGateServerId(self.DomainZone()));
            self.MapIdList.Add(DBHelper.GetPaiMaiServerId(self.DomainZone()));
            self.MapIdList.Add(DBHelper.GetRankServerId(self.DomainZone()));
            self.MapIdList.Add(DBHelper.GetFubenCenterId(self.DomainZone()));

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
            if (!self.OnBattleOpen)
            {
                int openTime = FunctionHelp.GetOpenTime(1025);
                int curMinte = dateTime.Hour * 60 + dateTime.Minute;
                if (curMinte == openTime - 1)
                {
                    self.OnBattleOpen();
                }
            }
            if (!self.OnBattleClose)
            {
                int closeTime = FunctionHelp.GetCloseTime(1025);
                int curMinte = dateTime.Hour * 60 + dateTime.Minute;
                if (curMinte == closeTime - 1)
                {
                    self.OnBattleClose();
                }
            }
            self.SaveDB();
        }

        public static void  OnBattleOpen(this ActivitySceneComponent self)
        {
            self.OnBattleOpen = true;
            self.OnBattleClose = false;

            if (DBHelper.GetOpenServerDay(self.DomainZone()) > 0)
            {
                long robotSceneId = StartSceneConfigCategory.Instance.GetBySceneName(203, "Robot01").InstanceId;
                MessageHelper.SendActor(robotSceneId, new G2Robot_MessageRequest() { Zone = self.DomainZone(), MessageType = NoticeType.BattleOpen });
            }
        }

        public static  void OnBattleClose(this ActivitySceneComponent self)
        {
            self.OnBattleClose = true;
            self.OnBattleOpen = false;

            long robotSceneId = StartSceneConfigCategory.Instance.GetBySceneName(203, "Robot01").InstanceId;
            MessageHelper.SendActor(robotSceneId, new G2Robot_MessageRequest() { Zone = self.DomainZone(), MessageType = NoticeType.BattleOver });

            ServerMessageHelper.SendServerMessage(DBHelper.GetBattleServerId(self.DomainZone()),
               NoticeType.BattleOver, "战场即将关闭。请退出战场").Coroutine();
        }

        public static async ETTask InitDayActivity(this ActivitySceneComponent self)
        {
            int zone = self.DomainZone();
            long dbCacheId = DBHelper.GetDbCacheId(zone);
            await TimerComponent.Instance.WaitAsync(zone * 100);
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
            self.Timer = TimerComponent.Instance.NewRepeatedTimer(30000, TimerType.ActivityTimer, self);
        }

        public static  void SaveDB(this ActivitySceneComponent self)
        {
            DBHelper.SaveUnitComponentCache(self.DomainZone(), self.DomainZone(), self.DBDayActivityInfo).Coroutine();
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
                self.OnBattleOpen = false;
                self.OnBattleClose = false;
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
