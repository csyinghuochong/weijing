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
            string payLoad = request.payMessage;
            if (unit.GetComponent<RechargeComponent>().PayLoadList.Contains(payLoad))
            {
                reply();
                return;
            }

            //携程锁
            using (await CoroutineLockComponent.Instance.Wait(CoroutineLockType.Recharge, unit.Id))
            {
                string verifyURL = string.Empty;
                if (ComHelp.IsInnerNet())
                {
                    verifyURL = "https://sandbox.itunes.apple.com/verifyReceipt";
                }
                else
                {
                    verifyURL = "https://buy.itunes.apple.com/verifyReceipt";
                }
                string sendStr = "{\"receipt-data\":\"" + payLoad + "\"}";
                string postReturnStr = await HttpHelper.GetIosPayParameter(verifyURL, sendStr);

                Root rt = JsonHelper.FromJson<Root>(postReturnStr);

                //交易失败，直接返回
                if (rt.status != 0)
                {
                    reply();
                    return;
                }

                if (rt.receipt.in_app == null || rt.receipt.in_app.Count == 0)
                {
                    reply();
                    return;
                }

                //封号处理 使用IAPFree工具
                if (rt.receipt.in_app[0].product_id == "com.zeptolab.ctrbonus.superpower1")
                {
                    reply();
                    return;
                }

                if (!string.IsNullOrEmpty(rt.receipt.bundle_id) && rt.receipt.bundle_id != "com.guangying.weijing2")
                {
                    reply();
                    return;
                }

                string dingDanTime = rt.receipt.purchase_date_ms;
                //判断时间

                string product_id = rt.receipt.in_app[0].product_id;
                //198SG
                if (!product_id.Contains("SG"))
                {
                    reply();
                    return;
                }

                product_id = product_id.Substring(0, product_id.Length - 2);
                int rechargeNumber = 0;
                try
                {
                    rechargeNumber = int.Parse(product_id);
                }
                catch (Exception ex)
                {
                    Log.Warning(ex.ToString());
                    reply();
                    return;
                }

                //充值成功
                unit.GetComponent<RechargeComponent>().PayLoadList.Add(payLoad);
                RechargeHelp.SendDiamondToUnit(unit, rechargeNumber);
                reply();
            }
            await ETTask.CompletedTask;
        }
    }
}
