using System;

namespace ET
{
    [ActorMessageHandler]
    public class M2T_TeamDungeonOffHandler : AMActorRpcHandler<Scene, M2T_TeamDungeonOffRequest, T2M_TeamDungeonOffResponse>
    {

        protected override async ETTask Run(Scene scene, M2T_TeamDungeonOffRequest request, T2M_TeamDungeonOffResponse response, Action reply)
        {
            scene.GetComponent<TeamSceneComponent>().OnDungeonOff( request.UserID );

            reply();
            await ETTask.CompletedTask;
        }
    }
}
