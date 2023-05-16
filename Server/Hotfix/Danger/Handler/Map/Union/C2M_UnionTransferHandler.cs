using System;

namespace ET
{
    [ActorMessageHandler]
    public class C2M_UnionTransferHandler : AMActorLocationRpcHandler<Unit, C2M_UnionTransferRequest, M2C_UnionTransferResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_UnionTransferRequest request, M2C_UnionTransferResponse response, Action reply)
        {
            NumericComponent numericComponent = unit.GetComponent<NumericComponent>();
            long unionid = numericComponent.GetAsLong( NumericType.UnionId_0 );
            if (unionid == 0)
            {
                response.Error = ErrorCore.ERR_Union_Not_Exist;
                reply();
                return;
            }
            if (numericComponent.GetAsInt(NumericType.UnionLeader)== 0)
            {
                response.Error = ErrorCore.ERR_Union_NotLeader;
                reply();
                return;
            }

            long unionserverid = DBHelper.GetUnionServerId( unit.DomainZone() );
            M2U_UnionTransferRequest transferRequest = new M2U_UnionTransferRequest() { NewLeader = request.NewLeader, UnionId = unionid, UnitID = unit.Id };
            U2M_UnionTransferResponse responseUnionEnter = (U2M_UnionTransferResponse)await ActorMessageSenderComponent.Instance.Call(unionserverid, transferRequest);

            if (responseUnionEnter.Error != ErrorCore.ERR_Success)
            {
                response.Error = responseUnionEnter.Error;
                reply();
                return;
            }

            //转让族长成功
            numericComponent.ApplyValue(NumericType.UnionLeader, 0);

            //通知新族长
            long gateServerId = DBHelper.GetGateServerId(unit.DomainZone());
            G2T_GateUnitInfoResponse g2M_UpdateUnitResponse = (G2T_GateUnitInfoResponse)await ActorMessageSenderComponent.Instance.Call
               (gateServerId, new T2G_GateUnitInfoRequest()
               {
                   UserID = request.NewLeader
               });
            if (g2M_UpdateUnitResponse.PlayerState == (int)PlayerState.Game && g2M_UpdateUnitResponse.SessionInstanceId > 0)
            {
                MessageHelper.SendToLocationActor(request.NewLeader, new M2M_UnionTransferMessage());
            }
            else
            {
                NumericComponent numericComponent_2 = await DBHelper.GetComponentCache<NumericComponent>(unit.DomainZone(), request.NewLeader);
                numericComponent_2.Set(NumericType.UnionLeader, 1, false);
                DBHelper.SaveComponent(unit.DomainZone(), request.NewLeader, numericComponent_2).Coroutine();
            }

            reply();
            await ETTask.CompletedTask;
        }
    }
}
