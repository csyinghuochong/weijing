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

            string orderId = "1";
            string nowTime = TimeHelper.ServerNow().ToString();
            if (self.DingdanlastTime != nowTime)
            {
                self.DingdanXuHao = 0;
            }
            else
            {
                self.DingdanXuHao++;
            }
            string dingDanID = $"{nowTime}{self.DingdanXuHao}_{request.Zone}_{request.RechargeNumber}";
            self.DingdanlastTime = nowTime;
            self.OrderDic.Add(dingDanID, $"{request.UnitId}_{request.UnitName}");

            paramlist.Add("aid", TikTokHelper.AppID.ToString());
            paramlist.Add("cp_order_id", orderId);
            paramlist.Add("product_id", "6");
            paramlist.Add("product_name", "钻石");
            paramlist.Add("product_desc", "钻石");
            paramlist.Add("product_amount", "1");
            paramlist.Add("sdk_open_id", request.Account);
            paramlist.Add("callback_url", self.HttpListenerUrl);
            paramlist.Add("actual_amount", "1");
            paramlist.Add("coupon_id", "0");
            paramlist.Add("risk_control_info", request.payMessage);
            paramlist.Add("trade_type", "2");
            paramlist.Add("extra_info", string.Empty);
            paramlist.Add("game_user_id", request.UnitId.ToString());
            paramlist.Add("role_id", request.UnitId.ToString());
            paramlist.Add("role_level", "1");
            paramlist.Add("role_name", request.UnitName);
            paramlist.Add("role_vip_leve", "0");
            paramlist.Add("server_id", request.Zone.ToString());
            paramlist.Add("user_agent", "");

            string signparamlist = string.Empty;
            foreach (var item in paramlist)
            {
                signparamlist = signparamlist + $"{item.Key}: {item.Value} \n";
            }
            Log.Warning($"参与sign的参数: {signparamlist}");
            string sign = TikTokHelper.getSign(paramlist);
            Log.Warning($"sign的结果:    {sign}");

            //接口参数  （除了client_ip、sign字段，其他的都参加sign计算；选传的参数，如果是空值则不加入sign计算）

            paramlist.Add("client_ip", request.ClientIp);
            paramlist.Add("sign", sign);

            string result = HttpHelper.OnWebRequestPost_Pay( self.TikTokRreOrder, paramlist);

            Log.Console($"sdk_open_id:  {request.Account}");
            Log.Console($"risk_control_info:  {request.payMessage}");
            Log.Console($"ReChargeTikTok:  {result}");
            Log.Warning($"ReChargeTikTok:  {result}");
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
                Log.Console($"CheckTikTokPayResult: 1");
                self.HttpListener.BeginGetContext(self.CheckTikTokPayResult, null);

                //异步传入值后进行调用
                HttpListenerContext context = self.HttpListener.EndGetContext(ar);
                HttpListenerRequest request = context.Request;//请求对象

                //读取数据流
                StreamReader body = new StreamReader(request.InputStream, Encoding.UTF8);//读取流，用来获取支付宝请求的数据
                //将传入的数据进行解码
                string pay_notice = HttpUtility.UrlDecode(body.ReadToEnd(), Encoding.UTF8);//HttpUtility.UrlDecode：解码 url编码，将字符串格式为%的形式，解码就是将%转化为字符串信息

                Log.Console($"pay_notice:  {pay_notice}");
                if (string.IsNullOrEmpty(pay_notice))
                {
                    return;
                }
            }
            catch (Exception ex) 
            {
                Log.Error(ex.ToString());
            }
        }
    }
}
