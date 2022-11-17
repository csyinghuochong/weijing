using System;
using UnityEngine;
using System.Linq;
using System.Collections.Generic;

namespace ET
{
    public class UIJiaYuanZuoQiComponent: Entity, IAwake
    {
        public GameObject ZuoQiListNode;
    }

    [ObjectSystem]
    public class UIJiaYuanZuoQiComponentAwake : AwakeSystem<UIJiaYuanZuoQiComponent>
    {
        public override void Awake(UIJiaYuanZuoQiComponent self)
        {
            ReferenceCollector rc   = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
            self.ZuoQiListNode      = rc.Get<GameObject>("ZuoQiListNode");

            self.OnInitUI();
        }
    }

    public static class UIJiaYuanZuoQiComponentSystem
    {
        public static  void OnInitUI(this UIJiaYuanZuoQiComponent self)
        {
            var path = ABPathHelper.GetUGUIPath("JiaYuan/UIJiaYuanZuoQiItem");
            GameObject prefab = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            List<ZuoQiShowConfig> zuoQiConfigs = ZuoQiShowConfigCategory.Instance.GetAll().Values.ToList();
            for (int i = 0; i < zuoQiConfigs.Count; i++)
            {
                GameObject zuoqiItem = GameObject.Instantiate(prefab);
                UICommonHelper.SetParent(zuoqiItem, self.ZuoQiListNode);
                self.AddChild<UIJiaYuanZuoQiItemComponent, GameObject>(zuoqiItem).OnInitUI(zuoQiConfigs[i]);
            }
        }
    }
}
