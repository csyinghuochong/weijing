using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UITeamDungeonShopComponent: Entity, IAwake<GameObject>, IDestroy
    {
        public int BuyNum;
        public int SellId;
        public GameObject ButtonBuy;
        public GameObject ItemListNode;
        public GameObject GameObject;
        public GameObject ItemIconShow;
        public GameObject ItemNum;
        public GameObject Obj_Lab_BuyNum;
        public GameObject Btn_BuyNum_jia1;
        public GameObject Btn_BuyNum_jia10;
        public GameObject Btn_BuyNum_jian1;
        public GameObject Btn_BuyNum_jian10;
        public GameObject UIBattleShopItem;
        public List<UIStoreItemComponent> SellList = new List<UIStoreItemComponent>();
    }

    public class UITeamDungeonShopComponentAwake: AwakeSystem<UITeamDungeonShopComponent, GameObject>
    {
        public override void Awake(UITeamDungeonShopComponent self, GameObject gameObject)
        {
            self.BuyNum = 0;
            self.SellId = 0;
            self.SellList.Clear();
            self.GameObject = gameObject;
            ReferenceCollector rc = gameObject.GetComponent<ReferenceCollector>();
            self.ItemListNode = rc.Get<GameObject>("ItemListNode");
            self.ItemIconShow = rc.Get<GameObject>("ItemIconShow");
            self.ItemNum = rc.Get<GameObject>("ItemNum");

            self.Obj_Lab_BuyNum = rc.Get<GameObject>("Lab_BuyNum");

            self.Btn_BuyNum_jia1 = rc.Get<GameObject>("Btn_BuyNum_jia1");
            self.Btn_BuyNum_jia1.GetComponent<Button>().onClick.AddListener(() => { self.OnClickChangeBuyNum(1); });

            self.Btn_BuyNum_jia10 = rc.Get<GameObject>("Btn_BuyNum_jia10");
            self.Btn_BuyNum_jia10.GetComponent<Button>().onClick.AddListener(() => { self.OnClickChangeBuyNum(10); });

            self.Btn_BuyNum_jian1 = rc.Get<GameObject>("Btn_BuyNum_jian1");
            self.Btn_BuyNum_jian1.GetComponent<Button>().onClick.AddListener(() => { self.OnClickChangeBuyNum(-1); });

            self.Btn_BuyNum_jian10 = rc.Get<GameObject>("Btn_BuyNum_jian10");
            self.Btn_BuyNum_jian10.GetComponent<Button>().onClick.AddListener(() => { self.OnClickChangeBuyNum(-10); });
            self.UIBattleShopItem = rc.Get<GameObject>("UIBattleShopItem");
            self.UIBattleShopItem.SetActive(false);

            self.ButtonBuy = rc.Get<GameObject>("ButtonBuy");
            ButtonHelp.AddListenerEx(self.ButtonBuy, self.OnButtonBuy);

            DataUpdateComponent.Instance.AddListener(DataType.BagItemUpdate, self);

            self.OnClickChangeBuyNum(1);
        }
    }

    public class UITeamDungeonShopComponentDestroySystem: DestroySystem<UITeamDungeonShopComponent>
    {
        public override void Destroy(UITeamDungeonShopComponent self)
        {
            DataUpdateComponent.Instance.RemoveListener(DataType.BagItemUpdate, self);
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

            self.ZoneScene().GetComponent<BagComponent>().SendBuyItem(self.SellId, self.BuyNum).Coroutine();
        }

        public static void OnClickHandler(this UITeamDungeonShopComponent self, int sellId)
        {
            self.SellId = sellId;
            for (int i = 0; i < self.SellList.Count; i++)
            {
                self.SellList[i].SetSelected(sellId);
            }

            self.OnClickChangeBuyNum(1 - self.BuyNum);
        }

        /// <summary>
        /// 改变当前购买数量
        /// </summary>
        /// <param name="self"></param>
        /// <param name="num"></param>
        public static void OnClickChangeBuyNum(this UITeamDungeonShopComponent self, int num)
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

                GameObject storeItem = GameObject.Instantiate(self.UIBattleShopItem);
                storeItem.SetActive(true);
                UICommonHelper.SetParent(storeItem, self.ItemListNode);
                UIStoreItemComponent uIItemComponent = self.AddChild<UIStoreItemComponent, GameObject>(storeItem);
                uIItemComponent.OnUpdateData(storeSellConfig);
                uIItemComponent.SetClickHandler(self.OnClickHandler);
                self.SellList.Add(uIItemComponent);
            }
        }
    }
}