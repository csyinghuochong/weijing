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

        //指定玩家发送邮件
        public static async ETTask<int> SendUserMail(int zone,long userID, MailInfo mailInfo )
        {
            long dbCacheId = DBHelper.GetDbCacheId(zone);
            D2G_GetComponent d2GGetUnit = (D2G_GetComponent)await ActorMessageSenderComponent.Instance.Call(dbCacheId, new G2D_GetComponent() { UnitId = userID, Component = DBHelper.DBMailInfo });
            DBMailInfo dBMainInfo=  d2GGetUnit.Component as DBMailInfo;
            if (dBMainInfo == null || dBMainInfo.MailInfoList.Count > 100)
            {
                return -1;
            }
            /*
            //判断邮件是否已满
            if (dBMainInfo.MailInfoList.Count > 99) {
                return ErrorCore.ERR_MailFull;
            }
            */
            //存储邮件
            dBMainInfo.MailInfoList.Add(mailInfo);
            D2M_SaveComponent d2GSave = (D2M_SaveComponent)await ActorMessageSenderComponent.Instance.Call(dbCacheId, new M2D_SaveComponent() { UnitId = userID, EntityByte = MongoHelper.ToBson(dBMainInfo), ComponentType = DBHelper.DBMailInfo });
            return ErrorCore.ERR_Success;
        }
    }
}
