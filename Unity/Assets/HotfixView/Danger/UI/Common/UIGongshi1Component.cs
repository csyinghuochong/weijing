using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{

    public class UIGongshi1Component : Entity, IAwake, IDestroy
    {
       
        public GameObject Btn_Close;
    }


    public class UIGongshi1ComponentAwakeSystem : AwakeSystem<UIGongshi1Component>
    {
        public override void Awake(UIGongshi1Component self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
            self.Btn_Close = rc.Get<GameObject>("Btn_Close");

            self.Btn_Close.GetComponent<Button>().onClick.AddListener(() =>
            {
                UIHelper.Remove(self.ZoneScene(), UIType.UI_Gongshi_1);
            });

        }
    }

    public static class UIGongshi1ComponentSystem
    {
      
    }
}
