using System;

namespace ET
{
    public class L2G_DisconnectGateUnitHandler : AMActorRpcHandler<Scene, L2G_DisconnectGateUnit, G2L_DisconnectGateUnit>
    {
        protected override async ETTask Run(Scene scene, L2G_DisconnectGateUnit request, G2L_DisconnectGateUnit response, Action reply)
        {
            try
            {
                long accountId = request.AccountId;

                using (await CoroutineLockComponent.Instance.Wait(CoroutineLockType.LoginGate, accountId.GetHashCode()))
                {
                    PlayerComponent playerComponent = scene.GetComponent<PlayerComponent>();
                    Player player = playerComponent.Get(accountId);
                    if (player == null)
                    {
                        reply();
                        return;
                    }

                    scene.GetComponent<GateSessionKeyComponent>().Remove(accountId);
                    Session gateSession = player.ClientSession;
                    if (gateSession != null && !gateSession.IsDisposed)
                    {
                        Log.Info($"ErrorCode.ERR_OtherAccountLogin2 {accountId}");
                        gateSession.GetComponent<SessionPlayerComponent>().isLoginAgain = true;
                        gateSession.Send(new A2C_Disconnect() { Error = ErrorCode.ERR_OtherAccountLogin });
                        gateSession?.Disconnect().Coroutine(); 
                    }
                    if (request.Relink)
                    {
                        player.RemoveComponent<PlayerOfflineOutTimeComponent>();
                        player.AddComponent<PlayerOfflineOutTimeComponent>();  
                    }
                    else
                    {
                        DisconnectHelper.KickPlayer(player).Coroutine();
                    }
                    player.ClientSession = null;
                }
                reply();
            }
            catch (Exception e) 
            {
                Log.Error(e.ToString());
            }
        }
    }
}