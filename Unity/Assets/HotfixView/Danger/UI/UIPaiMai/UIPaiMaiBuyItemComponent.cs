using System;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIPaiMaiBuyItemComponent : Entity, IAwake
    {
        public GameObject ButtonBuy;
        public GameObject Text_Owner;
        public GameObject Text_LeftTime;
        public GameObject Text_Price;
        public GameObject ItemNode;
        public GameObject Text_Name;

        public PaiMaiItemInfo PaiMaiItemInfo;

        public UI ItemUI;
    }


    [ObjectSystem]
    public class UIPaiMaiBuyItemComponentAwakeSystem : AwakeSystem<UIPaiMaiBuyItemComponent>
    {
        public override void Awake(UIPaiMaiBuyItemComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
            self.ItemUI = null;
            self.PaiMaiItemInfo = null;

            self.ButtonBuy = rc.Get<GameObject>("ButtonBuy");
            self.ButtonBuy.GetComponent<Button>().onClick.AddListener(() => { self.OnClickButtonBuy(); });

            self.Text_Owner = rc.Get<GameObject>("Text_Owner");
            self.Text_LeftTime = rc.Get<GameObject>("Text_LeftTime");
            self.Text_Price = rc.Get<GameObject>("Text_Price");
            self.ItemNode = rc.Get<GameObject>("ItemNode");
            self.Text_Name = rc.Get<GameObject>("Text_Name");

            self.InitItemUI().Coroutine();
        }
    }

    public static class UIPaiMaiBuyItemComponentSystem
    {
        public static async ETTask InitItemUI(this UIPaiMaiBuyItemComponent self)
        {
            var path = ABPathHelper.GetUGUIPath("Main/Common/UICommonItem");
            await ETTask.CompletedTask;
            var bundleGameObject =ResourcesComponent.Instance.LoadAsset<GameObject>(path);

            GameObject go = GameObject.Instantiate(bundleGameObject);
            UICommonHelper.SetParent(go, self.ItemNode);
            self.ItemUI = self.AddChild<UI, string, GameObject>("XiLianItem", go);
            self.ItemUI.AddComponent<UIItemComponent>();
            self.ItemUI.GetComponent<UIItemComponent>().Label_ItemName.SetActive(false);
            self.ItemUI.GameObject.transform.localScale = Vector3.one * 0.8f;

            if (self.PaiMaiItemInfo != null)
            { 
                self.OnUpdateItem(self.PaiMaiItemInfo);
            }
        }

        public static async ETTask RequestBuy(this UIPaiMaiBuyItemComponent self)
        {
            C2M_PaiMaiBuyRequest c2M_PaiMaiBuyRequest = new C2M_PaiMaiBuyRequest() { PaiMaiItemInfo = self.PaiMaiItemInfo };
            M2C_PaiMaiBuyResponse m2C_PaiMaiBuyResponse = (M2C_PaiMaiBuyResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(c2M_PaiMaiBuyRequest);

            //隐藏显示

            if (m2C_PaiMaiBuyResponse.Error == 0)
            {
                if (self.GetParent<UI>() != null)
                {
                    self.GetParent<UI>().GameObject.SetActive(false);
                }
            }

            //刷新列表
            /*
            UI uipaimai = UIHelper.GetUI( self.DomainScene(), UIType.UIPaiMai );
            uipaimai.GetComponent<UIPaiMaiComponent>().UIPageView.UISubViewList[(int)PaiMaiPageEnum.PaiMaiBuy].GetComponent<UIPaiMaiBuyComponent>().OnUpdateUI();
            */
        }

        public static  void OnClickButtonBuy(this UIPaiMaiBuyItemComponent self)
        {
            if (self.PaiMaiItemInfo.BagInfo.ItemNum >= 10)
            {
                PopupTipHelp.OpenPopupTip(self.ZoneScene(), "购买道具", "你购买的道具数量较多，是否购买？", ()=>
                {
                    self.RequestBuy().Coroutine();
                }, null).Coroutine();
            }
            else
            {
                self.RequestBuy().Coroutine();
            }
        }

        public static void OnUpdateItem(this UIPaiMaiBuyItemComponent self, PaiMaiItemInfo paiMaiItemInfo)
        {
            self.PaiMaiItemInfo = paiMaiItemInfo;
            if (paiMaiItemInfo == null || self.ItemUI == null)
                return;

            self.ItemUI.GetComponent<UIItemComponent>().UpdateItem(paiMaiItemInfo.BagInfo, ItemOperateEnum.None );
            self.Text_Owner.GetComponent<Text>().text = paiMaiItemInfo.PlayerName;

            //显示名称
            FunctionUI.GetInstance().ItemObjShowName(self.Text_Name, self.PaiMaiItemInfo.BagInfo.ItemID);

            //显示价格
            int sumPrice = paiMaiItemInfo.Price * paiMaiItemInfo.BagInfo.ItemNum;
            self.Text_Price.GetComponent<Text>().text = sumPrice.ToString();

            //显示时间
            self.Text_LeftTime.GetComponent<Text>().text = TimeHelper.TimeToShowCostTimeStr(paiMaiItemInfo.SellTime,48);
        }
    }
}
