using System;

namespace ET
{

    [ActorMessageHandler]
    public class M2U_UnionTransferHandler : AMActorRpcHandler<Scene, M2U_UnionTransferRequest, U2M_UnionTransferResponse>
    {
        protected override async ETTask Run(Scene scene, M2U_UnionTransferRequest request, U2M_UnionTransferResponse response, Action reply)
        {
            DBUnionInfo dBUnionInfo = await DBHelper.GetComponentCache<DBUnionInfo>(scene.DomainZone(), request.UnionId );
            if (dBUnionInfo == null)
            {
                response.Error = ErrorCore.ERR_Union_Not_Exist;
                reply();
                return;
            }
            UnionPlayerInfo unionPlayerInfo_self = UnionHelper.GetUnionPlayerInfo(dBUnionInfo.UnionInfo.UnionPlayerList, request.UnitID);
            if (unionPlayerInfo_self == null || unionPlayerInfo_self.UserID != dBUnionInfo.UnionInfo.LeaderId)
            {
                response.Error = ErrorCore.ERR_Union_NoLimits;
                reply();
                return;
            }

            UnionPlayerInfo unionPlayerInfo_new = UnionHelper.GetUnionPlayerInfo(dBUnionInfo.UnionInfo.UnionPlayerList, request.NewLeader);
            if (unionPlayerInfo_new == null)
            {
                response.Error = ErrorCore.ERR_Union_NoPlayer;
                reply();
                return;
            }

            dBUnionInfo.UnionInfo.LeaderId  = request.NewLeader;
            unionPlayerInfo_new.Position    = 1;
            unionPlayerInfo_self.Position   = 0;
            DBHelper.SaveComponent(scene.DomainZone(), request.UnionId, dBUnionInfo).Coroutine();
            reply();
            await ETTask.CompletedTask;
        }
    }
}
