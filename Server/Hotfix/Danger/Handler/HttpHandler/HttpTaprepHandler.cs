using System;
using System.Collections.Generic;
using System.Net;

namespace ET
{
    //http://39.96.194.143:20008/wjtaprep?idfa={IDFA}&time={TIME}&ip={IP}&game_id={TAP_PROJECT_ID}&game_name={GAME_NAME}&adset_id={ADSET_ID}&adset_net={ADSET_NAME}&device_brand={DEVICE_BRAND}&device_model={DEVICE_MODEL}&creative_id={CREATIVE_ID}&conversion_type={CONVERSION_TYPE}&device={DEVICE}&OAID={OAID}&callback={DEEP_CALLBACK_URL}&tap_track_id={TAP_TRACK_ID}&tap_project_id={TAP_PROJECT_ID}
    [HttpHandler(SceneType.AccountCenter, "/wjtaprepcallback")]
    public class HttpTaprepCallBackHandler : IHttpHandler
    {
        public async ETTask Handle(Entity entity, HttpListenerContext context)
        {
            Console.WriteLine($"HttpTaprepCallBackHandler:  {context.Request.RawUrl}");

            HttpServerHelper.ResponseEmpty(context);
            await ETTask.CompletedTask;
        }
    }


    //https://l.taptap.cn/E2d28678?channel=rep-rep_shn4rnatnaw
    [HttpHandler(SceneType.AccountCenter, "/wjtaprepjiance")]
    public class HttpTaprepJianCeHandler : IHttpHandler
    {
        public async ETTask Handle(Entity entity, HttpListenerContext context)
        {
            Console.WriteLine($"HttpTaprepJianCeHandler:  {context.Request.RawUrl}");

            System.Collections.Specialized.NameValueCollection queryString = context.Request.QueryString;

            string anid = queryString["anid"] ?? string.Empty;
            string callback = queryString["callback"] ?? string.Empty;
            string tap_project_id = queryString["tap_project_id"] ?? string.Empty;
            string tap_track_id = queryString["tap_track_id"] ?? string.Empty;

            if (!string.IsNullOrEmpty(anid))
            {
                DBCenterTaprepRequest dBCenterTaprepRequest = null;
                List<DBCenterTaprepRequest> centerAccountInfoList = await Game.Scene.GetComponent<DBComponent>().Query<DBCenterTaprepRequest>(202, d => d.anid == anid);
                if (centerAccountInfoList == null || centerAccountInfoList.Count == 0)
                {
                     dBCenterTaprepRequest = entity.AddChild<DBCenterTaprepRequest>();
                }
                else
                {
                    dBCenterTaprepRequest = centerAccountInfoList[0];
                }

                dBCenterTaprepRequest.anid = anid;
                dBCenterTaprepRequest.callback = callback;
                dBCenterTaprepRequest.tap_project_id = tap_project_id;
                dBCenterTaprepRequest.tap_track_id = tap_track_id;

                await Game.Scene.GetComponent<DBComponent>().Save(202, dBCenterTaprepRequest);
                dBCenterTaprepRequest.Dispose();
                dBCenterTaprepRequest = null;
            }


            HttpServerHelper.ResponseEmpty(context);
            await ETTask.CompletedTask;
        }
    }
}
