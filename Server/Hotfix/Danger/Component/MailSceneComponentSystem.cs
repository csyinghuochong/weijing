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
            await TimerComponent.Instance.WaitAsync( RandomHelper.RandomNumber(10000, 20000) );
            DBServerMailInfo dBServerInfo = null;
            long dbCacheId = DBHelper.GetDbCacheId(self.DomainZone());
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

        public static async ETTask SaveDB(this MailSceneComponent self)
        {
            long dbCacheId = DBHelper.GetDbCacheId(self.DomainZone());
            await ActorMessageSenderComponent.Instance.Call(dbCacheId, new M2D_SaveComponent() { UnitId = self.DomainZone(), EntityByte = MongoHelper.ToBson(self.dBServerMailInfo), ComponentType = DBHelper.DBServerMailInfo });
        }

        public static List<int> OnLogin(this MailSceneComponent self,  long unitid,  List<int> recvids)
        {
            //检测没有发送的邮件
            List<int> unrecvids = new List<int>();
            foreach ( ( int id, ServerMailItem  ServerItem)  in self.dBServerMailInfo.ServerMailList)
            {
                if (recvids.Contains(id))
                {
                    continue;
                }
                MailInfo mailInfo = new MailInfo();
                mailInfo.Status = 0;
                mailInfo.Title = "奖励";
                mailInfo.MailId = IdGenerater.Instance.GenerateId();
                for (int r = 0; r < ServerItem.ItemList.Count; r++)
                {
                    mailInfo.ItemList.Add( new BagInfo() { ItemID = ServerItem.ItemList[r].ItemID, ItemNum = ServerItem.ItemList[r].ItemNum } );
                }

                MailHelp.SendUserMail(self.DomainZone(), unitid, mailInfo).Coroutine();
                unrecvids.Add(id);
            }
            return unrecvids;
        }

        /// <summary>
        /// 全服邮件
        /// </summary>
        public static void OnServerMail(this MailSceneComponent self, M2E_GMEMailSendRequest request)
        {
            int mailid = self.dBServerMailInfo.ServerMailList.Count + 1;
            ServerMailItem serverMailItem = new ServerMailItem();
            serverMailItem.MailType = request.MailType;

            string[] rewardStrList = request.Itemlist.Split('@');
            for (int i = 0; i < rewardStrList.Length; i++)
            {
                string[] rewardList = rewardStrList[i].Split(';');
                serverMailItem.ItemList.Add(new BagInfo() { ItemID = int.Parse(rewardList[0]), ItemNum = int.Parse(rewardList[1]), GetWay = $"{ItemGetWay.ReceieMail}_{TimeHelper.ServerNow()}" });
            }

            serverMailItem.Parasm = request.Param;
            self.dBServerMailInfo.ServerMailList.Add(mailid, serverMailItem);

            self.SendAllOnLineMail(serverMailItem).Coroutine();
;       }

        public static async ETTask SendAllOnLineMail(this MailSceneComponent self, ServerMailItem serverMailItem)
        {
            try
            {
                int zone = self.DomainZone();
                long chatServerId = StartSceneConfigCategory.Instance.GetBySceneName(zone, Enum.GetName(SceneType.Chat)).InstanceId;
                Chat2Mail_GetUnitList chat2G_EnterChat = (Chat2Mail_GetUnitList)await MessageHelper.CallActor(chatServerId, new Mail2Chat_GetUnitList()
                {
                });
                if (chat2G_EnterChat.Error != ErrorCore.ERR_Success)
                {
                    return;
                }

                MailInfo mailInfo = new MailInfo();
                mailInfo.Status = 0;
                mailInfo.Title = "奖励";
                mailInfo.ItemList = serverMailItem.ItemList;
                mailInfo.MailId = IdGenerater.Instance.GenerateId();

                for (int i = 0; i < chat2G_EnterChat.OnlineUnitIdList.Count; i++)
                {
                    MailHelp.SendUserMail(zone, chat2G_EnterChat.OnlineUnitIdList[i], mailInfo).Coroutine();
                    MailHelp.SendServerMail(zone, chat2G_EnterChat.OnlineUnitIdList[i], serverMailItem);
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.ToString());
            }

        }
    }
}
