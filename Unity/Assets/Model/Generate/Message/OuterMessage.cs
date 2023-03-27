using ET;
using ProtoBuf;
using System.Collections.Generic;
namespace ET
{
//IRequest   IResponse   请求返回配合使用   直连网关服的
//IActorLocationRequest  IActorLocationResponse   切场景请求   请求返回配合使用  需要网关服转换的
//IActorMessage           服务器主动发送给前端不需要返回值
	[ResponseType(nameof(A2C_Register))]
	[Message(OuterOpcode.C2A_Register)]
	[ProtoContract]
	public partial class C2A_Register: Object, IRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(1)]
		public string Account { get; set; }

		[ProtoMember(2)]
		public string Password { get; set; }

	}

	[Message(OuterOpcode.A2C_Register)]
	[ProtoContract]
	public partial class A2C_Register: Object, IResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

	}

	[ResponseType(nameof(Center2C_Register))]
	[Message(OuterOpcode.C2Center_Register)]
	[ProtoContract]
	public partial class C2Center_Register: Object, IRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public string Account { get; set; }

		[ProtoMember(2)]
		public string Password { get; set; }

	}

	[Message(OuterOpcode.Center2C_Register)]
	[ProtoContract]
	public partial class Center2C_Register: Object, IResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

	}

	[ResponseType(nameof(A2C_RealNameResponse))]
	[Message(OuterOpcode.C2A_RealNameRequest)]
	[ProtoContract]
	public partial class C2A_RealNameRequest: Object, IRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(1)]
		public string Name { get; set; }

		[ProtoMember(2)]
		public string IdCardNO { get; set; }

		[ProtoMember(3)]
		public int AiType { get; set; }

		[ProtoMember(4)]
		public long AccountId { get; set; }

	}

	[Message(OuterOpcode.A2C_RealNameResponse)]
	[ProtoContract]
	public partial class A2C_RealNameResponse: Object, IResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

		[ProtoMember(1)]
		public int ErrorCode { get; set; }

	}

	[ResponseType(nameof(M2C_TestResponse))]
	[Message(OuterOpcode.C2M_TestRequest)]
	[ProtoContract]
	public partial class C2M_TestRequest: Object, IActorLocationRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public string request { get; set; }

	}

	[Message(OuterOpcode.M2C_TestResponse)]
	[ProtoContract]
	public partial class M2C_TestResponse: Object, IActorLocationResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

		[ProtoMember(1)]
		public string response { get; set; }

	}

	[ResponseType(nameof(Actor_TransferResponse))]
	[Message(OuterOpcode.Actor_TransferRequest)]
	[ProtoContract]
	public partial class Actor_TransferRequest: Object, IActorLocationRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public int SceneType { get; set; }

		[ProtoMember(2)]
		public int SceneId { get; set; }

		[ProtoMember(5)]
		public int Difficulty { get; set; }

		[ProtoMember(6)]
		public string paramInfo { get; set; }

	}

	[Message(OuterOpcode.Actor_TransferResponse)]
	[ProtoContract]
	public partial class Actor_TransferResponse: Object, IActorLocationResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

	}

	[ResponseType(nameof(A2C_CreateRoleData))]
	[Message(OuterOpcode.C2A_CreateRoleData)]
	[ProtoContract]
	public partial class C2A_CreateRoleData: Object, IRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(2)]
		public int CreateOcc { get; set; }

		[ProtoMember(3)]
		public string CreateName { get; set; }

		[ProtoMember(4)]
		public long AccountId { get; set; }

	}

	[Message(OuterOpcode.A2C_CreateRoleData)]
	[ProtoContract]
	public partial class A2C_CreateRoleData: Object, IResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

		[ProtoMember(1)]
		public CreateRoleInfo createRoleInfo { get; set; }

	}

	[ResponseType(nameof(A2C_DeleteRoleData))]
	[Message(OuterOpcode.C2A_DeleteRoleData)]
	[ProtoContract]
	public partial class C2A_DeleteRoleData: Object, IRequest
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

	[Message(OuterOpcode.A2C_DeleteRoleData)]
	[ProtoContract]
	public partial class A2C_DeleteRoleData: Object, IResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

	}

	[ResponseType(nameof(Q2C_EnterQueue))]
	[Message(OuterOpcode.C2Q_EnterQueue)]
	[ProtoContract]
	public partial class C2Q_EnterQueue: Object, IRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(1)]
		public string Token { get; set; }

		[ProtoMember(3)]
		public long AccountId { get; set; }

	}

	[Message(OuterOpcode.Q2C_EnterQueue)]
	[ProtoContract]
	public partial class Q2C_EnterQueue: Object, IResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

	}

	[Message(OuterOpcode.Q2C_EnterGame)]
	[ProtoContract]
	public partial class Q2C_EnterGame: Object, IMessage
	{
		[ProtoMember(1)]
		public int Error { get; set; }

		[ProtoMember(2)]
		public string Token { get; set; }

	}

	[ResponseType(nameof(A2C_GetRealmKey))]
	[Message(OuterOpcode.C2A_GetRealmKey)]
	[ProtoContract]
	public partial class C2A_GetRealmKey: Object, IRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(1)]
		public string Token { get; set; }

		[ProtoMember(2)]
		public int ServerId { get; set; }

		[ProtoMember(3)]
		public long AccountId { get; set; }

	}

	[Message(OuterOpcode.A2C_GetRealmKey)]
	[ProtoContract]
	public partial class A2C_GetRealmKey: Object, IResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

		[ProtoMember(1)]
		public string RealmKey { get; set; }

		[ProtoMember(2)]
		public string RealmAddress { get; set; }

	}

	[ResponseType(nameof(R2C_LoginRealm))]
	[Message(OuterOpcode.C2R_LoginRealm)]
	[ProtoContract]
	public partial class C2R_LoginRealm: Object, IRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(1)]
		public long AccountId { get; set; }

		[ProtoMember(2)]
		public string RealmTokenKey { get; set; }

	}

	[Message(OuterOpcode.R2C_LoginRealm)]
	[ProtoContract]
	public partial class R2C_LoginRealm: Object, IResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

		[ProtoMember(1)]
		public string GateSessionKey { get; set; }

		[ProtoMember(2)]
		public string GateAddress { get; set; }

	}

	[ResponseType(nameof(G2C_LoginGameGate))]
	[Message(OuterOpcode.C2G_LoginGameGate)]
	[ProtoContract]
	public partial class C2G_LoginGameGate: Object, IRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(1)]
		public string Key { get; set; }

		[ProtoMember(2)]
		public long RoleId { get; set; }

		[ProtoMember(3)]
		public long Account { get; set; }

	}

	[Message(OuterOpcode.G2C_LoginGameGate)]
	[ProtoContract]
	public partial class G2C_LoginGameGate: Object, IResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

// 自己的unit id
		[ProtoMember(1)]
		public long PlayerId { get; set; }

	}

	[ResponseType(nameof(G2C_EnterGame))]
	[Message(OuterOpcode.C2G_EnterGame)]
	[ProtoContract]
	public partial class C2G_EnterGame: Object, IRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(1)]
		public int MapId { get; set; }

		[ProtoMember(2)]
		public long UserID { get; set; }

		[ProtoMember(3)]
		public long AccountId { get; set; }

		[ProtoMember(4)]
		public bool Relink { get; set; }

		[ProtoMember(5)]
		public string DeviceName { get; set; }

		[ProtoMember(6)]
		public int Version { get; set; }

	}

	[Message(OuterOpcode.G2C_EnterGame)]
	[ProtoContract]
	public partial class G2C_EnterGame: Object, IResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

// 自己的unit id
		[ProtoMember(1)]
		public long MyId { get; set; }

	}

	[Message(OuterOpcode.MoveInfo)]
	[ProtoContract]
	public partial class MoveInfo: Object
	{
		[ProtoMember(1)]
		public List<float> X = new List<float>();

		[ProtoMember(2)]
		public List<float> Y = new List<float>();

		[ProtoMember(3)]
		public List<float> Z = new List<float>();

		[ProtoMember(4)]
		public float A { get; set; }

		[ProtoMember(5)]
		public float B { get; set; }

		[ProtoMember(6)]
		public float C { get; set; }

		[ProtoMember(7)]
		public float W { get; set; }

		[ProtoMember(8)]
		public int TurnSpeed { get; set; }

	}

	[Message(OuterOpcode.UserInfo)]
	[ProtoContract]
	public partial class UserInfo: Object
	{
		[ProtoMember(1)]
		public long AccInfoID { get; set; }

		[ProtoMember(2)]
		public string Name { get; set; }

		[ProtoMember(3)]
		public long Gold { get; set; }

//钻石
		[ProtoMember(4)]
		public long Diamond { get; set; }

// 等级
		[ProtoMember(5)]
		public int Lv { get; set; }

// 经验
		[ProtoMember(6)]
		public long Exp { get; set; }

// 疲劳
		[ProtoMember(7)]
		public long PiLao { get; set; }

//职业
		[ProtoMember(8)]
		public int Occ { get; set; }

//职业
		[ProtoMember(9)]
		public int OccTwo { get; set; }

		[ProtoMember(10)]
		public int Combat { get; set; }

		[ProtoMember(11)]
		public int RobotId { get; set; }

		[ProtoMember(12)]
		public long HuoYue { get; set; }

		[ProtoMember(13)]
		public int Sp { get; set; }

		[ProtoMember(14)]
		public int Vitality { get; set; }

		[ProtoMember(15)]
		public long UnionId { get; set; }

		[ProtoMember(16)]
		public long RongYu { get; set; }

		[ProtoMember(17)]
		public string UnionName { get; set; }

		[ProtoMember(18)]
		public long UserId { get; set; }

		[ProtoMember(19)]
		public List<KeyValuePair> GameSettingInfos = new List<KeyValuePair>();

		[ProtoMember(20)]
		public List<int> MakeList = new List<int>();

		[ProtoMember(21)]
		public List<int> CompleteGuideIds = new List<int>();

		[ProtoMember(22)]
		public List<KeyValuePairInt> DayFubenTimes = new List<KeyValuePairInt>();

		[ProtoMember(23)]
		public List<KeyValuePair> MonsterRevives = new List<KeyValuePair>();

		[ProtoMember(24)]
		public List<int> TowerRewardIds = new List<int>();

		[ProtoMember(25)]
		public List<int> ChouKaRewardIds = new List<int>();

		[ProtoMember(26)]
		public List<int> XiLianRewardIds = new List<int>();

//购买过的神秘商品
		[ProtoMember(27)]
		public List<KeyValuePairInt> MysteryItems = new List<KeyValuePairInt>();

//已开启的宝箱记录
		[ProtoMember(28)]
		public List<KeyValuePair> OpenChestList = new List<KeyValuePair>();

		[ProtoMember(29)]
		public List<KeyValuePairInt> MakeIdList = new List<KeyValuePairInt>();

//已通关的副本列表
		[ProtoMember(30)]
		public List<FubenPassInfo> FubenPassList = new List<FubenPassInfo>();

//每日道具使用限制
		[ProtoMember(31)]
		public List<KeyValuePairInt> DayItemUse = new List<KeyValuePairInt>();

		[ProtoMember(32)]
		public List<int> HorseIds = new List<int>();

//剧情副本每日刷新 global79
		[ProtoMember(33)]
		public List<KeyValuePairInt> DayMonsters = new List<KeyValuePairInt>();

//随机精灵每日刷新 global80
		[ProtoMember(34)]
		public List<int> DayJingLing = new List<int>();

		[ProtoMember(35)]
		public long JiaYuanFund { get; set; }

		[ProtoMember(36)]
		public long JiaYuanExp { get; set; }

		[ProtoMember(37)]
		public int JiaYuanLv { get; set; }

	}

	[Message(OuterOpcode.KeyValuePair)]
	[ProtoContract]
	public partial class KeyValuePair: Object
	{
		[ProtoMember(1)]
		public int KeyId { get; set; }

		[ProtoMember(2)]
		public string Value { get; set; }

		[ProtoMember(3)]
		public string Value2 { get; set; }

	}

	[Message(OuterOpcode.KeyValuePairInt)]
	[ProtoContract]
	public partial class KeyValuePairInt: Object
	{
		[ProtoMember(1)]
		public int KeyId { get; set; }

		[ProtoMember(2)]
		public long Value { get; set; }

	}

	[Message(OuterOpcode.CreateRoleInfo)]
	[ProtoContract]
	public partial class CreateRoleInfo: Object
	{
		[ProtoMember(2)]
		public long UserID { get; set; }

		[ProtoMember(4)]
		public int PlayerLv { get; set; }

		[ProtoMember(5)]
		public int PlayerOcc { get; set; }

		[ProtoMember(6)]
		public int WeaponId { get; set; }

		[ProtoMember(7)]
		public string PlayerName { get; set; }

		[ProtoMember(8)]
		public int OccTwo { get; set; }

	}

	[Message(OuterOpcode.UnitInfo)]
	[ProtoContract]
	public partial class UnitInfo: Object
	{
		[ProtoMember(1)]
		public long UnitId { get; set; }

		[ProtoMember(2)]
		public int UnitType { get; set; }

		[ProtoMember(3)]
		public int ConfigId { get; set; }

		[ProtoMember(4)]
		public int RoleCamp { get; set; }

		[ProtoMember(6)]
		public float X { get; set; }

		[ProtoMember(7)]
		public float Y { get; set; }

		[ProtoMember(8)]
		public float Z { get; set; }

		[ProtoMember(9)]
		public List<int> Ks = new List<int>();

		[ProtoMember(10)]
		public List<long> Vs = new List<long>();

		[ProtoMember(14)]
		public float ForwardX { get; set; }

		[ProtoMember(15)]
		public float ForwardY { get; set; }

		[ProtoMember(16)]
		public float ForwardZ { get; set; }

		[ProtoMember(17)]
		public MoveInfo MoveInfo { get; set; }

		[ProtoMember(19)]
		public List<KeyValuePair> Buffs = new List<KeyValuePair>();

		[ProtoMember(20)]
		public List<SkillInfo> Skills = new List<SkillInfo>();

		[ProtoMember(21)]
		public string UnitName { get; set; }

		[ProtoMember(22)]
		public string MasterName { get; set; }

		[ProtoMember(23)]
		public string StallName { get; set; }

		[ProtoMember(24)]
		public string UnionName { get; set; }

		[ProtoMember(25)]
		public string ExtendPar { get; set; }

	}

	[Message(OuterOpcode.M2C_CreateUnits)]
	[ProtoContract]
	public partial class M2C_CreateUnits: Object, IActorMessage
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(2)]
		public List<UnitInfo> Units = new List<UnitInfo>();

		[ProtoMember(3)]
		public List<SpilingInfo> Spilings = new List<SpilingInfo>();

		[ProtoMember(4)]
		public List<DropInfo> Drops = new List<DropInfo>();

		[ProtoMember(5)]
		public List<TransferInfo> Transfers = new List<TransferInfo>();

		[ProtoMember(6)]
		public List<NpcInfo> Npcs = new List<NpcInfo>();

		[ProtoMember(7)]
		public List<RolePetInfo> Pets = new List<RolePetInfo>();

		[ProtoMember(8)]
		public int UpdateAll { get; set; }

	}

	[Message(OuterOpcode.M2C_CreateMyUnit)]
	[ProtoContract]
	public partial class M2C_CreateMyUnit: Object, IActorMessage
	{
		[ProtoMember(1)]
		public UnitInfo Unit { get; set; }

	}

	[Message(OuterOpcode.M2C_StartSceneChange)]
	[ProtoContract]
	public partial class M2C_StartSceneChange: Object, IActorMessage
	{
		[ProtoMember(1)]
		public long SceneInstanceId { get; set; }

		[ProtoMember(2)]
		public int SceneType { get; set; }

		[ProtoMember(3)]
		public int ChapterId { get; set; }

		[ProtoMember(4)]
		public int Difficulty { get; set; }

		[ProtoMember(5)]
		public string ParamInfo { get; set; }

	}

	[Message(OuterOpcode.M2C_RemoveUnits)]
	[ProtoContract]
	public partial class M2C_RemoveUnits: Object, IActorMessage
	{
		[ProtoMember(2)]
		public List<long> Units = new List<long>();

	}

	[Message(OuterOpcode.C2M_PathfindingResult)]
	[ProtoContract]
	public partial class C2M_PathfindingResult: Object, IActorLocationMessage
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public float X { get; set; }

		[ProtoMember(2)]
		public float Y { get; set; }

		[ProtoMember(3)]
		public float Z { get; set; }

		[ProtoMember(4)]
		public bool YaoGan { get; set; }

		[ProtoMember(5)]
		public long UnitId { get; set; }

	}

	[Message(OuterOpcode.C2M_Stop)]
	[ProtoContract]
	public partial class C2M_Stop: Object, IActorLocationMessage
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

	}

	[Message(OuterOpcode.C2M_StopTest)]
	[ProtoContract]
	public partial class C2M_StopTest: Object, IActorLocationMessage
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

	}

	[Message(OuterOpcode.M2C_PathfindingResult)]
	[ProtoContract]
	public partial class M2C_PathfindingResult: Object, IActorMessage
	{
		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public long Id { get; set; }

		[ProtoMember(2)]
		public float X { get; set; }

		[ProtoMember(3)]
		public float Y { get; set; }

		[ProtoMember(4)]
		public float Z { get; set; }

		[ProtoMember(5)]
		public List<float> Xs = new List<float>();

		[ProtoMember(6)]
		public List<float> Ys = new List<float>();

		[ProtoMember(7)]
		public List<float> Zs = new List<float>();

	}

	[Message(OuterOpcode.M2C_Stop)]
	[ProtoContract]
	public partial class M2C_Stop: Object, IActorMessage
	{
		[ProtoMember(1)]
		public int Error { get; set; }

		[ProtoMember(2)]
		public long Id { get; set; }

		[ProtoMember(3)]
		public float X { get; set; }

		[ProtoMember(4)]
		public float Y { get; set; }

		[ProtoMember(5)]
		public float Z { get; set; }

		[ProtoMember(6)]
		public float A { get; set; }

		[ProtoMember(7)]
		public float B { get; set; }

		[ProtoMember(8)]
		public float C { get; set; }

		[ProtoMember(9)]
		public float W { get; set; }

	}

	[ResponseType(nameof(G2C_Ping))]
	[Message(OuterOpcode.C2G_Ping)]
	[ProtoContract]
	public partial class C2G_Ping: Object, IRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

	}

	[Message(OuterOpcode.G2C_Ping)]
	[ProtoContract]
	public partial class G2C_Ping: Object, IResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

		[ProtoMember(1)]
		public long Time { get; set; }

	}

	[Message(OuterOpcode.G2C_Test)]
	[ProtoContract]
	public partial class G2C_Test: Object, IMessage
	{
	}

	[ResponseType(nameof(M2C_Reload))]
	[Message(OuterOpcode.C2M_Reload)]
	[ProtoContract]
	public partial class C2M_Reload: Object, IRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(1)]
		public string Account { get; set; }

		[ProtoMember(2)]
		public string Password { get; set; }

		[ProtoMember(3)]
		public int LoadType { get; set; }

		[ProtoMember(4)]
		public string LoadValue { get; set; }

	}

	[Message(OuterOpcode.M2C_Reload)]
	[ProtoContract]
	public partial class M2C_Reload: Object, IResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

	}

	[ResponseType(nameof(A2C_LoginAccount))]
	[Message(OuterOpcode.C2A_LoginAccount)]
	[ProtoContract]
	public partial class C2A_LoginAccount: Object, IRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(1)]
		public string AccountName { get; set; }

		[ProtoMember(2)]
		public string Password { get; set; }

		[ProtoMember(3)]
		public string Token { get; set; }

		[ProtoMember(4)]
		public string ThirdLogin { get; set; }

		[ProtoMember(5)]
		public bool Relink { get; set; }

	}

	[Message(OuterOpcode.A2C_LoginAccount)]
	[ProtoContract]
	public partial class A2C_LoginAccount: Object, IResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

		[ProtoMember(1)]
		public string Token { get; set; }

		[ProtoMember(2)]
		public long AccountId { get; set; }

		[ProtoMember(6)]
		public int QueueNumber { get; set; }

		[ProtoMember(7)]
		public string QueueAddres { get; set; }

		[ProtoMember(8)]
		public PlayerInfo PlayerInfo { get; set; }

		[ProtoMember(9)]
		public List<CreateRoleInfo> RoleLists = new List<CreateRoleInfo>();

	}

	[Message(OuterOpcode.A2C_Disconnect)]
	[ProtoContract]
	public partial class A2C_Disconnect: Object, IMessage
	{
		[ProtoMember(1)]
		public int Error { get; set; }

	}

	[Message(OuterOpcode.PlayerInfo)]
	[ProtoContract]
	public partial class PlayerInfo: Object
	{
		[ProtoMember(1)]
		public int RealName { get; set; }

		[ProtoMember(2)]
		public string Name { get; set; }

		[ProtoMember(3)]
		public string IdCardNo { get; set; }

		[ProtoMember(4)]
		public int RealNameReward { get; set; }

		[ProtoMember(5)]
		public List<RechargeInfo> RechargeInfos = new List<RechargeInfo>();

		[ProtoMember(6)]
		public List<KeyValuePair> DeleteUserList = new List<KeyValuePair>();

		[ProtoMember(7)]
		public List<int> BuChangZone = new List<int>();

		[ProtoMember(8)]
		public string PhoneNumber { get; set; }

	}

	[ResponseType(nameof(M2C_TestActorResponse))]
	[Message(OuterOpcode.C2M_TestActorRequest)]
	[ProtoContract]
	public partial class C2M_TestActorRequest: Object, IActorLocationRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public string Info { get; set; }

	}

	[Message(OuterOpcode.M2C_TestActorResponse)]
	[ProtoContract]
	public partial class M2C_TestActorResponse: Object, IActorLocationResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

		[ProtoMember(1)]
		public string Info { get; set; }

	}

	[ResponseType(nameof(G2C_PlayerInfo))]
	[Message(OuterOpcode.C2G_PlayerInfo)]
	[ProtoContract]
	public partial class C2G_PlayerInfo: Object, IRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

	}

	[Message(OuterOpcode.G2C_PlayerInfo)]
	[ProtoContract]
	public partial class G2C_PlayerInfo: Object, IResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

		[ProtoMember(3)]
		public List<string> TestRepeatedString = new List<string>();

		[ProtoMember(4)]
		public List<int> TestRepeatedInt32 = new List<int>();

		[ProtoMember(5)]
		public List<long> TestRepeatedInt64 = new List<long>();

	}

	[Message(OuterOpcode.C2M_Move)]
	[ProtoContract]
	public partial class C2M_Move: Object, IActorLocationMessage
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(94)]
		public long Id { get; set; }

		[ProtoMember(1)]
		public float X { get; set; }

		[ProtoMember(2)]
		public float Y { get; set; }

		[ProtoMember(3)]
		public float Z { get; set; }

	}

	[Message(OuterOpcode.M2C_MoveResult)]
	[ProtoContract]
	public partial class M2C_MoveResult: Object, IActorMessage
	{
		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public long Id { get; set; }

		[ProtoMember(2)]
		public float X { get; set; }

		[ProtoMember(3)]
		public float Y { get; set; }

		[ProtoMember(4)]
		public float Z { get; set; }

	}

	[ResponseType(nameof(G2C_HeartBeat))]
	[Message(OuterOpcode.C2G_HeartBeat)]
	[ProtoContract]
	public partial class C2G_HeartBeat: Object, IRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

	}

	[Message(OuterOpcode.G2C_HeartBeat)]
	[ProtoContract]
	public partial class G2C_HeartBeat: Object, IResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

	}

	[ResponseType(nameof(C2R_TestCall))]
	[Message(OuterOpcode.C2R_TestCall)]
	[ProtoContract]
	public partial class C2R_TestCall: Object, IRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public string Message { get; set; }

	}

	[Message(OuterOpcode.R2C_TestResponse)]
	[ProtoContract]
	public partial class R2C_TestResponse: Object, IResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(92)]
		public int Error { get; set; }

		[ProtoMember(91)]
		public string Message { get; set; }

	}

	[ResponseType(nameof(A2C_Notice))]
	[Message(OuterOpcode.C2A_Notice)]
	[ProtoContract]
	public partial class C2A_Notice: Object, IRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public string Message { get; set; }

	}

	[Message(OuterOpcode.A2C_Notice)]
	[ProtoContract]
	public partial class A2C_Notice: Object, IResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public string Message { get; set; }

		[ProtoMember(92)]
		public int Error { get; set; }

	}

	[ResponseType(nameof(A2C_Thanks))]
	[Message(OuterOpcode.C2A_Thanks)]
	[ProtoContract]
	public partial class C2A_Thanks: Object, IRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public string Message { get; set; }

	}

	[Message(OuterOpcode.A2C_Thanks)]
	[ProtoContract]
	public partial class A2C_Thanks: Object, IResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public string Message { get; set; }

		[ProtoMember(92)]
		public int Error { get; set; }

	}

	[ResponseType(nameof(A2C_ServerList))]
	[Message(OuterOpcode.C2A_ServerList)]
	[ProtoContract]
	public partial class C2A_ServerList: Object, IRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public string Message { get; set; }

	}

	[Message(OuterOpcode.A2C_ServerList)]
	[ProtoContract]
	public partial class A2C_ServerList: Object, IResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public string Message { get; set; }

		[ProtoMember(92)]
		public int Error { get; set; }

		[ProtoMember(1)]
		public List<int> MyServers = new List<int>();

		[ProtoMember(2)]
		public List<ServerItem> ServerItems = new List<ServerItem>();

	}

	[Message(OuterOpcode.ServerItem)]
	[ProtoContract]
	public partial class ServerItem: Object
	{
		[ProtoMember(1)]
		public int ServerId { get; set; }

		[ProtoMember(2)]
		public string ServerIp { get; set; }

		[ProtoMember(3)]
		public string ServerName { get; set; }

		[ProtoMember(4)]
		public long ServerOpenTime { get; set; }

		[ProtoMember(5)]
		public int Show { get; set; }

	}

	[ResponseType(nameof(G2C_CreateRole))]
	[Message(OuterOpcode.C2G_CreateRole)]
	[ProtoContract]
	public partial class C2G_CreateRole: Object, IRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(2)]
		public string RoleName { get; set; }

	}

	[Message(OuterOpcode.G2C_CreateRole)]
	[ProtoContract]
	public partial class G2C_CreateRole: Object, IResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

		[ProtoMember(1)]
		public string RoleName { get; set; }

		[ProtoMember(2)]
		public int RoleLv { get; set; }

		[ProtoMember(3)]
		public long RoleLvExp { get; set; }

		[ProtoMember(4)]
		public long Money { get; set; }

	}

	[Message(OuterOpcode.M2C_PetDataUpdate)]
	[ProtoContract]
	public partial class M2C_PetDataUpdate: Object, IActorMessage
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

		[ProtoMember(1)]
		public long PetId { get; set; }

		[ProtoMember(2)]
		public int UpdateType { get; set; }

		[ProtoMember(3)]
		public string UpdateTypeValue { get; set; }

	}

	[Message(OuterOpcode.M2C_PetDataBroadcast)]
	[ProtoContract]
	public partial class M2C_PetDataBroadcast: Object, IActorMessage
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

		[ProtoMember(1)]
		public long PetId { get; set; }

		[ProtoMember(2)]
		public int UpdateType { get; set; }

		[ProtoMember(3)]
		public string UpdateTypeValue { get; set; }

		[ProtoMember(4)]
		public long UnitId { get; set; }

	}

	[Message(OuterOpcode.M2C_RoleDataUpdate)]
	[ProtoContract]
	public partial class M2C_RoleDataUpdate: Object, IActorMessage
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

		[ProtoMember(1)]
		public int UpdateType { get; set; }

		[ProtoMember(2)]
		public string UpdateTypeValue { get; set; }

	}

	[Message(OuterOpcode.M2C_RoleDataBroadcast)]
	[ProtoContract]
	public partial class M2C_RoleDataBroadcast: Object, IActorMessage
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

		[ProtoMember(1)]
		public int UpdateType { get; set; }

		[ProtoMember(2)]
		public string UpdateTypeValue { get; set; }

		[ProtoMember(3)]
		public long UnitId { get; set; }

	}

	[Message(OuterOpcode.BagInfo)]
	[ProtoContract]
	public partial class BagInfo: Object
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public string Name { get; set; }

		[ProtoMember(1)]
		public long BagInfoID { get; set; }

		[ProtoMember(2)]
		public int ItemID { get; set; }

		[ProtoMember(3)]
		public int ItemNum { get; set; }

		[ProtoMember(4)]
		public string ItemPar { get; set; }

		[ProtoMember(5)]
		public int HideID { get; set; }

		[ProtoMember(6)]
		public string GemHole { get; set; }

		[ProtoMember(8)]
		public int Loc { get; set; }

		[ProtoMember(9)]
		public bool IfJianDing { get; set; }

		[ProtoMember(10)]
		public List<HideProList> HideProLists = new List<HideProList>();

		[ProtoMember(11)]
		public List<HideProList> XiLianHideProLists = new List<HideProList>();

		[ProtoMember(12)]
		public List<int> HideSkillLists = new List<int>();

		[ProtoMember(13)]
		public bool isBinging { get; set; }

		[ProtoMember(14)]
		public List<HideProList> XiLianHideTeShuProLists = new List<HideProList>();

		[ProtoMember(16)]
		public string GetWay { get; set; }

		[ProtoMember(17)]
		public string GemIDNew { get; set; }

		[ProtoMember(18)]
		public string MakePlayer { get; set; }

		[ProtoMember(20)]
		public List<HideProList> FumoProLists = new List<HideProList>();

	}

	[Message(OuterOpcode.HideProList)]
	[ProtoContract]
	public partial class HideProList: Object
	{
		[ProtoMember(1)]
		public int HideID { get; set; }

		[ProtoMember(2)]
		public long HideValue { get; set; }

	}

	[ResponseType(nameof(M2C_GetHeroDataResponse))]
	[Message(OuterOpcode.C2M_GetHeroDataRequest)]
	[ProtoContract]
	public partial class C2M_GetHeroDataRequest: Object, IActorLocationRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public long ActorId { get; set; }

