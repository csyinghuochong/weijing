using System;

namespace ET
{
    [ActorMessageHandler]
    public class G2Mail_EnterMailHandler : AMActorRpcHandler<Scene, G2Mail_EnterMail, Mail2G_EnterMail>
    {
        protected override async ETTask Run(Scene scene, G2Mail_EnterMail request, Mail2G_EnterMail response, Action reply)
        {
            MailSceneComponent mailScene = scene.GetComponent<MailSceneComponent>();
            response.ServerMailIdMax = mailScene.OnLogin(request.UnitId, request.ServerMailIdCur);

            reply();
            await ETTask.CompletedTask;
        }
    }
}
