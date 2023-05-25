using System;

namespace ET
{
    [MessageHandler]
    public class M2C_SoloMatchHandler : AMHandler<M2C_SoloMatchResult>
    {
        protected override void Run(Session session, M2C_SoloMatchResult message)
        {
            //发送消息,服务器接受消息
            EnterFubenHelp.RequestTransfer( session.ZoneScene(), SceneTypeEnum.Solo, 7000001).Coroutine();
        }
    }
}
