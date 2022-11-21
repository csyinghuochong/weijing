using System;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{ 

    public class UICampShopItemComponent : Entity, IAwake<GameObject>
    {
        public GameObject Text_Money;
        public GameObject Button_Buy;
        public GameObject UICommonItem;
        public UIItemComponent UIItemComponent;
    }

    [ObjectSystem]
    public class UICampShopItemComponentAwakeSystem : AwakeSystem<UICampShopItemComponent, GameObject>
    {
        public override void Awake(UICampShopItemComponent self, GameObject gameObject)
        {
            ReferenceCollector rc = gameObject.GetComponent<ReferenceCollector>();

            self.Text_Money = rc.Get<GameObject>("Text_Money");

            self.Button_Buy = rc.Get<GameObject>("Button_Buy");
            ButtonHelp.AddListenerEx( self.Button_Buy, () =>{ self.OnButton_Buy().Coroutine();  } );

            self.UICommonItem = rc.Get<GameObject>("UICommonItem");
            self.UIItemComponent = self.AddChild<UIItemComponent, GameObject>(self.UICommonItem);
        }
    }

    public static class UICampShopItemComponentStstem
    {
        public static void OnUpdateUI(this UICampShopItemComponent self, StoreSellConfig campShopConfig)
        {
            self.Text_Money.GetComponent<Text>().text = campShopConfig.SellValue.ToString();
            self.UIItemComponent.UpdateItem( new BagInfo() { ItemID = campShopConfig.SellItemID } );
            self.UIItemComponent.Label_ItemNum.SetActive(false);
        }

        public static async ETTask OnButton_Buy(this UICampShopItemComponent self)
        {
            await ETTask.CompletedTask;
        }
    }
}
