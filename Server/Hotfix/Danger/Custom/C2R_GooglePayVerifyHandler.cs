using System;

namespace ET
{

    /// <summary>
    /// google支付结果效验
    /// </summary>
    [ActorMessageHandler]
    public class C2R_GooglePayVerifyHandler: AMActorRpcHandler<Scene, C2R_GooglePayVerifyRequest, R2C_GooglePayVerifyResponse>
    {
        protected override async ETTask Run(Scene scene, C2R_GooglePayVerifyRequest request, R2C_GooglePayVerifyResponse response, Action reply)
        {
            int zone = UnitIdStruct.GetUnitZone(request.UnitId);
            zone = StartZoneConfigCategory.Instance.Get(zone).PhysicZone;

            Console.WriteLine($"C2R_GooglePayVerifyRequest C2R_GooglePayVerifyRequest xxx {TimeInfo.Instance.ToDateTime(TimeHelper.ServerNow())}");

            using (await CoroutineLockComponent.Instance.Wait(CoroutineLockType.Recharge, request.UnitId))
            {
                //await scene.GetComponent<ReChargeGoogleComponent>().OnGooglePayVerify2(new M2R_RechargeRequest()
                //{
                //    Zone = zone,
                //    UnitId = request.UnitId,
                //    payMessage = request.payMessage, 
                //    UnitName = request.UnitId.ToString(),
                //    RechargeType = request.RechargeType,
                //});

                reply();
                await ETTask.CompletedTask;
            }
        }
    }
}