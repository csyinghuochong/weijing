using System;
using System.Collections.Generic;
using UnityEngine;

namespace ET
{
    public static class UnitFactory
    {
        public static Unit Create(Scene scene, long id, int unitType)
        {
            UnitComponent unitComponent = scene.GetComponent<UnitComponent>();
            switch (unitType)
            {
                case UnitType.Player:
                {
                    Unit unit = unitComponent.AddChildWithId<Unit, int>(id, 1001);
                    unit.AddComponent<MoveComponent>();
                    unit.Position = new Vector3(-10, 0, -10);
                    unit.TestType = UnitType.Player;
                    UnitInfoComponent unitInfoComponent = unit.AddComponent<UnitInfoComponent>();
                    unitInfoComponent.Type = UnitType.Player;
                    unitInfoComponent.RoleCamp = 1;

                    //NumericComponent numericComponent = unit.AddComponent<NumericComponent>();
                    //numericComponent.Set((int)NumericType.Now_Speed, 6f); // 速度是6米每秒
                    //numericComponent.Set(NumericType.AOI, 15000); // 视野15米
                    //unitComponent.Add(unit);
                    //// 加入aoi
                    //unit.AddComponent<AOIEntity, int, Vector3>(9 * 1000, unit.Position);
                    return unit;
                }
                default:
                    throw new Exception($"not such unit type: {unitType}");
            }
        }

        public static Unit CreateMonster(Scene scene, Vector3 vector3, int fubenDifficulty, int monsterID, CreateMonsterInfo createMonsterInfo)
        {
            MonsterConfig monsterConfig = MonsterConfigCategory.Instance.Get(monsterID);
            MapComponent mapComponent = scene.GetComponent<MapComponent>();
            Unit unit = scene.GetComponent<UnitComponent>().AddChildWithId<Unit, int>(IdGenerater.Instance.GenerateId(), 1001);
            scene.GetComponent<UnitComponent>().Add(unit);
            unit.AddComponent<NumericComponent>();
            unit.AddComponent<HeroDataComponent>();
            UnitInfoComponent unitInfoComponent = unit.AddComponent<UnitInfoComponent>();
            unitInfoComponent.Type = UnitType.Monster;
            unitInfoComponent.RoleCamp = 2;
            unitInfoComponent.UnitCondigID = monsterConfig.Id;
            unitInfoComponent.EnergySkillId = createMonsterInfo.SkillId;
            unit.TestType = UnitType.Monster;
            unit.Position = vector3;

            //51 场景怪
            //52 能量台子
            //53 传送门
            //54 场景怪 显示名称
            //55 宝箱
            if (monsterConfig.AI != 0)
            {
                unit.AddComponent<ObjectWait>();
                unit.AddComponent<MoveComponent>();
                unit.AddComponent<SkillManagerComponent>();
                unit.AddComponent<SkillPassiveComponent>();
                unit.AddComponent<PathfindingComponent, string>(scene.GetComponent<MapComponent>().NavMeshId);
                //添加其他组件
                unit.AddComponent<StateComponent>();         //添加状态组件
                unit.AddComponent<BuffManagerComponent>();      //添加Buff管理器
                unit.GetComponent<HeroDataComponent>().InitMonsterInfo(monsterConfig, fubenDifficulty, createMonsterInfo);
                unit.GetComponent<SkillPassiveComponent>().UpdateMonsterPassiveSkill();
                unit.GetComponent<SkillPassiveComponent>().Activeted();

                //AI行为树序号
                AIComponent aIComponent = unit.AddComponent<AIComponent, int>(monsterConfig.AI);
                switch (mapComponent.SceneTypeEnum)
                {
                    case (int)SceneTypeEnum.PetDungeon:
                        aIComponent.InitPetFubenMonster(monsterConfig.Id);
                        break;
                    default:
                        aIComponent.InitMonster(monsterConfig.Id);
                        break;
                }
                aIComponent.BornPostion = unit.Position;
            }

            unit.AI = monsterConfig.AI;
            unit.AddComponent<AOIEntity, int, Vector3>(1 * 1000, unit.Position);

            if (monsterConfig.DeathTime > 0)
            {
                unit.AddComponent<DeathTimeComponent, long>(monsterConfig.DeathTime * 1000);
            }

            Unit mainUnit = null;
            long revetime = 0;
            if (mapComponent.SceneTypeEnum == (int)SceneTypeEnum.LocalDungeon)
            {
                mainUnit = scene.GetComponent<LocalDungeonComponent>().MainUnit;
                revetime = mainUnit.GetComponent<UserInfoComponent>().GetReviveTime(mainUnit.Id,  monsterConfig.Id);
            }
            if (mainUnit!=null && TimeHelper.ServerNow() < revetime)
            {
                unit.AddComponent<ReviveTimeComponent, long>(revetime);
                NumericComponent numericComponent = unit.GetComponent<NumericComponent>();
                numericComponent.ApplyValue(NumericType.ReviveTime, revetime, false);
                numericComponent.ApplyValue(NumericType.Now_Dead, 1, false);
            }
            return unit;
        }

