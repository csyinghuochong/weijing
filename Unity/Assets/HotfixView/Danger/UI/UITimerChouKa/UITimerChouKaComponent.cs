using System;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UITimerChouKaComponent : Entity, IAwake, IDestroy
    {
        public Text TextTip;
        public Button OpenBtn;
        public GameObject RewardItemListNode;
        public Button ImageDi;
    }

    public class UITimerChouKaComponentAwake : AwakeSystem<UITimerChouKaComponent>
    {
        public override void Awake(UITimerChouKaComponent self)
        {
            self.Awake();
        }
    }

    public class UITimerChouKaComponentDestroy : DestroySystem<UITimerChouKaComponent>
    {
        public override void Destroy(UITimerChouKaComponent self)
        {
            self.Destroy();
        }
    }

    public static class UITimerChouKaComponentSystem
    {
        public static void Awake(this UITimerChouKaComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.TextTip = rc.Get<GameObject>("TextTip").GetComponent<Text>();
            self.OpenBtn = rc.Get<GameObject>("OpenBtn").GetComponent<Button>();

            self.RewardItemListNode = rc.Get<GameObject>("RewardItemListNode");

            self.ImageDi = rc.Get<GameObject>("ImageDi").GetComponent<Button>();
        }

        public static void Destroy(this UITimerChouKaComponent self)
        {

        }
    }
}