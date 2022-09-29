using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public static class DisconnectHelper
    {
        public static async ETTask Disconnect(this Session self)
        {
            if (self == null || self.IsDisposed)
            {
                return;
            }

            long instanceId = self.InstanceId;

            await TimerComponent.Instance.WaitAsync(1000);

            if (self.InstanceId != instanceId)
            {
                return;
            }
            self.Dispose();

        }

        public static async ETTask KickPlayer(Player player, bool isException = false)
        {
            if (player == null || player.IsDisposed)
            {
                return;
            }
            long instanceId = player.InstanceId;
            using (await CoroutineLockComponent.Instance.Wait(CoroutineLockType.LoginGate, player.AccountId.GetHashCode()))
            {
                if (player.IsDisposed || instanceId != player.InstanceId)
                {
                    return;
                }
                Log.Info($"KickPlayerBegin playerId: {player.Id} unitId:{player.UnitId}: {isException}");

                if (!isException)   //异常下线不会走正常下线的流程。
                {
                    switch (player.PlayerState)
                    {
                        case PlayerState.Disconnect:
                            break;
                        case PlayerState.Gate:
                            break;
                        case PlayerState.Game:
                            //通知游戏逻辑服下线Unit角色逻辑，并将数据存入数据库
                            var m2GRequestExitGame = (M2G_RequestExitGame)await MessageHelper.CallLocationActor(player.UnitId, new G2M_RequestExitGame());

                            //通知移除账号角色登录信息
                            long LoginCenterConfigSceneId = StartSceneConfigCategory.Instance.LoginCenterConfig.InstanceId;
                            var L2G_RemoveLoginRecord = (L2G_RemoveLoginRecord)await MessageHelper.CallActor(LoginCenterConfigSceneId, new G2L_RemoveLoginRecord()
                            {
                                AccountId = player.AccountId,
                                ServerId = player.DomainZone()
                            });
                            break;
                    }
                }

                //通知排队服
                long queueSceneId = DBHelper.GetQueueServerId(player.DomainZone());
                var q2G_ExitGame = (Q2G_ExitGame)await MessageHelper.CallActor(queueSceneId, new G2Q_ExitGame()
                {
                    AccountId = player.AccountId,
                });

                //通知账号服
                long accountSceneId = DBHelper.GetAccountServerId(player.DomainZone());
                var a2G_ExitGame = (A2G_ExitGame)await MessageHelper.CallActor(accountSceneId, new G2A_ExitGame()
                {
                    AccountId = player.AccountId,
                });

                player.PlayerState = PlayerState.Disconnect;
                player.DomainScene().GetComponent<PlayerComponent>()?.Remove(player.AccountId);
                player?.Dispose();
                Log.Info($"KickPlayerEnd playerId: {player.Id} unitId:{player.UnitId}: {isException}");
                await TimerComponent.Instance.WaitAsync(300);
            }
        }

    }
}
