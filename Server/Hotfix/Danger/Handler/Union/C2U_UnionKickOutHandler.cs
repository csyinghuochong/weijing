using System;

namespace ET
{

    [ActorMessageHandler]
    public class C2U_UnionKickOutHandler : AMActorRpcHandler<Scene, C2U_UnionKickOutRequest, U2C_UnionKickOutResponse>
    {
        protected override async ETTask Run(Scene scene, C2U_UnionKickOutRequest request, U2C_UnionKickOutResponse response, Action reply)
        {
            long dbCacheId = DBHelper.GetDbCacheId(scene.DomainZone());
            D2G_GetComponent d2GGet = (D2G_GetComponent)await ActorMessageSenderComponent.Instance.Call(dbCacheId, new G2D_GetComponent() { UnitId = request.UserId, Component = DBHelper.UserInfoComponent });
            UserInfoComponent userInfoComponent = d2GGet.Component as UserInfoComponent;

            DBUnionInfo dBUnionInfo = null;
            scene.GetComponent<UnionSceneComponent>().UnionList.TryGetValue(request.UnionId, out dBUnionInfo);
            if (dBUnionInfo == null)
            {
                reply();
                return;
            }
            bool have = false;
            for (int i = dBUnionInfo.UnionInfo.UnionPlayerList.Count -1; i >= 0; i--)
            {
                if (dBUnionInfo.UnionInfo.UnionPlayerList[i].UserID == request.UserId)
                {
                    have = true;
                    dBUnionInfo.UnionInfo.UnionPlayerList.RemoveAt(i);
                }
            }
            if (!have)
            {
                reply();
                return;
            }

            //通知玩家
            long gateServerId = DBHelper.GetGateServerId(scene.DomainZone());
            G2T_GateUnitInfoResponse g2M_UpdateUnitResponse = (G2T_GateUnitInfoResponse)await ActorMessageSenderComponent.Instance.Call
               (gateServerId, new T2G_GateUnitInfoRequest()
               {
                   UserID = request.UserId
               });
            if (g2M_UpdateUnitResponse.PlayerState == (int)PlayerState.Game && g2M_UpdateUnitResponse.SessionInstanceId > 0)
            {
                U2M_UnionKickOutRequest r2M_RechargeRequest = new U2M_UnionKickOutRequest() { UserId = request.UserId };
                M2U_UnionKickOutResponse m2G_RechargeResponse = (M2U_UnionKickOutResponse)await ActorLocationSenderComponent.Instance.Call(request.UserId, r2M_RechargeRequest);
            }
            else
            {
                userInfoComponent.UserInfo.UnionId = 0;
                D2M_SaveComponent d2GSave = (D2M_SaveComponent)await ActorMessageSenderComponent.Instance.Call(dbCacheId, new M2D_SaveComponent() { UnitId = request.UserId, EntityByte = MongoHelper.ToBson(userInfoComponent), ComponentType = DBHelper.UserInfoComponent });
            }
            reply();
        }
    }
}
