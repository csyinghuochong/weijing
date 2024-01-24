using System;
using System.Linq;
using System.Collections.Generic;

namespace ET
{
    public class C2G_GMCommonHandler : AMActorRpcHandler<Scene, C2C_GMCommonRequest, C2C_GMCommonResponse>
    {
        protected override async ETTask Run(Scene scene, C2C_GMCommonRequest request, C2C_GMCommonResponse response, Action reply)
        {
            if (string.IsNullOrEmpty(request.Context) || !AdminHelper.AdminAccount.Contains(request.Account))
            {
                reply();
                return;
            }

            Game.EventSystem.Publish(new EventType.GMCommonRequest() { Context = request.Context });

            reply();
            await ETTask.CompletedTask;
        }
    }
}
