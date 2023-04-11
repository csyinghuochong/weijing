using System;
using System.Collections.Generic;

namespace ET
{
    //游戏服务器处理
    [MessageHandler]
    public class C2A_ServerListHandler : AMRpcHandler<C2A_ServerList, A2C_ServerList>
    {
        protected override async ETTask Run(Session session, C2A_ServerList request, A2C_ServerList response, Action reply)
        {
            long serverTime = TimeHelper.ServerNow();
            List<ServerItem> serverItems = ServerHelper.GetServerList(ComHelp.IsInnerNet(), session.DomainZone());
            for (int i = serverItems.Count - 1; i >= 0; i--)
            {
                if (serverItems[i].Show == 0  || serverItems[i].ServerOpenTime > serverTime)
                {
                    serverItems.RemoveAt(i);    
                }
            }
            response.ServerItems = serverItems;
            response.Message = session.DomainScene().GetComponent<AccountCenterComponent>().TianQiValue.ToString();
            reply();
            await ETTask.CompletedTask;
        }
    }
}
