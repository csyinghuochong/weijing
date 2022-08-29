using System;
using System.Net;
using System.Linq;
using System.Xml;
using System.Text;
using System.IO;
using System.Web;
using System.Collections.Generic;
using System.Security.Cryptography;

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
            await ETTask.CompletedTask;
            string paramss = $"{request.RechargeNumber}_{request.RechargeNumber}_{request.RechargeNumber}";
            string[] msg = paramss.Split('_');

            //获取现在的时间戳
            long nowTime = TimeHelper.ServerNow();
            int r_num = RandomHelper.RandomNumber(1000, 9999);

            OrderInfo orderInfo = self.AddChild<OrderInfo>();
            orderInfo.appid = self.appId;
            orderInfo.mch_id = self.merchantId;
            orderInfo.body = "危境游戏赞助";      //商品描述
            orderInfo.total_fee = GettotalFeeTool.WeChatGettotalFee(msg[1], msg[2]); //支付金额 单位:分
            orderInfo.spbill_create_ip = "";//agent.remoteIP;        //用户终端实际IP
            orderInfo.notify_url = self.notify_url;             //支付结果通知地址
            orderInfo.trade_type = "APP";//交易类型
            //随机字符串 不长于32位 不能使用'.'符号拼接,如IP:127.0.0.1
            orderInfo.nonce_str = "nonceStr" + r_num + self.orderNumber + nowTime;
            //商户订单号 要求唯一性 
            orderInfo.out_trade_no = "wxpay" + r_num + self.orderNumber + nowTime;
            //orderInfo.clientAgent = agent;
            orderInfo.UserId = request.UserId;
            orderInfo.objID = msg[0];
            orderInfo.objCount = int.Parse(msg[1]);

            //第一步:签名计算=>获取向微信服务器请求的参数
            Dictionary<string, string> dics = new Dictionary<string, string>();
            dics.Add("appid", orderInfo.appid);
            dics.Add("mch_id", orderInfo.mch_id);
            dics.Add("nonce_str", orderInfo.nonce_str);
            dics.Add("body", orderInfo.body);
            dics.Add("out_trade_no", orderInfo.out_trade_no);
            dics.Add("total_fee", orderInfo.total_fee.ToString());
            dics.Add("spbill_create_ip", orderInfo.spbill_create_ip);
            dics.Add("notify_url", orderInfo.notify_url);
            dics.Add("trade_type", orderInfo.trade_type);

            //将订单转换成Xml格式准备传入服务器
            //string tempXML = self.GetParamSrc(dics);
            //// 第二步:下单请求 - 获取响应的参数
            ////此处为关键代码,游戏服务器像支付服务器发送支付请求,并且返回数据到result中
            //string result = await ComHelp.OnWebRequestPost_2(self.getWeChatPayParameterURL, JsonHelper.ToJson(dics));
            Dictionary<string, string> data = new Dictionary<string, string>();
            data.Add("appid", "wx0f24f5e538739f0d");
            data.Add("mch_id", "1498251552");
            data.Add("nonce_str", "nonceStr649411654081134956");
            data.Add("body", "危境游戏赞助");
            data.Add("out_trade_no", "wxpay649411654081134956");
            data.Add("total_fee", "200");
            data.Add("spbill_create_ip", "");
            data.Add("notify_url", "http://39.96.194.143:30003");
            data.Add("trade_type", "APP");
            string result = await ComHelp.OnWebRequestPost_2(self.getWeChatPayParameterURL, self.GetParamToXml(data));
            ////第三步:将返回的参数再进行签名 并且按照我们跟客户端协定好的格式拼接
            string payList = self.PayOrder(result, orderInfo);
            //第四步:发送给客户端
            //记录订单数据
            //string idOnly = ServerSQL.MySqlData_ReadKey("ID", "ZhangHaoID", zhanghaoID, "PlayerData");
            //收到支付宝支付,创建数据库订单
            //Pro_PayList wx_payList = new Pro_PayList();
            //wx_payList.zhanghaoID = zhanghaoID;
            //wx_payList.pay_PingTai = "2";
            //wx_payList.pay_DingDan = orderInfo.out_trade_no;
            //wx_payList.pay_JiaGe = (orderInfo.total_fee / 100).ToString();
            //wx_payList.pay_Status = "0";
            //wx_payList.pay_Des = "申请支付";
            //ServerSQL.Player_WritePayData(wx_payList);

            dics.Clear();
            orderInfo.Dispose();
            self.orderNumber++;
            return payList;
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
            self.httpListener.BeginGetContext(new AsyncCallback(self.GetContextCallback), null);
        }

        /// <summary> 请求客户端在微信支付时候所需的参数 </summary>
        public static string GetWeChatPayParameter(this ReChargeWXComponent self, Dictionary<string, string> dic)
        {
            try
            {
                //-----------------------------------第一步:创建Htt请求----------------------//
                //向微信发起支付参数的请求
                return "";
            }
            catch (Exception ex)
            {
                Log.Error("生成预订单错误:" + ex.ToString());
            }
            return null;
        }

        /// <summary>
        /// 计算客户端调起微信支付所需要的参数
        /// </summary>
        /// <param name="str">微信服务器返回的数据</param>
        /// <returns>由参数加逗号拼接的字符串</returns>
        public static string PayOrder(this ReChargeWXComponent self, string str, OrderInfo orderinfo)
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
                Log.Debug("请求预支付单号异常:" + xml["return_msg"].InnerText);
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

            //缓存订单信息  以便于在微信结果出来后 进行对比校验
            orderinfo.prepay_id = xml["prepay_id"].InnerText;
            orderinfo.sign = sign;
            //存储订单信息,方便面收到返回数据进行比对
            self.orderDic.Add(orderinfo.out_trade_no, orderinfo);

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

        /// <summary> 签名算法 </summary>
        // 签名算法,传入订单数据
        public static string GetParamToXml(this ReChargeWXComponent self, Dictionary<string, string> dic)
        {
            //-----------第一步:对参数按照key=value的格式，并按照参数名ASCII字典序排序-----//

            //格式:键=值&键=值... 意义:获取sign参数
            StringBuilder str = new StringBuilder();
            //排序:升序
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

            //从这里开始 是对str字符串进行MD5加密
            //MD5 md5 = new MD5CryptoServiceProvider();
            MD5 md5 = MD5.Create();
            byte[] bytValue, bytHash;
            bytValue = Encoding.UTF8.GetBytes(getSignStr);
            bytHash = md5.ComputeHash(bytValue);
            md5.Clear();  //释放掉MD5对象
            string tempStr = "";
            //按16进制的格式 将字节数组转化为等效字符串
            for (int i = 0; i < bytHash.Length; i++)
            {
                tempStr += bytHash[i].ToString("X").PadLeft(2, '0');
            }
            //转化为大写 得到 sign签名参数
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
            //xmlStr.Append("<sign_type>" + "HMAC-SHA256" + "</sign_type></xml>");
 
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
                //读取到监听到的信息
                HttpListenerContext context = self.httpListener.EndGetContext(ar);
                HttpListenerRequest request = context.Request;

                //判定读取到的信息不为空
                if (context == null)
                {
                    return;
                }
                //将支付的回调结果转换成字符串
                StreamReader body = new StreamReader(request.InputStream, Encoding.UTF8);       //读取流，用来获取微信请求的数据
                string pay_notice = HttpUtility.UrlDecode(body.ReadToEnd(), Encoding.UTF8);     //HttpUtility.UrlDecode：解码                                                  //打印看看支付宝给我们发了什么
                Log.Debug("微信通知结果来了:" + pay_notice);

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
                if (xml["return_code"].InnerText != "SUCCESS")
                {
                    return;
                }
                //新建一个订单类,里面包含订单的所有参数
                OrderInfo checkData;
                //判断此订单是否存在 out_trade_no 是商户订单号
                if (self.orderDic.ContainsKey(xml["out_trade_no"].InnerText))
                {
                    checkData = self.orderDic[xml["out_trade_no"].InnerText];
                }
                else
                {
                    checkData = null;
                }

                //如果订单真实存在则继续执行
                if (checkData != null)
                {
                    //获取微信支付单号
                    string dingdanStr = xml["out_trade_no"].InnerText;
                    //存储数据库订单数据
                    //string payID = ServerSQL.MySqlData_ReadKey("ID", "DingDan", dingdanStr, "playerpay");
                    //ServerSQL.MySqlData_Write("PayStatus", "成功", "ID", payID, "playerpay");
                    //ServerSQL.MySqlData_Write("PayDes", "已向玩家发送支付结果", "ID", payID, "playerpay");
                    //out_trade_no 商户订单号
                    //打印订单成功信息
                    Log.Debug("支付成功:" + xml["return_code"].InnerText);
                    if (xml["out_trade_no"].InnerText.Contains(checkData.out_trade_no))
                    {
                        //if (xml["sign"].InnerText.Contains(checkData.sign))
                        //{
                        //安全验证 单号对应的金额 
                        //验证单号上的金额和xml中的金额是否一致
                        if (int.Parse(xml["total_fee"].InnerText) == checkData.total_fee)
                        {
                            Log.Debug("微信支付结果验证,单号金额一致");
                            //消息协议 SendProps,会话ID/订单号，道具ID,数量...(道具实体)
                            //向客户端发送道具
                            string out_trade_no = xml["out_trade_no"].InnerText;
                            //string toClientMsg = "SendPay," + "2" + "@" + out_trade_no + "@" + (int)(checkData.total_fee/100) + "@" + "1" + "@" + "服务器支付";
                            string toClientMsg = "SendPay," + "1" + "@" + "1" + "@" + (int)(checkData.total_fee / 100) + "@" + dingdanStr + "@" + "服务器支付";
                            //checkData.clientAgent.SendClientStr(toClientMsg);
                            //byte[] sendByte = Encoding.UTF8.GetBytes(toClientMsg);
                            //checkData.clientAgent.SendBytes(sendByte);
                        }
                        else
                        {
                            Log.Debug("微信支付结果验证,单号金额不一致");
                            //Todo 再进一步验证微信支付单号  .....   如果一致 进一步排除原因 
                            //最终如果确认是入侵的数据 再做相应的处理即可 
                        }
                    }
                    else
                    {
                        Console.WriteLine("订单不匹配，商户订单号:{0},error:{1}", xml["out_trade_no"].InnerText, xml["err_code"].InnerText);
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

            if (self.httpListener.IsListening)
            {
                try
                {
                    self.httpListener.BeginGetContext(new AsyncCallback(self.GetContextCallback), null);
                }
                catch (Exception e)
                {
                    Log.Error("微信报错222:" + e.ToString());
                }
            }
        }

    }
}