//unit的ID
		[ProtoMember(1)]
		public long unitID { get; set; }

	}

	[Message(OuterOpcode.M2C_GetHeroDataResponse)]
	[ProtoContract]
	public partial class M2C_GetHeroDataResponse: Object, IActorLocationResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public long heroDataID { get; set; }

		[ProtoMember(94)]
		public string Message { get; set; }

	}

	[ResponseType(nameof(M2C_SkillCmd))]
	[Message(OuterOpcode.C2M_SkillCmd)]
	[ProtoContract]
	public partial class C2M_SkillCmd: Object, IActorLocationRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public int SkillID { get; set; }

		[ProtoMember(2)]
		public long TargetID { get; set; }

		[ProtoMember(3)]
		public int TargetAngle { get; set; }

		[ProtoMember(4)]
		public float TargetDistance { get; set; }

		[ProtoMember(5)]
		public int WeaponSkillID { get; set; }

		[ProtoMember(6)]
		public int ItemId { get; set; }

	}

	[Message(OuterOpcode.M2C_SkillCmd)]
	[ProtoContract]
	public partial class M2C_SkillCmd: Object, IActorLocationResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

		[ProtoMember(1)]
		public long CDEndTime { get; set; }

		[ProtoMember(2)]
		public long PublicCDTime { get; set; }

	}

	[Message(OuterOpcode.M2C_UnitUseSkill)]
	[ProtoContract]
	public partial class M2C_UnitUseSkill: Object, IActorMessage
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(94)]
		public long UnitId { get; set; }

		[ProtoMember(1)]
		public int SkillID { get; set; }

		[ProtoMember(3)]
		public int TargetAngle { get; set; }

		[ProtoMember(4)]
		public List<SkillInfo> SkillInfos = new List<SkillInfo>();

		[ProtoMember(6)]
		public int ItemId { get; set; }

		[ProtoMember(7)]
		public long CDEndTime { get; set; }

		[ProtoMember(8)]
		public long PublicCDTime { get; set; }

	}

//闪电链
	[Message(OuterOpcode.M2C_ChainLightning)]
	[ProtoContract]
	public partial class M2C_ChainLightning: Object, IActorMessage
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public long UnitId { get; set; }

		[ProtoMember(2)]
		public long TargetID { get; set; }

		[ProtoMember(3)]
		public int SkillID { get; set; }

		[ProtoMember(6)]
		public float PosX { get; set; }

		[ProtoMember(7)]
		public float PosY { get; set; }

		[ProtoMember(8)]
		public float PosZ { get; set; }

	}

	[Message(OuterOpcode.SkillInfo)]
	[ProtoContract]
	public partial class SkillInfo: Object
	{
		[ProtoMember(2)]
		public long TargetID { get; set; }

		[ProtoMember(3)]
		public int TargetAngle { get; set; }

		[ProtoMember(5)]
		public int WeaponSkillID { get; set; }

		[ProtoMember(6)]
		public float PosX { get; set; }

		[ProtoMember(7)]
		public float PosY { get; set; }

		[ProtoMember(8)]
		public float PosZ { get; set; }

		[ProtoMember(11)]
		public long SkillBeginTime { get; set; }

		[ProtoMember(12)]
		public long SkillEndTime { get; set; }

	}

	[Message(OuterOpcode.C2M_CreateSpiling)]
	[ProtoContract]
	public partial class C2M_CreateSpiling: Object, IActorLocationMessage
	{
		[ProtoMember(2)]
		public float X { get; set; }

		[ProtoMember(3)]
		public float Y { get; set; }

		[ProtoMember(4)]
		public float Z { get; set; }

//所归属的父实体id
		[ProtoMember(5)]
		public long ParentUnitId { get; set; }

		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(94)]
		public long Id { get; set; }

	}

//创建木桩
	[Message(OuterOpcode.M2C_CreateSpilings)]
	[ProtoContract]
	public partial class M2C_CreateSpilings: Object, IActorMessage
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public List<SpilingInfo> Spilings = new List<SpilingInfo>();

	}

	[Message(OuterOpcode.SpilingInfo)]
	[ProtoContract]
	public partial class SpilingInfo: Object
	{
		[ProtoMember(1)]
		public long UnitId { get; set; }

		[ProtoMember(2)]
		public float X { get; set; }

		[ProtoMember(3)]
		public float Y { get; set; }

		[ProtoMember(4)]
		public float Z { get; set; }

		[ProtoMember(5)]
		public List<int> Ks = new List<int>();

		[ProtoMember(6)]
		public List<long> Vs = new List<long>();

		[ProtoMember(8)]
		public int RoleCamp { get; set; }

		[ProtoMember(9)]
		public int MonsterID { get; set; }

		[ProtoMember(10)]
		public int SkillId { get; set; }

		[ProtoMember(11)]
		public long ReviveTime { get; set; }

		[ProtoMember(12)]
		public float ForwardX { get; set; }

		[ProtoMember(13)]
		public float ForwardY { get; set; }

		[ProtoMember(14)]
		public float ForwardZ { get; set; }

		[ProtoMember(19)]
		public List<KeyValuePair> Buffs = new List<KeyValuePair>();

		[ProtoMember(20)]
		public List<SkillInfo> Skills = new List<SkillInfo>();

	}

	[Message(OuterOpcode.M2C_UnitNumericUpdate)]
	[ProtoContract]
	public partial class M2C_UnitNumericUpdate: Object, IActorMessage
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(94)]
		public long UnitId { get; set; }

		[ProtoMember(1)]
		public int SkillId { get; set; }

		[ProtoMember(2)]
		public int NumericType { get; set; }

		[ProtoMember(3)]
		public long OldValue { get; set; }

		[ProtoMember(4)]
		public long NewValue { get; set; }

		[ProtoMember(5)]
		public int DamgeType { get; set; }

	}

	[Message(OuterOpcode.M2C_SyncUnitPos)]
	[ProtoContract]
	public partial class M2C_SyncUnitPos: Object, IActorMessage
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(94)]
		public long UnitId { get; set; }

		[ProtoMember(2)]
		public float PosX { get; set; }

		[ProtoMember(3)]
		public float PosY { get; set; }

		[ProtoMember(4)]
		public float PosZ { get; set; }

	}

	[Message(OuterOpcode.M2C_CreateDropItems)]
	[ProtoContract]
	public partial class M2C_CreateDropItems: Object, IActorMessage
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(94)]
		public long UnitId { get; set; }

		[ProtoMember(1)]
		public List<DropInfo> Drops = new List<DropInfo>();

	}

	[Message(OuterOpcode.DropInfo)]
	[ProtoContract]
	public partial class DropInfo: Object
	{
		[ProtoMember(1)]
		public long UnitId { get; set; }

		[ProtoMember(3)]
		public int ItemID { get; set; }

		[ProtoMember(4)]
		public int ItemNum { get; set; }

		[ProtoMember(5)]
		public float X { get; set; }

		[ProtoMember(6)]
		public float Y { get; set; }

		[ProtoMember(7)]
		public float Z { get; set; }

		[ProtoMember(8)]
		public int DropType { get; set; }

	}

	[Message(OuterOpcode.TransferInfo)]
	[ProtoContract]
	public partial class TransferInfo: Object
	{
		[ProtoMember(1)]
		public long UnitId { get; set; }

		[ProtoMember(2)]
		public int Direction { get; set; }

		[ProtoMember(3)]
		public int CellIndex { get; set; }

		[ProtoMember(5)]
		public float X { get; set; }

		[ProtoMember(6)]
		public float Y { get; set; }

		[ProtoMember(7)]
		public float Z { get; set; }

		[ProtoMember(8)]
		public int TransferId { get; set; }

	}

	[Message(OuterOpcode.NpcInfo)]
	[ProtoContract]
	public partial class NpcInfo: Object
	{
		[ProtoMember(1)]
		public long UnitId { get; set; }

		[ProtoMember(2)]
		public int NpcID { get; set; }

		[ProtoMember(5)]
		public float X { get; set; }

		[ProtoMember(6)]
		public float Y { get; set; }

		[ProtoMember(7)]
		public float Z { get; set; }

	}

	[Message(OuterOpcode.M2C_CancelAttack)]
	[ProtoContract]
	public partial class M2C_CancelAttack: Object, IActorMessage
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(94)]
		public long UnitId { get; set; }

	}

	[ResponseType(nameof(M2C_TestRobotCase))]
	[Message(OuterOpcode.C2M_TestRobotCase)]
	[ProtoContract]
	public partial class C2M_TestRobotCase: Object, IActorLocationRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public int N { get; set; }

	}

	[Message(OuterOpcode.M2C_TestRobotCase)]
	[ProtoContract]
	public partial class M2C_TestRobotCase: Object, IActorLocationResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

		[ProtoMember(1)]
		public int N { get; set; }

	}

	[ResponseType(nameof(M2C_TransferMap))]
	[Message(OuterOpcode.C2M_TransferMap)]
	[ProtoContract]
	public partial class C2M_TransferMap: Object, IActorLocationRequest
	{
		[ProtoMember(1)]
		public int RpcId { get; set; }

	}

	[Message(OuterOpcode.M2C_TransferMap)]
	[ProtoContract]
	public partial class M2C_TransferMap: Object, IActorLocationResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

	}

	[Message(OuterOpcode.C2M_UnitStateUpdate)]
	[ProtoContract]
	public partial class C2M_UnitStateUpdate: Object, IActorLocationMessage
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(2)]
		public long StateType { get; set; }

		[ProtoMember(3)]
		public int StateOperateType { get; set; }

		[ProtoMember(4)]
		public int StateTime { get; set; }

		[ProtoMember(5)]
		public string StateValue { get; set; }

	}

	[Message(OuterOpcode.M2C_UnitStateUpdate)]
	[ProtoContract]
	public partial class M2C_UnitStateUpdate: Object, IActorMessage
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public long UnitId { get; set; }

		[ProtoMember(2)]
		public long StateType { get; set; }

		[ProtoMember(3)]
		public int StateOperateType { get; set; }

		[ProtoMember(4)]
		public int StateTime { get; set; }

		[ProtoMember(5)]
		public string StateValue { get; set; }

	}

//message M2C_BuffInfo // IActorMessage
//{
//    int32 RpcId = 90;
//    int64 ActorId = 93;
//    int64 UnitId = 1; //要发送到的目标UnitId
//    int64 SkillId = 96; //目标技能Id
//    string BBKey = 2; //黑板键，此键对应值将会被设置为Buff层数
//    int64 TheUnitBelongToId = 95; //Buff归属的UnitId
//    int64 TheUnitFromId = 91; //Buff来自的UnitId
//    int32 BuffLayers = 3; //Buff层数
//    float BuffMaxLimitTime = 4; //Buff最大持续到的时间点
//}
	[Message(OuterOpcode.UnitBuffInfo)]
	[ProtoContract]
	public partial class UnitBuffInfo: Object
	{
		[ProtoMember(1)]
		public int BuffID { get; set; }

		[ProtoMember(2)]
		public long UnitIdBelongTo { get; set; }

		[ProtoMember(4)]
		public int BuffOperateType { get; set; }

		[ProtoMember(5)]
		public List<float> TargetPostion = new List<float>();

		[ProtoMember(6)]
		public long BuffEndTime { get; set; }

		[ProtoMember(7)]
		public string Spellcaster { get; set; }

		[ProtoMember(8)]
		public int UnitType { get; set; }

		[ProtoMember(9)]
		public int UnitConfigId { get; set; }

		[ProtoMember(10)]
		public int SkillId { get; set; }

	}

	[Message(OuterOpcode.M2C_UnitBuffUpdate)]
	[ProtoContract]
	public partial class M2C_UnitBuffUpdate: Object, IActorMessage
	{
		[ProtoMember(1)]
		public int BuffID { get; set; }

		[ProtoMember(2)]
		public long UnitIdBelongTo { get; set; }

		[ProtoMember(4)]
		public int BuffOperateType { get; set; }

		[ProtoMember(5)]
		public List<float> TargetPostion = new List<float>();

		[ProtoMember(6)]
		public long BuffEndTime { get; set; }

		[ProtoMember(7)]
		public string Spellcaster { get; set; }

		[ProtoMember(8)]
		public int UnitType { get; set; }

		[ProtoMember(9)]
		public int UnitConfigId { get; set; }

		[ProtoMember(10)]
		public int SkillId { get; set; }

	}

	[Message(OuterOpcode.M2C_UnitBuffRemove)]
	[ProtoContract]
	public partial class M2C_UnitBuffRemove: Object, IActorMessage
	{
		[ProtoMember(1)]
		public int BuffID { get; set; }

		[ProtoMember(2)]
		public long UnitIdBelongTo { get; set; }

	}

	[ResponseType(nameof(G2C_OffLine))]
	[Message(OuterOpcode.C2G_OffLine)]
	[ProtoContract]
	public partial class C2G_OffLine: Object, IRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int unitId { get; set; }

	}

	[Message(OuterOpcode.G2C_OffLine)]
	[ProtoContract]
	public partial class G2C_OffLine: Object, IResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

	}

	[ResponseType(nameof(D2C_Test))]
	[Message(OuterOpcode.C2D_Test)]
	[ProtoContract]
	public partial class C2D_Test: Object, IDBCacheActorRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public string TestMsg { get; set; }

	}

	[Message(OuterOpcode.D2C_Test)]
	[ProtoContract]
	public partial class D2C_Test: Object, IDBCacheActorResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

	}

	[Message(OuterOpcode.C2M_GMCommandRequest)]
	[ProtoContract]
	public partial class C2M_GMCommandRequest: Object, IActorLocationMessage
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public string GMMsg { get; set; }

		[ProtoMember(2)]
		public string Account { get; set; }

	}

	[ResponseType(nameof(C2C_SendChatResponse))]
	[Message(OuterOpcode.C2C_SendChatRequest)]
	[ProtoContract]
	public partial class C2C_SendChatRequest: Object, IChatActorRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public ChatInfo ChatInfo { get; set; }

	}

	[Message(OuterOpcode.C2C_SendChatResponse)]
	[ProtoContract]
	public partial class C2C_SendChatResponse: Object, IChatActorResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

		[ProtoMember(1)]
		public string ChatMsg { get; set; }

		[ProtoMember(2)]
		public int ChannelId { get; set; }

	}

	[Message(OuterOpcode.ChatInfo)]
	[ProtoContract]
	public partial class ChatInfo: Object
	{
		[ProtoMember(1)]
		public long UserId { get; set; }

		[ProtoMember(3)]
		public string ChatMsg { get; set; }

		[ProtoMember(4)]
		public string PlayerName { get; set; }

		[ProtoMember(2)]
		public int ChannelId { get; set; }

		[ProtoMember(5)]
		public long ParamId { get; set; }

		[ProtoMember(6)]
		public long Time { get; set; }

		[ProtoMember(7)]
		public int Occ { get; set; }

		[ProtoMember(8)]
		public int PlayerLevel { get; set; }

	}

	[Message(OuterOpcode.M2C_SyncChatInfo)]
	[ProtoContract]
	public partial class M2C_SyncChatInfo: Object, IActorMessage
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public ChatInfo ChatInfo { get; set; }

	}

	[ResponseType(nameof(M2C_RechargeResponse))]
	[Message(OuterOpcode.C2M_RechargeRequest)]
	[ProtoContract]
	public partial class C2M_RechargeRequest: Object, IActorLocationRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(1)]
		public int RechargeNumber { get; set; }

		[ProtoMember(2)]
		public long PayType { get; set; }

	}

	[Message(OuterOpcode.M2C_RechargeResponse)]
	[ProtoContract]
	public partial class M2C_RechargeResponse: Object, IActorLocationResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

	}

	[Message(OuterOpcode.M2C_HorseNoticeInfo)]
	[ProtoContract]
	public partial class M2C_HorseNoticeInfo: Object, IActorMessage
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public string NoticeText { get; set; }

		[ProtoMember(2)]
		public int NoticeType { get; set; }

	}

//物品排序[通知服务器排序，暂时不需要返回]
	[Message(OuterOpcode.C2M_ItemSortRequest)]
	[ProtoContract]
	public partial class C2M_ItemSortRequest: Object, IActorLocationMessage
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

	}

	[ResponseType(nameof(M2C_ItemHuiShouResponse))]
//回收装备
	[Message(OuterOpcode.C2M_ItemHuiShouRequest)]
	[ProtoContract]
	public partial class C2M_ItemHuiShouRequest: Object, IActorLocationRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(2)]
		public List<long> OperateBagID = new List<long>();

	}

	[Message(OuterOpcode.M2C_ItemHuiShouResponse)]
	[ProtoContract]
	public partial class M2C_ItemHuiShouResponse: Object, IActorLocationResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public string Message { get; set; }

		[ProtoMember(92)]
		public int Error { get; set; }

	}

	[ResponseType(nameof(M2C_ItemMeltingResponse))]
//装备熔炼
	[Message(OuterOpcode.C2M_ItemMeltingRequest)]
	[ProtoContract]
	public partial class C2M_ItemMeltingRequest: Object, IActorLocationRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(2)]
		public List<long> OperateBagID = new List<long>();

		[ProtoMember(3)]
		public int MakeType { get; set; }

	}

	[Message(OuterOpcode.M2C_ItemMeltingResponse)]
	[ProtoContract]
	public partial class M2C_ItemMeltingResponse: Object, IActorLocationResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public string Message { get; set; }

		[ProtoMember(92)]
		public int Error { get; set; }

	}

	[ResponseType(nameof(M2C_ItemQiangHuaResponse))]
