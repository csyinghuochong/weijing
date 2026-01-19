using System;
using System.Collections.Generic;

namespace ET
{
    [MessageHandler]
    public class C2Center_HotUpdatecompleteHandler : AMRpcHandler<C2Center_HotUpdatecompleteRequest, Center2C_HotUpdatecompleteResponse>
    {
        protected override async ETTask Run(Session session, C2Center_HotUpdatecompleteRequest request, Center2C_HotUpdatecompleteResponse response, Action reply)
        {
            List<DBCenterDataCache> centerDataCaches = await Game.Scene.GetComponent<DBComponent>().Query<DBCenterDataCache>(session.DomainZone(), d => d.anid == request.OAID);
            if (centerDataCaches != null && centerDataCaches.Count > 0 && string.IsNullOrEmpty(centerDataCaches[0].HotUpdatecomplte))
            {
                Console.WriteLine($"hotUpdatecompleteRequest: {request.OAID}");
                DBCenterDataCache dBCenterDataCache = centerDataCaches[0];
                dBCenterDataCache.HotUpdatecomplte = TimeInfo.Instance.ToDateTime(request.Time).ToString();
                await Game.Scene.GetComponent<DBComponent>().Save(202, dBCenterDataCache);
            }

            reply();
            await ETTask.CompletedTask;
        }
    }
}