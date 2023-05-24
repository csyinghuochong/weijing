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
        public GameObject TextHurt;

        public int Countdown;
        public long Timer;
        public long LastTiaoZhan;
        public long HurtValue;
    }


    public class UITrialMainComponentDestroy : DestroySystem<UITrialMainComponent>
    {
        public override void Destroy(UITrialMainComponent self)
        {
            TimerComponent.Instance?.Remove(ref self.Timer);
        }
    }

    public class UITrialMainComponentAwake : AwakeSystem<UITrialMainComponent>
    {
        public override void Awake(UITrialMainComponent self)
        {
            self.HurtValue = 0;
            self.LastTiaoZhan = 0;
            GameObject gameObject = self.GetParent<UI>().GameObject;
            ReferenceCollector rc = gameObject.GetComponent<ReferenceCollector>();

            self.TextCoundown = rc.Get<GameObject>("TextCoundown");
            self.ButtonTiaozhan = rc.Get<GameObject>("ButtonTiaozhan");
            self.TextHurt = rc.Get<GameObject>("TextHurt");
            self.OnUpdateHurt(0);

            ButtonHelp.AddListenerEx(self.ButtonTiaozhan, () => { self.OnButtonTiaozhan(); });

            self.BeginTimer();
        }
    }

    public static class UITrialMainComponentSystem
    {
        public static void StopTimer(this UITrialMainComponent self)
        {
            TimerComponent.Instance?.Remove(ref self.Timer);
        }

        public static void OnUpdateHurt(this UITrialMainComponent self, long hurt)
        {
            self.HurtValue += hurt;

            self.TextHurt.GetComponent<Text>().text = $"伤害值:{ self.HurtValue}";
        }

        public static void BeginTimer(this UITrialMainComponent self)
        {
            TimerComponent.Instance?.Remove(ref self.Timer);
            self.Countdown = 60;
            self.Timer = TimerComponent.Instance.NewRepeatedTimer(1000, TimerType.TrialMainTimer, self);
        }

        public static void OnButtonTiaozhan(this UITrialMainComponent self)
        {
            NumericComponent numericComponent = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene()).GetComponent<NumericComponent>();
            MapComponent mapComponent = self.ZoneScene().GetComponent<MapComponent>();
            if (numericComponent.GetAsInt(NumericType.TrialDungeonId) >= mapComponent.SonSceneId)
            {
                FloatTipManager.Instance.ShowFloatTip("已经通关了该关卡！");
                return;
            }

            if (TimeHelper.ServerNow() - self.LastTiaoZhan < 1000)
            {
                return;
            }
            self.LastTiaoZhan = TimeHelper.ServerNow();

            PopupTipHelp.OpenPopupTip(self.ZoneScene(),"系统提示", "是否重新开始挑战,开始后倒计时和怪物生命将自动初始化", () => 
            {
                self.RequestTiaozhan().Coroutine();
            }, null).Coroutine();
        }

        public static async ETTask RequestTiaozhan(this UITrialMainComponent self)
        {
            C2M_TrialDungeonBeginRequest request = new C2M_TrialDungeonBeginRequest();
            M2C_TrialDungeonBeginResponse response = (M2C_TrialDungeonBeginResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request);
            if (response.Error != ErrorCore.ERR_Success)
            {
                return;
            }
            self.BeginTimer();
            self.HurtValue = 0;
            self.OnUpdateHurt(0);
        }

        public static void OnTimer(this UITrialMainComponent self)
        {
            if (self.Countdown <= 0)
            {
                self.ZoneScene().GetComponent<SessionComponent>().Session.Call(new C2M_TrialDungeonFinishRequest()).Coroutine();
                TimerComponent.Instance?.Remove(ref self.Timer);

                self.TextCoundown.GetComponent<Text>().text = $"未能在60秒内击败怪物,请点击重新挑战";

                return;
            }

            self.TextCoundown.GetComponent<Text>().text = $"倒计时 {self.Countdown - 1}";
            self.Countdown--;
        }
    }
}