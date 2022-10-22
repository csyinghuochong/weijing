using ET;
using ProtoBuf;
using System.Collections.Generic;
namespace ET
{
	[ResponseType(nameof(ObjectQueryResponse))]
	[Message(InnerOpcode.ObjectQueryRequest)]
	[ProtoContract]
	public partial class ObjectQueryRequest: Object, IActorRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(1)]
		public long Key { get; set; }

		[ProtoMember(2)]
		public long InstanceId { get; set; }

	}

	[ResponseType(nameof(A2M_Reload))]
	[Message(InnerOpcode.M2A_Reload)]
	[ProtoContract]
	public partial class M2A_Reload: Object, IActorRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(3)]
		public int LoadType { get; set; }

		[ProtoMember(4)]
		public string LoadValue { get; set; }

	}

	[Message(InnerOpcode.A2M_Reload)]
	[ProtoContract]
	public partial class A2M_Reload: Object, IActorResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

	}

	[ResponseType(nameof(G2G_LockResponse))]
	[Message(InnerOpcode.G2G_LockRequest)]
	[ProtoContract]
	public partial class G2G_LockRequest: Object, IActorRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public long Id { get; set; }

		[ProtoMember(2)]
		public string Address { get; set; }

	}

	[Message(InnerOpcode.G2G_LockResponse)]
	[ProtoContract]
	public partial class G2G_LockResponse: Object, IActorResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

	}

	[ResponseType(nameof(R2M_RechargeResponse))]
	[Message(InnerOpcode.M2R_RechargeRequest)]
	[ProtoContract]
	public partial class M2R_RechargeRequest: Object, IActorRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long UserId { get; set; }

		[ProtoMember(1)]
		public int RechargeNumber { get; set; }

		[ProtoMember(2)]
		public long PayType { get; set; }

		[ProtoMember(3)]
		public int Zone { get; set; }

	}

	[Message(InnerOpcode.R2M_RechargeResponse)]
	[ProtoContract]
	public partial class R2M_RechargeResponse: Object, IActorResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

	}

	[ResponseType(nameof(G2R_RechargeResultResponse))]
	[Message(InnerOpcode.R2G_RechargeResultRequest)]
	[ProtoContract]
	public partial class R2G_RechargeResultRequest: Object, IActorRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public long Id { get; set; }

		[ProtoMember(2)]
		public int RechargeNumber { get; set; }

		[ProtoMember(3)]
		public long UserID { get; set; }

	}

	[Message(InnerOpcode.G2R_RechargeResultResponse)]
	[ProtoContract]
	public partial class G2R_RechargeResultResponse: Object, IActorResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

	}

	[ResponseType(nameof(M2G_RechargeResultResponse))]
	[Message(InnerOpcode.G2M_RechargeResultRequest)]
	[ProtoContract]
	public partial class G2M_RechargeResultRequest: Object, IActorRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public long Id { get; set; }

		[ProtoMember(2)]
		public int RechargeNumber { get; set; }

	}

	[Message(InnerOpcode.M2G_RechargeResultResponse)]
	[ProtoContract]
	public partial class M2G_RechargeResultResponse: Object, IActorResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

	}

	[ResponseType(nameof(Center2A_CenterServerList))]
	[Message(InnerOpcode.A2Center_CenterServerList)]
	[ProtoContract]
	public partial class A2Center_CenterServerList: Object, IActorRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

	}

	[Message(InnerOpcode.Center2A_CenterServerList)]
	[ProtoContract]
	public partial class Center2A_CenterServerList: Object, IActorResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

		[ProtoMember(1)]
		public List<ServerItem> ServerItems = new List<ServerItem>();

	}

	[ResponseType(nameof(Center2A_CheckAccount))]
	[Message(InnerOpcode.A2Center_CheckAccount)]
	[ProtoContract]
	public partial class A2Center_CheckAccount: Object, IActorRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public string AccountName { get; set; }

		[ProtoMember(2)]
		public string Password { get; set; }

	}

	[Message(InnerOpcode.Center2A_CheckAccount)]
	[ProtoContract]
	public partial class Center2A_CheckAccount: Object, IActorResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

		[ProtoMember(1)]
		public PlayerInfo PlayerInfo { get; set; }

		[ProtoMember(2)]
		public long AccountId { get; set; }

	}

	[ResponseType(nameof(Center2A_SaveAccount))]
	[Message(InnerOpcode.A2Center_SaveAccount)]
	[ProtoContract]
	public partial class A2Center_SaveAccount: Object, IActorRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public string AccountName { get; set; }

		[ProtoMember(2)]
		public string Password { get; set; }

		[ProtoMember(3)]
		public PlayerInfo PlayerInfo { get; set; }

		[ProtoMember(4)]
		public long AccountId { get; set; }

	}

	[Message(InnerOpcode.Center2A_SaveAccount)]
	[ProtoContract]
	public partial class Center2A_SaveAccount: Object, IActorResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

	}

	[ResponseType(nameof(Center2A_RegisterAccount))]
	[Message(InnerOpcode.A2Center_RegisterAccount)]
	[ProtoContract]
	public partial class A2Center_RegisterAccount: Object, IActorRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public string AccountName { get; set; }

		[ProtoMember(2)]
		public string Password { get; set; }

	}

	[Message(InnerOpcode.Center2A_RegisterAccount)]
	[ProtoContract]
	public partial class Center2A_RegisterAccount: Object, IActorResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

	}

	[ResponseType(nameof(C2C_CenterServerInfoRespone))]
	[Message(InnerOpcode.C2C_CenterServerInfoReuest)]
	[ProtoContract]
	public partial class C2C_CenterServerInfoReuest: Object, IActorRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public int infoType { get; set; }

		[ProtoMember(2)]
		public int Zone { get; set; }

	}

	[Message(InnerOpcode.C2C_CenterServerInfoRespone)]
	[ProtoContract]
	public partial class C2C_CenterServerInfoRespone: Object, IActorResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

		[ProtoMember(1)]
		public string Value { get; set; }

	}

	[ResponseType(nameof(A2M_ChangeStatusResponse))]
	[Message(InnerOpcode.M2A_ChangeStatusRequest)]
	[ProtoContract]
	public partial class M2A_ChangeStatusRequest: Object, IActorRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public long UnitId { get; set; }

		[ProtoMember(2)]
		public long GateSessionId { get; set; }

		[ProtoMember(3)]
		public long UnionId { get; set; }

		[ProtoMember(4)]
		public int SceneType { get; set; }

	}

	[Message(InnerOpcode.A2M_ChangeStatusResponse)]
	[ProtoContract]
	public partial class A2M_ChangeStatusResponse: Object, IActorResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

	}

	[ResponseType(nameof(G2G_LockReleaseResponse))]
	[Message(InnerOpcode.G2G_LockReleaseRequest)]
	[ProtoContract]
	public partial class G2G_LockReleaseRequest: Object, IActorRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public long Id { get; set; }

		[ProtoMember(2)]
		public string Address { get; set; }

	}

	[Message(InnerOpcode.G2G_LockReleaseResponse)]
	[ProtoContract]
	public partial class G2G_LockReleaseResponse: Object, IActorResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

	}

	[ResponseType(nameof(ObjectAddResponse))]
	[Message(InnerOpcode.ObjectAddRequest)]
	[ProtoContract]
	public partial class ObjectAddRequest: Object, IActorRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public long Key { get; set; }

		[ProtoMember(2)]
		public long InstanceId { get; set; }

	}

	[Message(InnerOpcode.ObjectAddResponse)]
	[ProtoContract]
	public partial class ObjectAddResponse: Object, IActorResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

	}

	[ResponseType(nameof(ObjectLockResponse))]
	[Message(InnerOpcode.ObjectLockRequest)]
	[ProtoContract]
	public partial class ObjectLockRequest: Object, IActorRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public long Key { get; set; }

		[ProtoMember(2)]
		public long InstanceId { get; set; }

		[ProtoMember(3)]
		public int Time { get; set; }

	}

	[Message(InnerOpcode.ObjectLockResponse)]
	[ProtoContract]
	public partial class ObjectLockResponse: Object, IActorResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

	}

	[ResponseType(nameof(ObjectUnLockResponse))]
	[Message(InnerOpcode.ObjectUnLockRequest)]
	[ProtoContract]
	public partial class ObjectUnLockRequest: Object, IActorRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public long Key { get; set; }

		[ProtoMember(2)]
		public long OldInstanceId { get; set; }

		[ProtoMember(3)]
		public long InstanceId { get; set; }

	}

	[Message(InnerOpcode.ObjectUnLockResponse)]
	[ProtoContract]
	public partial class ObjectUnLockResponse: Object, IActorResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

	}

	[ResponseType(nameof(ObjectRemoveResponse))]
	[Message(InnerOpcode.ObjectRemoveRequest)]
	[ProtoContract]
	public partial class ObjectRemoveRequest: Object, IActorRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public long Key { get; set; }

	}

	[Message(InnerOpcode.ObjectRemoveResponse)]
	[ProtoContract]
	public partial class ObjectRemoveResponse: Object, IActorResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

	}

	[ResponseType(nameof(ObjectGetResponse))]
	[Message(InnerOpcode.ObjectGetRequest)]
	[ProtoContract]
	public partial class ObjectGetRequest: Object, IActorRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public long Key { get; set; }

	}

	[Message(InnerOpcode.ObjectGetResponse)]
	[ProtoContract]
	public partial class ObjectGetResponse: Object, IActorResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

		[ProtoMember(1)]
		public long InstanceId { get; set; }

	}

	[ResponseType(nameof(Q2G_ExitGame))]
	[Message(InnerOpcode.G2Q_ExitGame)]
	[ProtoContract]
	public partial class G2Q_ExitGame: Object, IActorRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(1)]
		public long AccountId { get; set; }

	}

	[Message(InnerOpcode.Q2G_ExitGame)]
	[ProtoContract]
	public partial class Q2G_ExitGame: Object, IActorResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

	}

	[ResponseType(nameof(A2G_ExitGame))]
	[Message(InnerOpcode.G2A_ExitGame)]
	[ProtoContract]
	public partial class G2A_ExitGame: Object, IActorRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(1)]
		public long AccountId { get; set; }

	}

	[Message(InnerOpcode.A2G_ExitGame)]
	[ProtoContract]
	public partial class A2G_ExitGame: Object, IActorResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

	}

	[ResponseType(nameof(Q2A_EnterQueue))]
	[Message(InnerOpcode.A2Q_EnterQueue)]
	[ProtoContract]
	public partial class A2Q_EnterQueue: Object, IActorRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(1)]
		public long AccountId { get; set; }

		[ProtoMember(2)]
		public string Token { get; set; }

	}

	[Message(InnerOpcode.Q2A_EnterQueue)]
	[ProtoContract]
	public partial class Q2A_EnterQueue: Object, IActorResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

		[ProtoMember(1)]
		public int QueueNumber { get; set; }

	}

	[ResponseType(nameof(L2G_AddLoginRecord))]
	[Message(InnerOpcode.G2L_AddLoginRecord)]
	[ProtoContract]
	public partial class G2L_AddLoginRecord: Object, IActorRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(1)]
		public long AccountId { get; set; }

		[ProtoMember(2)]
		public int ServerId { get; set; }

	}

	[Message(InnerOpcode.L2G_AddLoginRecord)]
	[ProtoContract]
	public partial class L2G_AddLoginRecord: Object, IActorResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

	}

	[ResponseType(nameof(M2G_RequestEnterGameState))]
	[Message(InnerOpcode.G2M_RequestEnterGameState)]
	[ProtoContract]
	public partial class G2M_RequestEnterGameState: Object, IActorLocationRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(1)]
		public long GateSessionActorId { get; set; }

	}

	[Message(InnerOpcode.M2G_RequestEnterGameState)]
	[ProtoContract]
	public partial class M2G_RequestEnterGameState: Object, IActorLocationResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

	}

	[ResponseType(nameof(G2L_DisconnectGateUnit))]
	[Message(InnerOpcode.L2G_DisconnectGateUnit)]
	[ProtoContract]
	public partial class L2G_DisconnectGateUnit: Object, IActorRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(1)]
		public long AccountId { get; set; }

		[ProtoMember(4)]
		public bool Relink { get; set; }

	}

	[Message(InnerOpcode.G2L_DisconnectGateUnit)]
	[ProtoContract]
	public partial class G2L_DisconnectGateUnit: Object, IActorResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

	}

	[ResponseType(nameof(M2G_RequestExitGame))]
	[Message(InnerOpcode.G2M_RequestExitGame)]
	[ProtoContract]
	public partial class G2M_RequestExitGame: Object, IActorLocationRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

	}

	[Message(InnerOpcode.M2G_RequestExitGame)]
	[ProtoContract]
	public partial class M2G_RequestExitGame: Object, IActorLocationResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

	}

	[ResponseType(nameof(L2G_RemoveLoginRecord))]
	[Message(InnerOpcode.G2L_RemoveLoginRecord)]
	[ProtoContract]
	public partial class G2L_RemoveLoginRecord: Object, IActorRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(1)]
		public long AccountId { get; set; }

		[ProtoMember(2)]
		public int ServerId { get; set; }

	}

	[Message(InnerOpcode.L2G_RemoveLoginRecord)]
	[ProtoContract]
	public partial class L2G_RemoveLoginRecord: Object, IActorResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

	}

	[ResponseType(nameof(R2A_GetRealmKey))]
	[Message(InnerOpcode.A2R_GetRealmKey)]
	[ProtoContract]
	public partial class A2R_GetRealmKey: Object, IActorRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(1)]
		public long AccountId { get; set; }

	}

	[Message(InnerOpcode.R2A_GetRealmKey)]
	[ProtoContract]
	public partial class R2A_GetRealmKey: Object, IActorResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

		[ProtoMember(1)]
		public string RealmKey { get; set; }

	}

	[ResponseType(nameof(G2R_GetLoginGateKey))]
	[Message(InnerOpcode.R2G_GetLoginGateKey)]
	[ProtoContract]
	public partial class R2G_GetLoginGateKey: Object, IActorRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(1)]
		public long AccountId { get; set; }

	}

	[Message(InnerOpcode.G2R_GetLoginGateKey)]
	[ProtoContract]
	public partial class G2R_GetLoginGateKey: Object, IActorResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

		[ProtoMember(1)]
		public string GateSessionKey { get; set; }

	}

	[Message(InnerOpcode.M2M_UnitTransferResponse)]
	[ProtoContract]
	public partial class M2M_UnitTransferResponse: Object, IActorResponse
	{
		[ProtoMember(1)]
		public int RpcId { get; set; }

		[ProtoMember(2)]
		public int Error { get; set; }

		[ProtoMember(3)]
		public string Message { get; set; }

		[ProtoMember(4)]
		public long NewInstanceId { get; set; }

	}

	[Message(InnerOpcode.G2M_SessionDisconnect)]
	[ProtoContract]
	public partial class G2M_SessionDisconnect: Object, IActorLocationMessage
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

	}

	[Message(InnerOpcode.G2M_ActivityUpdate)]
	[ProtoContract]
	public partial class G2M_ActivityUpdate: Object, IActorLocationMessage
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public int ActivityType { get; set; }

	}

	[ResponseType(nameof(E2M_EMailSendResponse))]
	[Message(InnerOpcode.M2E_EMailSendRequest)]
	[ProtoContract]
	public partial class M2E_EMailSendRequest: Object, IActorRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public long Id { get; set; }

		[ProtoMember(3)]
		public MailInfo MailInfo { get; set; }

	}

	[Message(InnerOpcode.E2M_EMailSendResponse)]
	[ProtoContract]
	public partial class E2M_EMailSendResponse: Object, IActorResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

	}

	[ResponseType(nameof(E2M_EMailReceiveResponse))]
	[Message(InnerOpcode.M2E_EMailReceiveRequest)]
	[ProtoContract]
	public partial class M2E_EMailReceiveRequest: Object, IActorRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public long Id { get; set; }

		[ProtoMember(2)]
		public long MailId { get; set; }

	}

	[Message(InnerOpcode.E2M_EMailReceiveResponse)]
	[ProtoContract]
	public partial class E2M_EMailReceiveResponse: Object, IActorResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

		[ProtoMember(4)]
		public MailInfo MailInfo { get; set; }

	}

	[ResponseType(nameof(M2A_ActivityUpdateResponse))]
	[Message(InnerOpcode.A2M_ActivityUpdateRequest)]
	[ProtoContract]
	public partial class A2M_ActivityUpdateRequest: Object, IActorRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public int ActivityType { get; set; }

		[ProtoMember(2)]
		public int Zone { get; set; }

	}

	[Message(InnerOpcode.M2A_ActivityUpdateResponse)]
	[ProtoContract]
	public partial class M2A_ActivityUpdateResponse: Object, IActorResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

	}

	[ResponseType(nameof(A2M_ZhanQuInfoResponse))]
	[Message(InnerOpcode.M2A_ZhanQuInfoRequest)]
	[ProtoContract]
	public partial class M2A_ZhanQuInfoRequest: Object, IActorRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public long UserId { get; set; }

	}

	[Message(InnerOpcode.A2M_ZhanQuInfoResponse)]
	[ProtoContract]
	public partial class A2M_ZhanQuInfoResponse: Object, IActorResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

		[ProtoMember(1)]
		public List<int> DayTeHui = new List<int>();

		[ProtoMember(2)]
		public List<ZhanQuReceiveNumber> ReceiveNum = new List<ZhanQuReceiveNumber>();

	}

	[ResponseType(nameof(A2M_ZhanQuReceiveResponse))]
	[Message(InnerOpcode.M2A_ZhanQuReceiveRequest)]
	[ProtoContract]
	public partial class M2A_ZhanQuReceiveRequest: Object, IActorRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public int ActivityType { get; set; }

		[ProtoMember(2)]
		public int ActivityId { get; set; }

	}

	[Message(InnerOpcode.A2M_ZhanQuReceiveResponse)]
	[ProtoContract]
	public partial class A2M_ZhanQuReceiveResponse: Object, IActorResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

	}

	[ResponseType(nameof(R2M_PetRankUpdateResponse))]
	[Message(InnerOpcode.M2R_PetRankUpdateRequest)]
	[ProtoContract]
	public partial class M2R_PetRankUpdateRequest: Object, IActorRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public long EnemyId { get; set; }

		[ProtoMember(2)]
		public RankPetInfo RankPetInfo { get; set; }

	}

	[Message(InnerOpcode.R2M_PetRankUpdateResponse)]
	[ProtoContract]
	public partial class R2M_PetRankUpdateResponse: Object, IActorResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

	}

	[ResponseType(nameof(R2M_RankUpdateResponse))]
	[Message(InnerOpcode.M2R_RankUpdateRequest)]
	[ProtoContract]
	public partial class M2R_RankUpdateRequest: Object, IActorRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public int CampId { get; set; }

		[ProtoMember(2)]
		public RankingInfo RankingInfo { get; set; }

	}

	[Message(InnerOpcode.R2M_RankUpdateResponse)]
	[ProtoContract]
	public partial class R2M_RankUpdateResponse: Object, IActorResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

	}

	[ResponseType(nameof(P2M_PaiMaiSellResponse))]
	[Message(InnerOpcode.M2P_PaiMaiSellRequest)]
	[ProtoContract]
	public partial class M2P_PaiMaiSellRequest: Object, IActorRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(2)]
		public PaiMaiItemInfo PaiMaiItemInfo { get; set; }

	}

	[Message(InnerOpcode.P2M_PaiMaiSellResponse)]
	[ProtoContract]
	public partial class P2M_PaiMaiSellResponse: Object, IActorResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

	}

	[ResponseType(nameof(P2M_PaiMaiBuyResponse))]
	[Message(InnerOpcode.M2P_PaiMaiBuyRequest)]
	[ProtoContract]
	public partial class M2P_PaiMaiBuyRequest: Object, IActorRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public PaiMaiItemInfo PaiMaiItemInfo { get; set; }

	}

	[Message(InnerOpcode.P2M_PaiMaiBuyResponse)]
	[ProtoContract]
	public partial class P2M_PaiMaiBuyResponse: Object, IActorResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

		[ProtoMember(1)]
		public PaiMaiItemInfo PaiMaiItemInfo { get; set; }

	}

	[ResponseType(nameof(P2M_PaiMaiXiaJiaResponse))]
	[Message(InnerOpcode.M2P_PaiMaiXiaJiaRequest)]
	[ProtoContract]
	public partial class M2P_PaiMaiXiaJiaRequest: Object, IActorRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(2)]
		public long PaiMaiItemInfoId { get; set; }

	}

	[Message(InnerOpcode.P2M_PaiMaiXiaJiaResponse)]
	[ProtoContract]
	public partial class P2M_PaiMaiXiaJiaResponse: Object, IActorResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

		[ProtoMember(2)]
		public PaiMaiItemInfo PaiMaiItemInfo { get; set; }

	}

	[ResponseType(nameof(P2M_PaiMaiShopResponse))]
	[Message(InnerOpcode.M2P_PaiMaiShopRequest)]
	[ProtoContract]
	public partial class M2P_PaiMaiShopRequest: Object, IActorRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public int ItemID { get; set; }

		[ProtoMember(2)]
		public int BuyNum { get; set; }

	}

	[Message(InnerOpcode.P2M_PaiMaiShopResponse)]
	[ProtoContract]
	public partial class P2M_PaiMaiShopResponse: Object, IActorResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

		[ProtoMember(1)]
		public PaiMaiShopItemInfo PaiMaiShopItemInfo { get; set; }

	}

	[ResponseType(nameof(E2P_PaiMaiOverTimeResponse))]
	[Message(InnerOpcode.P2E_PaiMaiOverTimeRequest)]
	[ProtoContract]
	public partial class P2E_PaiMaiOverTimeRequest: Object, IActorRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(2)]
		public PaiMaiItemInfo PaiMaiItemInfo { get; set; }

	}

	[Message(InnerOpcode.E2P_PaiMaiOverTimeResponse)]
	[ProtoContract]
	public partial class E2P_PaiMaiOverTimeResponse: Object, IActorResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

	}

	[ResponseType(nameof(A2M_MysteryBuyResponse))]
	[Message(InnerOpcode.M2A_MysteryBuyRequest)]
	[ProtoContract]
	public partial class M2A_MysteryBuyRequest: Object, IActorRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(2)]
		public MysteryItemInfo MysteryItemInfo { get; set; }

	}

	[Message(InnerOpcode.A2M_MysteryBuyResponse)]
	[ProtoContract]
	public partial class A2M_MysteryBuyResponse: Object, IActorResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

	}

	[ResponseType(nameof(G2G_UnitListResponse))]
	[Message(InnerOpcode.G2G_UnitListRequest)]
	[ProtoContract]
	public partial class G2G_UnitListRequest: Object, IActorRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

	}

	[Message(InnerOpcode.G2G_UnitListResponse)]
	[ProtoContract]
	public partial class G2G_UnitListResponse: Object, IActorResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

		[ProtoMember(1)]
		public int OnLineNumber { get; set; }

	}

	[ResponseType(nameof(T2M_TeamDungeonOffResponse))]
	[Message(InnerOpcode.M2T_TeamDungeonOffRequest)]
	[ProtoContract]
	public partial class M2T_TeamDungeonOffRequest: Object, IActorRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public long UserID { get; set; }

	}

	[Message(InnerOpcode.T2M_TeamDungeonOffResponse)]
	[ProtoContract]
	public partial class T2M_TeamDungeonOffResponse: Object, IActorResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

	}