        public static Unit CreateNpc(Scene domainScene, int npcId)
        {
            NpcConfig npcConfig = NpcConfigCategory.Instance.Get(npcId);

            Unit unit = domainScene.GetComponent<UnitComponent>().AddChildWithId<Unit, int>(IdGenerater.Instance.GenerateId(), 1001);
            UnitInfoComponent unitInfoComponent = unit.AddComponent<UnitInfoComponent>();
            unitInfoComponent.Type = UnitType.Npc;
            unitInfoComponent.UnitCondigID = npcId;
            unit.Position = new Vector3(npcConfig.Position[0] * 0.01f, npcConfig.Position[1] * 0.01f, npcConfig.Position[2] * 0.01f);
            unit.Rotation = Quaternion.Euler(0, npcConfig.Rotation, 0);
            unit.TestType = UnitType.Npc;
            if (npcConfig.MovePosition.Length > 0)
            {
                unit.AddComponent<MoveComponent>();
                unit.AddComponent<StateComponent>();
                NumericComponent numericComponent = unit.AddComponent<NumericComponent>();
                numericComponent.Set(NumericType.Now_Speed, 3.0f);
                unit.AddComponent<NpcMoveComponent, string>(npcConfig.MovePosition);
                unit.AddComponent<PathfindingComponent, string>(domainScene.GetComponent<MapComponent>().NavMeshId.ToString());
                unit.AddComponent<AIComponent, int>(3);     //AI行为树序号		
            }

            unit.AddComponent<AOIEntity, int, Vector3>(9 * 1000, unit.Position);
            return unit;
        }

        public static Unit CreateTempPet(Unit master, int monster)
        {
            Scene scene = master.DomainScene();
            Unit unit = scene.GetComponent<UnitComponent>().AddChildWithId<Unit, int>(IdGenerater.Instance.GenerateId(), monster);
            scene.GetComponent<UnitComponent>().Add(unit);
            unit.AddComponent<ObjectWait>();
            unit.AddComponent<NumericComponent>();

            unit.AddComponent<MoveComponent>();
            unit.AddComponent<SkillManagerComponent>();
            unit.AddComponent<PathfindingComponent, string>(scene.GetComponent<MapComponent>().NavMeshId);

            unit.GetComponent<NumericComponent>().Set(NumericType.Master_ID, master.Id);
            UnitInfoComponent unitInfoComponent = unit.AddComponent<UnitInfoComponent>();
            unitInfoComponent.Type = UnitType.Monster;
            unitInfoComponent.UnitCondigID = monster;
            unitInfoComponent.RoleCamp = master.GetComponent<UnitInfoComponent>().RoleCamp;
            unit.AddComponent<StateComponent>();         //添加状态组件
            unit.AddComponent<BuffManagerComponent>();      //添加
            unit.Position = new Vector3(master.Position.x + RandomHelper.RandFloat01() * 1f, master.Position.y, master.Position.z + RandomHelper.RandFloat01() * 1f);
            unit.TestType = UnitType.Monster;
            //添加其他组件
            unit.AddComponent<HeroDataComponent>().InitTempPet(master, monster);

            unit.AddComponent<SkillPassiveComponent>().UpdateMonsterPassiveSkill();
            unit.GetComponent<SkillPassiveComponent>().Activeted();
            AIComponent aIComponent = unit.AddComponent<AIComponent, int>(2);     //AI行为树序号
            aIComponent.InitTeampPet(monster);

            unit.AddComponent<AOIEntity, int, Vector3>(9 * 1000, unit.Position);
            return unit;
        }

