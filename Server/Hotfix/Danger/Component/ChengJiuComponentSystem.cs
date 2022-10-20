using System.Collections.Generic;

namespace ET
{

    [ObjectSystem]
    public class ChengJiuComponentAwakeSystem : AwakeSystem<ChengJiuComponent>
    {
        public override void Awake(ChengJiuComponent self)
        {
            self.TriggerEvent(ChengJiuTargetEnum.PlayerLevel, 0, self.GetParent<Unit>().GetComponent<UserInfoComponent>().UserInfo.Lv);
        }
    }

    public static class ChengJiuComponentSystem
    {
        //击杀怪物可触发多种类型的成就
        public static void OnKillUnit(this ChengJiuComponent self, Unit bekill)
        {
            if (bekill == null || bekill.IsDisposed)
                return;

            UnitInfoComponent unitInfoComponent = bekill.GetComponent<UnitInfoComponent>();
            if (!unitInfoComponent.IsMonster())
                return;

            int unitconfigId = bekill.ConfigId;
            MonsterConfig monsterConfig = MonsterConfigCategory.Instance.Get(unitconfigId);
            bool isBoss = monsterConfig.MonsterType == (int)MonsterTypeEnum.Boss;
            MapComponent mapComponent = self.DomainScene().GetComponent<MapComponent>();
            int fubenDifficulty = (int)FubenDifficulty.None;
            if (mapComponent.SceneTypeEnum == (int)SceneTypeEnum.CellDungeon)
            {
                fubenDifficulty = (int)self.GetParent<Unit>().DomainScene().GetComponent<CellDungeonComponent>().FubenDifficulty;
            }

            self.TriggerEvent(ChengJiuTargetEnum.KillIDMonster_1, unitconfigId, 1);
            self.TriggerEvent(ChengJiuTargetEnum.KillTotalMonster_2, 0, 1);

            if (isBoss)
            {
                self.TriggerEvent(ChengJiuTargetEnum.KillTotalBoss_3, 0, 1);
                self.TriggerEvent(ChengJiuTargetEnum.KillNormalBoss_4, 0, 1);
            }
            if (fubenDifficulty >= (int)FubenDifficulty.TiaoZhan && isBoss) //挑战
            {
                self.TriggerEvent(ChengJiuTargetEnum.KillChallengeBoss_5, 0, 1);
            }
            if (fubenDifficulty == (int)FubenDifficulty.DiYu && isBoss) //地狱
            {
                self.TriggerEvent(ChengJiuTargetEnum.KillInfernalBoss_6, 0, 1);
            }
        }

        public static void OnPassFuben(this ChengJiuComponent self, int difficulty, int chapterid, int star)
        {
            self.TriggerEvent(ChengJiuTargetEnum.PassNormalFubenID_11, chapterid, 1);
            if ((int)difficulty >= (int)FubenDifficulty.TiaoZhan)  //挑战
            {
                self.TriggerEvent(ChengJiuTargetEnum.PassChallengeFubenID_12, chapterid, 1);
            }
            if ((int)difficulty == (int)FubenDifficulty.DiYu)  //地狱
            {
                self.TriggerEvent(ChengJiuTargetEnum.PassInfernalFubenID_13, chapterid, 1);
            }
            if (star == 3 && (int)difficulty == (int)FubenDifficulty.DiYu)
            {
                self.TriggerEvent(ChengJiuTargetEnum.PerfectPassInfernalFubenID_14, chapterid, 1);
            }
        }

        public static void OnChouKaTen(this ChengJiuComponent self)
        {
            self.TriggerEvent(ChengJiuTargetEnum.TotalChouKaTen, 0, 1);
        }

        public static void OnEquipXiLian(this ChengJiuComponent self, int times)
        {
            self.TriggerEvent(ChengJiuTargetEnum.TotalEquipXiLian, 0, times);
        }

        public static void OnRevive(this ChengJiuComponent self)
        {
            self.TriggerEvent(ChengJiuTargetEnum.TotalRevive, 0, 1);
        }

        public static void OnUpdateLevel(this ChengJiuComponent self, int lv)
        {
            self.TriggerEvent(ChengJiuTargetEnum.PlayerLevel, 0, lv);
        }

        public static void OnGetGold(this ChengJiuComponent self, int coin)
        {
            if (coin < 0)
                return;
            self.TriggerEvent(ChengJiuTargetEnum.TotalCoin_201,0, coin);
        }

