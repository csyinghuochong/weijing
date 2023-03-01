using System.Collections.Generic;

namespace ET
{

    [ObjectSystem]
    public class ChengJiuComponentAwakeSystem : AwakeSystem<ChengJiuComponent>
    {
        public override void Awake(ChengJiuComponent self)
        {
            self.TriggerEvent(ChengJiuTargetEnum.PlayerLevel_205, 0, self.GetParent<Unit>().GetComponent<UserInfoComponent>().UserInfo.Lv);
        }
    }

    public static class ChengJiuComponentSystem
    {
        //击杀怪物可触发多种类型的成就
        public static void OnKillUnit(this ChengJiuComponent self, Unit defend)
        {
            if (defend == null || defend.IsDisposed)
                return;

            if (defend.Type == UnitType.Player)
            {
                self.TriggerEvent(ChengJiuTargetEnum.KillPlayerNumber_209, 0, 1);
                LogHelper.KillPlayerInfo(self.GetParent<Unit>(),  defend);
            }
            if (defend.Type == UnitType.Monster)
            {
                int unitconfigId = defend.ConfigId;
                MonsterConfig monsterConfig = MonsterConfigCategory.Instance.Get(unitconfigId);
                bool isBoss = monsterConfig.MonsterType == (int)MonsterTypeEnum.Boss;
                MapComponent mapComponent = self.DomainScene().GetComponent<MapComponent>();
                int fubenDifficulty = (int)FubenDifficulty.None;
                if (mapComponent.SceneTypeEnum == (int)SceneTypeEnum.CellDungeon)
                {
                    fubenDifficulty = (int)self.GetParent<Unit>().DomainScene().GetComponent<CellDungeonComponent>().FubenDifficulty;
                }
                if (mapComponent.SceneTypeEnum == (int)SceneTypeEnum.LocalDungeon)
                {
                    fubenDifficulty = (int)self.GetParent<Unit>().DomainScene().GetComponent<LocalDungeonComponent>().FubenDifficulty;
                }

                self.TriggerEvent(ChengJiuTargetEnum.KillIDMonster_1, unitconfigId, 1);
                self.TriggerEvent(ChengJiuTargetEnum.KillTotalMonster_2, 0, 1);

                if (isBoss)
                {
                    self.TriggerEvent(ChengJiuTargetEnum.KillTotalBoss_3, 0, 1);
                    self.TriggerEvent(ChengJiuTargetEnum.KillNormalBoss_4, unitconfigId, 1);
                }
                if (fubenDifficulty >= (int)FubenDifficulty.TiaoZhan && isBoss) //挑战
                {
                    self.TriggerEvent(ChengJiuTargetEnum.KillChallengeBoss_5, unitconfigId, 1);
                }
                if (fubenDifficulty == (int)FubenDifficulty.DiYu && isBoss) //地狱
                {
                    self.TriggerEvent(ChengJiuTargetEnum.KillInfernalBoss_6, unitconfigId, 1);
                }
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
            self.TriggerEvent(ChengJiuTargetEnum.TotalChouKaTen_202, 0, 1);
        }

        public static void OnEquipXiLian(this ChengJiuComponent self, int times)
        {
            self.TriggerEvent(ChengJiuTargetEnum.TotalEquipXiLian_203, 0, times);
        }

        public static void OnRevive(this ChengJiuComponent self)
        {
            self.TriggerEvent(ChengJiuTargetEnum.TotalRevive_204, 0, 1);
        }

        public static void OnUpdateLevel(this ChengJiuComponent self, int lv)
        {
            self.TriggerEvent(ChengJiuTargetEnum.PlayerLevel_205, 0, lv);
        }

        public static void OnGetGold(this ChengJiuComponent self, int coin)
        {
            if (coin < 0)
            {
                self.TriggerEvent(ChengJiuTargetEnum.TotalCostGold_219, 0, coin * -1);
            }
            else
            {
                self.TriggerEvent(ChengJiuTargetEnum.TotalCoinGet_201, 0, coin);
            }
        }

        public static void OnGetPet(this ChengJiuComponent self, RolePetInfo rolePetInfo)
        {
            self.TriggerEvent(ChengJiuTargetEnum.PetIdNumber_301, rolePetInfo.ConfigId, 1);
            self.TriggerEvent(ChengJiuTargetEnum.TotalPetNumber_302, 0, 1);
            self.TriggerEvent(ChengJiuTargetEnum.PetNSkill_305, 0, rolePetInfo.PetSkill.Count);
        }

        public static void OnPetHeCheng(this ChengJiuComponent self, RolePetInfo rolePetInfo)
        {
            self.TriggerEvent(ChengJiuTargetEnum.TotalPetHeCheng_303, 0, 1);
            self.TriggerEvent(ChengJiuTargetEnum.PetNSkill_305, rolePetInfo.PetSkill.Count, 1);
        }

        public static void OnPetXiLian(this ChengJiuComponent self, RolePetInfo rolePetInfo)
        {
            self.TriggerEvent(ChengJiuTargetEnum.TotalPetXiLian_304, 0, 1);
            self.TriggerEvent(ChengJiuTargetEnum.PetNSkill_305, rolePetInfo.PetSkill.Count, 1);
        }

        public static void OnItemHuiShow(this ChengJiuComponent self, int itemNumber)
        {
            self.TriggerEvent(ChengJiuTargetEnum.TotalEquipHuiShou_206, 0, itemNumber);
        }

        public static void OnCostDiamond(this ChengJiuComponent self, long costNumber)
        {
            self.TriggerEvent(ChengJiuTargetEnum.TotalDiamondCost_207, 0, (int)(costNumber * -1));
        }

        public static void OnSkillShuLianDu(this ChengJiuComponent self, int shuLianDu)
        {
            self.TriggerEvent(ChengJiuTargetEnum.SkillShuLianDu_208, 0, shuLianDu);
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
            {
                return;
            }

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
                if (exist || self.ChengJiuCompleteList.Contains(chengjiuList[i]))
                {
                    break;
                }

                self.ChengJiuProgessList.Add(new ChengJiuInfo() { ChengJiuID = chengjiuList[i] });
            }

            for (int i = self.ChengJiuProgessList.Count - 1; i >= 0; i--)
            {
                ChengJiuInfo chengJiuInfo = self.ChengJiuProgessList[i];
                ChengJiuConfig chengJiuConfig = ChengJiuConfigCategory.Instance.Get(chengJiuInfo.ChengJiuID);
                if (chengJiuTargetInt != chengJiuConfig.TargetType)
                {
                    continue;
                }
                
                switch (chengJiuTarget)
                {
                    case ChengJiuTargetEnum.PlayerLevel_205:
                    case ChengJiuTargetEnum.SkillShuLianDu_208:
                    case ChengJiuTargetEnum.CombatToValue_211:
                    case ChengJiuTargetEnum.ZodiacEquipNumber_215:
                    case ChengJiuTargetEnum.PetNSkill_305:
                    case ChengJiuTargetEnum.PegScoreToValue_307:
                    case ChengJiuTargetEnum.PetArrayScoreToValue_308:
                    case ChengJiuTargetEnum.PetTianTiRank_309:
                    case ChengJiuTargetEnum.ZiZhiToValue_311:
                    case ChengJiuTargetEnum.ZiZhiUpValue_312:
                        if (target_id != chengJiuConfig.TargetID)
                        {
                            continue;
                        }
                        chengJiuInfo.ChengJiuProgess = target_value;
                        break;
                    case ChengJiuTargetEnum.JianDingEqipNumber_212:
                        if (target_id < chengJiuConfig.TargetID)
                        {
                            continue;
                        }
                        chengJiuInfo.ChengJiuProgess += target_value;
                        break;
                    default:
                        if (target_id != chengJiuConfig.TargetID)
                        {
                            continue;
                        }
                        chengJiuInfo.ChengJiuProgess += target_value;
                        break;
                }

                int acitiveId = 0;
                switch (chengJiuTarget)
                {
                    case ChengJiuTargetEnum.PetTianTiRank_309:
                        if (chengJiuInfo.ChengJiuProgess <= chengJiuConfig.TargetValue)
                        {
                            acitiveId = chengJiuInfo.ChengJiuID;
                            self.TotalChengJiuPoint += chengJiuConfig.RewardNum;
                            self.ChengJiuCompleteList.Add(chengJiuInfo.ChengJiuID);
                            self.ChengJiuProgessList.RemoveAt(i);
                        }
                        break;
                    case ChengJiuTargetEnum.ZiZhiUpValue_312:
                        if (chengJiuInfo.ChengJiuProgess > chengJiuConfig.TargetValue)
                        {
                            acitiveId = chengJiuInfo.ChengJiuID;
                            self.TotalChengJiuPoint += chengJiuConfig.RewardNum;
                            self.ChengJiuCompleteList.Add(chengJiuInfo.ChengJiuID);
                            self.ChengJiuProgessList.RemoveAt(i);
                        }
                        break;
                    default:
                        if (chengJiuInfo.ChengJiuProgess >= chengJiuConfig.TargetValue)
                        {
                            acitiveId = chengJiuInfo.ChengJiuID;
                            self.TotalChengJiuPoint += chengJiuConfig.RewardNum;
                            self.ChengJiuCompleteList.Add(chengJiuInfo.ChengJiuID);
                            self.ChengJiuProgessList.RemoveAt(i);
                        }
                        break;
                }

                if (acitiveId > 0 && !self.GetParent<Unit>().IsRobot())
                {
                    MessageHelper.SendToClient(self.GetParent<Unit>(), new M2C_ChengJiuActiveMessage() { ChengJiuId = acitiveId });
                }
            }
        }
    }
}
