using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIActivityV1OrderComponent : Entity, IAwake
    {
      
    }

    public class UIActivityV1OrderComponentAwake : AwakeSystem<UIActivityV1OrderComponent>
    {
        public override void Awake(UIActivityV1OrderComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.UpdateInfo();
        }
    }

    public static class UIActivityV1OrderComponentSystem
    {
        public static void UpdateInfo(this UIActivityV1OrderComponent self)
        {
            ActivityV1Info activityV1Info = self.ZoneScene().GetComponent<ActivityComponent>().ActivityV1Info;

        }

    }
}