//强化槽位
	[Message(OuterOpcode.C2M_ItemQiangHuaRequest)]
	[ProtoContract]
	public partial class C2M_ItemQiangHuaRequest: Object, IActorLocationRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(1)]
		public int WeiZhi { get; set; }

	}

	[Message(OuterOpcode.M2C_ItemQiangHuaResponse)]
	[ProtoContract]
	public partial class M2C_ItemQiangHuaResponse: Object, IActorLocationResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public string Message { get; set; }

		[ProtoMember(92)]
		public int Error { get; set; }

		[ProtoMember(1)]
		public int QiangHuaLevel { get; set; }

	}

	[ResponseType(nameof(M2C_ItemXiLianResponse))]
//洗练装备
	[Message(OuterOpcode.C2M_ItemXiLianRequest)]
	[ProtoContract]
	public partial class C2M_ItemXiLianRequest: Object, IActorLocationRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(2)]
		public long OperateBagID { get; set; }

		[ProtoMember(1)]
		public int Times { get; set; }

	}

	[Message(OuterOpcode.M2C_ItemXiLianResponse)]
	[ProtoContract]
	public partial class M2C_ItemXiLianResponse: Object, IActorLocationResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public string Message { get; set; }

		[ProtoMember(92)]
		public int Error { get; set; }

		[ProtoMember(1)]
		public List<ItemXiLianResult> ItemXiLianResults = new List<ItemXiLianResult>();

	}

	[ResponseType(nameof(M2C_ItemOperateResponse))]
//穿戴装备
	[Message(OuterOpcode.C2M_ItemOperateRequest)]
	[ProtoContract]
	public partial class C2M_ItemOperateRequest: Object, IActorLocationRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(1)]
		public int OperateType { get; set; }

		[ProtoMember(2)]
		public long OperateBagID { get; set; }

		[ProtoMember(3)]
		public string OperatePar { get; set; }

	}

	[Message(OuterOpcode.M2C_ItemOperateResponse)]
	[ProtoContract]
	public partial class M2C_ItemOperateResponse: Object, IActorLocationResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public string Message { get; set; }

		[ProtoMember(92)]
		public int Error { get; set; }

		[ProtoMember(1)]
		public string OperatePar { get; set; }

	}

//道具[装备]更新
	[Message(OuterOpcode.M2C_RoleBagUpdate)]
	[ProtoContract]
	public partial class M2C_RoleBagUpdate: Object, IActorMessage
	{
		[ProtoMember(1)]
		public List<BagInfo> BagInfoAdd = new List<BagInfo>();

		[ProtoMember(2)]
		public List<BagInfo> BagInfoUpdate = new List<BagInfo>();

		[ProtoMember(3)]
		public List<BagInfo> BagInfoDelete = new List<BagInfo>();

	}

	[ResponseType(nameof(Actor_FubenEnergySkillResponse))]
	[Message(OuterOpcode.Actor_FubenEnergySkillRequest)]
	[ProtoContract]
	public partial class Actor_FubenEnergySkillRequest: Object, IActorLocationRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public int SkillId { get; set; }

	}

	[Message(OuterOpcode.Actor_FubenEnergySkillResponse)]
	[ProtoContract]
	public partial class Actor_FubenEnergySkillResponse: Object, IActorLocationResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

	}

	[ResponseType(nameof(Actor_EnterFubenResponse))]
	[Message(OuterOpcode.Actor_EnterFubenRequest)]
	[ProtoContract]
	public partial class Actor_EnterFubenRequest: Object, IActorLocationRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public int ChapterId { get; set; }

		[ProtoMember(2)]
		public int Difficulty { get; set; }

		[ProtoMember(3)]
		public int RepeatEnter { get; set; }

	}

	[Message(OuterOpcode.Actor_EnterFubenResponse)]
	[ProtoContract]
	public partial class Actor_EnterFubenResponse: Object, IActorLocationResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

		[ProtoMember(1)]
		public FubenInfo FubenInfo { get; set; }

		[ProtoMember(2)]
		public SonFubenInfo SonFubenInfo { get; set; }

	}

	[Message(OuterOpcode.FubenInfo)]
	[ProtoContract]
	public partial class FubenInfo: Object
	{
		[ProtoMember(2)]
		public int StartCell { get; set; }

		[ProtoMember(3)]
		public int EndCell { get; set; }

		[ProtoMember(4)]
		public List<KeyValuePair> FubenCellNpcs = new List<KeyValuePair>();

	}

	[Message(OuterOpcode.SonFubenInfo)]
	[ProtoContract]
	public partial class SonFubenInfo: Object
	{
		[ProtoMember(1)]
		public int SonSceneId { get; set; }

		[ProtoMember(2)]
		public int CurrentCell { get; set; }

		[ProtoMember(3)]
		public List<int> PassableFlag = new List<int>();

	}

	[Message(OuterOpcode.FubenPassInfo)]
	[ProtoContract]
	public partial class FubenPassInfo: Object
	{
		[ProtoMember(1)]
		public int FubenId { get; set; }

		[ProtoMember(2)]
		public int Difficulty { get; set; }

	}

	[ResponseType(nameof(Actor_GetFubenInfoResponse))]
	[Message(OuterOpcode.Actor_GetFubenInfoRequest)]
	[ProtoContract]
	public partial class Actor_GetFubenInfoRequest: Object, IActorLocationRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

	}

	[Message(OuterOpcode.Actor_GetFubenInfoResponse)]
	[ProtoContract]
	public partial class Actor_GetFubenInfoResponse: Object, IActorLocationResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

		[ProtoMember(1)]
		public List<FubenPassInfo> FubenPassInfos = new List<FubenPassInfo>();

	}

	[ResponseType(nameof(Actor_EnterSonFubenResponse))]
	[Message(OuterOpcode.Actor_EnterSonFubenRequest)]
	[ProtoContract]
	public partial class Actor_EnterSonFubenRequest: Object, IActorLocationRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(2)]
		public int CurrentCell { get; set; }

		[ProtoMember(3)]
		public int DirectionType { get; set; }

		[ProtoMember(4)]
		public int ChuansongId { get; set; }

	}

	[Message(OuterOpcode.Actor_EnterSonFubenResponse)]
	[ProtoContract]
	public partial class Actor_EnterSonFubenResponse: Object, IActorLocationResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

		[ProtoMember(1)]
		public SonFubenInfo SonFubenInfo { get; set; }

	}

	[ResponseType(nameof(Actor_QuitFubenResponse))]
	[Message(OuterOpcode.Actor_QuitFubenRequest)]
	[ProtoContract]
	public partial class Actor_QuitFubenRequest: Object, IActorLocationRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public int MapIndex { get; set; }

	}

	[Message(OuterOpcode.Actor_QuitFubenResponse)]
	[ProtoContract]
	public partial class Actor_QuitFubenResponse: Object, IActorLocationResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

	}

	[ResponseType(nameof(Actor_SendReviveResponse))]
	[Message(OuterOpcode.Actor_SendReviveRequest)]
	[ProtoContract]
	public partial class Actor_SendReviveRequest: Object, IActorLocationRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public int MapIndex { get; set; }

	}

	[Message(OuterOpcode.Actor_SendReviveResponse)]
	[ProtoContract]
	public partial class Actor_SendReviveResponse: Object, IActorLocationResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

	}

	[Message(OuterOpcode.M2C_FubenSettlement)]
	[ProtoContract]
	public partial class M2C_FubenSettlement: Object, IActorMessage
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(92)]
		public int Error { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public int BattleResult { get; set; }

		[ProtoMember(2)]
		public int BattleGrade { get; set; }

		[ProtoMember(3)]
		public int RewardExp { get; set; }

		[ProtoMember(4)]
		public int RewardGold { get; set; }

		[ProtoMember(5)]
		public List<RewardItem> ReardList = new List<RewardItem>();

		[ProtoMember(6)]
		public List<RewardItem> ReardListExcess = new List<RewardItem>();

		[ProtoMember(7)]
		public List<int> StarInfos = new List<int>();

	}

	[ResponseType(nameof(Actor_GetFubenRewardReponse))]
	[Message(OuterOpcode.Actor_GetFubenRewardRequest)]
	[ProtoContract]
	public partial class Actor_GetFubenRewardRequest: Object, IActorLocationRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(1)]
		public RewardItem RewardItem { get; set; }

	}

	[Message(OuterOpcode.Actor_GetFubenRewardReponse)]
	[ProtoContract]
	public partial class Actor_GetFubenRewardReponse: Object, IActorLocationResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public string Message { get; set; }

		[ProtoMember(92)]
		public int Error { get; set; }

	}

	[ResponseType(nameof(Actor_PickItemResponse))]
	[Message(OuterOpcode.Actor_PickItemRequest)]
	[ProtoContract]
	public partial class Actor_PickItemRequest: Object, IActorLocationRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public List<DropInfo> ItemIds = new List<DropInfo>();

	}

	[Message(OuterOpcode.Actor_PickItemResponse)]
	[ProtoContract]
	public partial class Actor_PickItemResponse: Object, IActorLocationResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

	}

	[ResponseType(nameof(Actor_ItemInitResponse))]
	[Message(OuterOpcode.Actor_ItemInitRequest)]
	[ProtoContract]
	public partial class Actor_ItemInitRequest: Object, IActorLocationRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

	}

	[Message(OuterOpcode.Actor_ItemInitResponse)]
	[ProtoContract]
	public partial class Actor_ItemInitResponse: Object, IActorLocationResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public string Message { get; set; }

		[ProtoMember(92)]
		public int Error { get; set; }

		[ProtoMember(1)]
		public List<BagInfo> BagInfos = new List<BagInfo>();

		[ProtoMember(2)]
		public List<int> QiangHuaLevel = new List<int>();

		[ProtoMember(3)]
		public List<int> QiangHuaFails = new List<int>();

		[ProtoMember(4)]
		public int BagAddedCell { get; set; }

		[ProtoMember(5)]
		public List<int> WarehouseAddedCell = new List<int>();

	}

//活跃宝箱
	[ResponseType(nameof(M2C_TaskHuoYueRewardResponse))]
	[Message(OuterOpcode.C2M_TaskHuoYueRewardRequest)]
	[ProtoContract]
	public partial class C2M_TaskHuoYueRewardRequest: Object, IActorLocationRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(1)]
		public int HuoYueId { get; set; }

	}

	[Message(OuterOpcode.M2C_TaskHuoYueRewardResponse)]
	[ProtoContract]
	public partial class M2C_TaskHuoYueRewardResponse: Object, IActorLocationResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

	}

//每日活跃
	[ResponseType(nameof(M2C_TaskCountryInitResponse))]
	[Message(OuterOpcode.C2M_TaskCountryInitRequest)]
	[ProtoContract]
	public partial class C2M_TaskCountryInitRequest: Object, IActorLocationRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

	}

	[Message(OuterOpcode.M2C_TaskCountryInitResponse)]
	[ProtoContract]
	public partial class M2C_TaskCountryInitResponse: Object, IActorLocationResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

		[ProtoMember(1)]
		public List<TaskPro> TaskCountryList = new List<TaskPro>();

		[ProtoMember(2)]
		public List<int> ReceiveHuoYueIds = new List<int>();

	}

//提交任务
	[ResponseType(nameof(M2C_CommitTaskCountryResponse))]
	[Message(OuterOpcode.C2M_CommitTaskCountryRequest)]
	[ProtoContract]
	public partial class C2M_CommitTaskCountryRequest: Object, IActorLocationRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(1)]
		public int TaskId { get; set; }

	}

	[Message(OuterOpcode.M2C_CommitTaskCountryResponse)]
	[ProtoContract]
	public partial class M2C_CommitTaskCountryResponse: Object, IActorLocationResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

	}

	[Message(OuterOpcode.M2C_TaskCountryUpdate)]
	[ProtoContract]
	public partial class M2C_TaskCountryUpdate: Object, IActorMessage
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(92)]
		public int Error { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public int UpdateMode { get; set; }

		[ProtoMember(2)]
		public List<TaskPro> TaskCountryList = new List<TaskPro>();

	}

//任务列表
	[ResponseType(nameof(M2C_TaskInitResponse))]
	[Message(OuterOpcode.C2M_TaskInitRequest)]
	[ProtoContract]
	public partial class C2M_TaskInitRequest: Object, IActorLocationRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

	}

	[Message(OuterOpcode.M2C_TaskInitResponse)]
	[ProtoContract]
	public partial class M2C_TaskInitResponse: Object, IActorLocationResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

		[ProtoMember(1)]
		public List<TaskPro> RoleTaskList = new List<TaskPro>();

		[ProtoMember(2)]
		public List<int> RoleComoleteTaskList = new List<int>();

		[ProtoMember(3)]
		public List<TaskPro> TaskCountryList = new List<TaskPro>();

		[ProtoMember(4)]
		public List<int> ReceiveHuoYueIds = new List<int>();

		[ProtoMember(5)]
		public List<TaskPro> CampTaskList = new List<TaskPro>();

	}

//接取任务
	[ResponseType(nameof(M2C_TaskGetResponse))]
	[Message(OuterOpcode.C2M_TaskGetRequest)]
	[ProtoContract]
	public partial class C2M_TaskGetRequest: Object, IActorLocationRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(1)]
		public int TaskId { get; set; }

		[ProtoMember(2)]
		public int TaskStatus { get; set; }

	}

	[Message(OuterOpcode.M2C_TaskGetResponse)]
	[ProtoContract]
	public partial class M2C_TaskGetResponse: Object, IActorLocationResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

		[ProtoMember(1)]
		public TaskPro TaskPro { get; set; }

	}

//放弃任务
	[ResponseType(nameof(M2C_TaskGiveUpResponse))]
	[Message(OuterOpcode.C2M_TaskGiveUpRequest)]
	[ProtoContract]
	public partial class C2M_TaskGiveUpRequest: Object, IActorLocationRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(1)]
		public int TaskId { get; set; }

	}

	[Message(OuterOpcode.M2C_TaskGiveUpResponse)]
	[ProtoContract]
	public partial class M2C_TaskGiveUpResponse: Object, IActorLocationResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

	}

//任务追踪
	[ResponseType(nameof(M2C_TaskTrackResponse))]
	[Message(OuterOpcode.C2M_TaskTrackRequest)]
	[ProtoContract]
	public partial class C2M_TaskTrackRequest: Object, IActorLocationRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(1)]
		public int TaskId { get; set; }

		[ProtoMember(2)]
		public int TrackStatus { get; set; }

	}

	[Message(OuterOpcode.M2C_TaskTrackResponse)]
	[ProtoContract]
	public partial class M2C_TaskTrackResponse: Object, IActorLocationResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

	}

//任务通知【目前用于对话完成】
	[ResponseType(nameof(M2C_TaskNoticeResponse))]
	[Message(OuterOpcode.C2M_TaskNoticeRequest)]
	[ProtoContract]
	public partial class C2M_TaskNoticeRequest: Object, IActorLocationRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(1)]
		public int TaskId { get; set; }

		[ProtoMember(2)]
		public int TaskStatus { get; set; }

	}

	[Message(OuterOpcode.M2C_TaskNoticeResponse)]
	[ProtoContract]
	public partial class M2C_TaskNoticeResponse: Object, IActorLocationResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

	}

//提交任务
	[ResponseType(nameof(M2C_TaskCommitResponse))]
	[Message(OuterOpcode.C2M_TaskCommitRequest)]
	[ProtoContract]
	public partial class C2M_TaskCommitRequest: Object, IActorLocationRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(1)]
		public int TaskId { get; set; }

		[ProtoMember(2)]
		public int TaskStatus { get; set; }

	}

	[Message(OuterOpcode.M2C_TaskCommitResponse)]
	[ProtoContract]
	public partial class M2C_TaskCommitResponse: Object, IActorLocationResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

		[ProtoMember(1)]
		public List<int> RoleComoleteTaskList = new List<int>();

	}

	[Message(OuterOpcode.M2C_TaskUpdate)]
	[ProtoContract]
	public partial class M2C_TaskUpdate: Object, IActorMessage
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(92)]
		public int Error { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public List<TaskPro> RoleTaskList = new List<TaskPro>();

		[ProtoMember(2)]
		public List<TaskPro> DayTaskList = new List<TaskPro>();

	}

//任务列表
	[Message(OuterOpcode.TaskPro)]
	[ProtoContract]
	public partial class TaskPro: Object
	{
		[ProtoMember(1)]
		public int taskID { get; set; }

		[ProtoMember(2)]
		public int taskTargetNum_1 { get; set; }

		[ProtoMember(5)]
		public int taskTargetNum_2 { get; set; }

		[ProtoMember(6)]
		public int taskTargetNum_3 { get; set; }

		[ProtoMember(3)]
		public int taskStatus { get; set; }

		[ProtoMember(4)]
		public int TrackStatus { get; set; }

		[ProtoMember(7)]
		public int FubenId { get; set; }

		[ProtoMember(8)]
		public int WaveId { get; set; }

	}

	[ResponseType(nameof(M2C_RolePetList))]
	[Message(OuterOpcode.C2M_RolePetList)]
	[ProtoContract]
	public partial class C2M_RolePetList: Object, IActorLocationRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

	}

	[Message(OuterOpcode.M2C_RolePetList)]
	[ProtoContract]
	public partial class M2C_RolePetList: Object, IActorLocationResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public string Message { get; set; }

		[ProtoMember(92)]
		public int Error { get; set; }

		[ProtoMember(1)]
		public List<RolePetInfo> RolePetInfos = new List<RolePetInfo>();

		[ProtoMember(2)]
		public List<long> TeamPetList = new List<long>();

		[ProtoMember(3)]
		public List<RolePetEgg> RolePetEggs = new List<RolePetEgg>();

		[ProtoMember(4)]
		public List<long> PetFormations = new List<long>();

		[ProtoMember(5)]
		public List<PetFubenInfo> PetFubenInfos = new List<PetFubenInfo>();

		[ProtoMember(6)]
		public List<KeyValuePair> PetSkinList = new List<KeyValuePair>();

		[ProtoMember(7)]
		public int PetFubeRewardId { get; set; }

	}

	[Message(OuterOpcode.PetFubenInfo)]
	[ProtoContract]
	public partial class PetFubenInfo: Object
	{
		[ProtoMember(1)]
		public int PetFubenId { get; set; }

		[ProtoMember(2)]
		public int Star { get; set; }

		[ProtoMember(3)]
		public int Reward { get; set; }

	}

//宠物更新
	[Message(OuterOpcode.M2C_RolePetUpdate)]
	[ProtoContract]
	public partial class M2C_RolePetUpdate: Object, IActorMessage
	{
		[ProtoMember(1)]
		public List<RolePetInfo> PetInfoAdd = new List<RolePetInfo>();

		[ProtoMember(2)]
		public List<RolePetInfo> PetInfoUpdate = new List<RolePetInfo>();

		[ProtoMember(3)]
		public List<RolePetInfo> PetInfoDelete = new List<RolePetInfo>();

	}

	[ResponseType(nameof(M2C_RolePetFormationSet))]
//宠物出战设置
	[Message(OuterOpcode.C2M_RolePetFormationSet)]
	[ProtoContract]
	public partial class C2M_RolePetFormationSet: Object, IActorLocationRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(1)]
		public int Index { get; set; }

		[ProtoMember(2)]
		public long PetId { get; set; }

		[ProtoMember(3)]
		public int OperateType { get; set; }

		[ProtoMember(4)]
		public List<long> PetFormat = new List<long>();

		[ProtoMember(5)]
		public int SceneType { get; set; }

	}

	[Message(OuterOpcode.M2C_RolePetFormationSet)]
	[ProtoContract]
	public partial class M2C_RolePetFormationSet: Object, IActorLocationResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public string Message { get; set; }

		[ProtoMember(92)]
		public int Error { get; set; }

	}

	[ResponseType(nameof(M2C_RolePetSkinSet))]
//更改宠物皮肤
	[Message(OuterOpcode.C2M_RolePetSkinSet)]
	[ProtoContract]
	public partial class C2M_RolePetSkinSet: Object, IActorLocationRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(1)]
		public long PetInfoId { get; set; }

		[ProtoMember(2)]
		public int SkinId { get; set; }

	}

	[Message(OuterOpcode.M2C_RolePetSkinSet)]
	[ProtoContract]
	public partial class M2C_RolePetSkinSet: Object, IActorLocationResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public string Message { get; set; }

		[ProtoMember(92)]
		public int Error { get; set; }

	}

	[ResponseType(nameof(M2C_RolePetHeXin))]
//更改宠物之核
	[Message(OuterOpcode.C2M_RolePetHeXin)]
	[ProtoContract]
	public partial class C2M_RolePetHeXin: Object, IActorLocationRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(1)]
		public long PetInfoId { get; set; }

		[ProtoMember(2)]
		public long BagInfoId { get; set; }

		[ProtoMember(3)]
		public int Position { get; set; }

		[ProtoMember(4)]
		public int OperateType { get; set; }

	}

	[Message(OuterOpcode.M2C_RolePetHeXin)]
	[ProtoContract]
	public partial class M2C_RolePetHeXin: Object, IActorLocationResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public string Message { get; set; }

		[ProtoMember(92)]
		public int Error { get; set; }

		[ProtoMember(1)]
		public RolePetInfo RolePetInfo { get; set; }

	}

	[ResponseType(nameof(M2C_RolePetEggPut))]
//宠物蛋放入
	[Message(OuterOpcode.C2M_RolePetEggPut)]
	[ProtoContract]
	public partial class C2M_RolePetEggPut: Object, IActorLocationRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(1)]
		public long BagInfoId { get; set; }

		[ProtoMember(2)]
		public int Index { get; set; }

	}

	[Message(OuterOpcode.M2C_RolePetEggPut)]
	[ProtoContract]
	public partial class M2C_RolePetEggPut: Object, IActorLocationResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public string Message { get; set; }

		[ProtoMember(92)]
		public int Error { get; set; }

		[ProtoMember(1)]
		public RolePetEgg RolePetEgg { get; set; }

	}

	[ResponseType(nameof(M2C_RolePetEggHatch))]
//宠物蛋孵化
	[Message(OuterOpcode.C2M_RolePetEggHatch)]
	[ProtoContract]
	public partial class C2M_RolePetEggHatch: Object, IActorLocationRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(1)]
		public long BagInfoId { get; set; }

		[ProtoMember(2)]
		public int Index { get; set; }

	}

	[Message(OuterOpcode.M2C_RolePetEggHatch)]
	[ProtoContract]
	public partial class M2C_RolePetEggHatch: Object, IActorLocationResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public string Message { get; set; }

		[ProtoMember(92)]
		public int Error { get; set; }

		[ProtoMember(1)]
		public RolePetEgg RolePetEgg { get; set; }

	}

	[ResponseType(nameof(M2C_RolePetEggOpen))]
//宠物蛋开启【时间未到需要扣除钻石】
	[Message(OuterOpcode.C2M_RolePetEggOpen)]
	[ProtoContract]
	public partial class C2M_RolePetEggOpen: Object, IActorLocationRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(1)]
		public int Index { get; set; }

	}

	[Message(OuterOpcode.M2C_RolePetEggOpen)]
	[ProtoContract]
	public partial class M2C_RolePetEggOpen: Object, IActorLocationResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public string Message { get; set; }

		[ProtoMember(92)]
		public int Error { get; set; }

		[ProtoMember(1)]
		public RolePetInfo PetInfo { get; set; }

	}

	[ResponseType(nameof(M2C_RolePetRName))]
//宠物改名
	[Message(OuterOpcode.C2M_RolePetRName)]
	[ProtoContract]
	public partial class C2M_RolePetRName: Object, IActorLocationRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(1)]
		public long PetInfoId { get; set; }

		[ProtoMember(2)]
		public string PetName { get; set; }

	}

	[Message(OuterOpcode.M2C_RolePetRName)]
	[ProtoContract]
	public partial class M2C_RolePetRName: Object, IActorLocationResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public string Message { get; set; }

		[ProtoMember(92)]
		public int Error { get; set; }

	}

	[ResponseType(nameof(M2C_RolePetFight))]
