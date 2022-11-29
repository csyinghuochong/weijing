using System.Linq;
using System.Collections.Generic;

namespace ET
{
    public static class ServerMessageHelper
    {

        public static void SendBroadMessage(int zone, int messageType, string message)
        {
            long chatServerId = DBHelper.GetChatServerId(zone);
            SendServerMessage(chatServerId, messageType, message).Coroutine();
        }

        public static async ETTask SendServerMessage(long serverid, int messageType, string message)
        {
            A2A_ServerMessageRResponse g_SendChatRequest = (A2A_ServerMessageRResponse)await ActorMessageSenderComponent.Instance.Call
               (serverid, new A2A_ServerMessageRequest()
               {
                   MessageType = messageType,
                   MessageValue = message
               });
        }


        public static List<int> GetAllZone()
        {
            List<int> zoneList = new List<int> { };
            List<StartZoneConfig> listprogress = StartZoneConfigCategory.Instance.GetAll().Values.ToList();
            for (int i = 0; i < listprogress.Count; i++)
            {
                if (listprogress[i].Id >= ComHelp.MaxZone)
                {
                    continue;
                }
                if (!StartSceneConfigCategory.Instance.Gates.ContainsKey(listprogress[i].Id))
                {
                    continue;
                }
                zoneList.Add(listprogress[i].Id);
            }
            return zoneList;
        }
    }
}
