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

    public class OrderInfo : Entity, IAwake
    {
        public string appid = "wx0f24f5e538739f0d";//创建的应用ID
        public string mch_id = "1498251552";//商户ID
        public string nonce_str = "515M55XAQ0WRZIRRAKCIUUQCTFWN6V54";//随机字符串 不长于32位
        public string body = "";                                    //商品描述
        public string out_trade_no = "0078888899999988888";         //订单号商户系统内部订单号，要求32个字符内，只能是数字、大小写字母_-|*@ ，且在同一个商户号下唯一。
        public int total_fee = 1000;                                //1000分=1块钱
        public string spbill_create_ip = "";                        //用户终端实际IP
        public string notify_url = "";                              //139.196.112.69
        public string trade_type = "APP";
        public string scene_info = "危境";                     //这里填写实际场景信息

        public string prepay_id;//预支付单号
        public string sign;//最终给客户端的签名

        //public Agent clientAgent; //本次发起支付的客户端
        public long UserId;         //本次发起支付的客户端

        public string objID;//道具ID
        public int objCount;//道具数量

        public string transaction_id;//结果通知时返回的微信支付订单号
    }
    
    public class ReChargeWXComponent :Entity, IAwake
    {
        public string miyao = "515M55XAQ0WRZIRRAKCIUUQCTFWN6V54";
        public string appId = "wx0f24f5e538739f0d";
        public string merchantId = "1498251552";

        public string notify_url = @"http://39.96.194.143:20003";
        public string getWeChatPayParameterURL = @"https://api.mch.weixin.qq.com/pay/unifiedorder";
        public string packageValue = "Sign=WXPay";//扩展字段

        public int orderNumber = 1;//充值的序号

        public Dictionary<string, OrderInfo> orderDic = new Dictionary<string, OrderInfo>();

        public HttpListener httpListener; //http监听对象

        public string Order_Url = @"http://172.17.94.24:20003/";      //监听的url
    }
}
