using UnityEngine;

namespace ET
{
    public static class UnitFactory
    {
        public static Unit CreateUnit(Scene currentScene, UnitInfo unitInfo, bool mainHero = false)
        {
			UnitComponent unitComponent = currentScene.GetComponent<UnitComponent>();
	        Unit unit = unitComponent.AddChildWithId<Unit, int>(unitInfo.UnitId, (int)unitInfo.ConfigId);
	        unitComponent.Add(unit);
			unit.MainHero = mainHero;
	        unit.Position = new Vector3(unitInfo.X, unitInfo.Y, unitInfo.Z);
	        unit.Forward = new Vector3(unitInfo.ForwardX, unitInfo.ForwardY, unitInfo.ForwardZ);
	        
	        NumericComponent numericComponent = unit.AddComponent<NumericComponent>();
	        for (int i = 0; i < unitInfo.Ks.Count; ++i)
	        {
		        numericComponent.Set(unitInfo.Ks[i], unitInfo.Vs[i]);
	        }
	        
			unit.AddComponent<ObjectWait>();
			unit.AddComponent<HeroDataComponent>();
			unit.AddComponent<StateComponent>();
			unit.AddComponent<BuffManagerComponent>();              //buff管理器组建
			unit.AddComponent<SkillManagerComponent>();

			UnitInfoComponent unitInfoComponent = unit.AddComponent<UnitInfoComponent>();
			unitInfoComponent.Type = UnitType.Player;
			unitInfoComponent.UserID = unitInfo.UserId;
			unitInfoComponent.RoleCamp = unitInfo.RoleCamp;
			unitInfoComponent.PlayerName = unitInfo.PlayerName;
			unitInfoComponent.StallName = unitInfo.StallName;
			unitInfoComponent.UnitCondigID = unitInfo.PlayerOcc;
			unitInfoComponent.UnionName = string.IsNullOrEmpty(unitInfo.UnionName) ? "" : unitInfo.UnionName;

			unit.AddComponent<MoveComponent>();
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
			unit.GetComponent<BuffManagerComponent>().InitBuff(unitInfo.Buffs);
			UnitHelper.OnAfterCreateUnit(unit);
            return unit;
        }

		public static Unit CreateSpiling(Entity currentScene, SpilingInfo unitInfo)
		{
			UnitComponent unitComponent = currentScene.GetComponent<UnitComponent>();
			Unit unit = unitComponent.AddChildWithId<Unit, int>(unitInfo.UnitId, 1);
			unit.Position = new Vector3(unitInfo.X, unitInfo.Y, unitInfo.Z);
			unitComponent.Add(unit);

			unit.AddComponent<MoveComponent>();
			NumericComponent numericComponent = unit.AddComponent<NumericComponent>();
			for (int i = 0; i < unitInfo.Ks.Count; ++i)
			{
				numericComponent.Set(unitInfo.Ks[i], unitInfo.Vs[i], false);
			}

			unit.AddComponent<ObjectWait>(true);
			unit.AddComponent<HeroDataComponent>(true);
			unit.AddComponent<StateComponent>(true);
			UnitInfoComponent unitInfoComponent = unit.AddComponent<UnitInfoComponent>();
			unitInfoComponent.Type = UnitType.Monster;
			unitInfoComponent.RoleCamp = unitInfo.RoleCamp;
			unitInfoComponent.UnitCondigID = unitInfo.MonsterID;
			unitInfoComponent.EnergySkillId = unitInfo.SkillId;
			
			MonsterConfig monsterCof = MonsterConfigCategory.Instance.Get(unitInfo.MonsterID);
			if (monsterCof.AI != 0)
			{
				unit.AddComponent<BuffManagerComponent>(true);              //buff管理器组建
				unit.AddComponent<SkillManagerComponent>(true);
			}

			UnitHelper.OnAfterCreateUnit(unit);
			return unit;
		}

