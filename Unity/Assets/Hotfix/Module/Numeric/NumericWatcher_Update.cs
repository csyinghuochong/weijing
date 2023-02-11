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

	[NumericWatcher((int)NumericType.Now_Horse)]
	public class NumericWatcher_Now_Horse : INumericWatcher
	{
		public void Run(EventType.NumericChangeEvent args)
		{

#if SERVER
			Unit unit = args.Parent;
			long horseId = args.NewValue;
			if (horseId > 0)
			{
				BuffData buffData_2 = new BuffData();
				buffData_2.BuffConfig = SkillBuffConfigCategory.Instance.Get(98001104);
				buffData_2.BuffClassScript = buffData_2.BuffConfig.BuffScript;
				unit.GetComponent<BuffManagerComponent>().BuffFactory(buffData_2, unit, null);
			}
			else
			{
				unit.GetComponent<BuffManagerComponent>().BuffRemove(98001104);
			}
#else
			EventType.UnitNumericUpdate.Instance.OldValue = args.OldValue;
			EventType.UnitNumericUpdate.Instance.Unit = args.Parent;
			EventType.UnitNumericUpdate.Instance.NumericType = args.NumericType;
			Game.EventSystem.PublishClass(EventType.UnitNumericUpdate.Instance);
#endif
		}
	}


	[NumericWatcher((int)NumericType.Now_AI)]
	[NumericWatcher((int)NumericType.Now_Stall)]
	[NumericWatcher((int)NumericType.Now_Weapon)]
	[NumericWatcher((int)NumericType.Now_MaxHp)]
	[NumericWatcher((int)NumericType.Now_XiLian)]
	[NumericWatcher((int)NumericType.PetChouKa)]
	[NumericWatcher((int)NumericType.PetSkin)]
	[NumericWatcher((int)NumericType.TowerId)]
	[NumericWatcher((int)NumericType.Ling_DiLv)]
	[NumericWatcher((int)NumericType.Ling_DiExp)]
	[NumericWatcher((int)NumericType.ZeroClock)]
	[NumericWatcher((int)NumericType.HongBao)]
	[NumericWatcher((int)NumericType.PointRemain)]
	[NumericWatcher((int)NumericType.BossInCombat)]
	[NumericWatcher((int)NumericType.XiuLian_ExpNumber)]
	[NumericWatcher((int)NumericType.XiuLian_CoinNumber)]
	[NumericWatcher((int)NumericType.TrialDungeonId)]
	[NumericWatcher((int)NumericType.BattleTodayKill)]
	[NumericWatcher((int)NumericType.PetExtendNumber)]
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
