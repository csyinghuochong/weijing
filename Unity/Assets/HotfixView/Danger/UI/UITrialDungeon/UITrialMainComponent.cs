using System;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{

    [Timer(TimerType.TrialMainTimer)]
    public class TrialMainTimer : ATimer<UITrialMainComponent>
    {
        public override void Run(UITrialMainComponent self)
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

    public class UITrialMainComponent : Entity, IAwake, IDestroy
    {
        public GameObject TextCoundown;
        public GameObject ButtonTiaozhan;

        public int Countdown;
        public long Timer;
        public long LastTiaoZhan;
    }

    [ObjectSystem]
    public class UITrialMainComponentDestroy : DestroySystem<UITrialMainComponent>
    {
        public override void Destroy(UITrialMainComponent self)
        {
            TimerComponent.Instance?.Remove(ref self.Timer);
        }
    }

    [ObjectSystem]
    public class UITrialMainComponentAwake : AwakeSystem<UITrialMainComponent>
    {
        public override void Awake(UITrialMainComponent self)
        {
            self.LastTiaoZhan = 0;
            GameObject gameObject = self.GetParent<UI>().GameObject;
            ReferenceCollector rc = gameObject.GetComponent<ReferenceCollector>();

            self.TextCoundown = rc.Get<GameObject>("TextCoundown");
            self.ButtonTiaozhan = rc.Get<GameObject>("ButtonTiaozhan");
            self.ButtonTiaozhan.GetComponent<Button>().onClick.AddListener(() => { self.OnButtonTiaozhan().Coroutine(); });

            self.BeginTimer();
        }
    }

    public static class UITrialMainComponentSystem
    {
        public static void StopTimer(this UITrialMainComponent self)
        {
            TimerComponent.Instance?.Remove(ref self.Timer);
        }

        public static void BeginTimer(this UITrialMainComponent self)
        {
            TimerComponent.Instance?.Remove(ref self.Timer);
            self.Countdown = 60;
            self.Timer = TimerComponent.Instance.NewRepeatedTimer(1000, TimerType.TrialMainTimer, self);
        }

        public static async ETTask OnButtonTiaozhan(this UITrialMainComponent self)
        {
            if (TimeHelper.ServerNow() - self.LastTiaoZhan < 1000)
            {
                return;
            }
            self.LastTiaoZhan = TimeHelper.ServerNow();
            C2M_TrialDungeonBeginRequest request = new C2M_TrialDungeonBeginRequest();
            M2C_TrialDungeonFinishResponse response = (M2C_TrialDungeonFinishResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request);
            if (response.Error != ErrorCore.ERR_Success)
            {
                return;
            }
            self.BeginTimer();
        }

        public static void OnTimer(this UITrialMainComponent self)
        {
            if (self.Countdown <= 0)
            {
                self.ZoneScene().GetComponent<SessionComponent>().Session.Call(new C2M_TrialDungeonFinishRequest()).Coroutine();
                TimerComponent.Instance?.Remove(ref self.Timer);
                return;
            }
            self.TextCoundown.GetComponent<Text>().text = $"倒计时 {self.Countdown}";
            self.Countdown--;
        }
    }
}