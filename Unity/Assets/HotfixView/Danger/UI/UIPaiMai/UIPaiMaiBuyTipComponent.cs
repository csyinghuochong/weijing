using System;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIPaiMaiBuyTipComponent: Entity, IAwake
    {
        public GameObject ImageButton;
        public GameObject UICommonItem;
        public GameObject Lab_RmbNum;
        public GameObject Btn_BuyNum_jia1;
        public GameObject Btn_BuyNum_jia10;
        public GameObject Btn_BuyNum_jian1;
        public GameObject Btn_BuyNum_jian10;
        public GameObject UnitPriceText;
        public GameObject TotalPriceText;
        public GameObject Btn_Buy;

        public Action<int> BuyAction;
        public int BuyNum;
        public PaiMaiItemInfo PaiMaiItemInfo;
        public UIItemComponent UIItemComponent;
    }

    public class UIPaiMaiBuyTipComponentAwakeSystem: AwakeSystem<UIPaiMaiBuyTipComponent>
    {
        public override void Awake(UIPaiMaiBuyTipComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.ImageButton = rc.Get<GameObject>("ImageButton");
            self.UICommonItem = rc.Get<GameObject>("UICommonItem");
            self.Lab_RmbNum = rc.Get<GameObject>("Lab_RmbNum");
            self.Btn_BuyNum_jia1 = rc.Get<GameObject>("Btn_BuyNum_jia1");
            self.Btn_BuyNum_jia10 = rc.Get<GameObject>("Btn_BuyNum_jia10");
            self.Btn_BuyNum_jian1 = rc.Get<GameObject>("Btn_BuyNum_jian1");
            self.Btn_BuyNum_jian10 = rc.Get<GameObject>("Btn_BuyNum_jian10");
            self.UnitPriceText = rc.Get<GameObject>("UnitPriceText");
            self.TotalPriceText = rc.Get<GameObject>("TotalPriceText");
            self.Btn_Buy = rc.Get<GameObject>("Btn_Buy");
            self.UIItemComponent = self.AddChild<UIItemComponent, GameObject>(self.UICommonItem);
            
            self.ImageButton.GetComponent<Button>().onClick.AddListener(() => { UIHelper.Remove(self.ZoneScene(), UIType.UIPaiMaiBuyTip); });
            self.Btn_BuyNum_jia1.GetComponent<Button>().onClick.AddListener(() => { self.OnClickChangeBuyNum(1); });
            self.Btn_BuyNum_jia10.GetComponent<Button>().onClick.AddListener(() => { self.OnClickChangeBuyNum(10); });
            self.Btn_BuyNum_jian1.GetComponent<Button>().onClick.AddListener(() => { self.OnClickChangeBuyNum(-1); });
            self.Btn_BuyNum_jian10.GetComponent<Button>().onClick.AddListener(() => { self.OnClickChangeBuyNum(-10); });
            self.Btn_Buy.GetComponent<Button>().onClick.AddListener(() => { self.OnBtn_Buy().Coroutine(); });
        }
    }

    public static class UIPaiMaiBuyTipComponentSystem
    {
        public static void InitInfo(this UIPaiMaiBuyTipComponent self, PaiMaiItemInfo paiMaiItemInfo, Action<int> buyAction)
        {
            self.PaiMaiItemInfo = paiMaiItemInfo;
            self.BuyAction = buyAction;
            self.UIItemComponent.UpdateItem(self.PaiMaiItemInfo.BagInfo, ItemOperateEnum.None);
            self.BuyNum = 1;
            self.Lab_RmbNum.GetComponent<InputField>().text = self.BuyNum.ToString();
            self.UnitPriceText.GetComponent<Text>().text = $"单价：{self.PaiMaiItemInfo.Price}";
            self.TotalPriceText.GetComponent<Text>().text = $"总金币：{self.PaiMaiItemInfo.Price * self.BuyNum}";
        }

        public static void OnClickChangeBuyNum(this UIPaiMaiBuyTipComponent self, int num)
        {
            self.BuyNum += num;
            if (self.BuyNum < 1)
            {
                self.BuyNum = 1;
            }

            if (self.BuyNum > self.PaiMaiItemInfo.BagInfo.ItemNum)
            {
                self.BuyNum = self.PaiMaiItemInfo.BagInfo.ItemNum;
            }

            self.Lab_RmbNum.GetComponent<InputField>().text = self.BuyNum.ToString();

            self.TotalPriceText.GetComponent<Text>().text = $"总金币：{self.PaiMaiItemInfo.Price * self.BuyNum}";
        }

        public static async ETTask OnBtn_Buy(this UIPaiMaiBuyTipComponent self)
        {
            BagComponent bagComponent = self.ZoneScene().GetComponent<BagComponent>();
            if (bagComponent.GetBagLeftSpace() < 1)
            {
                FloatTipManager.Instance.ShowFloatTip("背包空间不足");
                return;
            }

            C2M_PaiMaiBuyRequest request = new C2M_PaiMaiBuyRequest() { PaiMaiItemInfo = self.PaiMaiItemInfo, BuyNum = self.BuyNum };
            M2C_PaiMaiBuyResponse response =
                    (M2C_PaiMaiBuyResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(request);

            if (response.Error != ErrorCode.ERR_Success)
            {
                return;
            }

            self.BuyAction?.Invoke(self.BuyNum);
            UIHelper.Remove(self.ZoneScene(), UIType.UIPaiMaiBuyTip);
        }
    }
}