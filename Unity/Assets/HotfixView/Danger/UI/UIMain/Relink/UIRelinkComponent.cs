using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIRelinkComponent : Entity, IAwake, IDestroy
    {
        public GameObject Img_Loading;
    }


    public class UIRelinkComponentAwakeSystem : AwakeSystem<UIRelinkComponent>
    {
        public override void Awake(UIRelinkComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            UI uirotate = self.AddChild<UI, string, GameObject>("Img_Loading", rc.Get<GameObject>("Img_Loading"));
            uirotate.AddComponent<UIRotateComponent>().StartRotate(true);
        }
    }
}