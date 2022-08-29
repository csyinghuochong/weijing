using System;


namespace ET
{
	[MessageHandler]
	public class C2M_ServerStopHandler : AMRpcHandler<C2M_ServerStop, M2C_ServerStop>
	{
		protected override async ETTask Run(Session session, C2M_ServerStop request, M2C_ServerStop response, Action reply)
		{
			long chatServerId = StartSceneConfigCategory.Instance.GetBySceneName(session.DomainZone(), Enum.GetName(SceneType.Chat)).InstanceId;

			A2M_ChangeStatusResponse g_SendChatRequest = (A2M_ChangeStatusResponse)await ActorMessageSenderComponent.Instance.Call
				(chatServerId, new M2A_ChangeStatusRequest()
				{
					SceneType = -1,
				});

			reply();
			await ETTask.CompletedTask;
		}
	}
}