using ET;
using System;

namespace ET
{
    //游戏注册账号
    [MessageHandler]
    class C2A_ThanksHandler : AMRpcHandler<C2A_Thanks, A2C_Thanks>
    {
        protected override async ETTask Run(Session session, C2A_Thanks request, A2C_Thanks response, Action reply)
        {
            response.Message = "服务器验证通过！这是一个测试的感谢名单";

            //发送创建回执
            reply();
            await ETTask.CompletedTask;
        }
    }
}

