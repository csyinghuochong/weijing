

namespace ET
{

	public static class SessionPlayerComponentSystem
	{
		public class SessionPlayerComponentAwakeSystem : AwakeSystem<SessionPlayerComponent>
		{
			public override void Awake(SessionPlayerComponent self)
			{
				self.DisconnectType = 0;
				self.AccountId = 0;
				self.PlayerId = 0;
				self.PlayerInstanceId = 0;
			}
		}

		public class SessionPlayerComponentDestroySystem: DestroySystem<SessionPlayerComponent>
		{
			public override void Destroy(SessionPlayerComponent self)
			{
				// 二次登录或者顶号操作不需要kickplayer。  主动下线则KickPlayer
				//if (self.GetMyPlayer().UnitId != 0)
				//{
				//    ActorLocationSenderComponent.Instance.Send(self.GetMyPlayer().UnitId, new G2M_SessionDisconnect());
				//}
				//ActorLocationSenderComponent.Instance.Send(self.PlayerId, new G2M_SessionDisconnect());
				//self.Domain.GetComponent<PlayerComponent>()?.Remove(self.AccountId);
				//player?.Dispose();

				Player player = self.Domain.GetComponent<PlayerComponent>().Get(self.AccountId);
				if (player == null)
				{
					Log.Info($"SessionPlayerComponent  player == null");
					return;
				}
				//if (self.DisconnectType == ErrorCore.ERR_OtherAccountLogin)
				//{
				//	Log.Info($"SessionPlayerComponent|self.DisconnectType = {self.DisconnectType}: {player.Id}"); //异地登录
				//	DisconnectHelper.KickPlayer(player).Coroutine();
				//}
				//else
				{
					//Log.Info($"SessionPlayerComponent|正常下线！{player.Id}");
					Log.Info($"SessionPlayerComponent|self.DisconnectType = {self.DisconnectType}: {player.Id}");
					ActorLocationSenderComponent.Instance.Send(self.PlayerId, new G2M_SessionDisconnect());
					player.RemoveComponent<PlayerOfflineOutTimeComponent>();
					player.AddComponent<PlayerOfflineOutTimeComponent>();
					player.ClientSession = null;
				}
			}
		}

		public static Player GetMyPlayer(this SessionPlayerComponent self)
		{
			return self.Domain.GetComponent<PlayerComponent>().Get(self.AccountId);
		}
	}
}