        public static Unit CreateFubenPet(Scene scene,  long masterId, int roleCamp, RolePetInfo petinfo, Vector3 postion)
        {
            Unit unit = scene.GetComponent<UnitComponent>().AddChildWithId<Unit, int>(petinfo.Id, 1);
            scene.GetComponent<UnitComponent>().Add(unit);
            unit.AddComponent<ObjectWait>();
            unit.AddComponent<NumericComponent>();

            unit.AddComponent<MoveComponent>();
            unit.AddComponent<SkillManagerComponent>();
            unit.AddComponent<PathfindingComponent, string>(scene.GetComponent<MapComponent>().NavMeshId);

            unit.GetComponent<NumericComponent>().Set(NumericType.Master_ID, masterId);
            UnitInfoComponent unitInfoComponent = unit.AddComponent<UnitInfoComponent>();
            unitInfoComponent.Type = UnitType.Pet;
            unitInfoComponent.UnitCondigID = petinfo.ConfigId;
            unitInfoComponent.RoleCamp = roleCamp;
            unit.AddComponent<StateComponent>();         //添加状态组件
            unit.AddComponent<BuffManagerComponent>();      //添加
            unit.Position = postion;
            unit.TestType = UnitType.Pet;
            unit.Rotation = Quaternion.Euler(0f,90f,0f);
            AIComponent aIComponent = unit.AddComponent<AIComponent, int>(1);     //AI行为树序号
            MapComponent mapComponent = scene.GetComponent<MapComponent>();
            aIComponent.BornPostion = unit.Position;
            switch (mapComponent.SceneTypeEnum)
            {
                case (int)SceneTypeEnum.PetDungeon:
                case (int)SceneTypeEnum.PetTianTi:
                    aIComponent.InitPetFubenPet(petinfo.ConfigId);
                    break;
                default:
                    aIComponent.InitPet(petinfo.ConfigId);
                    break;
            }
   
            unit.AddComponent<SkillPassiveComponent>().UpdatePetPassiveSkill();
            unit.GetComponent<SkillPassiveComponent>().Activeted();
            //添加其他组件
            unit.AddComponent<HeroDataComponent>().InitPet(petinfo, false);
            unit.AddComponent<AOIEntity, int, Vector3>(1 * 1000, unit.Position);
            return unit;
        }

