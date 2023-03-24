using System;
using System.Linq;
using System.Collections.Generic;

namespace ET
{

    public class DataUpdateHelp : Singleton<DataUpdateHelp>
    {
        public delegate void DataUpdatelegate(Dictionary<long, Entity> dataUpdateComponentDic,  string DataParams);
        public Dictionary<int, DataUpdatelegate> DataUpdatelegateDics;

        protected override void InternalInit()
        {
            base.InternalInit();

            DataUpdatelegateDics = new Dictionary<int, DataUpdatelegate>();
            DataUpdatelegateDics.Add(DataType.SkillSetting, OnSkillSetting);
            DataUpdatelegateDics.Add(DataType.SkillReset, OnSkillReset);
            DataUpdatelegateDics.Add(DataType.SkillUpgrade, OnSkillUpgrade);
            DataUpdatelegateDics.Add(DataType.EquipWear, OnEquipWear);
            DataUpdatelegateDics.Add(DataType.HuiShouSelect, OnHuiShouSelect);
            DataUpdatelegateDics.Add(DataType.TaskTrace, OnRecvTaskTrace);
            DataUpdatelegateDics.Add(DataType.TaskGet, OnGetTask);
            DataUpdatelegateDics.Add(DataType.TaskLoopGet, OnTaskLoopGet);
            DataUpdatelegateDics.Add(DataType.TaskGiveUp, OnTaskGiveUp);
            DataUpdatelegateDics.Add(DataType.TaskComplete, OnCompleteTask);
            DataUpdatelegateDics.Add(DataType.TaskUpdate, OnUpdateTask);
            DataUpdatelegateDics.Add(DataType.OnRecvChat, OnChatRecv);
            DataUpdatelegateDics.Add(DataType.HorseNotice, OnHorseNotice);
            DataUpdatelegateDics.Add(DataType.UpdateRoleData, OnUpdateRoleData);
            DataUpdatelegateDics.Add(DataType.UpdateRoleFightData, OnUpdateRoleFightData);
            DataUpdatelegateDics.Add(DataType.BagItemUpdate, OnBagItemUpdate);
            DataUpdatelegateDics.Add(DataType.OnMailUpdate, OnMailUpdate);
            DataUpdatelegateDics.Add(DataType.OnPetFightSet, OnPetFightSet);
            DataUpdatelegateDics.Add(DataType.OnActiveTianFu, OnActiveTianFu);
            DataUpdatelegateDics.Add(DataType.ChengJiuUpdate, OnChengJiuUpdate);
            DataUpdatelegateDics.Add(DataType.PetItemSelect, OnPetItemSelect);
            DataUpdatelegateDics.Add(DataType.PetUpStarUpdate, OnPetUpStarUpdate);
            DataUpdatelegateDics.Add(DataType.SettingUpdate, OnSettingUpdate);
            DataUpdatelegateDics.Add(DataType.PetFenJieUpdate, OnPetFenJieUpdate);
            DataUpdatelegateDics.Add(DataType.EquipHuiShow, OnEquipHuiShow);
            DataUpdatelegateDics.Add(DataType.BagItemAdd, OnBagItemAdd);
            DataUpdatelegateDics.Add(DataType.TeamUpdate, OnTeamUpdate);
            DataUpdatelegateDics.Add(DataType.FriendUpdate, OnFriendUpdate);
            DataUpdatelegateDics.Add(DataType.FriendChat, OnFriendChat);
            DataUpdatelegateDics.Add(DataType.PetXiLianUpdate, OnPetXiLianUpdate);
            DataUpdatelegateDics.Add(DataType.PetHeChengUpdate, OnHeChengReturn);
            DataUpdatelegateDics.Add(DataType.MainHeroMove, OnMainHeroPosition);
            DataUpdatelegateDics.Add(DataType.SkillCDUpdate, OnSkillCDUpdate);
            DataUpdatelegateDics.Add(DataType.SkillBeging, OnSkillBeging);
            DataUpdatelegateDics.Add(DataType.SkillFinish, OnSkillFinish);
            DataUpdatelegateDics.Add(DataType.JingLingButton, OnJingLingButton);
            DataUpdatelegateDics.Add(DataType.BuyBagCell, OnBuyBagCell);
        }

