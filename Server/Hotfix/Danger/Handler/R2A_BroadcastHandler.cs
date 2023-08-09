using System;

namespace ET
{

    [ActorMessageHandler]
    public class R2A_BroadcastHandler : AMActorRpcHandler<Scene, R2A_Broadcast, A2R_Broadcast>
    {
        protected override async ETTask Run(Scene session, R2A_Broadcast request, A2R_Broadcast response, Action reply)
        {
            Log.Console("R2A_Broadcast_a: " + session.Name);

            switch (request.LoadType)
            {
                case 1: //狩猎
                    ActivityHelper.ShowLieOpen = request.LoadValue == "1";
                    break;
            }

            reply();
            await ETTask.CompletedTask;
        }
    }
}
