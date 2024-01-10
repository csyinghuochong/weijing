using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIJiaYuanMysteryItem_AComponent: Entity, IAwake<GameObject>,IDestroy
    {
        public GameObject Text_Tip;
        public GameObject UIItemNode;
        public GameObject Text_Number;
        public GameObject Text_value;
        public GameObject ButtonBuy;
        public GameObject Image_gold;
        public GameObject GameObject;

        public MysteryItemInfo MysteryItemInfo;
        public UIItemComponent UICommonItem;
        
        public List<string> AssetPath = new List<string>();
    }

    public class UIJiaYuanMysteryItem_BComponentAwake: AwakeSystem<UIJiaYuanMysteryItem_AComponent, GameObject>
    {
        public override void Awake(UIJiaYuanMysteryItem_AComponent self, GameObject gameObject)
        {
            self.GameObject = gameObject;
            ReferenceCollector rc = gameObject.GetComponent<ReferenceCollector>();

            self.Text_Tip = rc.Get<GameObject>("Text_Number");
            self.UIItemNode = rc.Get<GameObject>("UIItemNode");
            self.Text_Number = rc.Get<GameObject>("Text_Number");
            self.Text_value = rc.Get<GameObject>("Text_value");
            self.Image_gold = rc.Get<GameObject>("Image_gold");

            self.ButtonBuy = rc.Get<GameObject>("ButtonBuy");
            ButtonHelp.AddListenerEx(self.ButtonBuy, () => { self.OnButtonBuy().Coroutine(); });

            self.Text_Number.SetActive(false);
            self.Text_Tip.SetActive(false);
            
            var path = ABPathHelper.GetUGUIPath("Main/Common/UICommonItem");
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject go = GameObject.Instantiate(bundleGameObject);
            UICommonHelper.SetParent(go, self.UIItemNode);
            self.UICommonItem = self.AddChild<UIItemComponent, GameObject>(go);
            self.UICommonItem.Label_ItemName.SetActive(true);
        }
    }
    public class UIJiaYuanMysteryItem_AComponentDestroy : DestroySystem<UIJiaYuanMysteryItem_AComponent>
    {
        public override void Destroy(UIJiaYuanMysteryItem_AComponent self)
        {
            for(int i = 0; i < self.AssetPath.Count; i++)
            {
                if (!string.IsNullOrEmpty(self.AssetPath[i]))
                {
                    ResourcesComponent.Instance.UnLoadAsset(self.AssetPath[i]); 
                }
            }
            self.AssetPath = null;
        }
    }
    public static class UIJiaYuanMysteryItem_BComponentSystem
    {
        public static async ETTask OnButtonBuy(this UIJiaYuanMysteryItem_AComponent self)
        {
            MysteryConfig mysteryConfig = MysteryConfigCategory.Instance.Get(self.MysteryItemInfo.MysteryId);

            // 判断家园等级是否足够
            int jiayuanid = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.JiaYuanLv;
            JiaYuanConfig jiayuanCof = JiaYuanConfigCategory.Instance.Get(jiayuanid);
            if (mysteryConfig.JiaYuanLv > jiayuanCof.Lv)
            {
                FloatTipManager.Instance.ShowFloatTip($"家园{mysteryConfig.JiaYuanLv}级开启");
                return;
            }

            int leftSpace = self.ZoneScene().GetComponent<BagComponent>().GetBagLeftCell();
            if (leftSpace < 1)
            {
                ErrorHelp.Instance.ErrorHint(ErrorCode.ERR_BagIsFull);
                return;
            }

            int sellValue = mysteryConfig.SellValue;

            if (mysteryConfig.SellType == 1 && self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.Gold < sellValue)
            {
                ErrorHelp.Instance.ErrorHint(ErrorCode.ERR_GoldNotEnoughError);
                return;
            }

            if (mysteryConfig.SellType == 3 && self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.Diamond < sellValue)
            {
                ErrorHelp.Instance.ErrorHint(ErrorCode.ERR_DiamondNotEnoughError);
                return;
            }

            if (!self.ZoneScene().GetComponent<BagComponent>().CheckNeedItem($"{mysteryConfig.SellType};{mysteryConfig.SellValue}"))
            {
                ErrorHelp.Instance.ErrorHint(ErrorCode.ERR_HouBiNotEnough);
                return;
            }

            if (self.MysteryItemInfo.ItemNumber < 1)
            {
                FloatTipManager.Instance.ShowFloatTip("请等待下次商店刷新");
                return;
            }

            C2M_JiaYuanMysteryBuyRequest c2M_MysteryBuyRequest = new C2M_JiaYuanMysteryBuyRequest()
            {
                MysteryId = self.MysteryItemInfo.MysteryId, ProductId = self.MysteryItemInfo.ProductId
            };
            M2C_JiaYuanMysteryBuyResponse r2c_roleEquip =
                    (M2C_JiaYuanMysteryBuyResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(c2M_MysteryBuyRequest);
            ItemConfig itemConfig = ItemConfigCategory.Instance.Get(mysteryConfig.SellItemID);
            self.GetParent<UIJiaYuanMystery_AComponent>()?.RequestMystery();
        }

        public static void OnUpdateUI(this UIJiaYuanMysteryItem_AComponent self, MysteryItemInfo mysteryItemInfo)
        {
            MysteryConfig mysteryConfig = MysteryConfigCategory.Instance.Get(mysteryItemInfo.MysteryId);
            self.MysteryItemInfo = mysteryItemInfo;

            ItemConfig itemConfig = ItemConfigCategory.Instance.Get(mysteryConfig.SellType);
            string path =ABPathHelper.GetAtlasPath_2(ABAtlasTypes.ItemIcon, itemConfig.Icon);
            Sprite sp = ResourcesComponent.Instance.LoadAsset<Sprite>(path);
            if (!self.AssetPath.Contains(path))
            {
                self.AssetPath.Add(path);
            }
            self.Image_gold.GetComponent<Image>().sprite = sp;

            // 判断家园等级是否足够
            int jiayuanid = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.JiaYuanLv;
            JiaYuanConfig jiayuanCof = JiaYuanConfigCategory.Instance.Get(jiayuanid);
            if (mysteryConfig.JiaYuanLv <= jiayuanCof.Lv)
            {
                // self.Text_Number.GetComponent<Text>().text = $"剩余 {self.MysteryItemInfo.ItemNumber}件";
                self.Text_value.GetComponent<Text>().text = mysteryConfig.SellValue.ToString();
            }
            else
            {
                self.Text_Tip.SetActive(true);
                self.Text_Tip.GetComponent<Text>().text = $"家园{mysteryConfig.JiaYuanLv}级开启";
                Material mat = ResourcesComponent.Instance.LoadAsset<Material>(ABPathHelper.GetMaterialPath("UI_Hui"));
                self.UICommonItem.Image_ItemIcon.GetComponent<Image>().material = mat;
                //self.UICommonItem.Image_ItemQuality.GetComponent<Image>().color = new Color(100 / 255f, 100 / 255f, 100 / 255f, 1f);
                self.Image_gold.SetActive(false);
                self.Text_value.SetActive(false);
            }

            self.UICommonItem.UpdateItem(new BagInfo() { ItemID = self.MysteryItemInfo.ItemID }, ItemOperateEnum.None);
            self.UICommonItem.Label_ItemNum.SetActive(false);
        }
    }
}