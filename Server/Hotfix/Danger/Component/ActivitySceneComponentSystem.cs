using System;
using System.Collections.Generic;

namespace ET
{

    [Timer(TimerType.ActivitySceneTimer)]
    public class ActivitySceneTimer : ATimer<ActivitySceneComponent>
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

    [Timer(TimerType.ActivityTipTimer)]
    public class ActivityTipTimer : ATimer<ActivitySceneComponent>
    {
        public override void Run(ActivitySceneComponent self)
        {
            try
            {
                self.OnCheckFuntionButton().Coroutine();
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
            self.MapIdList.Add(DBHelper.GetUnionServerId(self.DomainZone()));
            self.MapIdList.Add(DBHelper.GetSoloServerId(self.DomainZone()));
            self.MapIdList.Add(DBHelper.GetDbCacheId(self.DomainZone()));
            self.InitDayActivity().Coroutine();
            self.InitFunctionButton().Coroutine();
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
                self.NoticeActivityUpdate_Hour(dateTime).Coroutine();
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
            await ETTask.CompletedTask;
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
            LogHelper.LogDebug($"InitDayActivity: {zone}  {openServerDay}");
            if (self.DBDayActivityInfo.WeeklyTask == 0)
            {
                self.DBDayActivityInfo.WeeklyTask = TaskHelp.GetWeeklyTaskId();
            }
            self.DBDayActivityInfo.MysteryItemInfos =  MysteryShopHelper.InitMysteryItemInfos( openServerDay);
            self.SaveDB();

            //每日活动
            self.Timer = TimerComponent.Instance.NewRepeatedTimer(TimeHelper.Minute + self.DomainZone() * 100, TimerType.ActivitySceneTimer, self);
        }

        public static async ETTask OnCheckFuntionButton(this ActivitySceneComponent self)
        {
            await ETTask.CompletedTask;
            if (self.ActivityTimerList.Count > 0)
            {
                int functionId = self.ActivityTimerList[0].FunctionId;
                switch (functionId)
                {
                    case 1052:
                        long rankserverid = DBHelper.GetRankServerId(self.DomainZone());
                        ////开始//结束
                        A2A_ActivityUpdateResponse m2m_TrasferUnitResponse = (A2A_ActivityUpdateResponse)await ActorMessageSenderComponent.Instance.Call
                                     (rankserverid, new A2A_ActivityUpdateRequest() { Hour = -1, FunctionId = functionId, FunctionType = self.ActivityTimerList[0].FunctionType  });
                        break;
                    default:
                        break;
                }
                self.ActivityTimerList.RemoveAt(0);
            }

            TimerComponent.Instance.Remove(ref self.ActivityTimer);
            if (self.ActivityTimerList.Count > 0)
            {
                self.ActivityTimer = TimerComponent.Instance.NewOnceTimer(self.ActivityTimerList[0].BeginTime, TimerType.ActivityTipTimer, self);
            }
        }

        public static async ETTask InitFunctionButton(this ActivitySceneComponent self)
        {
            self.ActivityTimerList.Clear();    

            long serverTime = TimeHelper.ServerNow();
            DateTime dateTime = TimeInfo.Instance.ToDateTime(serverTime);
            long curTime = (dateTime.Hour * 60 + dateTime.Minute) * 60 + dateTime.Second;
            List<int> functonIds = new List<int>() { 1052 };
            for (int i = 0; i < functonIds.Count; i++)
            {
                long startTime = FunctionHelp.GetOpenTime(functonIds[i]);
                long endTime = FunctionHelp.GetCloseTime(functonIds[i]);

    
                if (curTime < startTime)
                {
                    long sTime = serverTime + (startTime - curTime) * 1000;
                    self.ActivityTimerList.Add(new ActivityTimer() { FunctionId = functonIds[i],  BeginTime = sTime, FunctionType = 1 });
                }
                if (curTime < endTime)
                {
                    long sTime = serverTime + (endTime - curTime) * 1000;
                    self.ActivityTimerList.Add(new ActivityTimer() { FunctionId = functonIds[i], BeginTime = sTime, FunctionType = 2 });
                }
                bool inTime = curTime >= startTime && curTime <= endTime;
                if (inTime && functonIds[i] == 1052)
                {
                    ////开始
                    long rankserverid = DBHelper.GetRankServerId(self.DomainZone());
                    A2A_ActivityUpdateResponse m2m_TrasferUnitResponse = (A2A_ActivityUpdateResponse)await ActorMessageSenderComponent.Instance.Call
                                 (rankserverid, new A2A_ActivityUpdateRequest() { Hour = -1, FunctionId = 1052, FunctionType = 1 });
                }
            }

            if (self.ActivityTimerList.Count > 0)
            {
                self.ActivityTimerList.Sort(delegate (ActivityTimer a, ActivityTimer b)
                {
                    return (int)(a.BeginTime - b.BeginTime);
                });

                self.ActivityTimer = TimerComponent.Instance.NewOnceTimer(self.ActivityTimerList[0].BeginTime, TimerType.ActivityTipTimer, self);
            }
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

        public static async ETTask NoticeActivityUpdate_Hour(this ActivitySceneComponent self, DateTime dateTime)
        {
            DayOfWeek dayOfWeek = dateTime.DayOfWeek;
            //int yeardate = dateTime.Year * 10000 + dateTime.Month * 100 + dateTime.Day;  //20230412
            int hour = dateTime.Hour;
            int openServerDay =  DBHelper.GetOpenServerDay(self.DomainZone());
            LogHelper.LogWarning($"NoticeActivityUpdate_Hour: zone: {self.DomainZone()} openday: {openServerDay}  {hour}", true);
            for (int i = 0; i < self.MapIdList.Count; i++)
            {
                A2A_ActivityUpdateResponse m2m_TrasferUnitResponse = (A2A_ActivityUpdateResponse)await ActorMessageSenderComponent.Instance.Call
                        (self.MapIdList[i], new A2A_ActivityUpdateRequest() { Hour = hour, OpenDay = openServerDay });
            }

            if (hour == 0)
            {
                LogHelper.LogWarning($"神秘商品刷新: {self.DomainZone()}", true);
                self.DBDayActivityInfo.MysteryItemInfos = MysteryShopHelper.InitMysteryItemInfos(openServerDay);
                self.InitFunctionButton().Coroutine();
            }
            if (hour == 0 && self.DomainZone() == 3) //通知中心服
            {
                long centerid = DBHelper.GetAccountCenter();
                A2A_ActivityUpdateResponse m2m_TrasferUnitResponse = (A2A_ActivityUpdateResponse)await ActorMessageSenderComponent.Instance.Call
                             (centerid, new A2A_ActivityUpdateRequest() { Hour = 0 });
            }
            if (hour == 0 && dayOfWeek == DayOfWeek.Monday)
            {
                self.DBDayActivityInfo.WeeklyTask = TaskHelp.GetWeeklyTaskId();
            }
            if (self.DomainZone() == 3)
            {
                Log.Warning("刷新机器人！！");
                long robotSceneId = StartSceneConfigCategory.Instance.GetBySceneName(203, "Robot01").InstanceId;
                MessageHelper.SendActor(robotSceneId, new G2Robot_MessageRequest() { Zone = self.DomainZone(), MessageType = NoticeType.CreateRobot });
            }
        }
    }
}
