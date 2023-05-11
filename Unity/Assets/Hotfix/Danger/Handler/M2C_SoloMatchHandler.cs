using System;

namespace ET
{
    [MessageHandler]
    public class M2C_SoloMatchHandler : AMHandler<M2C_SoloMatchResult>
    {
        protected override void Run(Session session, M2C_SoloMatchResult message)
        {
            EnterFubenHelp.RequestTransfer( session.ZoneScene(), SceneTypeEnum.Solo, 7000001).Coroutine();
        }
    }
}
