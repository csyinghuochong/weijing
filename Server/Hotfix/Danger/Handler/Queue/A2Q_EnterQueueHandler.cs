using System;

namespace ET
{
    public class A2Q_EnterQueueHandler : AMActorRpcHandler<Scene, A2Q_EnterQueue, Q2A_EnterQueue>
    {
        protected override async ETTask Run(Scene scene, A2Q_EnterQueue request, Q2A_EnterQueue response, Action reply)
        {
            scene.GetComponent<QueueSessionsComponent>().AddToken(request.AccountId, request.Token);
            response.QueueNumber = scene.GetComponent<QueueSessionsComponent>().QueueSessionsDictionary.Count + 1;

            reply();
            await ETTask.CompletedTask;
        }
    }
}
