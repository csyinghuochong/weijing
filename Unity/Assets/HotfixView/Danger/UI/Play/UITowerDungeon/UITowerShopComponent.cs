using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UITowerShopComponent : Entity, IAwake
    {
        public int SellId;
        public GameObject ButtonBuy;
        public GameObject ItemListNode;
        public List<UIStoreItemComponent> SellList = new List<UIStoreItemComponent>();

        public GameObject Btn_BuyNum_jian10;
        public GameObject Btn_BuyNum_jian1;
        public GameObject Btn_BuyNum_jia10;
        public GameObject Btn_BuyNum_jia1;

        public GameObject Lab_RmbNum;
        public GameObject Lab_Num;
    }


    public class UITowerShopComponentAwake : AwakeSystem<UITowerShopComponent>
    {

        public override void Awake(UITowerShopComponent self)
        {
            self.SellId = 0;
            self.SellList.Clear();
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
            self.ItemListNode = rc.Get<GameObject>("ItemListNode");

            self.ButtonBuy = rc.Get<GameObject>("ButtonBuy");
            ButtonHelp.AddListenerEx(self.ButtonBuy, self.OnButtonBuy);

            self.Lab_RmbNum = rc.Get<GameObject>("Lab_RmbNum");
            self.Lab_Num = rc.Get<GameObject>("Lab_Num");
            self.Btn_BuyNum_jian10 = rc.Get<GameObject>("Btn_BuyNum_jian10");
            self.Btn_BuyNum_jian10.GetComponent<Button>().onClick.AddListener(() => { self.OnBtn_BuyNum_jia(-10); });
            self.Btn_BuyNum_jian1 = rc.Get<GameObject>("Btn_BuyNum_jian1");
            self.Btn_BuyNum_jian1.GetComponent<Button>().onClick.AddListener(() => { self.OnBtn_BuyNum_jia(-1); });
            self.Btn_BuyNum_jia10 = rc.Get<GameObject>("Btn_BuyNum_jia10");
            self.Btn_BuyNum_jia10.GetComponent<Button>().onClick.AddListener(() => { self.OnBtn_BuyNum_jia(10); });
            self.Btn_BuyNum_jia1 = rc.Get<GameObject>("Btn_BuyNum_jia1");
            self.Btn_BuyNum_jia1.GetComponent<Button>().onClick.AddListener(() => { self.OnBtn_BuyNum_jia(1); });

            self.GetParent<UI>().OnUpdateUI = self.OnUpdateUI;
            self.OnInitUI();

            //默认购买数量为1
            self.Lab_RmbNum.GetComponent<InputField>().text = "1";
        }
    }

    public static class UITowerShopComponentSystem
    {

        public static async void OnButtonBuy(this UITowerShopComponent self)
        {
            if (self.SellId == 0)
            {
                FloatTipManager.Instance.ShowFloatTip("请选择道具！");
                return;
            }
            int buyNum = int.Parse(self.Lab_RmbNum.GetComponent<InputField>().text);
            await self.ZoneScene().GetComponent<BagComponent>().SendBuyItem(self.SellId, buyNum);
            self.OnUpdateNumShow();
        }

        public static void OnUpdateUI(this UITowerShopComponent self)
        {
            self.OnClickHandler(0);
        }

        public static void OnClickHandler(this UITowerShopComponent self, int sellId)
        {
            self.SellId = sellId;
            for (int i = 0; i < self.SellList.Count; i++)
            {
                self.SellList[i].SetSelected(sellId);
            }
        }

        public static void OnInitUI(this UITowerShopComponent self)
        {
            string path_1 = ABPathHelper.GetUGUIPath("TowerDungeon/UITowerShopItem");
            GameObject bundleObj = ResourcesComponent.Instance.LoadAsset<GameObject>(path_1);

            int shopSellid = GlobalValueConfigCategory.Instance.Get(64).Value2;
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

            //获取道具数量进行显示
            self.OnUpdateNumShow();
        }

        public static void OnUpdateNumShow(this UITowerShopComponent self) {
            //获取道具数量进行显示
            self.Lab_Num.GetComponent<Text>().text = "当前拥有数量:" + self.ZoneScene().GetComponent<BagComponent>().GetItemNumber(10000148);
        }

        public static void OnBtn_BuyNum_jia(this UITowerShopComponent self, int num)
        {

            long diamondsNumber = long.Parse(self.Lab_RmbNum.GetComponent<InputField>().text);

            if (num > 0 && diamondsNumber >= 100)
            {
                FloatTipManager.Instance.ShowFloatTip("购买最多100个！");
                return;
            }

            diamondsNumber += num;
            if (diamondsNumber < 1)
                diamondsNumber = 1;
            //单次兑换最多100
            if (diamondsNumber > 100)
            {
                diamondsNumber = 100;
            }

            self.Lab_RmbNum.GetComponent<InputField>().text = diamondsNumber.ToString();
        }
    }
}
