using System;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIPaiMaiShopItemComponent : Entity, IAwake
    {
        public GameObject ItemTipsSet;
        public GameObject ImageSelect;
        public GameObject ImageButton;
        public GameObject Obj_Lab_Price;
        public GameObject Obj_Lab_Tips;

        public UIItemComponent UIItemComponent;
        public PaiMaiShopItemInfo PaiMaiShopItemInfo;
        public int PaiMaiId;
        public Action<int> ClickHandler;
    }

    [ObjectSystem]
    public class UIPaiMaiShopItemComponentAwakeSystem : AwakeSystem<UIPaiMaiShopItemComponent>
    {
        public override void Awake(UIPaiMaiShopItemComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.ItemTipsSet = rc.Get<GameObject>("ItemTipsSet");
            self.ImageSelect = rc.Get<GameObject>("ImageSelect");
            self.Obj_Lab_Price = rc.Get<GameObject>("Lab_Price");
            self.Obj_Lab_Tips = rc.Get<GameObject>("Lab_Tips");
            self.ImageSelect.SetActive(false);
            self.ImageButton = rc.Get<GameObject>("ImageButton");
            self.ImageButton.GetComponent<Button>().onClick.AddListener(() => { self.ImageButton(); });

            self.PaiMaiId = 0;
            self.UIItemComponent = null;
            self.OnInitUI();
        }
    }

    public static class UIPaiMaiShopItemComponentSystem
    {
        public static  void OnInitUI(this UIPaiMaiShopItemComponent self)
        {
            var path = ABPathHelper.GetUGUIPath("Main/Common/UICommonItem");
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject bagSpace = GameObject.Instantiate(bundleGameObject);
            UICommonHelper.SetParent(bagSpace, self.ItemTipsSet);

            UI uiitem = self.AddChild<UI, string, GameObject>("UIItem", bagSpace);
            self.UIItemComponent = uiitem.AddComponent<UIItemComponent>();
            self.UIItemComponent.ClickItemHandler = (BagInfo baginfo) => { self.OnClickPaiMaiItem(baginfo.BagInfoID); };
            uiitem.GameObject.transform.localScale = Vector3.one * 0.9f;
            if (self.PaiMaiId != 0)
            {
                self.OnUpdateData( self.PaiMaiId, self.PaiMaiShopItemInfo );
            }
        }

        public static void ImageButton(this UIPaiMaiShopItemComponent self)
        {
            self.ClickHandler( self.PaiMaiId );
        }

        public static void OnClickPaiMaiItem(this UIPaiMaiShopItemComponent self, long paimaiId)
        {
            self.ClickHandler(self.PaiMaiId);
        }

        //注册回调方法
        public static void SetClickHandler(this UIPaiMaiShopItemComponent self, Action<int> action)
        {
            self.ClickHandler = action;
        }

        public static void SetSelected(this UIPaiMaiShopItemComponent self, int paimaiId)
        {
            self.ImageSelect.SetActive( self.PaiMaiId == paimaiId );

            //更新主界面显示
            //self.ClickHandler(self.PaiMaiId);

        }

        public static void OnUpdateData(this UIPaiMaiShopItemComponent self, int paimaiId, PaiMaiShopItemInfo shopItemInfo)
        {
            self.PaiMaiId = paimaiId;
            self.PaiMaiShopItemInfo = shopItemInfo;
            if (self.UIItemComponent == null)
            {
                return;
            }

            PaiMaiSellConfig paiMaiSellConfig = PaiMaiSellConfigCategory.Instance.Get(paimaiId);

            //获取拍卖数据
            //PaiMaiShopItemInfo paiMaiShopItemInfo = self.Parent.Parent.GetComponent<UIPaiMaiShopComponent>().PaiMaiShopItemInfos[paiMaiSellConfig.ItemID];

            self.UIItemComponent.UpdateItem( new BagInfo() { BagInfoID = paimaiId, ItemID = paiMaiSellConfig.ItemID }, ItemOperateEnum.None );
            self.UIItemComponent.Label_ItemNum.SetActive(false);  //不显示道具数据

            //显示当前价格
            self.Obj_Lab_Price.GetComponent<Text>().text = shopItemInfo.Price.ToString();

            string des = "";
            if (shopItemInfo.PricePro <= 0.95f)
            {
                des = "近期价格下降";
                self.Obj_Lab_Tips.GetComponent<Text>().color = new Color(200f / 255f, 255f / 255f, 130f / 255f);
            }

            if (shopItemInfo.PricePro > 0.95f&& shopItemInfo.PricePro < 1.95f)
            {
                des = "近期价格稳定";
                //self.Obj_Lab_Tips.GetComponent<Text>().color = new Color(255f / 255f, 255f / 255f, 255f / 255f);
                //self.Obj_Lab_Tips.GetComponent<Text>().color = new Color(137f / 255f, 89f / 255f, 51f / 255f);
                self.Obj_Lab_Tips.GetComponent<Text>().color = new Color(100f / 255f, 100f / 255f, 100f / 255f);
            }

            if (shopItemInfo.PricePro >= 1.05f)
            {
                des = "近期价格上涨";
                self.Obj_Lab_Tips.GetComponent<Text>().color = new Color(255f / 255f, 222f / 255f, 129f / 255f);
            }

            self.Obj_Lab_Tips.GetComponent<Text>().text = GameSettingLanguge.LoadLocalization(des);
        }
    }
}
