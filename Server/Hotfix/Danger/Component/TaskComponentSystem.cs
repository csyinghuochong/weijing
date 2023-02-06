using System.Collections.Generic;

namespace ET
{

    [ObjectSystem]
    public class TaskComponentAwakeSystem : AwakeSystem<TaskComponent>
    {
        public override void Awake(TaskComponent self)
        {
            if (self.RoleTaskList.Count == 0)
            {
                int initTask = int.Parse(GlobalValueConfigCategory.Instance.Get(1).Value);
                self.RoleTaskList.Add(new TaskPro() { taskID = initTask, TrackStatus = 1, taskStatus = (int)TaskStatuEnum.Completed, taskTargetNum_1 = 1});
            }
        }
    }

    [ObjectSystem]
    public class TaskComponentDestroySystem : DestroySystem<TaskComponent>
    {
        public override void Destroy(TaskComponent self)
        {
        }
    }

    [ObjectSystem]
    public class TaskComponentDeserializeSystem : DeserializeSystem<TaskComponent>
    {
        public override void Deserialize(TaskComponent self)
        {
        }
    }

    public static class TaskComponentSystem
    {

        public static void Check(this TaskComponent self)
        {
            self.OnLineTime(1);
        }

        public static bool IsTaskComplete(this TaskComponent self, int taskid)
        {
            return self.RoleComoleteTaskList.IndexOf(taskid) >= 0;
        }

        //任务追踪
        public static int TaskTrack(this TaskComponent self, C2M_TaskTrackRequest request)
        {
            for (int i = 0; i < self.RoleTaskList.Count; i++)
            {
                if (self.RoleTaskList[i].taskID == request.TaskId)
                {
                    self.RoleTaskList[i].TrackStatus = request.TrackStatus;
                }
            }
            return ErrorCore.ERR_Success;
        }

        //对话之类的任务由客户端触发完成
        public static void  OnTaskNotice(this TaskComponent self, C2M_TaskNoticeRequest request)
        {
            int taskid = request.TaskId;
            for (int i = 0; i < self.RoleTaskList.Count; i++)
            {
                if (self.RoleTaskList[i].taskID == taskid)
                {
                    self.RoleTaskList[i].taskTargetNum_1 = 1;
                    self.RoleTaskList[i].taskStatus = (int)TaskStatuEnum.Completed;
                }
            }
        }

        /// <summary>
        /// 放弃任务
        /// </summary>
        /// <param name="self"></param>
        /// <param name="taskId"></param>
        public static void OnRecvGiveUpTask(this TaskComponent self, int taskId)
        {
            for (int i = self.RoleTaskList.Count - 1; i >= 0; i--)
            {
                if (self.RoleTaskList[i].taskID == taskId)
                {
                    self.RoleTaskList.RemoveAt(i);
                    break;
                }
            }
        }

        /// <summary>
        /// 接取任务
        /// </summary>
        /// <param name="self"></param>
        /// <param name="request"></param>
        /// <param name="response"></param>
        /// <returns></returns>
        public static TaskPro OnGetTask(this TaskComponent self, int taskId)
        {
            Unit unit = self.GetParent<Unit>();
            bool canget = FunctionHelp.CheckTaskOn(unit, TaskConfigCategory.Instance.Get(taskId));
            if (!canget)
            {
                Log.Warning($"OnGetTask_1 {unit.DomainZone()} {unit.Id} {taskId}");
                return null;
            }
            if (self.IsHaveTask(taskId))
            {
                Log.Warning($"OnGetTask_2 {unit.DomainZone()} {unit.Id} {taskId}");
                return null;
            }

            TaskPro taskPro = self.CreateTask(taskId);
            self.RoleTaskList.Add(taskPro);
            return taskPro;
        }

        public static TaskPro OnGetLoopTask(this TaskComponent self, int taskId)
        {
            TaskPro taskPro = self.CreateTask(taskId);
            self.RoleTaskList.Add(taskPro);
            return taskPro;
        }

        public static List<TaskPro> GetTaskList(this TaskComponent self, int taskType)
        { 
            List<TaskPro> taskPros = new List<TaskPro>();
            for (int i = 0; i < self.RoleTaskList.Count; i++)
            {
                TaskPro taskPro = self.RoleTaskList[i];
                TaskConfig taskConfig = TaskConfigCategory.Instance.Get(taskPro.taskID);
                if (taskConfig.TaskType!= (int)taskType)
                {
                    continue;
                }
                taskPros.Add(taskPro);
            }
            return taskPros;
        }

