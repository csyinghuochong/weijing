using System;
using System.Collections.Generic;
using System.Linq;


namespace ET
{

    [ActorMessageHandler]
    public class C2M_EMailReceiveHandler : AMActorLocationRpcHandler<Unit, C2M_ReceiveMailRequest, M2C_ReceiveMailResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_ReceiveMailRequest request, M2C_ReceiveMailResponse response, Action reply)
        {
            MailComponent mailComponent = unit.GetComponent<MailComponent>();
            mailComponent.OnReceiveMail(request.MailId).Coroutine();

            reply();
            await ETTask.CompletedTask;
        }
    }
}
