using System;
using System.Collections.Generic;

namespace ET
{
    public class InApp
    {
        /// <summary>
        /// 
        /// </summary>
        public string product_id { get; set; }
    }

    public class Receipt
    {

        public List<InApp> in_app { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string original_purchase_date_pst { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string purchase_date_ms { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string unique_identifier { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string original_transaction_id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string bvrs { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string transaction_id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string quantity { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string unique_vendor_identifier { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string item_id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string original_purchase_date { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string is_in_intro_offer_period { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string purchase_date { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string is_trial_period { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string purchase_date_pst { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string bundle_id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string original_purchase_date_ms { get; set; }
    }

    public class Root
    {
        /// <summary>
        /// 
        /// </summary>
        public Receipt receipt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int status { get; set; }
    }

    [ActorMessageHandler]
    public class C2M_IOSPayVerifyHandler : AMActorLocationRpcHandler<Unit, C2M_IOSPayVerifyRequest, M2C_IOSPayVerifyResponse>
    {
       
        protected override async ETTask Run(Unit unit, C2M_IOSPayVerifyRequest request, M2C_IOSPayVerifyResponse response, Action reply)
        {
            //发送支付数据做验证
            LogHelper.LogWarning($"IOS充值回调,收到支付请求消息:  {unit.Id}");

            //携程锁
            using (await CoroutineLockComponent.Instance.Wait(CoroutineLockType.Recharge, unit.Id))
            {
                long rechareId = DBHelper.GetRechargeCenter();
                R2M_RechargeResponse r2M_RechargeResponse = (R2M_RechargeResponse)await ActorMessageSenderComponent.Instance.Call(rechareId, new M2R_RechargeRequest()
                {
                    Zone = unit.DomainZone(),
                    PayType = PayTypeEnum.IOSPay,
                    UnitId = unit.Id,
                    payMessage = request.payMessage
                });
            }
            reply();
            await ETTask.CompletedTask;
        }
    }
}
