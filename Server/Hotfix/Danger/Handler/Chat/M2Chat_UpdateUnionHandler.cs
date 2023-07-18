using System;

namespace ET
{
    [ActorMessageHandler]
    public class M2Chat_UpdateUnionHandler : AMActorRpcHandler<Scene, M2Chat_UpdateUnion, Chat2M_UpdateUnion>
    {
        protected override async ETTask Run(Scene scene, M2Chat_UpdateUnion request, Chat2M_UpdateUnion response, Action reply)
        {
          
            ChatSceneComponent chatInfoUnitsComponent = scene.GetComponent<ChatSceneComponent>();
            ChatInfoUnit chatInfoUnit = chatInfoUnitsComponent.Get(request.UnitId);
            if (chatInfoUnit == null)
            {
                Log.Console($"chatInfoUnit == null; {request.UnitId}");
                reply();
                return;
            }

            chatInfoUnit.UnionId = request.UnionId;
            reply();
            await ETTask.CompletedTask;
        }
    }
}
