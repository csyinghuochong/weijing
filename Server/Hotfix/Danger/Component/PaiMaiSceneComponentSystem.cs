using System;
using System.Collections.Generic;

namespace ET
{

    [Timer(TimerType.PaiMaiTimer)]
    public class PaiMaiTimer : ATimer<PaiMaiSceneComponent>
    {
        public override void Run(PaiMaiSceneComponent self)
        {
            try
            {
                self.SaveDB().Coroutine();
            }
            catch (Exception e)
            {
                Log.Error($"move timer error: {self.Id}\n{e}");
            }
        }
    }

    public class PaiMaiComponentAwakeSystem : AwakeSystem<PaiMaiSceneComponent>
    {
        public override void Awake(PaiMaiSceneComponent self)
        {
            self.InitDBData().Coroutine();

        }
    }

    [ObjectSystem]
    public class PaiMaiComponentDestroySystem : DestroySystem<PaiMaiSceneComponent>
    {

        public override void Destroy(PaiMaiSceneComponent self)
        {
            TimerComponent.Instance.Remove(ref self.Timer);
        }
    }


    public static class PaiMaiSceneComponentSystem
    {

        public static async ETTask OnAuctionBegin(this PaiMaiSceneComponent self, long time)
        {
            self.AuctionStatus = 1;

            int openDay = DBHelper.GetOpenServerDay(self.DomainZone());

            //初始化拍卖价格
            self.AuctionPrice = 1000000;
            self.AuctionStart = self.AuctionPrice;

            //第1天
            if (openDay == 1)
            {
                self.AuctionItem = 14060005;
                self.AuctionItemNum = 1;
            }

            //第2天
            if (openDay == 2)
            {
                self.AuctionItem = 15207003;
                self.AuctionItemNum = 1;
            }

            //第3天
            if (openDay == 3)
            {
                self.AuctionItem = 15306003;
                self.AuctionItemNum = 1;
            }

            //第4天
            if (openDay == 4)
            {
                self.AuctionItem = 15302007;
                self.AuctionItemNum = 1;
            }

            //第5天
            if (openDay == 5)
            {
                self.AuctionItem = 15406003;
                self.AuctionItemNum = 1;
            }

            //第6天
            if (openDay == 6)
            {
                self.AuctionItem = 15407003;
                self.AuctionItemNum = 1;
            }

            //第7天
            if (openDay == 7)
            {
                self.AuctionItem = 15506003;
                self.AuctionItemNum = 1;
            }

            //进入循环随机
            if (openDay > 7)
            {
                int[] weights = new int[] { 10, 10, 10, 10, 10, 10, 10, 10, 10 };
                string[] weightsItem = new string[] { "10000143,10", "10000141,1", "10000152,3", "10000150,1", "10010026,1", "10010053,1", "10010040,1", "10045106,1", "10045107,1" };
                int id = RandomHelper.RandomByWeight(weights);

                self.AuctionItem = int.Parse(weightsItem[id].Split(',')[0]);
                self.AuctionItemNum = int.Parse(weightsItem[id].Split(',')[1]);
            }

            //拍卖会开始
            ServerMessageHelper.SendServerMessage(DBHelper.GetChatServerId(self.DomainZone()), NoticeType.PaiMaiAuction,
            $"{self.AuctionItem}_{self.AuctionItemNum}_{self.AuctionPrice}_{self.AuctionPlayer}_1").Coroutine();

            Log.Console($"拍卖会开始:  {self.DomainZone()}");
            await TimerComponent.Instance.WaitAsync(time);
            self.OnAuctionOver().Coroutine();
        }