        public static bool IsHaveTask(this TaskComponent self, int taskId)
        {
            if (self.RoleComoleteTaskList.Contains(taskId))
            {
                return true;
            }
            for (int i = 0; i < self.RoleTaskList.Count; i++)
            {
                if (self.RoleTaskList[i].taskID == taskId)
                {
                    return true;
                }
            }
            return false;
        }

        public static TaskPro CreateTask(this TaskComponent self, int taskid)
        {
            Unit unit = self.GetParent<Unit>();
            TaskConfig taskConfig = TaskConfigCategory.Instance.Get(taskid);
            TaskPro taskPro = new TaskPro();
            taskPro.taskID = taskid;

            switch (taskConfig.TargetType)
            {
                case (int)TaskTargetType.KillMonsterID_1:
                    taskPro.taskTargetNum_1 = unit.GetComponent<UserInfoComponent>().GetReviveTime(taskConfig.Target[0]) > 0?1 : 0;
                    break;
                case (int)TaskTargetType.ItemID_Number_2:
                    for (int i = 0; i < taskConfig.Target.Length; i++)
                    {
                        if (i == 0)
                        {
                            taskPro.taskTargetNum_1 = (int)self.GetParent<Unit>().GetComponent<BagComponent>().GetItemNumber(taskConfig.Target[i]);
                        }
                        if (i == 1)
                        {
                            taskPro.taskTargetNum_2 = (int)self.GetParent<Unit>().GetComponent<BagComponent>().GetItemNumber(taskConfig.Target[i]);
                        }
                    }
                    break;
                case(int)TaskTargetType.LookingFor_3:
                    taskPro.taskTargetNum_1 = 1;
                    break;
                case (int)(int)TaskTargetType.PlayerLv_4:
                    taskPro.taskTargetNum_1 = self.GetParent<Unit>().GetComponent<UserInfoComponent>().UserInfo.Lv;
                    break;
                case (int)TaskTargetType.ChangeOcc_8:
                    taskPro.taskTargetNum_1 = self.GetParent<Unit>().GetComponent<UserInfoComponent>().UserInfo.OccTwo > 0 ? 1 : 0;
                    break;
                default:
                    taskPro.taskTargetNum_1 = 0;
                    break;
            }

            bool completed = self.IsCompleted(taskPro, taskConfig);
            taskPro.taskStatus = completed ? (int)TaskStatuEnum.Completed : (int)TaskStatuEnum.Accepted;
            if (self.GetTrackTaskList().Count < 3)
            {
                taskPro.TrackStatus = 1;
            }
            return taskPro;
        }

        public static bool IsCompleted(this TaskComponent self, TaskPro taskPro, TaskConfig taskConfig)
        {
            for (int i = 0; i < taskConfig.Target.Length; i++)
            {
                if (i == 0 && taskConfig.TargetValue[i] > taskPro.taskTargetNum_1)
                {
                    return false;
                }
                if (i == 1 && taskConfig.TargetValue[i] > taskPro.taskTargetNum_2)
                {
                    return false;
                }
            }
            return true;
        }

        public static void OnGMGetTask(this TaskComponent self, int taskid)
        {
            for (int i = 0; i < self.RoleTaskList.Count; i++)
            {
                if (self.RoleTaskList[i].taskID == taskid)
                {
                    return;
                }
            }

            TaskPro taskPro = self.CreateTask(taskid);
            self.RoleTaskList.Add(taskPro);

            M2C_TaskUpdate m2C_TaskUpdate = self.M2C_TaskUpdate;
            m2C_TaskUpdate.RoleTaskList = self.RoleTaskList;
            MessageHelper.SendToClient(self.GetParent<Unit>(), m2C_TaskUpdate);
        }

        public static List<TaskPro> GetTrackTaskList(this TaskComponent self)
        {
            List<TaskPro> taskPros = new List<TaskPro>();
            for (int i = self.RoleTaskList.Count - 1; i >= 0; i--)
            {
                if (self.RoleTaskList[i].TrackStatus == 1)
                {
                    taskPros.Add(self.RoleTaskList[i]);
                }
            }
            return taskPros;
        }