        public static void OnGetPet(this ChengJiuComponent self, RolePetInfo rolePetInfo)
        {
            self.TriggerEvent(ChengJiuTargetEnum.PetIdNumber, rolePetInfo.ConfigId, 1);
            self.TriggerEvent(ChengJiuTargetEnum.TotalPetNumber, 0, 1);
            self.TriggerEvent(ChengJiuTargetEnum.PetNSkill, rolePetInfo.PetSkill.Count, 1);
        }

        public static void OnPetHeCheng(this ChengJiuComponent self, RolePetInfo rolePetInfo)
        {
            self.TriggerEvent(ChengJiuTargetEnum.TotalPetHeCheng, 0, 1);
            self.TriggerEvent(ChengJiuTargetEnum.PetNSkill, rolePetInfo.PetSkill.Count, 1);
        }

        public static void OnPetXiLian(this ChengJiuComponent self, RolePetInfo rolePetInfo)
        {
            self.TriggerEvent(ChengJiuTargetEnum.TotalPetXiLian, 0, 1);
            self.TriggerEvent(ChengJiuTargetEnum.PetNSkill, rolePetInfo.PetSkill.Count, 1);
        }

        public static int ReceivedReward(this ChengJiuComponent self, int rewardId)
        {
            if (self.AlreadReceivedId.Contains(rewardId))
            {
                return ErrorCore.ERR_Success;
            }

            ChengJiuRewardConfig chengJiuRewardConfig = ChengJiuRewardConfigCategory.Instance.Get(rewardId);
            bool success = self.GetParent<Unit>().GetComponent<BagComponent>().OnAddItemData(chengJiuRewardConfig.RewardItems, $"{ItemGetWay.ChengJiuRward}_{TimeHelper.ServerNow()}");
            if (success)
            {
                self.AlreadReceivedId.Add(rewardId);
                return ErrorCore.ERR_Success;
            }
            else
            {
                return ErrorCore.ERR_BagIsFull;
            }
        }

        public static void TriggerEvent(this ChengJiuComponent self, ChengJiuTargetEnum chengJiuTarget, int target_id, int target_value=1)
        {
            int chengJiuTargetInt = (int)chengJiuTarget;
            List<int> chengjiuList = null;
            ChengJiuHelper.Instance.ChengJiuTargetData.TryGetValue(chengJiuTargetInt, out chengjiuList);
            if (chengjiuList == null)
                return;

            for (int i = 0;i < chengjiuList.Count;i ++)
            {
                bool exist = false;
                for (int k = 0; k < self.ChengJiuProgessList.Count; k++ )
                {
                    if (self.ChengJiuProgessList[k].ChengJiuID == chengjiuList[i])
                    {
                        exist = true;
                    }
                    if (exist)
                    {
                        break;
                    }
                }
                if (exist)
                {
                    continue;
                }
                exist = self.ChengJiuCompleteList.Contains(chengjiuList[i]);
                if (!exist)
                {
                    self.ChengJiuProgessList.Add(new ChengJiuInfo() { ChengJiuID = chengjiuList[i] });
                }
            }

            for (int i = self.ChengJiuProgessList.Count - 1; i >= 0; i--)
            {
                ChengJiuInfo chengJiuInfo = self.ChengJiuProgessList[i];
                ChengJiuConfig chengJiuConfig = ChengJiuConfigCategory.Instance.Get(chengJiuInfo.ChengJiuID);
                if (chengJiuTargetInt != chengJiuConfig.TargetType)
                {
                    continue;
                }
                if (target_id != chengJiuConfig.TargetID)
                {
                    continue;
                }
                if (chengJiuTarget == ChengJiuTargetEnum.PlayerLevel)
                {
                    chengJiuInfo.ChengJiuProgess = target_value;
                }
                else
                {
                    chengJiuInfo.ChengJiuProgess += target_value;
                }
                if (chengJiuInfo.ChengJiuProgess >= chengJiuConfig.TargetValue)
                {
                    self.TotalChengJiuPoint += chengJiuConfig.RewardNum;
                    self.ChengJiuCompleteList.Add(chengJiuInfo.ChengJiuID);
                    self.ChengJiuProgessList.RemoveAt(i);
                }
            }
        }
    }
}