        public static async ETTask OnAuctionOver(this PaiMaiSceneComponent self)
        {
            long gateServerId = DBHelper.GetGateServerId(self.DomainZone());

            if (self.AuctioUnitId != 0)
            {
               
                G2T_GateUnitInfoResponse g2M_UpdateUnitResponse = (G2T_GateUnitInfoResponse)await ActorMessageSenderComponent.Instance.Call
                   (gateServerId, new T2G_GateUnitInfoRequest()
                   {
                       UserID = self.AuctioUnitId
                   });

                bool getitem = false;

                //在线
                if (g2M_UpdateUnitResponse.PlayerState == (int)PlayerState.Game && g2M_UpdateUnitResponse.SessionInstanceId > 0)
                {
                    P2M_PaiMaiAuctionOverRequest p2M_PaiMaiAuctionOverRequest = new P2M_PaiMaiAuctionOverRequest()
                    {
                        Price = self.AuctionPrice,
                        ItemID = self.AuctionItem,
                        ItemNumber = self.AuctionItemNum,
                    };


                    M2P_PaiMaiAuctionOverResponse m2G_RechargeResponse = (M2P_PaiMaiAuctionOverResponse)await ActorLocationSenderComponent.Instance.Call(self.AuctioUnitId, p2M_PaiMaiAuctionOverRequest);
                    if (m2G_RechargeResponse.Error == ErrorCore.ERR_Success)
                    {
                        getitem = true;
                    }
                    else
                    {
                        //流派则不退还保证金
                        if (self.AuctionJoinList.Contains(self.AuctioUnitId))
                        {
                            self.AuctionJoinList.Remove(self.AuctioUnitId);
                        }
                    }
                }
                else
                {
                    UserInfoComponent userInfoComponent = await DBHelper.GetComponentCache<UserInfoComponent>(self.DomainZone(), self.AuctioUnitId);
                    if (userInfoComponent.UserInfo.Gold >= self.AuctionPrice)
                    {
                        userInfoComponent.UserInfo.Gold -= self.AuctionPrice;
                        DBHelper.SaveComponent(self.DomainZone(), self.AuctioUnitId, userInfoComponent).Coroutine();

                        //发送道具
                        getitem = true;
                    }
                    else
                    {
                        //流派则不退还保证金
                        if (self.AuctionJoinList.Contains(self.AuctioUnitId))
                        {
                            self.AuctionJoinList.Remove(self.AuctioUnitId);
                        }
                    }
                }

                if (getitem)
                {
                    MailInfo mailInfo = new MailInfo();
                    mailInfo.Status = 0;
                    mailInfo.Context = "竞拍道具";
                    mailInfo.Title = "竞拍道具";
                    mailInfo.MailId = IdGenerater.Instance.GenerateId();
                    mailInfo.ItemList.Add(new BagInfo() { ItemID = self.AuctionItem, ItemNum = self.AuctionItemNum, GetWay = $"{ItemGetWay.Auction}_{TimeHelper.ServerNow()}" });
                    await MailHelp.SendUserMail(self.DomainZone(), self.AuctioUnitId, mailInfo);
                }
            }

            //退还保证金
            int returnggold = (int)( self.AuctionStart * 0.1f);
            for (int i = 0; i < self.AuctionJoinList.Count; i++)
            {
                MailInfo mailInfo = new MailInfo();
                mailInfo.Status = 0;
                mailInfo.Context = "退还保证金";
                mailInfo.Title = "退还保证金";
                mailInfo.MailId = IdGenerater.Instance.GenerateId();
                mailInfo.ItemList.Add(new BagInfo() { ItemID = 1, ItemNum = returnggold, GetWay = $"{ItemGetWay.Auction}_{TimeHelper.ServerNow()}" });
                await MailHelp.SendUserMail(self.DomainZone(), self.AuctioUnitId, mailInfo);
            }

            self.AuctionStatus = 2;

            //拍卖会结束
            ServerMessageHelper.SendServerMessage(DBHelper.GetChatServerId(self.DomainZone()), NoticeType.PaiMaiAuction,
            $"{self.AuctionItem}_{self.AuctionItemNum}_{self.AuctionPrice}_{self.AuctionPlayer}_2").Coroutine();

            //其他玩家退还保证金
            self.AuctionJoinList.Clear();
            Log.Console($"拍卖会结束:  {self.DomainZone()} {self.AuctionPlayer}");
        }

        public static async ETTask BeginAuctionTimer(this PaiMaiSceneComponent self)
        {
            self.AuctionStatus = 0;

            DateTime dateTime = TimeHelper.DateTimeNow();
            long curTime = (dateTime.Hour * 60 + dateTime.Minute) * 60 + dateTime.Second;
            long openTime = FunctionHelp.GetAuctionBeginTime();
            long closeTime = FunctionHelp.GetAuctionOverTime();

            if (curTime < openTime)
            {
                await TimerComponent.Instance.WaitAsync( (openTime - curTime) * TimeHelper.Second );
                dateTime = TimeHelper.DateTimeNow();
                curTime = (dateTime.Hour * 60 + dateTime.Minute) * 60 + dateTime.Second;
                self.OnAuctionBegin((closeTime - curTime) * 1000).Coroutine();
            }
            else if (curTime >= openTime && curTime <= closeTime)
            {
                self.OnAuctionBegin((closeTime -curTime) * 1000).Coroutine();
            }
            else
            {

            }
        }
       
