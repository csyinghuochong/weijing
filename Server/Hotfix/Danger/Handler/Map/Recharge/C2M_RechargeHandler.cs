using System;

namespace ET
{

    [ActorMessageHandler]
    public class C2M_RechargeHandler : AMActorLocationRpcHandler<Unit, C2M_RechargeRequest, M2C_RechargeResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_RechargeRequest request, M2C_RechargeResponse response, Action reply)
        {
            using (await CoroutineLockComponent.Instance.Wait(CoroutineLockType.Recharge, unit.Id))
            {
                long dbCacheId = DBHelper.GetCenterServerId();
                C2C_CenterServerInfoRespone d2GGetUnit = (C2C_CenterServerInfoRespone)await ActorMessageSenderComponent.Instance.Call(dbCacheId, new C2C_CenterServerInfoReuest() { Zone = unit.DomainZone(), infoType = 1 });
                //Log.ILog.Info("d2GGetUnit.Value = " + d2GGetUnit.Value);
                if (int.Parse(d2GGetUnit.Value) != 1)
                {
                    reply();
                    return;
                }
                if (ComHelp.IsBanHaoZone(unit.DomainZone()))
                {
                    Log.Debug($"充值[版号服]SendDiamondToUnit： {unit.Id}");
                    RechargeHelp.SendDiamondToUnit(unit, request.RechargeNumber, "版号服");
                    reply();
                    return;
                }

                long rechareId = DBHelper.GetRechargeCenter();
                R2M_RechargeResponse r2M_RechargeResponse = (R2M_RechargeResponse)await ActorMessageSenderComponent.Instance.Call(rechareId, new M2R_RechargeRequest()
                {
                    Zone = unit.DomainZone(),
                    PayType = request.PayType,
                    UnitId = unit.Id,
                    RechargeNumber = request.RechargeNumber
                });

                response.Message = r2M_RechargeResponse.Message;
            }
            reply();
            await ETTask.CompletedTask;
        }
    }
}
