using Alipay.AopSdk.Core.Domain;
using System.Collections.Generic;

namespace ET
{
    public static class MailHelp
    {

        public static async ETTask SendPaiMaiEmail(int zone, PaiMaiItemInfo paiMaiItemInfo,int costNum)
        {
            MailInfo mailInfo = new MailInfo();
            ItemConfig itemCof = ItemConfigCategory.Instance.Get(paiMaiItemInfo.BagInfo.ItemID);
            mailInfo.Status = 0;
            mailInfo.Context = "你拍卖行出售的道具:" + itemCof.ItemName + ",已经被其他玩家购买" + costNum + "个。";
            mailInfo.Title = "拍卖行邮件";
            mailInfo.MailId = IdGenerater.Instance.GenerateId();
            BagInfo reward = new BagInfo();
            reward.ItemID = 1;
            int sellPrice = (int)(paiMaiItemInfo.Price * 0.95f) * costNum;     //5%手续费
            reward.ItemNum = sellPrice;
            reward.GetWay = $"{ItemGetWay.PaiMaiSell}_{TimeHelper.ServerNow()}";
            mailInfo.ItemList.Add(reward);
            mailInfo.ItemSell = paiMaiItemInfo.BagInfo;

            //发送到邮件服
            long mailServerId = StartSceneConfigCategory.Instance.GetBySceneName(zone, "EMail").InstanceId;      //获取邮件消息ID
            E2M_EMailSendResponse g_EMailSendResponse = (E2M_EMailSendResponse)await ActorMessageSenderComponent.Instance.Call
                (mailServerId, new M2E_EMailSendRequest() { Id = paiMaiItemInfo.UserId, MailInfo = mailInfo });
        }

        public static void  SendServerMail(int zone, long userID, ServerMailItem serverMailItem)
        {
            Mail2M_SendServerMailItem mail2M_SendServer = new Mail2M_SendServerMailItem();
            mail2M_SendServer.ServerMailItem = serverMailItem;
            MessageHelper.SendToLocationActor( userID, mail2M_SendServer);
        }

        public static async ETTask ServerMailItem(int zone, long userID, ServerMailItem serverMailItem)
        {
            //判断条件
            long dbCacheId = DBHelper.GetDbCacheId(zone);

            UserInfoComponent userInfoComponent = null;
            NumericComponent numericComponent = null;
            BagComponent bagComponent = null;
            D2G_GetComponent d2GGetUnit1 = (D2G_GetComponent)await ActorMessageSenderComponent.Instance.Call(dbCacheId, new G2D_GetComponent() { UnitId = userID, Component = DBHelper.UserInfoComponent });
            if (d2GGetUnit1.Component == null)
            {
                return;
            }
            userInfoComponent = d2GGetUnit1.Component as UserInfoComponent;
            if (userInfoComponent.UserInfo.RobotId > 0)
            {
                return;
            }

            D2G_GetComponent d2GGetUnit2 = (D2G_GetComponent)await ActorMessageSenderComponent.Instance.Call(dbCacheId, new G2D_GetComponent() { UnitId = userID, Component = DBHelper.NumericComponent });
            if (d2GGetUnit2.Component == null)
            {
                return;
            }
            numericComponent = d2GGetUnit2.Component as NumericComponent;

            D2G_GetComponent d2GGetUnit3 = (D2G_GetComponent)await ActorMessageSenderComponent.Instance.Call(dbCacheId, new G2D_GetComponent() { UnitId = userID, Component = DBHelper.BagComponent });
            if (d2GGetUnit3.Component == null)
            {
                return;
            }
            bagComponent = d2GGetUnit3.Component as BagComponent;

            switch (serverMailItem.MailType)
            {
                case 2: // 充值>=6元 10011003
                    if (numericComponent.GetAsLong(NumericType.RechargeNumber) < serverMailItem.Parasm)
                    {
                        return;
                    }
                    break;
                case 3: //20级以上 补
                    if (userInfoComponent.UserInfo.Lv < serverMailItem.Parasm)
                    {
                        return;
                    }
                    break;
                case 4: //开启第二个仓库并且格子没有开完的
                    if (numericComponent.GetAsInt(NumericType.CangKuNumber) < 2)
                    {
                        return;
                    }
                    if (bagComponent.WarehouseAddedCell.Count < 4)
                    {
                        return;
                    }
                    if (bagComponent.WarehouseAddedCell[1] >= 10)
                    {
                        return;
                    }
                    break;
                default:
                    break;
            }


            MailInfo mailInfo = new MailInfo();
            mailInfo.Status = 0;
            mailInfo.Title = "奖励";
            mailInfo.Context = "全服补偿邮件";
            mailInfo.ItemList = serverMailItem.ItemList;
            mailInfo.MailId = IdGenerater.Instance.GenerateId();
            await SendUserMail(zone, userID, mailInfo);
        }

        //指定玩家发送邮件
        public static async ETTask<int> SendUserMail(int zone,long userID, MailInfo mailInfo )
        {
            long dbCacheId = DBHelper.GetDbCacheId(zone);
            D2G_GetComponent d2GGetUnit = (D2G_GetComponent)await ActorMessageSenderComponent.Instance.Call(dbCacheId, new G2D_GetComponent() { UnitId = userID, Component = DBHelper.DBMailInfo });
            DBMailInfo dBMainInfo=  d2GGetUnit.Component as DBMailInfo;
            if (dBMainInfo == null )
            {
                return ErrorCode.ERR_NotFindAccount;
            }
            /*
            //判断邮件是否已满
            if (dBMainInfo.MailInfoList.Count > 99) {
                return ErrorCode.ERR_MailFull;
            }
            */
            //存储邮件
            if (dBMainInfo.MailInfoList.Count > 100)
            {
                dBMainInfo.MailInfoList.RemoveAt(0);
            }
            dBMainInfo.MailInfoList.Add(mailInfo);
            D2M_SaveComponent d2GSave = (D2M_SaveComponent)await ActorMessageSenderComponent.Instance.Call(dbCacheId, new M2D_SaveComponent() { UnitId = userID, EntityByte = MongoHelper.ToBson(dBMainInfo), ComponentType = DBHelper.DBMailInfo });
            return d2GSave.Error;
        }
    }
}
