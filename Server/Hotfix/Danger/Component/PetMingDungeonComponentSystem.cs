using System.Collections.Generic;

namespace ET
{
    public static class PetMingDungeonComponentSystem
    {

        public static async ETTask OnPetMingOccupy(this PetMingDungeonComponent self)
        {
            if (self.CombatResultEnum == CombatResultEnum.Win && self.MainUnit != null)
            {
                long chargeServerId = DBHelper.GetActivityServerId(self.DomainZone());
                A2M_PetMingBattleWinResponse r_GameStatusResponse = (A2M_PetMingBattleWinResponse)await ActorMessageSenderComponent.Instance.Call
                    (chargeServerId, new M2A_PetMingBattleWinRequest()
                    {
                        MingType = self.MineType,
                        Postion = self.Position,
                        UnitID = self.MainUnit.Id,
                        TeamId = self.TeamId,
                        WinPlayer = self.MainUnit.GetComponent<UserInfoComponent>().UserInfo.Name,
                    });
            }
        }

        public static async ETTask OnGameOver(this PetMingDungeonComponent self, int result)
        {
            self.CombatResultEnum = result;

            self.OnPetMingOccupy().Coroutine();

            long cdTime = result == CombatResultEnum.Win ? TimeHelper.Hour : TimeHelper.Minute * 10;
            M2C_FubenSettlement m2C_FubenSettlement = new M2C_FubenSettlement();
            m2C_FubenSettlement.BattleResult = result;
            m2C_FubenSettlement.StarInfos = result == CombatResultEnum.Win ?  new List<int>() { 1, 1, 1 } : new List<int>() { 0,0,0};
            MessageHelper.SendToClient(self.MainUnit, m2C_FubenSettlement);
            self.MainUnit.GetComponent<NumericComponent>().ApplyChange(null, NumericType.PetMineBattle,1,0  );
            self.MainUnit.GetComponent<NumericComponent>().ApplyValue(null, NumericType.PetMineCDTime, TimeHelper.ServerNow() + cdTime, 0);

            self.MainUnit.GetComponent<TaskComponent>().TriggerTaskEvent(TaskTargetType.MineBattleNumber_402, 0, 1);
            self.MainUnit.GetComponent<TaskComponent>().TriggerTaskCountryEvent(TaskTargetType.MineBattleNumber_402, 0, 1);
            if (result == CombatResultEnum.Win)
            {
                self.MainUnit.GetComponent<TaskComponent>().TriggerTaskEvent(TaskTargetType.MineWinNumber_403, 0, 1);
                self.MainUnit.GetComponent<TaskComponent>().TriggerTaskCountryEvent(TaskTargetType.MineWinNumber_403, 0, 1);
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

            if (r_GameStatusResponse.Error != ErrorCode.ERR_Success)
            {
                return;
            }

            //己方队伍
            Unit unit = self.MainUnit;
            unit.GetComponent<StateComponent>().StateTypeAdd(StateTypeEnum.WuDi);
            PetComponent petComponent = unit.GetComponent<PetComponent>();
            List<long> pets = petComponent.PetMingList;
            for (int i = 0; i <  5; i++)
            {
                long petinfoid = pets[i + self.TeamId * 5];
                RolePetInfo rolePetInfo = petComponent.GetPetInfo(petinfoid);
                if (rolePetInfo == null)
                {
                    continue;
                }

                int position = petComponent.PetMingPosition.IndexOf(petinfoid);
                position = position != -1 ? position %= 9 : i;   

                Unit petunit = UnitFactory.CreateTianTiPet(unit.DomainScene(), unit.Id,
                    CampEnum.CampPlayer_1, rolePetInfo, AIHelp.Formation_1[ position ], 0f, position);
                petunit.GetComponent<AIComponent>().Stop();
            }

            //敌方队伍
            if (r_GameStatusResponse.PetMingPlayerInfo == null)
            {
                MineBattleConfig mineBattleConfig = MineBattleConfigCategory.Instance.Get(self.MineType);
                int[] petdefendlist = mineBattleConfig.PetDefendInit;
                //初始配置

                for (int k = 0; k < petdefendlist.Length; k++)
                {
                    if (petdefendlist[k] == 0)
                    {
                        continue;
                    }

                    RolePetInfo petInfo = petComponent.GenerateNewPet(petdefendlist[k], 0);
                    petComponent.PetXiLian(petInfo, 2, 0, 0 );
                    petComponent.UpdatePetAttribute(petInfo, false);
                    petInfo.PlayerName = "机器人";
                    Unit petunit = UnitFactory.CreateTianTiPet(unit.DomainScene(), 0,
                       CampEnum.CampPlayer_2, petInfo, AIHelp.Formation_2[k], 180f, k);
                }
            }
            else
            {

                long enemyId = r_GameStatusResponse.PetMingPlayerInfo.UnitId;
                int teamid = r_GameStatusResponse.PetMingPlayerInfo.TeamId;
                long dbCacheId = DBHelper.GetDbCacheId(self.DomainZone());
                D2G_GetComponent d2GGetUnit = (D2G_GetComponent)await ActorMessageSenderComponent.Instance.Call(dbCacheId, new G2D_GetComponent() { UnitId = enemyId, Component = DBHelper.PetComponent });
                if (d2GGetUnit.Component != null)
                {
                    D2G_GetComponent d2GGetUnit_2 = (D2G_GetComponent)await ActorMessageSenderComponent.Instance.Call(dbCacheId, new G2D_GetComponent() { UnitId = enemyId, Component = DBHelper.BagComponent });
                    if (d2GGetUnit_2.Component == null)
                    {
                        return;
                    }

                    D2G_GetComponent d2GGetUnit_3 = (D2G_GetComponent)await ActorMessageSenderComponent.Instance.Call(dbCacheId, new G2D_GetComponent() { UnitId = enemyId, Component = DBHelper.NumericComponent });
                    if (d2GGetUnit_3.Component == null)
                    {
                        return;
                    }

                    PetComponent petComponent_enemy = d2GGetUnit.Component as PetComponent;
                    List<long> petsenemy = petComponent_enemy.PetMingList;
                    for (int i = 0; i < 5; i++)
                    {
                        long petinfoid = petsenemy[i + teamid * 5];
                        RolePetInfo rolePetInfo = petComponent_enemy.GetPetInfo(petinfoid);
                        if (rolePetInfo == null)
                        {
                            continue;
                        }
                        if (unit.GetParent<UnitComponent>().Get(rolePetInfo.Id) != null)
                        {
                            Log.Debug($"宠物ID重复：{unit.Id}");
                            continue;
                        }

                        int position = petComponent_enemy.PetMingPosition.IndexOf(petinfoid);
                        position = position != -1 ? position %= 9 : i;
                        petComponent_enemy.UpdatePetAttributeWithData( d2GGetUnit_2.Component as BagComponent, d2GGetUnit_3.Component as NumericComponent, rolePetInfo, false);
                        Unit petunit = UnitFactory.CreateTianTiPet(unit.DomainScene(), 0,
                           CampEnum.CampPlayer_2, rolePetInfo, AIHelp.Formation_2[position], 180f,position);
                    }
                }

            }
        }
    }
}
