using UnityEngine;

namespace ET
{
	namespace EventType
	{
		public struct AppStart
		{
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