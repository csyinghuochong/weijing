using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIJiaYuanMysteryItemComponent : Entity, IAwake<GameObject>
    {
        public GameObject UIItemNode;
        public GameObject Text_Number;
        public GameObject Text_value;
        public GameObject ButtonBuy;
        public GameObject Image_gold;
        public GameObject GameObject;

        public MysteryItemInfo MysteryItemInfo;
        public UIItemComponent UICommonItem;
    }

    [ObjectSystem]
    public class UIJiaYuanMysteryItemComponentAwake : AwakeSystem<UIJiaYuanMysteryItemComponent, GameObject>
    {
        public override void Awake(UIJiaYuanMysteryItemComponent self, GameObject gameObject)
        {
            self.GameObject = gameObject;
            ReferenceCollector rc = gameObject.GetComponent<ReferenceCollector>();

            self.UIItemNode = rc.Get<GameObject>("UIItemNode");
            self.Text_Number = rc.Get<GameObject>("Text_Number");
            self.Text_value = rc.Get<GameObject>("Text_value");
            self.Image_gold = rc.Get<GameObject>("Image_gold");

            self.ButtonBuy = rc.Get<GameObject>("ButtonBuy");
            ButtonHelp.AddListenerEx(self.ButtonBuy, () => { self.OnButtonBuy().Coroutine(); });

            var path = ABPathHelper.GetUGUIPath("Main/Common/UICommonItem");
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject go = GameObject.Instantiate(bundleGameObject);
            UICommonHelper.SetParent(go, self.UIItemNode);
            self.UICommonItem = self.AddChild<UIItemComponent, GameObject>(go);
            self.UICommonItem.Label_ItemName.SetActive(true);
        }
    }

    public static class UIJiaYuanMysteryItemComponentSystem
    {

        public static async ETTask OnButtonBuy(this UIJiaYuanMysteryItemComponent self)
        {
            int leftSpace = self.ZoneScene().GetComponent<BagComponent>().GetLeftSpace();
            if (leftSpace < 1)
            {
                ErrorHelp.Instance.ErrorHint(ErrorCore.ERR_BagIsFull);
                return;
            }

            MysteryConfig mysteryConfig = MysteryConfigCategory.Instance.Get(self.MysteryItemInfo.MysteryId);
            int sellValue = mysteryConfig.SellValue;

            if (mysteryConfig.SellType == 1 && self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.Gold < sellValue)
            {
                ErrorHelp.Instance.ErrorHint(ErrorCore.ERR_GoldNotEnoughError);
                return;
            }
            if (mysteryConfig.SellType == 3 && self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.Diamond < sellValue)
            {
                ErrorHelp.Instance.ErrorHint(ErrorCore.ERR_DiamondNotEnoughError);
                return;
            }
            if (!self.ZoneScene().GetComponent<BagComponent>().CheckNeedItem($"{mysteryConfig.SellType};{mysteryConfig.SellValue}"))
            {
                ErrorHelp.Instance.ErrorHint(ErrorCore.ERR_HouBiNotEnough);
                return;
            }

            C2M_JiaYuanMysteryBuyRequest c2M_MysteryBuyRequest = new C2M_JiaYuanMysteryBuyRequest() 
            {
                MysteryId = self.MysteryItemInfo.MysteryId,
                ProductId = self.MysteryItemInfo.ProductId
            };
            M2C_JiaYuanMysteryBuyResponse r2c_roleEquip = (M2C_JiaYuanMysteryBuyResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(c2M_MysteryBuyRequest);

            UI uI = UIHelper.GetUI(self.DomainScene(), UIType.UIJiaYuanMystery);
            uI.GetComponent<UIJiaYuanMysteryComponent>().RequestMystery().Coroutine();
        }

        public static void OnUpdateUI(this UIJiaYuanMysteryItemComponent self, MysteryItemInfo mysteryItemInfo)
        {
            MysteryConfig mysteryConfig = MysteryConfigCategory.Instance.Get(mysteryItemInfo.MysteryId);
            self.MysteryItemInfo = mysteryItemInfo;
            self.Text_Number.GetComponent<Text>().text = $"剩余 {mysteryItemInfo.ItemNumber}件";
            self.Text_value.GetComponent<Text>().text = mysteryConfig.SellValue.ToString();

            self.UICommonItem.UpdateItem(new BagInfo() { ItemID = self.MysteryItemInfo.ItemID }, ItemOperateEnum.None);
            self.UICommonItem.Label_ItemNum.SetActive(false);

            ItemConfig itemConfig = ItemConfigCategory.Instance.Get(mysteryConfig.SellType);
            Sprite sp = ABAtlasHelp.GetIconSprite(ABAtlasTypes.ItemIcon, itemConfig.Icon);
            self.Image_gold.GetComponent<Image>().sprite = sp;
        }

    }
}

