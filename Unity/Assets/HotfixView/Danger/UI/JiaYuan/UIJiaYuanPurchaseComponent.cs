

using System;
using System.Collections.Generic;
using UnityEngine;

namespace ET
{
    [Timer(TimerType.JiaYuanPurchaseTimer)]
    public class JiaYuanPurchaseTimer : ATimer<UIJiaYuanPurchaseComponent>
    {
        public override void Run(UIJiaYuanPurchaseComponent self)
        {
            try
            {
                self.OnTimer();
            }
            catch (Exception e)
            {
                Log.Error($"move timer error: {self.Id}\n{e}");
            }
        }
    }

    public class UIJiaYuanPurchaseComponent : Entity, IAwake, IDestroy
    {
        public long Timer;

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
            self.Timer = TimerComponent.Instance.NewRepeatedTimer(1000, TimerType.JiaYuanPurchaseTimer, self);

            self.OnUpdateUI();
        }
    }

    public class UIJiaYuanPurchaseComponentDestroy : DestroySystem<UIJiaYuanPurchaseComponent>
    {
        public override void Destroy(UIJiaYuanPurchaseComponent self)
        {
            TimerComponent.Instance?.Remove(ref self.Timer);
        }
    }

    public static class UIJiaYuanPurchaseComponentSystem
    {

        public static void OnTimer(this UIJiaYuanPurchaseComponent self)
        {
            for (int i = self.UIJiaYuanPurchases.Count - 1; i >= 0; i--)
            {
                bool leftTime= self.UIJiaYuanPurchases[i].UpdateLeftTime();
                if (!leftTime)
                {
                    self.UIJiaYuanPurchases[i].GameObject.SetActive(false);
                }
            }
        }

        public static void OnUpdateItem(this UIJiaYuanPurchaseComponent self)
        {
            self.OnUpdateUI();
        }

        public static void OnUpdateUI(this UIJiaYuanPurchaseComponent self)
        {
            var path = ABPathHelper.GetUGUIPath("JiaYuan/UIJiaYuanPurchaseItem");
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);

            for (int i = 0; i < self.JiaYuanComponent.PurchaseItemList_5.Count; i++)
            {
                JiaYuanPurchaseItem jiaYuanPurchaseItem = self.JiaYuanComponent.PurchaseItemList_5[i];

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
                    self.UIJiaYuanPurchases.Add(uIJiaYuanPurchaseItem);
                }
                uIJiaYuanPurchaseItem.OnUpdateUI(jiaYuanPurchaseItem, self.OnUpdateItem);
            }

            for (int i = self.JiaYuanComponent.PurchaseItemList_5.Count; i < self.UIJiaYuanPurchases.Count; i++)
            {
                self.UIJiaYuanPurchases[i].GameObject.SetActive(false);
            }
        }
    }
}
