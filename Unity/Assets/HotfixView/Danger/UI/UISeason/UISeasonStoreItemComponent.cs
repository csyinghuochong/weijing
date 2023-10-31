using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UISeasonStoreItemComponent: Entity, IAwake<GameObject>
    {
        public GameObject GameObject;
        public GameObject UIItemNode;
        public GameObject NameText;
        public GameObject GoldImg;
        public GameObject ValueText;
        public GameObject BuyBtn;

        public UIItemComponent UICommonItem;
        public int StoreSellConfigId;
    }

    public class UISeasonStoreItemComponentAwakeSystem: AwakeSystem<UISeasonStoreItemComponent, GameObject>
    {
        public override void Awake(UISeasonStoreItemComponent self, GameObject gameObject)
        {
            self.GameObject = gameObject;
            ReferenceCollector rc = gameObject.GetComponent<ReferenceCollector>();

            self.UIItemNode = rc.Get<GameObject>("UIItemNode");
            self.NameText = rc.Get<GameObject>("NameText");
            self.GoldImg = rc.Get<GameObject>("GoldImg");
            self.ValueText = rc.Get<GameObject>("ValueText");
            self.BuyBtn = rc.Get<GameObject>("BuyBtn");

            var path = ABPathHelper.GetUGUIPath("Main/Common/UICommonItem");
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject go = GameObject.Instantiate(bundleGameObject);
            UICommonHelper.SetParent(go, self.UIItemNode);
            self.UICommonItem = self.AddChild<UIItemComponent, GameObject>(go);

            self.BuyBtn.GetComponent<Button>().onClick.AddListener(() => { self.OnBuyBtn().Coroutine(); });
        }
    }

    public static class UISeasonStoreItemComponentSystem
    {
        public static async ETTask OnBuyBtn(this UISeasonStoreItemComponent self)
        {
            long glod = self.ZoneScene().GetComponent<BagComponent>()
                    .GetItemNumber(StoreSellConfigCategory.Instance.Get(self.StoreSellConfigId).SellType);
            StoreSellConfig storeSellConfig = StoreSellConfigCategory.Instance.Get(self.StoreSellConfigId);

            if (glod < storeSellConfig.SellValue)
            {
                FloatTipManager.Instance.ShowFloatTip("货币不足！");
                return;
            }

            C2M_StoreBuyRequest request = new C2M_StoreBuyRequest() { SellItemID = self.StoreSellConfigId, SellItemNum = 1 };
            M2C_StoreBuyResponse response =
                    (M2C_StoreBuyResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(request);

            if (response.Error == ErrorCode.ERR_Success)
            {
                self.GetParent<UISeasonStoreComponent>().UpdateInfo();
            }
        }

        public static void OnUpdateUI(this UISeasonStoreItemComponent self, int id)
        {
            StoreSellConfig storeSellConfig = StoreSellConfigCategory.Instance.Get(id);
            self.StoreSellConfigId = id;
            ItemConfig itemConfig = ItemConfigCategory.Instance.Get(storeSellConfig.SellItemID);

            self.UICommonItem.UpdateItem(new BagInfo() { ItemID = storeSellConfig.SellItemID }, ItemOperateEnum.None);
            self.UICommonItem.Label_ItemNum.SetActive(false);
            self.UICommonItem.HideItemName();
            self.NameText.GetComponent<Text>().text = itemConfig.ItemName;
            self.ValueText.GetComponent<Text>().text = storeSellConfig.SellValue.ToString();

            ItemConfig sellTypeItemConfig = ItemConfigCategory.Instance.Get(storeSellConfig.SellType);
            Sprite sp = ABAtlasHelp.GetIconSprite(ABAtlasTypes.ItemIcon, sellTypeItemConfig.Icon);
            self.GoldImg.GetComponent<Image>().sprite = sp;
        }
    }
}