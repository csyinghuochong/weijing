namespace ET
{

	[NumericWatcher((int)NumericType.Now_Damage)]
	public class NumericWatcher_Change_Now_Damage : INumericWatcher
	{
		public void Run(EventType.NumericChangeEvent args)
		{
#if SERVER
			;
#else
			EventType.UnitNumericUpdate.Instance.OldValue = args.OldValue;
			EventType.UnitNumericUpdate.Instance.Unit = args.Parent;
			EventType.UnitNumericUpdate.Instance.NumericType = NumericType.Now_Damage;
			Game.EventSystem.PublishClass(EventType.UnitNumericUpdate.Instance);
#endif
		}
	}

	[NumericWatcher((int)NumericType.RankID)]
	public class NumericWatcher_RankID : INumericWatcher
	{
		public void Run(EventType.NumericChangeEvent args)
		{
			Unit unit = args.Parent;
			int no1_horse = 10004;
#if SERVER
			if (args.NewValue == 1) //排行第一
			{
				unit.GetComponent<UserInfoComponent>().OnHorseActive(no1_horse, true);
			}
			else
			{
				unit.GetComponent<UserInfoComponent>().OnHorseActive(no1_horse, false);
				NumericComponent numericComponent = unit.GetComponent<NumericComponent>();
				if (numericComponent.GetAsInt(NumericType.HorseFightID) == no1_horse)
				{
					numericComponent.ApplyValue(NumericType.HorseFightID, 0);
					numericComponent.ApplyValue(NumericType.HorseRide, 0);
				}
			}
#else
			if (args.NewValue == 1) //排行第一
			{	
				unit.ZoneScene().GetComponent<UserInfoComponent>().OnHorseActive(no1_horse, true);
			}
			else
			{
				unit.ZoneScene().GetComponent<UserInfoComponent>().OnHorseActive(no1_horse, false);
			}
			EventType.UnitNumericUpdate.Instance.OldValue = args.OldValue;
			EventType.UnitNumericUpdate.Instance.Unit = args.Parent;
			EventType.UnitNumericUpdate.Instance.NumericType = args.NumericType;
			Game.EventSystem.PublishClass(EventType.UnitNumericUpdate.Instance);
#endif
		}
	}

	/// <summary>
	/// 出战ID
	/// </summary>
	[NumericWatcher((int)NumericType.HorseFightID)]
	public class NumericWatcher_HorseFightID : INumericWatcher
	{
		public void Run(EventType.NumericChangeEvent args)
		{
#if SERVER
#else
			EventType.UnitNumericUpdate.Instance.OldValue = args.OldValue;
			EventType.UnitNumericUpdate.Instance.Unit = args.Parent;
			EventType.UnitNumericUpdate.Instance.NumericType = args.NumericType;
			Game.EventSystem.PublishClass(EventType.UnitNumericUpdate.Instance);
#endif
		}
	}

	/// <summary>
	/// 出战状态
	/// </summary>
	[NumericWatcher((int)NumericType.HorseRide)]
	public class NumericWatcher_HorseRide : INumericWatcher
	{
		public void Run(EventType.NumericChangeEvent args)
		{

#if SERVER
			Unit unit = args.Parent;
			unit.OnUpdateHorseRide((int)args.OldValue);
#else
			EventType.UnitNumericUpdate.Instance.OldValue = args.OldValue;
			EventType.UnitNumericUpdate.Instance.Unit = args.Parent;
			EventType.UnitNumericUpdate.Instance.NumericType = args.NumericType;
			Game.EventSystem.PublishClass(EventType.UnitNumericUpdate.Instance);
#endif
		}
	}

	[NumericWatcher((int)NumericType.Now_AI)]
	[NumericWatcher((int)NumericType.PetSkin)]
	[NumericWatcher((int)NumericType.TowerId)]
	[NumericWatcher((int)NumericType.HongBao)]
	[NumericWatcher((int)NumericType.TitleID)]
	[NumericWatcher((int)NumericType.UnionId_0)]
	[NumericWatcher((int)NumericType.Ling_DiLv)]
	[NumericWatcher((int)NumericType.Ling_DiExp)]
	[NumericWatcher((int)NumericType.ZeroClock)]
	[NumericWatcher((int)NumericType.Now_Stall)]
	[NumericWatcher((int)NumericType.Now_Weapon)]
	[NumericWatcher((int)NumericType.Now_MaxHp)]
	[NumericWatcher((int)NumericType.Now_XiLian)]
	[NumericWatcher((int)NumericType.PetChouKa)]
	[NumericWatcher((int)NumericType.PointRemain)]
	[NumericWatcher((int)NumericType.GatherNumber)]
	[NumericWatcher((int)NumericType.BossInCombat)]
	[NumericWatcher((int)NumericType.XiuLian_ExpNumber)]
	[NumericWatcher((int)NumericType.XiuLian_CoinNumber)]
	[NumericWatcher((int)NumericType.TrialDungeonId)]
	[NumericWatcher((int)NumericType.BattleTodayKill)]
	[NumericWatcher((int)NumericType.PetExtendNumber)]
	[NumericWatcher((int)NumericType.BossBelongID)]
	[NumericWatcher((int)NumericType.RechargeNumber)]
	[NumericWatcher((int)NumericType.JiaYuanGatherOther)]
	[NumericWatcher((int)NumericType.JiaYuanPickOther)]
	public class NumericWatcher_Update : INumericWatcher
	{
		public void Run(EventType.NumericChangeEvent args)
		{

#if SERVER
			;
#else
			EventType.UnitNumericUpdate.Instance.OldValue = args.OldValue;
			EventType.UnitNumericUpdate.Instance.Unit = args.Parent;
			EventType.UnitNumericUpdate.Instance.NumericType = args.NumericType;
			Game.EventSystem.PublishClass(EventType.UnitNumericUpdate.Instance);
#endif
		}
	}

	[NumericWatcher((int)NumericType.Now_Speed)]
	public class NumericWatcher_Now_Speed : INumericWatcher
	{
		public void Run(EventType.NumericChangeEvent args)
		{
			float speed = args.Parent.GetComponent<NumericComponent>().GetAsFloat(NumericType.Now_Speed);
			args.Parent.GetComponent<MoveComponent>().ChangeSpeed(speed);
		}
	}
}
