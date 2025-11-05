using System;
using System.Linq;
using System.Collections.Generic;

namespace ET
{

    public class DataUpdateHelp : Singleton<DataUpdateHelp>
    {
        public delegate void DataUpdatelegate(Dictionary<long, Entity> dataUpdateComponentDic,  string DataParams, long upateValue);
        public Dictionary<int, DataUpdatelegate> DataUpdatelegateDics;

        protected override void InternalInit()
        {
            base.InternalInit();

            DataUpdatelegateDics = new Dictionary<int, DataUpdatelegate>
            {
                { DataType.SkillSetting, OnSkillSetting },
                { DataType.SkillReset, OnSkillReset },
                { DataType.SkillUpgrade, OnSkillUpgrade },
                { DataType.SkillGet, OnSkillGet},
                { DataType.EquipWear, OnEquipWear },
                { DataType.HuiShouSelect, OnHuiShouSelect },
                { DataType.TaskTrace, OnRecvTaskTrace },
                { DataType.TaskGet, OnGetTask },
                { DataType.TaskGiveUp, OnTaskGiveUp },
                { DataType.TaskComplete, OnCompleteTask },
                { DataType.TaskUpdate, OnUpdateTask },
                { DataType.OnRecvChat, OnChatRecv },
                { DataType.HorseNotice, OnHorseNotice },
                { DataType.UpdateUserData, OnUpdateUserData },
                { DataType.UpdateUserDataExp, OnUpdateUserDataExp },
                { DataType.UpdateUserDataPiLao, OnUpdateUserDataPiLao },
                { DataType.UpdateUserBuffSkill, OnUpdateUserBuffSkill },
                { DataType.OnSkillUse, OnSkillUse },
                { DataType.UpdateRoleProper, OnUpdateRoleProper },
                { DataType.BagItemUpdate, OnBagItemUpdate },
                { DataType.OnMailUpdate, OnMailUpdate },
                { DataType.OnPetFightSet, OnPetFightSet },
                { DataType.OnActiveTianFu, OnActiveTianFu },
                { DataType.ChengJiuUpdate, OnChengJiuUpdate },
                { DataType.PetItemSelect, OnPetItemSelect },
                { DataType.PetUpStarUpdate, OnPetUpStarUpdate },
                { DataType.SettingUpdate, OnSettingUpdate },
                { DataType.PetFenJieUpdate, OnPetFenJieUpdate },
                { DataType.EquipHuiShow, OnEquipHuiShow },
                { DataType.BagItemAdd, OnBagItemAdd },
                { DataType.TeamUpdate, OnTeamUpdate },
                { DataType.FriendUpdate, OnFriendUpdate },
                { DataType.FriendChat, OnFriendChat },
                { DataType.PetXiLianUpdate, OnPetXiLianUpdate },
                { DataType.PetHeChengUpdate, OnHeChengReturn },
                { DataType.MainHeroMove, OnMainHeroMove },
                { DataType.SkillCDUpdate, OnSkillCDUpdate },
                { DataType.SkillBeging, OnSkillBeging },
                { DataType.SkillFinish, OnSkillFinish },
                { DataType.JingLingButton, OnJingLingButton },
                { DataType.BuyBagCell, OnBuyBagCell },
                { DataType.BeforeMove, OnBeforeMove },
                { DataType.UpdateSing, OnUpdateSing },
                { DataType.AccountWarehous, OnAccountWarehous },
                { DataType.ChouKaWarehouseAddItem, OnChouKaWarehouseAddItem},
                { DataType.LanguageUpdate, OnLanguageUpdate},
                { DataType.TaskCountryComplete, OnTaskCountryComplete },
                { DataType.UpdateTimerChouKa, OnUpdateTimerChouKa },
                { DataType.OnUseSealWeapon, OnOnUseSealWeapon },
            };
        }

        public void OnChouKaWarehouseAddItem(Dictionary<long, Entity> dataUpdateComponentDic, string DataParams, long upateValue)
        {
            foreach (var component in dataUpdateComponentDic.Values)
            {
                if (component is UIChouKaComponent uiChouKaComponent)
                {
                    uiChouKaComponent.SetRedDot(true);
                    continue;
                }
            }
        }
        
        public void OnUpdateSing(Dictionary<long, Entity> dataUpdateComponentDic, string DataParams, long upateValue)
        {
            foreach (var component in dataUpdateComponentDic.Values)
            {
                if (component is UIMainHpBarComponent uiwareComponent)
                {
                    uiwareComponent.OnUpdateSing(DataParams);
                    continue;
                }
            }
        }

        public void OnBeforeMove(Dictionary<long, Entity> dataUpdateComponentDic, string DataParams, long upateValue)
        {
            foreach (var component in dataUpdateComponentDic.Values)
            {
                if (component is UIMainComponent uiComponent)
                {
                    uiComponent.OnMoveStart(DataParams);
                    continue;
                }
                if (component is UIJiaYuanMainComponent uiwareComponent)
                {
                    uiwareComponent.OnSelectCancel();
                    continue;
                }
            }
        }

        public void OnAccountWarehous(Dictionary<long, Entity> dataUpdateComponentDic, string DataParams, long upateValue)
        {
            foreach (var component in dataUpdateComponentDic.Values)
            {
                if (component is UIWarehouseAccountComponent uiwareComponent)
                {
                    uiwareComponent.OnAccountWarehous(DataParams, upateValue);
                    continue;
                }
            }
        }

        public void OnBuyBagCell(Dictionary<long, Entity> dataUpdateComponentDic, string DataParams, long upateValue)
        {
            foreach (var component in dataUpdateComponentDic.Values)
            {
                if (component is UIRoleComponent uiComponent)
                {
                    uiComponent.OnBuyBagCell();
                    continue;
                }
                if (component is UIWarehouseRoleComponent uiwareComponent)
                {
                    uiwareComponent.OnBuyBagCell(DataParams);
                    continue;
                }
            }
        }

        public void OnJingLingButton(Dictionary<long, Entity> dataUpdateComponentDic, string DataParams, long upateValue)
        {
            foreach (var component in dataUpdateComponentDic.Values)
            {
                if (component is UIMainSkillComponent uiComponent)
                {
                    uiComponent.CheckJingLingFunction();
                    continue;
                }
            }
        }

        public void OnSkillBeging(Dictionary<long, Entity> dataUpdateComponentDic, string DataParams, long upateValue)
        {
            foreach (var component in dataUpdateComponentDic.Values)
            {
                if (component is UIMainSkillComponent uiComponent)
                {
                    uiComponent.OnSkillBeging(DataParams);
                    continue;
                }
            }
        }

        public void OnSkillFinish(Dictionary<long, Entity> dataUpdateComponentDic, string DataParams, long upateValue)
        {
            foreach (var component in dataUpdateComponentDic.Values)
            {
                if (component is UIMainSkillComponent uiComponent)
                {
                    uiComponent.OnSkillFinish(DataParams);
                    continue;
                }
            }
        }

