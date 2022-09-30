using System;

namespace ET
{
    public class L2G_DisconnectGateUnitHandler : AMActorRpcHandler<Scene, L2G_DisconnectGateUnit, G2L_DisconnectGateUnit>
    {
        protected override async ETTask Run(Scene scene, L2G_DisconnectGateUnit request, G2L_DisconnectGateUnit response, Action reply)
        {
            long accountId = request.AccountId;//登录中心服踢玩家下线

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
                    Log.Info($"ErrorCore.ERR_OtherAccountLogin2 {accountId}");
                    gateSession.GetComponent<SessionPlayerComponent>().isLoginAgain = true;
                    gateSession.Send(new A2C_Disconnect() { Error = ErrorCore.ERR_OtherAccountLogin }); //客户端断线
                    gateSession?.Disconnect().Coroutine();  //释放会调用SessionPlayerComponentDestory
                }
                if (request.Relink)
                {
                    player.RemoveComponent<PlayerOfflineOutTimeComponent>();   
                    player.AddComponent<PlayerOfflineOutTimeComponent>();   //客户端踢下线，30秒之后调用kickplayer? 还是直接kickplayer;
                }
                else
                {
                    DisconnectHelper.KickPlayer(player).Coroutine();
                }
                player.ClientSession = null;
            }
            reply();
        }
    }
}