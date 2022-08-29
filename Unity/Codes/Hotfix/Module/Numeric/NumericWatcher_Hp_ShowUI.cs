namespace ET
{
	/// <summary>
	/// 监视hp数值变化，改变血条值
	/// </summary>
	[NumericWatcher(NumericType.Now_Hp)]
	public class NumericWatcher_Hp_ShowUI : INumericWatcher
	{
		public void Run(EventType.NumbericChange args)
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
				unit.GetComponent<HeroDataComponent>().OnDead(args);
			}

			//副本
			if (sceneTypeEnum == (int)SceneTypeEnum.CellDungeon && unitInfoComponent.Type == UnitType.Player)
			{
				DomainScene.GetComponent<CellDungeonComponent>().OnRecivedHurt(args.OldValue - args.NewValue);
			}
			if (sceneTypeEnum == (int)SceneTypeEnum.TeamDungeon && args.Attack != null && (args.OldValue > args.NewValue))
			{
				Unit player = null;
				if (args.Attack.GetComponent<UnitInfoComponent>().Type == UnitType.Player)
				{
					player = args.Attack;
				}
				if (args.Attack.GetComponent<UnitInfoComponent>().Type == UnitType.Pet)
				{
					long master = args.Attack.GetComponent<NumericComponent>().GetAsLong(NumericType.Master_ID);
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

			UnitType unitType = unitInfoComponent.Type;
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
		public void Run(EventType.NumbericChange args)
		{

#if SERVER
			;
#else

			Unit unit = args.Parent;
			if (args.NewValue == 0)//复活
			{
				EventType.UnitRevive.Instance.Unit = unit;
				Game.EventSystem.PublishClass(EventType.UnitRevive.Instance);
			}
			if (args.NewValue == 1)//死亡
			{
				unit.GetComponent<HeroDataComponent>().OnDead(args);
				EventType.UnitDead.Instance.Unit = unit;
				Game.EventSystem.PublishClass(EventType.UnitDead.Instance);
			}

#if !SERVER && NOT_UNITY
			RunAsync(args).Coroutine();
#endif
#endif
		}

#if !SERVER && NOT_UNITY
		public async ETTask RunAsync(EventType.NumbericChange args)
		{
			Unit unit = args.Parent;
			if (args.NewValue == 1 && unit.IsRobot())
			{
				Scene zoneScene = unit.ZoneScene();
				EnterFubenHelp.RequestQuitFuben(unit.ZoneScene());
				await TimerComponent.Instance.WaitAsync(1000);
				zoneScene.GetComponent<BehaviourComponent>().ChangeBehaviour(BehaviourType.Behaviour_Stroll);
			}
		}
#endif
	}
}