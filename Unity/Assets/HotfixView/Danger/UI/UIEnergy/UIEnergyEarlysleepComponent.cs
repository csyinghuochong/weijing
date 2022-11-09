using System;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIEnergyEarlysleepComponent : Entity, IAwake
    {
        public GameObject ButtonRecv;
        public GameObject ItemNodeList;

    }

    [ObjectSystem]
    public class UIEnergyEarlysleepComponentAwakeSystem : AwakeSystem<UIEnergyEarlysleepComponent>
    {
        public override void Awake(UIEnergyEarlysleepComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.ButtonRecv = rc.Get<GameObject>("ButtonRecv");
            self.ButtonRecv.GetComponent<Button>().onClick.AddListener(() => { self.OnClickButtonRecv(); });

            self.ItemNodeList = rc.Get<GameObject>("ItemNodeList");
            self.GetParent<UI>().OnUpdateUI = () => { self.OnUpdateUI(); };

            self.OnInitUI();
        }
    }

    public static class UIEnergyEarlysleepComponentSystem
    {

        public static void OnInitUI(this UIEnergyEarlysleepComponent self)
        {
            GlobalValueConfig globalValueConfig = GlobalValueConfigCategory.Instance.Get(14);
            UICommonHelper.ShowItemList(globalValueConfig.Value, self.ItemNodeList, self);
        }

        public static void OnUpdateUI(this UIEnergyEarlysleepComponent self)
        {
            
        }

        public static void OnClickButtonRecv(this UIEnergyEarlysleepComponent self)
        {
            DateTime dateTime = TimeHelper.DateTimeNow();
            int day = dateTime.Day;
            int huor = dateTime.Hour;
            int minute = dateTime.Minute;
            int second = dateTime.Second;
            int millisecond = dateTime.Millisecond;
            EnergyComponent energyComponent = self.ZoneScene().GetComponent<EnergyComponent>();

            if (huor >= 0 && huor <= 7)
            {
                FloatTipManager.Instance.ShowFloatTip("不在领取时间内！");
                return;
            }
            if (energyComponent.GetRewards[1] == 1)
            {
                FloatTipManager.Instance.ShowFloatTip("已经领取过该奖励！");
            }
            else
            {
                energyComponent.RequestEnergyReward(1).Coroutine();
            }
        }
    }
}
