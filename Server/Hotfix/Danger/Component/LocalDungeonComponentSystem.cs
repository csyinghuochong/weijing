using System;
using System.Collections.Generic;
using UnityEngine;

namespace ET
{
  
    [ObjectSystem]
    public class LocalDungeonComponentAwakeSystem : AwakeSystem<LocalDungeonComponent>
    {
        public override void Awake(LocalDungeonComponent self)
        {
            self.RandomJingLing = 0;
            self.RandomMonster = 0;
        }
    }

    [ObjectSystem]
    public class LocalDungeonComponentDestroySystem : DestroySystem<LocalDungeonComponent>
    {
        public override void Destroy(LocalDungeonComponent self)
        {

        }
    }

    public static class LocalDungeonComponentSystem
    {

        public static void OnKillEvent(this LocalDungeonComponent self, Unit unit, Unit attack)
        {
            if (attack == null || attack.Type != UnitType.Player)
            {
                return;
            }
            if (unit.Type != UnitType.Monster)
            {
                return;
            }

            if (unit.ConfigId == SeasonHelper.SeasonBossId)
            {
                self.MainUnit.GetComponent<NumericComponent>().ApplyValue( NumericType.SeasonBossRefreshTime, TimeHelper.ServerNow() + TimeHelper.Hour );
            }

            MonsterConfig monsterConfig = MonsterConfigCategory.Instance.Get(unit.ConfigId);
            UserInfoComponent userInfoComponent = self.MainUnit.GetComponent<UserInfoComponent>();
            if (userInfoComponent == null || userInfoComponent.IsDisposed)
            {
                return;
            }
            if (monsterConfig.MonsterType == (int)MonsterTypeEnum.Boss)
            {
                userInfoComponent.UpdateRoleData(UserDataType.BaoShiDu, "-1", true);
                return;
            }


            ///刷新刷出神秘之门
            if (userInfoComponent.UserInfo.PiLao > 0 && !unit.IsSceneItem() && RandomHelper.RandFloat01() < 0.001f)
            {
                int shenminId = 40000003;
                List<Unit> npclist = self.MainUnit.GetParent<UnitComponent>().GetAll();
                for (int i = 0; i < npclist.Count; i++)
                {
                    if (npclist[i].Type == UnitType.Npc && npclist[i].ConfigId == shenminId)
                    {
                        shenminId = 0;
                    }
                }
                if (shenminId != 0)
                {
                    UnitFactory.CreateNpcByPosition(self.DomainScene(), shenminId, unit.Position);
                }
            }

            bool showlieopen = ActivityHelper.IsShowLieOpen();
            NumericComponent numericComponent = attack.GetComponent<NumericComponent>();
            int killNumber = numericComponent.GetAsInt(NumericType.TiLiKillNumber);

            if (killNumber >= 4)
            {
                numericComponent.ApplyValue(NumericType.TiLiKillNumber, 0, false);
                userInfoComponent.UpdateRoleData(UserDataType.PiLao, showlieopen ? "0" : "-1", true);

                if (userInfoComponent.UserInfo.PiLao > 0)
                {
                    numericComponent.ApplyChange(null, NumericType.CostTiLi, 1, 0);
                }
            }
            else
            {
                numericComponent.ApplyValue(NumericType.TiLiKillNumber, killNumber+1, false);
            }

            if (userInfoComponent.UserInfo.PiLao > 0 && numericComponent.GetAsInt(NumericType.JueXingExp) < 5000)
            {
                numericComponent.ApplyChange(null, NumericType.JueXingExp, 1, 0);
            }
            //int baoShiKillNumber = numericComponent.GetAsInt(NumericType.BaoShiKillNumber);
            //if (baoShiKillNumber >= 24)
            //{
            //    numericComponent.ApplyValue(NumericType.BaoShiKillNumber, 0, false);
            //    userInfoComponent.UpdateRoleData(UserDataType.BaoShiDu, "-1", true);
            //}
            //else
            //{
            //    numericComponent.ApplyValue(NumericType.BaoShiKillNumber, baoShiKillNumber + 1, false);
            //}
        }

        public static void OnCleanBossCD(this LocalDungeonComponent self)
        {
            List<Unit> entities = self.DomainScene().GetComponent<UnitComponent>().GetAll();
            for (int i = 0; i < entities.Count; i++)
            {
                Unit entity = entities[i];
                if (entity.Type != UnitType.Monster)
                {
                    continue;
                }
                if (entity.GetComponent<NumericComponent>().GetAsInt(NumericType.Now_Dead)  == 1)
                {
                    entity.GetComponent<HeroDataComponent>().OnRevive();
                }
            }
        }

        public static void GenerateFubenScene(this LocalDungeonComponent self, int mapid)
        {
            DungeonConfig chapterSonConfig = DungeonConfigCategory.Instance.Get(mapid);

            string allmonster = SceneConfigHelper.GetLocalDungeonMonsters_2(mapid);
            FubenHelp.CreateMonsterList(self.DomainScene(), allmonster);

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
                    chuansong.ConfigId = transferId;
                    chuansong.Type = UnitType.Chuansong;
                    chuansong.Position = vector3;
                    chuansong.AddComponent<AOIEntity, int, Vector3>(9 * 1000, chuansong.Position);
                }
            }
            
        }



    }
}
