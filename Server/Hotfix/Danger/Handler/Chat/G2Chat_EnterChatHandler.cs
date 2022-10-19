using System;
using System.Collections.Generic;


namespace ET
{
    [ActorMessageHandler]
    public class G2Chat_EnterChatHandler : AMActorRpcHandler<Scene, G2Chat_EnterChat, Chat2G_EnterChat>
    {
        protected override async ETTask Run(Scene scene, G2Chat_EnterChat request, Chat2G_EnterChat response, Action reply)
        {
            ChatSceneComponent chatInfoUnitsComponent = scene.GetComponent<ChatSceneComponent>();
            ChatInfoUnit chatInfoUnit = chatInfoUnitsComponent.Get(request.UnitId);

            if (chatInfoUnit != null && !chatInfoUnit.IsDisposed)
            {
                chatInfoUnit.Name = request.Name;
                chatInfoUnit.GateSessionActorId = request.GateSessionActorId;
                response.ChatInfoUnitInstanceId = chatInfoUnit.InstanceId;
                reply();
                return;
            }

            chatInfoUnit = chatInfoUnitsComponent.AddChildWithId<ChatInfoUnit>(request.UnitId);
            chatInfoUnit.AddComponent<MailBoxComponent>();

            chatInfoUnit.Name = request.Name;
            chatInfoUnit.GateSessionActorId = request.GateSessionActorId;
            response.ChatInfoUnitInstanceId = chatInfoUnit.InstanceId;
            chatInfoUnitsComponent.Add(chatInfoUnit);

            reply();
            await ETTask.CompletedTask;
        }
    }
}
