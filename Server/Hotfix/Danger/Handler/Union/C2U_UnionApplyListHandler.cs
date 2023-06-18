using System;
using System.Collections.Generic;

namespace ET
{

    [ActorMessageHandler]
    public class C2U_UnionApplyListHandler : AMActorRpcHandler<Scene, C2U_UnionApplyListRequest, U2C_UnionApplyListResponse>
    {

        protected override async ETTask Run(Scene scene, C2U_UnionApplyListRequest request, U2C_UnionApplyListResponse response, Action reply)
        {
            long dbCacheId = DBHelper.GetDbCacheId(scene.DomainZone());
            DBUnionInfo dBUnionInfo =await scene.GetComponent<UnionSceneComponent>().GetDBUnionInfo(request.UnionId);

            List<UnionPlayerInfo> unionPlayers = new List<UnionPlayerInfo>();
            for(int i = dBUnionInfo.UnionInfo.ApplyList.Count - 1; i >= 0; i--)
            {
                //判断玩家是否已经有家族了
                NumericComponent numericComponent_0 = await DBHelper.GetComponentCache<NumericComponent>(scene.DomainZone(), dBUnionInfo.UnionInfo.ApplyList[i]);
                if (numericComponent_0 == null ||  numericComponent_0.GetAsLong(NumericType.UnionId_0) > 0)
                {
                    dBUnionInfo.UnionInfo.ApplyList.RemoveAt(i);
                    continue;
                }

                D2G_GetComponent d2GGetUnit = (D2G_GetComponent)await ActorMessageSenderComponent.Instance.Call(dbCacheId, new G2D_GetComponent() { UnitId = dBUnionInfo.UnionInfo.ApplyList[i], Component = DBHelper.UserInfoComponent });
                UserInfoComponent userInfoComponent = d2GGetUnit.Component as UserInfoComponent;
                unionPlayers.Add( new UnionPlayerInfo() 
                {  
                    PlayerLevel = userInfoComponent.UserInfo.Lv,
                    PlayerName = userInfoComponent.UserInfo.Name,
                    Combat  = userInfoComponent.UserInfo.Combat,
                    UserID = userInfoComponent.UserInfo.UserId,
                    Occ = userInfoComponent.UserInfo.Occ,
                    OccTwo = userInfoComponent.UserInfo.OccTwo, 
                } );
            }

            response.UnionPlayerList = unionPlayers;
            reply();
        }
    }
}
