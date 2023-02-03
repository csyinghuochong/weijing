using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;
using System.Xml;

namespace ET
{
    [ObjectSystem]
    public class ReChargeQDComponentAwakeSystem : AwakeSystem<ReChargeQDComponent>
    {
        public override void Awake(ReChargeQDComponent self)
        {
            self.ListenerAliPayResult();
        }
    }

    public static class ReChargeQDComponentSystem
    {
        public static string QudaoPay(this ReChargeQDComponent self, M2R_RechargeRequest request)
        {
            //第一步:获取支付的价格
            int totalFee = GettotalFeeTool.AliGettotalFee(request.RechargeNumber, 1);

            //唯一订单号
            string nowTime = TimeHelper.ClientNow().ToString();

            self.dingdanXuHao = (self.dingdanlastTime != nowTime) ? 0 : self.dingdanXuHao++;

            string dingDanID = "qd_" + nowTime + self.dingdanXuHao.ToString();

            //缓存订单 用于结果的校验
            if (self.orderDic.ContainsKey(dingDanID))
            {
                self.orderDic.Remove(dingDanID);
            }

            QudaoOrderInfo model = self.AddChild<QudaoOrderInfo>();
            model.zone = request.Zone;
            model.userId = request.UnitId;
            model.amount = request.RechargeNumber;
            model.objID = request.RechargeNumber;

            self.orderDic.Add(dingDanID, model);
            string toClientStr = model.objID + "," + dingDanID;
            return toClientStr;
        }

        public  static void ListenerAliPayResult(this ReChargeQDComponent self)
        {
            if (ComHelp.IsInnerNet())
            {
                self.httpListenerUrl = @"http://127.0.0.1:20004/";
            }
            //http监听器
            self.httpListener = new HttpListener();
            self.httpListener.Prefixes.Add(self.httpListenerUrl);
            self.httpListener.Start();
            self.httpListener.BeginGetContext(new AsyncCallback(self.CheckQudaoPayResult), null);
        }

        /// <summary>
        /// QuickSDK 同步参数解码
        /// </summary>
        /// <param name="src">密文</param>
        /// <param name="key">callbackKey</param>
        /// <returns></returns>
        public static string decode(this ReChargeQDComponent self, string src, string key)
        {
            if (src == null || src.Length == 0)
            {
                return src;
            }

            string pattern = "\\d+";
            MatchCollection results = Regex.Matches(src, pattern);

            ArrayList list = new ArrayList();
            for (int i = 0; i < results.Count; i++)
            {
                try
                {
                    String group = results[i].ToString();
                    list.Add((System.Object)group);
                }
                catch (Exception e)
                {
                    Log.Error(e.ToString());
                    return src;
                }
            }

            if (list.Count > 0)
            {
                try
                {
                    byte[] data = new byte[list.Count];
                    byte[] keys = System.Text.Encoding.Default.GetBytes(key);

                    for (int i = 0; i < data.Length; i++)
                    {
                        data[i] = (byte)(Convert.ToInt32(list[i]) - (0xff & Convert.ToInt32(keys[i % keys.Length])));
                    }
                    return System.Text.Encoding.Default.GetString(data);
                }
                catch (Exception e)
                {
                    Log.Error(e.ToString());
                    return src;
                }
            }
            else
            {
                return src;
            }

        }

        /// <summary>
        /// QuickSDK 同步参数编码
        /// </summary>
        /// <param name="src">密文</param>
        /// <param name="key">callbackKey</param>
        /// <returns></returns>
        public static string encode(this ReChargeQDComponent self, string src, string key)
        {
            try
            {
                byte[] data = System.Text.Encoding.Default.GetBytes(src);
                byte[] keys = System.Text.Encoding.Default.GetBytes(key);
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < data.Length; i++)
                {
                    int n = (0xff & data[i]) + (0xff & keys[i % keys.Length]);
                    sb.Append("@" + n);
                }
                return sb.ToString();
            }
            catch (Exception e)
            {
                Log.Error(e.ToString());
                return src;
            }

        }

        public static Dictionary<string, string> ParsePayResult(this ReChargeQDComponent self, string pay_notice)
        {
            Dictionary<string, string> payResult = new Dictionary<string, string>();
            try
            {
                string parsevalue = self.decode(pay_notice, self.callbackkey);
                StringReader Reader = new StringReader(parsevalue);

                XmlDocument xdoc = new XmlDocument();
                xdoc.Load(Reader);
                XmlNodeList nodeList = xdoc.GetElementsByTagName("quicksdk_message");

                XmlNodeList classNode = (XmlNodeList)nodeList.Item(0).ChildNodes[0].ChildNodes;//取列表中第一个对象
                foreach (XmlNode xn in classNode)
                {
                    XmlElement xe = (XmlElement)xn;
                    payResult[xe.Name] = xe.InnerText;
                }
            }
            catch (Exception ex)
            {
                Log.Debug(ex.ToString());
            }
            return payResult;
        }