//宠物出战[1出战 0休息]
	[Message(OuterOpcode.C2M_RolePetFight)]
	[ProtoContract]
	public partial class C2M_RolePetFight: Object, IActorLocationRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(1)]
		public long PetInfoId { get; set; }

		[ProtoMember(2)]
		public int PetStatus { get; set; }

	}

	[Message(OuterOpcode.M2C_RolePetFight)]
	[ProtoContract]
	public partial class M2C_RolePetFight: Object, IActorLocationResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public string Message { get; set; }

		[ProtoMember(92)]
		public int Error { get; set; }

	}

	[ResponseType(nameof(M2C_RolePetFenjie))]
//宠物分解
	[Message(OuterOpcode.C2M_RolePetFenjie)]
	[ProtoContract]
	public partial class C2M_RolePetFenjie: Object, IActorLocationRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(1)]
		public long PetInfoId { get; set; }

	}

	[Message(OuterOpcode.M2C_RolePetFenjie)]
	[ProtoContract]
	public partial class M2C_RolePetFenjie: Object, IActorLocationResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public string Message { get; set; }

		[ProtoMember(92)]
		public int Error { get; set; }

	}

	[ResponseType(nameof(M2C_RolePetJiadian))]
//宠物加点
	[Message(OuterOpcode.C2M_RolePetJiadian)]
	[ProtoContract]
	public partial class C2M_RolePetJiadian: Object, IActorLocationRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(1)]
		public long PetInfoId { get; set; }

		[ProtoMember(2)]
		public List<int> AddPropretyValue = new List<int>();

	}

	[Message(OuterOpcode.M2C_RolePetJiadian)]
	[ProtoContract]
	public partial class M2C_RolePetJiadian: Object, IActorLocationResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public string Message { get; set; }

		[ProtoMember(92)]
		public int Error { get; set; }

		[ProtoMember(3)]
		public RolePetInfo RolePetInfo { get; set; }

	}

	[ResponseType(nameof(M2C_RolePetHeCheng))]
//宠物合成
	[Message(OuterOpcode.C2M_RolePetHeCheng)]
	[ProtoContract]
	public partial class C2M_RolePetHeCheng: Object, IActorLocationRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(1)]
		public long PetInfoId1 { get; set; }

		[ProtoMember(2)]
		public long PetInfoId2 { get; set; }

	}

	[Message(OuterOpcode.M2C_RolePetHeCheng)]
	[ProtoContract]
	public partial class M2C_RolePetHeCheng: Object, IActorLocationResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public string Message { get; set; }

		[ProtoMember(92)]
		public int Error { get; set; }

		[ProtoMember(1)]
		public RolePetInfo rolePetInfo { get; set; }

		[ProtoMember(2)]
		public long DeletePetInfoId { get; set; }

	}

	[ResponseType(nameof(M2C_RolePetUpStar))]
//宠物合成
	[Message(OuterOpcode.C2M_RolePetUpStar)]
	[ProtoContract]
	public partial class C2M_RolePetUpStar: Object, IActorLocationRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(1)]
		public long PetInfoId { get; set; }

		[ProtoMember(2)]
		public List<long> CostPetInfoIds = new List<long>();

	}

	[Message(OuterOpcode.M2C_RolePetUpStar)]
	[ProtoContract]
	public partial class M2C_RolePetUpStar: Object, IActorLocationResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public string Message { get; set; }

		[ProtoMember(92)]
		public int Error { get; set; }

		[ProtoMember(1)]
		public RolePetInfo rolePetInfo { get; set; }

		[ProtoMember(2)]
		public List<long> CostPetInfoIds = new List<long>();

	}

	[ResponseType(nameof(M2C_RolePetXiLian))]
//宠物洗练
	[Message(OuterOpcode.C2M_RolePetXiLian)]
	[ProtoContract]
	public partial class C2M_RolePetXiLian: Object, IActorLocationRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(1)]
		public long PetInfoId { get; set; }

		[ProtoMember(2)]
		public long BagInfoID { get; set; }

		[ProtoMember(3)]
		public int CostItemNum { get; set; }

	}

	[Message(OuterOpcode.M2C_RolePetXiLian)]
	[ProtoContract]
	public partial class M2C_RolePetXiLian: Object, IActorLocationResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public string Message { get; set; }

		[ProtoMember(92)]
		public int Error { get; set; }

		[ProtoMember(1)]
		public RolePetInfo rolePetInfo { get; set; }

	}

	[ResponseType(nameof(M2C_RolePetXiuLian))]
//宠物修炼
	[Message(OuterOpcode.C2M_RolePetXiuLian)]
	[ProtoContract]
	public partial class C2M_RolePetXiuLian: Object, IActorLocationRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(1)]
		public long PetInfoId { get; set; }

		[ProtoMember(2)]
		public int XiuLianId { get; set; }

	}

	[Message(OuterOpcode.M2C_RolePetXiuLian)]
	[ProtoContract]
	public partial class M2C_RolePetXiuLian: Object, IActorLocationResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public string Message { get; set; }

		[ProtoMember(92)]
		public int Error { get; set; }

		[ProtoMember(1)]
		public RolePetInfo rolePetInfo { get; set; }

	}

	[Message(OuterOpcode.M2C_CreateRolePet)]
	[ProtoContract]
	public partial class M2C_CreateRolePet: Object, IActorMessage
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public List<RolePetInfo> RolePets = new List<RolePetInfo>();

	}

	[Message(OuterOpcode.RolePetEgg)]
	[ProtoContract]
	public partial class RolePetEgg: Object
	{
		[ProtoMember(1)]
		public int ItemId { get; set; }

		[ProtoMember(2)]
		public long EndTime { get; set; }

	}

	[Message(OuterOpcode.RolePetInfo)]
	[ProtoContract]
	public partial class RolePetInfo: Object
	{
		[ProtoMember(1)]
		public long Id { get; set; }

		[ProtoMember(2)]
		public int PetStatus { get; set; }

		[ProtoMember(3)]
		public int ConfigId { get; set; }

		[ProtoMember(4)]
		public int PetLv { get; set; }

		[ProtoMember(5)]
		public int Star { get; set; }

		[ProtoMember(7)]
		public int PetExp { get; set; }

		[ProtoMember(8)]
		public string PetName { get; set; }

		[ProtoMember(9)]
		public bool IfBaby { get; set; }

		[ProtoMember(10)]
		public int AddPropretyNum { get; set; }

		[ProtoMember(11)]
		public string AddPropretyValue { get; set; }

		[ProtoMember(12)]
		public int PetPingFen { get; set; }

		[ProtoMember(13)]
		public int ZiZhi_Hp { get; set; }

		[ProtoMember(14)]
		public int ZiZhi_Act { get; set; }

		[ProtoMember(15)]
		public int ZiZhi_MageAct { get; set; }

		[ProtoMember(16)]
		public int ZiZhi_Def { get; set; }

		[ProtoMember(17)]
		public int ZiZhi_Adf { get; set; }

		[ProtoMember(18)]
		public int ZiZhi_ActSpeed { get; set; }

		[ProtoMember(19)]
		public float ZiZhi_ChengZhang { get; set; }

		[ProtoMember(20)]
		public List<int> PetSkill = new List<int>();

		[ProtoMember(21)]
		public int EquipID_1 { get; set; }

		[ProtoMember(22)]
		public string EquipIDHide_1 { get; set; }

		[ProtoMember(23)]
		public int EquipID_2 { get; set; }

		[ProtoMember(24)]
		public string EquipIDHide_2 { get; set; }

		[ProtoMember(25)]
		public int EquipID_3 { get; set; }

		[ProtoMember(26)]
		public string EquipIDHide_3 { get; set; }

		[ProtoMember(27)]
		public float X { get; set; }

		[ProtoMember(28)]
		public float Y { get; set; }

		[ProtoMember(29)]
		public float Z { get; set; }

		[ProtoMember(30)]
		public List<int> Ks = new List<int>();

		[ProtoMember(31)]
		public List<long> Vs = new List<long>();

		[ProtoMember(32)]
		public int RoleCamp { get; set; }

		[ProtoMember(33)]
		public string PlayerName { get; set; }

		[ProtoMember(34)]
		public int SkinId { get; set; }

		[ProtoMember(35)]
		public List<long> PetHeXinList = new List<long>();

		[ProtoMember(38)]
		public int UpStageStatus { get; set; }

	}

	[ResponseType(nameof(M2C_SkillInitResponse))]
//技能升级
	[Message(OuterOpcode.C2M_SkillInitRequest)]
	[ProtoContract]
	public partial class C2M_SkillInitRequest: Object, IActorLocationRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

	}

	[Message(OuterOpcode.M2C_SkillInitResponse)]
	[ProtoContract]
	public partial class M2C_SkillInitResponse: Object, IActorLocationResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public string Message { get; set; }

		[ProtoMember(92)]
		public int Error { get; set; }

		[ProtoMember(1)]
		public SkillSetInfo SkillSetInfo { get; set; }

	}

	[Message(OuterOpcode.LifeShieldInfo)]
	[ProtoContract]
	public partial class LifeShieldInfo: Object
	{
		[ProtoMember(1)]
		public int ShieldType { get; set; }

		[ProtoMember(2)]
		public int Level { get; set; }

		[ProtoMember(3)]
		public int Exp { get; set; }

		[ProtoMember(4)]
		public string Message { get; set; }

	}

	[ResponseType(nameof(M2C_SkillUp))]
//技能升级
	[Message(OuterOpcode.C2M_SkillUp)]
	[ProtoContract]
	public partial class C2M_SkillUp: Object, IActorLocationRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(1)]
		public int SkillID { get; set; }

	}

	[Message(OuterOpcode.M2C_SkillUp)]
	[ProtoContract]
	public partial class M2C_SkillUp: Object, IActorLocationResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public string Message { get; set; }

		[ProtoMember(92)]
		public int Error { get; set; }

		[ProtoMember(1)]
		public int NewSkillID { get; set; }

	}

	[ResponseType(nameof(M2C_SkillSet))]
//技能设置
	[Message(OuterOpcode.C2M_SkillSet)]
	[ProtoContract]
	public partial class C2M_SkillSet: Object, IActorLocationRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(1)]
		public int SkillID { get; set; }

		[ProtoMember(2)]
		public int Position { get; set; }

		[ProtoMember(3)]
		public int SkillType { get; set; }

	}

	[Message(OuterOpcode.M2C_SkillSet)]
	[ProtoContract]
	public partial class M2C_SkillSet: Object, IActorLocationResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public string Message { get; set; }

		[ProtoMember(92)]
		public int Error { get; set; }

	}

	[ResponseType(nameof(M2C_SkillOperation))]
//技能操作
	[Message(OuterOpcode.C2M_SkillOperation)]
	[ProtoContract]
	public partial class C2M_SkillOperation: Object, IActorLocationRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(1)]
		public int SkillID { get; set; }

		[ProtoMember(3)]
		public int OperationType { get; set; }

		[ProtoMember(4)]
		public string OperationValue { get; set; }

	}

	[Message(OuterOpcode.M2C_SkillOperation)]
	[ProtoContract]
	public partial class M2C_SkillOperation: Object, IActorLocationResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public string Message { get; set; }

		[ProtoMember(92)]
		public int Error { get; set; }

	}

//技能列表
	[Message(OuterOpcode.SkillPro)]
	[ProtoContract]
	public partial class SkillPro: Object
	{
		[ProtoMember(1)]
		public int SkillID { get; set; }

		[ProtoMember(2)]
		public int SkillPosition { get; set; }

		[ProtoMember(3)]
		public int SkillSetType { get; set; }

		[ProtoMember(4)]
		public int Actived { get; set; }

		[ProtoMember(5)]
		public int SkillSource { get; set; }

	}

//通过奖励
	[Message(OuterOpcode.RewardItem)]
	[ProtoContract]
	public partial class RewardItem: Object
	{
		[ProtoMember(1)]
		public int ItemID { get; set; }

		[ProtoMember(2)]
		public int ItemNum { get; set; }

	}

	[ResponseType(nameof(M2C_ChangeOccTwoResponse))]
//转换职业
	[Message(OuterOpcode.C2M_ChangeOccTwoRequest)]
	[ProtoContract]
	public partial class C2M_ChangeOccTwoRequest: Object, IActorLocationRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(1)]
		public int OccTwoID { get; set; }

	}

	[Message(OuterOpcode.M2C_ChangeOccTwoResponse)]
	[ProtoContract]
	public partial class M2C_ChangeOccTwoResponse: Object, IActorLocationResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public string Message { get; set; }

		[ProtoMember(92)]
		public int Error { get; set; }

	}

	[ResponseType(nameof(M2C_StoreBuyResponse))]
//商店购买
	[Message(OuterOpcode.C2M_StoreBuyRequest)]
	[ProtoContract]
	public partial class C2M_StoreBuyRequest: Object, IActorLocationRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(1)]
		public int SellItemID { get; set; }

	}

	[Message(OuterOpcode.M2C_StoreBuyResponse)]
	[ProtoContract]
	public partial class M2C_StoreBuyResponse: Object, IActorLocationResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public string Message { get; set; }

		[ProtoMember(92)]
		public int Error { get; set; }

	}

	[ResponseType(nameof(M2C_GameSettingResponse))]
//游戏设置
	[Message(OuterOpcode.C2M_GameSettingRequest)]
	[ProtoContract]
	public partial class C2M_GameSettingRequest: Object, IActorLocationRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(1)]
		public List<KeyValuePair> GameSettingInfos = new List<KeyValuePair>();

	}

	[Message(OuterOpcode.M2C_GameSettingResponse)]
	[ProtoContract]
	public partial class M2C_GameSettingResponse: Object, IActorLocationResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public string Message { get; set; }

		[ProtoMember(92)]
		public int Error { get; set; }

	}

	[ResponseType(nameof(M2C_ModifyNameResponse))]
//改游戏名
	[Message(OuterOpcode.C2M_ModifyNameRequest)]
	[ProtoContract]
	public partial class C2M_ModifyNameRequest: Object, IActorLocationRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(1)]
		public string NewName { get; set; }

	}

	[Message(OuterOpcode.M2C_ModifyNameResponse)]
	[ProtoContract]
	public partial class M2C_ModifyNameResponse: Object, IActorLocationResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public string Message { get; set; }

		[ProtoMember(92)]
		public int Error { get; set; }

	}

	[Message(OuterOpcode.M2C_UpdateMailInfo)]
	[ProtoContract]
	public partial class M2C_UpdateMailInfo: Object, IActorMessage
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public List<MailInfo> MailInfos = new List<MailInfo>();

	}

	[Message(OuterOpcode.MailInfo)]
	[ProtoContract]
	public partial class MailInfo: Object
	{
		[ProtoMember(1)]
		public int Status { get; set; }

		[ProtoMember(3)]
		public string Context { get; set; }

		[ProtoMember(5)]
		public long MailId { get; set; }

		[ProtoMember(6)]
		public string Title { get; set; }

		[ProtoMember(7)]
		public List<BagInfo> ItemList = new List<BagInfo>();

		[ProtoMember(8)]
		public BagInfo ItemSell { get; set; }

	}

	[ResponseType(nameof(M2C_ReceiveMailResponse))]
	[Message(OuterOpcode.C2M_ReceiveMailRequest)]
	[ProtoContract]
	public partial class C2M_ReceiveMailRequest: Object, IActorLocationRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public long MailId { get; set; }

	}

	[Message(OuterOpcode.M2C_ReceiveMailResponse)]
	[ProtoContract]
	public partial class M2C_ReceiveMailResponse: Object, IActorLocationResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

	}

	[ResponseType(nameof(E2C_ReceiveMailResponse))]
	[Message(OuterOpcode.C2E_ReceiveMailRequest)]
	[ProtoContract]
	public partial class C2E_ReceiveMailRequest: Object, IMailActorRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public long MailId { get; set; }

	}

	[Message(OuterOpcode.E2C_ReceiveMailResponse)]
	[ProtoContract]
	public partial class E2C_ReceiveMailResponse: Object, IMailActorResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

	}

	[ResponseType(nameof(E2C_GetAllMailResponse))]
	[Message(OuterOpcode.C2E_GetAllMailRequest)]
	[ProtoContract]
	public partial class C2E_GetAllMailRequest: Object, IMailActorRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

	}

	[Message(OuterOpcode.E2C_GetAllMailResponse)]
	[ProtoContract]
	public partial class E2C_GetAllMailResponse: Object, IMailActorResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

		[ProtoMember(1)]
		public List<MailInfo> MailInfos = new List<MailInfo>();

	}

	[ResponseType(nameof(M2C_MakeEquipResponse))]
	[Message(OuterOpcode.C2M_MakeEquipRequest)]
	[ProtoContract]
	public partial class C2M_MakeEquipRequest: Object, IActorLocationRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public int MakeId { get; set; }

		[ProtoMember(2)]
		public long BagInfoID { get; set; }

	}

	[Message(OuterOpcode.M2C_MakeEquipResponse)]
	[ProtoContract]
	public partial class M2C_MakeEquipResponse: Object, IActorLocationResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

		[ProtoMember(1)]
		public int ItemId { get; set; }

		[ProtoMember(2)]
		public int NewMakeId { get; set; }

	}

	[ResponseType(nameof(M2C_MakeLearnResponse))]
	[Message(OuterOpcode.C2M_MakeLearnRequest)]
	[ProtoContract]
	public partial class C2M_MakeLearnRequest: Object, IActorLocationRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public int MakeId { get; set; }

	}

	[Message(OuterOpcode.M2C_MakeLearnResponse)]
	[ProtoContract]
	public partial class M2C_MakeLearnResponse: Object, IActorLocationResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

	}

	[ResponseType(nameof(M2C_TianFuActiveResponse))]
	[Message(OuterOpcode.C2M_TianFuActiveRequest)]
	[ProtoContract]
	public partial class C2M_TianFuActiveRequest: Object, IActorLocationRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public int TianFuId { get; set; }

	}

	[Message(OuterOpcode.M2C_TianFuActiveResponse)]
	[ProtoContract]
	public partial class M2C_TianFuActiveResponse: Object, IActorLocationResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

	}

	[ResponseType(nameof(M2C_RealNameRewardResponse))]
	[Message(OuterOpcode.C2M_RealNameRewardRequest)]
	[ProtoContract]
	public partial class C2M_RealNameRewardRequest: Object, IActorLocationRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

	}

	[Message(OuterOpcode.M2C_RealNameRewardResponse)]
	[ProtoContract]
	public partial class M2C_RealNameRewardResponse: Object, IActorLocationResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

	}

	[ResponseType(nameof(M2C_YueKaOpenResponse))]
	[Message(OuterOpcode.C2M_YueKaOpenRequest)]
	[ProtoContract]
	public partial class C2M_YueKaOpenRequest: Object, IActorLocationRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

	}

	[Message(OuterOpcode.M2C_YueKaOpenResponse)]
	[ProtoContract]
	public partial class M2C_YueKaOpenResponse: Object, IActorLocationResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

	}

	[ResponseType(nameof(M2C_YueKaRewardResponse))]
	[Message(OuterOpcode.C2M_YueKaRewardRequest)]
	[ProtoContract]
	public partial class C2M_YueKaRewardRequest: Object, IActorLocationRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

	}

	[Message(OuterOpcode.M2C_YueKaRewardResponse)]
	[ProtoContract]
	public partial class M2C_YueKaRewardResponse: Object, IActorLocationResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

	}

//成就进度
	[Message(OuterOpcode.ChengJiuInfo)]
	[ProtoContract]
	public partial class ChengJiuInfo: Object
	{
		[ProtoMember(1)]
		public int ChengJiuID { get; set; }

		[ProtoMember(2)]
		public int ChengJiuProgess { get; set; }

		[ProtoMember(3)]
		public long ChengJiuProgessLong { get; set; }

	}

	[ResponseType(nameof(M2C_ChengJiuListResponse))]
	[Message(OuterOpcode.C2M_ChengJiuListRequest)]
	[ProtoContract]
	public partial class C2M_ChengJiuListRequest: Object, IActorLocationRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

	}

	[Message(OuterOpcode.M2C_ChengJiuListResponse)]
	[ProtoContract]
	public partial class M2C_ChengJiuListResponse: Object, IActorLocationResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

		[ProtoMember(1)]
		public List<ChengJiuInfo> ChengJiuProgessList = new List<ChengJiuInfo>();

		[ProtoMember(2)]
		public List<int> ChengJiuCompleteList = new List<int>();

		[ProtoMember(3)]
		public int TotalChengJiuPoint { get; set; }

		[ProtoMember(4)]
		public List<int> AlreadReceivedId = new List<int>();

		[ProtoMember(5)]
		public List<int> JingLingList = new List<int>();

		[ProtoMember(6)]
		public int JingLingId { get; set; }

		[ProtoMember(7)]
		public int RandomDrop { get; set; }

	}

