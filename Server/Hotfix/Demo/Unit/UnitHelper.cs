using System.Collections.Generic;
using UnityEngine;
using System.Linq;

namespace ET
{
    public static class UnitHelper
    {
        public static int GetFubenDifficulty(Unit unit)
        {
            int fubenDifficulty = FubenDifficulty.None;
            MapComponent mapComponent = unit.DomainScene().GetComponent<MapComponent>();
            if (mapComponent.SceneTypeEnum == (int)SceneTypeEnum.CellDungeon)
            {
                fubenDifficulty = unit.DomainScene().GetComponent<CellDungeonComponent>().FubenDifficulty;
            }
            if (mapComponent.SceneTypeEnum == (int)SceneTypeEnum.CellDungeon)
            {
                fubenDifficulty = unit.DomainScene().GetComponent<LocalDungeonComponent>().FubenDifficulty;
            }
            return fubenDifficulty;
        }

        public static UnitInfo CreateUnitInfo(Unit unit)
        {
            UnitInfo unitInfo = new UnitInfo();
            UnitInfoComponent unitInfoComponent = unit.GetComponent<UnitInfoComponent>();
            NumericComponent nc = unit.GetComponent<NumericComponent>();
            unitInfo.UnitId = unit.Id;
            unitInfo.ConfigId = unit.ConfigId;
            //unitInfo.Type = (int)unit.Type;
            Vector3 position = unit.Position;
            unitInfo.X = position.x;
            unitInfo.Y = position.y;
            unitInfo.Z = position.z;
            Vector3 forward = unit.Forward;
            unitInfo.ForwardX = forward.x;
            unitInfo.ForwardY = forward.y;
            unitInfo.ForwardZ = forward.z;

            MoveComponent moveComponent = unit.GetComponent<MoveComponent>();
            if (moveComponent != null)
            {
                if (!moveComponent.IsArrived())
                {
                    unitInfo.MoveInfo = new MoveInfo();
                    for (int i = moveComponent.N; i < moveComponent.Targets.Count; ++i)
                    {
                        Vector3 pos = moveComponent.Targets[i];
                        unitInfo.MoveInfo.X.Add(pos.x);
                        unitInfo.MoveInfo.Y.Add(pos.y);
                        unitInfo.MoveInfo.Z.Add(pos.z);
                    }
                }
            }

            //创建玩家循环赋值属性
            foreach ((int key, long value) in nc.NumericDic)
            {
                if (key >= (int)NumericType.Max)
                {
                    continue;
                }
                //if (!NumericHelp.BroadcastType.Contains(key))
                //{
                //    continue;
                //}
                unitInfo.Ks.Add(key);
                unitInfo.Vs.Add(value);
            }

            //携带的buff
            unitInfo.Buffs = unit.GetComponent<BuffManagerComponent>().GetMessageBuff();
            unitInfo.Skills = unit.GetComponent<SkillManagerComponent>().GetMessageSkill();
            //设置数据
            UserInfoComponent userInfoComponent = unit.GetComponent<UserInfoComponent>();
            unitInfo.PlayerName = userInfoComponent.UserInfo.Name;
            unitInfo.PlayerOcc = userInfoComponent.UserInfo.Occ;
            unitInfo.UserId = userInfoComponent.UserInfo.UserId;
            unitInfo.ConfigId = userInfoComponent.UserInfo.Occ;
            unitInfo.UnionName = string.IsNullOrWhiteSpace(userInfoComponent.UserInfo.UnionName) ? "" : userInfoComponent.UserInfo.UnionName;
            unitInfo.StallName = unitInfoComponent.StallName;
            return unitInfo;
        }

        /// <summary>
        /// 获取看见unit的玩家，主要用于广播
        /// </summary>
        /// <param name="self"></param>
        /// <returns></returns>
        public static Dictionary<long, AOIEntity> GetBeSeePlayers(this Unit self)
        {
            return self.GetComponent<AOIEntity>().GetBeSeePlayers();
        }

        public static void NoticeUnitAdd(Unit unit, Unit sendUnit)
        {
            //非自己击杀的怪物。不同步
            if (sendUnit.Type == UnitType.DropItem)
            {
                DropComponent dropComponent = sendUnit.GetComponent<DropComponent>();
                if (dropComponent.IfDamgeDrop == 1 && dropComponent.BeAttackPlayerList.Contains(unit.Id))
                {
                    return;
                }
            }

            M2C_CreateUnits createUnits = new M2C_CreateUnits();
            GetUnitInfo(sendUnit, createUnits);
            MessageHelper.SendToClient(unit, createUnits);
        }

