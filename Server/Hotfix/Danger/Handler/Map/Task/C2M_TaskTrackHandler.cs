using System;
namespace ET
{
    [ActorMessageHandler]
    public class C2M_TaskTrackHandler : AMActorLocationRpcHandler<Unit, C2M_TaskTrackRequest, M2C_TaskTrackResponse>
    {

        protected override async ETTask Run(Unit unit, C2M_TaskTrackRequest request, M2C_TaskTrackResponse response, Action reply)
        {
            int value = unit.GetComponent<TaskComponent>().TaskTrack(request);
            reply();
            await ETTask.CompletedTask;
        }

    }
}