//激活成就
	[Message(OuterOpcode.M2C_ChengJiuActiveMessage)]
	[ProtoContract]
	public partial class M2C_ChengJiuActiveMessage: Object, IActorMessage
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

		[ProtoMember(1)]
		public int ChengJiuId { get; set; }

	}

	[ResponseType(nameof(M2C_ChengJiuRewardResponse))]
	[Message(OuterOpcode.C2M_ChengJiuRewardRequest)]
	[ProtoContract]
	public partial class C2M_ChengJiuRewardRequest: Object, IActorLocationRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public int RewardId { get; set; }

	}

	[Message(OuterOpcode.M2C_ChengJiuRewardResponse)]
	[ProtoContract]
	public partial class M2C_ChengJiuRewardResponse: Object, IActorLocationResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

	}

	[ResponseType(nameof(M2C_ChouKaResponse))]
	[Message(OuterOpcode.C2M_ChouKaRequest)]
	[ProtoContract]
	public partial class C2M_ChouKaRequest: Object, IActorLocationRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public int ChouKaType { get; set; }

		[ProtoMember(2)]
		public int ChapterId { get; set; }

	}

	[Message(OuterOpcode.M2C_ChouKaResponse)]
	[ProtoContract]
	public partial class M2C_ChouKaResponse: Object, IActorLocationResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

		[ProtoMember(1)]
		public List<RewardItem> RewardList = new List<RewardItem>();

	}

	[ResponseType(nameof(R2C_RankListResponse))]
	[Message(OuterOpcode.C2R_RankListRequest)]
	[ProtoContract]
	public partial class C2R_RankListRequest: Object, IRankActorRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public int RankType { get; set; }

	}

	[Message(OuterOpcode.R2C_RankListResponse)]
	[ProtoContract]
	public partial class R2C_RankListResponse: Object, IRankActorResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

		[ProtoMember(1)]
		public List<RankingInfo> RankList = new List<RankingInfo>();

	}

	[Message(OuterOpcode.RankingInfo)]
	[ProtoContract]
	public partial class RankingInfo: Object
	{
		[ProtoMember(1)]
		public long UserId { get; set; }

		[ProtoMember(2)]
		public string PlayerName { get; set; }

		[ProtoMember(3)]
		public int PlayerLv { get; set; }

		[ProtoMember(4)]
		public long Combat { get; set; }

		[ProtoMember(5)]
		public int Occ { get; set; }

	}

	[Message(OuterOpcode.RankPetInfo)]
	[ProtoContract]
	public partial class RankPetInfo: Object
	{
		[ProtoMember(1)]
		public long UserId { get; set; }

		[ProtoMember(2)]
		public string PlayerName { get; set; }

		[ProtoMember(3)]
		public string TeamName { get; set; }

		[ProtoMember(4)]
		public int RankId { get; set; }

		[ProtoMember(5)]
		public List<int> PetConfigId = new List<int>();

		[ProtoMember(6)]
		public List<long> PetUId = new List<long>();

	}

	[ResponseType(nameof(R2C_RankPetListResponse))]
	[Message(OuterOpcode.C2R_RankPetListRequest)]
	[ProtoContract]
	public partial class C2R_RankPetListRequest: Object, IRankActorRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(94)]
		public long UserId { get; set; }

	}

	[Message(OuterOpcode.R2C_RankPetListResponse)]
	[ProtoContract]
	public partial class R2C_RankPetListResponse: Object, IRankActorResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

		[ProtoMember(1)]
		public int LeftCombatTime { get; set; }

		[ProtoMember(2)]
		public List<RankPetInfo> RankPetList = new List<RankPetInfo>();

		[ProtoMember(3)]
		public long RankNumber { get; set; }

	}

	[ResponseType(nameof(M2C_RankPetCombatResponse))]
	[Message(OuterOpcode.C2M_RankPetCombatRequest)]
	[ProtoContract]
	public partial class C2M_RankPetCombatRequest: Object, IActorLocationRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public long PlayerId { get; set; }

	}

	[Message(OuterOpcode.M2C_RankPetCombatResponse)]
	[ProtoContract]
	public partial class M2C_RankPetCombatResponse: Object, IActorLocationResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

	}

	[ResponseType(nameof(M2C_QuitPetRankResponse))]
	[Message(OuterOpcode.C2M_QuitPetRankRequest)]
	[ProtoContract]
	public partial class C2M_QuitPetRankRequest: Object, IActorLocationRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public int MapIndex { get; set; }

	}

	[Message(OuterOpcode.M2C_QuitPetRankResponse)]
	[ProtoContract]
	public partial class M2C_QuitPetRankResponse: Object, IActorLocationResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

	}

	[ResponseType(nameof(M2C_PaiMaiShopResponse))]
	[Message(OuterOpcode.C2M_PaiMaiShopRequest)]
	[ProtoContract]
	public partial class C2M_PaiMaiShopRequest: Object, IActorLocationRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public int PaiMaiId { get; set; }

		[ProtoMember(2)]
		public int BuyNum { get; set; }

	}

	[Message(OuterOpcode.M2C_PaiMaiShopResponse)]
	[ProtoContract]
	public partial class M2C_PaiMaiShopResponse: Object, IActorLocationResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

	}

	[ResponseType(nameof(P2C_PaiMaiShopShowListResponse))]
	[Message(OuterOpcode.C2P_PaiMaiShopShowListRequest)]
	[ProtoContract]
	public partial class C2P_PaiMaiShopShowListRequest: Object, IPaiMaiListRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

	}

	[Message(OuterOpcode.P2C_PaiMaiShopShowListResponse)]
	[ProtoContract]
	public partial class P2C_PaiMaiShopShowListResponse: Object, IPaiMaiListResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

		[ProtoMember(1)]
		public List<PaiMaiShopItemInfo> PaiMaiShopItemInfos = new List<PaiMaiShopItemInfo>();

	}

	[ResponseType(nameof(M2C_PaiMaiBuyResponse))]
	[Message(OuterOpcode.C2M_PaiMaiBuyRequest)]
	[ProtoContract]
	public partial class C2M_PaiMaiBuyRequest: Object, IActorLocationRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public PaiMaiItemInfo PaiMaiItemInfo { get; set; }

	}

	[Message(OuterOpcode.M2C_PaiMaiBuyResponse)]
	[ProtoContract]
	public partial class M2C_PaiMaiBuyResponse: Object, IActorLocationResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

	}

	[ResponseType(nameof(M2C_PaiMaiSellResponse))]
	[Message(OuterOpcode.C2M_PaiMaiSellRequest)]
	[ProtoContract]
	public partial class C2M_PaiMaiSellRequest: Object, IActorLocationRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public PaiMaiItemInfo PaiMaiItemInfo { get; set; }

	}

	[Message(OuterOpcode.M2C_PaiMaiSellResponse)]
	[ProtoContract]
	public partial class M2C_PaiMaiSellResponse: Object, IActorLocationResponse
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

	[Message(OuterOpcode.PaiMaiItemInfo)]
	[ProtoContract]
	public partial class PaiMaiItemInfo: Object
	{
		[ProtoMember(1)]
		public long Id { get; set; }

		[ProtoMember(2)]
		public long UserId { get; set; }

		[ProtoMember(3)]
		public BagInfo BagInfo { get; set; }

		[ProtoMember(5)]
		public int Price { get; set; }

		[ProtoMember(6)]
		public string PlayerName { get; set; }

		[ProtoMember(7)]
		public long SellTime { get; set; }

	}

	[Message(OuterOpcode.PaiMaiShopItemInfo)]
	[ProtoContract]
	public partial class PaiMaiShopItemInfo: Object
	{
		[ProtoMember(1)]
		public long Id { get; set; }

		[ProtoMember(2)]
		public int ItemNumber { get; set; }

		[ProtoMember(3)]
		public int PriceType { get; set; }

		[ProtoMember(4)]
		public int Price { get; set; }

		[ProtoMember(5)]
		public float PricePro { get; set; }

		[ProtoMember(6)]
		public int BuyNum { get; set; }

	}

	[ResponseType(nameof(P2C_PaiMaiListResponse))]
	[Message(OuterOpcode.C2P_PaiMaiListRequest)]
	[ProtoContract]
	public partial class C2P_PaiMaiListRequest: Object, IPaiMaiListRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public long UserId { get; set; }

		[ProtoMember(2)]
		public int PaiMaiType { get; set; }

	}

	[Message(OuterOpcode.P2C_PaiMaiListResponse)]
	[ProtoContract]
	public partial class P2C_PaiMaiListResponse: Object, IPaiMaiListResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

		[ProtoMember(1)]
		public List<PaiMaiItemInfo> PaiMaiItemInfos = new List<PaiMaiItemInfo>();

	}

	[ResponseType(nameof(M2C_PaiMaiXiaJiaResponse))]
	[Message(OuterOpcode.C2M_PaiMaiXiaJiaRequest)]
	[ProtoContract]
	public partial class C2M_PaiMaiXiaJiaRequest: Object, IActorLocationRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public long PaiMaiItemInfoId { get; set; }

	}

	[Message(OuterOpcode.M2C_PaiMaiXiaJiaResponse)]
	[ProtoContract]
	public partial class M2C_PaiMaiXiaJiaResponse: Object, IActorLocationResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

	}

//摆摊
	[ResponseType(nameof(M2C_StallOperationResponse))]
	[Message(OuterOpcode.C2M_StallOperationRequest)]
	[ProtoContract]
	public partial class C2M_StallOperationRequest: Object, IActorLocationRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public int StallType { get; set; }

		[ProtoMember(2)]
		public string Value { get; set; }

	}

	[Message(OuterOpcode.M2C_StallOperationResponse)]
	[ProtoContract]
	public partial class M2C_StallOperationResponse: Object, IActorLocationResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

	}

	[ResponseType(nameof(M2C_PaiMaiDuiHuanResponse))]
	[Message(OuterOpcode.C2M_PaiMaiDuiHuanRequest)]
	[ProtoContract]
	public partial class C2M_PaiMaiDuiHuanRequest: Object, IActorLocationRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public long DiamondsNumber { get; set; }

	}

	[Message(OuterOpcode.M2C_PaiMaiDuiHuanResponse)]
	[ProtoContract]
	public partial class M2C_PaiMaiDuiHuanResponse: Object, IActorLocationResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

	}

	[Message(OuterOpcode.MysteryItemInfo)]
	[ProtoContract]
	public partial class MysteryItemInfo: Object
	{
		[ProtoMember(1)]
		public int MysteryId { get; set; }

		[ProtoMember(3)]
		public int ItemID { get; set; }

		[ProtoMember(4)]
		public int ItemNumber { get; set; }

	}

	[ResponseType(nameof(M2C_MysteryBuyResponse))]
	[Message(OuterOpcode.C2M_MysteryBuyRequest)]
	[ProtoContract]
	public partial class C2M_MysteryBuyRequest: Object, IActorLocationRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public MysteryItemInfo MysteryItemInfo { get; set; }

		[ProtoMember(2)]
		public int NpcId { get; set; }

	}

	[Message(OuterOpcode.M2C_MysteryBuyResponse)]
	[ProtoContract]
	public partial class M2C_MysteryBuyResponse: Object, IActorLocationResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

	}

	[ResponseType(nameof(Actor_FubenMoNengResponse))]
	[Message(OuterOpcode.Actor_FubenMoNengRequest)]
	[ProtoContract]
	public partial class Actor_FubenMoNengRequest: Object, IActorLocationRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

	}

	[Message(OuterOpcode.Actor_FubenMoNengResponse)]
	[ProtoContract]
	public partial class Actor_FubenMoNengResponse: Object, IActorLocationResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

		[ProtoMember(1)]
		public List<MysteryItemInfo> MysteryItemInfos = new List<MysteryItemInfo>();

	}

	[ResponseType(nameof(M2C_RolePetChouKaResponse))]
	[Message(OuterOpcode.C2M_RolePetChouKaRequest)]
	[ProtoContract]
	public partial class C2M_RolePetChouKaRequest: Object, IActorLocationRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public int ChouKaType { get; set; }

	}

	[Message(OuterOpcode.M2C_RolePetChouKaResponse)]
	[ProtoContract]
	public partial class M2C_RolePetChouKaResponse: Object, IActorLocationResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

		[ProtoMember(1)]
		public RolePetInfo RolePetInfo { get; set; }

	}

	[ResponseType(nameof(M2C_EnergyReceiveResponse))]
	[Message(OuterOpcode.C2M_EnergyReceiveRequest)]
	[ProtoContract]
	public partial class C2M_EnergyReceiveRequest: Object, IActorLocationRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public int RewardType { get; set; }

	}

	[Message(OuterOpcode.M2C_EnergyReceiveResponse)]
	[ProtoContract]
	public partial class M2C_EnergyReceiveResponse: Object, IActorLocationResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

	}

//答题
	[ResponseType(nameof(M2C_EnergyAnswerResponse))]
	[Message(OuterOpcode.C2M_EnergyAnswerRequest)]
	[ProtoContract]
	public partial class C2M_EnergyAnswerRequest: Object, IActorLocationRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public int AnswerIndex { get; set; }

		[ProtoMember(2)]
		public int QuestionId { get; set; }

	}

	[Message(OuterOpcode.M2C_EnergyAnswerResponse)]
	[ProtoContract]
	public partial class M2C_EnergyAnswerResponse: Object, IActorLocationResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

	}

	[ResponseType(nameof(M2C_EnergyInfoResponse))]
	[Message(OuterOpcode.C2M_EnergyInfoRequest)]
	[ProtoContract]
	public partial class C2M_EnergyInfoRequest: Object, IActorLocationRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

	}

	[Message(OuterOpcode.M2C_EnergyInfoResponse)]
	[ProtoContract]
	public partial class M2C_EnergyInfoResponse: Object, IActorLocationResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

		[ProtoMember(1)]
		public List<int> GetRewards = new List<int>();

		[ProtoMember(2)]
		public List<int> QuestionList = new List<int>();

		[ProtoMember(3)]
		public int QuestionIndex { get; set; }

	}

//开启宝箱
	[ResponseType(nameof(Actor_PickBoxResponse))]
	[Message(OuterOpcode.Actor_PickBoxRequest)]
	[ProtoContract]
	public partial class Actor_PickBoxRequest: Object, IActorLocationRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public long UnitId { get; set; }

	}

	[Message(OuterOpcode.Actor_PickBoxResponse)]
	[ProtoContract]
	public partial class Actor_PickBoxResponse: Object, IActorLocationResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

	}

//GM数据
	[ResponseType(nameof(C2C_GMInfoResponse))]
	[Message(OuterOpcode.C2C_GMInfoRequest)]
	[ProtoContract]
	public partial class C2C_GMInfoRequest: Object, ICenterActorRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public long UserId { get; set; }

	}

	[Message(OuterOpcode.C2C_GMInfoResponse)]
	[ProtoContract]
	public partial class C2C_GMInfoResponse: Object, ICenterActorResponse
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

//GM邮件
	[ResponseType(nameof(E2C_GMEMailResponse))]
	[Message(OuterOpcode.C2E_GMEMailRequest)]
	[ProtoContract]
	public partial class C2E_GMEMailRequest: Object, IMailActorRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public long UserId { get; set; }

		[ProtoMember(2)]
		public MailInfo MailInfo { get; set; }

	}

	[Message(OuterOpcode.E2C_GMEMailResponse)]
	[ProtoContract]
	public partial class E2C_GMEMailResponse: Object, IMailActorResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

	}

	[ResponseType(nameof(R2C_DBServerInfoResponse))]
	[Message(OuterOpcode.C2R_DBServerInfoRequest)]
	[ProtoContract]
	public partial class C2R_DBServerInfoRequest: Object, IRankActorRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

	}

	[Message(OuterOpcode.R2C_DBServerInfoResponse)]
	[ProtoContract]
	public partial class R2C_DBServerInfoResponse: Object, IRankActorResponse
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

	[ResponseType(nameof(A2C_MysteryListResponse))]
	[Message(OuterOpcode.C2A_MysteryListRequest)]
	[ProtoContract]
	public partial class C2A_MysteryListRequest: Object, IActivityActorRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public long UserId { get; set; }

	}

	[Message(OuterOpcode.A2C_MysteryListResponse)]
	[ProtoContract]
	public partial class A2C_MysteryListResponse: Object, IActivityActorResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

		[ProtoMember(1)]
		public List<MysteryItemInfo> MysteryItemInfos = new List<MysteryItemInfo>();

	}

//领取奖励
	[ResponseType(nameof(M2C_ActivityReceiveResponse))]
	[Message(OuterOpcode.C2M_ActivityReceiveRequest)]
	[ProtoContract]
	public partial class C2M_ActivityReceiveRequest: Object, IActorLocationRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public int ActivityType { get; set; }

		[ProtoMember(2)]
		public int ActivityId { get; set; }

		[ProtoMember(3)]
		public int ReceiveIndex { get; set; }

	}

	[Message(OuterOpcode.M2C_ActivityReceiveResponse)]
	[ProtoContract]
	public partial class M2C_ActivityReceiveResponse: Object, IActorLocationResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

	}

//活动信息
	[ResponseType(nameof(M2C_ActivityInfoResponse))]
	[Message(OuterOpcode.C2M_ActivityInfoRequest)]
	[ProtoContract]
	public partial class C2M_ActivityInfoRequest: Object, IActorLocationRequest
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

	[Message(OuterOpcode.M2C_ActivityInfoResponse)]
	[ProtoContract]
	public partial class M2C_ActivityInfoResponse: Object, IActorLocationResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

		[ProtoMember(1)]
		public List<int> ReceiveIds = new List<int>();

		[ProtoMember(3)]
		public long LastSignTime { get; set; }

		[ProtoMember(4)]
		public int TotalSignNumber { get; set; }

		[ProtoMember(5)]
		public List<TokenRecvive> QuTokenRecvive = new List<TokenRecvive>();

		[ProtoMember(6)]
		public long LastLoginTime { get; set; }

		[ProtoMember(7)]
		public List<int> DayTeHui = new List<int>();

	}

//战区活动
	[ResponseType(nameof(M2C_ZhanQuReceiveResponse))]
	[Message(OuterOpcode.C2M_ZhanQuReceiveRequest)]
	[ProtoContract]
	public partial class C2M_ZhanQuReceiveRequest: Object, IActorLocationRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public int ActivityType { get; set; }

		[ProtoMember(2)]
		public int ActivityId { get; set; }

		[ProtoMember(3)]
		public int ReceiveIndex { get; set; }

	}

	[Message(OuterOpcode.M2C_ZhanQuReceiveResponse)]
	[ProtoContract]
	public partial class M2C_ZhanQuReceiveResponse: Object, IActorLocationResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

	}

	[ResponseType(nameof(M2C_ZhanQuInfoResponse))]
	[Message(OuterOpcode.C2M_ZhanQuInfoRequest)]
	[ProtoContract]
	public partial class C2M_ZhanQuInfoRequest: Object, IActorLocationRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

	}

	[Message(OuterOpcode.M2C_ZhanQuInfoResponse)]
	[ProtoContract]
	public partial class M2C_ZhanQuInfoResponse: Object, IActorLocationResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

		[ProtoMember(1)]
		public List<int> ReceiveIds = new List<int>();

		[ProtoMember(2)]
		public List<ZhanQuReceiveNumber> ReceiveNum = new List<ZhanQuReceiveNumber>();

	}

//战区领取记录
	[Message(OuterOpcode.ZhanQuReceiveNumber)]
	[ProtoContract]
	public partial class ZhanQuReceiveNumber: Object
	{
		[ProtoMember(1)]
		public int ActivityId { get; set; }

		[ProtoMember(2)]
		public int ReceiveNum { get; set; }

		[ProtoMember(3)]
		public List<long> ReceiveUnitIds = new List<long>();

	}

	[Message(OuterOpcode.TokenRecvive)]
	[ProtoContract]
	public partial class TokenRecvive: Object
	{
		[ProtoMember(1)]
		public int ActivityId { get; set; }

		[ProtoMember(2)]
		public int ReceiveIndex { get; set; }

	}

	[Message(OuterOpcode.TeamInfo)]
	[ProtoContract]
	public partial class TeamInfo: Object
	{
		[ProtoMember(1)]
		public int SceneId { get; set; }

		[ProtoMember(2)]
		public List<TeamPlayerInfo> PlayerList = new List<TeamPlayerInfo>();

		[ProtoMember(3)]
		public long TeamId { get; set; }

		[ProtoMember(4)]
		public long FubenInstanceId { get; set; }

		[ProtoMember(5)]
		public long FubenUUId { get; set; }

		[ProtoMember(6)]
		public int FubenType { get; set; }

	}

	[Message(OuterOpcode.TeamPlayerInfo)]
	[ProtoContract]
	public partial class TeamPlayerInfo: Object
	{
		[ProtoMember(1)]
		public int HeadId { get; set; }

		[ProtoMember(2)]
		public int PlayerLv { get; set; }

		[ProtoMember(3)]
		public int WeaponId { get; set; }

		[ProtoMember(4)]
		public string PlayerName { get; set; }

		[ProtoMember(5)]
		public long UserID { get; set; }

		[ProtoMember(6)]
		public int Damage { get; set; }

		[ProtoMember(7)]
		public long Combat { get; set; }

		[ProtoMember(8)]
		public int Occ { get; set; }

		[ProtoMember(9)]
		public int InFuben { get; set; }

		[ProtoMember(10)]
		public int RobotId { get; set; }

		[ProtoMember(11)]
		public int OccTwo { get; set; }

		[ProtoMember(12)]
		public int Prepare { get; set; }

	}

//邀请组队
	[ResponseType(nameof(T2C_TeamInviteResponse))]
	[Message(OuterOpcode.C2T_TeamInviteRequest)]
	[ProtoContract]
	public partial class C2T_TeamInviteRequest: Object, ITeamActorRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public long UserID { get; set; }

		[ProtoMember(2)]
		public TeamPlayerInfo TeamPlayerInfo { get; set; }

	}

	[Message(OuterOpcode.T2C_TeamInviteResponse)]
	[ProtoContract]
	public partial class T2C_TeamInviteResponse: Object, ITeamActorResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

	}

//同意组队
	[ResponseType(nameof(T2C_TeamAgreeResponse))]
	[Message(OuterOpcode.C2T_TeamAgreeRequest)]
	[ProtoContract]
	public partial class C2T_TeamAgreeRequest: Object, ITeamActorRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public TeamPlayerInfo TeamPlayerInfo_1 { get; set; }

		[ProtoMember(2)]
		public TeamPlayerInfo TeamPlayerInfo_2 { get; set; }

	}

	[Message(OuterOpcode.T2C_TeamAgreeResponse)]
	[ProtoContract]
	public partial class T2C_TeamAgreeResponse: Object, ITeamActorResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

	}

//离开组队
	[ResponseType(nameof(T2C_TeamLeaveResponse))]
	[Message(OuterOpcode.C2T_TeamLeaveRequest)]
	[ProtoContract]
	public partial class C2T_TeamLeaveRequest: Object, ITeamActorRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public long UserId { get; set; }

	}

	[Message(OuterOpcode.T2C_TeamLeaveResponse)]
	[ProtoContract]
	public partial class T2C_TeamLeaveResponse: Object, ITeamActorResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

	}

//踢出队伍
	[ResponseType(nameof(T2C_TeamKickOutResponse))]
	[Message(OuterOpcode.C2T_TeamKickOutRequest)]
	[ProtoContract]
	public partial class C2T_TeamKickOutRequest: Object, ITeamActorRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public long UserId { get; set; }

	}

	[Message(OuterOpcode.T2C_TeamKickOutResponse)]
	[ProtoContract]
	public partial class T2C_TeamKickOutResponse: Object, ITeamActorResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

	}

//组队副本
	[ResponseType(nameof(T2C_TeamDungeonInfoResponse))]
	[Message(OuterOpcode.C2T_TeamDungeonInfoRequest)]
	[ProtoContract]
	public partial class C2T_TeamDungeonInfoRequest: Object, ITeamActorRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public long UserId { get; set; }

	}

	[Message(OuterOpcode.T2C_TeamDungeonInfoResponse)]
	[ProtoContract]
	public partial class T2C_TeamDungeonInfoResponse: Object, ITeamActorResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

		[ProtoMember(1)]
		public List<TeamInfo> TeamList = new List<TeamInfo>();

	}

//组队副本申请
	[ResponseType(nameof(T2C_TeamDungeonApplyResponse))]
	[Message(OuterOpcode.C2T_TeamDungeonApplyRequest)]
	[ProtoContract]
	public partial class C2T_TeamDungeonApplyRequest: Object, ITeamActorRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public long TeamId { get; set; }

		[ProtoMember(2)]
		public TeamPlayerInfo TeamPlayerInfo { get; set; }

	}

	[Message(OuterOpcode.T2C_TeamDungeonApplyResponse)]
	[ProtoContract]
	public partial class T2C_TeamDungeonApplyResponse: Object, ITeamActorResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

	}

//同意组队副本申请
	[ResponseType(nameof(T2C_TeamDungeonAgreeResponse))]
	[Message(OuterOpcode.C2T_TeamDungeonAgreeRequest)]
	[ProtoContract]
	public partial class C2T_TeamDungeonAgreeRequest: Object, ITeamActorRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public long TeamId { get; set; }

		[ProtoMember(2)]
		public TeamPlayerInfo TeamPlayerInfo { get; set; }

	}

	[Message(OuterOpcode.T2C_TeamDungeonAgreeResponse)]
	[ProtoContract]
	public partial class T2C_TeamDungeonAgreeResponse: Object, ITeamActorResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

	}

//创建组队副本
	[ResponseType(nameof(M2C_TeamDungeonCreateResponse))]
	[Message(OuterOpcode.C2M_TeamDungeonCreateRequest)]
	[ProtoContract]
	public partial class C2M_TeamDungeonCreateRequest: Object, IActorLocationRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public int FubenId { get; set; }

		[ProtoMember(2)]
		public TeamPlayerInfo TeamPlayerInfo { get; set; }

		[ProtoMember(3)]
		public int FubenType { get; set; }

	}

	[Message(OuterOpcode.M2C_TeamDungeonCreateResponse)]
	[ProtoContract]
	public partial class M2C_TeamDungeonCreateResponse: Object, IActorLocationResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

		[ProtoMember(1)]
		public TeamInfo TeamInfo { get; set; }

		[ProtoMember(3)]
		public int FubenType { get; set; }

	}

//开启组队副本
	[ResponseType(nameof(M2C_TeamDungeonOpenResponse))]
	[Message(OuterOpcode.C2M_TeamDungeonOpenRequest)]
	[ProtoContract]
	public partial class C2M_TeamDungeonOpenRequest: Object, IActorLocationRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public long UserID { get; set; }

		[ProtoMember(2)]
		public int FubenType { get; set; }

	}

	[Message(OuterOpcode.M2C_TeamDungeonOpenResponse)]
	[ProtoContract]
	public partial class M2C_TeamDungeonOpenResponse: Object, IActorLocationResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

		[ProtoMember(3)]
		public int FubenType { get; set; }

	}

