namespace ET
{

    [NumericWatcher((int)NumericType.Now_Damage)]
	public class NumericWatcher_Change_Now_Damage : INumericWatcher
	{
		public void Run(EventType.NumbericChange args)
		{
#if SERVER
;
				args.Parent.DomainScene().GetComponent<TeamDungeonComponent>().OnUpdateDamage(args.Parent, (int)args.NewValue);
#else
			EventType.UnitNumericUpdate.Instance.OldValue = args.OldValue;
			EventType.UnitNumericUpdate.Instance.Unit = args.Parent;
			EventType.UnitNumericUpdate.Instance.NumericType = NumericType.Now_Damage;
			Game.EventSystem.PublishClass(EventType.UnitNumericUpdate.Instance);
#endif
		}
	}


	[NumericWatcher((int)NumericType.Now_Stall)]
	[NumericWatcher((int)NumericType.Now_Weapon)]
	[NumericWatcher((int)NumericType.Now_MaxHp)]
	[NumericWatcher((int)NumericType.Now_XiLian)]
	[NumericWatcher((int)NumericType.Pet_ChouKa)]
	[NumericWatcher((int)NumericType.Pet_Skin)]
	[NumericWatcher((int)NumericType.Tower_ID)]
	[NumericWatcher((int)NumericType.Ling_DiLv)]
	[NumericWatcher((int)NumericType.Ling_DiExp)]
	[NumericWatcher((int)NumericType.ZeroClock)]
	[NumericWatcher((int)NumericType.PointRemain)]
	[NumericWatcher((int)NumericType.XiuLian_ExpNumber)]
	[NumericWatcher((int)NumericType.XiuLian_CoinNumber)]
	public class NumericWatcher_Change_Now_Weapon : INumericWatcher
	{
		public void Run(EventType.NumbericChange args)
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
}
