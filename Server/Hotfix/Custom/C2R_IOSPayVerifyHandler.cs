using System;
using System.Collections.Generic;

namespace ET
{

    [ActorMessageHandler]
    public class C2R_IOSPayVerifyHandler : AMActorRpcHandler<Scene, C2R_IOSPayVerifyRequest, R2C_IOSPayVerifyResponse>
    {
        protected override async ETTask Run(Scene scene, C2R_IOSPayVerifyRequest request, R2C_IOSPayVerifyResponse response, Action reply)
        {
            int zone = UnitIdStruct.GetUnitZone(request.UnitId);
            zone = StartZoneConfigCategory.Instance.Get(zone).PhysicZone;

            //Console.WriteLine($"C2R_IOSPayVerifyRequest C2R_IOSPayVerifyRequest xxxx");

            using (await CoroutineLockComponent.Instance.Wait(CoroutineLockType.Recharge, request.UnitId))
            {
                ////////////////111111
                await scene.GetComponent<ReChargeIOSComponent>().OnIOSPayVerify(new M2R_RechargeRequest()
                {
                    Zone = zone,
                    UnitId = request.UnitId,
                    payMessage = request.payMessage,
                    UnitName = request.UnitId.ToString(),
                });

                ////////////////222222
                //int errocode = scene.GetComponent<ReChargeIOSComponent>().OnIOSPayVerify_New(new M2R_RechargeRequest()
                //{
                //    Zone = zone,
                //    UnitId = request.UnitId,
                //    payMessage = request.payMessage,
                //    UnitName = request.UnitName
                //});

                //Console.WriteLine($"IOS充值回调11 {request.UnitName}  {errocode}");
                //if (errocode != ErrorCode.ERR_Success)
                //{
                //    return;
                //}

                //Root rt = null;
                ////Log.Warning($"IOS充值回调11 {postReturnStr}");
                //try
                //{
                //    rt = JsonHelper.FromJson<Root>(request.UnitName);
                //}
                //catch (Exception ex)
                //{
                //    Log.Warning($"IOS充值回调11_1 {ex.ToString()}");
                //    return;
                //}
                //Log.Warning($"IOS充值回调22 {rt.status}");
                ////交易失败，直接返回
                //if (rt.status != 0)
                //{
                //    Log.Warning($"IOS充值回调ERROR1 {rt.status}");
                //    return;
                //}

                //if (rt.receipt.in_app == null || rt.receipt.in_app.Count == 0)
                //{
                //    Log.Warning($"IOS充值回调ERROR2 ");
                //    return;
                //}

                ////封号处理 使用IAPFree工具
                //if (rt.receipt.in_app[0].product_id == "com.zeptolab.ctrbonus.superpower1")
                //{
                //    Log.Warning($"IOS充值回调ERROR3 ");
                //    return;
                //}

                //if (!string.IsNullOrEmpty(rt.receipt.bundle_id) && rt.receipt.bundle_id != "com.guangying.weijing2")
                //{
                //    Log.Warning($"IOS充值回调ERROR4");
                //    return;
                //}

                //string dingDanTime = rt.receipt.purchase_date_ms;
                ////判断时间
                //List<InApp> in_app_list = rt.receipt.in_app;
                //Log.Warning($"IOS充值回调[inapp]: {in_app_list.Count}");
                //for (int i = 0; i < in_app_list.Count; i++)
                //{
                //    InApp inApp = in_app_list[i];
                //    string product_id = inApp.product_id;

                //    if (product_id.Contains("SG"))
                //    {
                //        Log.Warning($"IOS充值回调ERROR5 : SG");
                //        continue;
                //    }

                //    int rechargeNumber = 0;

                //    if (product_id.Equals("testpay1"))
                //    {
                //        rechargeNumber = 1;
                //    }
                //    else
                //    {
                //        if (!product_id.Contains("WJ"))
                //        {
                //            Log.Warning($"IOS充值回调ERROR6 : !WJ");
                //            continue;
                //        }

                //        //testpay1
                //        product_id = product_id.Substring(0, product_id.Length - 2);

                //        try
                //        {
                //            rechargeNumber = int.Parse(product_id);
                //        }
                //        catch (Exception ex)
                //        {
                //            Log.Warning(ex.ToString());
                //            continue;
                //        }
                //    }

                //    string serverName = ServerHelper.GetGetServerItem(false, zone).ServerName;
                //    Log.Warning($"支付订单[IOS]支付成功: 区：{serverName}    玩家名字：{request.UnitId}     充值额度：{rechargeNumber}");
                //    Log.Console($"支付订单[IOS]支付成功: 区：{serverName}    玩家名字：{request.UnitId}     充值额度：{rechargeNumber}  时间:{TimeHelper.DateTimeNow().ToString()}");
                //    await RechargeHelp.OnPaySucessToGate(zone, request.UnitId, rechargeNumber, request.UnitName, PayTypeEnum.IOSPay);
                //}
                reply();
                await ETTask.CompletedTask;
            }
        }
    }
}