        public void OnSkillCDUpdate(Dictionary<long, Entity> dataUpdateComponentDic, string DataParams, long upateValue)
        {
            foreach (var component in dataUpdateComponentDic.Values)
            {
                if (component is UIMainSkillComponent uiComponent)
                {
                    uiComponent.OnSkillCDUpdate();
                    continue;
                }
            }
        }

        public void OnMainHeroMove(Dictionary<long, Entity> dataUpdateComponentDic, string DataParams, long upateValue)
        {
            foreach (var component in dataUpdateComponentDic.Values)
            {
                if (component is UIMapBigComponent uiComponent)
                {
                    uiComponent.OnMainHeroMove();
                    continue;
                }
                if (component is UIMainComponent mainComponent)
                {
                    mainComponent.OnMainHeroMove();
                    continue;
                }
            }
        }

        public void OnHeChengReturn(Dictionary<long, Entity> dataUpdateComponentDic, string DataParams, long upateValue)
        {
            //宠物合成返回
            foreach (var component in dataUpdateComponentDic.Values)
            {
                if (component is UIPetComponent uiComponent)
                {
                    uiComponent.OnHeChengReturn();
                    continue;
                }
            }
            return;
        }

        public void OnPetXiLianUpdate(Dictionary<long, Entity> dataUpdateComponentDic, string DataParams, long upateValue)
        { 
            //宠物洗练返回
            foreach (var component in dataUpdateComponentDic.Values)
            {
                if (component is UIPetComponent uiComponent)
                {
                    uiComponent.OnXiLianUpdate();
                    continue;
                }
            }
            return;
        }

        public void OnFriendChat(Dictionary<long, Entity> dataUpdateComponentDic, string DataParams, long upateValue)
        {
            foreach (var component in dataUpdateComponentDic.Values)
            {
                if (component is UIFriendListComponent uiFriendComponent)
                {
                    uiFriendComponent.OnFriendChat();
                    continue;
                }
            }
        }

        public void OnFriendUpdate(Dictionary<long, Entity> dataUpdateComponentDic, string DataParams, long upateValue)
        {
            foreach (var component in dataUpdateComponentDic.Values)
            {
                if (component is UIFriendComponent uiFriendComponent)
                {
                    uiFriendComponent.OnFriendUpdate();
                    continue;
                }
            }
        }

        public void OnTeamUpdate(Dictionary<long, Entity> dataUpdateComponentDic, string DataParams, long upateValue)
        {
            foreach (var component in dataUpdateComponentDic.Values)
            {
                if (component is UIMainComponent uiComponent)
                {
                    uiComponent.OnTeamUpdate();
                    continue;
                }
                if (component is UITeamComponent uiTeamComponent)
                {
                    uiTeamComponent.OnTeamUpdate();
                    continue;
                }
                if (component is UITeamDungeonComponent uiDungeonComponent)
                {
                    uiDungeonComponent.OnTeamUpdate();
                    continue;
                }
            }

        }

        public void OnBagItemAdd(Dictionary<long, Entity> dataUpdateComponentDic, string DataParams, long upateValue)
        {
            foreach (var component in dataUpdateComponentDic.Values)
            {
                if (component is UIMainComponent uiComponent)
                {
                    uiComponent.OnBagItemAdd(DataParams);
                    continue;
                }
            }
        }

        public void OnEquipHuiShow(Dictionary<long, Entity> dataUpdateComponentDic, string DataParams, long upateValue)
        {
            foreach (var component in dataUpdateComponentDic.Values)
            {
                if (component is UIRoleComponent uiComponent)
                {
                    uiComponent.OnEquipHuiShow();
                    continue;
                }
            }
        }

        public void OnPetFenJieUpdate(Dictionary<long, Entity> dataUpdateComponentDic, string DataParams, long upateValue)
        {
            foreach (var component in dataUpdateComponentDic.Values)
            {
                if (component is UIPetComponent uiComponent)
                {
                    uiComponent.OnPetFenJieUpdate();
                    continue;
                }
            }
        }

        public void OnSettingUpdate(Dictionary<long, Entity> dataUpdateComponentDic, string DataParams, long upateValue)
        {
            foreach (var component in dataUpdateComponentDic.Values)
            {
                if (component is UIMainComponent uiComponent)
                {
                    uiComponent.OnSettingUpdate();
                    continue;
                }
            }
        }

        public void OnPetUpStarUpdate(Dictionary<long, Entity> dataUpdateComponentDic, string DataParams, long upateValue)
        {
            foreach (var component in dataUpdateComponentDic.Values)
            {
                if (component is UIPetComponent uiComponent)
                {
                    uiComponent.OnPetUpStarUpdate(DataParams);
                    continue;
                }
            }
            return;
        }

        public void OnPetItemSelect(Dictionary<long, Entity> dataUpdateComponentDic, string DataParams, long upateValue)
        {
            foreach (var component in dataUpdateComponentDic.Values)
            {
                if (component is UIPetComponent uiComponent)
                {
                    uiComponent.PetItemSelect(DataParams);
                    continue;
                }
                if (component is UIPetXianjiComponent uixianjiComponent)
                {
                    uixianjiComponent.PetItemSelect(DataParams);
                    continue;
                }
                if (component is UIJiaYuanPetWalkComponent uipetwalkComponent)
                {
                    uipetwalkComponent.PetItemSelect(DataParams).Coroutine();
                    continue;
                }
            }
            return;
        }

        public void OnChengJiuUpdate(Dictionary<long, Entity> dataUpdateComponentDic, string DataParams, long upateValue)
        {
            foreach (var component in dataUpdateComponentDic.Values)
            {
                if (component is UIChengJiuComponent uiSkillComponent)
                {
                    uiSkillComponent.OnChengJiuUpdate();
                    continue;
                }
            }
        }

        public void OnActiveTianFu(Dictionary<long, Entity> dataUpdateComponentDic, string DataParams, long upateValue)
        {
            foreach (var component in dataUpdateComponentDic.Values)
            {
                if (component is UISkillComponent uiSkillComponent)
                {
                    uiSkillComponent.OnActiveTianFu();
                    continue;
                }
                if (component is UIMainComponent uIMainComponent)
                {
                    uIMainComponent.OnSkillSetUpdate();
                    continue;
                }
            }
        }

        public void OnPetFightSet(Dictionary<long, Entity> dataUpdateComponentDic, string DataParams, long upateValue)
        {
            //宠物出战设置
            foreach (var component in dataUpdateComponentDic.Values)
            {
                if (component is UIPetComponent uiComponent)
                {
                    uiComponent.OnPetFightSet();
                    continue;
                }
                if (component is UIMainComponent uimailComponent)
                {
                    uimailComponent.OnPetFightSet();
                    continue;
                }
            }
            return;
        }

        public void OnMailUpdate(Dictionary<long, Entity> dataUpdateComponentDic, string DataParams, long upateValue)
        {
            foreach (var component in dataUpdateComponentDic.Values)
            {
                if (component is UIMailComponent uimailComponent)
                {
                    uimailComponent.OnMailUpdate();
                    continue;
                }
            }
        }

