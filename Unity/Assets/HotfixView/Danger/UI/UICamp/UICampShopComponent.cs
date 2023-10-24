using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace ET
{
    public class UICampShopComponent : Entity, IAwake
    {
        public GameObject ShopNodeList;
        public GameObject UICampShopItem;
    }


    public class UICampShopComponentAwakeSystem : AwakeSystem<UICampShopComponent>
    {
        public override void Awake(UICampShopComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.ShopNodeList = rc.Get<GameObject>("ShopNodeList");
            self.UICampShopItem = rc.Get<GameObject>("UICampShopItem");

            self.UICampShopItem.SetActive(false);
            self.OnInitUI();
        }
    }

    public static class UICampShopComponentSystem
    {
        public static  void OnInitUI(this UICampShopComponent self)
        {
            int shopSellid = 0;
            while (shopSellid != 0)
            {
                StoreSellConfig storeSellConfig = StoreSellConfigCategory.Instance.Get(shopSellid);
                shopSellid = storeSellConfig.NextID;

                GameObject gameObject = GameObject.Instantiate(self.UICampShopItem);
                gameObject.SetActive(true);
                UICommonHelper.SetParent(gameObject, self.ShopNodeList);
                UICampShopItemComponent uICampShop = self.AddChild<UICampShopItemComponent, GameObject>(gameObject);
                uICampShop.OnUpdateUI(storeSellConfig);
            }
        }
    }
}
