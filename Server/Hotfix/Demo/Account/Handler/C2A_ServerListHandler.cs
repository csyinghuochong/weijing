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
            //long dbCacheId = DBHelper.GetCenterServerId();
            //Center2A_CenterServerList d2GGetUnit = (Center2A_CenterServerList)await ActorMessageSenderComponent.Instance.Call(dbCacheId, new A2Center_CenterServerList() {  });
            //long serverTime = TimeHelper.ServerNow();
            //List<ServerItem> serverItems_2 = d2GGetUnit.ServerItems;
            //for (int i = 0; i < serverItems_2.Count; i++)
            //{
            //    if (serverItems_2[i].ServerOpenTime > serverTime)
            //    {
            //        continue;
            //    }
            //    serverItems_1.Add(serverItems_2[i]);
            //}
            List<ServerItem> serverItems_1 = new List<ServerItem>();
            if (ComHelp.IsInnerNet())
            {
                if (ComHelp.IsBanHaoZone(session.DomainZone()))
                {
                    serverItems_1.Add(new ServerItem() { ServerId = 201, ServerIp = "127.0.0.1:20105", ServerName = "封测1区", ServerOpenTime = 0 });
                }
                else
                {
                    serverItems_1.Add(new ServerItem() { ServerId = 1, ServerIp = "127.0.0.1:20305", ServerName = "封测一区", ServerOpenTime = 0 });
                    serverItems_1.Add(new ServerItem() { ServerId = 2, ServerIp = "127.0.0.1:20315", ServerName = "封测二区", ServerOpenTime = 0 });
                }
            }
            else
            {
                if (ComHelp.IsBanHaoZone(session.DomainZone()))
                {
                    serverItems_1.Add(new ServerItem() { ServerId = 201, ServerIp = "39.96.194.143:20105", ServerName = "封测1区", ServerOpenTime = 0 });
                }
                else
                {
                    serverItems_1.Add(new ServerItem() { ServerId = 1, ServerIp = "39.96.194.143:20305", ServerName = "封测一区", ServerOpenTime = 0 });
                    serverItems_1.Add(new ServerItem() { ServerId = 2, ServerIp = "39.96.194.143:20315", ServerName = "封测二区", ServerOpenTime = 0 });
                }
            }

            response.ServerItems = serverItems_1;
            reply();
            await ETTask.CompletedTask;
        }
    }
}
