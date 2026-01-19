using System;
using System.Collections.Generic;
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

    [HttpHandler(SceneType.AccountCenter, "/game_start")]
    public class HttpGameStartHandler : IHttpHandler
    {
        public async ETTask Handle(Entity entity, HttpListenerContext context)
        {
            System.Collections.Specialized.NameValueCollection queryString = context.Request.QueryString;
            string param1 = queryString["TIME"];
            string anid = queryString["OAID"];

            Console.WriteLine($"game_start anid:  {anid}");
            if (long.TryParse(param1, out long createTimne) && !string.IsNullOrEmpty(anid) && !anid.Contains("00000000"))
            {
                DBCenterDataCache dBCenterDataCache = null;
                List<DBCenterDataCache> centerDataCaches = await Game.Scene.GetComponent<DBComponent>().Query<DBCenterDataCache>(202, d => d.anid == anid);
                if (centerDataCaches == null || centerDataCaches.Count == 0)
                {
                    dBCenterDataCache = entity.AddChild<DBCenterDataCache>();
                }
                else
                {
                    dBCenterDataCache = centerDataCaches[0];
                }
                
                dBCenterDataCache.anid = anid;
                dBCenterDataCache.CreateTimeLong = createTimne;
                dBCenterDataCache.CreateTimeString = TimeInfo.Instance.ToDateTime(createTimne).ToString();
                await Game.Scene.GetComponent<DBComponent>().Save(202, dBCenterDataCache);
                dBCenterDataCache.Dispose();
                dBCenterDataCache = null;
            }


            HttpGetRouterResponse response = new HttpGetRouterResponse();
            HttpServerHelper.Response(context, response);
            await ETTask.CompletedTask;
        }
    }

}
