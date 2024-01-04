using System.Collections.Generic;
using UnityEngine;

namespace ET
{
    public static class UnitFactory
    {
		public static bool LoadingScene = false;

		public static Unit CreateUnit(Scene currentScene, UnitInfo unitInfo, bool mainHero = false)
        {
			bool selfpet = false;
			bool mainScene = currentScene.Name.Equals(StringBuilderHelper.MainCity);
			if (mainScene && unitInfo.UnitType == UnitType.Pet || unitInfo.UnitType == UnitType.JingLing)
			{
                long mainunitid = UnitHelper.GetMyUnitId(currentScene.ZoneScene());
                for (int i = 0; i < unitInfo.Ks.Count; ++i)
                {
                    if (unitInfo.Ks[i] == NumericType.MasterId && unitInfo.Vs[i] == mainunitid)
                    {
						selfpet = true;
						break;
                    }
                }
            }
			if (unitInfo.UnitType == UnitType.Npc)
			{
				selfpet = true;
            }
			

            if (mainScene  && (SettingHelper.NoShowOther|| UnitHelper.GetUnitList(currentScene, UnitType.Player).Count >= SettingHelper.NoShowPlayer)
                && !mainHero && !selfpet)
			{
				return null;
			}

			UnitComponent unitComponent = currentScene.GetComponent<UnitComponent>();
	        Unit unit = unitComponent.AddChildWithId<Unit, int>(unitInfo.UnitId, (int)unitInfo.ConfigId);
	        unitComponent.Add(unit);
			unit.MainHero = mainHero;
			unit.Type = unitInfo.UnitType;
			unit.ConfigId = unitInfo.ConfigId;

            unit.AddComponent<ObjectWait>();
            unit.AddComponent<HeroDataComponent>();
            unit.AddComponent<StateComponent>();
            unit.AddComponent<SingingComponent>();
            unit.AddComponent<MoveComponent>();
            UnitInfoComponent unitInfoComponent = unit.AddComponent<UnitInfoComponent>();
            unitInfoComponent.UnitName = unitInfo.UnitName;
            unitInfoComponent.MasterName = unitInfo.MasterName;
            unitInfoComponent.UnionName = unitInfo.UnionName;
            unitInfoComponent.FashionEquipList = unitInfo.FashionEquipList;

            unit.Position = new Vector3(unitInfo.X, unitInfo.Y, unitInfo.Z);
            unit.Forward = new Vector3(unitInfo.ForwardX, unitInfo.ForwardY, unitInfo.ForwardZ);

            NumericComponent numericComponent = unit.AddComponent<NumericComponent>();
	        for (int i = 0; i < unitInfo.Ks.Count; ++i)
	        {
		        numericComponent.Set(unitInfo.Ks[i], unitInfo.Vs[i]);
	        }
            unit.MasterId = numericComponent.GetAsLong(NumericType.MasterId);
            if (unitInfo.MoveInfo != null && unitInfo.MoveInfo.X.Count > 0)
			{
				using (ListComponent<Vector3> list = ListComponent<Vector3>.Create())
				{
					list.Add(unit.Position);
					for (int i = 0; i < unitInfo.MoveInfo.X.Count; ++i)
					{
						list.Add(new Vector3(unitInfo.MoveInfo.X[i], unitInfo.MoveInfo.Y[i], unitInfo.MoveInfo.Z[i]));
					}
					unit.MoveToAsync(list).Coroutine();
				}
			}

			bool noSkill = unit.Type == UnitType.Npc && NpcConfigCategory.Instance.Get(unit.ConfigId).AI == 0;
			if (!noSkill)
			{
                unit.AddComponent<BuffManagerComponent>();              //buff管理器组建
                unit.AddComponent<SkillManagerComponent>();
                unit.GetComponent<BuffManagerComponent>().t_Buffs = unitInfo.Buffs;
                unit.GetComponent<SkillManagerComponent>().t_Skills = unitInfo.Skills;
            }
            if (mainHero)
            {
                int runraceMonster = numericComponent.GetAsInt(NumericType.RunRaceTransform);
                unit.ZoneScene().GetComponent<AttackComponent>().OnTransformId(unit.ConfigId, runraceMonster);
            }
			
            OnAfterCreateUnit(unit);
            return unit;
        }
       
