using System;


namespace ET
{
    [ActorMessageHandler]
    public class C2F_FriendDeleteHandler : AMActorRpcHandler<Scene, C2F_FriendDeleteRequest, F2C_FriendDeleteResponse>
    {
        protected override async ETTask Run(Scene scene, C2F_FriendDeleteRequest request, F2C_FriendDeleteResponse response, Action reply)
        {
            DBFriendInfo dBFriendInfo = await DBHelper.GetComponentCache<DBFriendInfo>(scene.DomainZone(), request.UserID);
            if (dBFriendInfo == null || !dBFriendInfo.FriendList.Contains(request.FriendID))
            {
               
                reply();
                return;
            }

            dBFriendInfo.FriendList.Remove(request.FriendID);
            DBHelper.SaveComponent(scene.DomainZone(), request.UserID, dBFriendInfo).Coroutine();

            DBFriendInfo dBFriendInfo_2 = await DBHelper.GetComponentCache<DBFriendInfo>(scene.DomainZone(), request.FriendID);
            if (dBFriendInfo_2!=null &&  dBFriendInfo_2.FriendList.Contains(request.UserID))
            {
                dBFriendInfo_2.FriendList.Remove(request.UserID);
                DBHelper.SaveComponent(scene.DomainZone(), request.FriendID, dBFriendInfo_2).Coroutine();
            }

            reply();
            await ETTask.CompletedTask;
        }
    }
}