        public void OnBagItemUpdate(Dictionary<long, Entity> dataUpdateComponentDic, string DataParams, long upateValue)
        {

            foreach (var component in dataUpdateComponentDic.Values)
            {
                if (component is UIRoleComponent uiequipComponent)
                {
                    uiequipComponent.UpdateBagUI();
                    continue;
                }
                if (component is UIWarehouseRoleComponent uihourseComponent)
                {
                    uihourseComponent.UpdateBagUI();
                    continue;
                }
                if (component is UIWarehouseGemComponent uihoursegemComponent)
                {
                    uihoursegemComponent.UpdateBagUI();
                    continue;
                }
                if (component is UIMainComponent uIMainComponent)
                {
                    uIMainComponent.OnBagItemUpdate();
                    continue;
                }
                if (component is UIPetComponent uIPetComponent)
                {
                    uIPetComponent.OnBagItemUpdate();
                    continue;
                }
                if (component is UIJiaYuanBagComponent jiayuanbagComponent)
                {
                    jiayuanbagComponent.OnUpdateUI();
                    continue;
                }
                if (component is UIJiaYuanWarehouseComponent warehouseComponent)
                {
                    warehouseComponent.OnUpdateUI();
                    continue;
                }
                if (component is UIJiaYuanTreasureMapStorageComponent uiJiaYuanTreasureMapStorageComponent)
                {
                    uiJiaYuanTreasureMapStorageComponent.OnUpdateUI();
                    continue;
                }

                if (component is UIEquipmentIncreaseShowComponent uiEquipmentIncreaseShowComponent)
                {
                    uiEquipmentIncreaseShowComponent.OnUpdateUI();
                    continue;
                }

                if (component is UIBattleShopComponent uiBattleShopComponent)
                {
                    uiBattleShopComponent.UpdateItemNum();
                    continue;
                }

                if (component is UITeamDungeonShopComponent uiTeamDungeonShopComponent)
                {
                    uiTeamDungeonShopComponent.OnUpdateUI();
                }

                if (component is UIChouKaWarehouseComponent uiChouKaWarehouseComponent)
                {
                    uiChouKaWarehouseComponent.OnUpdateUI();
                }

                if (component is UIUnionMystery_BComponent uiUnionMysteryBComponent)
                {
                    uiUnionMysteryBComponent.UpdateItemNum();
                }
                
                if (component is UIPetListComponent uiPetListComponent)
                {
                    uiPetListComponent.OnUpdatePetEquipItemList();
                    continue;
                }
            }
        }

        public void OnUpdateUserDataExp(Dictionary<long, Entity> dataUpdateComponentDic, string DataParams, long upateValue)
        {
            foreach (var component in dataUpdateComponentDic.Values)
            {
                if (component is UIMainComponent uimainComponent)
                {
                    uimainComponent.OnUpdateUserDataExp(DataParams, upateValue);
                    continue;
                }
            }
        }
        
