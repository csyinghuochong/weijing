using System;

namespace ET
{
    [ActorMessageHandler]
    public class M2Chat_UpdateLevelHandler : AMActorRpcHandler<Scene, M2Chat_UpdateLevel, Chat2M_UpdateLevel>
    {
        protected override async ETTask Run(Scene scene, M2Chat_UpdateLevel request, Chat2M_UpdateLevel response, Action reply)
        {
            ChatSceneComponent chatInfoUnitsComponent = scene.GetComponent<ChatSceneComponent>();
            ChatInfoUnit chatInfoUnit = chatInfoUnitsComponent.Get(request.UnitId);
            if(chatInfoUnit != null ) 
            {
                chatInfoUnit.Level = request.Level;
                //Console.WriteLine("11121212");
            }
            await ETTask.CompletedTask;
        }
    }
}
