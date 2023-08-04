using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{

    public class UIFashionShowItemComponent : Entity, IAwake<GameObject>
    {
        public GameObject GameObject;

        public GameObject Text_222;
        public GameObject Text_111;

        public GameObject Btn_Active;
        public GameObject RawImage;

        public int Status;
    }

    public class UIFashionShowItemComponentAwake : AwakeSystem<UIFashionShowItemComponent, GameObject>
    {
        public override void Awake(UIFashionShowItemComponent self, GameObject a)
        {
            self.GameObject = a;

            ReferenceCollector rc = a.GetComponent<ReferenceCollector>();

            self.Text_222 = rc.Get<GameObject>("Text_222");
            self.Text_111 = rc.Get<GameObject>("Text_111");
            self.Btn_Active = rc.Get<GameObject>("Btn_Active");
        }
    }

    public static class UIFashionShowItemComponentSystem
    {

        public static void OnUpdateUI(this UIFashionShowItemComponent self, int fashionid)
        { 
            
        }
    }
}