//副本开启
	[Message(OuterOpcode.M2C_TeamDungeonOpenResult)]
	[ProtoContract]
	public partial class M2C_TeamDungeonOpenResult: Object, IActorMessage
	{
		[ProtoMember(1)]
		public TeamInfo TeamInfo { get; set; }

	}

//请求准备
	[ResponseType(nameof(M2C_TeamDungeonPrepareResponse))]
	[Message(OuterOpcode.C2M_TeamDungeonPrepareRequest)]
	[ProtoContract]
	public partial class C2M_TeamDungeonPrepareRequest: Object, IActorLocationRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public TeamInfo TeamInfo { get; set; }

		[ProtoMember(2)]
		public int Prepare { get; set; }

	}

	[Message(OuterOpcode.M2C_TeamDungeonPrepareResponse)]
	[ProtoContract]
	public partial class M2C_TeamDungeonPrepareResponse: Object, IActorLocationResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

	}

//玩家准备
	[Message(OuterOpcode.M2C_TeamDungeonPrepareResult)]
	[ProtoContract]
	public partial class M2C_TeamDungeonPrepareResult: Object, IActorMessage
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

		[ProtoMember(1)]
		public TeamInfo TeamInfo { get; set; }

		[ProtoMember(2)]
		public int ErrorCode { get; set; }

	}

//退出组队广播
	[Message(OuterOpcode.M2C_TeamDungeonQuitMessage)]
	[ProtoContract]
	public partial class M2C_TeamDungeonQuitMessage: Object, IActorMessage
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

	}

//副本选择奖励
	[ResponseType(nameof(M2C_TeamDungeonBoxRewardResponse))]
	[Message(OuterOpcode.C2M_TeamDungeonBoxRewardRequest)]
	[ProtoContract]
	public partial class C2M_TeamDungeonBoxRewardRequest: Object, IActorLocationRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public int BoxIndex { get; set; }

		[ProtoMember(2)]
		public RewardItem RewardItem { get; set; }

	}

	[Message(OuterOpcode.M2C_TeamDungeonBoxRewardResponse)]
	[ProtoContract]
	public partial class M2C_TeamDungeonBoxRewardResponse: Object, IActorLocationResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

	}

	[Message(OuterOpcode.M2C_TeamDungeonBoxRewardResult)]
	[ProtoContract]
	public partial class M2C_TeamDungeonBoxRewardResult: Object, IActorMessage
	{
		[ProtoMember(1)]
		public long UserId { get; set; }

		[ProtoMember(2)]
		public int BoxIndex { get; set; }

		[ProtoMember(3)]
		public string PlayerName { get; set; }

	}

//组队副本结算
	[Message(OuterOpcode.M2C_TeamDungeonSettlement)]
	[ProtoContract]
	public partial class M2C_TeamDungeonSettlement: Object, IActorMessage
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(92)]
		public int Error { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public long PassTime { get; set; }

		[ProtoMember(2)]
		public List<TeamPlayerInfo> PlayerList = new List<TeamPlayerInfo>();

		[ProtoMember(4)]
		public List<RewardItem> RewardExtraItem = new List<RewardItem>();

		[ProtoMember(5)]
		public List<RewardItem> ReardList = new List<RewardItem>();

		[ProtoMember(6)]
		public List<RewardItem> ReardListExcess = new List<RewardItem>();

		[ProtoMember(7)]
		public int Star { get; set; }

	}

	[Message(OuterOpcode.M2C_TeamInviteResult)]
	[ProtoContract]
	public partial class M2C_TeamInviteResult: Object, IActorMessage
	{
		[ProtoMember(1)]
		public TeamPlayerInfo TeamPlayerInfo { get; set; }

	}

	[Message(OuterOpcode.M2C_TeamDungeonApplyResult)]
	[ProtoContract]
	public partial class M2C_TeamDungeonApplyResult: Object, IActorMessage
	{
		[ProtoMember(1)]
		public TeamPlayerInfo TeamPlayerInfo { get; set; }

	}

	[Message(OuterOpcode.M2C_TeamUpdateResult)]
	[ProtoContract]
	public partial class M2C_TeamUpdateResult: Object, IActorMessage
	{
		[ProtoMember(1)]
		public TeamInfo TeamInfo { get; set; }

	}

	[Message(OuterOpcode.ChatUnitInfo)]
	[ProtoContract]
	public partial class ChatUnitInfo: Object
	{
		[ProtoMember(1)]
		public long UserId { get; set; }

		[ProtoMember(2)]
		public long UnionId { get; set; }

		[ProtoMember(6)]
		public long GateSessionActorId { get; set; }

	}

	[ResponseType(nameof(F2C_WatchPlayerResponse))]
	[Message(OuterOpcode.C2F_WatchPlayerRequest)]
	[ProtoContract]
	public partial class C2F_WatchPlayerRequest: Object, IFriendActorRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public long UserId { get; set; }

		[ProtoMember(2)]
		public int WatchType { get; set; }

	}

	[Message(OuterOpcode.F2C_WatchPlayerResponse)]
	[ProtoContract]
	public partial class F2C_WatchPlayerResponse: Object, IFriendActorResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

		[ProtoMember(1)]
		public string Name { get; set; }

		[ProtoMember(2)]
		public int Lv { get; set; }

		[ProtoMember(3)]
		public List<BagInfo> EquipList = new List<BagInfo>();

		[ProtoMember(4)]
		public long TeamId { get; set; }

		[ProtoMember(5)]
		public int Occ { get; set; }

		[ProtoMember(7)]
		public List<RolePetInfo> RolePetInfos = new List<RolePetInfo>();

		[ProtoMember(8)]
		public List<KeyValuePair> PetSkinList = new List<KeyValuePair>();

		[ProtoMember(9)]
		public List<BagInfo> PetHeXinList = new List<BagInfo>();

		[ProtoMember(11)]
		public List<int> Ks = new List<int>();

		[ProtoMember(12)]
		public List<long> Vs = new List<long>();

	}

//好友列表
	[ResponseType(nameof(F2C_FriendInfoResponse))]
	[Message(OuterOpcode.C2F_FriendInfoRequest)]
	[ProtoContract]
	public partial class C2F_FriendInfoRequest: Object, IFriendActorRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public long UserID { get; set; }

	}

	[Message(OuterOpcode.F2C_FriendInfoResponse)]
	[ProtoContract]
	public partial class F2C_FriendInfoResponse: Object, IFriendActorResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

		[ProtoMember(2)]
		public List<FriendInfo> FriendList = new List<FriendInfo>();

		[ProtoMember(3)]
		public List<FriendInfo> ApplyList = new List<FriendInfo>();

		[ProtoMember(4)]
		public List<FriendInfo> Blacklist = new List<FriendInfo>();

	}

//好友申请
	[ResponseType(nameof(F2C_FriendApplyResponse))]
	[Message(OuterOpcode.C2F_FriendApplyRequest)]
	[ProtoContract]
	public partial class C2F_FriendApplyRequest: Object, IFriendActorRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(2)]
		public long UserID { get; set; }

		[ProtoMember(1)]
		public FriendInfo RoleInfo { get; set; }

	}

	[Message(OuterOpcode.F2C_FriendApplyResponse)]
	[ProtoContract]
	public partial class F2C_FriendApplyResponse: Object, IFriendActorResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

	}

//黑名单
	[ResponseType(nameof(F2C_FriendBlacklistResponse))]
	[Message(OuterOpcode.C2F_FriendBlacklistRequest)]
	[ProtoContract]
	public partial class C2F_FriendBlacklistRequest: Object, IFriendActorRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public int OperateType { get; set; }

		[ProtoMember(2)]
		public long UserID { get; set; }

		[ProtoMember(3)]
		public long FriendId { get; set; }

	}

	[Message(OuterOpcode.F2C_FriendBlacklistResponse)]
	[ProtoContract]
	public partial class F2C_FriendBlacklistResponse: Object, IFriendActorResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

	}

	[Message(OuterOpcode.M2C_FriendApplyResult)]
	[ProtoContract]
	public partial class M2C_FriendApplyResult: Object, IActorMessage
	{
		[ProtoMember(1)]
		public FriendInfo FriendInfo { get; set; }

	}

//好友申请回复
	[ResponseType(nameof(F2C_FriendApplyReplyResponse))]
	[Message(OuterOpcode.C2F_FriendApplyReplyRequest)]
	[ProtoContract]
	public partial class C2F_FriendApplyReplyRequest: Object, IFriendActorRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public long UserID { get; set; }

		[ProtoMember(2)]
		public long FriendID { get; set; }

		[ProtoMember(3)]
		public int ReplyCode { get; set; }

	}

	[Message(OuterOpcode.F2C_FriendApplyReplyResponse)]
	[ProtoContract]
	public partial class F2C_FriendApplyReplyResponse: Object, IFriendActorResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

	}

	[Message(OuterOpcode.FriendInfo)]
	[ProtoContract]
	public partial class FriendInfo: Object
	{
		[ProtoMember(1)]
		public long UserId { get; set; }

		[ProtoMember(2)]
		public int PlayerLevel { get; set; }

		[ProtoMember(3)]
		public string PlayerName { get; set; }

		[ProtoMember(4)]
		public long OnLineTime { get; set; }

		[ProtoMember(5)]
		public List<string> ChatMsgList = new List<string>();

		[ProtoMember(6)]
		public int Occ { get; set; }

	}

	[ResponseType(nameof(M2C_UserInfoInitResponse))]
	[Message(OuterOpcode.C2M_UserInfoRequest)]
	[ProtoContract]
	public partial class C2M_UserInfoRequest: Object, IActorLocationRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

	}

	[Message(OuterOpcode.M2C_UserInfoInitResponse)]
	[ProtoContract]
	public partial class M2C_UserInfoInitResponse: Object, IActorLocationResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

		[ProtoMember(1)]
		public UserInfo UserInfo { get; set; }

		[ProtoMember(3)]
		public List<KeyValuePair> ReddontList = new List<KeyValuePair>();

		[ProtoMember(4)]
		public List<KeyValuePairInt> TreasureInfo = new List<KeyValuePairInt>();

		[ProtoMember(5)]
		public List<ShouJiChapterInfo> ShouJiChapterInfos = new List<ShouJiChapterInfo>();

		[ProtoMember(6)]
		public List<KeyValuePairInt> TitleList = new List<KeyValuePairInt>();

	}

	[Message(OuterOpcode.RechargeInfo)]
	[ProtoContract]
	public partial class RechargeInfo: Object
	{
		[ProtoMember(1)]
		public int Amount { get; set; }

		[ProtoMember(2)]
		public long Time { get; set; }

		[ProtoMember(3)]
		public long UserId { get; set; }

		[ProtoMember(4)]
		public string OrderInfo { get; set; }

	}

	[Message(OuterOpcode.ShouJiChapterInfo)]
	[ProtoContract]
	public partial class ShouJiChapterInfo: Object
	{
		[ProtoMember(1)]
		public int ChapterId { get; set; }

		[ProtoMember(2)]
		public int StarNum { get; set; }

		[ProtoMember(3)]
		public int RewardInfo { get; set; }

		[ProtoMember(4)]
		public List<int> ShouJiItemList = new List<int>();

	}

	[Message(OuterOpcode.M2C_GameNotice)]
	[ProtoContract]
	public partial class M2C_GameNotice: Object, IActorMessage
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

		[ProtoMember(1)]
		public int UpdateType { get; set; }

		[ProtoMember(2)]
		public string UpdateTypeValue { get; set; }

	}

//创建公会
	[ResponseType(nameof(M2C_UnionCreateResponse))]
	[Message(OuterOpcode.C2M_UnionCreateRequest)]
	[ProtoContract]
	public partial class C2M_UnionCreateRequest: Object, IActorLocationRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public string UnionName { get; set; }

		[ProtoMember(2)]
		public string UnionPurpose { get; set; }

	}

	[Message(OuterOpcode.M2C_UnionCreateResponse)]
	[ProtoContract]
	public partial class M2C_UnionCreateResponse: Object, IActorLocationResponse
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

//公会列表
	[ResponseType(nameof(U2C_UnionListResponse))]
	[Message(OuterOpcode.C2U_UnionListRequest)]
	[ProtoContract]
	public partial class C2U_UnionListRequest: Object, IUnionActorRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

	}

	[Message(OuterOpcode.U2C_UnionListResponse)]
	[ProtoContract]
	public partial class U2C_UnionListResponse: Object, IUnionActorResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

		[ProtoMember(1)]
		public List<UnionListItem> UnionList = new List<UnionListItem>();

	}

//申请入会
	[ResponseType(nameof(U2C_UnionApplyResponse))]
	[Message(OuterOpcode.C2U_UnionApplyRequest)]
	[ProtoContract]
	public partial class C2U_UnionApplyRequest: Object, IUnionActorRequest
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

	[Message(OuterOpcode.U2C_UnionApplyResponse)]
	[ProtoContract]
	public partial class U2C_UnionApplyResponse: Object, IUnionActorResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

	}

//我的公会
	[ResponseType(nameof(U2C_UnionMyInfoResponse))]
	[Message(OuterOpcode.C2U_UnionMyInfoRequest)]
	[ProtoContract]
	public partial class C2U_UnionMyInfoRequest: Object, IUnionActorRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public long UnionId { get; set; }

	}

	[Message(OuterOpcode.U2C_UnionMyInfoResponse)]
	[ProtoContract]
	public partial class U2C_UnionMyInfoResponse: Object, IUnionActorResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

		[ProtoMember(1)]
		public UnionInfo UnionMyInfo { get; set; }

		[ProtoMember(2)]
		public List<long> OnLinePlayer = new List<long>();

	}

//离开公会
	[ResponseType(nameof(M2C_UnionLeaveResponse))]
	[Message(OuterOpcode.C2M_UnionLeaveRequest)]
	[ProtoContract]
	public partial class C2M_UnionLeaveRequest: Object, IActorLocationRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

	}

	[Message(OuterOpcode.M2C_UnionLeaveResponse)]
	[ProtoContract]
	public partial class M2C_UnionLeaveResponse: Object, IActorLocationResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

	}

//申请列表
	[ResponseType(nameof(U2C_UnionApplyListResponse))]
	[Message(OuterOpcode.C2U_UnionApplyListRequest)]
	[ProtoContract]
	public partial class C2U_UnionApplyListRequest: Object, IUnionActorRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public long UnionId { get; set; }

	}

	[Message(OuterOpcode.U2C_UnionApplyListResponse)]
	[ProtoContract]
	public partial class U2C_UnionApplyListResponse: Object, IUnionActorResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

		[ProtoMember(10)]
		public List<UnionPlayerInfo> UnionPlayerList = new List<UnionPlayerInfo>();

	}

//申请回复
	[ResponseType(nameof(U2C_UnionApplyReplyResponse))]
	[Message(OuterOpcode.C2U_UnionApplyReplyRequest)]
	[ProtoContract]
	public partial class C2U_UnionApplyReplyRequest: Object, IUnionActorRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public long UserId { get; set; }

		[ProtoMember(2)]
		public int ReplyCode { get; set; }

		[ProtoMember(3)]
		public long UnionId { get; set; }

	}

	[Message(OuterOpcode.U2C_UnionApplyReplyResponse)]
	[ProtoContract]
	public partial class U2C_UnionApplyReplyResponse: Object, IUnionActorResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

	}

//公会操作
	[ResponseType(nameof(U2C_UnionOperatateResponse))]
	[Message(OuterOpcode.C2U_UnionOperatateRequest)]
	[ProtoContract]
	public partial class C2U_UnionOperatateRequest: Object, IUnionActorRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public long UnionId { get; set; }

		[ProtoMember(2)]
		public int Operatate { get; set; }

		[ProtoMember(3)]
		public string Value { get; set; }

	}

	[Message(OuterOpcode.U2C_UnionOperatateResponse)]
	[ProtoContract]
	public partial class U2C_UnionOperatateResponse: Object, IUnionActorResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

	}

//公会踢人
	[ResponseType(nameof(U2C_UnionKickOutResponse))]
	[Message(OuterOpcode.C2U_UnionKickOutRequest)]
	[ProtoContract]
	public partial class C2U_UnionKickOutRequest: Object, IUnionActorRequest
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

	[Message(OuterOpcode.U2C_UnionKickOutResponse)]
	[ProtoContract]
	public partial class U2C_UnionKickOutResponse: Object, IUnionActorResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

	}

	[Message(OuterOpcode.M2C_UnionApplyResult)]
	[ProtoContract]
	public partial class M2C_UnionApplyResult: Object, IActorMessage
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

	}

	[Message(OuterOpcode.UnionInfo)]
	[ProtoContract]
	public partial class UnionInfo: Object
	{
		[ProtoMember(1)]
		public string UnionName { get; set; }

		[ProtoMember(2)]
		public long LeaderId { get; set; }

		[ProtoMember(3)]
		public string LeaderName { get; set; }

		[ProtoMember(4)]
		public int LevelLimit { get; set; }

		[ProtoMember(5)]
		public string UnionPurpose { get; set; }

		[ProtoMember(6)]
		public List<long> ApplyList = new List<long>();

		[ProtoMember(7)]
		public long UnionId { get; set; }

		[ProtoMember(10)]
		public List<UnionPlayerInfo> UnionPlayerList = new List<UnionPlayerInfo>();

	}

	[Message(OuterOpcode.UnionApplyItem)]
	[ProtoContract]
	public partial class UnionApplyItem: Object
	{
		[ProtoMember(1)]
		public string PlayerName { get; set; }

		[ProtoMember(2)]
		public int PlayerLevel { get; set; }

		[ProtoMember(3)]
		public int Combat { get; set; }

	}

	[Message(OuterOpcode.UnionPlayerInfo)]
	[ProtoContract]
	public partial class UnionPlayerInfo: Object
	{
		[ProtoMember(1)]
		public string PlayerName { get; set; }

		[ProtoMember(2)]
		public int PlayerLevel { get; set; }

		[ProtoMember(3)]
		public int Position { get; set; }

		[ProtoMember(4)]
		public long UserID { get; set; }

		[ProtoMember(5)]
		public int Combat { get; set; }

	}

	[Message(OuterOpcode.UnionListItem)]
	[ProtoContract]
	public partial class UnionListItem: Object
	{
		[ProtoMember(1)]
		public string UnionName { get; set; }

		[ProtoMember(2)]
		public long UnionId { get; set; }

		[ProtoMember(3)]
		public int PlayerNumber { get; set; }

		[ProtoMember(4)]
		public int LevelLimit { get; set; }

	}

	[ResponseType(nameof(M2C_ReddotReadResponse))]
	[Message(OuterOpcode.C2M_ReddotReadRequest)]
	[ProtoContract]
	public partial class C2M_ReddotReadRequest: Object, IActorLocationRequest
	{
		[ProtoMember(1)]
		public int RpcId { get; set; }

		[ProtoMember(2)]
		public int ReddotType { get; set; }

	}

	[Message(OuterOpcode.M2C_ReddotReadResponse)]
	[ProtoContract]
	public partial class M2C_ReddotReadResponse: Object, IActorLocationResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

	}

	[ResponseType(nameof(M2C_GuideUpdateResponse))]
	[Message(OuterOpcode.C2M_GuideUpdateRequest)]
	[ProtoContract]
	public partial class C2M_GuideUpdateRequest: Object, IActorLocationRequest
	{
		[ProtoMember(1)]
		public int RpcId { get; set; }

		[ProtoMember(2)]
		public int GuideId { get; set; }

		[ProtoMember(3)]
		public int GuideStep { get; set; }

	}

	[Message(OuterOpcode.M2C_GuideUpdateResponse)]
	[ProtoContract]
	public partial class M2C_GuideUpdateResponse: Object, IActorLocationResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

	}

	[ResponseType(nameof(M2C_YeWaiSceneResponse))]
	[Message(OuterOpcode.C2M_YeWaiSceneRequest)]
	[ProtoContract]
	public partial class C2M_YeWaiSceneRequest: Object, IActorLocationRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public int SceneId { get; set; }

	}

	[Message(OuterOpcode.M2C_YeWaiSceneResponse)]
	[ProtoContract]
	public partial class M2C_YeWaiSceneResponse: Object, IActorLocationResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

	}

	[ResponseType(nameof(M2C_YeWaiSceneQuitResponse))]
	[Message(OuterOpcode.C2M_YeWaiSceneQuitRequest)]
	[ProtoContract]
	public partial class C2M_YeWaiSceneQuitRequest: Object, IActorLocationRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public int MapIndex { get; set; }

	}

	[Message(OuterOpcode.M2C_YeWaiSceneQuitResponse)]
	[ProtoContract]
	public partial class M2C_YeWaiSceneQuitResponse: Object, IActorLocationResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

	}

	[ResponseType(nameof(M2C_ShoujiRewardResponse))]
	[Message(OuterOpcode.C2M_ShoujiRewardRequest)]
	[ProtoContract]
	public partial class C2M_ShoujiRewardRequest: Object, IActorLocationRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public int ChapterId { get; set; }

		[ProtoMember(2)]
		public int RewardIndex { get; set; }

	}

	[Message(OuterOpcode.M2C_ShoujiRewardResponse)]
	[ProtoContract]
	public partial class M2C_ShoujiRewardResponse: Object, IActorLocationResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

	}

	[ResponseType(nameof(M2C_ShouJiTreasureResponse))]
//收集珍宝
	[Message(OuterOpcode.C2M_ShouJiTreasureRequest)]
	[ProtoContract]
	public partial class C2M_ShouJiTreasureRequest: Object, IActorLocationRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(1)]
		public int ShouJiId { get; set; }

		[ProtoMember(2)]
		public List<long> ItemIds = new List<long>();

	}

	[Message(OuterOpcode.M2C_ShouJiTreasureResponse)]
	[ProtoContract]
	public partial class M2C_ShouJiTreasureResponse: Object, IActorLocationResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public string Message { get; set; }

		[ProtoMember(92)]
		public int Error { get; set; }

		[ProtoMember(1)]
		public int ActiveNum { get; set; }

	}

	[ResponseType(nameof(M2C_LingDiUpResponse))]
	[Message(OuterOpcode.C2M_LingDiUpRequest)]
	[ProtoContract]
	public partial class C2M_LingDiUpRequest: Object, IActorLocationRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

	}

	[Message(OuterOpcode.M2C_LingDiUpResponse)]
	[ProtoContract]
	public partial class M2C_LingDiUpResponse: Object, IActorLocationResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

	}

	[ResponseType(nameof(M2C_LingDiRewardResponse))]
	[Message(OuterOpcode.C2M_LingDiRewardRequest)]
	[ProtoContract]
	public partial class C2M_LingDiRewardRequest: Object, IActorLocationRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public int RewardId { get; set; }

	}

	[Message(OuterOpcode.M2C_LingDiRewardResponse)]
	[ProtoContract]
	public partial class M2C_LingDiRewardResponse: Object, IActorLocationResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

	}

	[ResponseType(nameof(M2C_XiuLianCenterResponse))]
	[Message(OuterOpcode.C2M_XiuLianCenterRequest)]
	[ProtoContract]
	public partial class C2M_XiuLianCenterRequest: Object, IActorLocationRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public int XiuLianType { get; set; }

	}

	[Message(OuterOpcode.M2C_XiuLianCenterResponse)]
	[ProtoContract]
	public partial class M2C_XiuLianCenterResponse: Object, IActorLocationResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

	}

	[ResponseType(nameof(M2C_PetFubenBeginResponse))]
