using System.Collections.Generic;
using UnityEngine;

namespace ET
{
    public class UITeamDungeonShopComponent : Entity, IAwake<GameObject>
    {
        public int SellId;
        public GameObject ButtonBuy;
        public GameObject ItemListNode;
        public GameObject GameObject;
        public List<UIStoreItemComponent> SellList = new List<UIStoreItemComponent>();
    }


    [ObjectSystem]
    public class UITeamDungeonShopComponentAwake : AwakeSystem<UITeamDungeonShopComponent, GameObject>
    {

        public override void Awake(UITeamDungeonShopComponent self, GameObject gameObject)
        {
            self.SellId = 0;
            self.SellList.Clear();
            self.GameObject = gameObject;   
            ReferenceCollector rc = gameObject.GetComponent<ReferenceCollector>();
            self.ItemListNode = rc.Get<GameObject>("ItemListNode");

            self.ButtonBuy = rc.Get<GameObject>("ButtonBuy");
            ButtonHelp.AddListenerEx(self.ButtonBuy, self.OnButtonBuy);
        }
    }

    public static class UITeamDungeonShopComponentSystem
    {

        public static void OnButtonBuy(this UITeamDungeonShopComponent self)
        {
            if (self.SellId == 0)
            {
                FloatTipManager.Instance.ShowFloatTip("请选择道具！");
                return;
            }
            self.ZoneScene().GetComponent<BagComponent>().SendBuyItem(self.SellId).Coroutine();
        }

        public static void OnClickHandler(this UITeamDungeonShopComponent self, int sellId)
        {
            self.SellId = sellId;
            for (int i = 0; i < self.SellList.Count; i++)
            {
                self.SellList[i].SetSelected(sellId);
            }
        }

        public static void OnUpdateUI(this UITeamDungeonShopComponent self)
        {
            if (self.SellList.Count > 0)
            {
                return;
            }
            string path_1 = ABPathHelper.GetUGUIPath("BattleDungeon/UIBattleShopItem");
            GameObject bundleObj = ResourcesComponent.Instance.LoadAsset<GameObject>(path_1);

            int shopSellid = GlobalValueConfigCategory.Instance.Get(76).Value2;
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
