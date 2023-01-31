using System;

namespace ET
{

    [ObjectSystem]
    public class ReChargeIOSComponentAwake : AwakeSystem<ReChargeIOSComponent>
    {
        public override void Awake(ReChargeIOSComponent self)
        {
            self.PayLoadList.Clear();   
        }
    }

    public static class ReChargeIOSComponentSystem
    {

        public static async ETTask<int> OnIOSPayVerify(this ReChargeIOSComponent self, M2R_RechargeRequest request)
        {
            await ETTask.CompletedTask;
            Log.Debug($"IOS充值回调执行00 " + "id:" + request.UnitId);
            string verifyURL = string.Empty;
            //if (request.UnitId == 1636544958309662720 || request.UnitId == 1655723533625524224)
            //{
            //    verifyURL = "https://sandbox.itunes.apple.com/verifyReceipt";
            //}
            //else
            {
                verifyURL = "https://buy.itunes.apple.com/verifyReceipt";
            }

            string payLoad = request.payMessage;
            if (self.PayLoadList.Contains(payLoad))
            {
                return ErrorCore.ERR_IOSVerify;
            }

            string sendStr = "{\"receipt-data\":\"" + payLoad + "\"}";
            string postReturnStr = await HttpHelper.GetIosPayParameter(verifyURL, sendStr);

            Log.Debug($"IOS充值回调11 {postReturnStr}");
            Root rt = JsonHelper.FromJson<Root>(postReturnStr);
            Log.Debug($"IOS充值回调22 {rt.status}");
            //交易失败，直接返回
            if (rt.status != 0)
            {
                Log.Debug($"IOS充值回调ERROR1 {rt.status}");
                return ErrorCore.ERR_IOSVerify;
            }

            if (rt.receipt.in_app == null || rt.receipt.in_app.Count == 0)
            {
                Log.Debug($"IOS充值回调ERROR2 ");
                return ErrorCore.ERR_IOSVerify;
            }

            //封号处理 使用IAPFree工具
            if (rt.receipt.in_app[0].product_id == "com.zeptolab.ctrbonus.superpower1")
            {
                Log.Debug($"IOS充值回调ERROR3 ");
                return ErrorCore.ERR_IOSVerify;
            }

            if (!string.IsNullOrEmpty(rt.receipt.bundle_id) && rt.receipt.bundle_id != "com.guangying.weijing2")
            {
                Log.Debug($"IOS充值回调ERROR4");
                return ErrorCore.ERR_IOSVerify;
            }

            string dingDanTime = rt.receipt.purchase_date_ms;
            //判断时间

            string product_id = rt.receipt.in_app[0].product_id;
            //198SG
            if (!product_id.Contains("WJ") && !product_id.Contains("SG"))
            {
                Log.Debug($"IOS充值回调ERROR5");
                return ErrorCore.ERR_IOSVerify;
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
                return ErrorCore.ERR_IOSVerify;
            }
            self.PayLoadList.Add(payLoad);
            if (self.PayLoadList.Count >= 100)
            {
                self.PayLoadList.RemoveAt(0);
            }
            Log.Debug($"IOS充值成功！");
            RechargeHelp.OnPaySucessToGate(request.Zone, request.UnitId, rechargeNumber).Coroutine();
            return ErrorCore.ERR_Success;
        }
    }
}