        //领取奖励
        public static int OnCommitTask(this TaskComponent self, int taskid)
        {

            TaskConfig taskConfig = TaskConfigCategory.Instance.Get(taskid);
            BagComponent bagComponent = self.GetParent<Unit>().GetComponent<BagComponent>();
            List<RewardItem> rewardItems = TaskHelp.GetTaskRewards(taskid, taskConfig);
            if (bagComponent.GetSpaceNumber() < rewardItems.Count)
            {
                return ErrorCore.ERR_BagIsFull;
            }

            bool have = false;
            for (int i = self.RoleTaskList.Count - 1; i >= 0; i--)
            {
                if (self.RoleTaskList[i].taskID == taskid)
                {
                    have = true;
                    self.RoleTaskList.RemoveAt(i);
                }
            }
            if (!have)
            {
                return ErrorCore.ERR_TaskCommited;
            }
            if (!self.RoleComoleteTaskList.Contains(taskid))
            {
                self.RoleComoleteTaskList.Add(taskid);
            }
            
            int TaskExp = taskConfig.TaskExp;
            int TaskCoin = taskConfig.TaskCoin;

            UserInfoComponent unitInfoComponent = self.GetParent<Unit>().GetComponent<UserInfoComponent>();
            unitInfoComponent.UpdateRoleData(UserDataType.Exp, TaskExp.ToString());
            unitInfoComponent.UpdateRoleMoneyAdd(UserDataType.Gold, TaskCoin.ToString(), true, ItemGetWay.TaskReward);
          
            bagComponent.OnAddItemData(rewardItems, string.Empty, $"{ItemGetWay.TaskReward}_{TimeHelper.ServerNow()}");
            if (taskConfig.TargetType == (int)TaskTargetType.ItemID_Number_2)
            {
                bagComponent.OnCostItemData($"{taskConfig.Target[0]};{taskConfig.TargetValue[0]}");
            }
            if (taskConfig.TaskType == TaskTypeEnum.EveryDay)
            {
                self.TriggerTaskCountryEvent(TaskCountryTargetType.TaskLoop_14, 0, 1);
            }
            return ErrorCore.ERR_Success;
        }

        /// <summary>
        /// 转职
        /// </summary>
        /// <param name="self"></param>
        public static void OnChangeOccTwo(this TaskComponent self)
        {
            self.TriggerTaskEvent(TaskTargetType.ChangeOcc_8, 0, 1);
        }

        /// <summary>
        /// 制造
        /// </summary>
        public static void OnMakeItem(this TaskComponent self)
        {
            self.TriggerTaskCountryEvent(TaskCountryTargetType.MakeItem_6, 0, 1);
        }

        /// <summary>
        /// 宠物洗练
        /// </summary>
        /// <param name="self"></param>
        public static void OnPetXiLian(this TaskComponent self)
        {
            self.TriggerTaskCountryEvent(TaskCountryTargetType.PetXiLian_7, 0, 1);
        }

        /// <summary>
        /// 获得宠物
        /// </summary>
        /// <param name="self"></param>
        public static void OnGetPet(this TaskComponent self)
        {
            self.TriggerTaskCountryEvent(TaskCountryTargetType.GetPet_8, 0, 1);
        }

        /// <summary>
        /// 道具洗练
        /// </summary>
        /// <param name="self"></param>
        public static void OnEquipXiLian(this TaskComponent self, int times)
        {
            self.TriggerTaskCountryEvent(TaskCountryTargetType.EquipXiLian_9, 0, times);
        }

        /// <summary>
        /// 在线时长，暂时一分钟触发一次
        /// </summary>
        /// <param name="self"></param>
        public static void OnLineTime(this TaskComponent self, int time)
        {
            self.TriggerTaskCountryEvent(TaskCountryTargetType.OnLineTime_10, 0, 1);

            if (self.DomainScene().GetComponent<MapComponent>().SceneTypeEnum == SceneTypeEnum.Battle)
            {
                self.TriggerTaskCountryEvent(TaskCountryTargetType.BattleExist_103, 0, 1);
            }
        }

        /// <summary>
        /// 道具回收
        /// </summary>
        /// <param name="self"></param>
        public static void OnItemHuiShow(this TaskComponent self)
        {
            self.TriggerTaskCountryEvent(TaskCountryTargetType.ItemHuiShou_11, 0, 1);
        }

        /// <summary>
        /// 消耗金币
        /// </summary>
        /// <param name="self"></param>
        public static void OnCostCoin(this TaskComponent self, int costCoin)
        {
            if (costCoin >= 0)
                return;
            self.TriggerTaskCountryEvent(TaskCountryTargetType.CostCoin_5, 0, costCoin * -1);
        }

