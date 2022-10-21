using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


namespace ET
{
    public class UIBattleShopComponent : Entity, IAwake
    {
        public GameObject ItemListNode;
        public List<UIStoreItemComponent> SellList = new List<UIStoreItemComponent>();
    }

    [ObjectSystem]
    public class UIBattleShopComponentAwakeSystem : AwakeSystem<UIBattleShopComponent>
    {

        public override void Awake(UIBattleShopComponent self)
        {
            self.SellList.Clear();
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
            self.ItemListNode = rc.Get<GameObject>("ItemListNode");

            self.GetParent<UI>().OnUpdateUI = self.OnUpdateUI;
        }
    }

    public static class UIBattleShopComponentSystem
    {
        public static void OnUpdateUI(this UIBattleShopComponent self)
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
                self.SellList.Add(uIItemComponent);
            }
        }
    }
}