        public void OnLanguageUpdate(Dictionary<long, Entity> dataUpdateComponentDic, string DataParams, long upateValue)
        {
            foreach (var component in dataUpdateComponentDic.Values)
            {
                if (component is UIMainComponent uIMainComponent)
                {
                    uIMainComponent.OnLanguageUpdate();
                    continue;
                }
                if (component is UIRoleComponent uiRoleComponent)
                {
                    uiRoleComponent.OnLanguageUpdate();
                    continue;
                }
                if (component is UIRoleBagComponent uiRoleBagComponent)
                {
                    uiRoleBagComponent.OnLanguageUpdate();
                    continue;
                }
                if (component is UIRoleGemComponent uiRoleGemComponent)
                {
                    uiRoleGemComponent.OnLanguageUpdate();
                    continue;
                }
                if (component is UIRolePropertyComponent uiRolePropertyComponent)
                {
                    uiRolePropertyComponent.OnLanguageUpdate();
                    continue;
                }
                if (component is UIProLucklyExplainComponent uiProLucklyExplainComponent)
                {
                    uiProLucklyExplainComponent.OnLanguageUpdate();
                    continue;
                }
                if (component is UIRoleGemHoleComponent uiRoleGemHoleComponent)
                {
                    uiRoleGemHoleComponent.OnLanguageUpdate();
                    continue;
                }
                if (component is UIItemComponent uiItemComponent)
                {
                    uiItemComponent.OnLanguageUpdate();
                    continue;
                }
                if (component is UIRoleHuiShouComponent uiRoleHuiShouComponent)
                {
                    uiRoleHuiShouComponent.OnLanguageUpdate();
                    continue;
                }
                if (component is UICommonRewardComponent uiCommonRewardComponent)
                {
                    uiCommonRewardComponent.OnLanguageUpdate();
                    continue;
                }
                if (component is UIPetComponent uiPetComponent)
                {
                    uiPetComponent.OnLanguageUpdate();
                    continue;
                }
                if (component is UIPetListComponent uiPetListComponent)
                {
                    uiPetListComponent.OnLanguageUpdate();
                    continue;
                }
                if (component is UISkillComponent uiSkillComponent)
                {
                    uiSkillComponent.OnLanguageUpdate();
                    continue;
                }
                if (component is UITaskComponent uiTaskComponent)
                {
                    uiTaskComponent.OnLanguageUpdate();
                    continue;
                }
                if (component is UIFriendComponent uiFriendComponent)
                {
                    uiFriendComponent.OnLanguageUpdate();
                    continue;
                }
                if (component is UIChengJiuComponent uiChengJiuComponent)
                {
                    uiChengJiuComponent.OnLanguageUpdate();
                    continue;
                }
                if (component is UIPetSetComponent uiPetSetComponent)
                {
                    uiPetSetComponent.OnLanguageUpdate();
                    continue;
                }
                if (component is UITeamDungeonComponent uiTeamDungeonComponent)
                {
                    uiTeamDungeonComponent.OnLanguageUpdate();
                    continue;
                }
                if (component is UIDonationComponent uiDonationComponent)
                {
                    uiDonationComponent.OnLanguageUpdate();
                    continue;
                }
                if (component is UIFenXiangComponent uiFenXiangComponent)
                {
                    uiFenXiangComponent.OnLanguageUpdate();
                    continue;
                }
                if (component is UICountryComponent uiCountryComponent)
                {
                    uiCountryComponent.OnLanguageUpdate();
                    continue;
                }
                if (component is UIActivityComponent uiActivityComponent)
                {
                    uiActivityComponent.OnLanguageUpdate();
                    continue;
                }
                if (component is UISeasonComponent uiSeasonComponent)
                {
                    uiSeasonComponent.OnLanguageUpdate();
                    continue;
                }
                if (component is UIZhanQuComponent uiZhanQuComponent)
                {
                    uiZhanQuComponent.OnLanguageUpdate();
                    continue;
                }
                if (component is UINewYearComponent uiNewYearComponent)
                {
                    uiNewYearComponent.OnLanguageUpdate();
                    continue;
                }
                if (component is UIRankComponent uiRankComponent)
                {
                    uiRankComponent.OnLanguageUpdate();
                    continue;
                }
                if (component is UIPetListItemComponent uiPetListItemComponent)
                {
                    uiPetListItemComponent.OnLanguageUpdate();
                    continue;
                }
                if (component is UIPetInfoShowComponent uiPetInfoShowComponent)
                {
                    uiPetInfoShowComponent.OnLanguageUpdate();
                    continue;
                }
                if (component is UIPetChouKaGetComponent uiPetChouKaGetComponent)
                {
                    uiPetChouKaGetComponent.OnLanguageUpdate();
                    continue;
                }
                if (component is UIRolePetBagComponent uiRolePetBagComponent)
                {
                    uiRolePetBagComponent.OnLanguageUpdate();
                    continue;
                }
                if (component is UIWatchPetComponent uiWatchPetComponent)
                {
                    uiWatchPetComponent.OnLanguageUpdate();
                    continue;
                }
                if (component is UIPetTuJianComponent uiPetTuJianComponent)
                {
                    uiPetTuJianComponent.OnLanguageUpdate();
                    continue;
                }
                if (component is UISkillLearnItemComponent uiSkillLearnItemComponent)
                {
                    uiSkillLearnItemComponent.OnLanguageUpdate();
                    continue;
                }
                if (component is UITaskTypeItemComponent uiTaskTypeItemComponent)
                {
                    uiTaskTypeItemComponent.OnLanguageUpdate();
                    continue;
                }
                if (component is UITaskBComponent uiTaskBComponent)
                {
                    uiTaskBComponent.OnLanguageUpdate();
                    continue;
                }
                if (component is UIChengJiuTypeItemComponent uiChengJiuTypeItemComponent)
                {
                    uiChengJiuTypeItemComponent.OnLanguageUpdate();
                    continue;
                }
                if (component is UIChengJiuShowItemComponent uiChengJiuShowItemComponent)
                {
                    uiChengJiuShowItemComponent.OnLanguageUpdate();
                    continue;
                }
                if (component is UIActivitySingleRechargeItemComponent uiActivitySingleRechargeItemComponent)
                {
                    uiActivitySingleRechargeItemComponent.OnLanguageUpdate();
                    continue;
                }
                if (component is UIPaiMaiShopTypeItemComponent uiPaiMaiShopTypeItemComponent)
                {
                    uiPaiMaiShopTypeItemComponent.OnLanguageUpdate();
                    continue;
                } 
                if (component is UITypeButtonItemComponent uiTypeButtonItemComponent)
                {
                    uiTypeButtonItemComponent.OnLanguageUpdate();
                    continue;
                }
                if (component is UIPaiMaiSellComponent uiPaiMaiSellComponent)
                {
                    uiPaiMaiSellComponent.OnLanguageUpdate();
                    continue;
                }
                if (component is UIStallSellComponent uiStallSellComponent)
                {
                    uiStallSellComponent.OnLanguageUpdate();
                    continue;
                }
                if (component is UIDungeonItemComponent uiDungeonItemComponent)
                {
                    uiDungeonItemComponent.OnLanguageUpdate();
                    continue;
                }
                if (component is UISettingGameComponent uiSettingGameComponent)
                {
                    uiSettingGameComponent.OnLanguageUpdate();
                    continue;
                }
                if (component is UISkillMakeComponent uiSkillMakeComponent)
                {
                    uiSkillMakeComponent.OnLanguageUpdate();
                    continue;
                }
                if (component is UIMakeNeedComponent uiMakeNeedComponent)
                {
                    uiMakeNeedComponent.OnLanguageUpdate();
                    continue;
                }
                if (component is UISkillLearnSkillItemComponent uiSkillLearnSkillItemComponent)
                {
                    uiSkillLearnSkillItemComponent.OnLanguageUpdate();
                    continue;
                }
                if (component is UISkillLearnComponent uiSkillLearnComponent)
                {
                    uiSkillLearnComponent.OnLanguageUpdate();
                    continue;
                }
                if (component is UITaskAComponent uiTaskAComponent)
                {
                    uiTaskAComponent.OnLanguageUpdate();
                    continue;
                }
                if (component is UIUnionListComponent uiUnionListComponent)
                {
                    uiUnionListComponent.OnLanguageUpdate();
                    continue;
                }
                if (component is UIUnionListItemComponent uiUnionListItemComponent)
                {
                    uiUnionListItemComponent.OnLanguageUpdate();
                    continue;
                }
                if (component is UIChengJiuRewardComponent uiChengJiuRewardComponent)
                {
                    uiChengJiuRewardComponent.OnLanguageUpdate();
                    continue;
                }
                if (component is UIRoleHeadComponent uiRoleHeadComponent)
                {
                    uiRoleHeadComponent.OnLanguageUpdate();
                    continue;
                }
                if (component is UIMainBuffComponent uiMainBuffComponent)
                {
                    uiMainBuffComponent.OnLanguageUpdate();
                    continue;
                }
                if (component is UIMainTaskComponent uiMainTaskComponent)
                {
                    uiMainTaskComponent.OnLanguageUpdate();
                    continue;
                }
                if (component is UIMapMiniComponent uiMapMiniComponent)
                {
                    uiMapMiniComponent.OnLanguageUpdate();
                    continue;
                }
                if (component is UIPaiMaiBuyItemComponent uiPaiMaiBuyItemComponent)
                {
                    uiPaiMaiBuyItemComponent.OnLanguageUpdate();
                    continue;
                }
                if (component is UIRankShowItemComponent uiRankShowItemComponent)
                {
                    uiRankShowItemComponent.OnLanguageUpdate();
                    continue;
                }
                if (component is UIRankRewardComponent uiRankRewardComponent)
                {
                    uiRankRewardComponent.OnLanguageUpdate();
                    continue;
                }
                if (component is UIRankPetRewardComponent uiRankPetRewardComponent)
                {
                    uiRankPetRewardComponent.OnLanguageUpdate();
                    continue;
                }
                if (component is UIRechargeRewardComponent uiRechargeRewardComponent)
                {
                    uiRechargeRewardComponent.OnLanguageUpdate();
                    continue;
                }
                if (component is UINewYearMonsterComponent uiNewYearMonsterComponent)
                {
                    uiNewYearMonsterComponent.OnLanguageUpdate();
                    continue;
                }
                if (component is UINewYearCollectionWordIemComponent uiNewYearCollectionWordIemComponent)
                {
                    uiNewYearCollectionWordIemComponent.OnLanguageUpdate();
                    continue;
                }
                if (component is UIFirstWinComponent uiFirstWinComponent)
                {
                    uiFirstWinComponent.OnLanguageUpdate();
                    continue;
                }
                if (component is UIDonationShowComponent uiDonationShowComponent)
                {
                    uiDonationShowComponent.OnLanguageUpdate();
                    continue;
                }
                if (component is UIDonationUnionComponent uiDonationUnionComponent)
                {
                    uiDonationUnionComponent.OnLanguageUpdate();
                    continue;
                }
                if (component is UIHuntTaskItemComponent uiHuntTaskItemComponent)
                {
                    uiHuntTaskItemComponent.OnLanguageUpdate();
                    continue;
                }
                if (component is UIPopularizeComponent uiPopularizeComponent)
                {
                    uiPopularizeComponent.OnLanguageUpdate();
                    continue;
                }
                if (component is UILunTanComponent uiLunTanComponent)
                {
                    uiLunTanComponent.OnLanguageUpdate();
                    continue;
                }
                if (component is UICountryTaskItemComponent uiCountryTaskItemComponent)
                {
                    uiCountryTaskItemComponent.OnLanguageUpdate();
                    continue;
                }
                if (component is UIActivitySingInComponent uiActivitySingInComponent)
                {
                    uiActivitySingInComponent.OnLanguageUpdate();
                    continue;
                }
                if (component is UICountryHuoDongComponent uiCountryHuoDongComponent)
                {
                    uiCountryHuoDongComponent.OnLanguageUpdate();
                    continue;
                }
                if (component is UIActivitySingleRechargeComponent uiActivitySingleRechargeComponent)
                {
                    uiActivitySingleRechargeComponent.OnLanguageUpdate();
                    continue;
                }
                if (component is UISelectRewardComponent uiSelectRewardComponent)
                {
                    uiSelectRewardComponent.OnLanguageUpdate();
                    continue;
                }
                if (component is UIMailItemComponent uiMailItemComponent)
                {
                    uiMailItemComponent.OnLanguageUpdate();
                    continue;
                }
                if (component is UITrialDungeonComponent uiTrialDungeonComponent)
                {
                    uiTrialDungeonComponent.OnLanguageUpdate();
                    continue;
                }
                if (component is UITrialComponent uiTrialComponent)
                {
                    uiTrialComponent.OnLanguageUpdate();
                    continue;
                }
                if (component is UITrialRankComponent uiTrialRankComponent)
                {
                    uiTrialRankComponent.OnLanguageUpdate();
                    continue;
                }
                if (component is UIMakeLearnItemComponent uiMakeLearnItemComponent)
                {
                    uiMakeLearnItemComponent.OnLanguageUpdate();
                    continue;
                }
                if (component is UIMakeLearnComponent uiMakeLearnComponent)
                {
                    uiMakeLearnComponent.OnLanguageUpdate();
                    continue;
                }
                if (component is UIWarehouseComponent uiWarehouseComponent)
                {
                    uiWarehouseComponent.OnLanguageUpdate();
                    continue;
                }
                if (component is UIWarehouseRoleComponent uiWarehouseRoleComponent)
                {
                    uiWarehouseRoleComponent.OnLanguageUpdate();
                    continue;
                }
                if (component is UIWarehouseAccountComponent uiWarehouseAccountComponent)
                {
                    uiWarehouseAccountComponent.OnLanguageUpdate();
                    continue;
                }
                if (component is UIPopupComponent uiPopupComponent)
                {
                    uiPopupComponent.OnLanguageUpdate();
                    continue;
                }
                if (component is UIWarehouseGemComponent uiWarehouseGemComponent)
                {
                    uiWarehouseGemComponent.OnLanguageUpdate();
                    continue;
                }
                if (component is UIZuoQiComponent uiZuoQiComponent)
                {
                    uiZuoQiComponent.OnLanguageUpdate();
                    continue;
                }
                if (component is UIZuoQiShowItemComponent uiZuoQiShowItemComponent)
                {
                    uiZuoQiShowItemComponent.OnLanguageUpdate();
                    continue;
                }
                if (component is UIZuoQiShowComponent uiZuoQiShowComponent)
                {
                    uiZuoQiShowComponent.OnLanguageUpdate();
                    continue;
                }
                if (component is UITaskGetComponent uiTaskGetComponent)
                {
                    uiTaskGetComponent.OnLanguageUpdate();
                    continue;
                }
                if (component is UIMysteryItemComponent uiMysteryItemComponent)
                {
                    uiMysteryItemComponent.OnLanguageUpdate();
                    continue;
                }
                if (component is UIShouJiComponent uiShouJiComponent)
                {
                    uiShouJiComponent.OnLanguageUpdate();
                    continue;
                }
                if (component is UIShouJiItemComponent uiShouJiItemComponent)
                {
                    uiShouJiItemComponent.OnLanguageUpdate();
                    continue;
                }
                if (component is UIShouJiTreasureTypeComponent uiShouJiTreasureTypeComponent)
                {
                    uiShouJiTreasureTypeComponent.OnLanguageUpdate();
                    continue;
                }
                if (component is UIShouJiTreasureItemComponent uiShouJiTreasureItemComponent)
                {
                    uiShouJiTreasureItemComponent.OnLanguageUpdate();
                    continue;
                }
                if (component is UIProtectComponent uiProtectComponent)
                {
                    uiProtectComponent.OnLanguageUpdate();
                    continue;
                }
                if (component is UIProtectEquipComponent uiProtectEquipComponent)
                {
                    uiProtectEquipComponent.OnLanguageUpdate();
                    continue;
                }
                if (component is UIProtectPetComponent uiProtectPetComponent)
                {
                    uiProtectPetComponent.OnLanguageUpdate();
                    continue;
                }
                if (component is UITowerComponent uiTowerComponent)
                {
                    uiTowerComponent.OnLanguageUpdate();
                    continue;
                }
                if (component is UITowerDungeonComponent uiTowerDungeonComponent)
                {
                    uiTowerDungeonComponent.OnLanguageUpdate();
                    continue;
                }
                if (component is UIOccTwoComponent uiOccTwoComponent)
                {
                    uiOccTwoComponent.OnLanguageUpdate();
                    continue;
                }
                if (component is UIChouKaComponent uiChouKaComponent)
                {
                    uiChouKaComponent.OnLanguageUpdate();
                    continue;
                }
                if (component is UIPetEggComponent uiPetEggComponent)
                {
                    uiPetEggComponent.OnLanguageUpdate();
                    continue;
                }
                if (component is UIPetEggChouKaComponent uiPetEggChouKaComponent)
                {
                    uiPetEggChouKaComponent.OnLanguageUpdate();
                    continue;
                }
                if (component is UITowerOfSealComponent uiTowerOfSealComponent)
                {
                    uiTowerOfSealComponent.OnLanguageUpdate();
                    continue;
                }
                if (component is UIRoleXiLianComponent uiRoleXiLianComponent)
                {
                    uiRoleXiLianComponent.OnLanguageUpdate();
                    continue;
                }
                if (component is UIRoleXiLianExplainComponent uiRoleXiLianExplainComponent)
                {
                    uiRoleXiLianExplainComponent.OnLanguageUpdate();
                    continue;
                }
                if (component is UIRoleXiLianTransferComponent uiRoleXiLianTransferComponent)
                {
                    uiRoleXiLianTransferComponent.OnLanguageUpdate();
                    continue;
                }
                if (component is UIPetEggListItemComponent uiPetEggListItemComponent)
                {
                    uiPetEggListItemComponent.OnLanguageUpdate();
                    continue;
                }
                if (component is UIPetFormationComponent uiPetFormationComponent)
                {
                    uiPetFormationComponent.OnLanguageUpdate();
                    continue;
                }
                if (component is UIPetMiningItemComponent uiPetMiningItemComponent)
                {
                    uiPetMiningItemComponent.OnLanguageUpdate();
                    continue;
                }
                if (component is UIPetMiningComponent uiPetMiningComponent)
                {
                    uiPetMiningComponent.OnLanguageUpdate();
                    continue;
                }
                if (component is UITeamDungeonListComponent uiTeamDungeonListComponent)
                {
                    uiTeamDungeonListComponent.OnLanguageUpdate();
                    continue;
                }
                if (component is UITeamDungeonCreateComponent uiTeamDungeonCreateComponent)
                {
                    uiTeamDungeonCreateComponent.OnLanguageUpdate();
                    continue;
                }
                if (component is UIJiaYuanDaShiComponent uiJiaYuanDaShiComponent)
                {
                    uiJiaYuanDaShiComponent.OnLanguageUpdate();
                    continue;
                }
                if (component is UIJiaYuanFoodComponent uiJiaYuanFoodComponent)
                {
                    uiJiaYuanFoodComponent.OnLanguageUpdate();
                    continue;
                }
                if (component is UIJiaYuanPurchaseComponent uiJiaYuanPurchaseComponent)
                {
                    uiJiaYuanPurchaseComponent.OnLanguageUpdate();
                    continue;
                }
                if (component is UIJiaYuanMysteryComponent uiJiaYuanMysteryComponent)
                {
                    uiJiaYuanMysteryComponent.OnLanguageUpdate();
                    continue;
                }
                if (component is UIJiaYuanPastureComponent uiJiaYuanPastureComponent)
                {
                    uiJiaYuanPastureComponent.OnLanguageUpdate();
                    continue;
                }
                if (component is UIJiaYuanWarehouseComponent uiJiaYuanWarehouseComponent)
                {
                    uiJiaYuanWarehouseComponent.OnLanguageUpdate();
                    continue;
                }
                if (component is UIJiaYuanTreasureMapStorageComponent uiJiaYuanTreasureMapStorageComponent)
                {
                    uiJiaYuanTreasureMapStorageComponent.OnLanguageUpdate();
                    continue;
                }
                if (component is UIEquipmentIncreaseComponent uiEquipmentIncreaseComponent)
                {
                    uiEquipmentIncreaseComponent.OnLanguageUpdate();
                    continue;
                }
                if (component is UIEquipmentIncreaseShowComponent uiEquipmentIncreaseShowComponent)
                {
                    uiEquipmentIncreaseShowComponent.OnLanguageUpdate();
                    continue;
                }
                if (component is UIEquipmentIncreaseTransferComponent uiEquipmentIncreaseTransferComponent)
                {
                    uiEquipmentIncreaseTransferComponent.OnLanguageUpdate();
                    continue;
                }
                if (component is UIJiaYuanUpLvComponent uiJiaYuanUpLvComponent)
                {
                    uiJiaYuanUpLvComponent.OnLanguageUpdate();
                    continue;
                }
                if (component is UIUnionCreateComponent uiUnionCreateComponent)
                {
                    uiUnionCreateComponent.OnLanguageUpdate();
                    continue;
                }
                if (component is UIUnionDonationComponent uiUnionDonationComponent)
                {
                    uiUnionDonationComponent.OnLanguageUpdate();
                    continue;
                }
                if (component is UIUnionMysteryComponent uiUnionMysteryComponent)
                {
                    uiUnionMysteryComponent.OnLanguageUpdate();
                    continue;
                }
                if (component is UIUnionKeJiComponent uiUnionKeJiComponent)
                {
                    uiUnionKeJiComponent.OnLanguageUpdate();
                    continue;
                }
                if (component is UIUnionXiuLianComponent uiUnionXiuLianComponent)
                {
                    uiUnionXiuLianComponent.OnLanguageUpdate();
                    continue;
                }
                if (component is UIUnionRoleXiuLianComponent uiUnionRoleXiuLianComponent)
                {
                    uiUnionRoleXiuLianComponent.OnLanguageUpdate();
                    continue;
                }
                if (component is UIUnionAttributeUpComponent uiUnionAttributeUpComponent)
                {
                    uiUnionAttributeUpComponent.OnLanguageUpdate();
                    continue;
                }
                if (component is UIUnionKeJiResearchItemComponent uiUnionKeJiResearchItemComponent)
                {
                    uiUnionKeJiResearchItemComponent.OnLanguageUpdate();
                    continue;
                }
                if (component is UIUnionKeJiLearnItemComponent uiUnionKeJiLearnItemComponent)
                {
                    uiUnionKeJiLearnItemComponent.OnLanguageUpdate();
                    continue;
                }
                if (component is UISettingComponent uiSettingComponent)
                {
                    uiSettingComponent.OnLanguageUpdate();
                    continue;
                }
                if (component is UIItemTipsComponent uiItemTipsComponent)
                {
                    uiItemTipsComponent.OnLanguageUpdate();
                    continue;
                }
                if (component is UISkillTianFuComponent uiSkillTianFuComponent)
                {
                    uiSkillTianFuComponent.OnLanguageUpdate();
                    continue;
                }
                if (component is UISkillTianFuItemComponent uiSkillTianFuItemComponent)
                {
                    uiSkillTianFuItemComponent.OnLanguageUpdate();
                    continue;
                }
                if (component is UIItemAppraisalTipsComponent uiItemAppraisalTipsComponent)
                {
                    uiItemAppraisalTipsComponent.OnLanguageUpdate();
                    continue;
                }
                if (component is UIEquipTipsComponent uiEquipTipsComponent)
                {
                    uiEquipTipsComponent.OnLanguageUpdate();
                    continue;
                }
                if (component is UISettingSkillComponent uiSettingSkillComponent)
                {
                    uiSettingSkillComponent.OnLanguageUpdate();
                    continue;
                }
                if (component is UIPaiMaiDuiHuanComponet uiPaiMaiDuiHuanComponent)
                {
                    uiPaiMaiDuiHuanComponent.OnLanguageUpdate();
                    continue;
                }
                if (component is UIAppraisalSelectComponent uiAppraisalSelectComponent)
                {
                    uiAppraisalSelectComponent.OnLanguageUpdate();
                    continue;
                }
                if (component is UIWelfareComponent uiWelfareComponent)
                {
                    uiWelfareComponent.OnLanguageUpdate();
                    continue;
                }
                if (component is UIJiaYuanPetComponent uiJiaYuanPetComponent)
                {
                    uiJiaYuanPetComponent.OnLanguageUpdate();
                    continue;
                }
                if (component is UISoloComponent uiSoloComponent)
                {
                    uiSoloComponent.OnLanguageUpdate();
                    continue;
                }
                if (component is UIHuntRankingComponent uiHuntRankingComponent)
                {
                    uiHuntRankingComponent.OnLanguageUpdate();
                    continue;
                }
                if (component is UIBattleComponent uiBattleComponent)
                {
                    uiBattleComponent.OnLanguageUpdate();
                    continue;
                }
                if (component is UIBattleEnterComponent uiBattleEnterComponent)
                {
                    uiBattleEnterComponent.OnLanguageUpdate();
                    continue;
                }
                if (component is UISeasonHomeComponent uiSeasonHomeComponent)
                {
                    uiSeasonHomeComponent.OnLanguageUpdate();
                    continue;
                }
                if (component is UISeasonTowerComponent uiSeasonTowerComponent)
                {
                    uiSeasonTowerComponent.OnLanguageUpdate();
                    continue;
                }
                if (component is UIRoleXiLianShowComponent uiRoleXiLianShowComponent)
                {
                    uiRoleXiLianShowComponent.OnLanguageUpdate();
                    continue;
                }
                if (component is UIHuntComponent uiHuntComponent)
                {
                    uiHuntComponent.OnLanguageUpdate();
                    continue;
                }
            }
        }

