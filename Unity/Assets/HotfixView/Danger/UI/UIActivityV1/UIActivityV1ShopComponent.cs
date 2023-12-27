using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIActivityV1ShopComponent: Entity, IAwake, IDestroy
    {
        public int BuyNum;
        public int SellId;
        public GameObject ButtonBuy;
        public GameObject Obj_Lab_BuyPrice;
        public GameObject Obj_Lab_BuyNum;
        public GameObject Btn_BuyNum_jia1;
        public GameObject Btn_BuyNum_jia10;
        public GameObject Btn_BuyNum_jian1;
        public GameObject Btn_BuyNum_jian10;
        public GameObject ItemListNode;
        public GameObject UIBattleShopItem;
        public List<UIStoreItemComponent> SellList = new List<UIStoreItemComponent>();
    }

    public class UIActivityV1ShopComponentAwake: AwakeSystem<UIActivityV1ShopComponent>
    {
        public override void Awake(UIActivityV1ShopComponent self)
        {
            self.SellId = 0;
            self.SellList.Clear();
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
            self.ItemListNode = rc.Get<GameObject>("ItemListNode");
            self.UIBattleShopItem = rc.Get<GameObject>("UIBattleShopItem");
            self.UIBattleShopItem.SetActive(false);

            self.ButtonBuy = rc.Get<GameObject>("ButtonBuy");
            ButtonHelp.AddListenerEx(self.ButtonBuy, self.OnButtonBuy);

            self.Btn_BuyNum_jia1 = rc.Get<GameObject>("Btn_BuyNum_jia1");
            self.Btn_BuyNum_jia1.GetComponent<Button>().onClick.AddListener(() => { self.OnClickChangeBuyNum(1); });

            self.Btn_BuyNum_jia10 = rc.Get<GameObject>("Btn_BuyNum_jia10");
            self.Btn_BuyNum_jia10.GetComponent<Button>().onClick.AddListener(() => { self.OnClickChangeBuyNum(10); });

            self.Btn_BuyNum_jian1 = rc.Get<GameObject>("Btn_BuyNum_jian1");
            self.Btn_BuyNum_jian1.GetComponent<Button>().onClick.AddListener(() => { self.OnClickChangeBuyNum(-1); });

            self.Btn_BuyNum_jian10 = rc.Get<GameObject>("Btn_BuyNum_jian10");
            self.Btn_BuyNum_jian10.GetComponent<Button>().onClick.AddListener(() => { self.OnClickChangeBuyNum(-10); });

            self.Obj_Lab_BuyPrice = rc.Get<GameObject>("Lab_BuyPrice");
            self.Obj_Lab_BuyNum = rc.Get<GameObject>("Lab_BuyNum");

            DataUpdateComponent.Instance.AddListener(DataType.BagItemUpdate, self);

            self.Obj_Lab_BuyNum.GetComponent<Text>().text = "1";
            self.Obj_Lab_BuyPrice.GetComponent<Text>().text = "0";

            self.GetParent<UI>().OnUpdateUI = self.OnUpdateUI;
            self.OnInitUI();
        }
    }

    public class UIActivityV1ShopComponentDestroySystem: DestroySystem<UIActivityV1ShopComponent>
    {
        public override void Destroy(UIActivityV1ShopComponent self)
        {
            DataUpdateComponent.Instance.RemoveListener(DataType.BagItemUpdate, self);
        }
    }

    public static class UIActivityV1ShopComponentSystem
    {
        public static void OnButtonBuy(this UIActivityV1ShopComponent self)
        {
            if (self.SellId == 0)
            {
                FloatTipManager.Instance.ShowFloatTip("请选择道具！");
                return;
            }

            self.ZoneScene().GetComponent<BagComponent>().SendBuyItem(self.SellId, self.BuyNum).Coroutine();
        }

        public static void OnUpdateUI(this UIActivityV1ShopComponent self)
        {
            self.OnClickHandler(0);
        }

        public static void OnClickHandler(this UIActivityV1ShopComponent self, int sellId)
        {
            self.SellId = sellId;
            for (int i = 0; i < self.SellList.Count; i++)
            {
                self.SellList[i].SetSelected(sellId);
            }

            if (sellId != 0)
            {
                self.OnClickChangeBuyNum(1 - self.BuyNum);
            }
        }

        public static void OnInitUI(this UIActivityV1ShopComponent self)
        {
            int shopSellid = GlobalValueConfigCategory.Instance.Get(114).Value2;
            int playLv = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.Lv;
            while (shopSellid != 0)
            {
                StoreSellConfig storeSellConfig = StoreSellConfigCategory.Instance.Get(shopSellid);
                shopSellid = storeSellConfig.NextID;
                if (playLv < storeSellConfig.ShowRoleLvMin || playLv > storeSellConfig.ShowRoleLvMax)
                {
                    continue;
                }

                GameObject storeItem = UnityEngine.Object.Instantiate(self.UIBattleShopItem);
                storeItem.SetActive(true);
                UICommonHelper.SetParent(storeItem, self.ItemListNode);
                UIStoreItemComponent uIItemComponent = self.AddChild<UIStoreItemComponent, GameObject>(storeItem);
                uIItemComponent.OnUpdateData(storeSellConfig);
                uIItemComponent.SetClickHandler(self.OnClickHandler);
                self.SellList.Add(uIItemComponent);
            }

            self.UpdateItemNum();
        }

        public static void UpdateItemNum(this UIActivityV1ShopComponent self)
        {
            long itemNum = self.ZoneScene().GetComponent<BagComponent>().GetItemNumber(3);
            // 货币拥有数量显示
            self.Obj_Lab_BuyPrice.GetComponent<Text>().text = itemNum.ToString();
        }

        //改变当前购买数量
        public static void OnClickChangeBuyNum(this UIActivityV1ShopComponent self, int num)
        {
            if (num > 0 && self.BuyNum >= 100)
            {
                FloatTipManager.Instance.ShowFloatTip("单次购买数量最多为100");
                return;
            }

            self.BuyNum += num;
            if (self.BuyNum <= 1)
            {
                self.BuyNum = 1;
            }

            //单词购买最多100个
            if (self.BuyNum > 100)
            {
                self.BuyNum = 100;
            }

            //数量显示
            self.Obj_Lab_BuyNum.GetComponent<Text>().text = self.BuyNum.ToString();
        }
    }
}