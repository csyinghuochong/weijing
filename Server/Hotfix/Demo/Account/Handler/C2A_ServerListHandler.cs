using System;
using System.Collections.Generic;

namespace ET
{
    //游戏服务器处理
    [MessageHandler]
    class C2A_ServerListHandler : AMRpcHandler<C2A_ServerList, A2C_ServerList>
    {
        protected override async ETTask Run(Session session, C2A_ServerList request, A2C_ServerList response, Action reply)
        {
            long dbCacheId = DBHelper.GetCenterServerId();
            Center2A_CenterServerList d2GGetUnit = (Center2A_CenterServerList)await ActorMessageSenderComponent.Instance.Call(dbCacheId, new A2Center_CenterServerList() {  });

            long serverTime = TimeHelper.ServerNow();
            List<ServerItem> serverItems_1 = new List<ServerItem>();
            List<ServerItem> serverItems_2 = d2GGetUnit.ServerItems;
            for (int i = 0; i < serverItems_2.Count; i++)
            {
                if (serverItems_2[i].ServerOpenTime > serverTime)
                {
                    continue;
                }
                serverItems_1.Add(serverItems_2[i]);
            }
            response.ServerItems = serverItems_1;
            reply();
            await ETTask.CompletedTask;
        }
    }
}
