using System;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIEnergyEarlyupComponent : Entity, IAwake
    {
        public GameObject ButtonRecv;
        public GameObject ItemNodeList;
    }

    [ObjectSystem]
    public class UIEnergyEarlyupComponentAwakeSystem : AwakeSystem<UIEnergyEarlyupComponent>
    {
        public override void Awake(UIEnergyEarlyupComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.ButtonRecv = rc.Get<GameObject>("ButtonRecv");
            ButtonHelp.AddListenerEx(self.ButtonRecv, ()=> { self.OnClickButtonRecv(); });

            self.ItemNodeList = rc.Get<GameObject>("ItemNodeList");
            self.GetParent<UI>().OnUpdateUI = () => { self.OnUpdateUI(); };

            self.OnInitUI();
        }
    }

    public static class UIEnergyEarlyupComponentSystem
    {
        public static void OnInitUI(this UIEnergyEarlyupComponent self)
        {
            GlobalValueConfig globalValueConfig = GlobalValueConfigCategory.Instance.Get(13);
            UICommonHelper.ShowItemList(globalValueConfig.Value, self.ItemNodeList, self);
        }

        public static void OnUpdateUI(this UIEnergyEarlyupComponent self)
        { 
            
        }

        public static void OnClickButtonRecv(this UIEnergyEarlyupComponent self)
        {
            DateTime dateTime = TimeHelper.DateTimeNow();
            int day = dateTime.Day;
            int huor = dateTime.Hour;
            int minute = dateTime.Minute;
            int second = dateTime.Second;
            int millisecond = dateTime.Millisecond;
            EnergyComponent energyComponent = self.ZoneScene().GetComponent<EnergyComponent>();

            if (huor < 6 || huor > 7)
            {
                FloatTipManager.Instance.ShowFloatTip("不在领取时间内！");
                return;
            }
            if (energyComponent.GetRewards[0] == 1)
            {
                FloatTipManager.Instance.ShowFloatTip("已经领取过该奖励！");
            }
            else
            {
                energyComponent.RequestEnergyReward(0).Coroutine();
            }
        }

    }
}
