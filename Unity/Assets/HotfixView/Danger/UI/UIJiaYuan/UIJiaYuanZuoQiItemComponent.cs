using System;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIJiaYuanZuoQiItemComponent : Entity, IAwake<GameObject>
    {
        public GameObject GameObject;
        public Text Text_Attribute_1;
        public Text TextName;
        public GameObject RawImage;
        public ZuoQiShowConfig ZuoQiConfig;
    }

    [ObjectSystem]
    public class UIJiaYuanZuoQiItemComponentAwake : AwakeSystem<UIJiaYuanZuoQiItemComponent, GameObject>
    {
        public override void Awake(UIJiaYuanZuoQiItemComponent self, GameObject a)
        {
            self.GameObject = a;
            ReferenceCollector rc = a.GetComponent<ReferenceCollector>();
            self.Text_Attribute_1 = rc.Get<GameObject>("Text_Attribute_1").GetComponent<Text>();
            self.TextName = rc.Get<GameObject>("TextName").GetComponent<Text>();
            self.RawImage = rc.Get<GameObject>("RawImage");
        }
    }

    public static class UIJiaYuanZuoQiItemComponentSystem
    {
        public static void OnInitUI(this UIJiaYuanZuoQiItemComponent self, ZuoQiShowConfig zuoQiConfig)
        {
            self.ZuoQiConfig    = zuoQiConfig;

            self.TextName.text  = zuoQiConfig.Name;
        }
    }
}
