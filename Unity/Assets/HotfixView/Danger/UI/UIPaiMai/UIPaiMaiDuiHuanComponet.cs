using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIPaiMaiDuiHuanComponet : Entity, IAwake
    {

        public GameObject Btn_BuyNum_jian10;
        public GameObject Btn_BuyNum_jian1;
        public GameObject Btn_BuyNum_jia10;
        public GameObject Btn_BuyNum_jia1;

        public GameObject Lab_RmbNum;
        public GameObject Btn_DuiHuan;

        public GameObject DuiHuan_Gold;
        public GameObject Lab_DuiHuanGoldProShow;
        public GameObject Lab_DuiHuanZuanShiProShow;


        public long ExchangeValue;
        public int ExchangeZuanShi;

    }

    [ObjectSystem]
    public class UIPaiMaiDuiHuanComponetAwakeSystem : AwakeSystem<UIPaiMaiDuiHuanComponet>
    {
        public override  void Awake(UIPaiMaiDuiHuanComponet self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.Lab_RmbNum = rc.Get<GameObject>("Lab_RmbNum");

            self.Btn_DuiHuan = rc.Get<GameObject>("Btn_DuiHuan");
            self.Btn_DuiHuan.GetComponent<Button>().onClick.AddListener(() => { self.OnBtn_DuiHuan().Coroutine(); });

            self.Btn_BuyNum_jian10 = rc.Get<GameObject>("Btn_BuyNum_jian10");
            self.Btn_BuyNum_jian10.GetComponent<Button>().onClick.AddListener(() => { self.OnBtn_BuyNum_jia(-1000); });
            self.Btn_BuyNum_jian1 = rc.Get<GameObject>("Btn_BuyNum_jian1");
            self.Btn_BuyNum_jian1.GetComponent<Button>().onClick.AddListener(() => { self.OnBtn_BuyNum_jia(-100); });
            self.Btn_BuyNum_jia10 = rc.Get<GameObject>("Btn_BuyNum_jia10");
            self.Btn_BuyNum_jia10.GetComponent<Button>().onClick.AddListener(() => { self.OnBtn_BuyNum_jia(1000); });
            self.Btn_BuyNum_jia1 = rc.Get<GameObject>("Btn_BuyNum_jia1");
            self.Btn_BuyNum_jia1.GetComponent<Button>().onClick.AddListener(() => { self.OnBtn_BuyNum_jia(100); });

            self.DuiHuan_Gold = rc.Get<GameObject>("DuiHuan_Gold");
            self.Lab_DuiHuanGoldProShow = rc.Get<GameObject>("Lab_DuiHuanGoldProShow");
            self.Lab_DuiHuanZuanShiProShow = rc.Get<GameObject>("Lab_DuiHuanZuanShiProShow");
            self.ExchangeZuanShi = 100;
            self.Lab_DuiHuanGoldProShow.GetComponent<Text>().text = (self.ExchangeValue * self.ExchangeZuanShi).ToString();
            self.Lab_DuiHuanZuanShiProShow.GetComponent<Text>().text = self.ExchangeZuanShi.ToString();
            self.DuiHuan_Gold.GetComponent<Text>().text  = (self.ExchangeValue * self.ExchangeZuanShi).ToString();
            self.Lab_RmbNum.GetComponent<InputField>().text = self.ExchangeZuanShi.ToString();

            self.Lab_RmbNum.GetComponent<InputField>().onValueChanged.AddListener((string str) => { self.OnBtn_BuyNum_jia(0); });
            
            //初始化数据
            self.Init().Coroutine();
        }
    }

    public static class UIPaiMaiDuiHuanComponetSystem
    {

        public static async ETTask Init(this UIPaiMaiDuiHuanComponet self) {

            //初始化兑换值
            C2R_DBServerInfoRequest c2A_ServerExchangeValue = new C2R_DBServerInfoRequest() { };
            R2C_DBServerInfoResponse a2C_ServerExchangeValue = (R2C_DBServerInfoResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(c2A_ServerExchangeValue);
            if (self.IsDisposed)
            {
                return;
            }
            self.ExchangeValue = a2C_ServerExchangeValue.ServerInfo.ExChangeGold;
        }

        public static void OnBtn_BuyNum_jia(this UIPaiMaiDuiHuanComponet self, int num)
        {
            long max = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.Diamond;
            long diamondsNumber = long.Parse(self.Lab_RmbNum.GetComponent<InputField>().text);
            diamondsNumber += num;
            if (diamondsNumber < 100)
                diamondsNumber = 100;
            if (diamondsNumber > max)
                diamondsNumber = max;
            self.Lab_RmbNum.GetComponent<InputField>().text = diamondsNumber.ToString();
            self.DuiHuan_Gold.GetComponent<Text>().text = (self.ExchangeValue * diamondsNumber).ToString();
        }

        public static async ETTask OnBtn_DuiHuan(this UIPaiMaiDuiHuanComponet self)
        {
            long diamondsNumber = long.Parse(self.Lab_RmbNum.GetComponent<InputField>().text);
            if (self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.Diamond < diamondsNumber)
            {
                FloatTipManager.Instance.ShowFloatTip("钻石不足！");
                return;
            }

            C2M_PaiMaiDuiHuanRequest c2M_PaiMaiBuyRequest = new C2M_PaiMaiDuiHuanRequest() { DiamondsNumber = diamondsNumber };
            M2C_PaiMaiDuiHuanResponse m2C_PaiMaiBuyResponse = (M2C_PaiMaiDuiHuanResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(c2M_PaiMaiBuyRequest);

        }

    }

}
