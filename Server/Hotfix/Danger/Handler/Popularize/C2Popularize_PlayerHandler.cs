using System;
using System.Collections.Generic;

namespace ET
{

    [ActorMessageHandler]
    public class C2Popularize_PlayerHandler : AMActorRpcHandler<Scene, C2Popularize_PlayerRequest, Popularize2C_PlayerResponse>
    {
        protected override async ETTask Run(Scene scene, C2Popularize_PlayerRequest request, Popularize2C_PlayerResponse response, Action reply)
        {
            DBPopularizeInfo dBPopularizeInfo = await DBHelper.GetComponentCache<DBPopularizeInfo>(scene.DomainZone(), request.ActorId);
            if (dBPopularizeInfo == null)
            {
                reply();
                return;
            }
            UserInfoComponent userInfoComponent = await DBHelper.GetComponentCache<UserInfoComponent>(scene.DomainZone(), request.ActorId);
            if (userInfoComponent == null)
            {
                reply();
                return;
            }

            int oldzone = (int)request.PopularizeId / 1000000;
            int xuhao   = (int)request.PopularizeId % 1000000;
            int newzone = ServerHelper.GetNewServerId(false, oldzone);

            if (newzone == 0)
            {
                reply();
                return;
            }
            List<DBPopularizeInfo> dBPopularizeInfoList = await Game.Scene.GetComponent<DBComponent>().Query<DBPopularizeInfo>(newzone, d => d.PopularizeCode == request.PopularizeId);
            if (dBPopularizeInfoList.Count == 0)
            {
                response.Error = ErrorCore.ERR_PopularizeNot;
                reply();
                return;
            }

            long puserid =  dBPopularizeInfoList[0].Id;
            UserInfoComponent userInfoComponent_2 = await DBHelper.GetComponentCache<UserInfoComponent>(newzone, puserid);
            if (userInfoComponent_2 == null)
            {
                reply();
                return;
            }
            if (userInfoComponent.UserInfo.AccInfoID == userInfoComponent_2.UserInfo.AccInfoID)
            {
                response.Error = ErrorCore.ERR_PopularizeThe;
                reply();
                return;
            }

            if (dBPopularizeInfoList[0].MyPopularizeList.Count >= 100)
            {
                response.Error = ErrorCore.ERR_PopularizeMax;
                reply();
                return;
            }

            dBPopularizeInfoList[0].MyPopularizeList.Add( new PopularizeInfo() { UnitId = request.ActorId } );
            await DBHelper.SaveComponent(newzone, dBPopularizeInfoList[0].Id, dBPopularizeInfoList[0]);

            dBPopularizeInfo.BePopularizeId = request.PopularizeId;
            await DBHelper.SaveComponent(newzone, dBPopularizeInfo.Id, dBPopularizeInfo);

            reply();
        }
    }
}
