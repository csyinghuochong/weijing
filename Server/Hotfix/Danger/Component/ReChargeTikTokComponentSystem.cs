using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ET
{

    [ObjectSystem]
    public class ReChargeTikTokComponentAwake : AwakeSystem<ReChargeTikTokComponent>
    {
        public override void Awake(ReChargeTikTokComponent self)
        {
            //1.启动监听支付结果的服务器
            self.ListenerTikTokResult();
        }
    }

    public static class ReChargeTikTokComponentSystem
    {

        public static string TikTokPay(this ReChargeTikTokComponent self, M2R_RechargeRequest request)
        {
            Dictionary<string, string> paramlist = new Dictionary<string, string>();    
            string result = HttpHelper.OnWebRequestPost_1( self.TikTokRreOrder, paramlist);

            return result;
        }

        public static void ListenerTikTokResult(this ReChargeTikTokComponent self)
        {
            if (ComHelp.IsInnerNet())
            {
                self.HttpListenerUrl = @"http://127.0.0.1:20005/";
            }
            if (ComHelp.IsBanHaoZone())
            {
                Log.Console("内测去屏蔽充值！");
                return;
            }

            //http监听器
            self.HttpListener = new HttpListener();
            self.HttpListener.Prefixes.Add(self.HttpListenerUrl);
            self.HttpListener.Start();
            //异步的方式处理请求
            self.HttpListener.BeginGetContext(self.CheckTikTokPayResult, self.HttpListener);
        }

        public static void CheckTikTokPayResult(this ReChargeTikTokComponent self, IAsyncResult ar)
        {
            try
            {
                self.HttpListener.BeginGetContext(self.CheckTikTokPayResult, null);

                //异步传入值后进行调用
                HttpListenerContext context = self.HttpListener.EndGetContext(ar);
                HttpListenerRequest request = context.Request;//请求对象

                //读取数据流
                StreamReader body = new StreamReader(request.InputStream, Encoding.UTF8);//读取流，用来获取支付宝请求的数据
                //将传入的数据进行解码
                string pay_notice = HttpUtility.UrlDecode(body.ReadToEnd(), Encoding.UTF8);//HttpUtility.UrlDecode：解码 url编码，将字符串格式为%的形式，解码就是将%转化为字符串信息
                if (string.IsNullOrEmpty(pay_notice))
                {
                    return;
                }

                Log.Console($"pay_notice:  {pay_notice}");
            }
            catch (Exception ex) 
            {
                Log.Error(ex.ToString());
            }
        }
    }
}
