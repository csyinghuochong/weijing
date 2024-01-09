using System;

namespace ET
{

    [ActorMessageHandler]
    public class C2Chat_GetChatHandler : AMActorRpcHandler<ChatInfoUnit, C2Chat_GetChatRequest, Chat2C_GetChatResponse>
    {
        protected override async ETTask Run(ChatInfoUnit chatInfoUnit, C2Chat_GetChatRequest request, Chat2C_GetChatResponse response, Action reply)
        {
            ChatSceneComponent chatInfoUnitsComponent = chatInfoUnit.DomainScene().GetComponent<ChatSceneComponent>();
            response.ChatInfos = chatInfoUnitsComponent.WordChatInfos;

            reply();
            await ETTask.CompletedTask;
        }
    }
}
