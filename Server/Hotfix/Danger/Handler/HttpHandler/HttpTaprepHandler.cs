using System;
using System.Collections.Generic;
using System.Net;

namespace ET
{

    //http://39.96.194.143:20008/wjtaprepcallback
    //https://weijinggameserver.weijinggame.com:20008/wjtaprepcallback
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

    //http://39.96.194.143:20008/wjtaprepjiance?idfa={IDFA}&time={TIME}&ip={IP}&game_id={TAP_PROJECT_ID}&game_name={GAME_NAME}&adset_id={ADSET_ID}&adset_net={ADSET_NAME}&device_brand={DEVICE_BRAND}&device_model={DEVICE_MODEL}&creative_id={CREATIVE_ID}&conversion_type={CONVERSION_TYPE}&device={DEVICE}&OAID={OAID}&callback={DEEP_CALLBACK_URL}&tap_track_id={TAP_TRACK_ID}&tap_project_id={TAP_PROJECT_ID}
    //https://l.taptap.cn/E2d28678?channel=rep-rep_shn4rnatnaw
    [HttpHandler(SceneType.AccountCenter, "/wjtaprepjiance")]
    public class HttpTaprepJianCeHandler : IHttpHandler
    {
        public async ETTask Handle(Entity entity, HttpListenerContext context)
        {
            //Console.WriteLine($"HttpTaprepJianCeHandler Old:  {context.Request.RawUrl}");

            System.Collections.Specialized.NameValueCollection queryString = context.Request.QueryString;

            string anid = queryString["OAID"] ?? string.Empty;
            string callback = queryString["callback"] ?? string.Empty;
            string tap_project_id = queryString["tap_project_id"] ?? string.Empty;
            string tap_track_id = queryString["tap_track_id"] ?? string.Empty;

            Console.WriteLine($"anid:  {anid}");

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

    [HttpHandler(SceneType.AccountCenter, "/wjtapconsole")]
    public class HttpTapConsoleHandler : IHttpHandler
    {
        public async ETTask Handle(Entity entity, HttpListenerContext context)
        {
            Console.WriteLine($"HttpTapConsoleHandler:  {context.Request.RawUrl}");
            System.Collections.Specialized.NameValueCollection queryString = context.Request.QueryString;
            string console = queryString["console"] ?? string.Empty;
            if (!string.IsNullOrEmpty(console))
            {
                Game.EventSystem.Publish(new EventType.GMCommonRequest() { Context = console });
            }
            HttpServerHelper.ResponseEmpty(context);
            await ETTask.CompletedTask;
        }
    }

    //配置链接
    //http://39.96.194.143:20008/wjtapadtrack?idfa={IDFA}&time={TIME}&ip={IP}&org_id={ORG_ID}&org_name={ORG_NAME}&game_id={TAP_PROJECT_ID}&game_name={GAME_NAME}&adset_id={ADSET_ID}&adset_net={ADSET_NAME}&device_brand={DEVICE_BRAND}&device_model={DEVICE_MODEL}&creative_id={CREATIVE_ID}&conversion_type={CONVERSION_TYPE}&device={DEVICE}&OAID={OAID}&callback={DEEP_CALLBACK_URL}
    //平台回传给广告主归因服务对应的示例：
    //http://39.96.194.143:20008/wjtapadtrack?idfa=asedfstUfe&time=1605432321&ip=10.33.25.54&org_id=20&org_name=广告主名称&game_id=13&game_name=游戏名称&adset_id=132214&adset_net=计划名称&device_brand=苹果&device_model=iPhone3,2&creative_id=131232&conversion_type=TapTapAd&device=1&OAID=&callback=https%3A%2F%2Fdcc.iem.taptap.cn%2Fv1%2Fdeep%2Fcallback%3Ftap_track_id%3DxYTKx4rSFFWx%26tap_project_id%3D1111&tap_track_id=xYTKx4rSFFWx&tap_project_id=1111
    //tap_track_id、tap_project_id 两个字段在下载回传服务中默认下发，在深度事件回传中回传该字段，也可以通过{TAP_TRACK_ID}和{TAP_PROJECT_ID}宏进行获取
    //tap_project_id、tap_track_id 默认填充在{DEEP_CALLBACK_URL}中，不需要再次拼接这两个参数， 由于历史问题，使用旧回传宏 {CALLBACK_HTTPS} / {CALLBACK_HTTP} 的客户建议尽快更换为新宏{DEEP_CALLBACK_URL}， 旧宏在下发时默认会添加event_timestamp和event_type， 请不要在后面再次拼接event_timestamp和event_type，造成重复参数，务必用真实事件时间和类型替换掉下发时这两个参数值， 否则会导致事件缺失或时间错误造成报表数据看不到，尤其是回传付费事件时。

    [HttpHandler(SceneType.AccountCenter, "/wjtapadtrack")]
    public class HttpTapAdTrackHandler : IHttpHandler
    {
        public async ETTask Handle(Entity entity, HttpListenerContext context)
        {
            Console.WriteLine($"HttpTapAdTrackHandler:  {context.Request.RawUrl}");

            System.Collections.Specialized.NameValueCollection queryString = context.Request.QueryString;

            string anid = queryString["OAID"] ?? string.Empty;
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

                Console.WriteLine($"anid:  {anid}");
                Console.WriteLine($"callback:  {callback}");

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