        public void OnSkillUse(Dictionary<long, Entity> dataUpdateComponentDic, string DataParams, long upateValue)
        {
            foreach (var component in dataUpdateComponentDic.Values)
            {
                if (component is UIRunRaceMainComponent uimainComponent)
                {
                    uimainComponent.OnSkillUse(upateValue);
                    continue;
                }
            }
        }

        public void OnUpdateUserBuffSkill(Dictionary<long, Entity> dataUpdateComponentDic, string DataParams, long upateValue)
        {
            foreach (var component in dataUpdateComponentDic.Values)
            {
                if (component is UIRunRaceMainComponent uimainComponent)
                {
                    uimainComponent.OnUpdateUserBuffSkill(upateValue);
                    continue;
                }
            }
        }

        public void OnUpdateUserDataPiLao(Dictionary<long, Entity> dataUpdateComponentDic, string DataParams, long upateValue)
        {
            foreach (var component in dataUpdateComponentDic.Values)
            {
                if (component is UIMainComponent uimainComponent)
                {
                    uimainComponent.OnUpdateUserDataPiLao(DataParams, upateValue);
                    continue;
                }
            }
        }

        //更新身上货币属性
        public void OnUpdateUserData(Dictionary<long, Entity> dataUpdateComponentDic, string DataParams, long upateValue)
        {
            //更新玩家数据
            foreach (var component in dataUpdateComponentDic.Values)
            {
                if (component is UICommonHuoBiSetComponent uiComponent)
                {
                    uiComponent.OnUpdateUI();
                    continue;
                }
                if (component is UIMainComponent uimainComponent)
                {
                    uimainComponent.OnUpdateUserData(DataParams);
                    uimainComponent.OnUpdateTapTapUserData(DataParams);
                    continue;
                }
                if (component is UIChouKaComponent uichoukaComponent)
                {
                    uichoukaComponent.OnUpdateUserData(DataParams);
                    continue;
                }
            }
        }

