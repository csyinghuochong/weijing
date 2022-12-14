using System;

namespace ET
{
    [ActorMessageHandler]
    public class C2U_UnionMyInfoHandler : AMActorRpcHandler<Scene, C2U_UnionMyInfoRequest, U2C_UnionMyInfoResponse>
    {

        protected override async ETTask Run(Scene scene, C2U_UnionMyInfoRequest request, U2C_UnionMyInfoResponse response, Action reply)
        {
            long dbCacheId = DBHelper.GetDbCacheId(scene.DomainZone());
            DBUnionInfo dBUnionInfo =await scene.GetComponent<UnionSceneComponent>().GetDBUnionInfo(request.UnionId);

            long gateServerId = DBHelper.GetGateServerId(scene.DomainZone());
            for (int i = 0; i < dBUnionInfo.UnionInfo.UnionPlayerList.Count; i++)
            {
                UnionPlayerInfo unionPlayerInfo = dBUnionInfo.UnionInfo.UnionPlayerList[i];
                long userId = unionPlayerInfo.UserID;

                D2G_GetComponent  d2GSave = (D2G_GetComponent)await ActorMessageSenderComponent.Instance.Call(dbCacheId, new G2D_GetComponent() { UnitId = userId, Component = DBHelper.UserInfoComponent });
                UserInfoComponent userInfoComponent = d2GSave.Component as UserInfoComponent;
                unionPlayerInfo.PlayerLevel = userInfoComponent.UserInfo.Lv;
                unionPlayerInfo.PlayerName = userInfoComponent.UserInfo.Name;
                unionPlayerInfo.Combat = userInfoComponent.UserInfo.Combat;

                G2T_GateUnitInfoResponse g2M_UpdateUnitResponse = (G2T_GateUnitInfoResponse)await ActorMessageSenderComponent.Instance.Call
                    (gateServerId, new T2G_GateUnitInfoRequest()
                    {
                        UserID = userId
                    });
                if (g2M_UpdateUnitResponse.PlayerState == (int)PlayerState.Game && g2M_UpdateUnitResponse.SessionInstanceId > 0)
                {
                    response.OnLinePlayer.Add(userId);
                }
                if (dBUnionInfo.UnionInfo.LeaderId == userId)
                {
                    dBUnionInfo.UnionInfo.LeaderName = userInfoComponent.UserInfo.Name;
                }
            }
            response.UnionMyInfo = dBUnionInfo.UnionInfo;
            reply();
        }
    }
}
