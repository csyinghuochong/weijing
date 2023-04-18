using System;

namespace ET
{

    [ActorMessageHandler]
    public class M2U_UnionCreateHandler : AMActorRpcHandler<Scene, M2U_UnionCreateRequest, U2M_UnionCreateResponse>
    {
        protected override async ETTask Run(Scene scene, M2U_UnionCreateRequest request, U2M_UnionCreateResponse response, Action reply)
        {
            if (scene.GetComponent<UnionSceneComponent>().IsSameNameUnion(request.UnionName))
            {
                response.Error = ErrorCore.ERR_Union_Same_Name;
                reply();
                return;
            }

            long dbCacheId = DBHelper.GetDbCacheId(scene.DomainZone());
            long unionId = IdGenerater.Instance.GenerateId();
            DBUnionInfo unionInfo = new DBUnionInfo();
            unionInfo.Id = unionId;
            unionInfo.UnionInfo.UnionId = unionId;
            unionInfo.UnionInfo.LeaderId = request.UserID;       
            unionInfo.UnionInfo.UnionName = request.UnionName;
            unionInfo.UnionInfo.UnionPurpose = request.UnionPurpose;

            D2G_GetComponent d2G_GetComponent = (D2G_GetComponent)await ActorMessageSenderComponent.Instance.Call(dbCacheId, new G2D_GetComponent() { UnitId = request.UserID, Component = DBHelper.UserInfoComponent });
            UserInfoComponent userInfoComponent = d2G_GetComponent.Component as UserInfoComponent;
            unionInfo.UnionInfo.LeaderName = userInfoComponent.UserInfo.Name;
            unionInfo.UnionInfo.UnionPlayerList.Add(new UnionPlayerInfo()
            {
                 PlayerLevel = userInfoComponent.UserInfo.Lv,
                 PlayerName = userInfoComponent.UserInfo.Name,
                 UserID = request.UserID,
            });
            scene.GetComponent<UnionSceneComponent>().UnionList.Add(unionId, unionInfo);
            DBHelper.SaveComponent(scene.DomainZone(), unionId, unionInfo).Coroutine();
            response.UnionId = unionId;
            reply();
            await ETTask.CompletedTask;
        }
    }
}
