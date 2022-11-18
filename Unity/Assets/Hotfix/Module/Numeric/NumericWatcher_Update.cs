namespace ET
{

	[NumericWatcher((int)NumericType.Now_Damage)]
	public class NumericWatcher_Change_Now_Damage : INumericWatcher
	{
		public void Run(EventType.NumericChangeEvent args)
		{
#if SERVER
			args.Parent.DomainScene().GetComponent<TeamDungeonComponent>().OnUpdateDamage(args.Parent, (int)args.NewValue);
#else
			EventType.UnitNumericUpdate.Instance.OldValue = args.OldValue;
			EventType.UnitNumericUpdate.Instance.Unit = args.Parent;
			EventType.UnitNumericUpdate.Instance.NumericType = NumericType.Now_Damage;
			Game.EventSystem.PublishClass(EventType.UnitNumericUpdate.Instance);
#endif
		}
	}


	
	[NumericWatcher((int)NumericType.Now_AI)]
	[NumericWatcher((int)NumericType.Now_Stall)]
	[NumericWatcher((int)NumericType.Now_Weapon)]
	[NumericWatcher((int)NumericType.Now_MaxHp)]
	[NumericWatcher((int)NumericType.Now_XiLian)]
	[NumericWatcher((int)NumericType.Now_Horse)]
	[NumericWatcher((int)NumericType.PetChouKa)]
	[NumericWatcher((int)NumericType.PetSkin)]
	[NumericWatcher((int)NumericType.TowerId)]
	[NumericWatcher((int)NumericType.Ling_DiLv)]
	[NumericWatcher((int)NumericType.Ling_DiExp)]
	[NumericWatcher((int)NumericType.ZeroClock)]
	[NumericWatcher((int)NumericType.PointRemain)]
	[NumericWatcher((int)NumericType.BossInCombat)]
	[NumericWatcher((int)NumericType.XiuLian_ExpNumber)]
	[NumericWatcher((int)NumericType.XiuLian_CoinNumber)]
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
