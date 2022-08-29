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
    }

    public class ReChargeQDComponent : Entity, IAwake
    {
        public string callbackkey = "94075752170876077849092058904924";
        public string md5Key = "rgcy2meduf2gu3zhvudzpq0xfzx9xdyo";
        public string httpListenerUrl = @"http://172.17.94.24:20004/";
        public HttpListener httpListener;
        public object listenLocker = new object();

        public Dictionary<string, QudaoOrderInfo> orderDic = new Dictionary<string, QudaoOrderInfo>();

        //订单序号ID
        public int dingdanXuHao;
        public string dingdanlastTime;
    }



}
