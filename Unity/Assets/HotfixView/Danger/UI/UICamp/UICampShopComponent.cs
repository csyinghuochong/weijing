using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace ET
{
    public class UICampShopComponent : Entity, IAwake
    {
        public GameObject ShopNodeList;
    }

    [ObjectSystem]
    public class UICampShopComponentAwakeSystem : AwakeSystem<UICampShopComponent>
    {
        public override void Awake(UICampShopComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.ShopNodeList = rc.Get<GameObject>("ShopNodeList");

            self.OnInitUI().Coroutine();
        }
    }

    public static class UICampShopComponentSystem
    {
        public static async ETTask OnInitUI(this UICampShopComponent self)
        {
            string path = ABPathHelper.GetUGUIPath("Main/Camp/UICampShopItem");
            GameObject bundleObj = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);

            int shopSellid = 0;
            while (shopSellid != 0)
            {
                StoreSellConfig storeSellConfig = StoreSellConfigCategory.Instance.Get(shopSellid);
                shopSellid = storeSellConfig.NextID;

                GameObject gameObject = GameObject.Instantiate(bundleObj);
                UICommonHelper.SetParent(gameObject, self.ShopNodeList);
                UICampShopItemComponent uICampShop = self.AddChild<UICampShopItemComponent, GameObject>(gameObject);
                uICampShop.OnUpdateUI(storeSellConfig);
            }
        }
    }
}
