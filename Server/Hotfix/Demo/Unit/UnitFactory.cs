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
                    unit.Type = UnitType.Player;
                    unit.AddComponent<UnitInfoComponent>();
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

        public static Unit CreateMonster(Scene scene, int monsterID, Vector3 vector3, CreateMonsterInfo createMonsterInfo)
        {
            MonsterConfig monsterConfig = MonsterConfigCategory.Instance.Get(monsterID);
            MapComponent mapComponent = scene.GetComponent<MapComponent>();
            Unit mainUnit = null;
            if (mapComponent.SceneTypeEnum == SceneTypeEnum.LocalDungeon && monsterConfig.MonsterSonType == 55)
            {
                mainUnit = scene.GetComponent<LocalDungeonComponent>().MainUnit;
                UserInfoComponent userInfoComponent = mainUnit.GetComponent<UserInfoComponent>();
                if (userInfoComponent.IsCheskOpen(mapComponent.SceneId, monsterID))
                {
                    return null;
                }
            }

            Unit unit = scene.GetComponent<UnitComponent>().AddChildWithId<Unit, int>(IdGenerater.Instance.GenerateId(), 1001);
            NumericComponent numericComponent = unit.AddComponent<NumericComponent>();
            HeroDataComponent heroDataComponent = unit.AddComponent<HeroDataComponent>();
            UnitInfoComponent unitInfoComponent = unit.AddComponent<UnitInfoComponent>();
            unitInfoComponent.EnergySkillId = createMonsterInfo.SkillId;
            unitInfoComponent.PlayerName = monsterConfig.MonsterName;
            unit.Type = UnitType.Monster;
            unit.Position = vector3;
            unit.ConfigId = monsterConfig.Id;
            unit.Rotation = Quaternion.Euler(0, createMonsterInfo.Rotation, 0);
            numericComponent.Set(NumericType.BattleCamp, createMonsterInfo.Camp);
            //出生点
            numericComponent.Set((int)NumericType.Born_X, unit.Position.x, false);
            numericComponent.Set((int)NumericType.Born_Y, unit.Position.y, false);
            numericComponent.Set((int)NumericType.Born_Z, unit.Position.z, false);
            //51 场景怪
            //52 能量台子
            //53 传送门
            //54 场景怪 显示名称
            //55 宝箱
            if (monsterConfig.AI != 0)
            {
                if (createMonsterInfo.MasterID > 0)
                {
                    heroDataComponent.InitMonsterInfo_Summon2(monsterConfig, createMonsterInfo);
                }
                else
                {
                    heroDataComponent.InitMonsterInfo(monsterConfig, createMonsterInfo);
                }
            }

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
                unit.GetComponent<SkillPassiveComponent>().UpdateMonsterPassiveSkill();
                numericComponent.Set(NumericType.MasterId, createMonsterInfo.MasterID);
                AIComponent aIComponent = unit.AddComponent<AIComponent, int>( monsterConfig.AI);
                switch (mapComponent.SceneTypeEnum)
                {
                    case (int)SceneTypeEnum.PetDungeon:
                        aIComponent.InitPetFubenMonster(monsterConfig.Id);
                        break;
                    default:
                        aIComponent.InitMonster(monsterConfig.Id);
                        break;
                }
            }
            if (monsterConfig.DeathTime > 0)
            {
                unit.AddComponent<DeathTimeComponent, long>(monsterConfig.DeathTime * 1000);
            }
            long revetime = 0;
            if (mapComponent.SceneTypeEnum == (int)SceneTypeEnum.LocalDungeon)
            {
                mainUnit = scene.GetComponent<LocalDungeonComponent>().MainUnit;
                revetime = mainUnit.GetComponent<UserInfoComponent>().GetReviveTime( monsterConfig.Id);
            }
            if (mainUnit!=null && TimeHelper.ServerNow() < revetime)
            {
                unit.AddComponent<ReviveTimeComponent, long>(revetime);
                numericComponent.ApplyValue(NumericType.ReviveTime, revetime, false);
                numericComponent.ApplyValue(NumericType.Now_Dead, 1, false);
            }

            unit.AI = monsterConfig.AI;
            scene.GetComponent<UnitComponent>().Add(unit);
            unit.AddComponent<AOIEntity, int, Vector3>(1 * 1000, unit.Position);
            if (monsterConfig.AI > 0 &&numericComponent.GetAsInt(NumericType.Now_Dead) == 0)
            {
                unit.GetComponent<SkillPassiveComponent>().Activeted();
            }
            return unit;
        }

        public static Unit CreateNpc(Scene domainScene, int npcId)
        {
            NpcConfig npcConfig = NpcConfigCategory.Instance.Get(npcId);

            Unit unit = domainScene.GetComponent<UnitComponent>().AddChildWithId<Unit, int>(IdGenerater.Instance.GenerateId(), 1001);
            unit.AddComponent<UnitInfoComponent>();
            unit.ConfigId = npcId;
            unit.Position = new Vector3(npcConfig.Position[0] * 0.01f, npcConfig.Position[1] * 0.01f, npcConfig.Position[2] * 0.01f);
            unit.Rotation = Quaternion.Euler(0, npcConfig.Rotation, 0);
            unit.Type = UnitType.Npc;
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

        public static Unit CreateTempFollower(Unit master, int monster)
        {
            Scene scene = master.DomainScene();
            Unit unit = scene.GetComponent<UnitComponent>().AddChildWithId<Unit, int>(IdGenerater.Instance.GenerateId(), monster);
            scene.GetComponent<UnitComponent>().Add(unit);
            unit.AddComponent<ObjectWait>();
            NumericComponent numericComponent = unit.AddComponent<NumericComponent>();
            UnitInfoComponent unitInfoComponent = unit.AddComponent<UnitInfoComponent>();
            unit.AddComponent<MoveComponent>();
            unit.AddComponent<SkillManagerComponent>();
            unit.AddComponent<PathfindingComponent, string>(scene.GetComponent<MapComponent>().NavMeshId);

            unitInfoComponent.PlayerName = master.GetComponent<UnitInfoComponent>().PlayerName;
            unit.GetComponent<NumericComponent>().Set(NumericType.MasterId, master.Id);
            numericComponent.Set(NumericType.BattleCamp, master.GetBattleCamp());
            numericComponent.Set(NumericType.TeamId, master.GetTeamId());
            unit.ConfigId = monster;
            unit.AddComponent<StateComponent>();         //添加状态组件
            unit.AddComponent<BuffManagerComponent>();      //添加
            unit.Type = UnitType.Monster;
            unit.Position = new Vector3(master.Position.x + RandomHelper.RandFloat01() * 1f, master.Position.y, master.Position.z + RandomHelper.RandFloat01() * 1f);
            //添加其他组件
            unit.AddComponent<HeroDataComponent>().InitTempFollower(master, monster);

            AIComponent aIComponent = unit.AddComponent<AIComponent, int>(2);     //AI行为树序号
            aIComponent.InitTempFollower(monster);

            unit.AddComponent<AOIEntity, int, Vector3>(9 * 1000, unit.Position);

            unit.AddComponent<SkillPassiveComponent>().UpdateMonsterPassiveSkill();
            unit.GetComponent<SkillPassiveComponent>().Activeted();
            return unit;
        }

        public static Unit CreateTianTiPet(Scene scene,  long masterId, int roleCamp, RolePetInfo petinfo, Vector3 postion)
        {
            Unit unit = scene.GetComponent<UnitComponent>().AddChildWithId<Unit, int>(petinfo.Id, 1);
            scene.GetComponent<UnitComponent>().Add(unit);
            unit.AddComponent<ObjectWait>();
            NumericComponent numericComponent = unit.AddComponent<NumericComponent>();
            numericComponent.Set(NumericType.BattleCamp, roleCamp);
            numericComponent.Set(NumericType.MasterId, masterId);
            unit.AddComponent<MoveComponent>();
            unit.AddComponent<UnitInfoComponent>();
            unit.AddComponent<SkillManagerComponent>();
            unit.AddComponent<PathfindingComponent, string>(scene.GetComponent<MapComponent>().NavMeshId);

            unit.ConfigId = petinfo.ConfigId;
            unit.AddComponent<StateComponent>();         //添加状态组件
            unit.AddComponent<BuffManagerComponent>();      //添加
            unit.Position = postion;
            unit.Type = UnitType.Pet;
            unit.Rotation = Quaternion.Euler(0f,90f,0f);
            AIComponent aIComponent = unit.AddComponent<AIComponent, int>(1);     //AI行为树序号
            MapComponent mapComponent = scene.GetComponent<MapComponent>();
            switch (mapComponent.SceneTypeEnum)
            {
                case (int)SceneTypeEnum.PetDungeon:
                case (int)SceneTypeEnum.PetTianTi:
                    aIComponent.InitTianTiPet(petinfo.ConfigId);
                    break;
                default:
                    aIComponent.InitPet(petinfo);
                    break;
            }
            unit.AddComponent<SkillPassiveComponent>().UpdatePetPassiveSkill();
          
            //添加其他组件
            unit.AddComponent<HeroDataComponent>().InitPet(petinfo, false);
            unit.AddComponent<AOIEntity, int, Vector3>(1 * 1000, unit.Position);
            unit.GetComponent<SkillPassiveComponent>().Activeted();
            return unit;
        }

        public static Unit CreatePet(Unit master, RolePetInfo petinfo)
        {
            Scene scene = master.DomainScene();
            Unit unit = scene.GetComponent<UnitComponent>().AddChildWithId<Unit, int>(petinfo.Id, 1);
            scene.GetComponent<UnitComponent>().Add(unit);
            unit.AddComponent<ObjectWait>();
            NumericComponent numericComponent = unit.AddComponent<NumericComponent>();
            UnitInfoComponent unitInfoComponent = unit.AddComponent<UnitInfoComponent>();
            unit.AddComponent<MoveComponent>();
            unit.AddComponent<SkillManagerComponent>();
            unit.AddComponent<PathfindingComponent, string>(scene.GetComponent<MapComponent>().NavMeshId);

            unitInfoComponent.PlayerName = master.GetComponent<UnitInfoComponent>().PlayerName;
            numericComponent.Set(NumericType.MasterId, master.Id);
            numericComponent.Set(NumericType.BattleCamp, master.GetBattleCamp());
            numericComponent.Set(NumericType.TeamId, master.GetTeamId());
            unit.ConfigId = petinfo.ConfigId;
            unit.AddComponent<StateComponent>();         //添加状态组件
            unit.AddComponent<BuffManagerComponent>();      //添加
            unit.Position = new Vector3(master.Position.x + RandomHelper.RandFloat01() * 1f, master.Position.y, master.Position.z + RandomHelper.RandFloat01() * 1f);
            unit.Type = UnitType.Pet;
            AIComponent aIComponent = unit.AddComponent<AIComponent, int>(2);     //AI行为树序号
            aIComponent.InitPet(petinfo);
            //添加其他组件
            unit.AddComponent<HeroDataComponent>().InitPet(petinfo, false);
            unit.AddComponent<AOIEntity, int, Vector3>(9 * 1000, unit.Position);

            if (scene.GetComponent<MapComponent>().SceneTypeEnum != (int)SceneTypeEnum.MainCityScene)
            {
                unit.AddComponent<SkillPassiveComponent>().UpdatePetPassiveSkill();
                unit.GetComponent<SkillPassiveComponent>().Activeted();
            }

            return unit;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bekill"></param>
        /// <param name="main"></param>
        /// <param name="sceneType"></param>
        /// <param name="playerNumer"></param>
        public static void CreateDropItems(Unit bekill, Unit main, int sceneType, int playerNumer)
        {
            if (bekill.Type != UnitType.Monster)
            {
                return;
            }
            bool drop = true;
            MonsterConfig monsterCof = MonsterConfigCategory.Instance.Get(bekill.ConfigId);
            if (ComHelp.IsSingleFuben(sceneType) && main!=null)
            {
                drop = main.GetComponent<UserInfoComponent>().UserInfo.PiLao > 0 || bekill.IsBoss();

                //场景宝箱掉落和体力无关
                if (monsterCof.MonsterType == 5 &&
                    (monsterCof.MonsterSonType == 55 || monsterCof.MonsterSonType == 57)) 
                {
                    drop = true;
                }
            }
            if (!drop)
            {
                return;
            }
            float dropAdd_Pro = 1;
            if (bekill.IsBoss() && main != null)
            {
                int fubenDifficulty = FubenDifficulty.None;
                dropAdd_Pro += main.GetComponent<NumericComponent>().GetAsFloat(NumericType.Base_DropAdd_Pro_Add);
                if (sceneType == (int)SceneTypeEnum.CellDungeon)
                {
                    fubenDifficulty = bekill.DomainScene().GetComponent<CellDungeonComponent>().FubenDifficulty;
                }
                if (sceneType == (int)SceneTypeEnum.LocalDungeon)
                {
                    fubenDifficulty = bekill.DomainScene().GetComponent<LocalDungeonComponent>().FubenDifficulty;
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
            }

            //1个人掉率降低
            if (sceneType == SceneTypeEnum.TeamDungeon)
            {
                if (playerNumer == 1)
                {
                    dropAdd_Pro -= 0.25f;
                }
                if (playerNumer == 2)
                {
                    //dropAdd_Pro -= 0.3f;
                }
                if (playerNumer == 3)
                {
                    dropAdd_Pro += 0.25f;
                }

                MapComponent mapComponent = bekill.DomainScene().GetComponent<MapComponent>();
                if (mapComponent.FubenDifficulty == TeamFubenType.ShenYuan)
                {
                    dropAdd_Pro += 0.5f;
                }
            }

            //创建掉落
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
            
            List<RewardItem> droplist = DropHelper.AI_MonsterDrop(monsterCof.Id, dropAdd_Pro, false);
           
            List<RewardItem> droplist_2 = null;
            if (main!=null && !main.IsDisposed)
            {
                int playerLv = main.GetComponent<UserInfoComponent>().UserInfo.Lv;
                droplist_2 = DropHelper.AI_DropByPlayerLv(monsterCof.Id, playerLv, dropAdd_Pro, false);
            }
            if (droplist_2 != null)
            {
                droplist.AddRange(droplist_2);
            }
            if ((monsterCof.MonsterSonType == 55 || monsterCof.MonsterSonType == 56) && droplist.Count == 0)
            {
                Log.Warning($"宝箱掉落为空{monsterCof.Id} {main.Id}");
            }
            if (monsterCof.MonsterType == (int)MonsterTypeEnum.Boss && droplist.Count == 0)
            {
                Log.Warning($"BOSS掉落为空{monsterCof.Id}  {main.Id}");
            }

            List<long> beattackIds = new List<long>();
            if (bekill.GetComponent<AIComponent>() != null)
            {
                beattackIds = bekill.GetComponent<AIComponent>().BeAttackPlayerList;
            }
            else if(main!=null)
            {
                beattackIds.Add(main.Id);
            }
            // 0 公共掉落 2保护掉落   1私有掉落
            if (monsterCof.DropType == 0 || monsterCof.DropType == 2) 
            {
                long serverTime = TimeHelper.ServerNow();
                for (int i = 0; i < droplist.Count; i++)
                {
                    UnitComponent unitComponent = bekill.DomainScene().GetComponent<UnitComponent>();
                    Unit dropitem = unitComponent.AddChildWithId<Unit, int>(IdGenerater.Instance.GenerateId(), 1);
                    dropitem.AddComponent<UnitInfoComponent>();
                    dropitem.Type = UnitType.DropItem;
                    DropComponent dropComponent = dropitem.AddComponent<DropComponent>();
                    dropComponent.SetItemInfo(droplist[i].ItemID, droplist[i].ItemNum);
                    dropComponent.IfDamgeDrop = monsterCof.IfDamgeDrop;
                    if (bekill.GetComponent<AIComponent>() != null)
                    {
                        dropComponent.BeAttackPlayerList = bekill.GetComponent<AIComponent>().BeAttackPlayerList;
                    }
                    //掉落归属问题 掉落类型为2 原来为： 最后一刀 修改为 第一拾取权限为优先攻击他的人,如果这个人死了，那么拾取权限清空，下一次伤害是谁归属权就是谁。
                    long ownderId = main!=null ? main.Id : 0;
                    if (monsterCof.DropType == 2 && beattackIds.Count > 0 && unitComponent.Get(beattackIds[0])!=null)
                    {
                        ownderId = beattackIds[0];
                    }
                    dropComponent.OwnerId = monsterCof.DropType == 0 ? 0 : ownderId;
                    dropComponent.ProtectTime = monsterCof.DropType == 0 ? 0 : serverTime + 30000;
                    float dropX = bekill.Position.x + RandomHelper.RandomNumberFloat(-1f, 1f);
                    float dropY = bekill.Position.y;
                    float dropZ = bekill.Position.z + RandomHelper.RandomNumberFloat(-1f, 1f);
                    dropitem.Position = new UnityEngine.Vector3(dropX, dropY, dropZ);
                    dropitem.AddComponent<AOIEntity, int, Vector3>(9 * 1000, dropitem.Position);
                }
            }
            if (monsterCof.DropType == 1)
            {
                for (int i = 0; i < beattackIds.Count; i++)
                {
                    Unit beAttack = bekill.DomainScene().GetComponent<UnitComponent>().Get(beattackIds[i]);
                    if (beAttack == null || beAttack.Type!= UnitType.Player)
                    {
                        continue;
                    }

                    M2C_CreateDropItems m2C_CreateDropItems = new M2C_CreateDropItems();
                    for (int k = 0; k < droplist.Count; k++)
                    {
                        //宠物蛋直接进背包
                        if (monsterCof.MonsterSonType == 57)
                        {
                            beAttack.GetComponent<BagComponent>().OnAddItemData($"{droplist[k].ItemID};{droplist[k].ItemNum}", $"{ItemGetWay.PickItem}_{TimeHelper.ServerNow()}");
                            continue;
                        }

                        m2C_CreateDropItems.Drops.Add(new DropInfo() {
                            DropType = 1, ItemID = droplist[k].ItemID, ItemNum = droplist[k].ItemNum,
                            X = bekill.Position.x + RandomHelper.RandomNumberFloat(-1f, 1f),
                            Y = bekill.Position.y,
                            Z = bekill.Position.z + RandomHelper.RandomNumberFloat(-1f, 1f),
                    }) ;
                    }                    
                    MessageHelper.SendToClient(beAttack, m2C_CreateDropItems);
                }
            }
        }

        public static void CreateDropItems(Unit main, Unit beKill, int dropType,  int dropId, string par)
        {
            // 0 公共掉落 2保护掉落   1私有掉落
            if (dropType == 0) 
            {
                List<RewardItem> droplist = new List<RewardItem>();
                DropHelper.DropIDToDropItem(dropId, droplist);
                if (par == "2")
                {
                    droplist.AddRange(droplist);
                }

                for (int i = 0; i < droplist.Count; i++)
                {
                    UnitComponent unitComponent = beKill.DomainScene().GetComponent<UnitComponent>();
                    Unit dropitem = unitComponent.AddChildWithId<Unit, int>(IdGenerater.Instance.GenerateId(), 1);
                    dropitem.AddComponent<UnitInfoComponent>();
                    dropitem.Type = UnitType.DropItem;
                    DropComponent dropCheckComponent = dropitem.AddComponent<DropComponent>();
                    dropCheckComponent.SetItemInfo(droplist[i].ItemID, droplist[i].ItemNum);
                    float dropX = beKill.Position.x + RandomHelper.RandomNumberFloat(-1f, 1f);
                    float dropY = beKill.Position.y;
                    float dropZ = beKill.Position.z + RandomHelper.RandomNumberFloat(-1f, 1f);
                    dropitem.Position = new UnityEngine.Vector3(dropX, dropY, dropZ);
                    dropitem.AddComponent<AOIEntity, int, Vector3>(9 * 1000, dropitem.Position);
                }
            }
            if (dropType == 1)
            {
                M2C_CreateDropItems m2C_CreateDropItems = new M2C_CreateDropItems();
                List<RewardItem> droplist = new List<RewardItem>();
                DropHelper.DropIDToDropItem(dropId, droplist);
                for (int k = 0; k < droplist.Count; k++)
                {
                    m2C_CreateDropItems.Drops.Add(new DropInfo()
                    {
                        DropType = 1,
                        ItemID = droplist[k].ItemID,
                        ItemNum = droplist[k].ItemNum,
                        X = beKill.Position.x + RandomHelper.RandomNumberFloat(-1f, 1f),
                        Y = beKill.Position.y,
                        Z = beKill.Position.z + RandomHelper.RandomNumberFloat(-1f, 1f),
                    });
                }
                MessageHelper.SendToClient(main, m2C_CreateDropItems);
            }
        }
    }
}