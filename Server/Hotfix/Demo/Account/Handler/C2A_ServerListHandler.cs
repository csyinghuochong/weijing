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
            response.ServerItems = ServerHelper.GetServerList(ComHelp.IsInnerNet(), session.DomainZone());
            reply();
            await ETTask.CompletedTask;
        }
    }
}
