using System.Collections.Generic;
using System.Net;

namespace ET
{
    public class XiaoQiOrderInfo : Entity, IAwake
    {
        public int amount;
        public int zone;
        public long userId;
        public string UnitName;
        public int RechargeType;
    }

    public class ReChargeXQComponent : Entity, IAwake
    {
        public string appKey = "8e4a4fc224dc249ff012e2623f670b83";
        public string x7PublicKey = "MIGfMA0GCSqGSIb3DQEBAQUAA4GNADCBiQKBgQC+I0ZD9muTrBuLlCcfmUzuHTsAlg5PvJJBk5T8KMoC5oCbsjP6332xlX3gbdgJ38oY2k+ZsUrbaDqTobPSCDfH79IdGzCbSla2o9UYVdK3iL7M8970BOK9XW1IDHXF+EDEiYjvwq1CN9dgF7vmANOBI3XlIrtDvtHgzQF2FPQ2FwIDAQAB";
        public string httpListenerUrl = @"http://172.17.94.24:20006/";
        public string notifyUrl = @"http://weijinggameservertestpay.weijinggame.com:20006/";

        public HttpListener httpListener;
        public Dictionary<string, XiaoQiOrderInfo> orderDic = new Dictionary<string, XiaoQiOrderInfo>();

        public long dingdanXuHao;
        public string dingdanlastTime;
    }
}
