using System;

namespace ET
{
    [ActorMessageHandler]
    public class C2E_GMEMailHandler : AMActorRpcHandler<Scene, C2E_GMEMailRequest, E2C_GMEMailResponse>
    {
        protected override async ETTask Run(Scene scene, C2E_GMEMailRequest request, E2C_GMEMailResponse response, Action reply)
        {
            //int errorCode = await ConsoleHelper.MailConsoleHandler(request.MailInfo);
            //response.Error = errorCode;     
            reply();
            await ETTask.CompletedTask;
        }

    }
}
