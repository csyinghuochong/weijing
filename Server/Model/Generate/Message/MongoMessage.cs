using ET;
using ProtoBuf;
using System.Collections.Generic;
namespace ET
{
	[Message(MongoOpcode.ObjectQueryResponse)]
	[ProtoContract]
	public partial class ObjectQueryResponse: Object, IActorResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

		[ProtoMember(1)]
		public Entity entity { get; set; }

	}

	[ResponseType(nameof(M2M_UnitTransferResponse))]
	[Message(MongoOpcode.M2M_UnitTransferRequest)]
	[ProtoContract]
	public partial class M2M_UnitTransferRequest: Object, IActorRequest
	{
		[ProtoMember(1)]
		public int RpcId { get; set; }

		[ProtoMember(2)]
		public Unit Unit { get; set; }

		[ProtoMember(4)]
		public int SceneType { get; set; }

		[ProtoMember(6)]
		public int ChapterId { get; set; }

		[ProtoMember(7)]
		public int Difficulty { get; set; }

		[ProtoMember(8)]
		public string ParamInfo { get; set; }

		[ProtoMember(12)]
		public List<byte[]> EntityBytes = new List<byte[]>();

	}

	[ResponseType(nameof(D2G_GetComponent))]
	[Message(MongoOpcode.G2D_GetComponent)]
	[ProtoContract]
	public partial class G2D_GetComponent: Object, IDBCacheActorRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public string Component { get; set; }

		[ProtoMember(2)]
		public long UnitId { get; set; }

	}

	[Message(MongoOpcode.D2G_GetComponent)]
	[ProtoContract]
	public partial class D2G_GetComponent: Object, IDBCacheActorResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

		[ProtoMember(1)]
		public Entity Component { get; set; }

	}

	[ResponseType(nameof(D2G_GetUnit))]
	[Message(MongoOpcode.G2D_GetUnit)]
	[ProtoContract]
	public partial class G2D_GetUnit: Object, IDBCacheActorRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public string Component { get; set; }

		[ProtoMember(2)]
		public long UnitId { get; set; }

	}

	[Message(MongoOpcode.D2G_GetUnit)]
	[ProtoContract]
	public partial class D2G_GetUnit: Object, IDBCacheActorResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

		[ProtoMember(1)]
		public List<Entity> EntityList = new List<Entity>();

		[ProtoMember(2)]
		public List<string> ComponentNameList = new List<string>();

	}

	[ResponseType(nameof(D2M_SaveComponent))]
	[Message(MongoOpcode.M2D_SaveComponent)]
	[ProtoContract]
	public partial class M2D_SaveComponent: Object, IDBCacheActorRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public Entity Component { get; set; }

		[ProtoMember(2)]
		public long UnitId { get; set; }

		[ProtoMember(3)]
		public string ComponentType { get; set; }

	}

	[Message(MongoOpcode.D2M_SaveComponent)]
	[ProtoContract]
	public partial class D2M_SaveComponent: Object, IDBCacheActorResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

	}

	[ResponseType(nameof(D2M_SaveUnit))]
	[Message(MongoOpcode.M2D_SaveUnit)]
	[ProtoContract]
	public partial class M2D_SaveUnit: Object, IDBCacheActorRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(1)]
		public long UnitId { get; set; }

		[ProtoMember(2)]
		public List<string> EntityTypes = new List<string>();

		[ProtoMember(3)]
		public List<byte[]> EntityBytes = new List<byte[]>();

	}

	[Message(MongoOpcode.D2M_SaveUnit)]
	[ProtoContract]
	public partial class D2M_SaveUnit: Object, IDBCacheActorResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

	}

}
