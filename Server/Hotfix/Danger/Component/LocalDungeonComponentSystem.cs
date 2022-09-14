using System;
using System.Collections.Generic;
using UnityEngine;

namespace ET
{
    [Timer(TimerType.LocalDungeonTimer)]
    public class LocalDungeonTimer : ATimer<LocalDungeonComponent>
    {
        public override void Run(LocalDungeonComponent self)
        {
            try
            {
                self.OnTimer();
            }
            catch (Exception e)
            {
                Log.Error($"move timer error: {self.Id}\n{e}");
            }
        }
    }

    [ObjectSystem]
    public class LocalDungeonComponentAwakeSystem : AwakeSystem<LocalDungeonComponent>
    {
        public override void Awake(LocalDungeonComponent self)
        {
            self.RefreshMonsters.Clear();   
        }
    }

    [ObjectSystem]
    public class LocalDungeonComponentDestroySystem : DestroySystem<LocalDungeonComponent>
    {
        public override void Destroy(LocalDungeonComponent self)
        {
            self.RefreshMonsters.Clear();
            TimerComponent.Instance?.Remove(ref self.Timer);
        }
    }

    public static class LocalDungeonComponentSystem
    {

        public static void OnKillEvent(this LocalDungeonComponent self, Unit unit)
        {
            if (unit.Type != UnitType.Monster)
            {
                return;
            }
            UnitInfoComponent unitInfoComponent = unit.GetComponent<UnitInfoComponent>();
            MonsterConfig monsterConfig = MonsterConfigCategory.Instance.Get(unitInfoComponent.UnitCondigID);
            if (monsterConfig.MonsterType == (int)MonsterTypeEnum.Boss)
            {
                return;
            }
            NumericComponent numericComponent = self.MainUnit.GetComponent<NumericComponent>();
            int killNumber = numericComponent.GetAsInt(NumericType.TiLi_Kill_Number);
            if (killNumber >= 4)
            {
                numericComponent.ApplyValue(NumericType.TiLi_Kill_Number, 0, false);
                self.MainUnit.GetComponent<UserInfoComponent>().UpdateRoleData(UserDataType.PiLao, "-1", true).Coroutine();
            }
            else
            {
                numericComponent.ApplyValue(NumericType.TiLi_Kill_Number, killNumber+1, false);
            }
        }

        public static void OnTimer(this LocalDungeonComponent self)
        {
            long time = TimeHelper.ServerNow();
            for (int i = self.RefreshMonsters.Count - 1; i >= 0; i--)
            {
                RefreshMonster refreshMonster = self.RefreshMonsters[i];
                if (time < refreshMonster.RefreshTime)
                {
                    continue;
                }
                self.CreateMonsters(refreshMonster);
                self.RefreshMonsters.RemoveAt(i);
            }

            if (self.RefreshMonsters.Count == 0)
            {
                TimerComponent.Instance?.Remove(ref self.Timer);
            }
        }

        public static void  CreateMonsters(this LocalDungeonComponent self, RefreshMonster refreshMonster)
        {
            UnitFactory.CreateMonster(self.GetParent<Scene>(), 
                new Vector3(refreshMonster.PositionX, refreshMonster.PositionY, refreshMonster.PositionZ),
                FubenDifficulty.Normal, refreshMonster.MonsterId, new CreateMonsterInfo());
        }

        public static void OnCleanMonsterCD(this LocalDungeonComponent self)
        {
            List<Unit> entities = self.DomainScene().GetComponent<UnitComponent>().GetAll();
            for (int i = 0; i < entities.Count; i++)
            {
                Unit entity = entities[i];
                if (entity.GetComponent<UnitInfoComponent>().Type != UnitType.Monster)
                {
                    continue;
                }
                if (entity.GetComponent<NumericComponent>().GetAsInt(NumericType.Now_Dead)  == 1)
                {
                    entity.GetComponent<HeroDataComponent>().OnRevive();
                }
            }
        }

        public static void OnAddRefreshList(this LocalDungeonComponent self, Unit unit, long aliveTime)
        {
            UnitInfoComponent unitInfoComponent = unit.GetComponent<UnitInfoComponent>();
            Vector3 bornpos;
            if (unit.GetComponent<AIComponent>() == null)
            {
                bornpos = unit.Position;
            }
            else {
                bornpos = unit.GetComponent<AIComponent>().BornPostion;
            }
             
            self.RefreshMonsters.Add(new RefreshMonster()
            {
                MonsterId = unitInfoComponent.UnitCondigID,
                RefreshTime = TimeHelper.ServerNow() + aliveTime,
                PositionX = bornpos.x,
                PositionY = bornpos.y,
                PositionZ = bornpos.z,
                Range = 0,
                Number = 1,
            });
            if (self.Timer == 0)
            {
                self.Timer = TimerComponent.Instance.NewRepeatedTimer(1000, TimerType.LocalDungeonTimer, self);
            }
        }

        public static void GenerateFubenScene(this LocalDungeonComponent self, int mapid)
        {
            DungeonConfig chapterSonConfig = DungeonConfigCategory.Instance.Get(mapid);

            FubenHelp.CreateMonsterList(self.DomainScene(), chapterSonConfig.CreateMonster, self.Difficulty).Coroutine();

            if (chapterSonConfig.MonsterGroup != 0)
            {
                MonsterGroupConfig monsterGroupConfig = MonsterGroupConfigCategory.Instance.Get(chapterSonConfig.MonsterGroup);
                FubenHelp.CreateMonsterList(self.DomainScene(), monsterGroupConfig.CreateMonster, self.Difficulty).Coroutine();
            }

            //生成npc
            int[] npcList = chapterSonConfig.NpcList;
            if (npcList != null)
            {
                for (int i = 0; i < npcList.Length; i++)
                {
                    if (npcList[i] == 0)
                    {
                        continue;
                    }
                    UnitFactory.CreateNpc(self.DomainScene(), npcList[i]);
                }
            }
            //生成传送点
            //读取传送坐标点配置
            if (chapterSonConfig.TransmitPos != null)
            {
                for (int i = 0; i < chapterSonConfig.TransmitPos.Length; i++)
                {
                    int transferId = chapterSonConfig.TransmitPos[i];
                    if (transferId == 0)
                    {
                        continue;
                    }

                    DungeonTransferConfig dungeonTransferConfig = DungeonTransferConfigCategory.Instance.Get(transferId);
                    int[] position = dungeonTransferConfig.Position;
                    Vector3 vector3 = new Vector3(position[0] * 0.01f, position[1] * 0.01f, position[2] * 0.01f);
                    //创建传送点Unit
                    Unit chuansong = self.DomainScene().GetComponent<UnitComponent>().AddChildWithId<Unit, int>(IdGenerater.Instance.GenerateId(), 1);
                    self.DomainScene().GetComponent<UnitComponent>().Add(chuansong);
                    chuansong.AddComponent<ChuansongComponent>();
                    UnitInfoComponent unitInfoComponent = chuansong.AddComponent<UnitInfoComponent>();
                    unitInfoComponent.UnitCondigID = transferId;
                    unitInfoComponent.Type = UnitType.Chuansong;
                    chuansong.TestType = UnitType.Chuansong;
                    chuansong.Position = vector3;
                    chuansong.AddComponent<AOIEntity, int, Vector3>(9 * 1000, chuansong.Position);
                }
            }
            
        }



    }
}
