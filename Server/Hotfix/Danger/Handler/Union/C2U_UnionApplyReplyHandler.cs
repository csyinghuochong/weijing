using System;

namespace ET
{

    [ActorMessageHandler]
    public class C2U_UnionApplyReplyHandler : AMActorRpcHandler<Scene, C2U_UnionApplyReplyRequest, U2C_UnionApplyReplyResponse>
    {

        protected override async ETTask Run(Scene scene, C2U_UnionApplyReplyRequest request, U2C_UnionApplyReplyResponse response, Action reply)
        {
            DBUnionInfo dBUnionInfo = await scene.GetComponent<UnionSceneComponent>().GetDBUnionInfo(request.UnionId);

            if (dBUnionInfo.UnionInfo.ApplyList.Contains(request.UserId))
            {
                dBUnionInfo.UnionInfo.ApplyList.Remove(request.UserId);
            }

            //拒绝入会
            if (request.ReplyCode == 0)
            {
                reply();
                return;
            }
            //同意入会
            bool exist = false;
            for (int i = 0; i < dBUnionInfo.UnionInfo.UnionPlayerList.Count; i++)
            {
                if (dBUnionInfo.UnionInfo.UnionPlayerList[i].UserID == request.UserId)
                {
                    exist = true;
                    break;
                }
            }
            if (!exist)
            {
                long dbCacheId = DBHelper.GetDbCacheId(scene.DomainZone());
                D2G_GetComponent d2GGet = (D2G_GetComponent)await ActorMessageSenderComponent.Instance.Call(dbCacheId, new G2D_GetComponent() { UnitId = request.UserId, Component = DBHelper.UserInfoComponent });
                UserInfoComponent userInfoComponent = d2GGet.Component as UserInfoComponent;
                dBUnionInfo.UnionInfo.UnionPlayerList.Add(new UnionPlayerInfo()
                {
                    UserID = request.UserId,
                });

                //通知玩家
                long gateServerId = DBHelper.GetGateServerId(scene.DomainZone());
                G2T_GateUnitInfoResponse g2M_UpdateUnitResponse = (G2T_GateUnitInfoResponse)await ActorMessageSenderComponent.Instance.Call
                   (gateServerId, new T2G_GateUnitInfoRequest()
                   {
                       UserID = request.UserId
                   });
                if (g2M_UpdateUnitResponse.PlayerState == (int)PlayerState.Game && g2M_UpdateUnitResponse.SessionInstanceId > 0)
                {
                    U2M_UnionApplyRequest r2M_RechargeRequest = new U2M_UnionApplyRequest() { UnionId = request.UnionId, UnionName = dBUnionInfo.UnionInfo.UnionName };
                    M2U_UnionApplyResponse m2G_RechargeResponse = (M2U_UnionApplyResponse)await ActorLocationSenderComponent.Instance.Call(g2M_UpdateUnitResponse.UnitId, r2M_RechargeRequest);
                }
                else
                {
                    userInfoComponent.UserInfo.UnionId = request.UnionId;
                    D2M_SaveComponent d2GSave = (D2M_SaveComponent)await ActorMessageSenderComponent.Instance.Call(dbCacheId, new M2D_SaveComponent() { UnitId = request.UserId, Component = userInfoComponent, ComponentType = DBHelper.UserInfoComponent });
                }
            }
            reply();
        }
    }
}
