using UnityEngine;
using System;

namespace ET
{
    public class UISoloComponent : Entity, IAwake
    {
        public GameObject ButtonMatch;
    }

    public class UISoloComponentAwake : AwakeSystem<UISoloComponent>
    {
        public override void Awake(UISoloComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.ButtonMatch = rc.Get<GameObject>("ButtonMatch");
            ButtonHelp.AddListenerEx(self.ButtonMatch, () => { self.OnButtonMatch().Coroutine();  });
        }
    }

    public static class UISoloComponentSystem
    {
        public static async ETTask OnButtonMatch(this UISoloComponent self)
        {
            //点击按钮给服务器发送匹配消息
            int errorCode = await NetHelper.RequestSoloMatch(self.ZoneScene());
            if (errorCode == 0) {
                FloatTipManager.Instance.ShowFloatTip("开始匹配，请耐心等候...");
            }

        }
    }
}
