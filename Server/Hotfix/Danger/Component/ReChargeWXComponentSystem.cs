using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Web;
using System.Xml;

namespace ET
{

    [ObjectSystem]
    public class ReChargeWXComponentAwakeSystem : AwakeSystem<ReChargeWXComponent>
    {
        public override void Awake(ReChargeWXComponent self)
        {
            self.WeChatPayResultListener();
        }
    }

    public static class ReChargeWXComponentSystem
    {

        public static async ETTask<string> WeChatPay(this ReChargeWXComponent self, M2R_RechargeRequest request)
        {
            string paramss = $"{request.RechargeNumber}_{request.RechargeNumber}_{request.RechargeNumber}";
            string[] msg = paramss.Split('_');

            //获取现在的时间戳
            long nowTime = TimeHelper.ServerNow();
            int r_num = RandomHelper.RandomNumber(1000, 9999);

            int tolalFee = GettotalFeeTool.WeChatGettotalFee(msg[1], msg[2]);
            string dingDanID = "wxpay" + r_num + self.orderNumber + nowTime + "_" + tolalFee.ToString();
            //第一步:签名计算=>获取向微信服务器请求的参数
            //将订单转换成Xml格式准备传入服务器
            //string tempXML = self.GetParamSrc(dics);
            //// 第二步:下单请求 - 获取响应的参数
            ////此处为关键代码,游戏服务器像支付服务器发送支付请求,并且返回数据到result中
            //string result = await ComHelp.OnWebRequestPost_2(self.getWeChatPayParameterURL, JsonHelper.ToJson(dics));
            Dictionary<string, string> data = new Dictionary<string, string>();
            data.Add("appid", self.appId);
            data.Add("mch_id", self.merchantId);
            data.Add("nonce_str", "nonceStr" + r_num + self.orderNumber + nowTime);
            data.Add("body", "危境游戏赞助");
            data.Add("out_trade_no", dingDanID);
            data.Add("total_fee", tolalFee.ToString());
            data.Add("spbill_create_ip", "123.12.12.123");
            data.Add("notify_url", self.notify_url);
            data.Add("trade_type", "APP");
            Log.Debug($"微信支付请求 {request.UnitId}  {msg[1]}");
            string tempXML = self.GetParamToXml(data);
            string result = "";
            try
            {
                var httpClient = new HttpClient();
                HttpContent httpContent = new StringContent(tempXML);
                httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/x-www-form-urlencoded");
                HttpResponseMessage response = await httpClient.PostAsync(self.getWeChatPayParameterURL, httpContent);
                response.EnsureSuccessStatusCode();//用来抛异常的
                result = await response.Content.ReadAsStringAsync();
            }
            catch (Exception ex)
            {
                Log.Info($"Exception ex: {ex}");
                return "";
            }

            //存储订单信息,方便面收到返回数据进行比对
            self.orderDic.Add(dingDanID, $"{request.Zone}_{request.UnitId}");

            ////第三步:将返回的参数再进行签名 并且按照我们跟客户端协定好的格式拼接
            self.orderNumber++;
            return self.PayOrder(result);
        }

        public static void WeChatPayResultListener(this ReChargeWXComponent self)
        {
            if (ComHelp.IsInnerNet())
            {
                self.Order_Url = @"http://127.0.0.1:20003/";
            }

            //开启微信支付监听
            self.httpListener = new HttpListener();
            self.httpListener.Prefixes.Add(self.Order_Url);
            self.httpListener.Start();
            //调用移除处理请求
            self.httpListener.BeginGetContext(self.GetContextCallback, self.httpListener);
        }