        /// <summary>
        /// 通关副本
        /// </summary>
        /// <param name="self"></param>
        /// <param name="difficulty"></param>
        /// <param name="chapterid"></param>
        /// <param name="star"></param>
        public static void OnPassFuben(this TaskComponent self, int difficulty, int chapterid, int star)
        {
            self.TriggerTaskEvent(TaskTargetType.PassFubenID_7, chapterid, 1);
            if ((int)difficulty >= (int)FubenDifficulty.TiaoZhan)  //挑战
            {
                self.TriggerTaskEvent(TaskTargetType.PassTianZhanFubenID_111, chapterid, 1);
            }
            if ((int)difficulty >= (int)FubenDifficulty.DiYu)  //地狱
            {
                self.TriggerTaskEvent(TaskTargetType.PassDiYuFubenID_112, chapterid, 1);
            }
        }

        public static void OnWinCampBattle(this TaskComponent self)
        {
            self.TriggerTaskCountryEvent(TaskCountryTargetType.BattleWin_101, 0, 1);
        }

        public static void OnPassTeamFuben(this TaskComponent self)
        {
            self.TriggerTaskCountryEvent(TaskCountryTargetType.PassTeamFuben_4, 0, 1);
        }

        //击杀怪物可触发多种类型的任务
        public static void OnKillUnit(this TaskComponent self, Unit bekill, int sceneType)
        {
            if (bekill == null || bekill.IsDisposed)
                return;

            UnitInfoComponent unitInfoComponent = bekill.GetComponent<UnitInfoComponent>();
            if (bekill.Type == UnitType.Player && sceneType == SceneTypeEnum.Battle)
            {
                self.TriggerTaskCountryEvent(TaskCountryTargetType.BattleKillPlayer_102, 0, 1);
            }
            if (bekill.Type == UnitType.Monster)
            {
                int unitconfigId = bekill.ConfigId;
                MonsterConfig monsterConfig = MonsterConfigCategory.Instance.Get(unitconfigId);
                bool isBoss = monsterConfig.MonsterType == (int)MonsterTypeEnum.Boss;
                MapComponent mapComponent = self.DomainScene().GetComponent<MapComponent>();
                int fubenDifficulty = FubenDifficulty.None;
                if (mapComponent.SceneTypeEnum == (int)SceneTypeEnum.CellDungeon)
                {
                    fubenDifficulty = self.GetParent<Unit>().DomainScene().GetComponent<CellDungeonComponent>().FubenDifficulty;
                }

                self.TriggerTaskEvent(TaskTargetType.KillMonsterID_1, unitconfigId, 1);
                self.TriggerTaskEvent(TaskTargetType.KillMonster_5, 0, 1);
                self.TriggerTaskCountryEvent(TaskCountryTargetType.KillMonster_2, 0, 1);

                if (isBoss)
                {
                    self.TriggerTaskEvent(TaskTargetType.KillBOSS_6, 0, 1);
                    self.TriggerTaskCountryEvent(TaskCountryTargetType.KillBoss_3, 0, 1);
                }

                if ((int)fubenDifficulty >= (int)FubenDifficulty.DiYu)  //地狱
                {
                    self.TriggerTaskEvent(TaskTargetType.KillTiaoZhanMonsterID_101, unitconfigId, 1);
                    self.TriggerTaskEvent(TaskTargetType.KillDiYuMonsterID_102, unitconfigId, 1);
                    self.TriggerTaskEvent(TaskTargetType.KillTianZhanMonsterNumber_121, 0, 1);
                    self.TriggerTaskEvent(TaskTargetType.KillDiYuMonsterNumber_122, 0, 1);

                    if (isBoss)
                    {
                        self.TriggerTaskEvent(TaskTargetType.KillTianZhanBossNumber_131, 0, 1);
                        self.TriggerTaskEvent(TaskTargetType.KillDiYuBossNumber_132, 0, 1);
                    }
                }
                if ((int)fubenDifficulty >= (int)FubenDifficulty.TiaoZhan) //挑战
                {
                    self.TriggerTaskEvent(TaskTargetType.KillTiaoZhanMonsterID_101, unitconfigId, 1);
                    self.TriggerTaskEvent(TaskTargetType.KillTianZhanMonsterNumber_121, 0, 1);

                    if (isBoss)
                    {
                        self.TriggerTaskEvent(TaskTargetType.KillTianZhanBossNumber_131, 0, 1);
                    }
                }
            }
        }

        //等级更新
        public static void OnUpdateLevel(this TaskComponent self, int rolelv)
        {
            self.TriggerTaskEvent(TaskTargetType.PlayerLv_4, 0, rolelv);
        }

