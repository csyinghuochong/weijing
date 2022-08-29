using System;


namespace ET
{

    [ActorMessageHandler]
    public class C2F_FriendApplyReplyHandler : AMActorRpcHandler<Scene, C2F_FriendApplyReplyRequest, F2C_FriendApplyReplyResponse>
    {
        protected override async ETTask Run(Scene scene, C2F_FriendApplyReplyRequest request, F2C_FriendApplyReplyResponse response, Action reply)
        {
            long dbCacheId = StartSceneConfigCategory.Instance.GetBySceneName(scene.DomainZone(), Enum.GetName(SceneType.DBCache)).InstanceId;
            D2G_GetComponent d2GGetUnit = (D2G_GetComponent)await ActorMessageSenderComponent.Instance.Call(dbCacheId, new G2D_GetComponent() { CharacterId = request.UserID, Component = DBHelper.DBFriendInfo });

            DBFriendInfo dBFriendInfo = d2GGetUnit.Component as DBFriendInfo;
            dBFriendInfo.ApplyList.Remove(request.FriendID);

            if (request.ReplyCode == 1) //同意
            {
                dBFriendInfo.FriendList.Add(request.FriendID);

                //对方也同样标记
                d2GGetUnit = (D2G_GetComponent)await ActorMessageSenderComponent.Instance.Call(dbCacheId, new G2D_GetComponent() { CharacterId = request.FriendID, Component = DBHelper.DBFriendInfo });
                DBFriendInfo dBFriendInfo_2 = d2GGetUnit.Component as DBFriendInfo;
                dBFriendInfo_2.FriendList.Add(request.UserID);
                D2M_SaveComponent d2GSave_2 = (D2M_SaveComponent)await ActorMessageSenderComponent.Instance.Call(dbCacheId, new M2D_SaveComponent() { CharacterId = request.FriendID, Component = dBFriendInfo_2, ComponentType = DBHelper.DBFriendInfo });
            }
            
            D2M_SaveComponent d2GSave = (D2M_SaveComponent)await ActorMessageSenderComponent.Instance.Call(dbCacheId, new M2D_SaveComponent() { CharacterId = request.UserID, Component = dBFriendInfo, ComponentType = DBHelper.DBFriendInfo });
            reply();
        }
    }
}
