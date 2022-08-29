using ET;
using System;

namespace ET
{
    //游戏注册账号
    [MessageHandler]
    class C2A_NoticeHandler : AMRpcHandler<C2A_Notice, A2C_Notice>
    {
        protected override async ETTask Run(Session session, C2A_Notice request, A2C_Notice response, Action reply)
        {
            Log.Debug("收到了客户端发来的Call消息,内容是:注册账号request.Account" + request.Message);

            response.Message = "游戏正在制作中,您的意见对我们非常重要!";

            //发送创建回执
            reply();

            await ETTask.CompletedTask;
        }
    }
}
