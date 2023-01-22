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
            Log.Debug($"IOS充值回调,收到支付请求消息:");
            string payLoad = request.payMessage;
            Log.Debug($"IOS充值回调,收到支付请求消息:" + "payLoad:" + payLoad + "id:" + unit.Id);
            if (unit.GetComponent<RechargeComponent>().PayLoadList.Contains(payLoad))
            {
                Log.Debug($"IOS充值回调错误,直接返回" + "id:" + unit.Id);
                reply();
                return;
            }
            Log.Debug($"IOS充值回调执行 " + "id:" + unit.Id);
            //携程锁
            using (await CoroutineLockComponent.Instance.Wait(CoroutineLockType.Recharge, unit.Id))
            {
                Log.Debug($"IOS充值回调执行00 " + "id:" + unit.Id);
                string verifyURL = string.Empty;
                if (ComHelp.IsInnerNet() || unit.Id == 1636544958309662720||unit.Id == 1655723533625524224)
                {
                    verifyURL = "https://sandbox.itunes.apple.com/verifyReceipt";
                }
                else
                {
                    verifyURL = "https://buy.itunes.apple.com/verifyReceipt";
                }
                string sendStr = "{\"receipt-data\":\"" + payLoad + "\"}";
                string postReturnStr = await HttpHelper.GetIosPayParameter(verifyURL, sendStr);

                Log.Debug($"IOS充值回调11 {postReturnStr}");
                Root rt = JsonHelper.FromJson<Root>(postReturnStr);
                Log.Debug($"IOS充值回调22 {rt}");
                //交易失败，直接返回
                if (rt.status != 0)
                {
                    Log.Debug($"IOS充值回调ERROR1 {rt.status}");
                    reply();
                    return;
                }

                if (rt.receipt.in_app == null || rt.receipt.in_app.Count == 0)
                {
                    Log.Debug($"IOS充值回调ERROR2 ");
                    reply();
                    return;
                }

                //封号处理 使用IAPFree工具
                if (rt.receipt.in_app[0].product_id == "com.zeptolab.ctrbonus.superpower1")
                {
                    Log.Debug($"IOS充值回调ERROR3 ");
                    reply();
                    return;
                }

                if (!string.IsNullOrEmpty(rt.receipt.bundle_id) && rt.receipt.bundle_id != "com.guangying.weijing2")
                {
                    Log.Debug($"IOS充值回调ERROR4");
                    reply();
                    return;
                }

                string dingDanTime = rt.receipt.purchase_date_ms;
                //判断时间

                string product_id = rt.receipt.in_app[0].product_id;
                //198SG
                if (!product_id.Contains("WJ") && !product_id.Contains("SG"))
                {
                    Log.Debug($"IOS充值回调ERROR5");
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
