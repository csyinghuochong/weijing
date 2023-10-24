using System;
using UnityEngine;
using System.Linq;
using System.Collections.Generic;

namespace ET
{
    public class UIZuoQiShowComponent: Entity, IAwake
    {
        public GameObject ZuoQiListNode;
        public GameObject UIZuoQiShowItem;
    }


    public class UIZuoQiShowComponentAwake : AwakeSystem<UIZuoQiShowComponent>
    {
        public override void Awake(UIZuoQiShowComponent self)
        {
            ReferenceCollector rc   = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
            self.ZuoQiListNode      = rc.Get<GameObject>("ZuoQiListNode");
            self.UIZuoQiShowItem = rc.Get<GameObject>("UIZuoQiShowItem");
            self.UIZuoQiShowItem.SetActive(false);

            self.OnInitUI();
        }
    }

    public static class UIZuoQiShowSystem
    {
        public static  void OnInitUI(this UIZuoQiShowComponent self)
        {
            List<ZuoQiShowConfig> zuoQiConfigs = ZuoQiShowConfigCategory.Instance.GetAll().Values.ToList();
            for (int i = 0; i < zuoQiConfigs.Count; i++)
            {
                GameObject zuoqiItem = GameObject.Instantiate(self.UIZuoQiShowItem);
                zuoqiItem.SetActive(true);
                UICommonHelper.SetParent(zuoqiItem, self.ZuoQiListNode);
                self.AddChild<UIZuoQiShowItemComponent, GameObject>(zuoqiItem).OnInitUI(zuoQiConfigs[i]);
            }
        }
    }
}
