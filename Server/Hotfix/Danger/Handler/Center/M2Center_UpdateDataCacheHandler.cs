
using System;
using System.Collections.Generic;


namespace ET
{
    [ActorMessageHandler]
    public class M2Center_UpdateDataCacheHandler : AMActorRpcHandler<Scene, M2Center_UpdateDataCacheRequest, Center2M_UpdateDataCacheResponse>
    {
        protected override async ETTask Run(Scene scene, M2Center_UpdateDataCacheRequest request, Center2M_UpdateDataCacheResponse response, Action reply)
        {
            List<DBCenterDataCache> centerDataCaches = await Game.Scene.GetComponent<DBComponent>().Query<DBCenterDataCache>(202, d => d.anid == request.OAID);
            if (centerDataCaches != null && centerDataCaches.Count > 0)
            {
                Console.WriteLine($"updatelastgametime DBCenterDataCache:  {request.OAID}");
                DBCenterDataCache dBCenterDataCache = centerDataCaches[0];
                dBCenterDataCache.LastLoginTime = request.Time;
                await Game.Scene.GetComponent<DBComponent>().Save(202, dBCenterDataCache);
            }

            List<DBCenterAccountInfo> centerAccountInfos = await Game.Scene.GetComponent<DBComponent>().Query<DBCenterAccountInfo>(202, d => d.Id == request.AccInfoID);
            if (centerAccountInfos != null && centerAccountInfos.Count > 0)
            {
                DBCenterAccountInfo dBCenterAccount = centerAccountInfos[0];
                dBCenterAccount.IP = request.RemoteAddress;
                await Game.Scene.GetComponent<DBComponent>().Save(202, dBCenterAccount);
            }

            reply();
            await ETTask.CompletedTask;
        }
    }
}
