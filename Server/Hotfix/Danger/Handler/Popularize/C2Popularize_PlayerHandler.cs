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

            int oldzone = (int)request.PopularizeId / 1000000;
            int xuhao   = (int)request.PopularizeId % 1000000;
            int newzone = ServerHelper.GetNewServerId(false, oldzone);

            List<DBPopularizeInfo> dBPopularizeInfoList = await Game.Scene.GetComponent<DBComponent>().Query<DBPopularizeInfo>(newzone, d => d.PopularizeCode == request.PopularizeId);
            if (dBPopularizeInfoList.Count == 0)
            {
                reply();
                return;
            }

            if (dBPopularizeInfoList[0].MyPopularizeList.Count >= 100)
            {
                reply();
                return;
            }

            dBPopularizeInfoList[0].MyPopularizeList.Add( new PopularizeInfo() { UnitId = request.ActorId } );
            await DBHelper.SaveComponent(newzone, dBPopularizeInfoList[0].Id, dBPopularizeInfoList[0]);

            reply();
            await ETTask.CompletedTask;
        }
    }
}
