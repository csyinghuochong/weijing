using System;
using System.Collections.Generic;

namespace ET
{
    [ActorMessageHandler]
    public class M2A_TurtleSupportHandler : AMActorRpcHandler<Scene, M2A_TurtleSupportRequest, A2M_TurtleSupportResponse>
    {
        protected override async ETTask Run(Scene scene, M2A_TurtleSupportRequest request, A2M_TurtleSupportResponse response, Action reply)
        {
            ActivitySceneComponent activitySceneComponent = scene.GetComponent<ActivitySceneComponent>();
            if (!activitySceneComponent.TurtleSupportList.ContainsKey(request.SupportId))
            {
                activitySceneComponent.TurtleSupportList.Add(request.SupportId, new List<KeyValuePair<long, long>>());
            }

            List<KeyValuePair<long, long>> supportlist = activitySceneComponent.TurtleSupportList[request.SupportId];
            for (int i = 0; i < supportlist.Count; i++)
            {
                if (supportlist[i].Key == request.AccountId)
                {
                    response.Error = ErrorCore.ERR_TurtleSupport_1;
                    reply();
                    return;
                }
            }
            
            activitySceneComponent.TurtleSupportList[request.SupportId].Add(new KeyValuePair<long, long>(request.AccountId, request.UnitId)); 
            reply();
            await ETTask.CompletedTask;
        }
    }
}