        public static Unit CreateSpiling(Entity currentScene, SpilingInfo unitInfo)
		{
            UnitComponent unitComponent = currentScene.GetComponent<UnitComponent>();
			Unit unit = unitComponent.AddChildWithId<Unit, int>(unitInfo.UnitId, 1);
			unitComponent.Add(unit);
			unit.Type = UnitType.Monster;
			unit.ConfigId = unitInfo.MonsterID;
			NumericComponent numericComponent = unit.AddComponent<NumericComponent>(true);
			for (int i = 0; i < unitInfo.Ks.Count; ++i)
			{
				numericComponent.Set(unitInfo.Ks[i], unitInfo.Vs[i], false);
			}
            unit.MasterId = numericComponent.GetAsLong(NumericType.MasterId);
            unit.AddComponent<ObjectWait>(true);
			unit.AddComponent<HeroDataComponent>(true);
			unit.AddComponent<StateComponent>(true);
			UnitInfoComponent unitInfoComponent = unit.AddComponent<UnitInfoComponent>(true);
			unitInfoComponent.EnergySkillId = unitInfo.SkillId;
			
			MonsterConfig monsterCof = MonsterConfigCategory.Instance.Get(unitInfo.MonsterID);
			if (monsterCof.AI != 0)
			{
				unit.AddComponent<BuffManagerComponent>(true);              //buff管理器组建
				unit.AddComponent<SkillManagerComponent>(true);
                unit.GetComponent<BuffManagerComponent>().t_Buffs = unitInfo.Buffs;
                unit.GetComponent<SkillManagerComponent>().t_Skills = unitInfo.Skills;
            }
			unit.Position = new Vector3(unitInfo.X, unitInfo.Y, unitInfo.Z);
			unit.Forward = new Vector3(unitInfo.ForwardX, unitInfo.ForwardY, unitInfo.ForwardZ);
			unit.AddComponent<MoveComponent>(true);
           
            OnAfterCreateUnit(unit);
			return unit;
		}

		public static Unit CreateDropItem(Entity currentScene, DropInfo dropinfo)
		{
			UnitComponent unitComponent = currentScene.GetComponent<UnitComponent>();
			long unitId = dropinfo.UnitId == 0 ? IdGenerater.Instance.GenerateId() : dropinfo.UnitId;
			if (unitComponent.Get(unitId) != null)
			{
				return null;
			}
			Unit unit = unitComponent.AddChildWithId<Unit, int>(unitId, 1);
			unit.Type = UnitType.DropItem;
			unitComponent.Add(unit);

			dropinfo.UnitId = unitId;
			unit.AddComponent<DropComponent>().DropInfo =  dropinfo;
			unit.GetComponent<DropComponent>().CellIndex = dropinfo.CellIndex;
            unit.AddComponent<UnitInfoComponent>();
			unit.Position = new Vector3(dropinfo.X, dropinfo.Y, dropinfo.Z);

			OnAfterCreateUnit(unit);
			return unit;
		}

		//创建传送点
		public static Unit CreateTransferItem(Entity currentScene, TransferInfo transferInfo)
		{
            if (transferInfo.TransferId == 20000040)
            {
				PetComponent petComponent = currentScene.ZoneScene().GetComponent<PetComponent>();
				if (!PetHelper.IsShenShouFull(petComponent.RolePetInfos))
				{
					return null;
				}
            }
            UnitComponent unitComponent = currentScene.GetComponent<UnitComponent>();
            Unit unit = unitComponent.AddChildWithId<Unit, int>(transferInfo.UnitId, 1);
			unit.Type = UnitType.Chuansong;
			unit.ConfigId = transferInfo.TransferId;
			unitComponent.Add(unit);

			ChuansongComponent chuansongComponent = unit.AddComponent<ChuansongComponent>();
			chuansongComponent.CellIndex = transferInfo.CellIndex;
			chuansongComponent.DirectionType = transferInfo.Direction;
			unit.AddComponent<UnitInfoComponent>();
			unit.Position = new Vector3(transferInfo.X, transferInfo.Y, transferInfo.Z);
			OnAfterCreateUnit(unit);
			return unit;
		}

		public static async ETTask ShowAllUnit(Scene zoneScene)
		{
			Scene curscene = zoneScene.CurrentScene();
			long instanceid = curscene.InstanceId;
            List<Unit> units = curscene.GetComponent<UnitComponent>().GetAll();
			for (int i = 0; i < units.Count; i++)
			{
				Unit unit = units[i];
				if (!unit.WaitLoad || unit.IsDisposed)
				{
					continue;
				}
				if (unit.Type == UnitType.Player)
				{
                    await TimerComponent.Instance.WaitFrameAsync();
                }
				if (instanceid != curscene.InstanceId)
				{
					break;
				}
				OnAfterCreateUnit(unit);
				unit.WaitLoad = false;
			}
		}

		public static void OnAfterCreateUnit(this Unit unit)
		{
			if (LoadingScene)
			{
				unit.WaitLoad = true;
				return;
			}
			unit.WaitLoad = false;

            EventType.AfterUnitCreate.Instance.Unit = unit;
			Game.EventSystem.PublishClass(EventType.AfterUnitCreate.Instance);
		}
	}

}