        public static Unit CreatePet(Unit master, RolePetInfo petinfo)
        {
            Scene scene = master.DomainScene();
            Unit unit = scene.GetComponent<UnitComponent>().AddChildWithId<Unit, int>(petinfo.Id, 1);
            scene.GetComponent<UnitComponent>().Add(unit);
            unit.AddComponent<ObjectWait>();
            unit.AddComponent<NumericComponent>();

            unit.AddComponent<MoveComponent>();
            unit.AddComponent<SkillManagerComponent>();
            unit.AddComponent<PathfindingComponent, string>(scene.GetComponent<MapComponent>().NavMeshId);

            unit.GetComponent<NumericComponent>().Set(NumericType.Master_ID, master.Id);
            UnitInfoComponent unitInfoComponent = unit.AddComponent<UnitInfoComponent>();
            unitInfoComponent.Type = UnitType.Pet;
            unitInfoComponent.UnitCondigID = petinfo.ConfigId;
            unitInfoComponent.RoleCamp = master.GetComponent<UnitInfoComponent>().RoleCamp;
            unit.AddComponent<StateComponent>();         //添加状态组件
            unit.AddComponent<BuffManagerComponent>();      //添加
            unit.Position = new Vector3(master.Position.x + RandomHelper.RandFloat01() * 1f, master.Position.y, master.Position.z + RandomHelper.RandFloat01() * 1f);
            unit.TestType = UnitType.Pet;
            AIComponent aIComponent = unit.AddComponent<AIComponent, int>(2);     //AI行为树序号
            aIComponent.InitPet(petinfo.ConfigId);

            if (scene.GetComponent<MapComponent>().SceneTypeEnum != (int)SceneTypeEnum.MainCityScene)
            {
                unit.AddComponent<SkillPassiveComponent>().UpdatePetPassiveSkill();
                unit.GetComponent<SkillPassiveComponent>().Activeted();
            }

            //添加其他组件
            unit.AddComponent<HeroDataComponent>().InitPet(petinfo,  false);
            unit.AddComponent<AOIEntity, int, Vector3>(9 * 1000, unit.Position);
            return unit;
        }

        public static void CreateDropItems(Unit unit, Unit main)
        {
            UnitInfoComponent unitInfoComponent = unit.GetComponent<UnitInfoComponent>();
            if (unitInfoComponent.Type != UnitType.Monster)
            {
                return;
            }
            if (unitInfoComponent.GetMonsterType() != (int)MonsterTypeEnum.Boss
                && unitInfoComponent.GetMonsterType() != (int)MonsterTypeEnum.SceneItem
                && main.GetComponent<UserInfoComponent>().UserInfo.PiLao <= 0)
            {
                return;
            }
            float dropAdd_Pro = 1;
            int fubenDifficulty = FubenDifficulty.None;
            dropAdd_Pro += main.GetComponent<NumericComponent>().GetAsFloat(NumericType.Base_DropAdd_Pro_Add);
            if (unit.DomainScene().GetComponent<MapComponent>().SceneTypeEnum == (int)SceneTypeEnum.CellDungeon)
            {
                fubenDifficulty = unit.DomainScene().GetComponent<CellDungeonComponent>().FubenDifficulty;
            }
            if (unit.DomainScene().GetComponent<MapComponent>().SceneTypeEnum == (int)SceneTypeEnum.LocalDungeon)
            {
                fubenDifficulty = unit.DomainScene().GetComponent<LocalDungeonComponent>().FubenDifficulty;
            }
            switch (fubenDifficulty)
            {
                case FubenDifficulty.TiaoZhan:
                    dropAdd_Pro += 0.3f;
                    break;
                case FubenDifficulty.DiYu:
                    dropAdd_Pro += 0.6f;
                    break;
            }

            //创建掉落
            MonsterConfig monsterCof = MonsterConfigCategory.Instance.Get(unit.GetComponent<UnitInfoComponent>().UnitCondigID);
            if (main != null && monsterCof.MonsterSonType == 1)
            {
                int nowUserLv = main.GetComponent<UserInfoComponent>().UserInfo.Lv;
                for (int i = 0; i < monsterCof.Parameter.Length; i++)
                {
                    MonsterConfig nowmonsterCof = MonsterConfigCategory.Instance.Get(monsterCof.Parameter[i]);
                    if (nowUserLv >= nowmonsterCof.Lv)
                    {
                        //指定等级对应属性
                        monsterCof = nowmonsterCof;
                    }
                }
            }

            if (monsterCof.DropType == 0) //公共掉落
            {
                List<RewardItem> droplist = DropHelper.AI_MonsterDrop(monsterCof.Id, dropAdd_Pro);
                for (int i = 0; i < droplist.Count; i++)
                {
                    UnitComponent unitComponent = unit.DomainScene().GetComponent<UnitComponent>();
                    Unit dropitem = unitComponent.AddChildWithId<Unit, int>(IdGenerater.Instance.GenerateId(), 1);
                    unitInfoComponent = dropitem.AddComponent<UnitInfoComponent>();
                    unitInfoComponent.Type = UnitType.DropItem;
                    dropitem.TestType = UnitType.DropItem;
                    DropComponent dropCheckComponent = dropitem.AddComponent<DropComponent>();
                    dropCheckComponent.SetItemInfo(droplist[i].ItemID, droplist[i].ItemNum);
                    float dropX = unit.Position.x + RandomHelper.RandomNumberFloat(-1f, 1f);
                    float dropY = unit.Position.y;
                    float dropZ = unit.Position.z + RandomHelper.RandomNumberFloat(-1f, 1f);
                    dropitem.Position = new UnityEngine.Vector3(dropX, dropY, dropZ);
                    dropitem.AddComponent<AOIEntity, int, Vector3>(9 * 1000, dropitem.Position);
                }
            }
            else
            {
                List<long> beattackIds = new List<long>();
                if (unit.GetComponent<AIComponent>() != null)
                {
                    beattackIds = unit.GetComponent<AIComponent>().BeAttackList;
                }
                else
                {
                    beattackIds.Add(main.Id);
                }
                for (int i = 0; i < beattackIds.Count; i++)
                {
                    Unit beAttack = unit.DomainScene().GetComponent<UnitComponent>().Get(beattackIds[i]);
                    if (beAttack == null)
                    {
                        continue;
                    }
                    M2C_CreateDropItems m2C_CreateDropItems = new M2C_CreateDropItems();

                    List<RewardItem> droplist = DropHelper.AI_MonsterDrop(monsterCof.Id, dropAdd_Pro);
                    for (int k = 0; k < droplist.Count; k++)
                    {
                        m2C_CreateDropItems.Drops.Add(new DropInfo() {
                            DropType = 1, ItemID = droplist[k].ItemID, ItemNum = droplist[k].ItemNum,
                            X = unit.Position.x + RandomHelper.RandomNumberFloat(-1f, 1f),
                            Y = unit.Position.y,
                            Z = unit.Position.z + RandomHelper.RandomNumberFloat(-1f, 1f),
                    }) ;
                    }                    
                    MessageHelper.SendToClient(beAttack, m2C_CreateDropItems);
                }
            }
        }