//宠物副本开始战斗
	[Message(OuterOpcode.C2M_PetFubenBeginRequest)]
	[ProtoContract]
	public partial class C2M_PetFubenBeginRequest: Object, IActorLocationRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

	}

	[Message(OuterOpcode.M2C_PetFubenBeginResponse)]
	[ProtoContract]
	public partial class M2C_PetFubenBeginResponse: Object, IActorLocationResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

	}

//宠物副本结束战斗
	[Message(OuterOpcode.C2M_PetFubenOverRequest)]
	[ProtoContract]
	public partial class C2M_PetFubenOverRequest: Object, IActorLocationMessage
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

	}

	[ResponseType(nameof(M2C_PetFubenRewardResponse))]
//宠物副本星级奖励
	[Message(OuterOpcode.C2M_PetFubenRewardRequest)]
	[ProtoContract]
	public partial class C2M_PetFubenRewardRequest: Object, IActorLocationRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

	}

	[Message(OuterOpcode.M2C_PetFubenRewardResponse)]
	[ProtoContract]
	public partial class M2C_PetFubenRewardResponse: Object, IActorLocationResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

	}

	[ResponseType(nameof(M2C_HongBaoOpenResponse))]
//开启红包
	[Message(OuterOpcode.C2M_HongBaoOpenRequest)]
	[ProtoContract]
	public partial class C2M_HongBaoOpenRequest: Object, IActorLocationRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

	}

	[Message(OuterOpcode.M2C_HongBaoOpenResponse)]
	[ProtoContract]
	public partial class M2C_HongBaoOpenResponse: Object, IActorLocationResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

		[ProtoMember(1)]
		public int HongbaoAmount { get; set; }

	}

	[ResponseType(nameof(M2C_RandomTowerBeginResponse))]
//随机副本开始战斗
	[Message(OuterOpcode.C2M_RandomTowerBeginRequest)]
	[ProtoContract]
	public partial class C2M_RandomTowerBeginRequest: Object, IActorLocationRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public int RandomNumber { get; set; }

	}

	[Message(OuterOpcode.M2C_RandomTowerBeginResponse)]
	[ProtoContract]
	public partial class M2C_RandomTowerBeginResponse: Object, IActorLocationResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

	}

	[ResponseType(nameof(M2C_RandomTowerRewardResponse))]
//随机副本领取奖励
	[Message(OuterOpcode.C2M_RandomTowerRewardRequest)]
	[ProtoContract]
	public partial class C2M_RandomTowerRewardRequest: Object, IActorLocationRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public int RewardId { get; set; }

	}

	[Message(OuterOpcode.M2C_RandomTowerRewardResponse)]
	[ProtoContract]
	public partial class M2C_RandomTowerRewardResponse: Object, IActorLocationResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

	}

	[ResponseType(nameof(M2C_PetHeXinHeChengResponse))]
//宠物之核合成
	[Message(OuterOpcode.C2M_PetHeXinHeChengRequest)]
	[ProtoContract]
	public partial class C2M_PetHeXinHeChengRequest: Object, IActorLocationRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public long BagInfoID_1 { get; set; }

		[ProtoMember(2)]
		public long BagInfoID_2 { get; set; }

	}

	[Message(OuterOpcode.M2C_PetHeXinHeChengResponse)]
	[ProtoContract]
	public partial class M2C_PetHeXinHeChengResponse: Object, IActorLocationResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

	}

	[ResponseType(nameof(M2C_ChouKaRewardResponse))]
	[Message(OuterOpcode.C2M_ChouKaRewardRequest)]
	[ProtoContract]
	public partial class C2M_ChouKaRewardRequest: Object, IActorLocationRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public int RewardId { get; set; }

	}

	[Message(OuterOpcode.M2C_ChouKaRewardResponse)]
	[ProtoContract]
	public partial class M2C_ChouKaRewardResponse: Object, IActorLocationResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

	}

	[ResponseType(nameof(M2C_RoleAddPointResponse))]
	[Message(OuterOpcode.C2M_RoleAddPointRequest)]
	[ProtoContract]
	public partial class C2M_RoleAddPointRequest: Object, IActorLocationRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(6)]
		public List<int> PointList = new List<int>();

	}

	[Message(OuterOpcode.M2C_RoleAddPointResponse)]
	[ProtoContract]
	public partial class M2C_RoleAddPointResponse: Object, IActorLocationResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public string Message { get; set; }

		[ProtoMember(92)]
		public int Error { get; set; }

	}

	[ResponseType(nameof(R2C_CampRankListResponse))]
	[Message(OuterOpcode.C2R_CampRankListRequest)]
	[ProtoContract]
	public partial class C2R_CampRankListRequest: Object, IRankActorRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

	}

	[Message(OuterOpcode.R2C_CampRankListResponse)]
	[ProtoContract]
	public partial class R2C_CampRankListResponse: Object, IRankActorResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public string Message { get; set; }

		[ProtoMember(92)]
		public int Error { get; set; }

		[ProtoMember(1)]
		public List<RankingInfo> RankList_1 = new List<RankingInfo>();

		[ProtoMember(2)]
		public List<RankingInfo> RankList_2 = new List<RankingInfo>();

	}

	[ResponseType(nameof(M2C_CampRankSelectResponse))]
	[Message(OuterOpcode.C2M_CampRankSelectRequest)]
	[ProtoContract]
	public partial class C2M_CampRankSelectRequest: Object, IActorLocationRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(1)]
		public int CampId { get; set; }

	}

	[Message(OuterOpcode.M2C_CampRankSelectResponse)]
	[ProtoContract]
	public partial class M2C_CampRankSelectResponse: Object, IActorLocationResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public string Message { get; set; }

		[ProtoMember(92)]
		public int Error { get; set; }

	}

	[ResponseType(nameof(M2C_RoleOpenCangKuResponse))]
	[Message(OuterOpcode.C2M_RoleOpenCangKuRequest)]
	[ProtoContract]
	public partial class C2M_RoleOpenCangKuRequest: Object, IActorLocationRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

	}

	[Message(OuterOpcode.M2C_RoleOpenCangKuResponse)]
	[ProtoContract]
	public partial class M2C_RoleOpenCangKuResponse: Object, IActorLocationResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public string Message { get; set; }

		[ProtoMember(92)]
		public int Error { get; set; }

	}

	[ResponseType(nameof(M2C_PetEggDuiHuanResponse))]
	[Message(OuterOpcode.C2M_PetEggDuiHuanRequest)]
	[ProtoContract]
	public partial class C2M_PetEggDuiHuanRequest: Object, IActorLocationRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(1)]
		public int ChouKaId { get; set; }

	}

	[Message(OuterOpcode.M2C_PetEggDuiHuanResponse)]
	[ProtoContract]
	public partial class M2C_PetEggDuiHuanResponse: Object, IActorLocationResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public string Message { get; set; }

		[ProtoMember(92)]
		public int Error { get; set; }

		[ProtoMember(1)]
		public List<RewardItem> ReardList = new List<RewardItem>();

	}

	[ResponseType(nameof(M2C_PetEggChouKaResponse))]
	[Message(OuterOpcode.C2M_PetEggChouKaRequest)]
	[ProtoContract]
	public partial class C2M_PetEggChouKaRequest: Object, IActorLocationRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(1)]
		public int ChouKaType { get; set; }

	}

	[Message(OuterOpcode.M2C_PetEggChouKaResponse)]
	[ProtoContract]
	public partial class M2C_PetEggChouKaResponse: Object, IActorLocationResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public string Message { get; set; }

		[ProtoMember(92)]
		public int Error { get; set; }

		[ProtoMember(1)]
		public List<RewardItem> ReardList = new List<RewardItem>();

	}

	[ResponseType(nameof(M2C_RolePetEggPutOut))]
//宠物蛋卸下
	[Message(OuterOpcode.C2M_RolePetEggPutOut)]
	[ProtoContract]
	public partial class C2M_RolePetEggPutOut: Object, IActorLocationRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(2)]
		public int Index { get; set; }

	}

	[Message(OuterOpcode.M2C_RolePetEggPutOut)]
	[ProtoContract]
	public partial class M2C_RolePetEggPutOut: Object, IActorLocationResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public string Message { get; set; }

		[ProtoMember(92)]
		public int Error { get; set; }

		[ProtoMember(1)]
		public RolePetEgg RolePetEgg { get; set; }

	}

	[ResponseType(nameof(M2C_PetHeXinHeChengQuickResponse))]
//宠物之核一键合成
	[Message(OuterOpcode.C2M_PetHeXinHeChengQuickRequest)]
	[ProtoContract]
	public partial class C2M_PetHeXinHeChengQuickRequest: Object, IActorLocationRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

	}

	[Message(OuterOpcode.M2C_PetHeXinHeChengQuickResponse)]
	[ProtoContract]
	public partial class M2C_PetHeXinHeChengQuickResponse: Object, IActorLocationResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

	}

	[Message(OuterOpcode.ServerInfo)]
	[ProtoContract]
	public partial class ServerInfo: Object
	{
		[ProtoMember(1)]
		public int WorldLv { get; set; }

		[ProtoMember(2)]
		public long ExChangeGold { get; set; }

		[ProtoMember(4)]
		public RankingInfo RankingInfo { get; set; }

	}

	[ResponseType(nameof(R2C_WorldLvResponse))]
	[Message(OuterOpcode.C2R_WorldLvRequest)]
	[ProtoContract]
	public partial class C2R_WorldLvRequest: Object, IRankActorRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public int RankType { get; set; }

	}

	[Message(OuterOpcode.R2C_WorldLvResponse)]
	[ProtoContract]
	public partial class R2C_WorldLvResponse: Object, IRankActorResponse
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

	[ResponseType(nameof(M2C_ExpToGoldResponse))]
	[Message(OuterOpcode.C2M_ExpToGoldRequest)]
	[ProtoContract]
	public partial class C2M_ExpToGoldRequest: Object, IActorLocationRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public int OperateType { get; set; }

	}

	[Message(OuterOpcode.M2C_ExpToGoldResponse)]
	[ProtoContract]
	public partial class M2C_ExpToGoldResponse: Object, IActorLocationResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

	}

	[ResponseType(nameof(M2C_MakeSelectResponse))]
	[Message(OuterOpcode.C2M_MakeSelectRequest)]
	[ProtoContract]
	public partial class C2M_MakeSelectRequest: Object, IActorLocationRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public int MakeType { get; set; }

	}

	[Message(OuterOpcode.M2C_MakeSelectResponse)]
	[ProtoContract]
	public partial class M2C_MakeSelectResponse: Object, IActorLocationResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

		[ProtoMember(1)]
		public List<int> MakeList = new List<int>();

	}

	[Message(OuterOpcode.FirstWinInfo)]
	[ProtoContract]
	public partial class FirstWinInfo: Object
	{
		[ProtoMember(1)]
		public long UserId { get; set; }

		[ProtoMember(2)]
		public int FirstWinId { get; set; }

		[ProtoMember(3)]
		public string PlayerName { get; set; }

		[ProtoMember(4)]
		public long KillTime { get; set; }

		[ProtoMember(5)]
		public int Difficulty { get; set; }

	}

	[ResponseType(nameof(A2C_FirstWinInfoResponse))]
	[Message(OuterOpcode.C2A_FirstWinInfoRequest)]
	[ProtoContract]
	public partial class C2A_FirstWinInfoRequest: Object, IActivityActorRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

	}

	[Message(OuterOpcode.A2C_FirstWinInfoResponse)]
	[ProtoContract]
	public partial class A2C_FirstWinInfoResponse: Object, IActivityActorResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

		[ProtoMember(1)]
		public List<FirstWinInfo> FirstWinInfos = new List<FirstWinInfo>();

	}

	[ResponseType(nameof(M2C_ItemXiLianRewardResponse))]
	[Message(OuterOpcode.C2M_ItemXiLianRewardRequest)]
	[ProtoContract]
	public partial class C2M_ItemXiLianRewardRequest: Object, IActorLocationRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public int XiLianId { get; set; }

	}

	[Message(OuterOpcode.M2C_ItemXiLianRewardResponse)]
	[ProtoContract]
	public partial class M2C_ItemXiLianRewardResponse: Object, IActorLocationResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

	}

	[ResponseType(nameof(M2C_BuChangeResponse))]
	[Message(OuterOpcode.C2M_BuChangeRequest)]
	[ProtoContract]
	public partial class C2M_BuChangeRequest: Object, IActorLocationRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public long BuChangId { get; set; }

	}

	[Message(OuterOpcode.M2C_BuChangeResponse)]
	[ProtoContract]
	public partial class M2C_BuChangeResponse: Object, IActorLocationResponse
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
		public int BuChangRecharge { get; set; }

		[ProtoMember(3)]
		public int BuChangDiamond { get; set; }

	}

	[Message(OuterOpcode.ItemXiLianResult)]
	[ProtoContract]
	public partial class ItemXiLianResult: Object
	{
		[ProtoMember(1)]
		public List<HideProList> XiLianHideProLists = new List<HideProList>();

		[ProtoMember(2)]
		public List<int> HideSkillLists = new List<int>();

		[ProtoMember(3)]
		public List<HideProList> XiLianHideTeShuProLists = new List<HideProList>();

	}

	[ResponseType(nameof(M2C_ItemXiLianSelectResponse))]
//洗练装备
	[Message(OuterOpcode.C2M_ItemXiLianSelectRequest)]
	[ProtoContract]
	public partial class C2M_ItemXiLianSelectRequest: Object, IActorLocationRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(2)]
		public long OperateBagID { get; set; }

		[ProtoMember(1)]
		public ItemXiLianResult ItemXiLianResult { get; set; }

	}

	[Message(OuterOpcode.M2C_ItemXiLianSelectResponse)]
	[ProtoContract]
	public partial class M2C_ItemXiLianSelectResponse: Object, IActorLocationResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public string Message { get; set; }

		[ProtoMember(92)]
		public int Error { get; set; }

	}

	[ResponseType(nameof(M2C_ItemXiLianTransferResponse))]
//洗练转移
	[Message(OuterOpcode.C2M_ItemXiLianTransferRequest)]
	[ProtoContract]
	public partial class C2M_ItemXiLianTransferRequest: Object, IActorLocationRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(1)]
		public long OperateBagID_1 { get; set; }

		[ProtoMember(2)]
		public long OperateBagID_2 { get; set; }

	}

	[Message(OuterOpcode.M2C_ItemXiLianTransferResponse)]
	[ProtoContract]
	public partial class M2C_ItemXiLianTransferResponse: Object, IActorLocationResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public string Message { get; set; }

		[ProtoMember(92)]
		public int Error { get; set; }

	}

	[ResponseType(nameof(G2C_ExitGameGate))]
	[Message(OuterOpcode.C2G_ExitGameGate)]
	[ProtoContract]
	public partial class C2G_ExitGameGate: Object, IRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(1)]
		public string Key { get; set; }

		[ProtoMember(2)]
		public long RoleId { get; set; }

		[ProtoMember(3)]
		public long Account { get; set; }

	}

	[Message(OuterOpcode.G2C_ExitGameGate)]
	[ProtoContract]
	public partial class G2C_ExitGameGate: Object, IResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

// 自己的unit id
		[ProtoMember(1)]
		public long PlayerId { get; set; }

	}

	[ResponseType(nameof(M2C_ItemOperateGemResponse))]
	[Message(OuterOpcode.C2M_ItemOperateGemRequest)]
	[ProtoContract]
	public partial class C2M_ItemOperateGemRequest: Object, IActorLocationRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(1)]
		public int OperateType { get; set; }

		[ProtoMember(2)]
		public long OperateBagID { get; set; }

		[ProtoMember(3)]
		public string OperatePar { get; set; }

	}

	[Message(OuterOpcode.M2C_ItemOperateGemResponse)]
	[ProtoContract]
	public partial class M2C_ItemOperateGemResponse: Object, IActorLocationResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public string Message { get; set; }

		[ProtoMember(92)]
		public int Error { get; set; }

		[ProtoMember(1)]
		public string OperatePar { get; set; }

	}

	[ResponseType(nameof(M2C_PetDuiHuanResponse))]
	[Message(OuterOpcode.C2M_PetDuiHuanRequest)]
	[ProtoContract]
	public partial class C2M_PetDuiHuanRequest: Object, IActorLocationRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(1)]
		public int OperateId { get; set; }

	}

	[Message(OuterOpcode.M2C_PetDuiHuanResponse)]
	[ProtoContract]
	public partial class M2C_PetDuiHuanResponse: Object, IActorLocationResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public string Message { get; set; }

		[ProtoMember(92)]
		public int Error { get; set; }

		[ProtoMember(1)]
		public RolePetInfo RolePetInfo { get; set; }

	}

//领取充值签到奖励
	[ResponseType(nameof(M2C_ActivityRechargeSignResponse))]
	[Message(OuterOpcode.C2M_ActivityRechargeSignRequest)]
	[ProtoContract]
	public partial class C2M_ActivityRechargeSignRequest: Object, IActorLocationRequest
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

	[Message(OuterOpcode.M2C_ActivityRechargeSignResponse)]
	[ProtoContract]
	public partial class M2C_ActivityRechargeSignResponse: Object, IActorLocationResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

	}

//组队副本返回
	[Message(OuterOpcode.C2M_TeamDungeonRBornRequest)]
	[ProtoContract]
	public partial class C2M_TeamDungeonRBornRequest: Object, IActorLocationMessage
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

	}

	[Message(OuterOpcode.M2C_TeamDungeonRBornResult)]
	[ProtoContract]
	public partial class M2C_TeamDungeonRBornResult: Object, IActorMessage
	{
		[ProtoMember(1)]
		public long ActorId { get; set; }

		[ProtoMember(2)]
		public long UnitId { get; set; }

		[ProtoMember(3)]
		public float X { get; set; }

		[ProtoMember(4)]
		public float Y { get; set; }

		[ProtoMember(5)]
		public float Z { get; set; }

	}

//重连成功刷新Unit
	[Message(OuterOpcode.C2M_RefreshUnitRequest)]
	[ProtoContract]
	public partial class C2M_RefreshUnitRequest: Object, IActorLocationMessage
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

	}

	[Message(OuterOpcode.M2C_BattleInfoResult)]
	[ProtoContract]
	public partial class M2C_BattleInfoResult: Object, IActorMessage
	{
		[ProtoMember(1)]
		public long ActorId { get; set; }

		[ProtoMember(2)]
		public long UnitId { get; set; }

		[ProtoMember(3)]
		public int CampKill_1 { get; set; }

		[ProtoMember(4)]
		public int CampKill_2 { get; set; }

	}

//循环赏金任务
	[ResponseType(nameof(M2C_TaskLoopGetResponse))]
	[Message(OuterOpcode.C2M_TaskLoopGetRequest)]
	[ProtoContract]
	public partial class C2M_TaskLoopGetRequest: Object, IActorLocationRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(1)]
		public int TaskId { get; set; }

	}

	[Message(OuterOpcode.M2C_TaskLoopGetResponse)]
	[ProtoContract]
	public partial class M2C_TaskLoopGetResponse: Object, IActorLocationResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

		[ProtoMember(1)]
		public TaskPro TaskLoop { get; set; }

	}

//紫色道具判断是否需要拾取
	[Message(OuterOpcode.M2C_TeamPickMessage)]
	[ProtoContract]
	public partial class M2C_TeamPickMessage: Object, IActorMessage
	{
		[ProtoMember(1)]
		public long ActorId { get; set; }

		[ProtoMember(2)]
		public long UnitId { get; set; }

		[ProtoMember(3)]
		public List<DropInfo> DropItems = new List<DropInfo>();

	}

	[Message(OuterOpcode.C2M_TeamPickRequest)]
	[ProtoContract]
	public partial class C2M_TeamPickRequest: Object, IActorLocationMessage
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(1)]
		public DropInfo DropItem { get; set; }

		[ProtoMember(2)]
		public int Need { get; set; }

	}

	[ResponseType(nameof(G2C_ExitGameGate))]
	[Message(OuterOpcode.C2G_LoginRobotRequest)]
	[ProtoContract]
	public partial class C2G_LoginRobotRequest: Object, IRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(1)]
		public string Key { get; set; }

		[ProtoMember(2)]
		public long RoleId { get; set; }

		[ProtoMember(3)]
		public long Account { get; set; }

	}

	[Message(OuterOpcode.G2C_LoginRobotResponse)]
	[ProtoContract]
	public partial class G2C_LoginRobotResponse: Object, IResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

// 自己的unit id
		[ProtoMember(1)]
		public long PlayerId { get; set; }

	}

//试炼副本结束
	[ResponseType(nameof(M2C_TrialDungeonFinishResponse))]
	[Message(OuterOpcode.C2M_TrialDungeonFinishRequest)]
	[ProtoContract]
	public partial class C2M_TrialDungeonFinishRequest: Object, IActorLocationRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

	}

	[Message(OuterOpcode.M2C_TrialDungeonFinishResponse)]
	[ProtoContract]
	public partial class M2C_TrialDungeonFinishResponse: Object, IActorLocationResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

		[ProtoMember(1)]
		public int CombatResult { get; set; }

	}

//试炼副本开始
	[ResponseType(nameof(M2C_TrialDungeonBeginResponse))]
	[Message(OuterOpcode.C2M_TrialDungeonBeginRequest)]
	[ProtoContract]
	public partial class C2M_TrialDungeonBeginRequest: Object, IActorLocationRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

	}

	[Message(OuterOpcode.M2C_TrialDungeonBeginResponse)]
	[ProtoContract]
	public partial class M2C_TrialDungeonBeginResponse: Object, IActorLocationResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

	}

//上下马
	[ResponseType(nameof(M2C_HorseRideResponse))]
	[Message(OuterOpcode.C2M_HorseRideRequest)]
	[ProtoContract]
	public partial class C2M_HorseRideRequest: Object, IActorLocationRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(1)]
		public int HorseId { get; set; }

		[ProtoMember(2)]
		public int OperateType { get; set; }

	}

	[Message(OuterOpcode.M2C_HorseRideResponse)]
	[ProtoContract]
	public partial class M2C_HorseRideResponse: Object, IActorLocationResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

	}

//坐骑出战
	[ResponseType(nameof(M2C_HorseFightResponse))]
	[Message(OuterOpcode.C2M_HorseFightRequest)]
	[ProtoContract]
	public partial class C2M_HorseFightRequest: Object, IActorLocationRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(1)]
		public int HorseId { get; set; }

		[ProtoMember(2)]
		public int OperateType { get; set; }

	}

	[Message(OuterOpcode.M2C_HorseFightResponse)]
	[ProtoContract]
	public partial class M2C_HorseFightResponse: Object, IActorLocationResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

	}

	[ResponseType(nameof(M2C_TowerFightBeginResponse))]
//挑战之地开始战斗
	[Message(OuterOpcode.C2M_TowerFightBeginRequest)]
	[ProtoContract]
	public partial class C2M_TowerFightBeginRequest: Object, IActorLocationRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

	}

	[Message(OuterOpcode.M2C_TowerFightBeginResponse)]
	[ProtoContract]
	public partial class M2C_TowerFightBeginResponse: Object, IActorLocationResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

	}

	[ResponseType(nameof(M2C_TowerExitResponse))]
	[Message(OuterOpcode.C2M_TowerExitRequest)]
	[ProtoContract]
	public partial class C2M_TowerExitRequest: Object, IActorLocationRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

	}

	[Message(OuterOpcode.M2C_TowerExitResponse)]
	[ProtoContract]
	public partial class M2C_TowerExitResponse: Object, IActorLocationResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

	}

	[ResponseType(nameof(C2C_SendBroadcastResponse))]
	[Message(OuterOpcode.C2C_SendBroadcastRequest)]
	[ProtoContract]
	public partial class C2C_SendBroadcastRequest: Object, IChatActorRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public ChatInfo ChatInfo { get; set; }

		[ProtoMember(2)]
		public int ZoneType { get; set; }

	}

	[Message(OuterOpcode.C2C_SendBroadcastResponse)]
	[ProtoContract]
	public partial class C2C_SendBroadcastResponse: Object, IChatActorResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

	}