        public void OnBuyBagCell(Dictionary<long, Entity> dataUpdateComponentDic, string DataParams)
        {
            foreach (var component in dataUpdateComponentDic.Values)
            {
                if (component is UIRoleComponent uiComponent)
                {
                    uiComponent.OnBuyBagCell();
                    continue;
                }
                if (component is UIWarehouseComponent uiwareComponent)
                {
                    uiwareComponent.OnBuyBagCell(DataParams);
                    continue;
                }
            }
        }

        public void OnJingLingButton(Dictionary<long, Entity> dataUpdateComponentDic, string DataParams)
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

        public void OnSkillBeging(Dictionary<long, Entity> dataUpdateComponentDic, string DataParams)
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

        public void OnSkillFinish(Dictionary<long, Entity> dataUpdateComponentDic, string DataParams)
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

        public void OnSkillCDUpdate(Dictionary<long, Entity> dataUpdateComponentDic, string DataParams)
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

        public void OnMainHeroPosition(Dictionary<long, Entity> dataUpdateComponentDic, string DataParams)
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

        public void OnHeChengReturn(Dictionary<long, Entity> dataUpdateComponentDic, string DataParams)
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

        public void OnPetXiLianUpdate(Dictionary<long, Entity> dataUpdateComponentDic, string DataParams)
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

        public void OnFriendChat(Dictionary<long, Entity> dataUpdateComponentDic, string DataParams)
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

        public void OnFriendUpdate(Dictionary<long, Entity> dataUpdateComponentDic, string DataParams)
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

        public void OnTeamUpdate(Dictionary<long, Entity> dataUpdateComponentDic, string DataParams)
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

        public void OnBagItemAdd(Dictionary<long, Entity> dataUpdateComponentDic, string DataParams)
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

        public void OnEquipHuiShow(Dictionary<long, Entity> dataUpdateComponentDic, string DataParams)
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

        public void OnPetFenJieUpdate(Dictionary<long, Entity> dataUpdateComponentDic, string DataParams)
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

        public void OnSettingUpdate(Dictionary<long, Entity> dataUpdateComponentDic, string DataParams)
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

        public void OnPetUpStarUpdate(Dictionary<long, Entity> dataUpdateComponentDic, string DataParams)
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

