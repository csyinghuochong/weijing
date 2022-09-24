using System;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIPaiMaiSellItemComponent : Entity, IAwake
    {
        public GameObject TextName;
        public GameObject ImageButton;
        public GameObject ItemSet;
        public GameObject Img_XuanZhong;
        public GameObject TextPrice;
        public GameObject TextTime;

        public UI UIItem;
        public PaiMaiItemInfo PaiMaiItemInfo;
        public Action<PaiMaiItemInfo> ClickHandler;
    }

    [ObjectSystem]
    public class UIPaiMaiSellItemComponentAwakeSystem : AwakeSystem<UIPaiMaiSellItemComponent>
    {
        public override void Awake(UIPaiMaiSellItemComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
            self.UIItem = null;
            self.PaiMaiItemInfo = null;
            self.TextName = rc.Get<GameObject>("TextName");
            self.ImageButton = rc.Get<GameObject>("ImageButton");
            self.ImageButton.GetComponent<Button>().onClick.AddListener(() => { self.OnImageButton(); } );

            self.ItemSet = rc.Get<GameObject>("ItemSet");
            self.Img_XuanZhong = rc.Get<GameObject>("Img_XuanZhong");
            self.Img_XuanZhong.SetActive(false);

            self.TextPrice = rc.Get<GameObject>("TextPrice");
            self.TextTime = rc.Get<GameObject>("TextTime");


            self.OnInitUI().Coroutine();
        }
    }

    public static class UIPaiMaiSellItemComponentSystem
    {
        public static async ETTask OnInitUI(this UIPaiMaiSellItemComponent self)
        {
            var path = ABPathHelper.GetUGUIPath("Main/Common/UICommonItem");
            var bundleGameObject = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);
            GameObject bagSpace = GameObject.Instantiate(bundleGameObject);
            UICommonHelper.SetParent(bagSpace, self.ItemSet);

            self.UIItem = self.AddChild<UI, string, GameObject>("UIItem", bagSpace);
            self.UIItem.AddComponent<UIItemComponent>();
            self.UIItem.GameObject.transform.localScale = Vector3.one * 1f;
            self.UIItem.GetComponent<UIItemComponent>().Label_ItemName.SetActive(false);

            if (self.PaiMaiItemInfo != null)
            {
                self.OnUpdateUI(self.PaiMaiItemInfo);
            }
        }

        public static void SetSelected(this UIPaiMaiSellItemComponent self, long uid)
        {
            self.Img_XuanZhong.SetActive(self.PaiMaiItemInfo.Id == uid);
        }

        public static void OnUpdateUI(this UIPaiMaiSellItemComponent self, PaiMaiItemInfo paiMaiItemInfo)
        {
            self.PaiMaiItemInfo = paiMaiItemInfo;
            if (self.UIItem == null)
            {
                return;
            }

            self.UIItem.GetComponent<UIItemComponent>().UpdateItem( new BagInfo() {ItemID = paiMaiItemInfo.BagInfo.ItemID}, ItemOperateEnum.None );
            self.UIItem.GetComponent<UIItemComponent>().Label_ItemNum.GetComponent<Text>().text = paiMaiItemInfo.BagInfo.ItemNum.ToString();
            self.TextPrice.GetComponent<Text>().text = self.PaiMaiItemInfo.Price.ToString();
            self.TextTime.GetComponent<Text>().text = TimeHelper.ShowTimeDifferenceStr(TimeHelper.DateTimeNow(), TimeInfo.Instance.ToDateTime(self.PaiMaiItemInfo.SellTime));

            self.TextName.GetComponent<Text>().text = ItemConfigCategory.Instance.Get(paiMaiItemInfo.BagInfo.ItemID).ItemName;

            self.UIItem.GetComponent<UIItemComponent>().Baginfo = self.PaiMaiItemInfo.BagInfo;
        }

        public static void SetClickHandler(this UIPaiMaiSellItemComponent self, Action<PaiMaiItemInfo> action)
        {
            self.ClickHandler = action;
        }

        public static void OnImageButton(this UIPaiMaiSellItemComponent self)
        {
            self.ClickHandler( self.PaiMaiItemInfo);
        }
    }

}
