using System;

namespace ET
{
    [MessageHandler]
    public class C2G_ExitGameGateHandler : AMRpcHandler<C2G_ExitGameGate, G2C_ExitGameGate>
    {
        protected override async ETTask Run(Session session, C2G_ExitGameGate request, G2C_ExitGameGate response, Action reply)
        {
            Player player = session.GetComponent<SessionPlayerComponent>().GetMyPlayer();
            Log.Debug($"C2G_ExitGameGate  {player != null}");
            if (player != null)
            {
                Log.Debug($"C2G_ExitGameGate  {player.UnitId}");
                DisconnectHelper.KickPlayer(player).Coroutine();
            }
            reply();
            await ETTask.CompletedTask;
        }
    }
}
