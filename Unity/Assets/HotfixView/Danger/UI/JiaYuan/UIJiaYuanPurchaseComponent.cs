

using System.Collections.Generic;
using UnityEngine;

namespace ET
{
    public class UIJiaYuanPurchaseComponent : Entity, IAwake
    {
        public GameObject ScorllListNode;

        public JiaYuanComponent JiaYuanComponent;
        public List<UIJiaYuanPurchaseItemComponent> UIJiaYuanPurchases = new List<UIJiaYuanPurchaseItemComponent>();
    }

    [ObjectSystem]
    public class UIJiaYuanPurchaseComponentAwake : AwakeSystem<UIJiaYuanPurchaseComponent>
    {
        public override void Awake(UIJiaYuanPurchaseComponent self)
        {
            self.UIJiaYuanPurchases.Clear();
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.ScorllListNode = rc.Get<GameObject>("ScorllListNode");

            self.JiaYuanComponent = self.ZoneScene().GetComponent<JiaYuanComponent>();

            self.OnUpdateUI();
        }
    }

    public static class UIJiaYuanPurchaseComponentSystem
    {
        public static void OnUpdateUI(this UIJiaYuanPurchaseComponent self)
        {
            var path = ABPathHelper.GetUGUIPath("JiaYuan/UIJiaYuanPurchaseItem");
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);

            for (int i = 0; i < self.JiaYuanComponent.PurchaseItemList_3.Count; i++)
            {
                JiaYuanPurchaseItem jiaYuanPurchaseItem = self.JiaYuanComponent.PurchaseItemList_3[i];

                UIJiaYuanPurchaseItemComponent uIJiaYuanPurchaseItem = null;
                if (i < self.UIJiaYuanPurchases.Count)
                {
                    uIJiaYuanPurchaseItem = self.UIJiaYuanPurchases[i];
                    uIJiaYuanPurchaseItem.GameObject.SetActive(true);
                }
                else
                {
                    GameObject itemSpace = GameObject.Instantiate(bundleGameObject);
                    itemSpace.SetActive(true);
                    UICommonHelper.SetParent(itemSpace, self.ScorllListNode);
                    uIJiaYuanPurchaseItem = self.AddChild<UIJiaYuanPurchaseItemComponent, GameObject>(itemSpace);
                }
                uIJiaYuanPurchaseItem.OnUpdateUI(jiaYuanPurchaseItem);
            }

            for (int i = self.JiaYuanComponent.PurchaseItemList_3.Count; i < self.UIJiaYuanPurchases.Count; i++)
            {
                self.UIJiaYuanPurchases[i].GameObject.SetActive(false);
            }
        }
    }
}
