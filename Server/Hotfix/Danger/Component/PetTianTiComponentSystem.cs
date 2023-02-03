using System;
using System.Collections.Generic;

namespace ET
{

    [ObjectSystem]
    public class PetTianTiComponentDestroySystem : DestroySystem<PetTianTiComponent>
    {
        public override void Destroy(PetTianTiComponent self)
        {
            TimerComponent.Instance.Remove(ref self.Timer);
        }
    }

    public static class PetTianTiComponentSystem
    {
        public static  async ETTask GeneratePetFuben(this PetTianTiComponent self)
        {
            Unit unit = self.MainUnit;
            unit.GetComponent<StateComponent>().StateTypeAdd(StateTypeEnum.WuDi);

            PetComponent petComponent = self.MainUnit.GetComponent<PetComponent>();
            for (int i = 0; i < petComponent.TeamPetList.Count; i++)
            {
                RolePetInfo rolePetInfo = petComponent.GetPetInfo(petComponent.TeamPetList[i]);
                if (rolePetInfo == null)
                {
                    continue;
                }
                Unit petunit = UnitFactory.CreateTianTiPet(unit.DomainScene(), unit.Id,
                   unit.GetBattleCamp(), rolePetInfo, AIHelp.Formation_1[i]);
                petunit.GetComponent<AIComponent>().StopAI = true;
            }

            //先查找真实玩家。再查找
            long dbCacheId = DBHelper.GetDbCacheId(self.DomainZone());
            D2G_GetComponent d2GGetUnit = (D2G_GetComponent)await ActorMessageSenderComponent.Instance.Call(dbCacheId, new G2D_GetComponent() { UnitId = self.EnemyId, Component = DBHelper.PetComponent });
            if (d2GGetUnit.Component != null)
            {
                PetComponent petComponent_enemy =  d2GGetUnit.Component as PetComponent;
                for (int i = 0; i < petComponent_enemy.TeamPetList.Count; i++)
                {
                    RolePetInfo rolePetInfo = petComponent_enemy.GetPetInfo(petComponent_enemy.TeamPetList[i]);
                    if (rolePetInfo == null)
                    {
                        continue;
                    }
                    Unit petunit = UnitFactory.CreateTianTiPet(unit.DomainScene(), 0,
                       CampEnum.CampPlayer_2, rolePetInfo, AIHelp.Formation_2[i]);
                    petunit.GetComponent<AIComponent>().StopAI = true;
                }
            }
            else
            {
                List<int> petlist = new List<int>() { 1000101, 1000201, 1000301 };
                for (int k = 0; k < petlist.Count; k++)
                {
                    RolePetInfo petInfo = petComponent.GenerateNewPet(petlist[0], 0);
                    petComponent.PetXiLian(petInfo, 1);
                    petComponent.UpdatePetAttribute(petInfo, false);
                    Unit petunit = UnitFactory.CreateTianTiPet(unit.DomainScene(), 0,
                       CampEnum.CampPlayer_2,  petInfo, AIHelp.Formation_2[k]);
                    petunit.GetComponent<AIComponent>().StopAI = true;
                }
            }
        }

        public static void OnKillEvent(this PetTianTiComponent self)
        {
            int result = self.GetCombatResult();
            if (result != CombatResultEnum.None)
            {
                self.OnGameOver(result);
            }
        }

        public static void OnGameOver(this PetTianTiComponent self, int result)
        {
            List<Unit> units = self.DomainScene().GetComponent<UnitComponent>().GetAll();
            for (int i = 0; i < units.Count; i++)
            {
                AIComponent aIComponent = units[i].GetComponent<AIComponent>();
                aIComponent?.Stop();
            }

            if (result == CombatResultEnum.Win)
            {
                self.NoticeRankServer().Coroutine();
            }

            M2C_FubenSettlement m2C_FubenSettlement = new M2C_FubenSettlement();
            m2C_FubenSettlement.BattleResult = result;
            if (result == CombatResultEnum.Win)
            {
                GlobalValueConfig globalValueConfig = GlobalValueConfigCategory.Instance.Get(68);
                int dropId = int.Parse(globalValueConfig.Value);
                List<RewardItem> rewardItems = new List<RewardItem>();
                DropHelper.DropIDToDropItem(dropId, rewardItems);
                m2C_FubenSettlement.ReardList.AddRange(rewardItems);
                m2C_FubenSettlement.StarInfos = new List<int> { 1, 1, 1 };

                self.MainUnit.GetComponent<BagComponent>().OnAddItemData(rewardItems, string.Empty, $"{ItemGetWay.PetFubenReward}_{TimeHelper.ServerNow()}");
            }
            else
            {
                m2C_FubenSettlement.StarInfos = new List<int> { 0,0,0 };
            }
            MessageHelper.SendToClient(self.MainUnit, m2C_FubenSettlement);
        }

        /// <summary>
        /// 失败不通知
        /// </summary>
        /// <param name="self"></param>
        /// <param name=""></param>
        /// <returns></returns>
        public static async ETTask NoticeRankServer(this PetTianTiComponent self)
        {
            //获取传送map的 actorId
            long mapInstanceId = StartSceneConfigCategory.Instance.GetBySceneName(self.DomainZone(), Enum.GetName(SceneType.Rank)).InstanceId;

            Unit unit = self.MainUnit;
            RankPetInfo rankPetInfo = new RankPetInfo();
            UserInfoComponent userInfoComponent = unit.GetComponent<UserInfoComponent>();
            rankPetInfo.UserId = userInfoComponent.UserInfo.UserId;
            rankPetInfo.PlayerName = userInfoComponent.UserInfo.Name;
            rankPetInfo.PetUId = unit.GetComponent<PetComponent>().TeamPetList;
            rankPetInfo.TeamName = rankPetInfo.PlayerName;
            for (int i = 0; i < rankPetInfo.PetUId.Count; i++ )
            {
                RolePetInfo rolePetInfo = unit.GetComponent<PetComponent>().GetPetInfo(rankPetInfo.PetUId[i]);
                rankPetInfo.PetConfigId.Add(rolePetInfo!=null ? rolePetInfo.ConfigId :0);
            }
            R2M_PetRankUpdateResponse m2m_TrasferUnitResponse = (R2M_PetRankUpdateResponse)await ActorMessageSenderComponent.Instance.Call
                     (mapInstanceId, new M2R_PetRankUpdateRequest() {  RankPetInfo = rankPetInfo, EnemyId = self.DomainScene().GetComponent<PetTianTiComponent>().EnemyId });
        }
        
        /// <summary>
        /// 1 成功 2失败
        /// </summary>
        /// <param name="self"></param>
        /// <returns></returns>
        public static int GetCombatResult(this PetTianTiComponent self)
        {
            int number_self = 0;
            int number_enemy = 0;
            List<Unit> unitList = self.DomainScene().GetComponent<UnitComponent>().GetAll();
            for(int i = 0; i < unitList.Count; i++)
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

    }
}
