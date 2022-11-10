using System;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{

    [Timer(TimerType.BattleCountDown)]
    public class BattleMainTimer : ATimer<UIBattleMainComponent>
    {
        public override void Run(UIBattleMainComponent self)
        {
            try
            {
                self.OnTimer();
            }
            catch (Exception e)
            {
                Log.Error($"move timer error: {self.Id}\n{e}");
            }
        }
    }

    public class UIBattleMainComponent : Entity, IAwake, IDestroy
    {
        public GameObject TextVS_1;
        public GameObject TextVS_2;
        public Text CountDownTime;

        public long Timer;
        public int CDTime;
    }

    [ObjectSystem]
    public class UIBattleMainComponentAwakeSystem : AwakeSystem<UIBattleMainComponent>
    {
        public override void Awake(UIBattleMainComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.TextVS_1 = rc.Get<GameObject>("TextVS_1");
            self.TextVS_2 = rc.Get<GameObject>("TextVS_2");
            self.CountDownTime = rc.Get<GameObject>("CountDownTime").GetComponent<Text>();

            DateTime dateTime = TimeHelper.DateTimeNow();
            int huor = dateTime.Hour;
            int minute = dateTime.Minute;
            
            int leftTime = (60 - minute) * 60 - dateTime.Second;
            self.CDTime = leftTime * 1000;
            self.Timer = TimerComponent.Instance.NewFrameTimer(TimerType.BattleCountDown, self);
        }
    }

    [ObjectSystem]
    public class UIBattleMainComponentDestroySystem : DestroySystem<UIBattleMainComponent>
    {
        public override void Destroy(UIBattleMainComponent self)
        {
            TimerComponent.Instance?.Remove(ref self.Timer);
        }
    }

    public static class UIBattleMainComponentSystem
    {
        public static void OnTimer(this UIBattleMainComponent self)
        {
            if (self.CDTime < 0)
            {
                TimerComponent.Instance?.Remove(ref self.Timer);
                return;
            }
            self.CDTime-=1000;
            self.CountDownTime.text = TimeHelper.ShowLeftTime(self.CDTime);
        }

        public static void OnUpdateUI(this UIBattleMainComponent self, M2C_BattleInfoResult message)
        {
            self.TextVS_1.GetComponent<Text>().text = message.CampKill_1.ToString();
            self.TextVS_2.GetComponent<Text>().text = message.CampKill_2.ToString();
        }
    }
}