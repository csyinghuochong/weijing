using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UISeasonStoreComponent: Entity, IAwake
    {
        public GameObject SeasonStoreListNode;
        public GameObject UISeasonStoreItem;
        public GameObject GoldNumText;
        public GameObject GoldImg;

        public List<UISeasonStoreItemComponent> UISeasonStoreItemComponentList = new List<UISeasonStoreItemComponent>();
    }

    public class UISeasonStoreComponentAwakeSystem: AwakeSystem<UISeasonStoreComponent>
    {
        public override void Awake(UISeasonStoreComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.SeasonStoreListNode = rc.Get<GameObject>("SeasonStoreListNode");
            self.UISeasonStoreItem = rc.Get<GameObject>("UISeasonStoreItem");
            self.GoldNumText = rc.Get<GameObject>("GoldNumText");
            self.GoldImg = rc.Get<GameObject>("GoldImg");

            self.UISeasonStoreItem.SetActive(false);

            self.UpdateInfo();
        }
    }

    public static class UISeasonStoreComponentSystem
    {
        public static void UpdateInfo(this UISeasonStoreComponent self)
        {
            int seasonShopid = GlobalValueConfigCategory.Instance.Get(103).Value2;
            self.GoldNumText.GetComponent<Text>().text = self.ZoneScene().GetComponent<BagComponent>()
                    .GetItemNumber(StoreSellConfigCategory.Instance.Get(seasonShopid).SellType).ToString();

            ItemConfig sellTypeItemConfig = ItemConfigCategory.Instance.Get(StoreSellConfigCategory.Instance.Get(seasonShopid).SellType);
            Sprite sp = ABAtlasHelp.GetIconSprite(ABAtlasTypes.ItemIcon, sellTypeItemConfig.Icon);
            self.GoldImg.GetComponent<Image>().sprite = sp;

            List<int> itemList = new List<int>();
            while (seasonShopid > 0)
            {
                itemList.Add(seasonShopid);

                StoreSellConfig storeSellConfig = StoreSellConfigCategory.Instance.Get(seasonShopid);
                seasonShopid = storeSellConfig.NextID;
            }

            int number = 0;
            for (int i = 0; i < itemList.Count; i++)
            {
                UISeasonStoreItemComponent ui_1 = null;
                if (number < self.UISeasonStoreItemComponentList.Count)
                {
                    ui_1 = self.UISeasonStoreItemComponentList[number];
                    ui_1.GameObject.SetActive(true);
                }
                else
                {
                    GameObject storeItem = GameObject.Instantiate(self.UISeasonStoreItem);
                    storeItem.SetActive(true);
                    UICommonHelper.SetParent(storeItem, self.SeasonStoreListNode);

                    ui_1 = self.AddChild<UISeasonStoreItemComponent, GameObject>(storeItem);
                    self.UISeasonStoreItemComponentList.Add(ui_1);
                }

                ui_1.OnUpdateUI(itemList[i]);

                number++;
            }

            for (int i = number; i < self.UISeasonStoreItemComponentList.Count; i++)
            {
                self.UISeasonStoreItemComponentList[i].GameObject.SetActive(false);
            }
        }
    }
}