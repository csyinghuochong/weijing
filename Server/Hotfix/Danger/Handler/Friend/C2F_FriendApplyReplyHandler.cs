using System;


namespace ET
{

    [ActorMessageHandler]
    public class C2F_FriendApplyReplyHandler : AMActorRpcHandler<Scene, C2F_FriendApplyReplyRequest, F2C_FriendApplyReplyResponse>
    {
        protected override async ETTask Run(Scene scene, C2F_FriendApplyReplyRequest request, F2C_FriendApplyReplyResponse response, Action reply)
        {
            long dbCacheId = StartSceneConfigCategory.Instance.GetBySceneName(scene.DomainZone(), Enum.GetName(SceneType.DBCache)).InstanceId;
            D2G_GetComponent d2GGetUnit = (D2G_GetComponent)await ActorMessageSenderComponent.Instance.Call(dbCacheId, new G2D_GetComponent() { UnitId = request.UserID, Component = DBHelper.DBFriendInfo });

            DBFriendInfo dBFriendInfo = d2GGetUnit.Component as DBFriendInfo;
            dBFriendInfo.ApplyList.Remove(request.FriendID);

            if (request.ReplyCode == 1) //同意
            {
                if (!dBFriendInfo.FriendList.Contains(request.FriendID))
                {
                    dBFriendInfo.FriendList.Add(request.FriendID);
                }

                //对方也同样标记
                d2GGetUnit = (D2G_GetComponent)await ActorMessageSenderComponent.Instance.Call(dbCacheId, new G2D_GetComponent() { UnitId = request.FriendID, Component = DBHelper.DBFriendInfo });
                DBFriendInfo dBFriendInfo_2 = d2GGetUnit.Component as DBFriendInfo;
                if (!dBFriendInfo_2.FriendList.Contains(request.UserID))
                {
                    dBFriendInfo_2.FriendList.Add(request.UserID);
                }
                D2M_SaveComponent d2GSave_2 = (D2M_SaveComponent)await ActorMessageSenderComponent.Instance.Call(dbCacheId, new M2D_SaveComponent() { UnitId = request.FriendID, EntityByte = MongoHelper.ToBson(dBFriendInfo_2), ComponentType = DBHelper.DBFriendInfo });
            }
            
            D2M_SaveComponent d2GSave = (D2M_SaveComponent)await ActorMessageSenderComponent.Instance.Call(dbCacheId, new M2D_SaveComponent() { UnitId = request.UserID, EntityByte = MongoHelper.ToBson(dBFriendInfo), ComponentType = DBHelper.DBFriendInfo });
            reply();
        }
    }
}
