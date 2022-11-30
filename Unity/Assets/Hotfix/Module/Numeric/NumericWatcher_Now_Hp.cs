namespace ET
{
	/// <summary>
	/// 监视hp数值变化，改变血条值
	/// </summary>
	[NumericWatcher(NumericType.Now_Hp)]
	public class NumericWatcher_Now_Hp : INumericWatcher
	{
		public void Run(EventType.NumericChangeEvent args)
		{
			Unit unit = args.Parent;
			UnitInfoComponent unitInfoComponent = unit.GetComponent<UnitInfoComponent>();
			NumericComponent numericComponentDefend = unit.GetComponent<NumericComponent>();
#if SERVER
			Scene DomainScene = args.Parent.DomainScene();
			int sceneTypeEnum = DomainScene.GetComponent<MapComponent>().SceneTypeEnum;

			if (args.NewValue <= 0 && numericComponentDefend.GetAsInt(NumericType.Now_Dead) == 1)
			{
				return;
			}

			if (args.NewValue <= 0 && numericComponentDefend.GetAsInt(NumericType.Now_Dead) == 0)
			{
				unit.GetComponent<HeroDataComponent>().OnKillZhaoHuan(args);
				unit.GetComponent<HeroDataComponent>().OnDead(args);
			}

			//副本
			if (sceneTypeEnum == (int)SceneTypeEnum.CellDungeon && unit.Type == UnitType.Player)
			{
				DomainScene.GetComponent<CellDungeonComponent>().OnRecivedHurt(args.OldValue - args.NewValue);
			}
			if (sceneTypeEnum == (int)SceneTypeEnum.TeamDungeon && args.Attack != null && (args.OldValue > args.NewValue))
			{
				Unit player = null;
				if (args.Attack.Type == UnitType.Player)
				{
					player = args.Attack;
				}
				if (args.Attack.Type == UnitType.Pet)
				{
					long master = args.Attack.GetComponent<NumericComponent>().GetAsLong(NumericType.MasterId);
					player = args.Attack.GetParent<UnitComponent>().Get(master);
				}

				if (player != null)
				{
					NumericComponent numericComponent = player.GetComponent<NumericComponent>();
					numericComponent.ApplyValue((int)NumericType.Now_Damage,
						numericComponent.GetAsInt(NumericType.Now_Damage) + (args.OldValue - args.NewValue));
				}
			}
#else
			long nowHpValue = numericComponentDefend.GetAsLong(NumericType.Now_Hp);
			long costHp = (nowHpValue - args.OldValue);
			int unitType = unit.Type;

			EventType.UnitHpUpdate.Instance.Unit = unit;
			EventType.UnitHpUpdate.Instance.ChangeHpValue = costHp;
			EventType.UnitHpUpdate.Instance.DamgeType = args.DamgeType;
			EventType.UnitHpUpdate.Instance.SkillID = args.SkillId;
			Game.EventSystem.PublishClass(EventType.UnitHpUpdate.Instance);
#endif
		}
	}


	[NumericWatcher(NumericType.Now_Dead)]
	public class NumericWatcher_Now_Dead : INumericWatcher
	{
		public void Run(EventType.NumericChangeEvent args)
		{
#if !SERVER
			Unit unit = args.Parent;
			if (args.NewValue == 0)//复活
			{
				EventType.UnitRevive.Instance.Unit = unit;
				unit.Position = unit.GetBornPostion();
				unit.GetComponent<StateComponent>().Reset();
				Game.EventSystem.PublishClass(EventType.UnitRevive.Instance);
			}
			if (args.NewValue == 1)//死亡
			{
				unit.GetComponent<HeroDataComponent>().OnDead(args);
				EventType.UnitDead.Instance.Unit = unit;
				Game.EventSystem.PublishClass(EventType.UnitDead.Instance);
			}
#endif
		}
	}
}