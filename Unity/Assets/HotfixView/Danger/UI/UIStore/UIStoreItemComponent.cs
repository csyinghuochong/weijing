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
        public GameObject Image_gold;
        public GameObject GameObject;
        public UIItemComponent uIItemComponent;
    }

    [ObjectSystem]
    public class UIStoreItemComponentAwakeSystem : AwakeSystem<UIStoreItemComponent, GameObject>
    {

        public override void Awake(UIStoreItemComponent self, GameObject gameObject)
        {
            self.GameObject = gameObject;
            ReferenceCollector rc = gameObject.GetComponent<ReferenceCollector>();

            self.Text_value = rc.Get<GameObject>("Text_value");
            self.UIItem = rc.Get<GameObject>("UIItem");
            self.Image_gold = rc.Get<GameObject>("Image_gold");

            self.uIItemComponent = self.AddChild<UIItemComponent, GameObject>(self.UIItem);
            self.ButtonBuy = rc.Get<GameObject>("ButtonBuy");
            if (self.ButtonBuy != null)
            {
                self.ButtonBuy.GetComponent<Button>().onClick.AddListener(() => { self.OnClickBuyButton(); });
            }
        }
    }

    [ObjectSystem]
    public class UIStoreItemComponentDestroySystem : DestroySystem<UIStoreItemComponent>
    {

        public override void Destroy(UIStoreItemComponent self)
        {
            self.uIItemComponent = null;
        }
    }

    public static class UIStoreItemComponentSystem
    {

        public static void OnClickBuyButton(this UIStoreItemComponent self)
        {
            UserInfo userInfo = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo;
            BagComponent bagComponent = self.ZoneScene().GetComponent<BagComponent>();
            int costType = self.StoreSellConfig.SellType;

            if (bagComponent.GetLeftSpace() == 0)
            {
                ErrorHelp.Instance.ErrorHint(ErrorCore.ERR_BagIsFull);
                return;
            }
            if (costType == 1 && userInfo.Gold < self.StoreSellConfig.SellValue)
            {
                FloatTipManager.Instance.ShowFloatTip("金币不足！");
                return;
            }
            if (costType == 3 && userInfo.Diamond < self.StoreSellConfig.SellValue)
            {
                FloatTipManager.Instance.ShowFloatTip("钻石不足！");
                return;
            }
            if (bagComponent.GetItemNumber(costType) < self.StoreSellConfig.SellValue)
            {
                FloatTipManager.Instance.ShowFloatTip("道具不足！");
                return;
            }

            bagComponent.SendBuyItem(self.StoreSellConfig.Id).Coroutine() ;
        }

        public static void OnUpdateData(this UIStoreItemComponent self, StoreSellConfig storeSellConfig)
        {
            self.StoreSellConfig = storeSellConfig;
            int costType = self.StoreSellConfig.SellType;
            ItemConfig itemConfig = ItemConfigCategory.Instance.Get(costType);
            self.Image_gold.GetComponent<Image>().sprite = ABAtlasHelp.GetIconSprite(ABAtlasTypes.ItemIcon, itemConfig.Icon);

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