        public static void CreateDropItems(Unit main, int dropId, string par)
        {
            //创建掉落
            if (dropId > 0) //公共掉落
            {
                List<RewardItem> droplist = new List<RewardItem>();
                DropHelper.DropIDToDropItem(dropId, droplist);
                if (par == "2")
                {
                    droplist.AddRange(droplist);
                }

                for (int i = 0; i < droplist.Count; i++)
                {
                    UnitComponent unitComponent = main.DomainScene().GetComponent<UnitComponent>();
                    Unit dropitem = unitComponent.AddChildWithId<Unit, int>(IdGenerater.Instance.GenerateId(), 1);
                    UnitInfoComponent unitInfoComponent = dropitem.AddComponent<UnitInfoComponent>();
                    unitInfoComponent.Type = UnitType.DropItem;
                    dropitem.TestType = UnitType.DropItem;
                    DropComponent dropCheckComponent = dropitem.AddComponent<DropComponent>();
                    dropCheckComponent.SetItemInfo(droplist[i].ItemID, droplist[i].ItemNum);
                    float dropX = main.Position.x + RandomHelper.RandomNumberFloat(-1f, 1f);
                    float dropY = main.Position.y;
                    float dropZ = main.Position.z + RandomHelper.RandomNumberFloat(-1f, 1f);
                    dropitem.Position = new UnityEngine.Vector3(dropX, dropY, dropZ);
                    dropitem.AddComponent<AOIEntity, int, Vector3>(9 * 1000, dropitem.Position);
                }
            }
            else
            {
            }
        }
    }
}