//终止技能
	[Message(OuterOpcode.M2C_UnitFinishSkill)]
	[ProtoContract]
	public partial class M2C_UnitFinishSkill: Object, IActorMessage
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public long UnitId { get; set; }

	}

	[Message(OuterOpcode.M2C_SyncMiJingDamage)]
	[ProtoContract]
	public partial class M2C_SyncMiJingDamage: Object, IActorMessage
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public List<TeamPlayerInfo> DamageList = new List<TeamPlayerInfo>();

	}

	[ResponseType(nameof(M2C_FubenTimesResetResponse))]
	[Message(OuterOpcode.C2M_FubenTimesResetRequest)]
	[ProtoContract]
	public partial class C2M_FubenTimesResetRequest: Object, IActorLocationRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public int SceneType { get; set; }

	}

	[Message(OuterOpcode.M2C_FubenTimesResetResponse)]
	[ProtoContract]
	public partial class M2C_FubenTimesResetResponse: Object, IActorLocationResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

	}

	[ResponseType(nameof(M2C_IOSPayVerifyResponse))]
	[Message(OuterOpcode.C2M_IOSPayVerifyRequest)]
	[ProtoContract]
	public partial class C2M_IOSPayVerifyRequest: Object, IActorLocationRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(2)]
		public string payMessage { get; set; }

	}

	[Message(OuterOpcode.M2C_IOSPayVerifyResponse)]
	[ProtoContract]
	public partial class M2C_IOSPayVerifyResponse: Object, IActorLocationResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

	}

//通用协议 应急用
	[ResponseType(nameof(M2C_FubenMessageResponse))]
	[Message(OuterOpcode.C2M_FubenMessageRequest)]
	[ProtoContract]
	public partial class C2M_FubenMessageRequest: Object, IActorLocationRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public int SceneType { get; set; }

		[ProtoMember(2)]
		public int MessageType { get; set; }

	}

	[Message(OuterOpcode.M2C_FubenMessageResponse)]
	[ProtoContract]
	public partial class M2C_FubenMessageResponse: Object, IActorLocationResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

		[ProtoMember(1)]
		public string MessageValue { get; set; }

	}

///////Max OpcodeID
	[Message(OuterOpcode.M2C_UpdateVersion)]
	[ProtoContract]
	public partial class M2C_UpdateVersion: Object, IActorMessage
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public int Version { get; set; }

	}

	[ResponseType(nameof(M2C_ShareSucessResponse))]
	[Message(OuterOpcode.C2M_ShareSucessRequest)]
	[ProtoContract]
	public partial class C2M_ShareSucessRequest: Object, IActorLocationRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public int ShareType { get; set; }

	}

	[Message(OuterOpcode.M2C_ShareSucessResponse)]
	[ProtoContract]
	public partial class M2C_ShareSucessResponse: Object, IActorLocationResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

	}

	[ResponseType(nameof(M2C_UnitInfoResponse))]
	[Message(OuterOpcode.C2M_UnitInfoRequest)]
	[ProtoContract]
	public partial class C2M_UnitInfoRequest: Object, IActorLocationRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

	}

	[Message(OuterOpcode.M2C_UnitInfoResponse)]
	[ProtoContract]
	public partial class M2C_UnitInfoResponse: Object, IActorLocationResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

		[ProtoMember(6)]
		public List<int> Ks = new List<int>();

		[ProtoMember(7)]
		public List<long> Vs = new List<long>();

	}

	[ResponseType(nameof(Center2C_DeleteAccountResponse))]
	[Message(OuterOpcode.C2Center_DeleteAccountRequest)]
	[ProtoContract]
	public partial class C2Center_DeleteAccountRequest: Object, IRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(1)]
		public string Account { get; set; }

		[ProtoMember(2)]
		public string Password { get; set; }

	}

	[Message(OuterOpcode.Center2C_DeleteAccountResponse)]
	[ProtoContract]
	public partial class Center2C_DeleteAccountResponse: Object, IResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

	}

	[ResponseType(nameof(R2C_IOSPayVerifyResponse))]
	[Message(OuterOpcode.C2R_IOSPayVerifyRequest)]
	[ProtoContract]
	public partial class C2R_IOSPayVerifyRequest: Object, IRechargeActorRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public long UnitId { get; set; }

		[ProtoMember(2)]
		public string payMessage { get; set; }

	}

	[Message(OuterOpcode.R2C_IOSPayVerifyResponse)]
	[ProtoContract]
	public partial class R2C_IOSPayVerifyResponse: Object, IRechargeActorResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

	}

//技能打断
	[Message(OuterOpcode.C2M_SkillInterruptRequest)]
	[ProtoContract]
	public partial class C2M_SkillInterruptRequest: Object, IActorLocationMessage
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public int SkillID { get; set; }

	}

	[Message(OuterOpcode.M2C_SkillInterruptResult)]
	[ProtoContract]
	public partial class M2C_SkillInterruptResult: Object, IActorMessage
	{
		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public long UnitId { get; set; }

		[ProtoMember(2)]
		public int SkillId { get; set; }

	}

	[ResponseType(nameof(M2C_RolePetUpStage))]
//宠物进化
	[Message(OuterOpcode.C2M_RolePetUpStage)]
	[ProtoContract]
	public partial class C2M_RolePetUpStage: Object, IActorLocationRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(1)]
		public long PetInfoId { get; set; }

		[ProtoMember(2)]
		public long PetInfoXianJiId { get; set; }

	}

	[Message(OuterOpcode.M2C_RolePetUpStage)]
	[ProtoContract]
	public partial class M2C_RolePetUpStage: Object, IActorLocationResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public string Message { get; set; }

		[ProtoMember(92)]
		public int Error { get; set; }

		[ProtoMember(1)]
		public RolePetInfo OldPetInfo { get; set; }

		[ProtoMember(2)]
		public RolePetInfo NewPetInfo { get; set; }

	}

	[ResponseType(nameof(Center2C_PhoneBinging))]
//手机号绑定
	[Message(OuterOpcode.C2Center_PhoneBinging)]
	[ProtoContract]
	public partial class C2Center_PhoneBinging: Object, IRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(1)]
		public string PhoneNumber { get; set; }

		[ProtoMember(2)]
		public long AccountId { get; set; }

		[ProtoMember(3)]
		public string Account { get; set; }

		[ProtoMember(4)]
		public string Password { get; set; }

	}

	[Message(OuterOpcode.Center2C_PhoneBinging)]
	[ProtoContract]
	public partial class Center2C_PhoneBinging: Object, IResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

	}

	[ResponseType(nameof(M2C_ItemTreasureOpenResponse))]
//藏宝图开启
	[Message(OuterOpcode.C2M_ItemTreasureOpenRequest)]
	[ProtoContract]
	public partial class C2M_ItemTreasureOpenRequest: Object, IActorLocationRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(1)]
		public int OperateType { get; set; }

		[ProtoMember(2)]
		public long OperateBagID { get; set; }

		[ProtoMember(3)]
		public string OperatePar { get; set; }

	}

	[Message(OuterOpcode.M2C_ItemTreasureOpenResponse)]
	[ProtoContract]
	public partial class M2C_ItemTreasureOpenResponse: Object, IActorLocationResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public string Message { get; set; }

		[ProtoMember(92)]
		public int Error { get; set; }

		[ProtoMember(1)]
		public string OperatePar { get; set; }

		[ProtoMember(5)]
		public RewardItem ReardItem { get; set; }

	}

	[ResponseType(nameof(A2C_ActivityInfoResponse))]
	[Message(OuterOpcode.C2A_ActivityInfoRequest)]
	[ProtoContract]
	public partial class C2A_ActivityInfoRequest: Object, IActivityActorRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public int ActivityType { get; set; }

	}

	[Message(OuterOpcode.A2C_ActivityInfoResponse)]
	[ProtoContract]
	public partial class A2C_ActivityInfoResponse: Object, IActivityActorResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

		[ProtoMember(1)]
		public string ActivityContent { get; set; }

	}

	[Message(OuterOpcode.ActivityInfo)]
	[ProtoContract]
	public partial class ActivityInfo: Object
	{
		[ProtoMember(1)]
		public int WeeklyTask { get; set; }

		[ProtoMember(2)]
		public string ActivityContent { get; set; }

	}

//激活称号
	[ResponseType(nameof(M2C_TitleUseResponse))]
	[Message(OuterOpcode.C2M_TitleUseRequest)]
	[ProtoContract]
	public partial class C2M_TitleUseRequest: Object, IActorLocationRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(1)]
		public int TitleId { get; set; }

		[ProtoMember(2)]
		public int OperateType { get; set; }

	}

	[Message(OuterOpcode.M2C_TitleUseResponse)]
	[ProtoContract]
	public partial class M2C_TitleUseResponse: Object, IActorLocationResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

	}

	[Message(OuterOpcode.M2C_TitleUpdateResult)]
	[ProtoContract]
	public partial class M2C_TitleUpdateResult: Object, IActorMessage
	{
		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public long UnitId { get; set; }

		[ProtoMember(6)]
		public List<KeyValuePairInt> TitleList = new List<KeyValuePairInt>();

	}

	[Message(OuterOpcode.M2C_AreneInfoResult)]
	[ProtoContract]
	public partial class M2C_AreneInfoResult: Object, IActorMessage
	{
		[ProtoMember(1)]
		public long ActorId { get; set; }

		[ProtoMember(2)]
		public long UnitId { get; set; }

		[ProtoMember(3)]
		public int LeftPlayer { get; set; }

		[ProtoMember(4)]
		public string Message { get; set; }

	}

	[ResponseType(nameof(M2C_LifeShieldCostResponse))]
	[Message(OuterOpcode.C2M_LifeShieldCostRequest)]
	[ProtoContract]
	public partial class C2M_LifeShieldCostRequest: Object, IActorLocationRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(1)]
		public int OperateType { get; set; }

		[ProtoMember(2)]
		public List<long> OperateBagID = new List<long>();

	}

	[Message(OuterOpcode.M2C_LifeShieldCostResponse)]
	[ProtoContract]
	public partial class M2C_LifeShieldCostResponse: Object, IActorLocationResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

		[ProtoMember(1)]
		public List<LifeShieldInfo> ShieldList = new List<LifeShieldInfo>();

		[ProtoMember(2)]
		public int AddExp { get; set; }

	}

	[ResponseType(nameof(M2C_ItemSplitResponse))]
	[Message(OuterOpcode.C2M_ItemSplitRequest)]
	[ProtoContract]
	public partial class C2M_ItemSplitRequest: Object, IActorLocationRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(1)]
		public int OperateType { get; set; }

		[ProtoMember(2)]
		public long OperateBagID { get; set; }

		[ProtoMember(3)]
		public string OperatePar { get; set; }

	}

	[Message(OuterOpcode.M2C_ItemSplitResponse)]
	[ProtoContract]
	public partial class M2C_ItemSplitResponse: Object, IActorLocationResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public string Message { get; set; }

		[ProtoMember(92)]
		public int Error { get; set; }

		[ProtoMember(1)]
		public string OperatePar { get; set; }

	}

//副本击杀boss
	[Message(OuterOpcode.M2C_TeamDungeonKillBossMessage)]
	[ProtoContract]
	public partial class M2C_TeamDungeonKillBossMessage: Object, IActorMessage
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

		[ProtoMember(1)]
		public List<int> KillBossList = new List<int>();

	}

	[Message(OuterOpcode.M2C_KickPlayerMessage)]
	[ProtoContract]
	public partial class M2C_KickPlayerMessage: Object, IActorMessage
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

	}

//出战精灵
	[ResponseType(nameof(M2C_JingLingUseResponse))]
	[Message(OuterOpcode.C2M_JingLingUseRequest)]
	[ProtoContract]
	public partial class C2M_JingLingUseRequest: Object, IActorLocationRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(1)]
		public int JingLingId { get; set; }

		[ProtoMember(2)]
		public int OperateType { get; set; }

	}

	[Message(OuterOpcode.M2C_JingLingUseResponse)]
	[ProtoContract]
	public partial class M2C_JingLingUseResponse: Object, IActorLocationResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

		[ProtoMember(1)]
		public int JingLingId { get; set; }

	}

//抓捕精灵
	[ResponseType(nameof(M2C_JingLingCatchResponse))]
	[Message(OuterOpcode.C2M_JingLingCatchRequest)]
	[ProtoContract]
	public partial class C2M_JingLingCatchRequest: Object, IActorLocationRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(1)]
		public long JingLingId { get; set; }

		[ProtoMember(2)]
		public int ItemId { get; set; }

		[ProtoMember(5)]
		public string OperateType { get; set; }

	}

	[Message(OuterOpcode.M2C_JingLingCatchResponse)]
	[ProtoContract]
	public partial class M2C_JingLingCatchResponse: Object, IActorLocationResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

	}

//精灵掉落
	[ResponseType(nameof(M2C_JingLingDropResponse))]
	[Message(OuterOpcode.C2M_JingLingDropRequest)]
	[ProtoContract]
	public partial class C2M_JingLingDropRequest: Object, IActorLocationRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

	}

	[Message(OuterOpcode.M2C_JingLingDropResponse)]
	[ProtoContract]
	public partial class M2C_JingLingDropResponse: Object, IActorLocationResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

	}

	[ResponseType(nameof(M2C_TianFuPlanResponse))]
	[Message(OuterOpcode.C2M_TianFuPlanRequest)]
	[ProtoContract]
	public partial class C2M_TianFuPlanRequest: Object, IActorLocationRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public int TianFuPlan { get; set; }

	}

	[Message(OuterOpcode.M2C_TianFuPlanResponse)]
	[ProtoContract]
	public partial class M2C_TianFuPlanResponse: Object, IActorLocationResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

	}

	[Message(OuterOpcode.SkillSetInfo)]
	[ProtoContract]
	public partial class SkillSetInfo: Object
	{
		[ProtoMember(1)]
		public List<SkillPro> SkillList = new List<SkillPro>();

		[ProtoMember(2)]
		public List<int> TianFuList = new List<int>();

		[ProtoMember(3)]
		public List<LifeShieldInfo> LifeShieldList = new List<LifeShieldInfo>();

		[ProtoMember(4)]
		public List<int> TianFuList1 = new List<int>();

		[ProtoMember(5)]
		public int TianFuPlan { get; set; }

	}

//技能天赋更新
	[Message(OuterOpcode.M2C_SkillSetMessage)]
	[ProtoContract]
	public partial class M2C_SkillSetMessage: Object, IActorMessage
	{
		[ProtoMember(1)]
		public SkillSetInfo SkillSetInfo { get; set; }

	}

	[ResponseType(nameof(M2C_ItemBuyCellResponse))]
	[Message(OuterOpcode.C2M_ItemBuyCellRequest)]
	[ProtoContract]
	public partial class C2M_ItemBuyCellRequest: Object, IActorLocationRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(1)]
		public int OperateType { get; set; }

	}

	[Message(OuterOpcode.M2C_ItemBuyCellResponse)]
	[ProtoContract]
	public partial class M2C_ItemBuyCellResponse: Object, IActorLocationResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public string Message { get; set; }

		[ProtoMember(92)]
		public int Error { get; set; }

		[ProtoMember(1)]
		public int BagAddedCell { get; set; }

		[ProtoMember(2)]
		public List<int> WarehouseAddedCell = new List<int>();

		[ProtoMember(3)]
		public string GetItem { get; set; }

	}

	[Message(OuterOpcode.JiaYuanPlant)]
	[ProtoContract]
	public partial class JiaYuanPlant: Object
	{
		[ProtoMember(1)]
		public int CellIndex { get; set; }

		[ProtoMember(2)]
		public int ItemId { get; set; }

		[ProtoMember(3)]
		public long StartTime { get; set; }

		[ProtoMember(4)]
		public int GatherNumber { get; set; }

		[ProtoMember(5)]
		public long GatherLastTime { get; set; }

		[ProtoMember(6)]
		public long UnitId { get; set; }

	}

	[Message(OuterOpcode.JiaYuanPastures)]
	[ProtoContract]
	public partial class JiaYuanPastures: Object
	{
		[ProtoMember(2)]
		public int ConfigId { get; set; }

		[ProtoMember(3)]
		public long StartTime { get; set; }

		[ProtoMember(4)]
		public int GatherNumber { get; set; }

		[ProtoMember(5)]
		public long GatherLastTime { get; set; }

		[ProtoMember(6)]
		public long UnitId { get; set; }

	}

	[ResponseType(nameof(M2C_JiaYuanInitResponse))]
	[Message(OuterOpcode.C2M_JiaYuanInitRequest)]
	[ProtoContract]
	public partial class C2M_JiaYuanInitRequest: Object, IActorLocationRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(1)]
		public long UnitId { get; set; }

	}

	[Message(OuterOpcode.M2C_JiaYuanInitResponse)]
	[ProtoContract]
	public partial class M2C_JiaYuanInitResponse: Object, IActorLocationResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public string Message { get; set; }

		[ProtoMember(92)]
		public int Error { get; set; }

		[ProtoMember(1)]
		public List<JiaYuanPlant> PlantList = new List<JiaYuanPlant>();

	}

	[ResponseType(nameof(M2C_JiaYuanPlantResponse))]
	[Message(OuterOpcode.C2M_JiaYuanPlantRequest)]
	[ProtoContract]
	public partial class C2M_JiaYuanPlantRequest: Object, IActorLocationRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(1)]
		public int CellIndex { get; set; }

		[ProtoMember(2)]
		public int ItemId { get; set; }

		[ProtoMember(3)]
		public long OperateBagID { get; set; }

	}

	[Message(OuterOpcode.M2C_JiaYuanPlantResponse)]
	[ProtoContract]
	public partial class M2C_JiaYuanPlantResponse: Object, IActorLocationResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public string Message { get; set; }

		[ProtoMember(92)]
		public int Error { get; set; }

		[ProtoMember(1)]
		public JiaYuanPlant PlantItem { get; set; }

	}

	[ResponseType(nameof(M2C_JiaYuanStoreResponse))]
	[Message(OuterOpcode.C2M_JiaYuanStoreRequest)]
	[ProtoContract]
	public partial class C2M_JiaYuanStoreRequest: Object, IActorLocationRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(2)]
		public int ItemId { get; set; }

		[ProtoMember(3)]
		public long OperateBagID { get; set; }

	}

	[Message(OuterOpcode.M2C_JiaYuanStoreResponse)]
	[ProtoContract]
	public partial class M2C_JiaYuanStoreResponse: Object, IActorLocationResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public string Message { get; set; }

		[ProtoMember(92)]
		public int Error { get; set; }

	}

	[ResponseType(nameof(M2C_JiaYuanGatherResponse))]
	[Message(OuterOpcode.C2M_JiaYuanGatherRequest)]
	[ProtoContract]
	public partial class C2M_JiaYuanGatherRequest: Object, IActorLocationRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(2)]
		public int CellIndex { get; set; }

	}

	[Message(OuterOpcode.M2C_JiaYuanGatherResponse)]
	[ProtoContract]
	public partial class M2C_JiaYuanGatherResponse: Object, IActorLocationResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public string Message { get; set; }

		[ProtoMember(92)]
		public int Error { get; set; }

		[ProtoMember(1)]
		public JiaYuanPlant PlantItem { get; set; }

	}

	[Message(OuterOpcode.M2C_JiaYuanGatherMessage)]
	[ProtoContract]
	public partial class M2C_JiaYuanGatherMessage: Object, IActorMessage
	{
		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public long UnitId { get; set; }

		[ProtoMember(2)]
		public JiaYuanPlant PlantItem { get; set; }

	}

	[ResponseType(nameof(M2C_JiaYuanUprootResponse))]
	[Message(OuterOpcode.C2M_JiaYuanUprootRequest)]
	[ProtoContract]
	public partial class C2M_JiaYuanUprootRequest: Object, IActorLocationRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(2)]
		public int CellIndex { get; set; }

		[ProtoMember(3)]
		public long UnitId { get; set; }

	}

	[Message(OuterOpcode.M2C_JiaYuanUprootResponse)]
	[ProtoContract]
	public partial class M2C_JiaYuanUprootResponse: Object, IActorLocationResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public string Message { get; set; }

		[ProtoMember(92)]
		public int Error { get; set; }

		[ProtoMember(2)]
		public int CellIndex { get; set; }

	}

	[ResponseType(nameof(M2C_JiaYuanCangKuOpenResponse))]
	[Message(OuterOpcode.C2M_JiaYuanCangKuOpenRequest)]
	[ProtoContract]
	public partial class C2M_JiaYuanCangKuOpenRequest: Object, IActorLocationRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

	}

	[Message(OuterOpcode.M2C_JiaYuanCangKuOpenResponse)]
	[ProtoContract]
	public partial class M2C_JiaYuanCangKuOpenResponse: Object, IActorLocationResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public string Message { get; set; }

		[ProtoMember(92)]
		public int Error { get; set; }

	}

	[ResponseType(nameof(M2C_JiaYuanMysteryListResponse))]
	[Message(OuterOpcode.C2M_JiaYuanMysteryListRequest)]
	[ProtoContract]
	public partial class C2M_JiaYuanMysteryListRequest: Object, IActorLocationRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

	}

	[Message(OuterOpcode.M2C_JiaYuanMysteryListResponse)]
	[ProtoContract]
	public partial class M2C_JiaYuanMysteryListResponse: Object, IActorLocationResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public string Message { get; set; }

		[ProtoMember(92)]
		public int Error { get; set; }

		[ProtoMember(1)]
		public List<MysteryItemInfo> MysteryItemInfos = new List<MysteryItemInfo>();

	}

	[ResponseType(nameof(M2C_JiaYuanMysteryBuyResponse))]
	[Message(OuterOpcode.C2M_JiaYuanMysteryBuyRequest)]
	[ProtoContract]
	public partial class C2M_JiaYuanMysteryBuyRequest: Object, IActorLocationRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(1)]
		public MysteryItemInfo MysteryItemInfo { get; set; }

	}

	[Message(OuterOpcode.M2C_JiaYuanMysteryBuyResponse)]
	[ProtoContract]
	public partial class M2C_JiaYuanMysteryBuyResponse: Object, IActorLocationResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public string Message { get; set; }

		[ProtoMember(92)]
		public int Error { get; set; }

		[ProtoMember(1)]
		public List<MysteryItemInfo> MysteryItemInfos = new List<MysteryItemInfo>();

	}

	[ResponseType(nameof(M2C_JiaYuanPastureListResponse))]
	[Message(OuterOpcode.C2M_JiaYuanPastureListRequest)]
	[ProtoContract]
	public partial class C2M_JiaYuanPastureListRequest: Object, IActorLocationRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

	}

	[Message(OuterOpcode.M2C_JiaYuanPastureListResponse)]
	[ProtoContract]
	public partial class M2C_JiaYuanPastureListResponse: Object, IActorLocationResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public string Message { get; set; }

		[ProtoMember(92)]
		public int Error { get; set; }

		[ProtoMember(1)]
		public List<MysteryItemInfo> MysteryItemInfos = new List<MysteryItemInfo>();

	}

	[ResponseType(nameof(M2C_JiaYuanPastureBuyResponse))]
	[Message(OuterOpcode.C2M_JiaYuanPastureBuyRequest)]
	[ProtoContract]
	public partial class C2M_JiaYuanPastureBuyRequest: Object, IActorLocationRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(1)]
		public MysteryItemInfo MysteryItemInfo { get; set; }

	}

	[Message(OuterOpcode.M2C_JiaYuanPastureBuyResponse)]
	[ProtoContract]
	public partial class M2C_JiaYuanPastureBuyResponse: Object, IActorLocationResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public string Message { get; set; }

		[ProtoMember(92)]
		public int Error { get; set; }

		[ProtoMember(1)]
		public List<MysteryItemInfo> MysteryItemInfos = new List<MysteryItemInfo>();

	}

}
