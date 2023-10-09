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
                response.Error = ErrorCode.ERR_Union_Not_Exist;
                reply();
                return;
            }
            if (numericComponent.GetAsInt(NumericType.UnionLeader)== 0)
            {
                response.Error = ErrorCode.ERR_Union_NotLeader;
                reply();
                return;
            }

            long unionserverid = DBHelper.GetUnionServerId( unit.DomainZone() );
            M2U_UnionTransferRequest transferRequest = new M2U_UnionTransferRequest() { NewLeader = request.NewLeader, UnionId = unionid, UnitID = unit.Id };
            U2M_UnionTransferResponse responseUnionEnter = (U2M_UnionTransferResponse)await ActorMessageSenderComponent.Instance.Call(unionserverid, transferRequest);

            if (responseUnionEnter.Error != ErrorCode.ERR_Success)
            {
                response.Error = responseUnionEnter.Error;
                reply();
                return;
            }

            reply();
            await ETTask.CompletedTask;
        }
    }
}
