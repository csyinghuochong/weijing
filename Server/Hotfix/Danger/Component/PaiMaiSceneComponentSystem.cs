using System;

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
            self.Timer = TimerComponent.Instance.NewRepeatedTimer(60000,  TimerType.PaiMaiTimer, self);
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
            long dbCacheId = DBHelper.GetDbCacheId(self.DomainZone());
            D2G_GetComponent d2GGetUnit = (D2G_GetComponent)await ActorMessageSenderComponent.Instance.Call(dbCacheId, new G2D_GetComponent() { CharacterId = self.DomainZone(), Component = DBHelper.DBPaiMainInfo });
         
            if (d2GGetUnit.Component == null)
            {
                //初始化拍卖行数据
                DBPaiMainInfo dBPaiMainInfo = new DBPaiMainInfo();
                dBPaiMainInfo.Id = self.DomainZone();
                self.dBPaiMainInfo = dBPaiMainInfo;

                //初始化快捷购买列表
                dBPaiMainInfo.PaiMaiShopItemInfos = PaiMaiHelper.Instance.InitPaiMaiShopItemList();

                //存储数据库数据
                D2M_SaveComponent d2GSave = (D2M_SaveComponent)await ActorMessageSenderComponent.Instance.Call(dbCacheId, new M2D_SaveComponent() { CharacterId = self.DomainZone(), Component = dBPaiMainInfo, ComponentType = DBHelper.DBPaiMainInfo });

            }
            else
            {
                self.dBPaiMainInfo = d2GGetUnit.Component as DBPaiMainInfo;

                //更新快捷购买列表
                self.dBPaiMainInfo.PaiMaiShopItemInfos = PaiMaiHelper.Instance.InitPaiMaiShopItemList(self.dBPaiMainInfo.PaiMaiShopItemInfos);

            }

            //测试更新价格
            //PaiMaiHelper.Instance.UpdatePaiMaiShopItemList(self.dBPaiMainInfo.PaiMaiShopItemInfos);
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
           D2M_SaveComponent d2GSave = (D2M_SaveComponent)await ActorMessageSenderComponent.Instance.Call(dbCacheId, new M2D_SaveComponent() { CharacterId = self.DomainZone(), Component = self.dBPaiMainInfo, ComponentType = DBHelper.DBPaiMainInfo });
        }
    }
}
