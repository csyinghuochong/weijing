using System;

namespace ET
{
    [ActorMessageHandler]
    public class C2U_UnionKeJiActiteHandler : AMActorRpcHandler<Scene, C2U_UnionKeJiActiteRequest, U2C_UnionKeJiActiteResponse>
    {
        protected override async ETTask Run(Scene scene, C2U_UnionKeJiActiteRequest request, U2C_UnionKeJiActiteResponse response, Action reply)
        {
            DBUnionInfo dBUnionInfo = await scene.GetComponent<UnionSceneComponent>().GetDBUnionInfo(request.UnionId);
            if (dBUnionInfo == null)
            {
                response.Error = ErrorCode.ERR_Union_Not_Exist;
                reply();
                return;
            }

            if (dBUnionInfo.UnionInfo.KeJiActiteTime != 0)
            {
                response.Error = ErrorCode.ERR_Union_HavActive;
                reply();
                return;
            }

            U2M_UnionKeJiQuickRequest r2M_RechargeRequest = new U2M_UnionKeJiQuickRequest() {  };
            M2U_UnionKeJiQuickResponse m2G_RechargeResponse = (M2U_UnionKeJiQuickResponse)await ActorLocationSenderComponent.Instance.Call(request.ActorId, r2M_RechargeRequest);
            if (m2G_RechargeResponse.Error != ErrorCode.ERR_Success)
            {
                response.Error = m2G_RechargeResponse.Error;
                reply();
                return;
            }

            dBUnionInfo.UnionInfo.KeJiActitePos = request.Position;
            dBUnionInfo.UnionInfo.KeJiActiteTime = TimeHelper.ServerNow();
            DBHelper.SaveComponent(scene.DomainZone(), request.UnionId, dBUnionInfo).Coroutine();
            reply();
        }
    }
}
