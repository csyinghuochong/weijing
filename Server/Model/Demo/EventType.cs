using ET;
using UnityEngine;

namespace WaitType
{

	public struct WaitRealNameCode : IWaitType
	{
		public int Error
		{
			get;
			set;
		}
		public RealNameCode Message;
	}

}
namespace ET
{
        namespace EventType
	{
		public struct AppStart
		{
		}

        public struct AppStart2
        {
        }

        public struct MergeZone
		{
			public int oldzone;
            public int newzone;
        }

		public struct ServerMail
		{
			public Scene MailScene;
            //public string Itemlist;
            //public string Title;
            //public string UserName;
            //public int MailType;
            //public int Param;
            public M2E_GMEMailSendRequest Message;
        }

        public struct RealName
		{
			public Scene AccountScene;
			public string idNum;
			public string name;
			public string ai;
        }

		public struct PlayerDisconnect
		{
            public Scene DomainScene;
			public long UnitId;
        }

		public struct RemoveAccountSessions
		{
			public Scene DomainScene;
			public long AccountId;
        }

		public struct PlayerGmOperate
		{
            public Scene DomainScene;
            public int OperateType;
			public string OperatePar;
        }

        public struct ReturnMainCity
		{
            public Scene DomainScene;
            public long UnitId;
        }

        public struct GenerateSerials
		{
			public int Index;
            public Scene AccountCenterScene;
        }

        public struct RechargeScene
        {
            public Scene DomainScene;
        }

        public class ChangePosition : DisposeObject
		{
			public static readonly ChangePosition Instance = new ChangePosition();

			public Unit Unit;

			public WrapVector3 OldPos = new WrapVector3();

			// 因为是重复利用的，所以用完PublishClass会调用Dispose
			public override void Dispose()
			{
				this.Unit = null;
			}
		}

		public class ChangeRotation : DisposeObject
		{
			public static readonly ChangeRotation Instance = new ChangeRotation();

			public Unit Unit;

			// 因为是重复利用的，所以用完PublishClass会调用Dispose
			public override void Dispose()
			{
				this.Unit = null;
			}
		}

		public class MoveStart : DisposeObject
		{
			public static readonly MoveStart Instance = new MoveStart();
			public Unit Unit;

			public override void Dispose()
			{
				this.Unit = null;
			}
		}

		public class MoveStop : DisposeObject
		{
			public static readonly MoveStop Instance = new MoveStop();
			public Unit Unit;

			public override void Dispose()
			{
				this.Unit = null;
			}
		}

		public struct UnitEnterSightRange
		{
			public AOIEntity A;
			public AOIEntity B;
		}

		public struct UnitLeaveSightRange
		{
			public AOIEntity A;
			public AOIEntity B;
		}
		//击杀事件
		public struct KillEvent
		{
			public int WaitRevive;
			public Unit UnitAttack;
			public Unit UnitDefend;
		}
	}
}