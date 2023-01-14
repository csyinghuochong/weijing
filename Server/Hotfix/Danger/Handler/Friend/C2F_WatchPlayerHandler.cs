using System;

namespace ET
{

    [ActorMessageHandler]
    public class C2F_WatchPlayerHandler : AMActorRpcHandler<Scene, C2F_WatchPlayerRequest, F2C_WatchPlayerResponse>
    {
        protected override async ETTask Run(Scene scene, C2F_WatchPlayerRequest request, F2C_WatchPlayerResponse response, Action reply)
        {
            long dbCacheId = StartSceneConfigCategory.Instance.GetBySceneName(scene.DomainZone(), Enum.GetName(SceneType.DBCache)).InstanceId;
            D2G_GetComponent d2GGetUnit_1 = (D2G_GetComponent)await ActorMessageSenderComponent.Instance.Call(dbCacheId, new G2D_GetComponent() { UnitId = request.UserId, Component = DBHelper.UserInfoComponent });
            UserInfoComponent userinfo = d2GGetUnit_1.Component as UserInfoComponent;
            if (userinfo == null)
            {
                response.Error = ErrorCore.ERR_Error;
                reply();
                return;
            }
            //根据类型返回不同的值
            switch (request.WatchType) 
            {
                //全部
                case 0:
                    D2G_GetComponent d2GGetUnit_2 = (D2G_GetComponent)await ActorMessageSenderComponent.Instance.Call(dbCacheId, new G2D_GetComponent() { UnitId = request.UserId, Component = DBHelper.BagComponent });
                    response.Lv = userinfo.UserInfo.Lv;
                    response.Name = userinfo.UserInfo.Name;
                    BagComponent bagComponents = d2GGetUnit_2.Component as BagComponent;
                    response.EquipList = bagComponents.EquipList;
                    response.PetHeXinList = bagComponents.PetHeXinList;
                    response.Occ = userinfo.UserInfo.Occ;
                    D2G_GetComponent d2GGetUnit_3 = (D2G_GetComponent)await ActorMessageSenderComponent.Instance.Call(dbCacheId, new G2D_GetComponent() { UnitId = request.UserId, Component = DBHelper.PetComponent });
                    PetComponent petComponent = d2GGetUnit_3.Component as PetComponent;
                    response.RolePetInfos = petComponent.RolePetInfos;
                    response.PetSkinList = petComponent.PetSkinList;
                    break;
                //只返回名字
                case 1:
                    response.Name = userinfo.UserInfo.Name;
                    break;
                case 2:
                    long teamServerId = StartSceneConfigCategory.Instance.GetBySceneName(scene.DomainZone(), Enum.GetName(SceneType.Team)).InstanceId;
                    T2C_GetTeamInfoResponse g_SendChatRequest1 = (T2C_GetTeamInfoResponse)await ActorMessageSenderComponent.Instance.Call
                        (teamServerId, new C2T_GetTeamInfoRequest() { UserID = request.UserId });

                    response.TeamId = g_SendChatRequest1.TeamInfo != null ? g_SendChatRequest1.TeamInfo.TeamId : 0;
                    break;
                default:
                    break;
            }
            reply();
        }
    }
}
