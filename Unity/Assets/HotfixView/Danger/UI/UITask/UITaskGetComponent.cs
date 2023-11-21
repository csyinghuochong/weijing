using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UITaskGetComponent : Entity, IAwake, IDestroy
    {
        public int NpcID;
        public int TaskId;
        public int WeekTaskId = 0;

        //NpcID
        public GameObject ButtonMystery;
        public GameObject ButtonGiveTask;
        public GameObject ButtonPetFragment;
        public GameObject ButtonExpDuiHuan;
        public GameObject ButtonJieRiReward;
        public GameObject TaskFubenList;
        public GameObject UITaskFubenItem;
        public GameObject Btn_EnergyDuihuan;
        public GameObject EnergySkill;
        public GameObject BtnCommitTask1;
        public GameObject RewardListNode;
        public GameObject ButtonGet;
        public GameObject TaskListNode;
        public GameObject UITaskGetItem;
        public GameObject ScrollView1;
        public GameObject Lab_NpcSpeak;
        public GameObject Lab_NpcName;
        public GameObject Img_button;
        public GameObject Obj_Lab_MoNnengHint;
        public List<UI> TaskUIList = new List<UI>();
    }


    public class UINpcTaskComponentAwakeSystem : AwakeSystem<UITaskGetComponent>
    {
        public override void Awake(UITaskGetComponent self)
        {
            self.TaskId = 0;
            self.TaskUIList.Clear();
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.Btn_EnergyDuihuan = rc.Get<GameObject>("Btn_EnergyDuihuan");
            self.Btn_EnergyDuihuan.GetComponent<Button>().onClick.AddListener(() => { self.RequestEnergySkill().Coroutine(); });

            self.EnergySkill = rc.Get<GameObject>("EnergySkill");
            self.Obj_Lab_MoNnengHint = rc.Get<GameObject>("Lab_MoNnengHint");

            self.BtnCommitTask1 = rc.Get<GameObject>("BtnCommitTask1");
            ButtonHelp.AddListenerEx(self.BtnCommitTask1, () => { self.OnBtn_CommitTask().Coroutine(); });
            self.BtnCommitTask1.SetActive(false);
            self.RewardListNode = rc.Get<GameObject>("RewardListNode");
          
            self.ButtonGet = rc.Get<GameObject>("ButtonGet");
            ButtonHelp.AddListenerEx(self.ButtonGet, self.OnButtonGetTask);
            self.ButtonGet.SetActive(false);

            self.TaskListNode = rc.Get<GameObject>("TaskListNode");
            self.UITaskGetItem = rc.Get<GameObject>("UITaskGetItem");
            self.UITaskGetItem.SetActive(false);
            self.ScrollView1 = rc.Get<GameObject>("ScrollView1");
            self.ScrollView1.SetActive(false);

            self.Lab_NpcSpeak = rc.Get<GameObject>("Lab_NpcSpeak");
            self.Lab_NpcName = rc.Get<GameObject>("Lab_NpcName");

            self.TaskFubenList = rc.Get<GameObject>("TaskFubenList");
            self.UITaskFubenItem = rc.Get<GameObject>("UITaskFubenItem");
            self.UITaskFubenItem.SetActive(false);

            self.ButtonJieRiReward = rc.Get<GameObject>("ButtonJieRiReward");
            self.ButtonJieRiReward.SetActive(false);
            ButtonHelp.AddListenerEx(self.ButtonJieRiReward, () => { self.OnButtonJieRiReward();  });

            self.ButtonExpDuiHuan = rc.Get<GameObject>("ButtonExpDuiHuan");
            self.ButtonExpDuiHuan.SetActive(false);
            ButtonHelp.AddListenerEx(self.ButtonExpDuiHuan, () => { self.OnButtonExpDuiHuan().Coroutine(); });

            self.Img_button = rc.Get<GameObject>("Img_button");
            self.Img_button.GetComponent<Button>().onClick.AddListener(() => { self.OnCloseNpcTask(); });

            self.ButtonPetFragment = rc.Get<GameObject>("ButtonPetFragment");
            self.ButtonPetFragment.GetComponent<Button>().onClick.AddListener(() => { self.OnButtonFragmentHuan(); });

            self.ButtonGiveTask = rc.Get<GameObject>("ButtonGiveTask");
            self.ButtonGiveTask.GetComponent<Button>().onClick.AddListener(() => { self.OnButtonGiveTask().Coroutine(); });

            self.ButtonMystery = rc.Get<GameObject>("ButtonMystery");
            self.ButtonMystery.GetComponent<Button>().onClick.AddListener(self.OnButtonMystery);

            DataUpdateComponent.Instance.AddListener(DataType.TaskGet, self);
        }
    }

    public class UINpcTaskComponentDestroySystem : DestroySystem<UITaskGetComponent>
    {
        public override void Destroy(UITaskGetComponent self)
        {
            self.TaskUIList = null;
            DataUpdateComponent.Instance.RemoveListener(DataType.TaskGet, self);
        }
    }

    public static class UINpcTaskComponentSystem
    {
        public static  void OnTaskGet(this UITaskGetComponent self)
        {
            bool update = self.UpdataTask();
            if (!update)
            {
                self.OnCloseNpcTask();
            }
        }

        public static void OnCloseNpcTask(this UITaskGetComponent self)
        {
            //UIHelper.Remove(self.ZoneScene(), UIType.UIGuide);
            UIHelper.Remove(self.ZoneScene(), UIType.UITaskGet);
        }

        public static async ETTask OnButtonExpDuiHuan(this UITaskGetComponent self)
        {
            C2M_ExpToGoldRequest request = new C2M_ExpToGoldRequest() { OperateType = 2 };
            M2C_ExpToGoldResponse response = (M2C_ExpToGoldResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request);
           
        }

        public static void OnButtonJieRiReward(this UITaskGetComponent self)
        {
            int activityId = ActivityHelper.GetJieRiActivityId();
            ActivityConfig activityConfig = ActivityConfigCategory.Instance.Get(activityId);
            if (activityConfig == null)
            {
                return;
            }
            ActivityComponent activityComponent = self.ZoneScene().GetComponent<ActivityComponent>();
            if (activityComponent.ActivityReceiveIds.Contains(activityId))
            {
                FloatTipManager.Instance.ShowFloatTip("已经领取过奖励！");
            }
            activityComponent.GetActivityReward( activityConfig.ActivityType, activityId).Coroutine();
            self.ButtonJieRiReward.SetActive(false);
        }

        public static void InitData(this UITaskGetComponent self, int npcID)
        {
            self.NpcID = npcID;
            NpcConfig npcConfig = NpcConfigCategory.Instance.Get(npcID);

            //显示Npc对话   
            self.Lab_NpcSpeak.GetComponent<Text>().text = "   " + npcConfig.SpeakText;
            self.Lab_NpcName.GetComponent<Text>().text = npcConfig.Name;
            self.TaskFubenList.SetActive(false);
            self.ScrollView1.SetActive(false);
            self.EnergySkill.SetActive(false);
            self.ButtonJieRiReward.SetActive(false);
            self.ButtonExpDuiHuan.SetActive(false);
            self.ButtonPetFragment.SetActive(false);
            self.ButtonGiveTask.SetActive(false);
            self.ButtonMystery.SetActive(false);

            switch (npcConfig.NpcType)
            {
                case 1://神兽兑换
                case 2: //挑戰之地
                    self.TaskFubenList.SetActive(true);
                    if (npcConfig.NpcPar != null)
                    {
                        List<int> fubenList = new List<int>(npcConfig.NpcPar);
                        for (int i = 0; i < fubenList.Count; i++)
                        {
                            if (fubenList[i] == 0)
                            {
                                continue;
                            }
                            GameObject go = GameObject.Instantiate(self.UITaskFubenItem);
                            go.SetActive(true);
                            UICommonHelper.SetParent(go, self.TaskFubenList);
                            UITaskFubenItemComponent uITaskFubenItemComponent = self.AddChild<UITaskFubenItemComponent, GameObject>(go);
                            uITaskFubenItemComponent.OnInitData((int npcType, int fubenId) => { self.OnClickFubenItem(npcType, fubenId); }, npcConfig.NpcType, fubenList[i]);
                        }
                    }
                    break;
                case 3://循环任务 周任务 支线任务 藏宝图任务
                    self.RequestWeeklyTask().Coroutine();
                    break;
                case 4: //魔能老人
                    int costItemID = 12000006;
                    long itemNum = self.ZoneScene().GetComponent<BagComponent>().GetItemNumber(costItemID);
                    self.EnergySkill.SetActive(true);
                    //获取
                    self.Obj_Lab_MoNnengHint.GetComponent<Text>().text = ItemConfigCategory.Instance.Get(costItemID).ItemName + "  " + itemNum + "/" + 5;
                    break;
                case 5://补偿大师
                    self.TaskFubenList.SetActive(true);
                    UICommonHelper.DestoryChild(self.TaskFubenList);
                    AccountInfoComponent accountInfo = self.ZoneScene().GetComponent<AccountInfoComponent>();
                    int buchangNumber = BuChangHelper.ShowNewBuChang(accountInfo.PlayerInfo, accountInfo.MyId);
                    if (buchangNumber > 0)
                    {
                        GameObject goitem = GameObject.Instantiate(self.UITaskFubenItem);
                        goitem.SetActive(true);
                        UICommonHelper.SetParent(goitem, self.TaskFubenList);
                        UIBuChangItemComponent uIBuChangItem = self.AddChild<UIBuChangItemComponent, GameObject>(goitem);
                        uIBuChangItem.OnInitUI_2((long userid) => { self.OnClickBuChangItem(userid); }, buchangNumber);
                    }
                    else
                    {
                        for (int i = 0; i < accountInfo.PlayerInfo.DeleteUserList.Count; i++)
                        {
                            GameObject goitem = GameObject.Instantiate(self.UITaskFubenItem);
                            goitem.SetActive(true);
                            UICommonHelper.SetParent(goitem, self.TaskFubenList);
                            UIBuChangItemComponent uIBuChangItem = self.AddChild<UIBuChangItemComponent, GameObject>(goitem);
                            uIBuChangItem.OnInitUI((long userid) => { self.OnClickBuChangItem(userid); }, accountInfo.PlayerInfo.DeleteUserList[i]);
                        }
                    }
                    break;
                case 6: //节日使者
                    int activityId = ActivityHelper.GetJieRiActivityId();
                    ActivityComponent activityComponent = self.ZoneScene().GetComponent<ActivityComponent>();
                    self.ButtonJieRiReward.SetActive(activityId > 0 && !activityComponent.ActivityReceiveIds.Contains(activityId));

                    if (activityId == 0)
                    {
                        int nextid = ActivityHelper.GetNextRiActivityId();
                        ActivityConfig activityConfig = ActivityConfigCategory.Instance.Get(nextid);
                        string[] riqi = activityConfig.Par_1.Split(';');
                        string speek = self.Lab_NpcSpeak.GetComponent<Text>().text;
                        self.Lab_NpcSpeak.GetComponent<Text>().text = $"{speek} 下次领取时间:{riqi[0]}月{riqi[1]}日 {activityConfig.Par_4}";
                    }
                    break;
                case 8:  //经验兑换
                    self.ButtonExpDuiHuan.SetActive(true);
                    break;
                case 9:
                    self.ButtonPetFragment.SetActive(true);
                    break;
                case 10: //神秘之门
                    self.ButtonMystery.SetActive(true);
                    break;
                default:  
                    self.ScrollView1.SetActive(true);
                    self.UpdataTask();
                    break;
            }

            self.ShowGuide().Coroutine();
        }

        public static async ETTask ShowGuide(this UITaskGetComponent self)
        {
            await  TimerComponent.Instance.WaitAsync(100);
            if (self.IsDisposed)
            {
                return;
            }
            self.ZoneScene().GetComponent<GuideComponent>().OnTrigger(GuideTriggerType.OpenUI, UIType.UITaskGet);
        }

        public static void OnButtonWeeklyCommit(this UITaskGetComponent self)
        {
            self.OnBtn_CommitTask().Coroutine();
        }

        public static void OnButtonWeeklyGet(this UITaskGetComponent self)
        {
            NetHelper.SendGetTask(self.ZoneScene(), self.TaskId).Coroutine();
        }

        public static void OnButtonFragmentHuan(this UITaskGetComponent self)
        {
            if (!PetHelper.IsShenShouFull(self.ZoneScene().GetComponent<PetComponent>().RolePetInfos))
            {
                FloatTipManager.Instance.ShowFloatTip("神兽未满不能对话！");
                return;
            }

            if (self.ZoneScene().GetComponent<BagComponent>().GetItemNumber(10000136) < 1)
            {
                FloatTipManager.Instance.ShowFloatTip("神兽碎片不足！");
                return;
            }

            ItemConfig itemConfig = ItemConfigCategory.Instance.Get(ConfigHelper.PetFramgeItemId);
            PopupTipHelp.OpenPopupTip( self.ZoneScene(), "碎片兑换", $"是否消耗一个神兽碎片兑换一个{itemConfig.ItemName}", ()=>
            {
                self.RequestFramegeDuiHuan().Coroutine();
            }, null).Coroutine();
        }

        public static async ETTask RequestFramegeDuiHuan(this UITaskGetComponent self)
        {
            C2M_PetFragmentDuiHuan c2M_PetDui = new C2M_PetFragmentDuiHuan();
            M2C_PetFragmentDuiHuan m2C_PetDui = (M2C_PetFragmentDuiHuan)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(c2M_PetDui);
        }

        public static async ETTask RequestWeeklyTask(this UITaskGetComponent self)
        {
            long instanceId = self.InstanceId;
            C2A_ActivityInfoRequest  request = new C2A_ActivityInfoRequest() { ActivityType = 1 };
            A2C_ActivityInfoResponse response = (A2C_ActivityInfoResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request);
            if (instanceId != self.InstanceId)
            {
                return;
            }
            if (response.Error != ErrorCode.ERR_Success)
            {
                return;   
            }
            self.WeekTaskId = int.Parse(response.ActivityContent);

            bool update = self.UpdataTask();
            self.ScrollView1.SetActive(update);
            //if (response.ActivityContent == "0")
            //{
            //    return;
            //}
            //AccountInfoComponent accountInfoComponent = self.ZoneScene().GetComponent<AccountInfoComponent>();
            //if (!GMHelp.GmAccount.Contains(accountInfoComponent.Account))
            //{
            //    return;
            //}
            //self.UIWeeklyTask.SetActive(true);
            //TaskComponent taskComponent = self.ZoneScene().GetComponent<TaskComponent>();
            //List<TaskPro> taskPros = taskComponent.GetTaskTypeList(TaskTypeEnum.Weekly);
            //TaskPro taskPro = taskPros.Count > 0 ? taskPros[0] : null;
            //self.ButtonWeeklyCommit.SetActive(taskPro != null && taskPro.taskStatus == (int)TaskStatuEnum.Completed);
            //self.ButtonWeeklyGet.SetActive(taskPro == null);
            //self.TaskId = int.Parse(response.ActivityContent);
            //self.UIWeeklyTaskItem.SetActive(true);
            //self.UIWeeklyTaskItem.transform.Find("TextFubenName").GetComponent<Text>().text = TaskConfigCategory.Instance.Get(self.TaskId).TaskName;
        }

        public static  void OnClickBuChangItem(this UITaskGetComponent self, long userid)
        {
            PopupTipHelp.OpenPopupTip(self.ZoneScene(), "补偿大师", "请求补偿",
            () =>
            {
                self.RequestBuChangItem(userid).Coroutine();
            }).Coroutine();
        }

        public static async ETTask RequestBuChangItem(this UITaskGetComponent self, long userid)
        {
            C2M_BuChangeRequest request = new C2M_BuChangeRequest() { BuChangId = userid };
            M2C_BuChangeResponse response = (M2C_BuChangeResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request);
            AccountInfoComponent accountInfoComponent = self.ZoneScene().GetComponent<AccountInfoComponent>();
            accountInfoComponent.PlayerInfo = response.PlayerInfo;

            UIHelper.Remove(self.ZoneScene(), UIType.UITaskGet);
        }

        public static void OnClickFubenItem(this UITaskGetComponent self,  int npcType, int configId)
        {
            if (configId == 0)
            {
                return;
            }
            if (npcType == 1)
            {
                PopupTipHelp.OpenPopupTip(self.ZoneScene(), "神兽兑换", ItemViewHelp.ShowDuiHuanPet(configId),
                   () =>
                   {
                       self.ReqestPetDuiHuan(configId).Coroutine();
                   }).Coroutine();
            }
            if (npcType == 2)
            {
                SceneConfig sceneConfig = SceneConfigCategory.Instance.Get(configId);
                string desStr = "是否进入" + sceneConfig.Name + "?";
                if (sceneConfig.DayEnterNum >= 1)
                {
                    desStr += "\n提示:每天只能进入" + sceneConfig.DayEnterNum + "次";
                }
                
                PopupTipHelp.OpenPopupTip(self.ZoneScene(), "进入地图", desStr,
                    () =>
                    {
                        self.RequestEnterFuben(configId).Coroutine();
                    }).Coroutine();
            }
        }

        public static async ETTask ReqestPetDuiHuan(this UITaskGetComponent self, int configId)
        {
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            PetComponent petComponent = self.ZoneScene().GetComponent<PetComponent>();
            int lv = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.Lv;
            
            if (PetHelper.GetBagPetNum(petComponent.RolePetInfos) >= ComHelp.GetPetMaxNumber(unit, lv) )
            {
                FloatTipManager.Instance.ShowFloatTip("已达到最大宠物数量！");
                return;
            }
            C2M_PetDuiHuanRequest   request = new C2M_PetDuiHuanRequest() { OperateId = configId };
            M2C_PetDuiHuanResponse response = (M2C_PetDuiHuanResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request);
            if (response.RolePetInfo == null)
            {
                return;
            }
        }

        public static async ETTask RequestEnterFuben(this UITaskGetComponent self, int sceneId)
        {
            SceneConfig sceneConfig = SceneConfigCategory.Instance.Get(sceneId);
            int sceneType = sceneConfig.MapType;
            if (sceneType == SceneTypeEnum.Arena)
            {
                Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
                if (unit.GetComponent<NumericComponent>().GetAsLong(NumericType.ArenaNumber)>0)
                {
                    FloatTipManager.Instance.ShowFloatTip("次数不足！");
                    return;
                }

                if (!FunctionHelp.IsInTime(1031))
                {
                    FloatTipManager.Instance.ShowFloatTip("不在活动时间内！");
                    return;
                }
            }
            int errorCode = await EnterFubenHelp.RequestTransfer(self.ZoneScene(), sceneType, sceneId);
            if (errorCode == ErrorCode.ERR_Success && !self.IsDisposed)
            { 
                UIHelper.Remove(self.ZoneScene(), UIType.UITaskGet);
            }
        }

        public static async ETTask RequestEnergySkill(this UITaskGetComponent self)
        {
            Actor_FubenEnergySkillRequest c2M_PaiMaiBuyRequest = new Actor_FubenEnergySkillRequest() {   };
            Actor_FubenEnergySkillResponse m2C_PaiMaiBuyResponse = (Actor_FubenEnergySkillResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(c2M_PaiMaiBuyRequest);

            if (m2C_PaiMaiBuyResponse.Error == 0)
            {
                UIHelper.Remove(self.DomainScene(), UIType.UITaskGet);
            }
            else {
                ErrorHelp.Instance.ErrorHint(ErrorCode.ERR_ItemNotEnoughError);
            }
        }

        public static List<int> GetAddtionTaskId(this UITaskGetComponent self, int npcId)
        {
            List<int> addTaskids = new List<int>();
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            NumericComponent numericComponent = unit.GetComponent<NumericComponent>();
            TaskComponent taskComponent = self.ZoneScene().GetComponent<TaskComponent>();
            if (npcId == 20000024)   //任务使者：赛利
            {
                int weeklyTask = self.WeekTaskId;
                if (weeklyTask > 0)
                {
                    if (!taskComponent.RoleComoleteTaskList.Contains(weeklyTask) 
                     && taskComponent.GetTaskById(weeklyTask) == null)
                    {
                        addTaskids.Add(weeklyTask);
                    }
                }

                int taskLoopid = numericComponent.GetAsInt(NumericType.LoopTaskID);
                if (taskLoopid > 0 && taskComponent.GetTaskById(taskLoopid) == null)
                {
                    addTaskids.Add(taskLoopid);
                }
            }
            if (npcId == 20000102)   //家族任务
            {
                int taskLoopid = numericComponent.GetAsInt(NumericType.UnionTaskId);
                if (taskLoopid > 0 && taskComponent.GetTaskById(taskLoopid) == null )
                {
                    addTaskids.Add(taskLoopid);
                }
            }
            return addTaskids;
        }

        //如果当前有任务接取了还没完成，则什么都不显示
        public static bool UpdataTask(this UITaskGetComponent self)
        {
            for (int i = 0; i < self.TaskUIList.Count; i++)
            {
                self.TaskUIList[i].Dispose();
            }
            self.TaskUIList.Clear();
            TaskComponent taskComponent = self.ZoneScene().GetComponent<TaskComponent>();

            //获取npc任务
            List<int> taskids = new List<int>();

            List<TaskPro> taskProCompleted = taskComponent.GetCompltedTaskByNpc(self.NpcID);
            for (int i = 0; i < taskProCompleted.Count; i++)
            {
                taskids.Add(taskProCompleted[i].taskID);
            }

            taskids.AddRange(taskComponent.GetOpenTaskIds(self.NpcID));
            taskids.AddRange(self.GetAddtionTaskId(self.NpcID));

            //bool haveloopids = false;
            //for (int i = 0; i < taskids.Count; i++)
            //{
            //    if (TaskConfigCategory.Instance.Get(taskids[i]).TaskType == TaskTypeEnum.EveryDay)
            //    {
            //        haveloopids = true;
            //        break;
            //    }
            //}
            //Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());    
            //if (taskComponent.IsHaveTaskCountryLoop() && taskComponent.GetTaskTypeList(TaskTypeEnum.EveryDay).Count == 0 && !haveloopids)
            //{
            //    FloatTipManager.Instance.ShowFloatTip("获取赏金任务失败，请重新登录！");
            //}

            //给予任务
            List<TaskPro> taskPros = taskComponent.RoleTaskList;
            for (int i = 0; i < taskPros.Count; i++)
            {
                if (taskids.Contains(taskPros[i].taskID))
                {
                    continue;
                }
                TaskConfig taskConfig = TaskConfigCategory.Instance.Get(taskPros[i].taskID );
                if ((taskConfig.TargetType == (int)TaskTargetType.GiveItem_10 || taskConfig.TargetType == (int)TaskTargetType.GivePet_25)
                    && taskConfig.CompleteNpcID == self.NpcID)
                {
                    taskids.Add(taskPros[i].taskID);
                }
            }

            //当前没有接取任务
            
            for (int i = 0; i < taskids.Count; i++)
            {
                GameObject go = GameObject.Instantiate(self.UITaskGetItem);
                go.SetActive(true);
                UICommonHelper.SetParent(go, self.TaskListNode);

                UI uiitem = self.AddChild<UI, string, GameObject>("UITaskItem_" + i, go);
                UITaskGetItemComponent taskItemComponent = uiitem.AddComponent<UITaskGetItemComponent>();
                taskItemComponent.InitData(taskids[i]);
                taskItemComponent.SetClickHandler((int taskid) => { self.OnSelectTaskHandler(taskid); });

                self.TaskUIList.Add(uiitem);
            }

            if (taskids.Count > 0)
            {
                self.TaskUIList[0].GetComponent<UITaskGetItemComponent>().OnClickSelectTask();
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void OnSelectTaskHandler(this UITaskGetComponent self, int taskid)
        {
            self.TaskId = taskid;

            for (int i = 0; i < self.TaskUIList.Count; i++)
            {
                self.TaskUIList[i].GetComponent<UITaskGetItemComponent>().SetSelected(taskid);
            }

            TaskPro taskPro = self.ZoneScene().GetComponent<TaskComponent>().GetTaskById(taskid);
            TaskConfig taskConfig = TaskConfigCategory.Instance.Get(taskid);
            if (taskConfig.TargetType == (int)TaskTargetType.GiveItem_10
                || taskConfig.TargetType == (int)TaskTargetType.GivePet_25)
            {
                self.ButtonGiveTask.SetActive(taskPro != null);
                self.ButtonGet.SetActive(taskPro == null);
            }
            else
            {
                bool isCompleted = taskPro != null && taskPro.taskStatus == (int)TaskStatuEnum.Completed;
                self.BtnCommitTask1.SetActive(isCompleted);
                self.ButtonGiveTask.SetActive(false);
                self.ButtonGet.SetActive(!isCompleted);
            }
        }

        public static void OnButtonMystery(this UITaskGetComponent self)
        {
            int sceneId = self.ZoneScene().GetComponent<MapComponent>().SceneId;
            int chapterid = DungeonConfigCategory.Instance.DungeonToChapter[sceneId];
            int mysterDungeonid = DungeonSectionConfigCategory.Instance.GetMysteryDungeon(chapterid);
            EnterFubenHelp.RequestTransfer(self.ZoneScene(), SceneTypeEnum.LocalDungeon, mysterDungeonid, 0, "0").Coroutine();
            UIHelper.Remove(self.ZoneScene(), UIType.UITaskGet);
        }

        /// <summary>
        /// 给予道具任务
        /// </summary>
        /// <param name="self"></param>
        public static async ETTask OnButtonGiveTask(this UITaskGetComponent self)
        {
            //打开界面选择道具。
            //给予道具和给予宠物界面分开
            TaskConfig taskConfig = TaskConfigCategory.Instance.Get(self.TaskId);
            if (taskConfig.TargetType == (int)TaskTargetType.GivePet_25)
            {
                ///给予宠物界面
                ///参考一下宠物界面 不能放生的宠物此处也不同提交。 添加道具检测一遍。  
                ///加个任务测试
                ////TaskHelper.IsTaskGivePet();
            }
            else
            {
                UI ui = await UIHelper.Create(self.ZoneScene(), UIType.UIGiveTask);
                ui.GetComponent<UIGiveTaskComponent>().InitTask(self.TaskId);
                UIHelper.Remove(self.ZoneScene(), UIType.UITaskGet);
            }
        }

        public static void OnButtonGetTask(this UITaskGetComponent self)
        {
            if (self.TaskId == 0)
            {
                FloatTipManager.Instance.ShowFloatTip("请选择一个任务");
                return;
            }

            NetHelper.SendGetTask(self.ZoneScene(), self.TaskId).Coroutine();
        }

        public static async ETTask OnBtn_CommitTask(this UITaskGetComponent self)
        {
            long instanceid = self.InstanceId;
            Scene zoneScene = self.ZoneScene();
            int errorCode =  await zoneScene.GetComponent<TaskComponent>().SendCommitTask(self.TaskId, 0);
            if (errorCode == ErrorCode.ERR_Success)
            {
                FunctionEffect.GetInstance().PlaySelfEffect(UnitHelper.GetMyUnitFromZoneScene(zoneScene), 91000201) ;
            }
            if (instanceid != self.InstanceId)
            {
                return;
            }
            self.OnTaskGet();
        }

    }

}