        //更新玩家战斗属性
        public void OnUpdateRoleProper(Dictionary<long, Entity> dataUpdateComponentDic, string DataParams, long upateValue)
        {
            //更新玩家数据
            foreach (var component in dataUpdateComponentDic.Values)
            {
                if (component is UIRolePropertyComponent uiRolePropertyCompont)
                {
                    uiRolePropertyCompont.InitPropertyShow(uiRolePropertyCompont.NowShowType);
                    continue;
                }
            }
        }

        //修改名字
        public void OnUpdateRoleName(Dictionary<long, Entity> dataUpdateComponentDic, string DataParams, long upateValue)
        {
            foreach (var component in dataUpdateComponentDic.Values)
            {
                if (component is UIMainComponent uimainComponent)
                {
                    uimainComponent.OnUpdateRoleName();
                    continue;
                }
            }
        }

        //跑马灯
        public void OnHorseNotice(Dictionary<long, Entity> dataUpdateComponentDic, string DataParams, long upateValue)
        {
            foreach (var component in dataUpdateComponentDic.Values)
            {
                if (component is UIMainComponent uimainComponent)
                {
                    uimainComponent.OnHorseNotice();
                    continue;
                }
            }
        }

        //聊天更新
        public void OnChatRecv(Dictionary<long, Entity> dataUpdateComponentDic, string DataParams, long upateValue)
        {
            foreach (var component in dataUpdateComponentDic.Values)
            {
                if (component is UIChatComponent uichatComponent)
                {
                    uichatComponent.OnChatRecv().Coroutine();
                    continue;
                }
                if (component is UIMainComponent uimainComponent)
                {
                    uimainComponent.OnRecvChat();
                    continue;
                }
                if (component is UIUnitHpComponent uiUnitHpComponent)
                {
                    uiUnitHpComponent.ShowDialog();
                }
            }
        }

