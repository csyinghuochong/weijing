using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{

    [Timer(TimerType.AccountCenterTimer)]
    public class AccountCenterTimer : ATimer<AccountCenterComponent>
    {
        public override void Run(AccountCenterComponent self)
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

    [ObjectSystem]
    public class AccountCenterComponentAwake : AwakeSystem<AccountCenterComponent>
    {
        public override void Awake(AccountCenterComponent self)
        {
            self.InitDBRankInfo().Coroutine();
          
            self.Timer = TimerComponent.Instance.NewRepeatedTimer(60000 + self.DomainZone() * 1000, TimerType.AccountCenterTimer, self);
        }
    }


    [ObjectSystem]
    public class AccountCenterComponentDestroy : DestroySystem<AccountCenterComponent>
    {
        public override void Destroy(AccountCenterComponent self)
        {
            TimerComponent.Instance.Remove(ref self.Timer);
        }
    }


    public static class AccountCenterComponentSystem
    {

        public static void GenerateSerials(this AccountCenterComponent self)
        {
            DBCenterSerialInfo dBCenterSerialInfo = self.DBCenterSerialInfo;
            self.DBCenterSerialInfo.SerialIndex++;
            int sindex = self.DBCenterSerialInfo.SerialIndex;

            SerialHelper serialHelper = new SerialHelper();
            for (int i = 0; i < 100; i++)
            {
                string code = serialHelper.GenerateCheckCode(6);
                dBCenterSerialInfo.SerialList.Add(new KeyValuePair() { KeyId = sindex, Value = code, Value2 = "0" });
            }
        }

        public static async ETTask InitDBRankInfo(this AccountCenterComponent self)
        {
            long dbCacheId = DBHelper.GetDbCacheId(self.DomainZone());
            D2G_GetComponent d2GGetUnit = (D2G_GetComponent)await ActorMessageSenderComponent.Instance.Call(dbCacheId, new G2D_GetComponent() { UnitId = self.DomainZone(), Component = DBHelper.DBCenterSerialInfo });

            if (d2GGetUnit.Component == null)
            {
                self.DBCenterSerialInfo = new DBCenterSerialInfo();
                self.DBCenterSerialInfo.Id = self.DomainZone();
            }
            else
            {
                self.DBCenterSerialInfo = d2GGetUnit.Component as DBCenterSerialInfo;
            }
        }

        public static async ETTask SaveDB(this AccountCenterComponent self)
        {
            long dbCacheId = DBHelper.GetDbCacheId(self.DomainZone());
            await ActorMessageSenderComponent.Instance.Call(dbCacheId, new M2D_SaveComponent() { UnitId = self.DomainZone(), EntityByte = MongoHelper.ToBson(self.DBCenterSerialInfo), ComponentType = DBHelper.DBCenterSerialInfo });
        }

    }
}
