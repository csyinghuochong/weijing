using System;
using System.Net;

namespace ET
{

    [HttpHandler(SceneType.AccountCenter, "/wjtapconsolen")]
    public class HttpTapConsolenHandler : IHttpHandler
    {
        public async ETTask Handle(Entity entity, HttpListenerContext context)
        {
            System.Collections.Specialized.NameValueCollection queryString = context.Request.QueryString;
            string console = queryString["consolen"] ?? string.Empty;
            string lognname = queryString["lognname"] ?? string.Empty;
            if (!string.IsNullOrEmpty(console))
            {
                LogHelper.NoticeInfo(console, lognname);
            }
            HttpServerHelper.ResponseEmpty(context);
            await ETTask.CompletedTask;
        }
    }

        [ActorMessageHandler]
    public class G2Mail_EnterMailHandler : AMActorRpcHandler<Scene, G2Mail_EnterMail, Mail2G_EnterMail>
    {
        protected override async ETTask Run(Scene scene, G2Mail_EnterMail request, Mail2G_EnterMail response, Action reply)
        {
            MailSceneComponent mailScene = scene.GetComponent<MailSceneComponent>();
            if (request.ServerMailIdCur != -1)
            {
                mailScene.OnLogin(request.UnitId, request.ServerMailIdCur).Coroutine();
            }
            response.ServerMailIdMax = mailScene.GetMaxMaild();

            reply();
            await ETTask.CompletedTask;
        }
    }
}
