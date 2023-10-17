using UnityEngine;
using System.Collections.Generic;

namespace ET
{
    public static class PetMingDungeonComponentSystem
    {

        public static async ETTask OnGameOver(this PetMingDungeonComponent self, int result)
        {
            Log.Console($"OnGameOver:  {result}");
            if (result == CombatResultEnum.Win && self.MainUnit != null)
            {
                long chargeServerId = DBHelper.GetActivityServerId(self.DomainZone());
                A2M_PetMingBattleWinResponse r_GameStatusResponse = (A2M_PetMingBattleWinResponse)await ActorMessageSenderComponent.Instance.Call
                    (chargeServerId, new M2A_PetMingBattleWinRequest()
                    {
                        MingType = self.MineType,
                        Postion = self.Position,
                        UnitID = self.MainUnit.Id,
                        TeamId = self.TeamId
                    });
            }
            await ETTask.CompletedTask;
        }

        /// <summary>
        /// 1 成功 2失败
        /// </summary>
        /// <param name="self"></param>
        /// <returns></returns>
        public static int GetCombatResult(this PetMingDungeonComponent self)
        {
            int number_self = 0;
            int number_enemy = 0;
            List<Unit> unitList = self.DomainScene().GetComponent<UnitComponent>().GetAll();
            for (int i = 0; i < unitList.Count; i++)
            {
                Unit unit = unitList[i];
                if (unit.Type != UnitType.Pet || !unit.IsCanBeAttack())
                {
                    continue;
                }
                if (unit.GetBattleCamp() == CampEnum.CampPlayer_1)
                {
                    number_self++;
                }
                else
                {
                    number_enemy++;
                }
            }
            if (number_self > 0 && number_enemy > 0)
                return CombatResultEnum.None;
            if (number_self > 0 && number_enemy == 0)
                return CombatResultEnum.Win;
            return CombatResultEnum.Fail;
        }


        public static void OnKillEvent(this PetMingDungeonComponent self)
        {
            int result = self.GetCombatResult();
            if (result != CombatResultEnum.None)
            {
                self.OnGameOver(result).Coroutine();
            }
        }

        public static async ETTask GeneratePetFuben(this PetMingDungeonComponent self)
        {
            long chargeServerId = DBHelper.GetActivityServerId(self.DomainZone());
            A2M_PetMingPlayerInfoResponse r_GameStatusResponse = (A2M_PetMingPlayerInfoResponse)await ActorMessageSenderComponent.Instance.Call
                (chargeServerId, new M2A_PetMingPlayerInfoRequest()
                {
                    MingType = self.MineType, 
                    Postion = self.Position,
                });

            Log.Console($"r_GameStatusResponse:  {r_GameStatusResponse.PetMingPlayerInfo}");
            if (r_GameStatusResponse.Error != ErrorCode.ERR_Success)
            {
                return;
            }

            //己方队伍
            Unit unit = self.MainUnit;
            unit.GetComponent<StateComponent>().StateTypeAdd(StateTypeEnum.WuDi);
            PetComponent petComponent = unit.GetComponent<PetComponent>();
            List<long> pets = petComponent.PetMingList;
            for (int i = self.TeamId * 5; i < (self.TeamId + 1) * 5; i++)
            {
                RolePetInfo rolePetInfo = petComponent.GetPetInfo(pets[i]);
                if (rolePetInfo == null)
                {
                    continue;
                }
                Unit petunit = UnitFactory.CreateTianTiPet(unit.DomainScene(), unit.Id,
                    CampEnum.CampPlayer_1, rolePetInfo, AIHelp.Formation_1[i], 0f);
                petunit.GetComponent<AIComponent>().Stop();
            }

            //敌方队伍
            if (r_GameStatusResponse.PetMingPlayerInfo == null)
            {
                return;
            }
            long enemyId = r_GameStatusResponse.PetMingPlayerInfo.UnitId;
            int teamid = r_GameStatusResponse.PetMingPlayerInfo.TeamId;
            long dbCacheId = DBHelper.GetDbCacheId(self.DomainZone());
            D2G_GetComponent d2GGetUnit = (D2G_GetComponent)await ActorMessageSenderComponent.Instance.Call(dbCacheId, new G2D_GetComponent() { UnitId = enemyId, Component = DBHelper.PetComponent });
            if (d2GGetUnit.Component != null)
            {
                PetComponent petComponent_enemy = d2GGetUnit.Component as PetComponent;
                List<long> petsenemy = petComponent_enemy.PetMingList;
                for (int i = teamid * 5; i < (teamid + 1) * 5; i++)
                {
                    RolePetInfo rolePetInfo = petComponent_enemy.GetPetInfo(petComponent_enemy.PetMingList[i]);
                    if (rolePetInfo == null)
                    {
                        continue;
                    }
                    if (unit.GetParent<UnitComponent>().Get(rolePetInfo.Id) != null)
                    {
                        Log.Debug($"宠物ID重复：{unit.Id}");
                        continue;
                    }
                    Unit petunit = UnitFactory.CreateTianTiPet(unit.DomainScene(), 0,
                       CampEnum.CampPlayer_2, rolePetInfo, AIHelp.Formation_2[i], 180f);
                }
            }
        }
    }
}
