using System.Collections.Generic;
using System.Net;

namespace ET
{

    public class Pro_PayList : Entity, IAwake
    {
        public string zhanghaoID;           //玩家账号ID
        public string pay_PingTai;          //支付平台
        public string pay_DingDan;          //订单号
        public string pay_JiaGe;            //价格
        public string pay_Status;           //支付成功/失败
        public string pay_Des;              //交易信息
        public string pay_IOSDes;              //交易信息
    }

    public class ReChargeWXComponent :Entity, IAwake
    {
        public string miyao = "515M55XAQ0WRZIRRAKCIUUQCTFWN6V54";
        public string appId = "wx74d544161221d62f";
        public string merchantId = "1498251552";

        public string notify_url = @"http://39.96.194.143:20003";
        public string getWeChatPayParameterURL = @"https://api.mch.weixin.qq.com/pay/unifiedorder";
        public string packageValue = "Sign=WXPay";//扩展字段

        public int orderNumber = 1;//充值的序号

        public Dictionary<string, string> orderDic = new Dictionary<string, string>();

        public HttpListener httpListener; //http监听对象

        public string Order_Url = @"http://172.17.94.24:20003/";      //监听的url
    }
}