        public static void GetUnitInfo(Unit sendUnit, M2C_CreateUnits createUnits)
        {
            switch (sendUnit.Type)
            {
                case UnitType.Player:
                    createUnits.Units.Add(CreateUnitInfo(sendUnit));
                    break;
                case UnitType.Monster:
                    NumericComponent numericComponent = sendUnit.GetComponent<NumericComponent>();
                    int now_dead = numericComponent != null ? numericComponent.GetAsInt(NumericType.Now_Dead) : 0;
                    if (now_dead == 0)
                    {
                        createUnits.Spilings.Add(CreateSpilingInfo(sendUnit, 0));
                        break;
                    }
                    long reviveTime = numericComponent.GetAsLong(NumericType.ReviveTime);
                    if (now_dead == 1 && reviveTime > 0)
                    {
                        createUnits.Spilings.Add(CreateSpilingInfo(sendUnit, reviveTime));
                    }
                    break;
                case UnitType.DropItem:
                    createUnits.Drops.Add(CreateDropInfo(sendUnit));
                    break;
                case UnitType.Chuansong:
                    createUnits.Transfers.Add(CreateTransferInfo(sendUnit));
                    break;
                case UnitType.Npc:
                    createUnits.Npcs.Add(CreateNpcInfo(sendUnit));
                    break;
                case UnitType.Pet:
                    createUnits.Pets.Add(CreatePetInfo(sendUnit));
                    break;
            }
        }

        public static void NoticeUnitRemove(Unit unit, Unit sendUnit)
        {
            M2C_RemoveUnits removeUnits = new M2C_RemoveUnits();
            removeUnits.Units.Add(sendUnit.Id);
            MessageHelper.SendToClient(unit, removeUnits);
        }

        public static SpilingInfo CreateSpilingInfo(Unit unit, long reviveTime)
        {
            SpilingInfo spilingInfo = new SpilingInfo();
            unit.GetComponent<UnitInfoComponent>();
            spilingInfo.X = unit.Position.x;
            spilingInfo.Y = unit.Position.y;
            spilingInfo.Z = unit.Position.z;
            Vector3 forward = unit.Forward;
            spilingInfo.ForwardX = forward.x;
            spilingInfo.ForwardY = forward.y;
            spilingInfo.ForwardZ = forward.z;
            spilingInfo.UnitId = unit.Id;

            NumericComponent nc = unit.GetComponent<NumericComponent>();
            if (nc != null)
            {
                foreach ((int key, long value) in nc.NumericDic)
                {
                    if (key >= (int)NumericType.Max)
                    {
                        continue;
                    }
                    spilingInfo.Ks.Add(key);
                    spilingInfo.Vs.Add(value);
                }
            }

            if (unit.GetComponent<BuffManagerComponent>() != null)
            {
                spilingInfo.Buffs = unit.GetComponent<BuffManagerComponent>().GetMessageBuff();
                spilingInfo.Skills = unit.GetComponent<SkillManagerComponent>().GetMessageSkill();
            }

            spilingInfo.ReviveTime = reviveTime;
            //广播创建的是那个怪物ID
            spilingInfo.SkillId = unit.GetComponent<UnitInfoComponent>().EnergySkillId;
            spilingInfo.MonsterID = unit.ConfigId;
            return spilingInfo;
        }

        public static RolePetInfo CreatePetInfo(Unit unit)
        {
            RolePetInfo rolePetInfo = new RolePetInfo();
            rolePetInfo.Id = unit.Id;
            rolePetInfo.ConfigId = unit.ConfigId;
            rolePetInfo.X = unit.Position.x;
            rolePetInfo.Y = unit.Position.y;
            rolePetInfo.Z = unit.Position.z;

            rolePetInfo.PlayerName = unit.GetComponent<UnitInfoComponent>().PlayerName;
            rolePetInfo.PetName = unit.GetComponent<UnitInfoComponent>().StallName;

            NumericComponent nc = unit.GetComponent<NumericComponent>();
            foreach ((int key, long value) in nc.NumericDic)
            {
                if (key >= (int)NumericType.Max)
                {
                    continue;
                }
                rolePetInfo.Ks.Add(key);
                rolePetInfo.Vs.Add(value);
            }

            rolePetInfo.Buffs = unit.GetComponent<BuffManagerComponent>().GetMessageBuff();
            rolePetInfo.Skills = unit.GetComponent<SkillManagerComponent>().GetMessageSkill();
            return rolePetInfo;
        }

        public static DropInfo CreateDropInfo(Unit unit)
        {
            DropInfo dropinfo = new DropInfo();
            dropinfo.UnitId = unit.Id;
            //DropType == 0 公共掉落 2保护掉落   1私有掉落
            DropComponent dropComponent = unit.GetComponent<DropComponent>();
            dropinfo.DropType = dropComponent.OwnerId > 0 ? 2 : 0;
            dropinfo.ItemID = dropComponent.ItemID;
            dropinfo.ItemNum = dropComponent.ItemNum;
            dropinfo.X = unit.Position.x;
            dropinfo.Y = unit.Position.y;
            dropinfo.Z = unit.Position.z;
            return dropinfo;
        }

