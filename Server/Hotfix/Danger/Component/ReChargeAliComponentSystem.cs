using Alipay.AopSdk.Core;
using Alipay.AopSdk.Core.Domain;
using Alipay.AopSdk.Core.Request;
using Alipay.AopSdk.Core.Response;
using Alipay.AopSdk.Core.Util;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Web;

namespace ET
{

    [ObjectSystem]
    public class ReChargeAliComponentAwakeSystem : AwakeSystem<ReChargeAliComponent>
    {
        public override void Awake(ReChargeAliComponent self)
        {
            //1.启动监听支付结果的服务器
            self.ListenerAliPayResult();
        }
    }

    public static class ReChargeAliComponentSystem
    {

        public static string AliPay(this ReChargeAliComponent self, M2R_RechargeRequest request)
        {
            //第一步:获取支付的价格
            int totalFee = GettotalFeeTool.AliGettotalFee(request.RechargeNumber, 1);

            //唯一订单号
            //string nowTime = TimeTool.ConvertDateTimeInt(DateTime.Now).ToString();
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

            //第二步:封装请求的参数模型
            //请求参数对照：https://docs.open.alipay.com/204/105465/
            //AliPayOrderInfo AlipayTradeAppPayModel
            AliPayOrderInfo model = self.AddChild<AliPayOrderInfo>(true);
            model.SetInfo(request.RechargeNumber.ToString(), dingDanID);
            model.objID = request.RechargeNumber.ToString();
            self.OrderDic.Add(dingDanID, request.UnitId.ToString());
            model.Dispose();

            //第三步:向支付宝的服务器请求 可用于 客户端调起支付的 参数
            string aliRequestStr = self.GetAliPayParameter(model.alipayTradeAppPayModel);

            //第四步:拼接格式 发送给客户端
            string toClientStr = "AliPay" + "," + aliRequestStr;
            //agent.SendClientStr(toClientStr);
            Log.Warning($"支付宝支付请求 {request.UnitId} {request.RechargeNumber}");
            return aliRequestStr;
        }

        /// <summary>
        /// 请求支付参数:https://docs.open.alipay.com/204/105465/
        /// </summary>
        /// <returns>客户端向安卓层（支付宝客户端SDK）请求的字符串</returns>
        public static string GetAliPayParameter(this ReChargeAliComponent self, AlipayTradeAppPayModel alipaymode)
        {
            //如果客户端为空则调用起安卓客户端
            if (self.client == null)
            {
                self.client = new DefaultAopClient(self.AliServerURL, self.appid, self.APP_Private_Key, "JSON", "1.0", "RSA2", self.AliPay_Public_Key, "UTF-8", false);
            }

            //参数对照: https://docs.open.alipay.com/204/105465/

            //向支付服务器发送支付请求
            self.request = new AlipayTradeAppPayRequest();
            self.request.SetBizModel(alipaymode);                    //请求的数据模型
            self.request.SetNotifyUrl(self.AliPayResultListenerUrl);      //设置支付结果通知的地址

            //这里和普通的接口调用不同，使用的是sdkExecute
            AlipayTradeAppPayResponse response = self.client.SdkExecute(self.request);

            //(不用理这句注释)HttpUtility.HtmlEncode是为了输出到页面时防止被浏览器将关键参数html转义，实际打印到日志以及http传输不会有这个问题
            //通过Body获取到返回的参数
            return response.Body;
        }

        /// <summary>监听阿里支付结果 https://docs.open.alipay.com/204/105301/ </summary>
        public static void ListenerAliPayResult(this ReChargeAliComponent self)
        {
            if (ComHelp.IsInnerNet())
            {
                self.HttpListenerUrl = @"http://127.0.0.1:20002/";
            }
            //http监听器
            self.HttpListener = new HttpListener();
            self.HttpListener.Prefixes.Add(self.HttpListenerUrl);
            self.HttpListener.Start();
            //异步的方式处理请求
            self.HttpListener.BeginGetContext(self.CheckAliPayResult, self.HttpListener);
        }