        //登录
        public static void OnLogin(this TaskComponent self)
        {
            if (self.TaskCountryList.Count == 0)
            {
                Log.Debug($"矫正活跃任务:  {self.GetParent<Unit>().Id} {self.TaskCountryList.Count}");
                self.OnZeroClockUpdate(false);
            }
            for (int i = self.RoleTaskList.Count - 1; i >=0; i--)
            { 
                if (!TaskConfigCategory.Instance.Contain(self.RoleTaskList[i].taskID))
                {
                    self.RoleTaskList.RemoveAt(i);
                }
            }
            //触发一下搜集道具类型的任务
            for (int i = 0; i < self.RoleTaskList.Count; i++)
            {
                TaskPro taskPro = self.RoleTaskList[i];
                TaskConfig taskConfig = TaskConfigCategory.Instance.Get(taskPro.taskID);
                if ((TaskTargetType)taskConfig.TargetType == TaskTargetType.ItemID_Number_2)
                {
                    self.TriggerTaskEvent(TaskTargetType.ItemID_Number_2, taskConfig.Target[0], 0);
                    continue;
                }
                if ((TaskTargetType)taskConfig.TargetType == TaskTargetType.PlayerLv_4)
                {
                    int roleLv = self.GetParent<Unit>().GetComponent<UserInfoComponent>().UserInfo.Lv;
                    self.TriggerTaskEvent(TaskTargetType.PlayerLv_4, taskConfig.Target[0], roleLv);
                    continue;
                }
            }

            NumericComponent numericComponent = self.GetParent<Unit>().GetComponent<NumericComponent>();
            int giveUpId = numericComponent.GetAsInt(NumericType.TaskLoopGiveId);
            if (giveUpId > 0 && self.GetTaskList(TaskTypeEnum.EveryDay).Count == 0
                && self.RoleComoleteTaskList.Contains(giveUpId))
            {
                numericComponent.Set(NumericType.TaskLoopGiveId,0, false);
            }

            self.TriggerTaskCountryEvent(  TaskCountryTargetType.Login_1, 0, 1, false );
        }

        //收集道具
        public static void OnGetItem(this TaskComponent self, int itemId)
        {
            self.TriggerTaskEvent(TaskTargetType.ItemID_Number_2, itemId, 0);
        }

        public static void TriggerTaskEvent(this TaskComponent self, TaskTargetType targetType, int targetTypeId, int targetValue)
        {
            bool updateTask = false;

            for (int i = 0; i < self.RoleTaskList.Count; i++)
            {
                TaskPro taskPro = self.RoleTaskList[i];
                TaskConfig taskConfig = TaskConfigCategory.Instance.Get(taskPro.taskID);
                if ((TaskTargetType)taskConfig.TargetType != targetType)
                {
                    continue;
                }
                if (taskPro.taskStatus == (int)TaskStatuEnum.Completed)
                {
                    continue;
                }
       
                for (int t = 0; t < taskConfig.Target.Length; t++)
                {
                    if (taskConfig.Target[t] != targetTypeId)
                    {
                        continue;
                    }

                    updateTask = true;
                    if (targetType == TaskTargetType.ItemID_Number_2)
                    {
                        targetValue = (int)self.GetParent<Unit>().GetComponent<BagComponent>().GetItemNumber(taskConfig.Target[t]);
                    }

                    if (targetType == TaskTargetType.PlayerLv_4
                        || targetType == TaskTargetType.ItemID_Number_2)
                    {
                        if (t == 0)
                        {
                            taskPro.taskTargetNum_1 = targetValue;
                        }
                        if (t == 1)
                        {
                            taskPro.taskTargetNum_2 = targetValue;
                        }
                    }
                    else
                    {
                        if (t == 0)
                        {
                            taskPro.taskTargetNum_1 += targetValue;
                        }
                        if (t == 1)
                        {
                            taskPro.taskTargetNum_2 += targetValue;
                        }
                    }
                }
                bool completed = self.IsCompleted( taskPro, taskConfig);
                taskPro.taskStatus = completed ? (int)TaskStatuEnum.Completed : (int)TaskStatuEnum.Accepted;
            }

            if (!updateTask)
                return;

            M2C_TaskUpdate m2C_TaskUpdate = self.M2C_TaskUpdate;
            m2C_TaskUpdate.RoleTaskList = self.RoleTaskList;
            MessageHelper.SendToClient(self.GetParent<Unit>(), m2C_TaskUpdate);
        }