        public static async ETTask InitDBData(this PaiMaiSceneComponent self)
        {
            int zone = self.DomainZone();
            long dbCacheId = DBHelper.GetDbCacheId(zone);
            await TimerComponent.Instance.WaitAsync(zone * 100);
            D2G_GetComponent d2GGetUnit = (D2G_GetComponent)await ActorMessageSenderComponent.Instance.Call(dbCacheId, new G2D_GetComponent() { UnitId = zone, Component = DBHelper.DBPaiMainInfo });
         
            if (d2GGetUnit.Component == null)
            {
                //初始化拍卖行数据
                DBPaiMainInfo dBPaiMainInfo = new DBPaiMainInfo();
                dBPaiMainInfo.Id = self.DomainZone();
                self.dBPaiMainInfo = dBPaiMainInfo;

                //初始化快捷购买列表
                dBPaiMainInfo.PaiMaiShopItemInfos = PaiMaiHelper.Instance.InitPaiMaiShopItemList();

                //存储数据库数据
                D2M_SaveComponent d2GSave = (D2M_SaveComponent)await ActorMessageSenderComponent.Instance.Call(dbCacheId, new M2D_SaveComponent() { UnitId = zone, EntityByte = MongoHelper.ToBson(dBPaiMainInfo), ComponentType = DBHelper.DBPaiMainInfo });
            }
            else
            {
                self.dBPaiMainInfo = d2GGetUnit.Component as DBPaiMainInfo;

                //更新快捷购买列表
                self.UpdatePaiMaiShopItemList();
            }

            self.Timer = TimerComponent.Instance.NewRepeatedTimer(TimeHelper.Minute * 4 + self.DomainZone() * 200, TimerType.PaiMaiTimer, self);
            //测试更新价格
            //PaiMaiHelper.Instance.UpdatePaiMaiShopItemList(self.dBPaiMainInfo.PaiMaiShopItemInfos);

            self.BeginAuctionTimer().Coroutine();
        }

        //更新快捷购买列表
        public static void UpdatePaiMaiShopItemList(this PaiMaiSceneComponent self)
        {
            self.dBPaiMainInfo.PaiMaiShopItemInfos = PaiMaiHelper.Instance.InitPaiMaiShopItemList(self.dBPaiMainInfo.PaiMaiShopItemInfos);
        }

        //零点刷新
        public static void OnZeroClockUpdate(this PaiMaiSceneComponent self)
        {
            //更新价格
            self.UpdatePaiMaiShopItemPrice();

            self.UpdateShangJiaItems();

            self.BeginAuctionTimer().Coroutine();
        }

        //每天更新道具物品价格
        public static  void UpdatePaiMaiShopItemPrice(this PaiMaiSceneComponent self)
        {
            int curzone = ServerHelper.GetOldServerId( ComHelp.IsBanHaoZone(self.DomainZone()), self.DomainZone());
            int openserverDay =  DBHelper.GetOpenServerDay(curzone);
            Log.Info($"PaiMaiScene开服天数 {self.DomainZone()} {openserverDay}");
            if (openserverDay == 0 || openserverDay > 15) {
                return;
            }

            List<PaiMaiShopItemInfo> paiMaiShopItemInfos = self.dBPaiMainInfo.PaiMaiShopItemInfos;
            for (int i = 0; i < paiMaiShopItemInfos.Count; i++)
            {
                float upPrice = RandomHelper.RandomNumberFloat(0.03f,0.06f);
                PaiMaiShopItemInfo info = paiMaiShopItemInfos[i];

                info.PricePro = 1 + upPrice;
                info.Price = (int)(info.Price * info.PricePro);
                Log.Debug($"{info.Id} {info.Price}");
            }
        }

        //遍历上架道具
        public static void UpdateShangJiaItems(this PaiMaiSceneComponent self)
        {
            int AAA = self.DomainZone();
            List<PaiMaiItemInfo> paimaiItems = self.dBPaiMainInfo.PaiMaiItemInfos;

            for (int i = 0; i < paimaiItems.Count; i++)
            {
                PaiMaiItemInfo paiMaiItem = paimaiItems[i];

                //int price = 0;
                PaiMaiShopItemInfo shopInfo = self.GetPaiMaiShopInfo(paiMaiItem.BagInfo.ItemID);
                if (shopInfo != null && shopInfo.Price <= 500000 && ItemConfigCategory.Instance.Get(paiMaiItem.BagInfo.ItemID).ItemType != 3)
                {
                    //int singPro = (int)(paiMaiItem.Price / paiMaiItem.BagInfo.ItemNum);  //单价
                    float pro = paiMaiItem.Price / shopInfo.Price;
                    float buyPro = 0;

                    if (pro <= 0.5f)
                    {
                        buyPro = 0.35f;
                    }
                    else if (pro <= 0.75f)
                    {
                        buyPro = 0.2f;
                    }
                    else if (pro <= 1f)
                    {
                        buyPro = 0.1f;
                    }
                    else if (pro <= 1.2f) {

                        buyPro = 0.05f;
                    }
                    else if (pro <= 1.5f)
                    {
                        buyPro = 0.025f;
                    }

                    ItemConfig itemCof = ItemConfigCategory.Instance.Get(paiMaiItem.BagInfo.ItemID);
                    int costNum = 0;
                    switch (itemCof.ItemQuality) {

                        case 1:
                            costNum = RandomHelper.NextInt(1, 100);
                            break;
                        //绿色道具随机数量
                        case 2:
                            costNum = RandomHelper.NextInt(1,100);
                            break;
                        //蓝道具随机数量
                        case 3:
                            costNum = RandomHelper.NextInt(1, 10);
                            break;
                        //紫色道具随机数量
                        case 4:
                            costNum = RandomHelper.NextInt(1, 5);
                            break;
                    
                    }

                    //不能超过当前拥有上限
                    costNum = Math.Min(costNum, paiMaiItem.BagInfo.ItemNum);

                    if (pro < 1.5f)
                    {
                        //概率购买
                        if (RandomHelper.RandFloat01() < buyPro)
                        {
                            Log.Info("拍卖行系统购买 概率:" + buyPro + "出售价格:" + paiMaiItem.Price * costNum + "玩家名称:" + paiMaiItem.PlayerName + "出售道具:" + paiMaiItem.BagInfo.ItemID + "出售单价:" + paiMaiItem.Price + "道具拥有数量:" + paiMaiItem.BagInfo.ItemNum);
                            MailHelp.SendPaiMaiEmail(self.DomainZone(), paiMaiItem, costNum).Coroutine();
                        }
                    }
                }
            }
        }

