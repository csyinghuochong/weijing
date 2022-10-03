using System;

namespace ET
{
	public class C2G_LoginGameGateHandler : AMRpcHandler<C2G_LoginGameGate, G2C_LoginGameGate>
	{
		protected override async ETTask Run(Session session, C2G_LoginGameGate request, G2C_LoginGameGate response, Action reply)
		{
			Log.Debug($"LoginTest C2G_LoginGameGate  {request.RoleId}");
			if (session.DomainScene().SceneType != SceneType.Gate)
			{
<<<<<<< HEAD
				Log.Error($"LoginTest C2G_LoginGameGate请求的Scene错误，当前Scene为：{session.DomainScene().SceneType}");
=======
				Log.Error($"C2G_LoginGameGate请求的Scene错误，当前Scene为：{session.DomainScene().SceneType}");
>>>>>>> ba72ae7e7 (no message)
				session.Dispose();
				return;
			}
			session.RemoveComponent<SessionAcceptTimeoutComponent>();
			if (session.GetComponent<SessionLockingComponent>() != null)
			{
				response.Error = ErrorCore.ERR_RequestRepeatedly;
				reply();
				return;
			}

			Scene scene = session.DomainScene();
			string tokenKey = scene.GetComponent<GateSessionKeyComponent>().Get(request.Account);
			if (tokenKey == null || !tokenKey.Equals(request.Key))
			{
				response.Error = ErrorCore.ERR_ConnectGateKeyError;
				response.Message = "LoginTest C2G_LoginGameGate key验证失败!";
				reply();
				session?.Disconnect().Coroutine();
				return;
			}

			scene.GetComponent<GateSessionKeyComponent>().Remove(request.Account);

			long instanceId = session.InstanceId;
			using (session.AddComponent<SessionLockingComponent>())
			using (await CoroutineLockComponent.Instance.Wait(CoroutineLockType.LoginGate, request.Account.GetHashCode()))
			{
				if (instanceId != session.InstanceId)	//防止多个客户端同时请求
				{
<<<<<<< HEAD
					Log.Debug($"LoginTest C2G_LoginGameGate 多个客户端同时请求 request.RoleId: {request.RoleId}");
=======
					Log.Debug($"C2G_LoginGameGate 多个客户端同时请求{request.Account}{session.RemoteAddress}");
>>>>>>> ba72ae7e7 (no message)
					return;
				}

				//通知登录中心服 记录本次登录的服务器Zone
				StartSceneConfig loginCenterConfig = StartSceneConfigCategory.Instance.LoginCenterConfig;
				L2G_AddLoginRecord l2ARoleLogin = (L2G_AddLoginRecord)await MessageHelper.CallActor(loginCenterConfig.InstanceId,
																				new G2L_AddLoginRecord() { AccountId = request.Account, ServerId = scene.Zone });
				if (l2ARoleLogin.Error != ErrorCode.ERR_Success)
				{
					response.Error = l2ARoleLogin.Error;
					reply();
					session?.Disconnect().Coroutine();
					return;
				}

				SessionStateComponent SessionStateComponent = session.GetComponent<SessionStateComponent>();
				if (SessionStateComponent == null)
				{
					SessionStateComponent = session.AddComponent<SessionStateComponent>();
				}
				SessionStateComponent.State = SessionState.Normal;
				//游戏客户端在Gate上的一个映射
				Player player = scene.GetComponent<PlayerComponent>().Get(request.Account);
				if (player!=null && player.Id != request.RoleId)
				{
					Log.Debug($"LoginTest C2G_LoginGameGate  player.Id:{player.Id}  request.RoleId: {request.RoleId}");
				}
				if (player == null)
				{
					// 添加一个新的GateUnit
					player = scene.GetComponent<PlayerComponent>().AddChildWithId<Player, long, long>(request.RoleId, request.Account, request.RoleId);
					scene.GetComponent<PlayerComponent>().Add(player);
					session.AddComponent<MailBoxComponent, MailboxType>(MailboxType.GateSession);
					player.AddComponent<MailBoxComponent, MailboxType>(MailboxType.GateSession);                    //ET-UWA
					player.PlayerState = PlayerState.Gate;
<<<<<<< HEAD
					Log.Debug($"LoginTest C2G_LoginGameGate  player.Id: {player.Id} player.InstanceId:{player.InstanceId} unitId: {request.RoleId}");
=======
>>>>>>> ba72ae7e7 (no message)
				}
				else
				{
					//移除倒计时下线组件   //断线重连、
					player.RemoveComponent<PlayerOfflineOutTimeComponent>();
<<<<<<< HEAD
					Log.Debug($"LoginTest C2G_LoginGameGate player!=null player.Id: {player.Id} player.InstanceId:{player.InstanceId} unitId: {request.RoleId}");
=======
					Log.Debug($"C2G_LoginGameGate 多个客户端同时请求{request.Account}{session.RemoteAddress}");
>>>>>>> ba72ae7e7 (no message)
				}

				session.AddComponent<SessionPlayerComponent>().PlayerId = player.Id;
				session.GetComponent<SessionPlayerComponent>().PlayerInstanceId = player.InstanceId;
				session.GetComponent<SessionPlayerComponent>().AccountId = request.Account;
				player.ClientSession = session;
			}
			reply();
		}
	}
}