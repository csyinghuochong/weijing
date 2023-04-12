using System;
using System.Collections.Generic;
using UnityEngine;

namespace ET
{
    public class UICommonItemListComponent : Entity, IAwake<GameObject>
    {
        public GameObject itemNodeList;
        public List<UIItemComponent> UIItemComponents = new List<UIItemComponent>();
    }


    public class UICommonItemListComponentAwake : AwakeSystem<UICommonItemListComponent, GameObject>
    {
        public override void Awake(UICommonItemListComponent self, GameObject gameObject)
        {
            self.UIItemComponents.Clear();
            self.itemNodeList = gameObject;
        }
    }

    public static class UICommonItemListComponentSystem
    {
        public static void OnUpdateUI(this UICommonItemListComponent self, string itemList, float scale, bool showNumber)
        {
            List<RewardItem> rewardItems = ItemHelper.GetRewardItems(itemList);
            rewardItems.Sort(delegate (RewardItem a, RewardItem b)
            {
                int itemIda = a.ItemID;
                int itemIdb = b.ItemID;
                int quliatya = ItemConfigCategory.Instance.Get(itemIda).ItemQuality;
                int quliatyb = ItemConfigCategory.Instance.Get(itemIdb).ItemQuality;
                if (quliatya == quliatyb)
                {
                    if (itemIda == itemIdb)
                        return b.ItemNum - a.ItemNum;
                    else
                        return itemIda - itemIdb;
                }
                else
                {
                    return quliatyb - quliatya;
                }
            });

            int number = 0;
            var path = ABPathHelper.GetUGUIPath("Main/Common/UICommonItem");
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            for (int i = 0; i < rewardItems.Count; i++)
            {
                UIItemComponent uIItemComponent = null;
                if (number < self.UIItemComponents.Count)
                {
                    uIItemComponent = self.UIItemComponents[i];
                    uIItemComponent.GameObject.SetActive(true);
                }
                else
                {
                    GameObject itemSpace = GameObject.Instantiate(bundleGameObject);
                    UICommonHelper.SetParent(itemSpace, self.itemNodeList);
                    uIItemComponent = self.AddChild<UIItemComponent, GameObject>(itemSpace);
                    uIItemComponent.Label_ItemName.SetActive(false);
                    uIItemComponent.Label_ItemNum.SetActive(showNumber);
                    itemSpace.transform.localScale = Vector3.one * scale;
                    self.UIItemComponents.Add(uIItemComponent);
                }
                uIItemComponent.UpdateItem(new BagInfo() { ItemID = rewardItems[i].ItemID, ItemNum = rewardItems[i].ItemNum }, ItemOperateEnum.None);
                number++;
            }
            for (int i = number; i < self.UIItemComponents.Count; i++)
            {
                self.UIItemComponents[i].GameObject.SetActive(false);
            }
        }
    }
}
