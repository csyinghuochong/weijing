using System;
using System.Collections.Generic;

namespace ET
{
    [Timer(TimerType.ChatSceneTimer)]
    public class ChatSceneTimer : ATimer<ChatSceneComponent>
    {
        public override void Run(ChatSceneComponent self)
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

    [ObjectSystem]
    public class ChatSceneComponentAwake : AwakeSystem<ChatSceneComponent>
    {
        public override void Awake(ChatSceneComponent self)
        {
            self.WordSayList.Clear();
            self.OnZeroClockUpdate();
        }
    }

    [ObjectSystem]
    public class ChatSceneComponentDestroy : DestroySystem<ChatSceneComponent>
    {
        public override void Destroy(ChatSceneComponent self)
        {
            TimerComponent.Instance.Remove(ref self.Timer);

            foreach (var chatInfoUnit in self.ChatInfoUnitsDict.Values)
            {
                chatInfoUnit?.Dispose();
            }
        }
    }

    public static class ChatSceneComponentSystem
    {
        public static void OnZeroClockUpdate(this ChatSceneComponent self)
        {
            long serverTime = TimeHelper.ServerNow();
            DateTime dateTime = TimeHelper.DateTimeNow();
            int huor = dateTime.Hour;
            int minute = dateTime.Minute;
            int second = dateTime.Second;
            int time1 = huor * 3600 + minute * 60 + second;

            for (int i = 0; i < ConfigHelper.WorldSayList.Count; i++)
            {
                WorldSayConfig worldSayConfig = ConfigHelper.WorldSayList[i];
                int hour2 = worldSayConfig.Time / 100;
                int minute2 = worldSayConfig.Time % 100;
                int time2 = hour2 * 3600 + minute2 * 60;

                int leftTime = time2 - time1;
                if (leftTime > 0)
                {
                    worldSayConfig.ServerTime = serverTime + leftTime * 1000;
                    self.WordSayList.Add(worldSayConfig);
                }
            }

            self.WordSayList.Sort(delegate (WorldSayConfig a, WorldSayConfig b)
            {
                return a.Time - b.Time; 
            });

            self.StartTimer();
        }

        public static void StartTimer(this ChatSceneComponent self)
        {
            if (self.WordSayList.Count > 0)
            {
                TimerComponent.Instance.Remove(ref self.Timer);
                self.Timer = TimerComponent.Instance.NewOnceTimer(self.WordSayList[0].ServerTime, TimerType.ChatSceneTimer, self);
            }
            else
            {
                TimerComponent.Instance.Remove(ref self.Timer);
            }
        }

        public static void OnCheck(this ChatSceneComponent self)
        {
            if (self.WordSayList.Count > 0)
            {
                WorldSayConfig worldSayConfig = self.WordSayList[0];
                self.WordSayList.RemoveAt(0);

                ServerMessageHelper.SendServerMessage(DBHelper.GetChatServerId(self.DomainZone()),
                NoticeType.Notice, worldSayConfig.Conent).Coroutine();
            }
            self.StartTimer();
        }

        public static void Add(this ChatSceneComponent self, ChatInfoUnit chatInfoUnit)
        {
            if (self.ChatInfoUnitsDict.ContainsKey(chatInfoUnit.Id))
            {
                Log.Error($"chatInfoUnit is exist! ： {chatInfoUnit.Id}");
                return;
            }
            self.ChatInfoUnitsDict.Add(chatInfoUnit.Id, chatInfoUnit);
        }


        public static ChatInfoUnit Get(this ChatSceneComponent self, long id)
        {
            self.ChatInfoUnitsDict.TryGetValue(id, out ChatInfoUnit chatInfoUnit);
            return chatInfoUnit;
        }


        public static void Remove(this ChatSceneComponent self, long id)
        {
            if (self.ChatInfoUnitsDict.TryGetValue(id, out ChatInfoUnit chatInfoUnit))
            {
                self.ChatInfoUnitsDict.Remove(id);
                chatInfoUnit?.Dispose();
            }
        }
    }
}
