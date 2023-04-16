using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
        public GameObject Text_2;
        public GameObject TextPrice;
        public GameObject Btn_Auction;
        public GameObject Btn_BuyNum_jian1;
        public GameObject Btn_BuyNum_jia1;
        public GameObject ButtonClose;
        public InputField Lab_RmbNum;

        public UIItemComponent UICommonItem;

        public long AuctionTimer;
        public long LeftTime;
    }

    public class UIPaiMaiAuctionComponentAwake : AwakeSystem<UIPaiMaiAuctionComponent>
    {
        public override void Awake(UIPaiMaiAuctionComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.TextPrice = rc.Get<GameObject>("TextPrice");

            self.Text_2 = rc.Get<GameObject>("Text_2");

            GameObject UICommonItem = rc.Get<GameObject>("UICommonItem");
            self.UICommonItem = self.AddChild<UIItemComponent, GameObject>(UICommonItem);

            self.Btn_Auction = rc.Get<GameObject>("Btn_Auction");
            ButtonHelp.AddListenerEx(self.Btn_Auction, self.OnBtn_Auction);

            self.Btn_BuyNum_jian1 = rc.Get<GameObject>("Btn_BuyNum_jian1");
            self.Btn_BuyNum_jian1.GetComponent<Button>().onClick.AddListener(() => { self.Btn_BuyNum_jia(-1000); });
            self.Btn_BuyNum_jia1 = rc.Get<GameObject>("Btn_BuyNum_jia1");
            self.Btn_BuyNum_jia1.GetComponent<Button>().onClick.AddListener(() => { self.Btn_BuyNum_jia(1000);  });

            self.ButtonClose = rc.Get<GameObject>("ButtonClose");
            self.ButtonClose.GetComponent<Button>().onClick.AddListener(() => { UIHelper.Remove( self.ZoneScene(), UIType.UIPaiMaiAuction );  });
            self.Lab_RmbNum = rc.Get<GameObject>("Lab_RmbNum").GetComponent<InputField>();

            self.RequestPaiMaiAuction().Coroutine();


            DateTime dateTime = TimeHelper.DateTimeNow();
            long curTime = (dateTime.Hour * 60 + dateTime.Minute)* 60 + dateTime.Second;

            long openTime = FunctionHelp.GetOpenTime(1040);
            long closeTime = FunctionHelp.GetCloseTime(1040);
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
            self.Text_2.GetComponent<Text>().text = TimeHelper.ShowLeftTime(self.LeftTime * 1000); 
            self.LeftTime--;
        }

        public static void Btn_BuyNum_jia(this UIPaiMaiAuctionComponent self, int add)
        {
            string text = self.Lab_RmbNum.text;
           
            long curprice = long.Parse(text);

            long paiprice = long.Parse(self.TextPrice.GetComponent<Text>().text);

            curprice += add;

            if (curprice < paiprice)
            {
                FloatTipManager.Instance.ShowFloatTip("不能小于竞拍价！");
                return;
            }

            self.Lab_RmbNum.text = curprice.ToString();
        }

        public static  void OnBtn_Auction(this UIPaiMaiAuctionComponent self)
        {
            string text = self.Lab_RmbNum.text;
            if (string.IsNullOrEmpty(text))
            {
                return;
            }
            long price = long.Parse(text);
            C2M_PaiMaiAuctionPriceRequest request = new C2M_PaiMaiAuctionPriceRequest() { Price = price };
            self.ZoneScene().GetComponent<SessionComponent>().Session.Send(request);
        }

        public static async ETTask RequestPaiMaiAuction(this UIPaiMaiAuctionComponent self)
        {
            C2P_PaiMaiAuctionInfoRequest  request = new C2P_PaiMaiAuctionInfoRequest();
            P2C_PaiMaiAuctionInfoResponse response = (P2C_PaiMaiAuctionInfoResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request);
            if (response.AuctionItem == 0)
            {
                return;
            }
            self.OnUpdateUI( response.AuctionItem, response.AuctionPrice );
        }

        public static void OnUpdateUI(this UIPaiMaiAuctionComponent self, int itemid, long price)
        { 
            self.TextPrice.GetComponent<Text>().text = price.ToString();    
            self.Lab_RmbNum.text = price.ToString();

            self.UICommonItem.UpdateItem( new BagInfo() { ItemID = itemid }, ItemOperateEnum.None );
            self.UICommonItem.Label_ItemNum.SetActive(false);
        }

        public static void OnRecvHorseNotice(this UIPaiMaiAuctionComponent self, string noticeText)
        {
            // $"{self.AuctionItem}_{self.AuctionPrice}_2").Coroutine();
            string[] infos = noticeText.Split('_');
            int itmeid = int.Parse(infos[0]);
            long price = long.Parse(infos[1]);
            self.OnUpdateUI(itmeid, price);
        }
    }
}
