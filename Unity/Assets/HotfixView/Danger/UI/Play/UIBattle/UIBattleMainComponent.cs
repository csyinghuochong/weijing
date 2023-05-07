using System;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{

    [Timer(TimerType.BattleMainTimer)]
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
        public GameObject TextVS_Kill;
        public GameObject TextVS_1;
        public GameObject TextVS_2;
        public Text CountDownTime;

        public long Timer;
        public int CDTime;
    }


    public class UIBattleMainComponentAwakeSystem : AwakeSystem<UIBattleMainComponent>
    {
        public override void Awake(UIBattleMainComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.TextVS_1 = rc.Get<GameObject>("TextVS_1");
            self.TextVS_2 = rc.Get<GameObject>("TextVS_2");
            self.TextVS_Kill = rc.Get<GameObject>("TextVS_Kill");
            self.CountDownTime = rc.Get<GameObject>("CountDownTime").GetComponent<Text>();

            DateTime dateTime = TimeInfo.Instance.ToDateTime(TimeHelper.ServerNow());
            int huor = dateTime.Hour;
            int minute = dateTime.Minute;

            long curTime = (huor * 60 * 60 + minute * 60 + dateTime.Second) * 1000;
            long closeTime = FunctionHelp.GetCloseTime(1025)  * 1000;
            self.CDTime = (int)(closeTime - curTime);
            self.Timer = TimerComponent.Instance.NewRepeatedTimer(1000, TimerType.BattleMainTimer, self);

            self.OnUpdateSelfKill();
        }
    }


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
                EnterFubenHelp.RequestQuitFuben(self.ZoneScene());
                return;
            }
            self.CDTime-=1000;
            self.CountDownTime.text = "倒计时: " + TimeHelper.ShowLeftTime(self.CDTime);
        }

        public static void OnUpdateUI(this UIBattleMainComponent self, M2C_BattleInfoResult message)
        {
            self.TextVS_1.GetComponent<Text>().text = message.CampKill_1.ToString();
            self.TextVS_2.GetComponent<Text>().text = message.CampKill_2.ToString();
        }

        public static void OnUpdateSelfKill(this UIBattleMainComponent self)
        {
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            self.TextVS_Kill.GetComponent<Text>().text = "自身已战胜"+unit.GetComponent<NumericComponent>().GetAsInt(NumericType.BattleTodayKill).ToString()+ "个玩家";
        }
    }
}