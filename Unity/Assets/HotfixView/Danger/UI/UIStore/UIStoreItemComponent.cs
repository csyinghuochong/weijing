using System;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{ 
    public class UIStoreItemComponent : Entity, IAwake<GameObject>, IDestroy
    {
        public StoreSellConfig StoreSellConfig;

        public GameObject Text_value;
        public GameObject ButtonBuy;
        public GameObject UIItem;
        public GameObject GameObject;
        public GameObject Image_bg;
        public GameObject ImageSelect;

        public UIItemComponent Image_gold;
        public UIItemComponent uIItemComponent;

        public Action<int> ClickHandle;
    }


    public class UIStoreItemComponentAwakeSystem : AwakeSystem<UIStoreItemComponent, GameObject>
    {

        public override void Awake(UIStoreItemComponent self, GameObject gameObject)
        {
            self.GameObject = gameObject;
            ReferenceCollector rc = gameObject.GetComponent<ReferenceCollector>();

            self.Text_value = rc.Get<GameObject>("Text_value");
            self.UIItem = rc.Get<GameObject>("UIItem");
            GameObject image_gold  = rc.Get<GameObject>("Image_gold");
            self.Image_gold = self.AddChild<UIItemComponent, GameObject>(image_gold);

            self.uIItemComponent = self.AddChild<UIItemComponent, GameObject>(self.UIItem);
            self.ButtonBuy = rc.Get<GameObject>("ButtonBuy");
            if (self.ButtonBuy != null)
            {
                ButtonHelp.AddListenerEx(self.ButtonBuy, () => { self.OnClickBuyButton(); });
            }
            self.Image_bg = rc.Get<GameObject>("Image_bg");
            if (self.Image_bg != null)
            {
                ButtonHelp.AddListenerEx(self.Image_bg, () => { self.OnClickImageBg(); });
            }

            self.ImageSelect = rc.Get<GameObject>("ImageSelect");
            if (self.ImageSelect != null)
            {
                self.ImageSelect.SetActive(false);
            }
        }
    }


    public class UIStoreItemComponentDestroySystem : DestroySystem<UIStoreItemComponent>
    {

        public override void Destroy(UIStoreItemComponent self)
        {
            self.uIItemComponent = null;
        }
    }

    public static class UIStoreItemComponentSystem
    {
        public static void OnClickImageBg(this UIStoreItemComponent self)
        {
            self.ClickHandle(self.StoreSellConfig.Id);
        }

        public static void SetClickHandler(this UIStoreItemComponent self, Action<int> action)
        { 
            self.ClickHandle = action;  
        }

        public static void SetSelected(this UIStoreItemComponent self, int sellId)
        {
            self.ImageSelect.SetActive(self.StoreSellConfig.Id == sellId);
        }

        public static void OnClickBuyButton(this UIStoreItemComponent self)
        {
            self.ZoneScene().GetComponent<BagComponent>().SendBuyItem(self.StoreSellConfig.Id).Coroutine() ;
        }

        public static void OnUpdateData(this UIStoreItemComponent self, StoreSellConfig storeSellConfig)
        {
            self.StoreSellConfig = storeSellConfig;
            int costType = self.StoreSellConfig.SellType;
            //ItemConfig itemConfig = ItemConfigCategory.Instance.Get(costType);
            //self.Image_gold.GetComponent<Image>().sprite = ABAtlasHelp.GetIconSprite(ABAtlasTypes.ItemIcon, itemConfig.Icon);
            self.Image_gold.UpdateItem(new BagInfo() { ItemID = costType }, ItemOperateEnum.None);
            self.Image_gold.Label_ItemNum.SetActive(false);
            self.Image_gold.Image_ItemQuality.SetActive(false);

           BagInfo bagInfo = new BagInfo();
            bagInfo.ItemNum = storeSellConfig.SellItemNum;
            bagInfo.ItemID = storeSellConfig.SellItemID;
            self.Text_value.GetComponent<Text>().text = storeSellConfig.SellValue.ToString();
            self.uIItemComponent.UpdateItem(bagInfo, ItemOperateEnum.None);
            if (bagInfo.ItemNum <= 1)
            {
                self.uIItemComponent.Label_ItemNum.SetActive(false);
            }
        }

    }

}