		public static Unit CreateRolePet(Entity currentScene, RolePetInfo rolePetInfo)
		{
			UnitComponent unitComponent = currentScene.GetComponent<UnitComponent>();
			Unit unit = unitComponent.AddChildWithId<Unit, int>(rolePetInfo.Id, 1);
			unit.Position = new Vector3(rolePetInfo.X, rolePetInfo.Y, rolePetInfo.Z);
			unitComponent.Add(unit);
		
			unit.AddComponent<MoveComponent>();
			NumericComponent numericComponent = unit.AddComponent<NumericComponent>();
			for (int i = 0; i < rolePetInfo.Ks.Count; ++i)
			{
				numericComponent.Set(rolePetInfo.Ks[i], rolePetInfo.Vs[i], false);
			}
			unit.AddComponent<HeroDataComponent>();
			unit.AddComponent<StateComponent>();
			unit.AddComponent<BuffManagerComponent>();              //buff管理器组建
			unit.AddComponent<SkillManagerComponent>();

			UnitInfoComponent unitInfoComponent = unit.AddComponent<UnitInfoComponent>();
			unitInfoComponent.Type = UnitType.Pet;
			unitInfoComponent.RoleCamp = rolePetInfo.RoleCamp;
			unitInfoComponent.UnitCondigID = rolePetInfo.ConfigId;
			unitInfoComponent.PlayerName = rolePetInfo.PlayerName;

			UnitHelper.OnAfterCreateUnit(unit);
			return unit;
		}

		public static Unit CreateDropItem(Entity currentScene, DropInfo dropinfo)
		{
			UnitComponent unitComponent = currentScene.GetComponent<UnitComponent>();
			long unitId = dropinfo.DropType == 1 ? IdGenerater.Instance.GenerateId() : dropinfo.UnitId;
			Unit unit = unitComponent.AddChildWithId<Unit, int>(unitId, 1);
			unit.Position = new Vector3(dropinfo.X, dropinfo.Y, dropinfo.Z);
			unitComponent.Add(unit);

			dropinfo.UnitId = unitId;
			unit.AddComponent<DropComponent>().DropInfo =  dropinfo;
			unit.AddComponent<UnitInfoComponent>().Type = UnitType.DropItem;

			UnitHelper.OnAfterCreateUnit(unit);
			return unit;
		}

		//创建传送点
		public static Unit CreateTransferItem(Entity currentScene, TransferInfo transferInfo)
		{
			UnitComponent unitComponent = currentScene.GetComponent<UnitComponent>();
			Unit unit = unitComponent.AddChildWithId<Unit, int>(transferInfo.UnitId, 1);
			unit.Position = new Vector3(transferInfo.X, transferInfo.Y, transferInfo.Z);
			unitComponent.Add(unit);

			ChuansongComponent chuansongComponent = unit.AddComponent<ChuansongComponent>();
			chuansongComponent.CellIndex = transferInfo.CellIndex;
			chuansongComponent.DirectionType = transferInfo.Direction;
			UnitInfoComponent unitInfoComponent = unit.AddComponent<UnitInfoComponent>();
			unitInfoComponent.Type = UnitType.Chuansong;
			unitInfoComponent.UnitCondigID = transferInfo.TransferId;

			UnitHelper.OnAfterCreateUnit(unit);
			return unit;
		}

		//创建Npc
		public static Unit CreateNpcItem(Entity currentScene, NpcInfo npcInfo)
		{
			UnitComponent unitComponent = currentScene.GetComponent<UnitComponent>();
			NpcConfig npcConfig = NpcConfigCategory.Instance.Get(npcInfo.NpcID);
			Unit unit = unitComponent.AddChildWithId<Unit, int>(npcInfo.UnitId, 1);
			unit.Position = new Vector3(npcInfo.X, npcInfo.Y, npcInfo.Z);
			unit.Rotation = Quaternion.Euler(0, npcConfig.Rotation, 0);
			unitComponent.Add(unit);

			unit.AddComponent<MoveComponent>();
			unit.AddComponent<StateComponent>();
			NumericComponent numericComponent = unit.AddComponent<NumericComponent>();
			numericComponent.Set((int)NumericType.Now_Speed, 3.0f);
			UnitInfoComponent unitInfoComponent = unit.AddComponent<UnitInfoComponent>();
			unitInfoComponent.Type = UnitType.Npc;
			unitInfoComponent.UnitCondigID = npcInfo.NpcID;

			UnitHelper.OnAfterCreateUnit(unit);
			return unit;
		}
	}

}
