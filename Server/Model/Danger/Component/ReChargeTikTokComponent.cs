using Alipay.AopSdk.Core;
using Alipay.AopSdk.Core.Domain;
using Alipay.AopSdk.Core.Request;
using System.Collections.Generic;
using System.Net;


namespace ET
{

    public class ReChargeTikTokComponent : Entity, IAwake
    {

        public string DingdanlastTime;
        public long DingdanXuHao;

        public HttpListener HttpListener;
        public string HttpListenerUrl = @"http://172.17.94.24:20005/";
        public string TikTokRreOrder = "https://usdk.dailygn.com/gsdk/usdk/payment/live_pre_order";

        // <summary> 订单的集合 实际上 要持久化到数据库或者硬盘上 放在内存中会因为服务器重启而丢失已有的订单 </summary>
        //从服务器开启到现在存储的所有游戏内的订单号
        public Dictionary<string, string> OrderDic = new Dictionary<string, string>();
    }
}
