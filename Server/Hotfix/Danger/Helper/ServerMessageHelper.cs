using System;

namespace ET
{
    public static class ServerMessageHelper
    {
        public static async ETTask SendServerMessage(long serverid, int messageType, string message)
        {
            A2A_ServerMessageRResponse g_SendChatRequest = (A2A_ServerMessageRResponse)await ActorMessageSenderComponent.Instance.Call
               (serverid, new A2A_ServerMessageRequest()
               {
                   MessageType = messageType,
                   MessageValue = message
               });
        }

    }
}
