using System;


namespace ET
{

    [MessageHandler]
    public class M2C_KickPlayerHandler : AMHandler<M2C_KickPlayerMessage>
    {
        protected override void Run(Session session, M2C_KickPlayerMessage message)
        {
            session.GetComponent<PingComponent>().DisconnectType = 1;
            session.Dispose();
        }
    }
}