//进入组队副本
	[ResponseType(nameof(T2M_TeamDungeonEnterResponse))]
	[Message(InnerOpcode.M2T_TeamDungeonEnterRequest)]
	[ProtoContract]
	public partial class M2T_TeamDungeonEnterRequest: Object, IActorRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public long UserID { get; set; }

	}

	[Message(InnerOpcode.T2M_TeamDungeonEnterResponse)]
	[ProtoContract]
	public partial class T2M_TeamDungeonEnterResponse: Object, IActorResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

		[ProtoMember(1)]
		public int FubenId { get; set; }

		[ProtoMember(2)]
		public long FubenInstanceId { get; set; }

	}

	[ResponseType(nameof(G2T_GateUnitInfoResponse))]
	[Message(InnerOpcode.T2G_GateUnitInfoRequest)]
	[ProtoContract]
	public partial class T2G_GateUnitInfoRequest: Object, IActorRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public long UserID { get; set; }

	}

	[Message(InnerOpcode.G2T_GateUnitInfoResponse)]
	[ProtoContract]
	public partial class G2T_GateUnitInfoResponse: Object, IActorResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

		[ProtoMember(1)]
		public long SessionInstanceId { get; set; }

		[ProtoMember(2)]
		public int PlayerState { get; set; }

		[ProtoMember(3)]
		public long UnitId { get; set; }

	}

	[ResponseType(nameof(T2C_GetTeamInfoResponse))]
	[Message(InnerOpcode.C2T_GetTeamInfoRequest)]
	[ProtoContract]
	public partial class C2T_GetTeamInfoRequest: Object, IActorRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public long UserID { get; set; }

	}

	[Message(InnerOpcode.T2C_GetTeamInfoResponse)]
	[ProtoContract]
	public partial class T2C_GetTeamInfoResponse: Object, IActorResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

		[ProtoMember(1)]
		public TeamInfo TeamInfo { get; set; }

	}

	[ResponseType(nameof(U2M_UnionCreateResponse))]
	[Message(InnerOpcode.M2U_UnionCreateRequest)]
	[ProtoContract]
	public partial class M2U_UnionCreateRequest: Object, IActorRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public string UnionName { get; set; }

		[ProtoMember(2)]
		public string UnionPurpose { get; set; }

		[ProtoMember(4)]
		public long UserID { get; set; }

	}

	[Message(InnerOpcode.U2M_UnionCreateResponse)]
	[ProtoContract]
	public partial class U2M_UnionCreateResponse: Object, IActorResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

		[ProtoMember(1)]
		public long UnionId { get; set; }

	}

