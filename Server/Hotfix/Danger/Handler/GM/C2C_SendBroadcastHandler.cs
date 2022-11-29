using System;
using System.Collections.Generic;

namespace ET
{
    [ActorMessageHandler]
    public class C2C_SendBroadcastHandler : AMActorRpcHandler<ChatInfoUnit, C2C_SendBroadcastRequest, C2C_SendBroadcastResponse>
    {
        protected override async ETTask Run(ChatInfoUnit chatInfoUnit, C2C_SendBroadcastRequest request, C2C_SendBroadcastResponse response, Action reply)
        {
            List<int> zones = new List<int>();
            if (request.ZoneType == 0)
            {
                zones.AddRange(ServerMessageHelper.GetAllZone());
            }
            else
            {
                zones.Add(chatInfoUnit.DomainZone());
            }

            for (int  i= 0; i < zones.Count; i++)
            {
                ServerMessageHelper.SendBroadMessage(zones[i], NoticeType.Notice, request.ChatInfo.ChatMsg);
            }

            reply();
            await ETTask.CompletedTask;
        }
    }
}