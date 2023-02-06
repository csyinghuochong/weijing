using System;

namespace ET
{
    [MessageHandler]
    public class C2G_ExitGameGateHandler : AMRpcHandler<C2G_ExitGameGate, G2C_ExitGameGate>
    {
        protected override async ETTask Run(Session session, C2G_ExitGameGate request, G2C_ExitGameGate response, Action reply)
        {
            if (request.Account == 0)
            {
                Player player = session.GetComponent<SessionPlayerComponent>().GetMyPlayer();

                if (player != null)
                {
                    DisconnectHelper.KickPlayer(player).Coroutine();
                }
            }
            else
            {
                long mapInstanceId = DBHelper.GetRankServerId(session.DomainZone());
                //Uid 1628585061177688064  Aid 1628584562793709626
                var m2GRequestExitGame = (M2G_RequestExitGame)await MessageHelper.CallLocationActor(request.RoleId, new G2M_RequestExitGame());
            }
            reply();
            await ETTask.CompletedTask;
        }
    }
}
