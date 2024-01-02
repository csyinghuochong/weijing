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
                { DataType.ChouKaWarehouseAddItem, OnChouKaWarehouseAddItem}
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
                    if (DataParams == "1")
                    {
                        uiComponent.AutoHorse();
                    }
                    uiComponent.OnMoveStart();
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
            FloatTipManager.Instance.ShowFloatTipDi(GameSettingLanguge.LoadLocalization("接取任务") + ":" + taskCof.TaskName);

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
                if (component is UITaskAComponent uitaskAComponent)
                {
                    uitaskAComponent.OnRecvTaskUpdate();
                    continue;
                }
                if (component is UIMainComponent uimainComponent)
                {
                    uimainComponent.OnCompleteTask(DataParams).Coroutine();
                    uimainComponent.OnRecvTaskUpdate();
                    continue;
                }
            }
            TaskConfig taskCof = TaskConfigCategory.Instance.Get(int.Parse(DataParams));
            FloatTipManager.Instance.ShowFloatTipDi(taskCof.TaskName + GameSettingLanguge.LoadLocalization("任务完成!"));
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