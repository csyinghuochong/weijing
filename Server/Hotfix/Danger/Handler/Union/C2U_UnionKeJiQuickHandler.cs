using System;

namespace ET
{
    [ActorMessageHandler]
    public class C2U_UnionKeJiQuickHandler : AMActorRpcHandler<Scene, C2U_UnionKeJiQuickRequest, U2C_UnionKeJiQuickResponse>
    {
        protected override async ETTask Run(Scene scene, C2U_UnionKeJiQuickRequest request, U2C_UnionKeJiQuickResponse response, Action reply)
        {
            DBUnionInfo dBUnionInfo = await scene.GetComponent<UnionSceneComponent>().GetDBUnionInfo(request.UnionId);
            if (dBUnionInfo == null)
            {
                response.Error = ErrorCode.ERR_Union_Not_Exist;
                reply();
                return;
            }

            if (dBUnionInfo.UnionInfo.KeJiActiteTime == 0)
            {
                response.Error = ErrorCode.ERR_Union_NotActive;
                reply();
                return;
            }

            int keijiId = dBUnionInfo.UnionInfo.UnionKeJiList[dBUnionInfo.UnionInfo.KeJiActitePos];
            UnionKeJiConfig unionKeJiConfig = UnionKeJiConfigCategory.Instance.Get(keijiId);
            if (unionKeJiConfig.NextID == 0)
            {
                response.Error = ErrorCode.ERR_Union_NotActive;
                reply();
                return;
            }

            int cost = UnionHelper.CalcuNeedeForAccele(dBUnionInfo.UnionInfo.KeJiActiteTime, unionKeJiConfig.NeedTime);
            
            ////需要向游戏服发送协议扣除钻石
            U2M_UnionKeJiQuickRequest r2M_RechargeRequest = new U2M_UnionKeJiQuickRequest() { Cost = cost };
            M2U_UnionKeJiQuickResponse m2G_RechargeResponse = (M2U_UnionKeJiQuickResponse)await ActorLocationSenderComponent.Instance.Call(request.ActorId, r2M_RechargeRequest);
            if (m2G_RechargeResponse.Error != ErrorCode.ERR_Success)
            {
                response.Error = m2G_RechargeResponse.Error;
                reply();
                return;
            }

            dBUnionInfo.UnionInfo.UnionKeJiList[dBUnionInfo.UnionInfo.KeJiActitePos] = unionKeJiConfig.NextID;
            dBUnionInfo.UnionInfo.KeJiActitePos = -1;
            dBUnionInfo.UnionInfo.KeJiActiteTime = 0;
            response.UnionInfo = dBUnionInfo.UnionInfo;
            DBHelper.SaveComponent(scene.DomainZone(), request.UnionId, dBUnionInfo).Coroutine();
            reply();
        }
    }
}