        public void OnPetItemSelect(Dictionary<long, Entity> dataUpdateComponentDic, string DataParams)
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
            }
            return;
        }

        public void OnChengJiuUpdate(Dictionary<long, Entity> dataUpdateComponentDic, string DataParams)
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

        public void OnActiveTianFu(Dictionary<long, Entity> dataUpdateComponentDic, string DataParams)
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

        public void OnPetFightSet(Dictionary<long, Entity> dataUpdateComponentDic, string DataParams)
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

        public void OnMailUpdate(Dictionary<long, Entity> dataUpdateComponentDic, string DataParams)
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

        public void OnBagItemUpdate(Dictionary<long, Entity> dataUpdateComponentDic, string DataParams)
        {

            foreach (var component in dataUpdateComponentDic.Values)
            {
                if (component is UIRoleComponent uiequipComponent)
                {
                    uiequipComponent.UpdateBagUI();
                    continue;
                }
                if (component is UIWarehouseComponent uihourseComponent)
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
            }
        }

        //更新身上货币属性
        public void OnUpdateRoleData(Dictionary<long, Entity> dataUpdateComponentDic, string DataParams)
        {
            //更新玩家数据
            foreach (var component in dataUpdateComponentDic.Values)
            {
                if (component is UICommonHuoBiSetComponent uiComponent)
                {
                    //更新金币
                    uiComponent.UpdataGoldShow();
                    //更新钻石
                    uiComponent.UpdataRmbShow();
                    uiComponent.UpdateRongYu();
                    continue;
                }
                if (component is UICountryComponent uiCountry)
                {
                    //更新活跃
                    uiCountry.OnUpdateRoleData(DataParams);
                    continue;
                }
                if (component is UIMainComponent uimainComponent)
                {
                    uimainComponent.OnUpdateRoleData(DataParams);
                    continue;
                }
                if (component is UIChouKaComponent uichoukaComponent)
                {
                    uichoukaComponent.OnUpdateRoleData(DataParams);
                    continue;
                }
            }
        }

        //更新玩家战斗属性
        public void OnUpdateRoleFightData(Dictionary<long, Entity> dataUpdateComponentDic, string DataParams)
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
        public void OnUpdateRoleName(Dictionary<long, Entity> dataUpdateComponentDic, string DataParams)
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
        public void OnHorseNotice(Dictionary<long, Entity> dataUpdateComponentDic, string DataParams)
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
        public void OnChatRecv(Dictionary<long, Entity> dataUpdateComponentDic, string DataParams)
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
        public void OnRecvTaskTrace(Dictionary<long, Entity> dataUpdateComponentDic, string DataParams)
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
        public void OnTaskGiveUp(Dictionary<long, Entity> dataUpdateComponentDic, string DataParams)
        {
            foreach (var component in dataUpdateComponentDic.Values)
            {
                if (component is UITaskComponent uitaskComponent)
                {
                    uitaskComponent.OnTaskGiveUp();
                    continue;
                }
                if (component is UIMainComponent uimainComponent)
                {
                    uimainComponent.OnTaskGiveUp();
                    continue;
                }
            }
        }

        public void OnTaskLoopGet(Dictionary<long, Entity> dataUpdateComponentDic, string DataParams)
        {
            TaskConfig taskCof = TaskConfigCategory.Instance.Get(int.Parse(DataParams));
            FloatTipManager.Instance.ShowFloatTipDi(GameSettingLanguge.LoadLocalization("接取任务") + ":" + taskCof.TaskName);

            List<Entity> entities = dataUpdateComponentDic.Values.ToList();
            for (int i = entities.Count - 1; i >= 0; i--)
            {
                Entity component = entities[i];
                if (component is UIMainComponent uimainComponent)
                {
                    uimainComponent.OnRecvTaskUpdate();
                    uimainComponent.OnRecvTaskTrace();
                    continue;
                }
            }
            return;
        }

       //任务接取
        public void OnGetTask(Dictionary<long, Entity> dataUpdateComponentDic, string DataParams) 
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
                    uimainComponent.OnRecvTaskUpdate();
                    uimainComponent.OnRecvTaskTrace();
                    continue;
                }
            }
            return;
        }

        //任务完成
        public void OnCompleteTask(Dictionary<long, Entity> dataUpdateComponentDic, string DataParams)
        {
            this.OnUpdateTask(dataUpdateComponentDic, DataParams);
            TaskConfig taskCof = TaskConfigCategory.Instance.Get(int.Parse(DataParams));
            FloatTipManager.Instance.ShowFloatTipDi(taskCof.TaskName + GameSettingLanguge.LoadLocalization("任务完成!"));
        }

        public void OnUpdateTask(Dictionary<long, Entity> dataUpdateComponentDic, string DataParams) 
        {
            foreach (var component in dataUpdateComponentDic.Values)
            {
                if (component is UITaskComponent uitaskComponent)
                {
                    uitaskComponent.OnRecvTaskUpdate();
                    continue;
                }
                if (component is UIMainComponent uimainComponent)
                {
                    uimainComponent.OnRecvTaskUpdate();
                    continue;
                }
            }
            return;
        }

        //选择回收
        public void OnHuiShouSelect(Dictionary<long, Entity> dataUpdateComponentDic, string DataParams)
        {
            foreach (var component in dataUpdateComponentDic.Values)
            {
                if (component is UIRoleComponent uiequipComponent)
                {
                    uiequipComponent.OnHuiShouSelect(DataParams);
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
        public void OnEquipWear(Dictionary<long, Entity> dataUpdateComponentDic, string DataParams)
        {
            foreach (var component in dataUpdateComponentDic.Values)
            {
                if (component is UIRoleComponent uiequipComponent)
                {
                    uiequipComponent.OnEquipWear(DataParams);
                    continue;
                }
                if (component is UIMainComponent uimainComponent)
                {
                    uimainComponent.OnEquipWear(DataParams);
                    continue;
                }
            }
        }

        //技能升级
        public void OnSkillUpgrade(Dictionary<long, Entity> dataUpdateComponentDic, string DataParams)
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

        public void OnSkillReset(Dictionary<long, Entity> dataUpdateComponentDic, string DataParams)
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
        public void OnSkillSetting(Dictionary<long, Entity> dataUpdateComponentDic, string DataParams)
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
            if (dataUpdateComponentDic!=null)
            {
                DataUpdateHelp.Instance.DataUpdatelegateDics[args.DataType](dataUpdateComponentDic, args.DataParams);
                return;
            }
        }
    }
}