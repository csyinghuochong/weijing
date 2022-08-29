using System;

namespace ET
{

    public static class PetTianTiComponentSystem
    {

        public static void OnKillEvent(this PetTianTiComponent self)
        {
            int result = self.GetCombatResult();
            if (result == 0)
            {
                return;
            }

            if (result == 1)
            {
                self.NoticeRankServer().Coroutine();
            }

            M2C_PetRankSettlement m2C_FubenSettlement = new M2C_PetRankSettlement();
            m2C_FubenSettlement.BattleResult = result;
            MessageHelper.SendToClient(self.GetPlayerUnit(), m2C_FubenSettlement);
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

            Unit unit = self.GetPlayerUnit();
            RankPetInfo rankPetInfo = new RankPetInfo();
            UserInfoComponent userInfoComponent = unit.GetComponent<UserInfoComponent>();
            rankPetInfo.UserId = userInfoComponent.UserInfo.UserId;
            rankPetInfo.PlayerName = userInfoComponent.UserInfo.Name;
            rankPetInfo.PetUId = unit.GetComponent<PetComponent>().TeamPetList;
            for (int i = 0; i < rankPetInfo.PetUId.Count; i++ )
            {
                RolePetInfo rolePetInfo = unit.GetComponent<PetComponent>().GetPetInfo(rankPetInfo.PetUId[i]);
                rankPetInfo.PetConfigId.Add(rolePetInfo!=null ? rolePetInfo.ConfigId :0);
            }
            R2M_PetRankUpdateResponse m2m_TrasferUnitResponse = (R2M_PetRankUpdateResponse)await ActorMessageSenderComponent.Instance.Call
                     (mapInstanceId, new M2R_PetRankUpdateRequest() {  RankPetInfo = rankPetInfo, EnemyId = self.DomainScene().GetComponent<PetTianTiComponent>().EnemyId });
        }

        public static Unit GetPlayerUnit(this PetTianTiComponent self)
        {
            foreach ((long id, Entity value) in self.DomainScene().GetComponent<UnitComponent>().Children)
            {
                UnitInfoComponent unitInfoComponent = value.GetComponent<UnitInfoComponent>();
                if (unitInfoComponent.Type == UnitType.Player )
                {
                    return value as Unit;
                }
            }
            return null;
        }

        public static int GetCombatResult(this PetTianTiComponent self)
        {
            int number_1 = 0;
            int number_2 = 0;
            foreach ((long id, Entity value) in self.DomainScene().GetParent<UnitComponent>().Children)
            {
                UnitInfoComponent unitInfoComponent = value.GetComponent<UnitInfoComponent>();
                if (!unitInfoComponent.IsPet() || !unitInfoComponent.IsCanBeAttack())
                {
                    continue;
                }
                if (unitInfoComponent.RoleCamp == 1)
                {
                    number_1++;
                }
                else
                {
                    number_2++;
                }
            }
            if (number_1 > 0 && number_2 > 0)
                return 0;
            if (number_1 > 0 && number_2 == 0)
                return 1;
            return 2;
        }

    }
}
