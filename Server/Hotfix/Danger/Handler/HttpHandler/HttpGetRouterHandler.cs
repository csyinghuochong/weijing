using System.Net;
using System.Web;

namespace ET
{

    [HttpHandler(SceneType.AccountCenter, "/get_router")]
    public class HttpGetRouterHandler : IHttpHandler
    {
        public async ETTask Handle(Entity entity, HttpListenerContext context)
        {
            System.Collections.Specialized.NameValueCollection queryString = context.Request.QueryString;
            string param1 = queryString["tap_track_id"];
            string param2 = queryString["tap_project_id"] ?? "default";

            HttpGetRouterResponse response = new HttpGetRouterResponse();

            HttpServerHelper.Response(context, response);
            await ETTask.CompletedTask;
        }
    }

}
