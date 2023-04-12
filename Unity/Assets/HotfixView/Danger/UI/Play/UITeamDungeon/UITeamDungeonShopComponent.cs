using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UITeamDungeonShopComponent : Entity, IAwake<GameObject>
    {
        public int SellId;
        public GameObject ButtonBuy;
        public GameObject ItemListNode;
        public GameObject GameObject;
        public GameObject ItemIconShow;
        public GameObject ItemNum;
        public List<UIStoreItemComponent> SellList = new List<UIStoreItemComponent>();
    }



    public class UITeamDungeonShopComponentAwake : AwakeSystem<UITeamDungeonShopComponent, GameObject>
    {

        public override void Awake(UITeamDungeonShopComponent self, GameObject gameObject)
        {
            self.SellId = 0;
            self.SellList.Clear();
            self.GameObject = gameObject;   
            ReferenceCollector rc = gameObject.GetComponent<ReferenceCollector>();
            self.ItemListNode = rc.Get<GameObject>("ItemListNode");
            self.ItemIconShow = rc.Get<GameObject>("ItemIconShow");
            self.ItemNum = rc.Get<GameObject>("ItemNum");

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

            //更新自身拥有的货币显示
            int itemShowID = 10000149;
            self.ItemIconShow.GetComponent<Image>().sprite = ABAtlasHelp.GetIconSprite(ABAtlasTypes.ItemIcon, itemShowID.ToString());
            self.ItemNum.GetComponent<Text>().text = self.ZoneScene().GetComponent<BagComponent>().GetItemNumber(itemShowID).ToString();

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
