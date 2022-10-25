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
;
            self.MapIdList.Add(StartSceneConfigCategory.Instance.GetBySceneName(self.DomainZone(), "Gate1").InstanceId);
            self.MapIdList.Add(StartSceneConfigCategory.Instance.GetBySceneName(self.DomainZone(), "PaiMai").InstanceId);
            self.MapIdList.Add(StartSceneConfigCategory.Instance.GetBySceneName(self.DomainZone(), "Rank").InstanceId);

            self.InitDayActivity().Coroutine();

            //每日活动
            self.Timer = TimerComponent.Instance.NewRepeatedTimer(30000, TimerType.ActivityTimer, self);
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
                self.NoticeActivityUpdate_Hour(dateTime.Hour).Coroutine();
            }
            if (!self.OnBattleOpen && dateTime.Hour == 12 && dateTime.Minute == 38)
            {
                self.OnBattleOpen();
            }
            if (!self.OnBattleClose && dateTime.Hour == 12 && dateTime.Minute == 40)
            {
                self.OnBattleClose().Coroutine();
            }

            self.SaveDB().Coroutine();
        }

        public static void OnBattleOpen(this ActivitySceneComponent self)
        {
            self.OnBattleOpen = true;
            ServerMessageHelper.SendServerMessage(DBHelper.GetChatServerId(self.DomainZone()), 
               NoticeType.BattleOpen, "战场已开启。请前往战场").Coroutine();
        }

        public static  async ETTask OnBattleClose(this ActivitySceneComponent self)
        {
            self.OnBattleClose = true;
            ServerMessageHelper.SendServerMessage(DBHelper.GetChatServerId(self.DomainZone()),
               NoticeType.BattleNotice, "战场即将关闭。请退出战场").Coroutine();

            await TimerComponent.Instance.WaitAsync(60000);

            ServerMessageHelper.SendServerMessage(DBHelper.GetBattleServerId(self.DomainZone()),
               NoticeType.BattleClose, "战场即将关闭。请退出战场").Coroutine();
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
          
            self.DBDayActivityInfo.MysteryItemInfos =  MysteryShopHelper.InitMysteryItemInfos( openServerTime);
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
                A2A_ActivityUpdateResponse m2m_TrasferUnitResponse = (A2A_ActivityUpdateResponse)await ActorMessageSenderComponent.Instance.Call
                        (self.MapIdList[i], new A2A_ActivityUpdateRequest() { ActivityType = hour });
            }

            if (hour == 0)
            {
                long openServerTime = await DBHelper.GetOpenServerTime(self.DomainZone());
                self.DBDayActivityInfo.MysteryItemInfos = MysteryShopHelper.InitMysteryItemInfos(openServerTime);

                self.OnBattleOpen = false;
                self.OnBattleClose = false;
            }
        }
    }
}
