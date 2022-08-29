using System;

namespace ET
{
    [ActorMessageHandler]
    public class C2A_FirstWinInfoHandler : AMActorRpcHandler<Scene, C2A_FirstWinInfoRequest, A2C_FirstWinInfoResponse>
    {
        protected override async ETTask Run(Scene scene, C2A_FirstWinInfoRequest request, A2C_FirstWinInfoResponse response, Action reply)
        {
            response.FirstWinInfos = scene.GetComponent<ActivitySceneComponent>().DBDayActivityInfo.FirstWinInfos;

            reply();
            await ETTask.CompletedTask;
        }
    }
}
