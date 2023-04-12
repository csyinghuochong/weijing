using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace ET
{
    public class UIPaiMaiSellPriceComponent : Entity, IAwake
    {
        public GameObject ImageButton;
        public GameObject Btn_ChuShou;
        public GameObject ItemShowSet;
        public GameObject Lab_Name;
        public GameObject Btn_Cost;
        public GameObject Btn_Add;
        public GameObject Btn_CostNum;
        public GameObject Btn_AddNum;
        public GameObject Text_Price;
        public GameObject Lab_SellNumber;
        public GameObject Lab_Tuijian;
        public GameObject PriceInputField;
        public GameObject Lab_SellSumPro;
        public BagInfo BagInfo;
        public int oldPrice;
        public int nowPrice;
        public int priceProNum;
        public int SellNum;
        public bool IsHoldDown;
    }


    public class UIPaiMaiSellPriceComponentAwakeSystem : AwakeSystem<UIPaiMaiSellPriceComponent>
    {
        public override void Awake(UIPaiMaiSellPriceComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.ImageButton = rc.Get<GameObject>("ImageButton");
            self.ImageButton.GetComponent<Button>().onClick.AddListener(() => { self.OnImageButton(); });

            self.Btn_ChuShou = rc.Get<GameObject>("Btn_ChuShou");
            self.Btn_ChuShou.GetComponent<Button>().onClick.AddListener(() => { self.OnBtn_ChuShou().Coroutine(); });

            self.ItemShowSet = rc.Get<GameObject>("ItemShowSet");
            self.Lab_Name = rc.Get<GameObject>("Lab_Name");
            self.Text_Price = rc.Get<GameObject>("Text_Price");
            self.Lab_Tuijian = rc.Get<GameObject>("Lab_Tuijian");
            self.Lab_SellNumber = rc.Get<GameObject>("Lab_SellNumber");
            self.Lab_SellSumPro = rc.Get<GameObject>("Lab_SellSumPro");

            self.Btn_Cost = rc.Get<GameObject>("Btn_Cost");
            self.Btn_Cost.GetComponent<Button>().onClick.AddListener(() => { self.OnCostPrice(); });

            self.Btn_Add = rc.Get<GameObject>("Btn_Add");
            self.Btn_Add.GetComponent<Button>().onClick.AddListener(() => { self.OnAddPrice(); });

            self.Btn_CostNum = rc.Get<GameObject>("Btn_CostNum");
            self.Btn_AddNum = rc.Get<GameObject>("Btn_AddNum");

            self.PriceInputField = rc.Get<GameObject>("PriceInputField");
            self.PriceInputField.GetComponent<InputField>().onValueChanged.AddListener((string value) => { self.OnChange(value); });


            ButtonHelp.AddEventTriggers(self.Btn_CostNum, (PointerEventData pdata) => { self.PointerDown_Btn_CostNum(pdata).Coroutine(); }, EventTriggerType.PointerDown);
            ButtonHelp.AddEventTriggers(self.Btn_CostNum, (PointerEventData pdata) => { self.PointerUp_Btn_CostNum(pdata); }, EventTriggerType.PointerUp);

            ButtonHelp.AddEventTriggers(self.Btn_AddNum, (PointerEventData pdata) => { self.PointerDown_Btn_AddNum(pdata).Coroutine(); }, EventTriggerType.PointerDown);
            ButtonHelp.AddEventTriggers(self.Btn_AddNum, (PointerEventData pdata) => { self.PointerUp_Btn_AddNum(pdata); }, EventTriggerType.PointerUp);

            self.IsHoldDown = false;
        }
    }

    public static class UIPaiMaiSellPriceComponentSystem
    {

        public static async ETTask PointerDown_Btn_CostNum(this UIPaiMaiSellPriceComponent self, PointerEventData pdata)
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

        public static void PointerUp_Btn_CostNum(this UIPaiMaiSellPriceComponent self, PointerEventData pdata)
        {
            self.IsHoldDown = false;
        }

        public static async ETTask PointerDown_Btn_AddNum(this UIPaiMaiSellPriceComponent self, PointerEventData pdata)
        {
            self.IsHoldDown = true;
            while (self.IsHoldDown)
            {
                self.OnAddNum();
                if (self.SellNum >= self.BagInfo.ItemNum)
                {
                    break;
                }
                await TimerComponent.Instance.WaitAsync(200);
            }
        }

        public static void PointerUp_Btn_AddNum(this UIPaiMaiSellPriceComponent self, PointerEventData pdata)
        {
            self.IsHoldDown = false;
        }

        public static void OnImageButton(this UIPaiMaiSellPriceComponent self)
        {
            UIHelper.Remove( self.DomainScene(), UIType.UIPaiMaiSellPrice );
        }

        public static async ETTask OnBtn_ChuShou(this UIPaiMaiSellPriceComponent self)
        {
            PaiMaiItemInfo paiMaiItemInfo = new PaiMaiItemInfo();
            paiMaiItemInfo.BagInfo = ComHelp.DeepCopy<BagInfo>(self.BagInfo);
            paiMaiItemInfo.BagInfo.ItemNum = self.SellNum;
            paiMaiItemInfo.Price = self.nowPrice;


            UI ui =  UIHelper.GetUI(self.ZoneScene(), UIType.UIPaiMai);
            if (ui.GetComponent<UIPaiMaiComponent>().PaiMaiShopItemInfos.ContainsKey(paiMaiItemInfo.BagInfo.ItemID))
            {
                int oldPrice = ui.GetComponent<UIPaiMaiComponent>().PaiMaiShopItemInfos[paiMaiItemInfo.BagInfo.ItemID].Price;

                int nowPrice = (int)((float)paiMaiItemInfo.Price);
                if (nowPrice < (int)(oldPrice * 0.5f))
                {
                    FloatTipManager.Instance.ShowFloatTip(GameSettingLanguge.LoadLocalization("出售价格过低,当前最低价格为:" + (int)(oldPrice * 0.5f) * paiMaiItemInfo.BagInfo.ItemNum));
                    return;
                }
            }


            //发送上架协议
            C2M_PaiMaiSellRequest c2M_PaiMaiBuyRequest = new C2M_PaiMaiSellRequest() {  PaiMaiItemInfo = paiMaiItemInfo };
            M2C_PaiMaiSellResponse m2C_PaiMaiBuyResponse = (M2C_PaiMaiSellResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(c2M_PaiMaiBuyRequest);

            UI uI = UIHelper.GetUI(self.DomainScene(), UIType.UIPaiMai);
            uI.GetComponent<UIPaiMaiComponent>().UIPageView.UISubViewList[(int)PaiMaiPageEnum.PaiMaiSell].GetComponent<UIPaiMaiSellComponent>().OnPaiBuyShangJia(m2C_PaiMaiBuyResponse.PaiMaiItemInfo);

            UIHelper.Remove( self.DomainScene(), UIType.UIPaiMaiSellPrice );
        }

        public static void InitPriceUI(this UIPaiMaiSellPriceComponent self, BagInfo bagInfo)
        {
            self.BagInfo = bagInfo;
            FunctionUI.GetInstance().ItemShowIcon(self.ItemShowSet, self.GetParent<UI>(), bagInfo, ItemOperateEnum.None, false,1);
            FunctionUI.GetInstance().ItemObjShowName(self.Lab_Name, bagInfo.ItemID);

            //设置价格
            self.oldPrice = 10000;          //临时
            //获取是否是快捷购买的道具列表
            UI ui = UIHelper.GetUI(self.ZoneScene(), UIType.UIPaiMai);
            if (ui.GetComponent<UIPaiMaiComponent>().PaiMaiShopItemInfos.ContainsKey(bagInfo.ItemID)) {
                self.oldPrice = ui.GetComponent<UIPaiMaiComponent>().PaiMaiShopItemInfos[bagInfo.ItemID].Price;
            }
            
            self.nowPrice = self.oldPrice;
            self.SellNum = bagInfo.ItemNum;

            self.Lab_Tuijian.GetComponent<Text>().text = self.oldPrice.ToString();
            //self.Text_Price.GetComponent<Text>().text = (self.oldPrice * self.SellNum).ToString();
            self.Lab_SellNumber.GetComponent<Text>().text = self.SellNum.ToString();


            //初始化显示
            self.priceProNum = 1;
            self.OnCostPrice();

        }

        public static void  OnAddPrice(this UIPaiMaiSellPriceComponent self) {

            //Log.Info("OnAddPrice.....");

            self.priceProNum += 1;
            if (self.priceProNum >= 10)
            {
                self.priceProNum = 10;
                FloatTipManager.Instance.ShowFloatTip(GameSettingLanguge.LoadLocalization("如需再提高价格,请手动修改价格!"));
            }
            self.nowPrice = (int)(self.oldPrice * (1f + 0.1f * self.priceProNum));
            self.Lab_SellSumPro.GetComponent<Text>().text = ((int)(self.oldPrice * (1f + 0.1f * self.priceProNum) * self.SellNum)).ToString();
            self.PriceInputField.GetComponent<InputField>().text = self.nowPrice.ToString();

        }

        public static void OnCostPrice(this UIPaiMaiSellPriceComponent self)
        {
            self.priceProNum -= 1;
            if (self.priceProNum <= -10)
            {
                self.priceProNum = -10;
            }

            self.nowPrice = (int)(self.oldPrice * (1f + 0.1f * self.priceProNum));
            self.Lab_SellSumPro.GetComponent<Text>().text = ((int)(self.oldPrice * (1f + 0.1f * self.priceProNum) * self.SellNum)).ToString();
            self.PriceInputField.GetComponent<InputField>().text = self.nowPrice.ToString();
        }

        public static void OnAddNum(this UIPaiMaiSellPriceComponent self)
        {
            self.SellNum += 1;
            if (self.SellNum >= self.BagInfo.ItemNum)
            {
                self.SellNum = self.BagInfo.ItemNum;
            }
            self.Lab_SellNumber.GetComponent<Text>().text = self.SellNum.ToString();
            //调整价格
            //self.PriceInputField.GetComponent<InputField>().text = self.nowPrice.ToString();
            self.Lab_SellSumPro.GetComponent<Text>().text = ((int)(self.oldPrice * (1f + 0.1f * self.priceProNum) * self.SellNum)).ToString();
        }

        public static void OnCostNum(this UIPaiMaiSellPriceComponent self)
        {
            self.SellNum -= 1;
            if (self.SellNum <= 1)
            {
                self.SellNum = 1;
            }
            self.Lab_SellNumber.GetComponent<Text>().text = self.SellNum.ToString();
            //调整价格
            //self.PriceInputField.GetComponent<InputField>().text = self.nowPrice.ToString();
            self.Lab_SellSumPro.GetComponent<Text>().text = ((int)(self.oldPrice * (1f + 0.1f * self.priceProNum) * self.SellNum)).ToString();
        }

        public static void OnChange(this UIPaiMaiSellPriceComponent self, string str) {

            self.nowPrice = int.Parse(str);

        }

    }

}
