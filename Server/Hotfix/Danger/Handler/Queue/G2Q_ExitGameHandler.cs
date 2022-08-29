using System;

namespace ET
{
    public class G2Q_ExitGameHandler : AMActorRpcHandler<Scene, G2Q_ExitGame, Q2G_ExitGame>
    {
        protected override async ETTask Run(Scene scene, G2Q_ExitGame request, Q2G_ExitGame response, Action reply)
        {
            //通知队列第一个玩家进入
            long accountId = scene.GetComponent<QueueSessionsComponent>().GetFirst();
            if (accountId > 0)
            {
                long sessionInstanceid = scene.GetComponent<QueueSessionsComponent>().Get(accountId);
                Session otherSession = Game.EventSystem.Get(sessionInstanceid) as Session;
                Q2C_EnterGame q2C_EnterGame = new Q2C_EnterGame()
                {
                    Error = ErrorCore.ERR_Success,
                    Token = scene.GetComponent<QueueSessionsComponent>().GetToken(accountId)
                };
                otherSession?.Send(q2C_EnterGame) ;                 
                otherSession?.Disconnect().Coroutine();
                scene.GetComponent<QueueSessionsComponent>().Remove(accountId);
            }
            reply();
            await ETTask.CompletedTask;
        }
    }
}
