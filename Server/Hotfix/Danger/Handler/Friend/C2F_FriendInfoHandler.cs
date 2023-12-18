using System;

namespace ET
{

    [ActorMessageHandler]
    public  class C2F_FriendInfoHandler : AMActorRpcHandler<Scene, C2F_FriendInfoRequest, F2C_FriendInfoResponse>
    {
        protected override async ETTask Run(Scene scene, C2F_FriendInfoRequest request, F2C_FriendInfoResponse response, Action reply)
        {
            long dbCacheId = DBHelper.GetDbCacheId( scene.DomainZone() );
            DBFriendInfo dBFriendInfo = await DBHelper.GetComponentCache<DBFriendInfo>(scene.DomainZone(), request.UserID);
            if (dBFriendInfo == null)
            {
                Log.Warning($"C2F_FriendInfo==null: {request.UserID}");
                reply();
                return;
            }
            long gateServerId = StartSceneConfigCategory.Instance.GetBySceneName(scene.DomainZone(), "Gate1").InstanceId;
            response.FriendList = await FriendHelper.GetFriendInfos(dbCacheId, gateServerId, dBFriendInfo.FriendList);
            response.ApplyList = await FriendHelper.GetFriendInfos(dbCacheId, gateServerId, dBFriendInfo.ApplyList);
            response.Blacklist = await FriendHelper.GetFriendInfos(dbCacheId, gateServerId, dBFriendInfo.Blacklist);
            response.FriendChats = dBFriendInfo.FriendChats;
            reply();
        }
    }
}
