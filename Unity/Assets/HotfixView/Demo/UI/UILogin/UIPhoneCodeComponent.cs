using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{

    public class UIPhoneCodeComponent : Entity, IAwake
    {
        public GameObject ImageClose;
    }

    [ObjectSystem]
    public class UIPhoneCodeComponentAwake : AwakeSystem<UIPhoneCodeComponent>
    {
        public override void Awake(UIPhoneCodeComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
            self.ImageClose = rc.Get<GameObject>("ImageClose");
            self.ImageClose.GetComponent<Button>().onClick.AddListener(() => { UIHelper.Remove(self.ZoneScene(), UIType.UIPhoneCode); } );
        }
    }

    public static class UIPhoneCodeComponentSystem
    { 
        


    }
}
