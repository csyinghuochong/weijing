using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


namespace ET
{
    public class UIBattleShopComponent : Entity, IAwake
    {
        public int SellId;
        public GameObject ButtonBuy;
        public GameObject ItemListNode;
        public List<UIStoreItemComponent> SellList = new List<UIStoreItemComponent>();
    }

    [ObjectSystem]
    public class UIBattleShopComponentAwakeSystem : AwakeSystem<UIBattleShopComponent>
    {

        public override void Awake(UIBattleShopComponent self)
        {
            self.SellId = 0;
            self.SellList.Clear();
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
            self.ItemListNode = rc.Get<GameObject>("ItemListNode");

            self.ButtonBuy = rc.Get<GameObject>("ButtonBuy");
            ButtonHelp.AddListenerEx( self.ButtonBuy, self.OnButtonBuy );

            self.GetParent<UI>().OnUpdateUI = self.OnUpdateUI;
            self.OnInitUI();
        }
    }

    public static class UIBattleShopComponentSystem
    {

        public static void OnButtonBuy(this UIBattleShopComponent self)
        {
            if (self.SellId == 0)
            {
                FloatTipManager.Instance.ShowFloatTip("请选择道具！");
                return;
            }
            self.ZoneScene().GetComponent<BagComponent>().SendBuyItem(self.SellId).Coroutine(); 
        }

        public static void OnUpdateUI(this UIBattleShopComponent self)
        {
            self.OnClickHandler(0);
        }

        public static void OnClickHandler(this UIBattleShopComponent self, int sellId)
        {
            self.SellId = sellId;
            for (int i = 0; i < self.SellList.Count; i++)
            {
                self.SellList[i].SetSelected(sellId);
            }
        }

        public static void OnInitUI(this UIBattleShopComponent self)
        {
            string path_1 = ABPathHelper.GetUGUIPath("Main/Battle/UIBattleShopItem");
            GameObject bundleObj = ResourcesComponent.Instance.LoadAsset<GameObject>(path_1);

            int shopSellid = GlobalValueConfigCategory.Instance.Get(55).Value2;
            int playLv = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.Lv;
            while (shopSellid != 0)
            {
                StoreSellConfig storeSellConfig = StoreSellConfigCategory.Instance.Get(shopSellid);
                shopSellid = storeSellConfig.NextID;
                if (playLv < storeSellConfig.ShowRoleLvMin || playLv > storeSellConfig.ShowRoleLvMax)
                {
                    continue;
                }

                GameObject storeItem = GameObject.Instantiate(bundleObj);
                UICommonHelper.SetParent(storeItem, self.ItemListNode);
                UIStoreItemComponent uIItemComponent = self.AddChild<UIStoreItemComponent, GameObject>(storeItem);
                uIItemComponent.OnUpdateData(storeSellConfig);
                uIItemComponent.SetClickHandler(self.OnClickHandler);
                self.SellList.Add(uIItemComponent);
            }
        }
    }
}