//离开公会
	[ResponseType(nameof(U2M_UnionLeaveResponse))]
	[Message(InnerOpcode.M2U_UnionLeaveRequest)]
	[ProtoContract]
	public partial class M2U_UnionLeaveRequest: Object, IActorRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public long UnionId { get; set; }

		[ProtoMember(2)]
		public long UserId { get; set; }

	}

	[Message(InnerOpcode.U2M_UnionLeaveResponse)]
	[ProtoContract]
	public partial class U2M_UnionLeaveResponse: Object, IActorResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

	}

//公会踢人
	[ResponseType(nameof(M2U_UnionKickOutResponse))]
	[Message(InnerOpcode.U2M_UnionKickOutRequest)]
	[ProtoContract]
	public partial class U2M_UnionKickOutRequest: Object, IActorRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public long UserId { get; set; }

	}

	[Message(InnerOpcode.M2U_UnionKickOutResponse)]
	[ProtoContract]
	public partial class M2U_UnionKickOutResponse: Object, IActorResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

	}

//入会通知
	[ResponseType(nameof(M2U_UnionApplyResponse))]
	[Message(InnerOpcode.U2M_UnionApplyRequest)]
	[ProtoContract]
	public partial class U2M_UnionApplyRequest: Object, IActorRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public long UnionId { get; set; }

		[ProtoMember(2)]
		public string UnionName { get; set; }

	}

	[Message(InnerOpcode.M2U_UnionApplyResponse)]
	[ProtoContract]
	public partial class M2U_UnionApplyResponse: Object, IActorResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

	}

	[ResponseType(nameof(R2A_DeleteRoleData))]
	[Message(InnerOpcode.A2R_DeleteRoleData)]
	[ProtoContract]
	public partial class A2R_DeleteRoleData: Object, IActorRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(2)]
		public int DeleXuhaoID { get; set; }

		[ProtoMember(3)]
		public long DeleUserID { get; set; }

		[ProtoMember(4)]
		public long AccountId { get; set; }

	}

	[Message(InnerOpcode.R2A_DeleteRoleData)]
	[ProtoContract]
	public partial class R2A_DeleteRoleData: Object, IActorResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

	}

	[ResponseType(nameof(R2M_DBServerInfoResponse))]
	[Message(InnerOpcode.M2R_DBServerInfoRequest)]
	[ProtoContract]
	public partial class M2R_DBServerInfoRequest: Object, IActorRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

	}

	[Message(InnerOpcode.R2M_DBServerInfoResponse)]
	[ProtoContract]
	public partial class R2M_DBServerInfoResponse: Object, IActorResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

		[ProtoMember(1)]
		public ServerInfo ServerInfo { get; set; }

	}

	[ResponseType(nameof(F2M_FubenCenterListResponse))]
	[Message(InnerOpcode.M2F_FubenCenterListRequest)]
	[ProtoContract]
	public partial class M2F_FubenCenterListRequest: Object, IActorRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

	}

	[Message(InnerOpcode.F2M_FubenCenterListResponse)]
	[ProtoContract]
	public partial class F2M_FubenCenterListResponse: Object, IActorResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

		[ProtoMember(1)]
		public List<long> FubenInstanceList = new List<long>();

	}

