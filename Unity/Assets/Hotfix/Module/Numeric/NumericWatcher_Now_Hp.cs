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
			if (unit == null || unit.IsDisposed)
			{
				Log.TraceInfo("NumericType.Now_Hp == null");
			}
			UnitInfoComponent unitInfoComponent = unit.GetComponent<UnitInfoComponent>();
			NumericComponent numericComponentDefend = unit.GetComponent<NumericComponent>();
#if SERVER
			Scene DomainScene = args.Parent.DomainScene();
			MapComponent mapComponent = DomainScene.GetComponent<MapComponent>();	
			int sceneTypeEnum = mapComponent.SceneTypeEnum;
			int sceneId = mapComponent.SceneId;	

			if (args.NewValue <= 0 && numericComponentDefend.GetAsInt(NumericType.Now_Dead) == 1)
			{
				return;
			}

			if (args.NewValue <= 0 && numericComponentDefend.GetAsInt(NumericType.Now_Dead) == 0)
			{
				unit.GetComponent<HeroDataComponent>().OnKillZhaoHuan(args);
				unit.GetComponent<HeroDataComponent>().OnDead(args);
			}

			if (args.Attack != null && (args.OldValue > args.NewValue))
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

				if (sceneTypeEnum == (int)SceneTypeEnum.CellDungeon)   //个人副本接受到的伤害
				{
					DomainScene.GetComponent<CellDungeonComponent>().OnRecivedHurt(args.OldValue - args.NewValue);
				}
				if (sceneTypeEnum == (int)SceneTypeEnum.TeamDungeon && player != null)  //组队副本输出伤害
				{
					//NumericComponent numericComponent = player.GetComponent<NumericComponent>();
					//numericComponent.ApplyChange(null, NumericType.Now_Damage, (args.OldValue - args.NewValue), 0);
					DomainScene.GetComponent<TeamDungeonComponent>()?.OnUpdateDamage(player, unit, args.OldValue - args.NewValue);
				}
				if (sceneTypeEnum == (int)SceneTypeEnum.MiJing && player != null)  //秘境伤害
				{
					DomainScene.GetComponent<MiJingComponent>()?.OnUpdateDamage(player,unit, args.OldValue - args.NewValue);
				}
			}
#else
			long nowHpValue = numericComponentDefend.GetAsLong(NumericType.Now_Hp);
			long costHp = (nowHpValue - args.OldValue);
		
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
				unit.GetComponent<HeroDataComponent>().OnDead();
				EventType.UnitDead.Instance.Unit = unit;
				Game.EventSystem.PublishClass(EventType.UnitDead.Instance);
			}
#endif
		}
	}
}