        //根据道具ID获取对应快捷购买的列表
        public static PaiMaiShopItemInfo GetPaiMaiShopInfo(this PaiMaiSceneComponent self, long needItemID)
        {
            //获取当前的数据
            foreach (PaiMaiShopItemInfo info in self.dBPaiMainInfo.PaiMaiShopItemInfos)
            {
                if (info.Id == needItemID)
                {
                    return info;
                }
            }
            return null;
        }

        //根据道具ID获取对应快捷购买的列表
        public static void PaiMaiShopInfoAddBuyNum(this PaiMaiSceneComponent self, long needItemID, int buyNum)
        {
            foreach (PaiMaiShopItemInfo info in self.dBPaiMainInfo.PaiMaiShopItemInfos)
            {
                if (info.Id == needItemID)
                {
                    info.BuyNum += buyNum;
                }
            }
        }

        public static List<PaiMaiItemInfo> GetPaiMaiItemInfo(this PaiMaiSceneComponent self, int itemID,int singPrice)
        {
            List<PaiMaiItemInfo> paiMaiItemInfo = new List<PaiMaiItemInfo>();
            List<PaiMaiItemInfo> paiMaiItemInfos = self.dBPaiMainInfo.PaiMaiItemInfos;
            for (int i = 0; i < paiMaiItemInfos.Count; i++)
            {
                if (paiMaiItemInfos[i].BagInfo.ItemID!=itemID)
                {
                    continue;
                }

                int sellSingPri = (int)((float)paiMaiItemInfos[i].Price / paiMaiItemInfos[i].BagInfo.ItemNum);
                if (sellSingPri < (int)((float)singPrice * 0.8f))
                {
                    paiMaiItemInfo.Add(paiMaiItemInfos[i]);
                }
            }
            return paiMaiItemInfo;
        }

        public static async ETTask SaveDB(this PaiMaiSceneComponent self)
        {

            //检测超时的道具
            long currentTime = TimeHelper.ServerNow();
            for (int i = self.dBPaiMainInfo.PaiMaiItemInfos.Count - 1; i >= 0; i--)
            {
                PaiMaiItemInfo paiMaiItemInfo = self.dBPaiMainInfo.PaiMaiItemInfos[i];
                if (currentTime - paiMaiItemInfo.SellTime >= TimeHelper.OneDay)
                {
                    long emaiId = StartSceneConfigCategory.Instance.GetBySceneName(self.DomainZone(), Enum.GetName(SceneType.EMail)).InstanceId;
                    E2P_PaiMaiOverTimeResponse g_SendChatRequest = (E2P_PaiMaiOverTimeResponse)await ActorMessageSenderComponent.Instance.Call
                        (emaiId, new P2E_PaiMaiOverTimeRequest()
                        {
                             PaiMaiItemInfo = paiMaiItemInfo
                        });

                    self.dBPaiMainInfo.PaiMaiItemInfos.RemoveAt(i);
                }
            }

            long dbCacheId = DBHelper.GetDbCacheId(self.DomainZone());
           D2M_SaveComponent d2GSave = (D2M_SaveComponent)await ActorMessageSenderComponent.Instance.Call(dbCacheId, new M2D_SaveComponent() { UnitId = self.DomainZone(), EntityByte = MongoHelper.ToBson(self.dBPaiMainInfo), ComponentType = DBHelper.DBPaiMainInfo });
        }
    }
}