        public static NpcInfo CreateNpcInfo(Unit unit)
        {
            NpcInfo npcInfo = new NpcInfo();

            npcInfo.UnitId = unit.Id;
            npcInfo.NpcID = unit.ConfigId;
            npcInfo.X = unit.Position.x;
            npcInfo.Y = unit.Position.y;
            npcInfo.Z = unit.Position.z;
            return npcInfo;
        }

        public static TransferInfo CreateTransferInfo(Unit unit)
        {
            TransferInfo transferinfo = new TransferInfo();
            ChuansongComponent chuansongComponent = unit.GetComponent<ChuansongComponent>();

            transferinfo.UnitId = unit.Id;
            transferinfo.X = unit.Position.x;
            transferinfo.Y = unit.Position.y;
            transferinfo.Z = unit.Position.z;
            transferinfo.CellIndex = chuansongComponent.CellIndex;
            transferinfo.Direction = chuansongComponent.DirectionType;
            transferinfo.TransferId = unit.ConfigId;
            return transferinfo;
        }

        public static List<Unit> GetUnitList(this Unit self, int unitType)
        {
            List<Unit> units = new List<Unit>();
            List<Unit> allunits = self.DomainScene().GetComponent<UnitComponent>().GetAll();
            for (int i = 0; i < allunits.Count; i++)
            {
                if (allunits[i].Type == unitType)
                {
                    units.Add(allunits[i]);
                }
            }
            return units;
        }

        public static bool IsRobot(this Unit self)
        {
            return self.GetComponent<UserInfoComponent>().UserInfo.RobotId > 0;
        }

        public static int GetWeaponType(this Unit self)
        {
            BagComponent bagComponent = self.GetComponent<BagComponent>();
            int EquipType = bagComponent != null ? bagComponent.GetEquipType() : ItemEquipType.Common;
            return EquipType;
        }

        public static int GetWeaponSkill(this Unit self, int skillId)
        {
            BagComponent bagComponent = self.GetComponent<BagComponent>();
            int EquipType = bagComponent != null ? bagComponent.GetEquipType() : ItemEquipType.Common;
            return SkillHelp.GetWeaponSkill(skillId, EquipType);
        }

        public static void SetBornPosition(this Unit self, Vector3 vector3)
        {
            NumericComponent numericComponent = self.GetComponent<NumericComponent>();
            numericComponent.ApplyValue(NumericType.Born_X, (long)(vector3.x * 10000));
            numericComponent.ApplyValue(NumericType.Born_Y, (long)(vector3.y * 10000));
            numericComponent.ApplyValue(NumericType.Born_Z, (long)(vector3.z * 10000));
        }

        public static Vector3 GetBornPostion(this Unit self)
        {
            NumericComponent numericComponent = self.GetComponent<NumericComponent>();
            return new Vector3(numericComponent.GetAsFloat(NumericType.Born_X),
                numericComponent.GetAsFloat(NumericType.Born_Y),
                numericComponent.GetAsFloat(NumericType.Born_Z));
        }

        public static void OnUpdateHorseRide(this Unit self)
        {
            int horseId = self.GetComponent<NumericComponent>().GetAsInt(NumericType.HorseFightID);
            if (horseId==0)
            {
                return;
            }

            int horseRide = self.GetComponent<NumericComponent>().GetAsInt(NumericType.HorseRide);
            ZuoQiShowConfig zuoqiCof = ZuoQiShowConfigCategory.Instance.Get(horseId);
            if (horseRide == 1)
            {
                BuffData buffData_2 = new BuffData();
                buffData_2.BuffConfig = SkillBuffConfigCategory.Instance.Get(zuoqiCof.MoveBuffID);
                self.GetComponent<BuffManagerComponent>().BuffFactory(buffData_2, self, null);
            }
            if (horseRide == 0)
            {
                self.GetComponent<BuffManagerComponent>().BuffRemove(zuoqiCof.MoveBuffID);
            }
        }

        public static void RecordPostion(this Unit self, int sceneType, int sceneId)
        {
            bool record = false;
            NumericComponent numericComponent = self.GetComponent<NumericComponent>();
            if (!SceneConfigHelper.UseSceneConfig(sceneType) || sceneId == 0)
            {
                record = false;
            }
            else
            {
                if (!SceneConfigCategory.Instance.Contain(sceneId))
                {
                    record = false;
                    Log.Debug($"sceneconfig ==null:  sceneType: {sceneType} sceneId: {sceneId}");
                }
                else
                {
                    record = SceneConfigCategory.Instance.Get(sceneId).IfInitPosi == 1;
                }
            }
            if (record)
            {
                numericComponent.Set(NumericType.MainCity_X, self.Position.x);
                numericComponent.Set(NumericType.MainCity_Y, self.Position.y);
                numericComponent.Set(NumericType.MainCity_Z, self.Position.z);
            }
            else
            {
                numericComponent.Set(NumericType.MainCity_X, 0f);
                numericComponent.Set(NumericType.MainCity_Y, 0f);
                numericComponent.Set(NumericType.MainCity_Z, 0f);
            }
        }
    }
}