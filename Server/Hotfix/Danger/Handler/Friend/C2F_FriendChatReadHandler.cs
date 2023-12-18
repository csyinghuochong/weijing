using System;

namespace ET
{
    [ActorMessageHandler]
    public class C2F_FriendChatReadHandler : AMActorRpcHandler<Scene, C2F_FriendChatRead, F2C_FriendChatRead>
    {
        protected override async ETTask Run(Scene scene, C2F_FriendChatRead request, F2C_FriendChatRead response, Action reply)
        {
            DBFriendInfo dBFriendInfo = await DBHelper.GetComponentCache<DBFriendInfo>(scene.DomainZone(), request.UserID);
            if (dBFriendInfo == null)
            {
                Log.Warning($"C2F_FriendInfo==null: {request.UserID}");
                reply();
                return;
            }
            for (int i = dBFriendInfo.FriendChats.Count - 1; i >= 0; i-- )
            {
                if (dBFriendInfo.FriendChats[i].UserId == request.FriendID)
                {
                    dBFriendInfo.FriendChats.RemoveAt(i);   
                }
            }
            DBHelper.SaveComponent(scene.DomainZone(), request.UserID, dBFriendInfo).Coroutine();
            reply();
        }
    }
}
