using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIJiaYuanPurchaseItemComponent : Entity, IAwake<GameObject>
    {
        public GameObject Text_Price;
        public GameObject Button_Sell;
        public GameObject MakeItem;
        public GameObject MakeItemList;
        public GameObject GameObject;

        public UIItemComponent UICommonItem;
        public List<UIItemComponent> MakeList = new List<UIItemComponent>();
    }

    public class UIJiaYuanPurchaseItemComponentAwake : AwakeSystem<UIJiaYuanPurchaseItemComponent, GameObject>
    {
        public override void Awake(UIJiaYuanPurchaseItemComponent self, GameObject gameObject)
        {
            self.MakeList.Clear();
            self.GameObject = gameObject;
            ReferenceCollector rc= gameObject.GetComponent<ReferenceCollector>();

            self.Text_Price = rc.Get<GameObject>("Text_Price");
            self.Button_Sell = rc.Get<GameObject>("Button_Sell");

            self.MakeItem = rc.Get<GameObject>("MakeItem");
            self.MakeItem.SetActive(false);

            self.MakeItemList = rc.Get<GameObject>("MakeItemList");

            GameObject uICommonItem = rc.Get<GameObject>("UICommonItem");
            self.UICommonItem = self.AddChild<UIItemComponent, GameObject>(uICommonItem);
        }
    }

    public static class UIJiaYuanPurchaseItemComponentSystem
    {
        public static void OnUpdateUI(this UIJiaYuanPurchaseItemComponent self, JiaYuanPurchaseItem jiaYuanPurchaseItem)
        { 
            int itemid = jiaYuanPurchaseItem.ItemID;
            int makeid = EquipMakeConfigCategory.Instance.GetMakeId(itemid);
            EquipMakeConfig equipMakeConfig = EquipMakeConfigCategory.Instance.Get(makeid);
            self.UICommonItem.UpdateItem(new BagInfo() { ItemID = itemid , ItemNum = jiaYuanPurchaseItem.LeftNum }, ItemOperateEnum.None);
            var path = ABPathHelper.GetUGUIPath("Main/Common/UICommonItem");
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            string[] costItems = equipMakeConfig.NeedItems.Split('@');
            for (int i = 0;i < costItems.Length; i++)
            {
                string[] itemInfo = costItems[i].Split(';');
                if (itemInfo.Length < 2)
                {
                    Log.Error($"equipMakeConfig: {equipMakeConfig.NeedItems}");
                    continue;
                }

                UIItemComponent ui_2 = null;
                if (i < self.MakeList.Count)
                {
                    ui_2 = self.MakeList[i];
                    ui_2.GameObject.SetActive(true);
                }
                else
                {
                    GameObject itemSpace = GameObject.Instantiate(bundleGameObject);
                    itemSpace.SetActive(true);
                    UICommonHelper.SetParent(itemSpace, self.MakeItemList);
                    ui_2 = self.AddChild<UIItemComponent, GameObject>(itemSpace);
                    self.MakeList.Add(ui_2);
                }
                ui_2.UpdateItem(new BagInfo() { ItemID = int.Parse(itemInfo[0]), ItemNum = int.Parse(itemInfo[1]) }, ItemOperateEnum.None);
                ui_2.Label_ItemName.SetActive(true);
            }

            for (int i = costItems.Length; i < self.MakeList.Count; i++)
            {
                self.MakeList[i].GameObject.SetActive(false);
            }

            self.Text_Price.GetComponent<Text>().text = jiaYuanPurchaseItem.BuyZiJin.ToString();
        }
    }
}
