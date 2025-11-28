using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIActivityV1PointsChouKaComponent : Entity, IAwake
    {
       
    }

    public class UIActivityV1PointsChouKaComponentAwake : AwakeSystem<UIActivityV1PointsChouKaComponent>
    {
        public override void Awake(UIActivityV1PointsChouKaComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

          
        }
    }

    public static class UIActivityV1PointsChouKaComponentSystem
    {
        public static void UpdateInfo(this UIActivityV1PointsChouKaComponent self)
        {
          
        }

        public static async ETTask OnOpenBtn(this UIActivityV1PointsChouKaComponent self)
        {
            await ETTask.CompletedTask;
        }

    }
}