        /// <summary>
        /// 计算客户端调起微信支付所需要的参数
        /// </summary>
        /// <param name="str">微信服务器返回的数据</param>
        /// <returns>由参数加逗号拼接的字符串</returns>
        public static string PayOrder(this ReChargeWXComponent self, string str)
        {
            //微信支付返回的是XML 需要进行解析
            //将str解析成xml格式,方便后面进行比对
            XmlDocument doc = new XmlDocument();
            //防止xml被外部注入修改
            doc.XmlResolver = null;
            doc.LoadXml(str);
            XmlNode xml = doc.DocumentElement;
            //状态码:SUCCESS 成功   FAIL 失败
            if (xml["return_code"].InnerText == "FAIL")//获取预支付单号失败
            {
                Log.Warning($"请求预支付单号异常:{ xml["return_msg"].InnerText}");
                //实际上这里对错误 不应该直接处理 而是需要根据错误原因做相应的逻辑
                //如充值单号如果重复了 随机字符串如果重复了 就重新生成
                //但是 像这类异常 应该是在请求之前 就有相应的策略 而不应该等到这里来响应处理
                //错误码:https://pay.weixin.qq.com/wiki/doc/api/app/app.php?chapter=9_1
                return "error";
            }

            //请求参数:https://pay.weixin.qq.com/wiki/doc/api/app/app.php?chapter=9_12&index=2
            //解析得到以下的这些参数 再进行二次签名
            //将上面解析的xml数据加入到dic中存储
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("appid", xml["appid"].InnerText);
            dic.Add("partnerid", xml["mch_id"].InnerText);
            dic.Add("prepayid", xml["prepay_id"].InnerText);
            dic.Add("noncestr", xml["nonce_str"].InnerText);
            dic.Add("package", "Sign=WXPay");
            //dic.Add("package", "Sign");
            //存储时间
            string timeStamp = TimeHelper.ServerNow().ToString();
            dic.Add("timestamp", timeStamp);
            //进行签名,并返回的是XML格式数据
            string sign = self.GetParamToXml(dic);

            //将客户端所需要的参数进行返回
            //string msg = xml["appid"].InnerText + "," + xml["mch_id"].InnerText + "," + xml["prepay_id"].InnerText + "," + xml["nonce_str"].InnerText + "," + timeStamp + "," + packageValue + "," + sign;
            XmlDocument nowDoc = new XmlDocument();
            //防止xml被外部注入修改
            nowDoc.XmlResolver = null;
            nowDoc.LoadXml(sign);
            XmlNode nowXml = nowDoc.DocumentElement;
            string nowSign = nowXml["sign"].InnerText;

            string msg = xml["appid"].InnerText + "," + xml["mch_id"].InnerText + "," + xml["prepay_id"].InnerText + "," + xml["nonce_str"].InnerText + "," + timeStamp + "," + self.packageValue + "," + nowSign;
            dic.Clear();//清空本次的数据
            return msg;
        }

        public static string GetParamToXml(this ReChargeWXComponent self, Dictionary<string, string> dic)
        {
            StringBuilder str = new StringBuilder();
            var param1 = dic.OrderBy(x => x.Key).ToDictionary(x => x.Key, y => y.Value);

            //再从字典中 获取各个元素 拼接为XML的格式 键跟值之间 用"="连接起来
            foreach (string dic1 in param1.Keys)
            {
                str.Append(dic1 + "=" + dic[dic1] + "&");
            }
            //-----------------第二步:拼接商户密钥 获取签名sign-----------------------------//
            str.Append("key=" + self.miyao);
            //把空字符串给移除替换掉 得到获取sign的字符串
            string getSignStr = str.ToString().Replace(" ", "");
           
            string tempStr = MD5Helper.StringMD5(getSignStr);
            string sign = tempStr.ToUpper();

            //------------------第三步 返回XML格式的字符串--------------------------//
            StringBuilder xmlStr = new StringBuilder();
            xmlStr.Append("<xml>");
            foreach (string dic1 in param1.Keys)
            {
                xmlStr.Append("<" + dic1 + ">" + dic[dic1] + "</" + dic1 + ">");
            }
            //追加到XML尾部
            xmlStr.Append("<sign>" + sign + "</sign></xml>");
            xmlStr = xmlStr.Replace(" ", "");
            string data = xmlStr.ToString().Replace(" ", "");
            return data;
        }

