using System;
using UnityEngine;
using System.Linq;
using System.Collections.Generic;

namespace ET
{
    public class UIZuoQiShowComponent: Entity, IAwake
    {
        public GameObject ZuoQiListNode;
    }


    public class UIZuoQiShowComponentAwake : AwakeSystem<UIZuoQiShowComponent>
    {
        public override void Awake(UIZuoQiShowComponent self)
        {
            ReferenceCollector rc   = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
            self.ZuoQiListNode      = rc.Get<GameObject>("ZuoQiListNode");

            self.OnInitUI();
        }
    }

    public static class UIZuoQiShowSystem
    {
        public static  void OnInitUI(this UIZuoQiShowComponent self)
        {
            var path = ABPathHelper.GetUGUIPath("ZuoQi/UIZuoQiShowItem");
            GameObject prefab = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            List<ZuoQiShowConfig> zuoQiConfigs = ZuoQiShowConfigCategory.Instance.GetAll().Values.ToList();
            for (int i = 0; i < zuoQiConfigs.Count; i++)
            {
                GameObject zuoqiItem = GameObject.Instantiate(prefab);
                UICommonHelper.SetParent(zuoqiItem, self.ZuoQiListNode);
                self.AddChild<UIZuoQiShowItemComponent, GameObject>(zuoqiItem).OnInitUI(zuoQiConfigs[i]);
            }
        }
    }
}
