using System;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UISeasonMainComponent : Entity, IAwake, IDestroy
    {
        public Text CDdownTimeText;
        public long CDTimer;
        public int CDdownTimeNumber;
    }

    [Timer(TimerType.SeasonTowerTimer)]
    public class SeasonTowerTimer : ATimer<UISeasonMainComponent>
    {
        public override void Run(UISeasonMainComponent self)
        {
            try
            {
                self.OnUpdate();
            }
            catch (Exception e)
            {
                Log.Error($"move timer error: {self.Id}\n{e}");
            }
        }
    }

    public class UISeasonMainComponentAwake : AwakeSystem<UISeasonMainComponent>
    {
        public override void Awake(UISeasonMainComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.CDdownTimeText = rc.Get<GameObject>("CDdownTimeText").GetComponent<Text>();
            self.CDTimer = TimerComponent.Instance.NewRepeatedTimer( 1000, TimerType.SeasonTowerTimer, self);
            self.CDdownTimeNumber = 100;
        }
    }

    public class UISeasonMainComponentDestroy : DestroySystem<UISeasonMainComponent>
    {
        public override void Destroy(UISeasonMainComponent self)
        {
            TimerComponent.Instance?.Remove(ref self.CDTimer);
        }
    }

    public static class UISeasonMainComponentSystem
    {

        public static async ETTask WaitReturn(this UISeasonMainComponent self)
        {
            long instanceid = self.InstanceId;
            await TimerComponent.Instance.WaitAsync(5000);

            if (instanceid != self.InstanceId)
            {
                return;
            }
            EnterFubenHelp.RequestQuitFuben(self.ZoneScene()); 
        }

        public static void OnUpdate( this UISeasonMainComponent self )
        {
            if (self.CDdownTimeNumber < 0)
            {
                FloatTipManager.Instance.ShowFloatTip("本层赛季之塔的时间已经用尽，请返回主城!");
                TimerComponent.Instance?.Remove(ref self.CDTimer);
                self.WaitReturn().Coroutine();
                return;
            }

            if ( self.CDdownTimeNumber >= 0 )
            {
                int showTime = self.CDdownTimeNumber;
                int minute = showTime / 60;
                int sceond = showTime % 60;
                self.CDdownTimeText.text = $"倒计时 {minute}:{sceond}";
            }
            self.CDdownTimeNumber--;
        }
    }
}