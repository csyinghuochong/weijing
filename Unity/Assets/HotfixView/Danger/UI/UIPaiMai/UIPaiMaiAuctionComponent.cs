using System;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{

    [Timer(TimerType.AuctionTimer)]
    public class AuctionTimer : ATimer<UIPaiMaiAuctionComponent>
    {
        public override void Run(UIPaiMaiAuctionComponent self)
        {
            try
            {
                self.OnAuctionTimer();
            }
            catch (Exception e)
            {
                Log.Error($"move timer error: {self.Id}\n{e}");
            }
        }
    }

    public class UIPaiMaiAuctionComponent : Entity, IAwake, IDestroy
    {
        public GameObject TextBaoZhenJin;
        public GameObject Btn_CanYu;
        public GameObject Text_2;
        public GameObject TextPrice;
        public GameObject Btn_Auction;
        public GameObject Btn_BuyNum_jian1;
        public GameObject Btn_BuyNum_jia1;
        public GameObject ButtonClose;
        public InputField Lab_RmbNum;
        public GameObject TextAuctionPlayer;
        public UIItemComponent UICommonItem;
        public GameObject Btn_Record;

        public long AuctionTimer;
        public long LeftTime;
        public long AuctionStart;   //起拍价
        public bool BaoZhenJin;
    }

    public class UIPaiMaiAuctionComponentAwake : AwakeSystem<UIPaiMaiAuctionComponent>
    {
        public override void Awake(UIPaiMaiAuctionComponent self)
        {
            self.BaoZhenJin = false;
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.TextPrice = rc.Get<GameObject>("TextPrice");

            self.Text_2 = rc.Get<GameObject>("Text_2");

            GameObject UICommonItem = rc.Get<GameObject>("UICommonItem");
            self.UICommonItem = self.AddChild<UIItemComponent, GameObject>(UICommonItem);

            self.TextBaoZhenJin = rc.Get<GameObject>("TextBaoZhenJin");
            self.TextBaoZhenJin.GetComponent<Text>().text = string.Empty;

            self.Btn_Auction = rc.Get<GameObject>("Btn_Auction");
            ButtonHelp.AddListenerEx(self.Btn_Auction, self.OnBtn_Auction);

            self.Btn_CanYu = rc.Get<GameObject>("Btn_CanYu");
            ButtonHelp.AddListenerEx(self.Btn_CanYu, () => { self.OnBtn_CanYu();  });

            self.Btn_Record = rc.Get<GameObject>("Btn_CanYu");
            ButtonHelp.AddListenerEx(self.Btn_Record, () => { UIHelper.Create( self.ZoneScene(), UIType.UIAuctionRecode ).Coroutine() ; });

            self.TextAuctionPlayer = rc.Get<GameObject>("TextAuctionPlayer");

            self.Btn_BuyNum_jian1 = rc.Get<GameObject>("Btn_BuyNum_jian1");
            self.Btn_BuyNum_jian1.GetComponent<Button>().onClick.AddListener(() => { self.Btn_BuyNum_jia(-1); });
            self.Btn_BuyNum_jia1 = rc.Get<GameObject>("Btn_BuyNum_jia1");
            self.Btn_BuyNum_jia1.GetComponent<Button>().onClick.AddListener(() => { self.Btn_BuyNum_jia(1);  });

            self.ButtonClose = rc.Get<GameObject>("ButtonClose");
            self.ButtonClose.GetComponent<Button>().onClick.AddListener(() => { UIHelper.Remove( self.ZoneScene(), UIType.UIPaiMaiAuction );  });
            self.Lab_RmbNum = rc.Get<GameObject>("Lab_RmbNum").GetComponent<InputField>();

            self.RequestPaiMaiAuction().Coroutine();

            long serverTime = TimeHelper.ServerNow();
            DateTime dateTime = TimeInfo.Instance.ToDateTime(serverTime);
            long curTime = (dateTime.Hour * 60 + dateTime.Minute)* 60 + dateTime.Second;

            long openTime = FunctionHelp.GetAuctionBeginTime();
            long closeTime = FunctionHelp.GetAuctionOverTime();
            if (curTime >= openTime && curTime < closeTime)
            {
                self.LeftTime = closeTime - curTime;
                self.AuctionTimer = TimerComponent.Instance.NewRepeatedTimer(1000, TimerType.AuctionTimer, self);
                self.OnAuctionTimer();
            }
            else
            {
                self.Text_2.GetComponent<Text>().text = "已结束";
            }
        }
    }

    public class UIPaiMaiAuctionComponentDestroy : DestroySystem<UIPaiMaiAuctionComponent>
    {
        public override void Destroy(UIPaiMaiAuctionComponent self)
        {
            TimerComponent.Instance?.Remove(ref self.AuctionTimer);
        }
    }

    public static class UIPaiMaiAuctionComponentSystem
    {

        public static void OnAuctionTimer(this UIPaiMaiAuctionComponent self)
        {
            if (self.LeftTime < 0)
            {
                self.Text_2.GetComponent<Text>().text = "已结束";
                TimerComponent.Instance?.Remove(ref self.AuctionTimer);
                return;
            }
            self.Text_2.GetComponent<Text>().text = "剩余时间:" + TimeHelper.ShowLeftTime(self.LeftTime * 1000); 
            self.LeftTime--;
        }

        public static void Btn_BuyNum_jia(this UIPaiMaiAuctionComponent self, int add)
        {

            long paiprice = long.Parse(self.TextPrice.GetComponent<Text>().text);

            string text = self.Lab_RmbNum.text;

            if (add < 0) {
                //降低
                add = (int)(add * paiprice * 0.1f);
            }

            if (add > 0) {
                //增加
                add = (int)(add * paiprice * 0.1f);
            }
           
            long curprice = long.Parse(text);

            curprice += add;

            if (curprice < paiprice)
            {
                FloatTipManager.Instance.ShowFloatTip("不能小于竞拍价！");
                return;
            }

            self.Lab_RmbNum.text = curprice.ToString();
        }

        public static void OnBtn_Auction(this UIPaiMaiAuctionComponent self)
        {
            string text = self.Lab_RmbNum.text;
            if (string.IsNullOrEmpty(text))
            {
                return;
            }
            long price = long.Parse(text);
            if (price < 0)
            {
                return;
            }
            UserInfo userInfo = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo;
            if (userInfo.Gold < price)
            {
                FloatTipManager.Instance.ShowFloatTip("金币不足！");
                return;
            }


            C2M_PaiMaiAuctionPriceRequest request = new C2M_PaiMaiAuctionPriceRequest() { Price = price };
            self.ZoneScene().GetComponent<SessionComponent>().Session.Send(request);
        }

        public static  void OnBtn_CanYu(this UIPaiMaiAuctionComponent self)
        {
            int returngold = (int)(self.AuctionStart * 0.1f);
            if (returngold <= 0)
            {
                return;
            }
            PopupTipHelp.OpenPopupTip(self.ZoneScene(), "参与竞拍", $"扣除{returngold}金币的保证金", () =>
           {
               self.RquestCanYu().Coroutine();
           }, null).Coroutine();
        }

        public static async ETTask RquestCanYu(this UIPaiMaiAuctionComponent self)
        {
            C2M_PaiMaiAuctionJoinRequest request = new C2M_PaiMaiAuctionJoinRequest() { };
            M2C_PaiMaiAuctionJoinResponse response = (M2C_PaiMaiAuctionJoinResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request);
            if (response.Error != ErrorCode.ERR_Success)
            {
                return;
            }
            self.RequestPaiMaiAuction().Coroutine();
        }

        public static async ETTask RequestPaiMaiAuction(this UIPaiMaiAuctionComponent self)
        {
            Unit unit = UnitHelper.GetMyUnitFromZoneScene( self.ZoneScene() );
            C2P_PaiMaiAuctionInfoRequest  request = new C2P_PaiMaiAuctionInfoRequest() { UnitId = unit.Id };
            P2C_PaiMaiAuctionInfoResponse response = (P2C_PaiMaiAuctionInfoResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request);
            if (response.AuctionItem == 0)
            {
                self.Text_2.GetComponent<Text>().text = "已结束";
                self.Btn_Auction.SetActive(false);
                self.Btn_CanYu.SetActive(false);
                return;
            }
            self.OnUpdateUI( response.AuctionItem, response.AuctionNumber, response.AuctionPrice );
            self.TextAuctionPlayer.GetComponent<Text>().text = "出价玩家:" + response.AuctionPlayer;
            self.UICommonItem.Label_ItemNum.GetComponent<Text>().text = response.AuctionNumber.ToString();
            self.AuctionStart = response.AuctionStart;

            self.Btn_CanYu.SetActive(!response.AuctionJoin);
            self.Btn_Auction.SetActive(response.AuctionJoin);

            if (response.AuctionJoin)
            {
                int returngold = (int)(response.AuctionStart * 0.1f);
                string text = $"已经缴纳{returngold}保证金";
                self.TextBaoZhenJin.GetComponent<Text>().text = text;
            }
            else
            {
                self.TextBaoZhenJin.GetComponent<Text>().text = string.Empty;
            }
        }

        public static void OnUpdateUI(this UIPaiMaiAuctionComponent self, int itemid, int number,  long price)
        { 
            self.TextPrice.GetComponent<Text>().text = price.ToString();    
            self.Lab_RmbNum.text = price.ToString();

            self.UICommonItem.UpdateItem( new BagInfo() { ItemID = itemid, ItemNum = number }, ItemOperateEnum.None );
        }

        public static void OnRecvHorseNotice(this UIPaiMaiAuctionComponent self, string noticeText)
        {
            //$"{self.AuctionItem}_{self.AuctionItemNum}_{self.AuctionPrice}_{self.AuctionPlayer}_1").
            string[] infos = noticeText.Split('_');
            int itmeid = int.Parse(infos[0]);
            int itmenumber = int.Parse(infos[1]);
            long price = long.Parse(infos[2]);
            self.OnUpdateUI(itmeid, itmenumber, price);
            self.TextAuctionPlayer.GetComponent<Text>().text = "出价玩家:" + infos[3];
        }
    }
}
