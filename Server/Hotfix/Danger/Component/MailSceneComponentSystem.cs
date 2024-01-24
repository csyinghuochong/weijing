using System;
using System.Collections.Generic;

namespace ET
{

    [Timer(TimerType.MailSceneTimer)]
    public class MailSceneTimer : ATimer<MailSceneComponent>
    {
        public override void Run(MailSceneComponent self)
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
    public class MailSceneComponentAwakeSystem : AwakeSystem<MailSceneComponent>
    {
        public override void Awake(MailSceneComponent self)
        {
            self.InitServerInfo().Coroutine();

            self.Timer = TimerComponent.Instance.NewRepeatedTimer(TimeHelper.Hour * 10 + self.DomainZone() * 1000, TimerType.MailSceneTimer, self);
        }
    }

    public static class MailSceneComponentSystem
    {

        public static async ETTask InitServerInfo(this MailSceneComponent self)
        {
            DBServerMailInfo dBServerInfo = null;
            long dbCacheId = DBHelper.GetDbCacheId(self.DomainZone());
            await TimerComponent.Instance.WaitAsync( RandomHelper.RandomNumber(1000,2000) );
            D2G_GetComponent d2GGetUnit = (D2G_GetComponent)await ActorMessageSenderComponent.Instance.Call(dbCacheId, new G2D_GetComponent() { UnitId = self.DomainZone(), Component = DBHelper.DBServerMailInfo });
            if (d2GGetUnit.Component != null)
            {
                dBServerInfo = d2GGetUnit.Component as DBServerMailInfo;
            }
            if (dBServerInfo == null)
            {
                dBServerInfo = new DBServerMailInfo();
                dBServerInfo.Id = self.DomainZone();
            }
            self.dBServerMailInfo = dBServerInfo;
            self.SaveDB().Coroutine();
        }

        public static int GetMaxMaild(this MailSceneComponent self)
        {
            int maxId = 0; 
            foreach ((int id, ServerMailItem ServerItem) in self.dBServerMailInfo.ServerMailList)
            {
                if (id >= maxId)
                {
                    maxId = id;
                }
            }
            return maxId;
        }

        public static async ETTask<int> OnLogin(this MailSceneComponent self, long unitid, int curmailid)
        {
            //检测没有发送的邮件
            foreach ((int id, ServerMailItem ServerItem) in self.dBServerMailInfo.ServerMailList)
            {
                if (curmailid >= id)
                {
                    continue;
                }
                if (!string.IsNullOrEmpty(ServerItem.ParasmNew))
                {
                   await  MailHelp.ServerMailItem(self.DomainZone(), unitid, ServerItem);
                }
                
                curmailid = id;
            }
            return curmailid;
        }


        public static async ETTask SaveDB(this MailSceneComponent self)
        {
            long dbCacheId = DBHelper.GetDbCacheId(self.DomainZone());
            await ActorMessageSenderComponent.Instance.Call(dbCacheId, new M2D_SaveComponent() { UnitId = self.DomainZone(), EntityByte = MongoHelper.ToBson(self.dBServerMailInfo), ComponentType = DBHelper.DBServerMailInfo });
        }

    }
}
