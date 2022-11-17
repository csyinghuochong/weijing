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
            GameObject gameObject = self.GetParent<UI>().GameObject;
            ReferenceCollector rc = gameObject.GetComponent<ReferenceCollector>();

            self.TextCoundown = rc.Get<GameObject>("TextCoundown");
            self.ButtonTiaozhan = rc.Get<GameObject>("ButtonTiaozhan");
            self.ButtonTiaozhan.SetActive(false);

            self.BeginTimer();
        }
    }

    public static class UITrialMainComponentSystem
    {
        public static void BeginTimer(this UITrialMainComponent self)
        {
            TimerComponent.Instance?.Remove(ref self.Timer);
            self.Countdown = 60;
            self.Timer = TimerComponent.Instance.NewRepeatedTimer(1000, TimerType.TrialMainTimer, self);
        }

        public static void OnTimer(this UITrialMainComponent self)
        {
            self.Countdown--;
            self.TextCoundown.GetComponent<Text>().text = self.Countdown.ToString();
            if (self.Countdown <= 0)
            {
                TimerComponent.Instance?.Remove(ref self.Timer);
                self.ButtonTiaozhan.SetActive(true);
            }
        }
    }
}