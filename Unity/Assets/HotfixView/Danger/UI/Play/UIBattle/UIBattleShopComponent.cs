using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIBattleShopComponent: Entity, IAwake
    {
        public int BuyNum;
        public int SellId;
        public GameObject Image_1;
        public GameObject ButtonBuy;
        public GameObject Obj_Lab_BuyPrice;
        public GameObject Obj_Lab_BuyNum;
        public GameObject Btn_BuyNum_jia1;
        public GameObject Btn_BuyNum_jia10;
        public GameObject Btn_BuyNum_jian1;
        public GameObject Btn_BuyNum_jian10;
        public GameObject ItemListNode;
        public List<UIStoreItemComponent> SellList = new List<UIStoreItemComponent>();
    }

    public class UIBattleShopComponentAwakeSystem: AwakeSystem<UIBattleShopComponent>
    {
        public override void Awake(UIBattleShopComponent self)
        {
            self.SellId = 0;
            self.SellList.Clear();
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
            self.ItemListNode = rc.Get<GameObject>("ItemListNode");

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
            
            Sprite sp =  ABAtlasHelp.GetIconSprite(ABAtlasTypes.ItemIcon, "10010035");
            self.Image_1 = rc.Get<GameObject>("Image_1");
            self.Image_1.GetComponent<Image>().sprite = sp;
            
            self.Obj_Lab_BuyNum.GetComponent<Text>().text = "1";
            self.Obj_Lab_BuyPrice.GetComponent<Text>().text = "0";
            
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

            self.ZoneScene().GetComponent<BagComponent>().SendBuyItem(self.SellId, self.BuyNum).Coroutine();
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

            if (sellId != 0)
            {
                self.OnClickChangeBuyNum(1 - self.BuyNum);
            }
        }

        public static void OnInitUI(this UIBattleShopComponent self)
        {
            string path_1 = ABPathHelper.GetUGUIPath("BattleDungeon/UIBattleShopItem");
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

        //改变当前购买数量
        public static void OnClickChangeBuyNum(this UIBattleShopComponent self, int num)
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

            StoreSellConfig storeSellConfig = StoreSellConfigCategory.Instance.Get(self.SellId);

            //价格显示
            self.Obj_Lab_BuyPrice.GetComponent<Text>().text = (storeSellConfig.SellValue * self.BuyNum).ToString();
        }
    }
}