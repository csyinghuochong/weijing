using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIActivityV1GrowthTreeComponent : Entity, IAwake
    {
      
    }

    public class UIActivityV1GrowthTreeComponentAwake : AwakeSystem<UIActivityV1GrowthTreeComponent>
    {
        public override void Awake(UIActivityV1GrowthTreeComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

        
            self.UpdateInfo();
        }
    }

    public static class UIActivityV1GrowthTreeComponentSystem
    {
        public static void UpdateInfo(this UIActivityV1GrowthTreeComponent self)
        {
            ActivityV1Info activityV1Info = self.ZoneScene().GetComponent<ActivityComponent>().ActivityV1Info;

        }

       
    }
}