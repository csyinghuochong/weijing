using System;

namespace ET
{
    [ActorMessageHandler]
    public class C2F_FriendBlacklistHandler : AMActorRpcHandler<Scene, C2F_FriendBlacklistRequest, F2C_FriendBlacklistResponse>
    {
        protected override async ETTask Run(Scene scene, C2F_FriendBlacklistRequest request, F2C_FriendBlacklistResponse response, Action reply)
        {
            long dbCacheId = StartSceneConfigCategory.Instance.GetBySceneName(scene.DomainZone(), Enum.GetName(SceneType.DBCache)).InstanceId;
            D2G_GetComponent d2GGetUnit = (D2G_GetComponent)await ActorMessageSenderComponent.Instance.Call(dbCacheId, new G2D_GetComponent() { UnitId = request.UserID, Component = DBHelper.DBFriendInfo });
            DBFriendInfo dBFriendInfo = d2GGetUnit.Component as DBFriendInfo;
            
            if (dBFriendInfo.FriendList.Contains(request.FriendId))
            {
                //在好友列表
                reply();
                return;
            }

            if (request.OperateType == 1)
            {
                if (dBFriendInfo.Blacklist.Contains(request.FriendId))
                {
                    reply();
                    return;
                }
                dBFriendInfo.Blacklist.Add(request.FriendId);
            }
            if (request.OperateType == 2)
            {
                if (!dBFriendInfo.Blacklist.Contains(request.FriendId))
                {
                    reply();
                    return;
                }
                dBFriendInfo.Blacklist.Remove(request.FriendId);
            }
            D2M_SaveComponent d2GSave = (D2M_SaveComponent)await ActorMessageSenderComponent.Instance.Call(dbCacheId, new M2D_SaveComponent() { UnitId = request.UserID, EntityByte = MongoHelper.ToBson(dBFriendInfo), ComponentType = DBHelper.DBFriendInfo });
            reply();
        }
    }
}