        public static void CompletCurrentTask(this TaskComponent self)
        {
            for (int i = 0; i < self.RoleTaskList.Count; i++)
            {
                TaskPro taskPro = self.RoleTaskList[i];
                TaskConfig taskConfig = TaskConfigCategory.Instance.Get(taskPro.taskID);
              
                if (taskPro.taskStatus == (int)TaskStatuEnum.Completed)
                {
                    continue;
                }

                for (int t = 0; t < taskConfig.Target.Length; t++)
                {
                    if (t == 0)
                    {
                        taskPro.taskTargetNum_1 = taskConfig.TargetValue[0];
                    }
                    if (t == 1)
                    {
                        taskPro.taskTargetNum_2 = taskConfig.TargetValue[1];
                    }
                }
                taskPro.taskStatus = (int)TaskStatuEnum.Completed;
            }

            M2C_TaskUpdate m2C_TaskUpdate = self.M2C_TaskUpdate;
            m2C_TaskUpdate.RoleTaskList = self.RoleTaskList;
            MessageHelper.SendToClient(self.GetParent<Unit>(), m2C_TaskUpdate);
        }

        public static void TriggerTaskCountryEvent(this TaskComponent self, TaskCountryTargetType targetType, int targetTypeId, int targetValue, bool notice = true)
        {
            bool updateTask = false;
            List<TaskPro> countryList = new List<TaskPro>();

            for (int i = 0; i < self.TaskCountryList.Count; i++)
            {
                TaskPro taskInfo = self.TaskCountryList[i];
                TaskCountryConfig taskCountryConfig = TaskCountryConfigCategory.Instance.Get(taskInfo.taskID);
                if ((TaskCountryTargetType)taskCountryConfig.TargetType != targetType)
                {
                    continue;
                }
                if (taskCountryConfig.Target != targetTypeId)
                {
                    continue;
                }
                if (taskInfo.taskStatus >= (int)TaskStatuEnum.Completed)
                {
                    continue;
                }

                updateTask = true;
                taskInfo.taskTargetNum_1 += targetValue;

                taskInfo.taskStatus = (taskInfo.taskTargetNum_1 >= taskCountryConfig.TargetValue) ? (int)TaskStatuEnum.Completed : (int)TaskStatuEnum.Accepted;
                countryList.Add(taskInfo);
            }

            if (!updateTask || !notice)
                return;
            M2C_TaskCountryUpdate m2C_TaskUpdate = self.m2C_TaskCountryUpdate;
            m2C_TaskUpdate.UpdateMode = 1;
            m2C_TaskUpdate.TaskCountryList = countryList;
            MessageHelper.SendToClient(self.GetParent<Unit>(), m2C_TaskUpdate);
        }

        /// <summary>
        /// 重置每日活跃
        /// </summary> 
        /// <param name="self"></param>

        public static void OnZeroClockUpdate(this TaskComponent self,  bool notice = false)
        {
            Unit unit = self.GetParent<Unit>(); 
            NumericComponent numericComponent = unit.GetComponent<NumericComponent>();
            int taskLoop = self.GetTaskList(TaskTypeEnum.EveryDay).Count > 0 ? 1 : 0;
            numericComponent.ApplyValue(NumericType.TaskLoopNumber, taskLoop, notice);

            self.ReceiveHuoYueIds.Clear();
            self.TaskCountryList.Clear();
            List<int> taskCountryList = new List<int>();
            taskCountryList.AddRange(TaskHelp.GetTaskCountrys(unit));
            taskCountryList.AddRange(TaskHelp.GetBattleTask());
            for (int i = 0; i < taskCountryList.Count; i++)
            {
                self.TaskCountryList.Add(new TaskPro() { taskID = taskCountryList[i] });
            }
            if (notice)
            {
                M2C_TaskCountryUpdate m2C_TaskUpdate = self.m2C_TaskCountryUpdate;
                m2C_TaskUpdate.UpdateMode = 2;
                m2C_TaskUpdate.TaskCountryList = self.TaskCountryList;
                MessageHelper.SendToClient(unit, m2C_TaskUpdate);
            }

            UserInfoComponent userInfoComponent = unit.GetComponent<UserInfoComponent>();
            userInfoComponent.UpdateRoleData(UserDataType.HuoYue, (0 - userInfoComponent.UserInfo.HuoYue).ToString(), notice);
            Log.Debug($"更新活跃任务:  {unit.Id} {notice} {userInfoComponent.UserInfo.HuoYue} {self.TaskCountryList.Count}");
        }
    }
}
