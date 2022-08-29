using System;

namespace ET
{

    [ActorMessageHandler]
    public class C2F_WatchPlayerHandler : AMActorRpcHandler<Scene, C2F_WatchPlayerRequest, F2C_WatchPlayerResponse>
    {
        protected override async ETTask Run(Scene scene, C2F_WatchPlayerRequest request, F2C_WatchPlayerResponse response, Action reply)
        {
            long dbCacheId = StartSceneConfigCategory.Instance.GetBySceneName(scene.DomainZone(), Enum.GetName(SceneType.DBCache)).InstanceId;
            D2G_GetComponent d2GGetUnit_1 = (D2G_GetComponent)await ActorMessageSenderComponent.Instance.Call(dbCacheId, new G2D_GetComponent() { CharacterId = request.UserId, Component = DBHelper.UserInfoComponent });
            D2G_GetComponent d2GGetUnit_2 = (D2G_GetComponent)await ActorMessageSenderComponent.Instance.Call(dbCacheId, new G2D_GetComponent() { CharacterId = request.UserId, Component = DBHelper.BagComponent });

            UserInfoComponent userinfo = d2GGetUnit_1.Component as UserInfoComponent;

            //根据类型返回不同的值
            switch (request.WatchType) {

                //全部
                case 0:
                    response.Lv = userinfo.UserInfo.Lv;
                    response.Name = userinfo.UserInfo.Name;
                    BagComponent bagComponents = d2GGetUnit_2.Component as BagComponent;
                    response.EquipList = bagComponents.EquipList;
                    response.Occ = userinfo.UserInfo.Occ;
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
            }

            reply();
        }
    }
}
