using System;
using System.Reflection;
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
        public BagInfo BagInfo;
        public int oldPrice;
        public int nowPrice;
        public int priceProNum;
        public int SellNum;
        public bool IsHoldDown;
    }

    [ObjectSystem]
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
            UIHelper.Remove( self.DomainScene(), UIType.UIPaiMaiSellPrice ).Coroutine();
        }

        //浅拷贝即可
        public static T DeepCopy<T>(T obj)
        {
            //如果是字符串或值类型则直接返回
            if (obj == null || obj is string || obj.GetType().IsValueType) return obj;

            object retval = Activator.CreateInstance(obj.GetType());
            System.Reflection.FieldInfo[] fields = obj.GetType().GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static);
            foreach (System.Reflection.FieldInfo field in fields)
            {
                //try { field.SetValue(retval, DeepCopy(field.GetValue(obj))); }
                try { field.SetValue(retval, (field.GetValue(obj))); }
                catch { }
            }
            return (T)retval;
        }

        public static async ETTask OnBtn_ChuShou(this UIPaiMaiSellPriceComponent self)
        {
            PaiMaiItemInfo paiMaiItemInfo = new PaiMaiItemInfo();
            paiMaiItemInfo.BagInfo = DeepCopy<BagInfo>(self.BagInfo);
            paiMaiItemInfo.BagInfo.ItemNum = self.SellNum;
            paiMaiItemInfo.Price = self.nowPrice;
            C2M_PaiMaiSellRequest c2M_PaiMaiBuyRequest = new C2M_PaiMaiSellRequest() {  PaiMaiItemInfo = paiMaiItemInfo };
            M2C_PaiMaiSellResponse m2C_PaiMaiBuyResponse = (M2C_PaiMaiSellResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(c2M_PaiMaiBuyRequest);

            UI uI = UIHelper.GetUI(self.DomainScene(), UIType.UIPaiMai);
            uI.GetComponent<UIPaiMaiComponent>().UIPageView.UISubViewList[(int)PaiMaiPageEnum.PaiMaiSell].GetComponent<UIPaiMaiSellComponent>().OnPaiBuyShangJia(m2C_PaiMaiBuyResponse.PaiMaiItemInfo);

            UIHelper.Remove( self.DomainScene(), UIType.UIPaiMaiSellPrice ).Coroutine();
        }

        public static async void InitPriceUI(this UIPaiMaiSellPriceComponent self, BagInfo bagInfo)
        {
            self.BagInfo = bagInfo;
            FunctionUI.GetInstance().ItemShowIcon(self.ItemShowSet, self.GetParent<UI>(), bagInfo, ItemOperateEnum.None, false,1).Coroutine();
            FunctionUI.GetInstance().ItemObjShowName(self.Lab_Name, bagInfo.ItemID);

            //设置价格
            self.oldPrice = 10000;          //临时
            //获取是否是快捷购买的道具列表
            UI ui = await UIHelper.Create(self.ZoneScene(), UIType.UIPaiMai);
            if (ui.GetComponent<UIPaiMaiComponent>().PaiMaiShopItemInfos.ContainsKey(bagInfo.ItemID)) {
                self.oldPrice = ui.GetComponent<UIPaiMaiComponent>().PaiMaiShopItemInfos[bagInfo.ItemID].Price;
            }
            
            self.nowPrice = self.oldPrice;
            self.Lab_Tuijian.GetComponent<Text>().text = self.oldPrice.ToString();
            self.Text_Price.GetComponent<Text>().text = self.oldPrice.ToString();
            self.SellNum = bagInfo.ItemNum;
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
        }

        public static void OnCostNum(this UIPaiMaiSellPriceComponent self)
        {
            self.SellNum -= 1;
            if (self.SellNum <= 1)
            {
                self.SellNum = 1;
            }
            self.Lab_SellNumber.GetComponent<Text>().text = self.SellNum.ToString();
        }

        public static void OnChange(this UIPaiMaiSellPriceComponent self, string str) {

            self.nowPrice = int.Parse(str);

        }

    }

}