        //任务追踪
        public void OnRecvTaskTrace(Dictionary<long, Entity> dataUpdateComponentDic, string DataParams, long upateValue)
        {
            foreach (var component in dataUpdateComponentDic.Values)
            {
                if (component is UIMainComponent uimainComponent)
                {
                    uimainComponent.OnRecvTaskTrace();
                    continue;
                }
            }
        }

        /// <summary>
        /// 放弃任务
        /// </summary>
        /// <param name="dataUpdateComponentDic"></param>
        /// <param name="DataParams"></param>
        public void OnTaskGiveUp(Dictionary<long, Entity> dataUpdateComponentDic, string DataParams, long upateValue)
        {
            foreach (var component in dataUpdateComponentDic.Values)
            {
                if (component is UITaskAComponent uitaskAComponent)
                {
                    uitaskAComponent.OnTaskGiveUp();
                    continue;
                }
                if (component is UIMainComponent uimainComponent)
                {
                    uimainComponent.OnTaskGiveUp();
                    continue;
                }
            }
        }

       //任务接取
        public void OnGetTask(Dictionary<long, Entity> dataUpdateComponentDic, string DataParams, long upateValue) 
        {
            TaskConfig taskCof = TaskConfigCategory.Instance.Get(int.Parse(DataParams));
            FloatTipManager.Instance.ShowFloatTipDi(GameSettingLanguge.LoadLocalization("接取任务") + ":" + taskCof.GetTaskName());

            List<Entity> entities = dataUpdateComponentDic.Values.ToList();
            for (int i = entities.Count - 1; i >= 0; i--)
            {
                Entity component = entities[i];    
                if (component is UITaskGetComponent uitaskgetComponent)
                {
                    uitaskgetComponent.OnTaskGet();
                    continue;
                }
                if (component is UIMainComponent uimainComponent)
                {
                    uimainComponent.OnTaskGet(DataParams);
                    uimainComponent.OnRecvTaskUpdate();
                    uimainComponent.OnRecvTaskTrace();
                    uimainComponent.OnTaskGetEffect();
                    continue;
                }
                if (component is UITaskAComponent uiTaskAComponent)
                {
                    uiTaskAComponent.OnClickTaskType((int)TaskTypeEnum.Daily);
                }
            }
            return;
        }

