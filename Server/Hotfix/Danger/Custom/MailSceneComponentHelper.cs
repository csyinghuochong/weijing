using System;

namespace ET
{
    public static class MailSceneComponentHelper
    {

        /// <summary>
        /// 全服邮件
        /// </summary>
        public static void OnServerMail(this MailSceneComponent self, M2E_GMEMailSendRequest request)
        {
            Log.Warning($"OnServerMail: {request.MailType}  {request.Title}");

            int mailid = self.dBServerMailInfo.ServerMailList.Count + 1;
            ServerMailItem serverMailItem = new ServerMailItem();
            serverMailItem.MailType = request.MailType;

            string[] rewardStrList = request.Itemlist.Split('@');
            for (int i = 0; i < rewardStrList.Length; i++)
            {
                string[] rewardList = rewardStrList[i].Split(';');
                serverMailItem.ItemList.Add(new BagInfo() { ItemID = int.Parse(rewardList[0]), ItemNum = int.Parse(rewardList[1]), GetWay = $"{ItemGetWay.ReceieMail}_{TimeHelper.ServerNow()}" });
            }

            serverMailItem.ParasmNew = request.Title;
            serverMailItem.ServerMailIId = mailid;
            self.dBServerMailInfo.ServerMailList.Add(mailid, serverMailItem);

            self.SendAllOnLineMail(serverMailItem).Coroutine();
            self.SaveDB().Coroutine();
        }

        public static async ETTask SendAllOnLineMail(this MailSceneComponent self, ServerMailItem serverMailItem)
        {
            try
            {
                int zone = self.DomainZone();
                long chatServerId = StartSceneConfigCategory.Instance.GetBySceneName(zone, Enum.GetName(SceneType.Chat)).InstanceId;
                Chat2Mail_GetUnitList chat2G_EnterChat = (Chat2Mail_GetUnitList)await MessageHelper.CallActor(chatServerId, new Mail2Chat_GetUnitList()
                {
                });
                if (chat2G_EnterChat.Error != ErrorCode.ERR_Success)
                {
                    return;
                }

                for (int i = 0; i < chat2G_EnterChat.OnlineUnitIdList.Count; i++)
                {
                    //旧的邮件不发给玩家了，但是需要做记录
                    if (!string.IsNullOrEmpty(serverMailItem.ParasmNew))
                    {
                        Log.Warning($"新邮件: {serverMailItem.ServerMailIId}");
                        await  MailHelp.ServerMailItem(zone, chat2G_EnterChat.OnlineUnitIdList[i], serverMailItem);
                    }
                    else
                    {
                        Log.Warning($"旧邮件: {serverMailItem.ServerMailIId}");
                    }

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