        public static bool CheckMd5Sign(this ReChargeQDComponent self, string pay_notice)
        {
            string[] pay_value1 = pay_notice.Split('&');
            string nt_data = pay_value1[0].Split('=')[1];
            string sign = pay_value1[1].Split('=')[1];
            string md5Sign = pay_value1[2].Split('=')[1];
            string newsign1 = self.GetMD5WithString_2(nt_data + sign + self.md5Key);

            bool value = md5Sign.Equals(newsign1);
            return value;
        }

        public  static string GetMD5WithString_2(this ReChargeQDComponent self, String input)
        {
            if (input == null)
            {
                return null;
            }

            MD5 md5Hash = MD5.Create();

            // 将输入字符串转换为字节数组并计算哈希数据
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // 创建一个 Stringbuilder 来收集字节并创建字符串
            StringBuilder sBuilder = new StringBuilder();

            // 循环遍历哈希数据的每一个字节并格式化为十六进制字符串
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // 返回十六进制字符串
            return sBuilder.ToString();
        }


        public static void CheckQudaoPayResult(this ReChargeQDComponent self, IAsyncResult ar)
        {
            try
            {
                self.httpListener.BeginGetContext(new AsyncCallback(self.CheckQudaoPayResult), null);

                //异步传入值后进行调用
                HttpListenerContext context = self.httpListener.EndGetContext(ar);
                HttpListenerRequest request = context.Request;//请求对象

                //如果接受到的数据不为空
                //读取数据流
                StreamReader body = new StreamReader(request.InputStream, Encoding.UTF8);//读取流，用来获取支付宝请求的数据
                                                                                         //将传入的数据进行解码
                string pay_notice = HttpUtility.UrlDecode(body.ReadToEnd(), Encoding.UTF8);//HttpUtility.UrlDecode：解码 url编码，将字符串格式为%的形式，解码就是将%转化为字符串信息                                                                       
                if ( string.IsNullOrEmpty(pay_notice))
                {
                    return;
                }

                string[] pay_value1 = pay_notice.Split('&');
                string nt_data = pay_value1[0].Split('=')[1];
                Dictionary<string, string> payResults = self.ParsePayResult(nt_data);
                if (payResults.ContainsKey("game_order"))
                {
                    string dingdanid = payResults["game_order"];
                    QudaoOrderInfo orderinfo = null;
                    self.orderDic.TryGetValue(dingdanid, out orderinfo);

                    if (orderinfo != null && self.CheckMd5Sign(pay_notice) && payResults["status"] == "0")
                    {
                        Console.WriteLine(dingdanid + ":支付成功！");
                        //修改数据库订单描述
                        string toClientMsg = "SendPay," + "1" + "@" + "1" + "@" + orderinfo.objID + "@" + dingdanid + "@" + "服务器支付";
                        RechargeHelp.OnPaySucessToGate(orderinfo.zone, orderinfo.userId, orderinfo.amount,"渠道").Coroutine();
                    }
                    else
                    {
                        //string toClientMsg11 = "SendPay," + "2" + "@" + "1" + "@" + orderinfo.objID + "@" + dingdanid + "@" + "服务器支付";
                        //orderinfo.clientAgent.SendClientStr(toClientMsg11);
                        Console.WriteLine(dingdanid + ":支付失败！");
                    }
                    if (orderinfo != null)
                    {
                        self.orderDic.Remove(dingdanid);
                        orderinfo.Dispose();
                    }

                    HttpListenerResponse response = context.Response;
                    //给支付宝服务器返回success,如果不返回,支付宝服务器会间隔一段时间就向此服务器支付成功的回调信息
                    string responseString = "SUCCESS";
                    byte[] buffer = Encoding.UTF8.GetBytes(responseString);
                    response.ContentLength64 = buffer.Length;
                    Stream output = response.OutputStream;
                    output.Write(buffer, 0, buffer.Length);//响应支付宝服务器本次的通知
                    output.Close();
                    response.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("渠道包支付结果解析报错:" + e.ToString());
            }
        }
    }
}
