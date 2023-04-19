using System;

namespace ET
{

    [ActorMessageHandler]
    public class M2U_UnionLeaveHandler : AMActorRpcHandler<Scene, M2U_UnionLeaveRequest, U2M_UnionLeaveResponse>
    {
        protected override async ETTask Run(Scene scene, M2U_UnionLeaveRequest request, U2M_UnionLeaveResponse response, Action reply)
        {
            DBUnionInfo dBUnionInfo = await scene.GetComponent<UnionSceneComponent>().GetDBUnionInfo(request.UnionId);

            UnionPlayerInfo unionPlayerInfo = null;
            for (int i = dBUnionInfo.UnionInfo.UnionPlayerList.Count - 1; i >= 0; i--)
            {
                if (dBUnionInfo.UnionInfo.UnionPlayerList[i].UserID == request.UserId)
                {
                    unionPlayerInfo = dBUnionInfo.UnionInfo.UnionPlayerList[i];
                    dBUnionInfo.UnionInfo.UnionPlayerList.RemoveAt(i);
                    break;
                }
            }
            if (unionPlayerInfo == null)
            {
                reply();
                return;
            }

            DBHelper.SaveComponent(scene.DomainZone(), request.UnionId, dBUnionInfo).Coroutine();
            if (unionPlayerInfo.UserID == dBUnionInfo.UnionInfo.LeaderId)
            {
                //族长退出解散家族
                long dbCacheId = DBHelper.GetDbCacheId(scene.DomainZone());
                for (int i = dBUnionInfo.UnionInfo.UnionPlayerList.Count - 1; i >= 0; i--)
                {
                    long userId = dBUnionInfo.UnionInfo.UnionPlayerList[i].UserID;

                    //通知玩家
                    long gateServerId = DBHelper.GetGateServerId(scene.DomainZone());
                    G2T_GateUnitInfoResponse g2M_UpdateUnitResponse = (G2T_GateUnitInfoResponse)await ActorMessageSenderComponent.Instance.Call
                       (gateServerId, new T2G_GateUnitInfoRequest()
                       {
                           UserID = userId
                       });
                    if (g2M_UpdateUnitResponse.PlayerState == (int)PlayerState.Game && g2M_UpdateUnitResponse.SessionInstanceId > 0)
                    {
                        U2M_UnionKickOutRequest r2M_RechargeRequest = new U2M_UnionKickOutRequest() { UserId = userId };
                        M2U_UnionKickOutResponse m2G_RechargeResponse = (M2U_UnionKickOutResponse)await ActorLocationSenderComponent.Instance.Call(userId, r2M_RechargeRequest);
                    }
                    else
                    {
                        D2G_GetComponent d2GGet = (D2G_GetComponent)await ActorMessageSenderComponent.Instance.Call(dbCacheId, new G2D_GetComponent() { UnitId = userId, Component = DBHelper.NumericComponent });
                        NumericComponent numericComponent = d2GGet.Component as NumericComponent;
                        numericComponent.Set(NumericType.UnionId_0, 0, false);
                        D2M_SaveComponent d2GSave = (D2M_SaveComponent)await ActorMessageSenderComponent.Instance.Call(dbCacheId, new M2D_SaveComponent() { UnitId = userId, EntityByte = MongoHelper.ToBson(numericComponent), ComponentType = DBHelper.NumericComponent });
                    }
                }
                //族长退出再另选族长。
                //unionInfo.UnionInfo.UnionPlayerList.Sort(delegate (UnionPlayerInfo a, UnionPlayerInfo b )
                //{
                //    return a.Combat - b.Combat;
                //});
                //UnionPlayerInfo unionNewInfo = unionInfo.UnionInfo.UnionPlayerList[0];
                //unionInfo.UnionInfo.LeaderId = unionNewInfo.UserID;

                //long dbCacheId = DBHelper.GetDbCacheId(scene.DomainZone());
                //D2G_GetComponent d2G_GetComponent = (D2G_GetComponent)await ActorMessageSenderComponent.Instance.Call(dbCacheId, new G2D_GetComponent() { CharacterId = unionNewInfo.UserID, Component = DBHelper.UserInfoComponent });
                //UserInfoComponent userInfoComponent = d2G_GetComponent.Component as UserInfoComponent;
                //unionInfo.UnionInfo.LeaderName = userInfoComponent.UserInfo.Name;

            }
            reply();
            await ETTask.CompletedTask;
        }
    }
}