        /// <summary>
        /// 异步处理请求
        /// </summary>
        /// <param name="ar"></param>
        public static void GetContextCallback(this ReChargeWXComponent self, IAsyncResult ar)
        {
            try
            {
                //继续异步监听
                self.httpListener.BeginGetContext(self.GetContextCallback, null);

                //读取到监听到的信息
                HttpListenerContext context = self.httpListener.EndGetContext(ar);
                HttpListenerRequest request = context.Request;
                //判定读取到的信息不为空
                if (context == null)
                {
                    Log.Warning("微信支付通知结果来了context == null");
                    return;
                }
                //将支付的回调结果转换成字符串
                StreamReader body = new StreamReader(request.InputStream, Encoding.UTF8);       //读取流，用来获取微信请求的数据
                string pay_notice = HttpUtility.UrlDecode(body.ReadToEnd(), Encoding.UTF8);     //HttpUtility.UrlDecode：解码                                                  //打印看看支付宝给我们发了什么
                Log.Warning("微信支付通知结果来了:" + pay_notice);
                if (string.IsNullOrEmpty(pay_notice))
                {
                    return;
                }
                //回应结果的对象
                HttpListenerResponse response = context.Response;
                //微信支付返回的是XML 需要进行XML解析
                XmlDocument doc = new XmlDocument();
                //防止xml被外部注入修改
                doc.XmlResolver = null;
                doc.LoadXml(pay_notice);
                XmlNode xml = doc.DocumentElement;
                //状态码:SUCCESS 成功   FAIL 失败
                if (xml == null || xml["return_code"] == null || xml["return_code"].InnerText != "SUCCESS")
                {
                    return;
                }
                //新建一个订单类,里面包含订单的所有参数
                string userinfo = string.Empty;
                //获取微信支付单号
                string dingdanStr = xml["out_trade_no"].InnerText;
                //判断此订单是否存在 out_trade_no 是商户订单号
                if (self.orderDic.ContainsKey(dingdanStr))
                {
                    userinfo = self.orderDic[dingdanStr];
                }
                //如果订单真实存在则继续执行
                if (userinfo != string.Empty)
                {
                    //存储数据库订单数据
                    //out_trade_no 商户订单号
                    //打印订单成功信息
                    //安全验证 单号对应的金额 
                    //验证单号上的金额和xml中的金额是否一致
                    int amount = int.Parse(dingdanStr.Split('_')[1]);
                    Log.Warning($"单号金额: {xml["total_fee"].InnerText}  {amount} ");
                    if (int.Parse(xml["total_fee"].InnerText) == amount)
                    {
                        //消息协议 SendProps,会话ID/订单号，道具ID,数量...(道具实体)
                        //向客户端发送道具
                        int zone = int.Parse(userinfo.Split('_')[0]);
                        long userId = long.Parse(userinfo.Split('_')[1]);
                        amount /= 100;
                        Log.Warning($"微信支付成功 {userId}  {amount}");
                        RechargeHelp.OnPaySucessToGate( zone, userId, amount, dingdanStr).Coroutine();
                        //删除本地缓存的订单
                        self.orderDic.Remove(dingdanStr);
                    }
                    else
                    {
                        Log.Warning("微信支付失败,单号金额不一致");
                    }
                }

                //回应给微信服务器,如果此消息不发送服务器会一直向自己发送订单信息
                string responseStr = @"<xml><return_code><![CDATA[SUCCESS]]></return_code><return_msg><![CDATA[OK]]></return_msg></xml>";
                byte[] buffer = Encoding.UTF8.GetBytes(responseStr);
                response.ContentLength64 = buffer.Length;
                Stream output = response.OutputStream;
                output.Write(buffer, 0, buffer.Length);

                //发送完毕关闭流
                output.Close();
                response.Close();
            }
            catch (Exception e)
            {
                Log.Error("微信支付报错111:" + e.ToString());
            }

            //if (self.httpListener.IsListening)
            //{
            //    try
            //    {
            //        self.httpListener.BeginGetContext(new AsyncCallback(self.GetContextCallback), null);
            //    }
            //    catch (Exception e)
            //    {
            //        Log.Error("微信支付报错222:" + e.ToString());
            //    }
            //}
        }

    }
}
