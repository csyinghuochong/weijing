using System.Collections.Generic;

namespace ET
{
    public class RechargeComponent : Entity, IAwake, ITransfer, IUnitCache
    {
        //已验证的支付订单
        public List<string> PayLoadList = new List<string>();
    }
}
