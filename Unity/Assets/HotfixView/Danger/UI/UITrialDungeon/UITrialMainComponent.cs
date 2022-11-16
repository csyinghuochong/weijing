using System;
using UnityEngine;

namespace ET
{
    public class UITrialMainComponent : Entity, IAwake
    {
        public GameObject TextCoundown;
        public GameObject ButtonTiaozhan;
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
        }

    }
}