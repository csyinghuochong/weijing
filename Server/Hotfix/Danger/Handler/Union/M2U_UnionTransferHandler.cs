using System;

namespace ET
{

    [ActorMessageHandler]
    public class M2U_UnionTransferHandler : AMActorRpcHandler<Scene, M2U_UnionTransferRequest, U2M_UnionTransferResponse>
    {
        protected override async ETTask Run(Scene scene, M2U_UnionTransferRequest request, U2M_UnionTransferResponse response, Action reply)
        {
            Log.Console("转移族长1");
            DBUnionInfo dBUnionInfo = await scene.GetComponent<UnionSceneComponent>().GetDBUnionInfo(request.UnionId);
            if (dBUnionInfo == null)
            {
                response.Error = ErrorCode.ERR_Union_Not_Exist;
                reply();
                return;
            }
            UnionPlayerInfo unionPlayerInfo_self = UnionHelper.GetUnionPlayerInfo(dBUnionInfo.UnionInfo.UnionPlayerList, request.UnitID);
            if (unionPlayerInfo_self == null || unionPlayerInfo_self.UserID != dBUnionInfo.UnionInfo.LeaderId)
            {
                response.Error = ErrorCode.ERR_Union_NoLimits;
                reply();
                return;
            }

            UnionPlayerInfo unionPlayerInfo_new = UnionHelper.GetUnionPlayerInfo(dBUnionInfo.UnionInfo.UnionPlayerList, request.NewLeader);
            if (unionPlayerInfo_new == null)
            {
                response.Error = ErrorCode.ERR_Union_NoPlayer;
                reply();
                return;
            }

            dBUnionInfo.UnionInfo.LeaderId  = request.NewLeader;
            unionPlayerInfo_new.Position    = 1;
            unionPlayerInfo_self.Position   = 0;
            DBHelper.SaveComponent(scene.DomainZone(), request.UnionId, dBUnionInfo).Coroutine();

            //通知新族长
            //G2T_GateUnitInfoResponse g2M_UpdateUnitResponse_2 = (G2T_GateUnitInfoResponse)await ActorMessageSenderComponent.Instance.Call
            //   (gateServerId, new T2G_GateUnitInfoRequest()
            //   {
            //       UserID = request.NewLeader
            //   });
            //if (g2M_UpdateUnitResponse_2.PlayerState == (int)PlayerState.Game && g2M_UpdateUnitResponse_2.SessionInstanceId > 0)
            //{
            //    MessageHelper.SendToLocationActor(request.NewLeader, new M2M_UnionTransferMessage() { UnionLeader = 1 });
            //}
            //else
            //{
            //    NumericComponent numericComponent_2 = await DBHelper.GetComponentCache<NumericComponent>(scene.DomainZone(), request.NewLeader);
            //    numericComponent_2.Set(NumericType.UnionLeader, 1, false);
            //    DBHelper.SaveComponent(scene.DomainZone(), request.NewLeader, numericComponent_2).Coroutine();
            //}
            UnionHelper.NoticeUnionLeader(scene.DomainZone(), request.NewLeader, 1).Coroutine();

            //通知旧族长
            UnionHelper.NoticeUnionLeader(scene.DomainZone(), request.UnitID, 0).Coroutine();

            reply();
            await ETTask.CompletedTask;
        }

       
    }
}
