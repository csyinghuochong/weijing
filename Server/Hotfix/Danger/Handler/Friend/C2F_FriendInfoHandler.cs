using System;

namespace ET
{

    [ActorMessageHandler]
    public  class C2F_FriendInfoHandler : AMActorRpcHandler<Scene, C2F_FriendInfoRequest, F2C_FriendInfoResponse>
    {
        protected override async ETTask Run(Scene scene, C2F_FriendInfoRequest request, F2C_FriendInfoResponse response, Action reply)
        {
            long dbCacheId = StartSceneConfigCategory.Instance.GetBySceneName(scene.DomainZone(), Enum.GetName(SceneType.DBCache)).InstanceId;
            D2G_GetComponent d2GGetUnit = (D2G_GetComponent)await ActorMessageSenderComponent.Instance.Call(dbCacheId, new G2D_GetComponent() { CharacterId = request.UserID, Component = DBHelper.DBFriendInfo });
            DBFriendInfo dBFriendInfo = d2GGetUnit.Component as DBFriendInfo;
          
            long gateServerId = StartSceneConfigCategory.Instance.GetBySceneName(scene.DomainZone(), "Gate1").InstanceId;
            response.FriendList = await FriendHelper.GetFriendInfos(dbCacheId, gateServerId, dBFriendInfo.FriendList);
            response.ApplyList = await FriendHelper.GetFriendInfos(dbCacheId, gateServerId, dBFriendInfo.ApplyList);
            response.Blacklist = await FriendHelper.GetFriendInfos(dbCacheId, gateServerId, dBFriendInfo.Blacklist);
            
            reply();
        }
    }
}
