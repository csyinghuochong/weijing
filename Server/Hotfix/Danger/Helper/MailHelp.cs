namespace ET
{
    public static class MailHelp
    {

        //指定玩家发送邮件
        public static async ETTask<int> SendUserMail(int zone,long userID, MailInfo mailInfo )
        {
            //未找到角色
            if (userID == 0)
            {
                return ErrorCore.ERR_UserNoFind;
            }

            long dbCacheId = DBHelper.GetDbCacheId(zone);
            D2G_GetComponent d2GGetUnit = (D2G_GetComponent)await ActorMessageSenderComponent.Instance.Call(dbCacheId, new G2D_GetComponent() { CharacterId = userID, Component = DBHelper.DBMailInfo });

            DBMailInfo dBMainInfo;
            if (d2GGetUnit.Component == null)
            {
                dBMainInfo = new DBMailInfo();
                dBMainInfo.Id = userID;
            }
            else 
            {
                dBMainInfo = d2GGetUnit.Component as DBMailInfo;
            }
            
            /*
            //判断邮件是否已满
            if (dBMainInfo.MailInfoList.Count > 99) {
                return ErrorCore.ERR_MailFull;
            }
            */
            //存储邮件
            dBMainInfo.MailInfoList.Add(mailInfo);

            D2M_SaveComponent d2GSave = (D2M_SaveComponent)await ActorMessageSenderComponent.Instance.Call(dbCacheId, new M2D_SaveComponent() { CharacterId = userID, Component = dBMainInfo, ComponentType = DBHelper.DBMailInfo });
            return ErrorCore.ERR_Success;

        }
    }
}
