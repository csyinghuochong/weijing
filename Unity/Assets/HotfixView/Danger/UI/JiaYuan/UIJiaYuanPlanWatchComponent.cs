using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIJiaYuanPlanWatchComponent : Entity, IAwake
    {
        public GameObject ButtonClose;
    }

    [ObjectSystem]
    public class UIJiaYuanPlanWatchComponentAwake : AwakeSystem<UIJiaYuanPlanWatchComponent>
    {
        public override void Awake(UIJiaYuanPlanWatchComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.ButtonClose = rc.Get<GameObject>("ButtonClose");
            self.ButtonClose.GetComponent<Button>().onClick.AddListener(() => { UIHelper.Remove( self.ZoneScene(), UIType.UIJiaYuanPlanWatch ); });
        }
    }
}
