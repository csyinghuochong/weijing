using System;
using System.Collections.Generic;


namespace ET
{
    public static class FriendHelper
    {

        public static async ETTask<List<FriendInfo>> GetFriendInfos(long dbCacheId, long gateServerId,  List<long> friends)
        {
            List<FriendInfo> friendInfos = new List < FriendInfo >();
            for (int i = 0; i < friends.Count; i++)
            {
                long friendId = friends[i];
                D2G_GetComponent d2GGetUnit = (D2G_GetComponent)await ActorMessageSenderComponent.Instance.Call(dbCacheId, new G2D_GetComponent() { UnitId = friendId, Component = DBHelper.UserInfoComponent });
                UserInfoComponent userInfoComponent = d2GGetUnit.Component as UserInfoComponent;

                G2T_GateUnitInfoResponse g2M_UpdateUnitResponse = (G2T_GateUnitInfoResponse)await ActorMessageSenderComponent.Instance.Call
                   (gateServerId, new T2G_GateUnitInfoRequest()
                   {
                       UserID = friendId
                   });

                friendInfos.Add(new FriendInfo()
                {
                    UserId = friendId,
                    PlayerLevel = userInfoComponent.UserInfo.Lv,
                    OnLineTime = g2M_UpdateUnitResponse.PlayerState == (int)PlayerState.Game ? 1 : 0,
                    PlayerName = userInfoComponent.UserInfo.Name,
                    Occ = userInfoComponent.UserInfo.Occ
                });
            }

            return friendInfos;
        }
    }
}
