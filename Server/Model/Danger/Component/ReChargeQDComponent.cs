using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ET
{

    public class QudaoOrderInfo : Entity, IAwake
    {
        public int amount;
        public int objID;
        public int zone;
        public long userId;
        public string UnitName;
    }

    public class ReChargeQDComponent : Entity, IAwake
    {
        public string callbackkey = "79732310199972304452069037663031";
        public string md5Key = "16ujpemxehsnxls0eyijzgos41xn6ru7";
        public string httpListenerUrl = @"http://172.17.94.24:20004/";  //39.96.194.143
        public HttpListener httpListener;
        public object listenLocker = new object();

        public Dictionary<string, QudaoOrderInfo> orderDic = new Dictionary<string, QudaoOrderInfo>();

        //订单序号ID
        public int dingdanXuHao;
        public string dingdanlastTime;
    }



}
