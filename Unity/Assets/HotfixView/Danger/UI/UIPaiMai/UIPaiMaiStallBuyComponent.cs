using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace ET
{
    public class UIPaiMaiStallBuyComponent : Entity, IAwake
    {
        public GameObject Text_Number;
        public GameObject Btn_Close;
        public GameObject Btn_CostNum;
        public GameObject Btn_AddNum;
        public GameObject Btn_Buy;
        public GameObject Lab_ChuShouPrice;
        public GameObject Lab_ItemName;
        public GameObject ItemShowSet;

        public UIItemComponent UIItemComponent;
        public PaiMaiItemInfo PaiMaiItemInfo;

        public int SellNum;
        public bool IsHoldDown;
        //public int danjia;
    }



    public class UIPaiMaiStallBuyComponentAwakeSystem : AwakeSystem<UIPaiMaiStallBuyComponent>
    {
        public override void Awake(UIPaiMaiStallBuyComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.Text_Number = rc.Get<GameObject>("Text_Number");

            self.Btn_Close = rc.Get<GameObject>("Btn_Close");
            self.Btn_Close.GetComponent<Button>().onClick.AddListener(() => { self.OnBtn_Close(); });

            self.Btn_CostNum = rc.Get<GameObject>("Btn_CostNum");
            self.Btn_AddNum = rc.Get<GameObject>("Btn_AddNum");
            ButtonHelp.AddEventTriggers(self.Btn_CostNum, (PointerEventData pdata) => { self.PointerDown_Btn_CostNum(pdata).Coroutine(); }, EventTriggerType.PointerDown);
            ButtonHelp.AddEventTriggers(self.Btn_CostNum, (PointerEventData pdata) => { self.PointerUp_Btn_CostNum(pdata); }, EventTriggerType.PointerUp);

            ButtonHelp.AddEventTriggers(self.Btn_AddNum, (PointerEventData pdata) => { self.PointerDown_Btn_AddNum(pdata).Coroutine(); }, EventTriggerType.PointerDown);
            ButtonHelp.AddEventTriggers(self.Btn_AddNum, (PointerEventData pdata) => { self.PointerUp_Btn_AddNum(pdata); }, EventTriggerType.PointerUp);


            self.Btn_Buy = rc.Get<GameObject>("Btn_Buy");
            self.Btn_Buy.GetComponent<Button>().onClick.AddListener(() => { self.OnBtn_Buy().Coroutine(); });

            self.Lab_ChuShouPrice = rc.Get<GameObject>("Lab_ChuShouPrice");
            self.Lab_ItemName = rc.Get<GameObject>("Lab_ItemName");

            self.ItemShowSet = rc.Get<GameObject>("ItemShowSet");
           
            self.IsHoldDown = false;
            self.UIItemComponent = null;
            self.PaiMaiItemInfo = null;
            self.OnInitUI().Coroutine();

        }
    }

    public static class UIPaiMaiStallBuyComponentSystem
    {
        public static async ETTask OnInitUI(this UIPaiMaiStallBuyComponent self)
        {
            var path = ABPathHelper.GetUGUIPath("Main/Common/UICommonItem");
            var bundleGameObject = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);
            GameObject go = GameObject.Instantiate(bundleGameObject);
            UICommonHelper.SetParent(go, self.ItemShowSet);
            UI uiItem = self.AddChild<UI, string, GameObject>("XiLianItem", go);
            self.UIItemComponent = uiItem.AddComponent<UIItemComponent>();
            self.UIItemComponent.Label_ItemName.SetActive(false);

            if (self.PaiMaiItemInfo != null)
            {
                self.OnUpdateUI(self.PaiMaiItemInfo);
            }

            //danjia = self.PaiMaiItemInfo.Price / self.PaiMaiItemInfo.BagInfo.BagInfoID;
        }

        public static async ETTask PointerDown_Btn_CostNum(this UIPaiMaiStallBuyComponent self, PointerEventData pdata)
        {
            self.IsHoldDown = true;
            while (self.IsHoldDown)
            {
                self.OnCostNum();
                if (self.SellNum == 1)
                {
                    break;
                }

                await TimerComponent.Instance.WaitAsync(200);
            }
        }

        public static void OnAddNum(this UIPaiMaiStallBuyComponent self)
        {
            self.SellNum += 1;
            if (self.SellNum >= self.PaiMaiItemInfo.BagInfo.ItemNum)
            {
                self.SellNum = self.PaiMaiItemInfo.BagInfo.ItemNum;
            }
            self.Text_Number.GetComponent<Text>().text = self.SellNum.ToString();
            //self.Lab_ChuShouPrice.GetComponent<Text>().text = self.PaiMaiItemInfo.ToString .Price.ToString();
        }

        public static void OnCostNum(this UIPaiMaiStallBuyComponent self)
        {
            self.SellNum -= 1;
            if (self.SellNum <= 1)
            {
                self.SellNum = 1;
            }
            self.Text_Number.GetComponent<Text>().text = self.SellNum.ToString();
        }

        public static void PointerUp_Btn_CostNum(this UIPaiMaiStallBuyComponent self, PointerEventData pdata)
        {
            self.IsHoldDown = false;
        }

        public static async ETTask PointerDown_Btn_AddNum(this UIPaiMaiStallBuyComponent self, PointerEventData pdata)
        {
            self.IsHoldDown = true;
            while (self.IsHoldDown)
            {
                self.OnAddNum();
                if (self.SellNum >= self.PaiMaiItemInfo.BagInfo.ItemNum)
                {
                    break;
                }
                await TimerComponent.Instance.WaitAsync(200);
            }
        }

        public static void PointerUp_Btn_AddNum(this UIPaiMaiStallBuyComponent self, PointerEventData pdata)
        {
            self.IsHoldDown = false;
        }


        public static void OnUpdateUI(this UIPaiMaiStallBuyComponent self, PaiMaiItemInfo paiMaiItemInfo )
        {
            self.PaiMaiItemInfo = paiMaiItemInfo;
            if (self.UIItemComponent == null)
            {
                return;
            }

            self.SellNum = paiMaiItemInfo.BagInfo.ItemNum;
            self.Text_Number.GetComponent<Text>().text = paiMaiItemInfo.BagInfo.ItemNum.ToString();

            ItemConfig itemConfig = ItemConfigCategory.Instance.Get(paiMaiItemInfo.BagInfo.ItemID);
            self.Lab_ItemName.GetComponent<Text>().text = itemConfig.ItemName;
            self.Lab_ChuShouPrice.GetComponent<Text>().text = paiMaiItemInfo.Price.ToString();
            self.UIItemComponent.UpdateItem(paiMaiItemInfo.BagInfo, ItemOperateEnum.None);
        }

        public static void OnBtn_Close(this UIPaiMaiStallBuyComponent self)
        {
            UIHelper.Remove(self.DomainScene(), UIType.UIPaiMaiStallBuy);
        }

        public static async ETTask OnBtn_Buy(this UIPaiMaiStallBuyComponent self)
        {
            C2M_PaiMaiBuyRequest c2M_PaiMaiBuyRequest = new C2M_PaiMaiBuyRequest() { PaiMaiItemInfo = self.PaiMaiItemInfo };
            M2C_PaiMaiBuyResponse m2C_PaiMaiBuyResponse = (M2C_PaiMaiBuyResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(c2M_PaiMaiBuyRequest);

            UI uI = UIHelper.GetUI( self.DomainScene(), UIType.UIPaiMaiStall );
            uI.GetComponent<UIPaiMaiStallComponent>().RequestStallInfo().Coroutine();

            self.OnBtn_Close();
        }
    }
}
