using System.Collections.Generic;
using UnityEngine;
using System.Linq;

namespace ET
{
    public static class UnitHelper
    {
        public static int GetSceneType(Unit unit)
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

             //设置数据
            UserInfoComponent userInfoComponent = unit.GetComponent<UserInfoComponent>();
            unitInfo.PlayerName = userInfoComponent.UserInfo.Name;
            unitInfo.PlayerOcc = userInfoComponent.UserInfo.Occ;
            unitInfo.UserId = userInfoComponent.UserInfo.UserId;
            unitInfo.ConfigId = userInfoComponent.UserInfo.Occ;
            unitInfo.UnionName = string.IsNullOrWhiteSpace(userInfoComponent.UserInfo.UnionName)?"": userInfoComponent.UserInfo.UnionName;
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
            M2C_CreateUnits createUnits = new M2C_CreateUnits();

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
           
            MessageHelper.SendToClient(unit, createUnits);
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
            UnitInfoComponent unitInfoComponent = unit.GetComponent<UnitInfoComponent>();
            spilingInfo.X = unit.Position.x;
            spilingInfo.Y = unit.Position.y;
            spilingInfo.Z = unit.Position.z;
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

            spilingInfo.ReviveTime = reviveTime;
            //广播创建的是那个怪物ID
            spilingInfo.SkillId = unit.GetComponent<UnitInfoComponent>().EnergySkillId;
            spilingInfo.MonsterID = unit.ConfigId;
            return spilingInfo;
        }

        public static RolePetInfo CreatePetInfo(Unit unit)
        {
            RolePetInfo rolePetInfo = new RolePetInfo();
            UnitInfoComponent unitInfoComponent = unit.GetComponent<UnitInfoComponent>();
            rolePetInfo.Id = unit.Id;
            rolePetInfo.ConfigId = unit.ConfigId;
            rolePetInfo.X = unit.Position.x;
            rolePetInfo.Y = unit.Position.y;
            rolePetInfo.Z = unit.Position.z;

            long masterId = unit.GetComponent<NumericComponent>().GetAsLong(NumericType.MasterId);
            Unit player = unit.GetParent<UnitComponent>().Get(masterId);
            if (player != null)
            {
                rolePetInfo.PlayerName = player.GetComponent<UserInfoComponent>().UserInfo.Name;
            }

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

            return rolePetInfo;
        }

        public static DropInfo CreateDropInfo(Unit unit)
        {
            DropInfo dropinfo = new DropInfo();
            dropinfo.UnitId = unit.Id;

            DropComponent dropCheckComponent = unit.GetComponent<DropComponent>();
            dropinfo.ItemID = dropCheckComponent.ItemID;
            dropinfo.ItemNum = dropCheckComponent.ItemNum;
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

        public static void RecordPostion(this Unit self)
        {
            int sceneTypeEnum = self.DomainScene().GetComponent<MapComponent>().SceneTypeEnum;
            if (sceneTypeEnum == (int)SceneTypeEnum.MainCityScene)
            {
                self.GetComponent<NumericComponent>().NumericDic[NumericType.MainCity_X] = (long)(10000 * self.Position.x);
                self.GetComponent<NumericComponent>().NumericDic[NumericType.MainCity_Y] = (long)(10000 * self.Position.y);
                self.GetComponent<NumericComponent>().NumericDic[NumericType.MainCity_Z] = (long)(10000 * self.Position.z);
            }
        }

        public static void ResetPostion(this Unit self)
        {
            self.GetComponent<NumericComponent>().NumericDic[NumericType.MainCity_X] = 0;
            self.GetComponent<NumericComponent>().NumericDic[NumericType.MainCity_Y] = 0;
            self.GetComponent<NumericComponent>().NumericDic[NumericType.MainCity_Z] = 0;
        }

        public static int GetBattleCamp(this Unit self)
        {
            return self.GetComponent<NumericComponent>().GetAsInt(NumericType.BattleCamp);
        }
    }
}