        //任务完成
        public void OnCompleteTask(Dictionary<long, Entity> dataUpdateComponentDic, string DataParams, long upateValue)
        {
            foreach (var component in dataUpdateComponentDic.Values)
            {
                if (component is UIMainComponent uimainComponent)
                {
                    uimainComponent.OnCompleteTask(DataParams).Coroutine();
                    uimainComponent.OnRecvTaskUpdate();
                    uimainComponent.OnTaskCompleteEffect();
                    continue;
                }
            }
            TaskConfig taskCof = TaskConfigCategory.Instance.Get(int.Parse(DataParams));
            FloatTipManager.Instance.ShowFloatTipDi(taskCof.GetTaskName() + GameSettingLanguge.LoadLocalization(GameSettingLanguge.LoadLocalization("任务完成!")));
        }

        public static void OnUpdateTask(Dictionary<long, Entity> dataUpdateComponentDic, string DataParams, long upateValue)
        {
            foreach (var component in dataUpdateComponentDic.Values)
            {
                if (component is UITaskAComponent uitaskAComponent)
                {
                    uitaskAComponent.OnRecvTaskUpdate();
                    continue;
                }
                if (component is UIMainComponent uimainComponent)
                {
                    uimainComponent.OnRecvTaskUpdate();
                    continue;
                }
            }
        }

        //选择回收
        public void OnHuiShouSelect(Dictionary<long, Entity> dataUpdateComponentDic, string DataParams, long upateValue)
        {
            foreach (var component in dataUpdateComponentDic.Values)
            {
                if (component is UIRoleComponent uiequipComponent)
                {
                    uiequipComponent.OnHuiShouSelect(DataParams);
                    continue;
                }
                if (component is UIJiaYuanCookingComponent cookingComponent)
                {
                    cookingComponent.OnHuiShouSelect(DataParams);
                    continue;
                }
                if (component is UIJiaYuanPetFeedComponent petfeedComponent)
                {
                    petfeedComponent.OnHuiShouSelect(DataParams);
                    continue;
                }
                if (component is UISkillMeltingComponent uiSkillMeltComponent)
                {
                    uiSkillMeltComponent.OnHuiShouSelect(DataParams);
                    continue;
                }
                if (component is UISkillLifeShieldComponent uiSkillLiftComponent)
                {
                    uiSkillLiftComponent.OnHuiShouSelect(DataParams);
                    continue;
                }
                if (component is UIMagickaSlotComponent uIMagickaSlotComponent)
                {
                    uIMagickaSlotComponent.OnHuiShouSelect(DataParams);
                    continue;
                }
            }

        }

        //穿戴装备
        public void OnEquipWear(Dictionary<long, Entity> dataUpdateComponentDic, string DataParams, long upateValue)
        {
            foreach (var component in dataUpdateComponentDic.Values)
            {
                if (component is UIRoleComponent uiequipComponent)
                {
                    uiequipComponent.OnEquipWear();
                    continue;
                }
                if (component is UIMainComponent uimainComponent)
                {
                    uimainComponent.OnEquipWear();
                    continue;
                }
                if (component is UIMagickaSlotComponent uIMagickaSlot)
                {
                    uIMagickaSlot.OnEquipWear();
                    continue;
                }
            }
        }

        //技能升级
        public void OnSkillUpgrade(Dictionary<long, Entity> dataUpdateComponentDic, string DataParams, long upateValue)
        {
            foreach (var component in dataUpdateComponentDic.Values)
            {
                if (component is UISkillComponent uiTargetComponent)
                {
                    uiTargetComponent.OnSkillUpgrade(DataParams);
                    continue;
                }
                if (component is UIMainComponent uiMainComponent)
                {
                    uiMainComponent.OnSkillSetUpdate();
                    continue;
                }
            }
        }
        
        // 技能获得
        public void OnSkillGet(Dictionary<long, Entity> dataUpdateComponentDic, string DataParams, long upateValue)
        {
            foreach (var component in dataUpdateComponentDic.Values)
            {
                if (component is UISkillComponent uiTargetComponent)
                {
                    uiTargetComponent.SkillSetGuideTrigger();
                    continue;
                }
            }
        }

        public void OnSkillReset(Dictionary<long, Entity> dataUpdateComponentDic, string DataParams, long upateValue)
        {
            foreach (var component in dataUpdateComponentDic.Values)
            {
                if (component is UIMainComponent uiMainComponent)
                {
                    uiMainComponent.OnSkillSetUpdate();
                    continue;
                }
                if (component is UISkillComponent uiskillComponent)
                {
                    uiskillComponent.OnSkillReset();
                    continue;
                }
            }
        }

        //技能设置
        public void OnSkillSetting(Dictionary<long, Entity> dataUpdateComponentDic, string DataParams, long upateValue)
        {
            foreach (var component in dataUpdateComponentDic.Values)
            {
                if (component is UISkillComponent uiTargetComponent)
                {
                    uiTargetComponent.OnSkillSetUpdate();
                    continue;
                }
                if (component is UIMainComponent uiMainComponent)
                {
                    uiMainComponent.OnSkillSetUpdate();
                    continue;
                }
            }
        }


        public void OnTaskCountryComplete(Dictionary<long, Entity> dataUpdateComponentDic, string DataParams, long upateValue)
        {
            foreach (var component in dataUpdateComponentDic.Values)
            {
                if (component is UIMainComponent uimainComponent)
                {
                    uimainComponent.OnTaskCompleteEffect();
                    continue;
                }
            }
        }

        public void OnUpdateTimerChouKa(Dictionary<long, Entity> dataUpdateComponentDic, string DataParams, long upateValue)
        {
            foreach (var component in dataUpdateComponentDic.Values)
            {
                if (component is UIMainComponent uimainComponent)
                {
                    uimainComponent.OnUpdateTimerChouKa();
                    continue;
                }
            }
        }

        public void OnOnUseSealWeapon(Dictionary<long, Entity> dataUpdateComponentDic, string DataParams, long upateValue)
        {
            foreach (var component in dataUpdateComponentDic.Values)
            {
                if (component is UIMainComponent uimainComponent)
                {
                    uimainComponent.OnOnUseSealWeapon(DataParams).Coroutine();
                    continue;
                }
            }
        }
    }

    [Event]
    public class DataUpdateEvent: AEventClass<EventType.DataUpdate>
    {
        protected override  void Run(object cls)
        {
            EventType.DataUpdate args = cls as EventType.DataUpdate;
            //根据对应类型获取对应的组件,判定那些组件监听事件，有监听事件才会调用对应的委托
            if (!DataUpdateComponent.Instance.DataUpdateComponents.TryGetDic(args.DataType, out var dataUpdateComponentDic))
            {
                return;
            }
            
            //调用对应委托
            if (dataUpdateComponentDic==null)
            {
                return;
            }

            DataUpdateHelp.Instance.DataUpdatelegateDics[args.DataType](dataUpdateComponentDic, args.DataParamString, args.UpdateValue);
        }
    }
}