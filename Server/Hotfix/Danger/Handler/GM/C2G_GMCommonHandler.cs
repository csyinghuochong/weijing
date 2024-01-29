using System;

namespace ET
{
    public class C2G_GMCommonHandler : AMActorRpcHandler<Scene, C2C_GMCommonRequest, C2C_GMCommonResponse>
    {
        protected override async ETTask Run(Scene scene, C2C_GMCommonRequest request, C2C_GMCommonResponse response, Action reply)
        {
            Console.WriteLine($"request.Context:  {request.Account} {request.Context}");
            if (string.IsNullOrEmpty(request.Context) || !AdminHelper.AdminAccount.Contains(request.Account))
            {
                reply();
                return;
            }
            Console.WriteLine($"request.Context:  GMCommonRequest");
            Game.EventSystem.Publish(new EventType.GMCommonRequest() { Context = request.Context });

            reply();
            await ETTask.CompletedTask;
        }
    }
}