//副本分配中心服
	[ResponseType(nameof(F2M_FubenCenterOpenResponse))]
	[Message(InnerOpcode.M2F_FubenCenterOperateRequest)]
	[ProtoContract]
	public partial class M2F_FubenCenterOperateRequest: Object, IActorRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public int OperateType { get; set; }

		[ProtoMember(2)]
		public long FubenInstanceId { get; set; }

	}

	[Message(InnerOpcode.F2M_FubenCenterOpenResponse)]
	[ProtoContract]
	public partial class F2M_FubenCenterOpenResponse: Object, IActorResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

		[ProtoMember(1)]
		public ServerInfo ServerInfo { get; set; }

	}

//通知其他服务进程刷新肝帝
	[ResponseType(nameof(F2R_WorldLvUpdateResponse))]
	[Message(InnerOpcode.R2F_WorldLvUpdateRequest)]
	[ProtoContract]
	public partial class R2F_WorldLvUpdateRequest: Object, IActorRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public ServerInfo ServerInfo { get; set; }

	}

	[Message(InnerOpcode.F2R_WorldLvUpdateResponse)]
	[ProtoContract]
	public partial class F2R_WorldLvUpdateResponse: Object, IActorResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

	}

//通知其他服务进程刷新肝帝
	[ResponseType(nameof(M2F_ServerInfoUpdateResponse))]
	[Message(InnerOpcode.F2M_ServerInfoUpdateRequest)]
	[ProtoContract]
	public partial class F2M_ServerInfoUpdateRequest: Object, IActorRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public ServerInfo ServerInfo { get; set; }

	}

	[Message(InnerOpcode.M2F_ServerInfoUpdateResponse)]
	[ProtoContract]
	public partial class M2F_ServerInfoUpdateResponse: Object, IActorResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

	}

	[Message(InnerOpcode.M2A_FirstWinInfoMessage)]
	[ProtoContract]
	public partial class M2A_FirstWinInfoMessage: Object, IActorMessage
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public FirstWinInfo FirstWinInfo { get; set; }

	}

	[ResponseType(nameof(Center2A_RechargeResponse))]
	[Message(InnerOpcode.A2Center_RechargeRequest)]
	[ProtoContract]
	public partial class A2Center_RechargeRequest: Object, IActorRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public long AccountId { get; set; }

		[ProtoMember(2)]
		public RechargeInfo RechargeInfo { get; set; }

	}

	[Message(InnerOpcode.Center2A_RechargeResponse)]
	[ProtoContract]
	public partial class Center2A_RechargeResponse: Object, IActorResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

	}

	[ResponseType(nameof(Center2M_BuChangeResponse))]
	[Message(InnerOpcode.M2Center_BuChangeRequest)]
	[ProtoContract]
	public partial class M2Center_BuChangeRequest: Object, IActorRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public long BuChangId { get; set; }

		[ProtoMember(2)]
		public long UserId { get; set; }

		[ProtoMember(3)]
		public long AccountId { get; set; }

	}

	[Message(InnerOpcode.Center2M_BuChangeResponse)]
	[ProtoContract]
	public partial class Center2M_BuChangeResponse: Object, IActorResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

		[ProtoMember(1)]
		public List<RechargeInfo> RechargeInfos = new List<RechargeInfo>();

	}

	[ResponseType(nameof(E2M_GMEMailSendResponse))]
	[Message(InnerOpcode.M2E_GMEMailSendRequest)]
	[ProtoContract]
	public partial class M2E_GMEMailSendRequest: Object, IActorRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public long UserId { get; set; }

		[ProtoMember(2)]
		public string Itemlist { get; set; }

		[ProtoMember(3)]
		public string Title { get; set; }

	}

	[Message(InnerOpcode.E2M_GMEMailSendResponse)]
	[ProtoContract]
	public partial class E2M_GMEMailSendResponse: Object, IActorResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

	}

	[ResponseType(nameof(L2A_LoginAccountResponse))]
	[Message(InnerOpcode.A2L_LoginAccountRequest)]
	[ProtoContract]
	public partial class A2L_LoginAccountRequest: Object, IActorRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(1)]
		public long AccountId { get; set; }

		[ProtoMember(5)]
		public bool Relink { get; set; }

	}

	[Message(InnerOpcode.L2A_LoginAccountResponse)]
	[ProtoContract]
	public partial class L2A_LoginAccountResponse: Object, IActorResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

	}

	[ResponseType(nameof(Chat2G_EnterChat))]
	[Message(InnerOpcode.G2Chat_EnterChat)]
	[ProtoContract]
	public partial class G2Chat_EnterChat: Object, IActorRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(1)]
		public string Name { get; set; }

		[ProtoMember(2)]
		public long UnitId { get; set; }

		[ProtoMember(3)]
		public long GateSessionActorId { get; set; }

	}

	[Message(InnerOpcode.Chat2G_EnterChat)]
	[ProtoContract]
	public partial class Chat2G_EnterChat: Object, IActorResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

		[ProtoMember(1)]
		public long ChatInfoUnitInstanceId { get; set; }

	}

	[ResponseType(nameof(Chat2G_RequestExitChat))]
	[Message(InnerOpcode.G2Chat_RequestExitChat)]
	[ProtoContract]
	public partial class G2Chat_RequestExitChat: Object, IActorRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

	}

	[Message(InnerOpcode.Chat2G_RequestExitChat)]
	[ProtoContract]
	public partial class Chat2G_RequestExitChat: Object, IActorResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

	}

//进入战场
	[ResponseType(nameof(B2M_BattleEnterResponse))]
	[Message(InnerOpcode.M2B_BattleEnterRequest)]
	[ProtoContract]
	public partial class M2B_BattleEnterRequest: Object, IActorRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public long UserID { get; set; }

		[ProtoMember(2)]
		public int SceneId { get; set; }

	}

	[Message(InnerOpcode.B2M_BattleEnterResponse)]
	[ProtoContract]
	public partial class B2M_BattleEnterResponse: Object, IActorResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

		[ProtoMember(2)]
		public long FubenInstanceId { get; set; }

		[ProtoMember(3)]
		public int Camp { get; set; }

	}

}
