using System;

namespace ET
{
    [MessageHandler]
    public class C2G_ExitGameGateHandler : AMRpcHandler<C2G_ExitGameGate, G2C_ExitGameGate>
    {
        protected override async ETTask Run(Session session, C2G_ExitGameGate request, G2C_ExitGameGate response, Action reply)
        {
            Log.Warning($"C2G_ExitGameGate  {request.Account}");

            if (request.Account == 0)
            {
                Player player = session.GetComponent<SessionPlayerComponent>().GetMyPlayer();

                if (player != null)
                {
                    Log.Warning($"C2G_ExitGameGate  {player.UnitId} 1111 ");
                    DisconnectHelper.KickPlayer(player).Coroutine();
                }
                else
                {
                    Log.Warning($"C2G_ExitGameGate null");
                }
            }
            else
            {
                long mapInstanceId = DBHelper.GetRankServerId(session.DomainZone());
                
            }
            reply();
            await ETTask.CompletedTask;
        }
    }
}