        public static void CheckAliPayResult(this ReChargeAliComponent self, IAsyncResult ar)
        {
            try
            {
                self.HttpListener.BeginGetContext(self.CheckAliPayResult,null);

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

           
                //此处存储所有的支付返回数据（因为返回数据是用aaa = bbb 的结构 所以用此方法进行解析,直接调用Key即可获取对应的Value）
                Dictionary<string, string> aliPayResultDic = self.StringToDictionary(pay_notice);
                if (aliPayResultDic == null)
                {
                    return;
                }

                //设置支付结果打印颜色并输出结果
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Log.Warning("支付宝支付结果来了：" + pay_notice);
                Console.ForegroundColor = ConsoleColor.White;

                //根据加密算法 验签 API 
                bool result = AlipaySignature.RSACheckV1(aliPayResultDic, self.AliPay_Public_Key, "UTF-8", "RSA2", false);
                string orderId = aliPayResultDic["out_trade_no"];
                if (result  && aliPayResultDic["trade_status"] == "TRADE_SUCCESS" && self.OrderDic.ContainsKey(orderId))
                {
                    long userId = long.Parse(self.OrderDic[orderId]);
                    Log.Warning($"支付宝支付成功 {userId}  {int.Parse(orderId.Split('_')[2])}");
                    RechargeHelp.OnPaySucessToGate( int.Parse(orderId.Split('_')[1]), userId, int.Parse(orderId.Split('_')[2]), orderId).Coroutine();
                    self.OrderDic.Remove(aliPayResultDic["out_trade_no"]);
                }
                else
                {
                    Log.Warning("支付宝支付失败");
                }
                //输出验证结果
 
                //输出当前订单的的信息
                if (aliPayResultDic.ContainsKey("trade_status"))
                {
                    switch (aliPayResultDic["trade_status"])
                    {
                        case "WAIT_BUYER_PAY":
                            Log.Warning("交易状态:" + "交易创建，等待买家付款");
                            break;
                        case "TRADE_CLOSED":
                            Log.Warning("交易状态:" + "未付款交易超时关闭，或支付完成后全额退款");
                            break;
                        case "TRADE_SUCCESS":
                            Log.Warning("交易状态:" + "交易支付成功");
                            break;
                        case "TRADE_FINISHED":
                            Log.Warning("交易结束，不可退款");
                            break;
                        default:
                            break;
                    }
                }

                //验签（支付）成功 告诉客户端 加钻石，给数据库加记录，等。。。  
                //另外官方建议：最好将返回数据中的几个重要信息，与支付时候对应的参数去对比。 
                //返回的所有参数都在这里：StringToDictionary(pay_notice)          
                //请求的参数 在：Get_equest_Str()    

                //成功了就需要给支付宝回消息“success”
                //https://docs.open.alipay.com/204/105301/
                HttpListenerResponse response = context.Response;

                //给支付宝服务器返回success,如果不返回,支付宝服务器会间隔一段时间就向此服务器支付成功的回调信息
                string responseString = "success";
                byte[] buffer = Encoding.UTF8.GetBytes(responseString);
                response.ContentLength64 = buffer.Length;
                Stream output = response.OutputStream;
                output.Write(buffer, 0, buffer.Length);//响应支付宝服务器本次的通知
                output.Close();
                response.Close();
            }
            catch (Exception e)
            {
                Log.Warning("支付宝:" + e.ToString());
            }

            //一直监听消息
            //if (self.HttpListener.IsListening)
            //{
            //    try
            //    {
            //        self.HttpListener.BeginGetContext(new AsyncCallback(self.CheckAliPayResult), null);
            //    }
            //    catch (Exception e)
            //    {
            //        Log.Debug("支付宝:" + e.ToString());
            //    }
            //}
        }

        /// <summary>
        /// 支付结果返回来的是字符串格式,而验证结果的API需要一个字典结构 so..提供这样的一个API
        /// </summary>
        public static Dictionary<string, string> StringToDictionary(this ReChargeAliComponent self, string value)
        {
            if (value.Length < 1)
            {
                return null;
            }

            Dictionary<string, string> dic = new Dictionary<string, string>();
            //每个字段之间用"&"拼接
            string[] dicStrs = value.Split('&');
            foreach (string str in dicStrs)
            {
                //    Console.Write("183value--" + str); 
                //每个字段的结构是通过"="拼接键值
                string[] strs = str.Split(new char[] { '=' }, 2);
                dic.Add(strs[0], strs[1]);
            }
            return dic;
        }
    }
}
