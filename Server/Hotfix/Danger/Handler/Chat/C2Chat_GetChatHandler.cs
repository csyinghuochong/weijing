using System;

namespace ET
{

    [ActorMessageHandler]
    public class C2Chat_GetChatHandler : AMActorRpcHandler<ChatInfoUnit, C2Chat_GetChatRequest, Chat2C_GetChatResponse>
    {
        protected override async ETTask Run(ChatInfoUnit chatInfoUnit, C2Chat_GetChatRequest request, Chat2C_GetChatResponse response, Action reply)
        {
            long serverTime = TimeHelper.ServerNow();
            ChatSceneComponent chatInfoUnitsComponent = chatInfoUnit.DomainScene().GetComponent<ChatSceneComponent>();

            for (int i = 0; i < chatInfoUnitsComponent.WordChatInfos.Count; i++)
            {
                ChatInfo chatInfo = chatInfoUnitsComponent.WordChatInfos[i];
                if (serverTime - chatInfo.Time < TimeHelper.OneDay)
                {
                    response.ChatInfos.Add(chatInfo);
                }
            }
            

            reply();
            await ETTask.CompletedTask;
        }
    }
}
