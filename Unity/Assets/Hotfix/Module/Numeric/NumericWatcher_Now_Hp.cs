using System;
using System.Collections.Generic;
using UnityEngine;

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
			Unit unit = args.Defend;
			if (unit == null || unit.IsDisposed)
			{
				Log.TraceInfo("NumericType.Now_Hp == null");
			}
			UnitInfoComponent unitInfoComponent = unit.GetComponent<UnitInfoComponent>();
			NumericComponent numericComponentDefend = unit.GetComponent<NumericComponent>();
#if SERVER
			Scene DomainScene = args.Defend.DomainScene();
			MapComponent mapComponent = DomainScene.GetComponent<MapComponent>();	
			int sceneTypeEnum = mapComponent.SceneTypeEnum;
			int sceneId = mapComponent.SceneId;	

			if (args.NewValue <= 0 && numericComponentDefend.GetAsInt(NumericType.Now_Dead) == 1)
			{
				return;
			}

            Unit attack = args.Attack;
            if (args.NewValue <= 0 && numericComponentDefend.GetAsInt(NumericType.Now_Dead) == 0)
			{
                if (attack == null || attack.IsDisposed)
                {
                    Log.Error("NumericWatcher_Now_Hp.args.NewValue <= 0 ");
                }

                // 死亡召唤
                if (args.SkillId > 0 && SkillConfigCategory.Instance.Get(args.SkillId).GameObjectName == "Skill_Com_Summon_5")
                {
	                // 攻击者创建召唤怪。属性也是复制攻击者
	                // '1;90000102;1;1;1;0.5,0.5,0.5,0.5,0.5;0,0,0,0,0;5
	                // 时间间隔；召唤ID；是否复刻玩家形象（0不是，1是）；范围；数量；血量比例,攻击比例,魔法比例,物防比例，魔防比例；血量固定值,攻击固定值，魔法固定值，物防固定值，魔防固定值;数量上限
	                if (unitInfoComponent.GetZhaoHuanNumber() >= 100)
	                {
		                Log.Error("Skill_Com_Summon_5:Error:  死亡召唤数量超过100！！！");
		                return;
	                }

	                SkillConfig skillConfig = SkillConfigCategory.Instance.Get(args.SkillId);
	                string gameObjectParameter = skillConfig.GameObjectParameter;
	                string[] summonParListold = gameObjectParameter.Split(';');
	                string[] summonParList = new string[summonParListold.Length - 1];
	                Array.Copy(summonParListold, 1, summonParList, 0, summonParList.Length);

	                int monsterId = 0;
	                int maxNum = 0;
	                try
	                {
		                monsterId = int.Parse(summonParList[0]);
		                maxNum = int.Parse(summonParList[6]);
	                }
	                catch (Exception ex)
	                {
		                Log.Error("Skill_Com_Summon_5:Error:  ", skillConfig.Id);
		                Log.Error(ex.ToString());
		                return;
	                }

	                List<Unit> haved = new List<Unit>();
	                List<Unit> all = args.Attack.GetParent<UnitComponent>().GetAll();
	                foreach (Unit uu in all)
	                {
		                if (uu.Type == UnitType.Monster && uu.ConfigId == monsterId && uu.MasterId == args.Attack.Id)
		                {
			                haved.Add(uu);
		                }
	                }

	                if (haved.Count + 1 > maxNum)
	                {
		                int de = haved.Count + 1 - maxNum;
		                while (de > 0 && haved.Count > 0)
		                {
			                Unit uu = haved[0];
			                haved.Remove(uu);
			                uu.GetComponent<HeroDataComponent>().OnDead(null);
			                unitInfoComponent.ZhaohuanIds.Remove(uu.Id);
			                --de;
		                }
	                }

	                Unit unitMonster = UnitFactory.CreateMonster(args.Attack.DomainScene(), monsterId, args.Defend.Position,
		                new CreateMonsterInfo()
		                {
			                Camp = args.Attack.GetBattleCamp(),
			                MasterID = args.Attack.Id,
			                AttributeParams = summonParList[1] + ";" + summonParList[4] + ";" + summonParList[5]
		                });
	                unitInfoComponent.ZhaohuanIds.Add(unitMonster.Id);
                }


                unit.GetComponent<HeroDataComponent>().OnKillZhaoHuan(attack);
                unit.GetComponent<HeroDataComponent>().OnDead(attack);
                unit.GetComponent<HeroDataComponent>().PlayDeathSkill(attack);
               
                //unit.GetComponent<HeroDataComponent>().OnKillZhaoHuan(args.Attack);
                //unit.GetComponent<HeroDataComponent>().PlayDeathSkill();
                //unit.GetComponent<HeroDataComponent>().OnDead(args.Attack);
            }

			if (attack != null && !attack.IsDisposed && (args.OldValue > args.NewValue))
			{
				Unit player = attack;
               
                if (attack.MasterId > 0 &&( attack.Type == UnitType.Pet || attack.Type == UnitType.Monster))
				{
                    player = attack.GetParent<UnitComponent>().Get(attack.MasterId);
				}

                if (player != null && player.Type != UnitType.Player)
                {
                    player = null;
                }

                if (sceneTypeEnum == (int)SceneTypeEnum.CellDungeon)   //个人副本接受到的伤害
				{
					DomainScene.GetComponent<CellDungeonComponent>().OnRecivedHurt(args.OldValue - args.NewValue);
				}
				if (sceneTypeEnum == (int)SceneTypeEnum.TeamDungeon && player != null)  //组队副本输出伤害
				{
					DomainScene.GetComponent<TeamDungeonComponent>()?.OnUpdateDamage(player, unit, args.OldValue - args.NewValue);
				}
				if (sceneTypeEnum == (int)SceneTypeEnum.MiJing && player != null)  //秘境伤害
				{
					DomainScene.GetComponent<MiJingComponent>()?.OnUpdateDamage(player,unit, args.OldValue - args.NewValue);
				}
                if (sceneTypeEnum == (int)SceneTypeEnum.TrialDungeon && player != null)  //试炼副本伤害
                {
                    DomainScene.GetComponent<TrialDungeonComponent>()?.OnUpdateDamage(player, attack, unit, args.OldValue - args.NewValue, args.SkillId);
                }
            }
#else
			long nowHpValue = numericComponentDefend.GetAsLong(NumericType.Now_Hp);
			long costHp = (nowHpValue - args.OldValue);
		
			EventType.UnitHpUpdate.Instance.Defend = unit;
			EventType.UnitHpUpdate.Instance.ChangeHpValue = costHp;
			EventType.UnitHpUpdate.Instance.DamgeType = args.DamgeType;
			EventType.UnitHpUpdate.Instance.SkillID = args.SkillId;
			EventType.UnitHpUpdate.Instance.Attack = args.Attack;
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
			Unit unit = args.Defend;
			if (args.NewValue == 0)//复活
			{
                unit.Position = unit.GetBornPostion();
                EventType.UnitRevive.Instance.Unit = unit;
				Game.EventSystem.PublishClass(EventType.UnitRevive.Instance);
			}
			if (args.NewValue == 1)//死亡
			{
                unit.GetComponent<HeroDataComponent>().OnDead(args.Attack);
				EventType.UnitDead.Instance.Unit = unit;
				Game.EventSystem.PublishClass(EventType.UnitDead.Instance);
			}
#endif
		}
	}
}