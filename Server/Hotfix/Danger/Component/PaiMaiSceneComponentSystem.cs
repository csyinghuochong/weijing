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
                D2M_SaveComponent d2GSave = (D2M_SaveComponent)await ActorMessageSenderComponent.Instance.Call(dbCacheId, new M2D_SaveComponent() { UnitId = zone, Component = dBPaiMainInfo, ComponentType = DBHelper.DBPaiMainInfo });
            }
            else
            {
                self.dBPaiMainInfo = d2GGetUnit.Component as DBPaiMainInfo;

                //更新快捷购买列表
                self.UpdatePaiMaiShopItemList();
            }

            self.Timer = TimerComponent.Instance.NewRepeatedTimer(60000, TimerType.PaiMaiTimer, self);
            //测试更新价格
            //PaiMaiHelper.Instance.UpdatePaiMaiShopItemList(self.dBPaiMainInfo.PaiMaiShopItemInfos);
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
            self.UpdatePaiMaiShopItemPrice().Coroutine();

            self.UpdateShangJiaItems();
        }

        //每天更新道具物品价格
        public static async ETTask UpdatePaiMaiShopItemPrice(this PaiMaiSceneComponent self)
        {

            long openServerTime = await DBHelper.GetOpenServerTime(self.DomainZone());
            long serverNow = TimeHelper.ServerNow();
            int openserverDay = ComHelp.DateDiff_Day(serverNow, openServerTime);        //当前开服天数

            Log.Info($"PaiMaiScene开服天数 {self.DomainZone()} {openserverDay}");
            if (openserverDay > 15) {
                return;
            }

            List<PaiMaiShopItemInfo> paiMaiShopItemInfos = self.dBPaiMainInfo.PaiMaiShopItemInfos;
            for (int i = 0; i < paiMaiShopItemInfos.Count; i++)
            {
                float upPrice = RandomHelper.RandomNumberFloat(0.03f,0.06f);
                PaiMaiShopItemInfo info = paiMaiShopItemInfos[i];

                info.PricePro = 1 + upPrice;
                info.Price = (int)(info.Price * info.PricePro);
            }
        }

        //遍历上架道具
        public static void UpdateShangJiaItems(this PaiMaiSceneComponent self)
        {
            List<PaiMaiItemInfo> paimaiItems = self.dBPaiMainInfo.PaiMaiItemInfos;
            for (int i = 0; i < paimaiItems.Count; i++)
            {
                PaiMaiItemInfo paiMaiItem = paimaiItems[i];

                //int price = 0;
                PaiMaiShopItemInfo shopInfo = self.GetPaiMaiShopInfo(paiMaiItem.BagInfo.ItemID);
                if (shopInfo != null)
                {
                    //price = shopInfo.Price;
                    float pro = paiMaiItem.Price / shopInfo.Price;
                    float buyPro = 0;

                    if (pro <= 0.5f)
                    {
                        buyPro = 0.25f;
                    }
                    else if (pro <= 0.75f)
                    {
                        buyPro = 0.15f;
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
                    //概率购买
                    if (RandomHelper.RandFloat01() <= buyPro) {
                        MailHelp.SendPaiMaiEmail(self.DomainZone(), paiMaiItem, paiMaiItem.BagInfo.ItemNum).Coroutine();
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

        public static PaiMaiItemInfo GetPaiMaiItemInfo(this PaiMaiSceneComponent self, int itemID)
        {
            PaiMaiItemInfo paiMaiItemInfo = null;
            List<PaiMaiItemInfo> paiMaiItemInfos = self.dBPaiMainInfo.PaiMaiItemInfos;
            for (int i = 0; i < paiMaiItemInfos.Count; i++)
            {
                if (paiMaiItemInfos[i].BagInfo.ItemID!=itemID)
                {
                    continue;
                }
                if (paiMaiItemInfo == null || paiMaiItemInfos[i].Price < paiMaiItemInfo.Price)
                {
                    paiMaiItemInfo = paiMaiItemInfos[i];
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
                if (currentTime - paiMaiItemInfo.SellTime >= self.Overtime)
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
           D2M_SaveComponent d2GSave = (D2M_SaveComponent)await ActorMessageSenderComponent.Instance.Call(dbCacheId, new M2D_SaveComponent() { UnitId = self.DomainZone(), Component = self.dBPaiMainInfo, ComponentType = DBHelper.DBPaiMainInfo });
        }
    }
}
