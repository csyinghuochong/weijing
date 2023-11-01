using System;
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

        public static int GetHuoYueDu(this TaskComponent self)
        {
            int huoYueDu = 0;
            for (int i = 0; i < self.TaskCountryList.Count; i++)
            {
                if (self.TaskCountryList[i].taskStatus != (int)TaskStatuEnum.Commited)
                {
                    continue;
                }
                TaskCountryConfig taskCountryConfig = TaskCountryConfigCategory.Instance.Get(self.TaskCountryList[i].taskID);
                huoYueDu += taskCountryConfig.EveryTaskRewardNum;
            }
            return huoYueDu;
        }

        public static void Check(this TaskComponent self)
        {
            self.OnLineTime++;
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
            return ErrorCode.ERR_Success;
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
        public static TaskPro OnAcceptedTask(this TaskComponent self, int taskId)
        {
            if (taskId == 0)
            {
                return null;
            }
            Unit unit = self.GetParent<Unit>();
            bool canget = FunctionHelp.CheckTaskOn(unit, TaskConfigCategory.Instance.Get(taskId));
            if (!canget)
            {
                Log.Debug($"CanNotGetTask: {unit.DomainZone()} {unit.Id} {taskId}");
                return null;
            }
            if (self.IsHaveTask(taskId))
            {
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

        public static string GetMainTaskId(this TaskComponent self)
        {
            string maintask = string.Empty;
            List<TaskPro> taskPros = self.GetTaskList( TaskTypeEnum.Main );
            for (int i = 0; i < taskPros.Count; i++)
            {
                TaskConfig taskConfig = TaskConfigCategory.Instance.Get(taskPros[i].taskID );
                maintask += $"{taskConfig.TaskName}_";
            }
            if (string.IsNullOrEmpty(maintask))
            {
                return "无";
            }
            else
            {
                return maintask;
            }
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

        public static bool IsItemTask(this TaskComponent self, int monsterid)
        {
            int taskId = 0;
            switch (monsterid)
            {
                case 41001008:
                    taskId = 30010013; //矿工的袋子
                    break;
                case 41001010:
                    taskId = 30010010;//解毒草
                    break;
                case 41002001:
                    taskId = 30020102;//清水
                    break;
                default:
                    break;
            }

            for (int i = 0; i < self.RoleTaskList.Count; i++)
            {
                if (self.RoleTaskList[i].taskID == taskId)
                {
                    return self.RoleTaskList[i].taskStatus == (int)TaskStatuEnum.Accepted;
                }
            }
            return false;
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
                            taskPro.taskTargetNum_1 = (int)unit.GetComponent<BagComponent>().GetItemNumber(taskConfig.Target[i]);
                        }
                        if (i == 1)
                        {
                            taskPro.taskTargetNum_2 = (int)unit.GetComponent<BagComponent>().GetItemNumber(taskConfig.Target[i]);
                        }
                    }
                    break;
                case(int)TaskTargetType.LookingFor_3:
                    taskPro.taskTargetNum_1 = 1;
                    break;
                case (int)(int)TaskTargetType.PlayerLv_4:
                    taskPro.taskTargetNum_1 = unit.GetComponent<UserInfoComponent>().UserInfo.Lv;
                    break;
                case (int)TaskTargetType.ChangeOcc_8:
                    taskPro.taskTargetNum_1 = unit.GetComponent<UserInfoComponent>().UserInfo.OccTwo > 0 ? 1 : 0;
                    break;
                case (int)TaskTargetType.JoinUnion_9:
                    taskPro.taskTargetNum_1 = unit.GetComponent<NumericComponent>().GetAsLong(NumericType.UnionId_0) > 0? 1 : 0;
                    break;
                case (int)TaskTargetType.PetNumber1_11:
                    taskPro.taskTargetNum_1 = unit.GetComponent<PetComponent>().GetAllPets().Count;
                    break;
                case (int)TaskTargetType.QiangHuaLevel_17:
                    taskPro.taskTargetNum_1 = unit.GetComponent<BagComponent>().GetMaxQiangHuaLevel();
                    break;
                case (int)TaskTargetType.PetNSkill_18:
                    taskPro.taskTargetNum_1 = unit.GetComponent<PetComponent>().GetMaxSkillNumber();
                    break;
                case (int)TaskTargetType.PetFubenId_19:
                    taskPro.taskTargetNum_1 = unit.GetComponent<PetComponent>().GetPassMaxFubenId();
                    break;
                case (int)TaskTargetType.JiaYuanLevel_22:
                    taskPro.taskTargetNum_1 = unit.GetComponent<UserInfoComponent>().UserInfo.JiaYuanLv - 10000;
                    break;
                case (int)TaskTargetType.TrialTowerCeng_134:
                    int curtrialid = unit.GetComponent<NumericComponent>().GetAsInt(NumericType.TrialDungeonId);
                    if (curtrialid > taskConfig.Target[0])
                    {
                        taskPro.taskTargetNum_1 = 1;
                    }
                    break;
                default:
                    taskPro.taskTargetNum_1 = 0;
                    break;
            }

            bool completed = self.IsCompleted(taskPro, taskConfig);
            taskPro.taskStatus = completed ? (int)TaskStatuEnum.Completed : (int)TaskStatuEnum.Accepted;
            if (taskConfig.TaskType == TaskTypeEnum.Treasure)
            {
                self.GetRandomFubenId(taskPro);
            }
            if (taskConfig.TaskType != TaskTypeEnum.Season
                && taskConfig.TaskType != TaskTypeEnum.Welfare
                && self.GetTrackTaskList().Count < 3)
            {
                taskPro.TrackStatus = 1;
            }
            return taskPro;
        }

        public static void GetRandomFubenId(this TaskComponent self, TaskPro taskPro)
        {
            List<int> openfubenids = new List<int>();
            int lv = self.GetParent<Unit>().GetComponent<UserInfoComponent>().UserInfo.Lv;

            Dictionary<int, DungeonConfig> allfuben =  DungeonConfigCategory.Instance.GetAll();
            foreach (( int fubenid, DungeonConfig config) in allfuben)
            {
                if (config.Id == 50007)
                {
                    continue;
                }
                if (DungeonSectionConfigCategory.Instance.MysteryDungeonList.Contains(config.Id))
                {
                    continue;
                }
                if (config.EnterLv <= lv)
                {
                    openfubenids.Add(fubenid);
                }
            }
            int dungeonid = openfubenids[RandomHelper.RandomNumber(0, openfubenids.Count)];
            string[] monsters =  SceneConfigHelper.GetLocalDungeonMonsters_2(dungeonid).Split('@');
            taskPro.FubenId = dungeonid;
            taskPro.WaveId = RandomHelper.RandomNumber(0, monsters.Length);
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

        public static TaskPro GetTaskById(this TaskComponent self, int taskid)
        {
            for (int i = self.RoleTaskList.Count - 1; i >= 0; i--)
            {
                if (self.RoleTaskList[i].taskID == taskid)
                {
                    return self.RoleTaskList[i];
                }
            }
            return null;
        }
        
        //领取奖励
        public static int OnCommitTask(this TaskComponent self, C2M_TaskCommitRequest request)
        {
            int taskid = request.TaskId;
            TaskPro taskPro = self.GetTaskById(taskid);
            if (taskPro == null)
            {
                return ErrorCode.ERR_TaskCommited;
            }
            Unit unit = self.GetParent<Unit>();
            TaskConfig taskConfig = TaskConfigCategory.Instance.Get(taskid);
            BagComponent bagComponent = unit.GetComponent<BagComponent>();

            List<RewardItem> rewardItems = TaskHelper.GetTaskRewards(taskid, taskConfig);
            if (bagComponent.GetLeftSpace() < rewardItems.Count)
            {
                return ErrorCode.ERR_BagIsFull;
            }

            //收集道具的任务
            if (taskConfig.TargetType == (int)TaskTargetType.ItemID_Number_2)
            {
                int needid = taskConfig.Target[0];
                int neednumber = taskConfig.TargetValue[0];
                int curnumber = (int)bagComponent.GetItemNumber(needid);
                if (curnumber < neednumber)
                {
                    self.TriggerTaskEvent(TaskTargetType.ItemID_Number_2, needid, 0);
                    return ErrorCode.ERR_ItemNotEnoughError;
                }

                bagComponent.OnCostItemData($"{needid};{neednumber}");
            }
            //给予任务
            if (taskConfig.TargetType == (int)TaskTargetType.GiveItem_10)
            {
                long baginfoId = request.BagInfoID;
                BagInfo bagInfo = bagComponent.GetItemByLoc(ItemLocType.ItemLocBag, baginfoId);
                if (bagInfo == null)
                {
                    return ErrorCode.ERR_ItemNotExist;
                }
                if (!TaskHelper.IsTaskGiveItem( taskid, bagInfo ))
                {
                    return ErrorCode.ERR_ItemNotEnoughError;
                }

                bagComponent.OnCostItemData(baginfoId, 1);
            }

            for (int i = self.RoleTaskList.Count - 1; i >= 0; i--)
            {
                if (self.RoleTaskList[i].taskID == taskid)
                {
                    self.RoleTaskList.RemoveAt(i);
                }
            }

            NumericComponent numericComponent = unit.GetComponent<NumericComponent>();
            if (taskConfig.TaskType != TaskTypeEnum.EveryDay
              && taskConfig.TaskType != TaskTypeEnum.Union
              && taskConfig.TaskType != TaskTypeEnum.Treasure
              && taskConfig.TaskType != TaskTypeEnum.Season)
            {
                if (!self.RoleComoleteTaskList.Contains(taskid))
                {
                    self.RoleComoleteTaskList.Add(taskid);
                }
            }
           
            int TaskExp = taskConfig.TaskExp;
            int TaskCoin = taskConfig.TaskCoin;

            UserInfoComponent unitInfoComponent = unit.GetComponent<UserInfoComponent>();
            unitInfoComponent.UpdateRoleData(UserDataType.Exp, TaskExp.ToString());
            unitInfoComponent.UpdateRoleMoneyAdd(UserDataType.Gold, TaskCoin.ToString(), true, ItemGetWay.TaskReward);
            int roleLv = unitInfoComponent.UserInfo.Lv;
            bagComponent.OnAddItemData(rewardItems, string.Empty, $"{ItemGetWay.TaskReward}_{TimeHelper.ServerNow()}");
            if (taskConfig.TargetType == (int)TaskTargetType.ItemID_Number_2)
            {
                bagComponent.OnCostItemData($"{taskConfig.Target[0]};{taskConfig.TargetValue[0]}");
            }
            if (taskConfig.TaskType == TaskTypeEnum.EveryDay)
            {
                numericComponent.ApplyValue(NumericType.LoopTaskID, TaskHelper.GetLoopTaskId(roleLv));
                self.TriggerTaskCountryEvent(TaskCountryTargetType.TaskLoop_14, 0, 1);
            }
            if (taskConfig.TaskType == TaskTypeEnum.Union)
            {
                int unionTaskNumber = numericComponent.GetAsInt(NumericType.UnionTaskNumber);
                numericComponent.ApplyValue(NumericType.UnionTaskId, unionTaskNumber < 10 ? TaskHelper.GetUnionTaskId(roleLv) : 0);
            }
            if (taskConfig.TaskType == TaskTypeEnum.Treasure)
            {
                int treasureTask = numericComponent.GetAsInt(NumericType.TreasureTask);
                numericComponent.ApplyValue(NumericType.TreasureTask, treasureTask + 1);
            }
            if (taskConfig.TaskType == TaskTypeEnum.Season)
            {
                int nextTask = taskid + 1;
                if (TaskConfigCategory.Instance.Contain(nextTask) && TaskConfigCategory.Instance.Get(nextTask).TaskType == TaskTypeEnum.Season)
                {
                    self.OnAcceptedTask(nextTask);

                    M2C_TaskUpdate m2C_TaskUpdate = self.M2C_TaskUpdate;
                    m2C_TaskUpdate.RoleTaskList = self.RoleTaskList;
                    MessageHelper.SendToClient(unit, m2C_TaskUpdate);
                }
            }
            if (taskConfig.TaskType != TaskTypeEnum.Main)
            {
                self.TriggerTaskCountryEvent(TaskCountryTargetType.EveryDayTask_19, 0, 1);
            }
            return ErrorCode.ERR_Success;
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
        public static void OnPetXiLian(this TaskComponent self, RolePetInfo rolePetInfo)
        {
            self.TriggerTaskEvent(TaskTargetType.PetNSkill_18, 0, rolePetInfo.PetSkill.Count);
            self.TriggerTaskCountryEvent(TaskCountryTargetType.PetXiLian_7, 0, 1);
        }

        public static void OnPetHeCheng(this TaskComponent self, RolePetInfo rolePetInfo)
        {
            self.TriggerTaskEvent(TaskTargetType.PetNumber1_11, 0, 1);
            self.TriggerTaskEvent(TaskTargetType.PetHeCheng_23, 0, 1);
            self.TriggerTaskEvent(TaskTargetType.PetNumber2_24, 0, 1);
            self.TriggerTaskEvent(TaskTargetType.PetNSkill_18, 0, rolePetInfo.PetSkill.Count);
            self.TriggerTaskCountryEvent(TaskCountryTargetType.GetPet_8, 0, 1);
        }

        /// <summary>
        /// 获得宠物
        /// </summary>
        /// <param name="self"></param>
        public static void OnGetPet(this TaskComponent self, RolePetInfo rolePetInfo)
        {
            self.TriggerTaskEvent( TaskTargetType.PetNumber1_11, 0, 1 );
            self.TriggerTaskEvent(TaskTargetType.PetNumber2_24, 0, 1);
            self.TriggerTaskEvent( TaskTargetType.PetNSkill_18,  0, rolePetInfo.PetSkill.Count);
            self.TriggerTaskCountryEvent(TaskCountryTargetType.GetPet_8, 0, 1);
        }

        /// <summary>
        /// 道具洗练
        /// </summary>
        /// <param name="self"></param>
        public static void OnEquipXiLian(this TaskComponent self, int times)
        {
            self.TriggerTaskEvent( TaskTargetType.EquipXiLian_13, 0, times);
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
        public static void OnItemHuiShow(this TaskComponent self, int itemNumber)
        {
            self.TriggerTaskEvent(TaskTargetType.EquipHuiShou_16, 0, itemNumber);
            self.TriggerTaskCountryEvent(TaskCountryTargetType.ItemHuiShou_11, 0, itemNumber);
        }

        /// <summary>
        /// 消耗金币
        /// </summary>
        /// <param name="self"></param>
        public static void OnCostCoin(this TaskComponent self, int costCoin)
        {
            if (costCoin >= 0)
                return;
            self.TriggerTaskEvent(TaskTargetType.TotalCostGold_20, 0, costCoin * -1);
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

        public static async ETTask UpdateUnionRaceRank(this TaskComponent self)
        {
            Unit unit = self.GetParent<Unit>();
            RankShouLieInfo rankingInfo = new RankShouLieInfo()
            {
                UnitID = unit.Id,
                KillNumber = 1,
                Occ = unit.GetComponent<UserInfoComponent>().UserInfo.Occ,
                PlayerName = unit.GetComponent<UserInfoComponent>().UserInfo.Name
            };
            M2R_RankUnionRaceRequest request = new M2R_RankUnionRaceRequest()
            {
                 RankingInfo = rankingInfo
            };
            long mapInstanceId = DBHelper.GetRankServerId(self.DomainZone());
            R2M_RankUnionRaceResponse Response = (R2M_RankUnionRaceResponse)await ActorMessageSenderComponent.Instance.Call
                     (mapInstanceId, request);
        }

        //击杀怪物可触发多种类型的任务
        public static void OnKillUnit(this TaskComponent self, Unit bekill, int sceneType)
        {
            if (bekill == null || bekill.IsDisposed)
                return;

            if (bekill.Type == UnitType.Player && sceneType == SceneTypeEnum.Battle)
            {
                self.TriggerTaskCountryEvent(TaskCountryTargetType.BattleKillPlayer_102, 0, 1);
                bekill.GetComponent<TaskComponent>().TriggerTaskCountryEvent(TaskCountryTargetType.BattleDead_104, 0, 1);
            }
            if (bekill.Type == UnitType.Player && sceneType == SceneTypeEnum.UnionRace)
            {
                self.TriggerTaskCountryEvent(TaskCountryTargetType.UnionRaceKill_301, 0, 1);
                self.UpdateUnionRaceRank().Coroutine();
            }
            if (bekill.Type == UnitType.Player)
            {
                self.TriggerTaskEvent( TaskTargetType.KillPlayer_21,0, 1 );
            }
            if (bekill.Type == UnitType.Monster)
            {
                int unitconfigId = bekill.ConfigId;
                MonsterConfig monsterConfig = MonsterConfigCategory.Instance.Get(unitconfigId);
                bool isBoss = monsterConfig.MonsterType == (int)MonsterTypeEnum.Boss;
                MapComponent mapComponent = self.DomainScene().GetComponent<MapComponent>();
                int fubenDifficulty = FubenDifficulty.None;
                Scene DomainScene = self.GetParent<Unit>().DomainScene();
                if (mapComponent.SceneTypeEnum == (int)SceneTypeEnum.CellDungeon)
                {
                    fubenDifficulty = DomainScene.GetComponent<CellDungeonComponent>().FubenDifficulty;
                }
                if (mapComponent.SceneTypeEnum == (int)SceneTypeEnum.LocalDungeon)
                {
                    fubenDifficulty = DomainScene.GetComponent<LocalDungeonComponent>().FubenDifficulty;
                }

                if (ActivityHelper.IsShowLieOpen())
                {
                    self.TriggerTaskCountryEvent(TaskCountryTargetType.ShowLieMonster_201, 0, 1);
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

            if (rolelv == 10)
            {
                self.CheckLoopTask();
            }
        }

        //登录
        public static void OnLogin(this TaskComponent self)
        {
            if (self.TaskCountryList.Count == 0)
            {
                Log.Debug($"活跃任务为空: {self.DomainZone()} {self.GetParent<Unit>().Id}");
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
                if ((TaskTargetType)taskConfig.TargetType == TaskTargetType.JoinUnion_9)
                {
                    long unionid = self.GetParent<Unit>().GetComponent<NumericComponent>().GetAsLong(NumericType.UnionId_0);
                    self.TriggerTaskEvent(TaskTargetType.JoinUnion_9, taskConfig.Target[0], unionid > 0 ? 1 : 0);
                    continue;
                }
                if ((TaskTargetType)taskConfig.TargetType == TaskTargetType.CombatToValue_133)
                {
                    int combat = self.GetParent<Unit>().GetComponent<UserInfoComponent>().UserInfo.Combat;
                    self.TriggerTaskEvent(TaskTargetType.CombatToValue_133, 0, combat);
                    continue;
                }
                if ((TaskTargetType)taskConfig.TargetType == TaskTargetType.TrialTowerCeng_134)
                {
                    //试炼副本
                    int trialid = self.GetParent<Unit>().GetComponent<NumericComponent>().GetAsInt(NumericType.TrialDungeonId);
                    if (trialid >= taskConfig.Target[0])
                    {
                        self.TriggerTaskEvent(TaskTargetType.TrialTowerCeng_134, taskConfig.Target[0], 1);
                    }
                } 
            }

            //试炼副本
            for (int i = 0; i < self.TaskCountryList.Count; i++)
            {
                int trialid = self.GetParent<Unit>().GetComponent<NumericComponent>().GetAsInt(NumericType.TrialDungeonId);
                TaskCountryConfig taskCountryConfig = TaskCountryConfigCategory.Instance.Get(self.TaskCountryList[i].taskID);
                if (taskCountryConfig.TargetType == (int)TaskCountryTargetType.TrialFuben_12 && trialid >= 20100)
                {
                    self.TriggerTaskCountryEvent(TaskCountryTargetType.TrialFuben_12, 0, taskCountryConfig.TargetValue, false);
                }
            }

            NumericComponent numericComponent = self.GetParent<Unit>().GetComponent<NumericComponent>();
            if (numericComponent.GetAsInt(NumericType.LoopTaskID) == 0)
            {
                self.UpdateDayTask(false);
            }

            if (ComHelp.IsInnerNet())
            {
                self.CheckSeasonMainTask();

                self.UpdateTargetTask(false);
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
                if (targetType != TaskTargetType.ItemID_Number_2 && taskPro.taskStatus == (int)TaskStatuEnum.Completed)
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
                        || targetType == TaskTargetType.ItemID_Number_2
                        || targetType == TaskTargetType.QiangHuaLevel_17
                        || targetType == TaskTargetType.JiaYuanLevel_22
                        || targetType == TaskTargetType.CombatToValue_133)
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
                    else if (targetType == TaskTargetType.PetNSkill_18
                        || targetType == TaskTargetType.PetFubenId_19)
                    {
                        if (t == 0 && targetValue > taskPro.taskTargetNum_1)
                        {
                            taskPro.taskTargetNum_1 = targetValue;
                        }
                        if (t == 1 && targetValue > taskPro.taskTargetNum_2)
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
            {
                return;
            }

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

        public static void OnPetMineLogin(this TaskComponent self, List<PetMingPlayerInfo> petMingPlayers, List<KeyValuePairInt> extends)
        {
            for (int i = 0; i < petMingPlayers.Count; i++)
            {
                for (int mineid = petMingPlayers[i].MineType; mineid <= 10003; mineid++)
                {
                    self.TriggerTaskCountryEvent(TaskCountryTargetType.MineHaveNumber_401, mineid, 1);
                }

                bool hexin = ComHelp.IsHexinMine(petMingPlayers[i].MineType, petMingPlayers[i].Postion, extends);
                if (hexin)
                {
                    self.TriggerTaskCountryEvent(TaskCountryTargetType.MineHaveNumber_401, 0, 1);
                }
            }
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

        public static void UpdateCountryList(this TaskComponent self,  bool notice)
        {
            Unit unit = self.GetParent<Unit>();
            if (self.TaskCountryList.Count == 0)
            {
                Log.Debug($"更新活跃任务ERROE:  {unit.Id} {notice} {self.DomainZone()} ");
            }
            self.TaskCountryList.Clear();
            self.ReceiveHuoYueIds.Clear();
            List<int> taskCountryList = new List<int>();
            taskCountryList.AddRange(TaskHelper.GetTaskCountrys(unit));
            taskCountryList.AddRange(TaskHelper.GetBattleTask());
            taskCountryList.AddRange(TaskHelper.GetShowLieTask());
            taskCountryList.AddRange(TaskHelper.GetUnionRaceTask());
            taskCountryList.AddRange(TaskHelper.GetMineTask());
            taskCountryList.AddRange(TaskHelper.GetSeasonTask());
            for (int i = 0; i < taskCountryList.Count; i++)
            {
                self.TaskCountryList.Add(new TaskPro() { taskID = taskCountryList[i] });
            }
            //UserInfoComponent userInfoComponent = unit.GetComponent<UserInfoComponent>();
            //userInfoComponent.UpdateRoleData(UserDataType.HuoYue, (0 - userInfoComponent.UserInfo.HuoYue).ToString(), notice);
            Log.Debug($"更新活跃任务:  {unit.Id} {self.DomainZone()}  {self.TaskCountryList.Count}");
        }

        public static void CheckLoopTask(this TaskComponent self)
        {
            NumericComponent numericComponent = self.GetParent<Unit>().GetComponent<NumericComponent>();
            if (numericComponent.GetAsInt(NumericType.LoopTaskID) != 0)
            {
                return;
            }
            if (numericComponent.GetAsInt(NumericType.LoopTaskNumber) >= 10)
            {
                return;
            }
            int roleLv = self.GetParent<Unit>().GetComponent<UserInfoComponent>().UserInfo.Lv;
            numericComponent.ApplyValue(NumericType.LoopTaskID, TaskHelper.GetLoopTaskId(roleLv));
        }

        public static void CheckSeasonMainTask(this TaskComponent self)
        {
            bool have = false;
            for (int i = self.RoleTaskList.Count - 1; i >= 0; i--)
            {
                TaskConfig taskConfig = TaskConfigCategory.Instance.Get(self.RoleTaskList[i].taskID);
                if (taskConfig.TaskType == TaskTypeEnum.Season)
                {
                    have = true;
                    break;
                }
            }
            if (have)
            {
                return;
            }

            int seasonTaskid = 0;
            foreach ( ( int taskid, TaskConfig taskcofnig ) in TaskConfigCategory.Instance.GetAll())
            {
                if (taskcofnig.TaskType == TaskTypeEnum.Season)
                {
                    seasonTaskid = taskid;
                    break;   
                }
            }

            self.OnAcceptedTask(seasonTaskid);
        }

        public static void UpdateTargetTask(this TaskComponent self, bool notice)
        {
            int openDay = self.GetParent<Unit>().GetComponent<UserInfoComponent>().GetCrateDay();
            if (openDay == 0 || openDay > ConfigHelper.WelfareTaskList.Count)
            {
                return;
            }

            //所有任务
            List<int> taskids = new List<int>();
            for (int i = 0; i < openDay; i++)
            {
                taskids.AddRange(ConfigHelper.WelfareTaskList[i]);
            }
            for (int i = 0; i < taskids.Count; i++)
            {
                Log.Console($"新手任务: {taskids[i]}");

                if (self.GetTaskById(taskids[i]) != null)
                {
                    continue;
                }
                if (self.RoleComoleteTaskList.Contains(taskids[i]))
                {
                    continue;
                }

                Log.Console($" 福利任务：{taskids[i]}");

                self.RoleTaskList.Add( self.CreateTask(taskids[i]));
            }
        }

        public static void UpdateDayTask(this TaskComponent self, bool notice)
        {
            //清空每日任务
            Unit unit = self.GetParent<Unit>();
            System.DateTime dateTime = TimeHelper.DateTimeNow();
            for (int i = self.RoleTaskList.Count - 1; i >= 0; i--)
            {
                TaskConfig taskConfig = TaskConfigCategory.Instance.Get(self.RoleTaskList[i].taskID);
                if (taskConfig.TaskType == TaskTypeEnum.EveryDay || taskConfig.TaskType == TaskTypeEnum.Union)
                {
                    if (self.RoleComoleteTaskList.Contains(taskConfig.Id))
                    {
                        self.RoleComoleteTaskList.Remove(taskConfig.Id);
                    }
                    self.RoleTaskList.RemoveAt(i);
                    continue;
                }
            }

            NumericComponent numericComponent = unit.GetComponent<NumericComponent>();
            int roleLv = unit.GetComponent<UserInfoComponent>().UserInfo.Lv;
            numericComponent.ApplyValue(NumericType.LoopTaskNumber, 0, notice);
            numericComponent.ApplyValue(NumericType.UnionTaskNumber, 0, notice);
            numericComponent.ApplyValue(NumericType.LoopTaskID, TaskHelper.GetLoopTaskId(roleLv), notice);
            numericComponent.ApplyValue(NumericType.UnionTaskId, TaskHelper.GetUnionTaskId(roleLv), notice);
            Log.Debug($"更新每日任务: {numericComponent.GetAsInt(NumericType.LoopTaskID)}");
        }

        public static TaskPro GetTreasureMonster(this TaskComponent self, int fubenid)
        {
            List<TaskPro> taskPros = self.GetTaskList(TaskTypeEnum.Treasure);
            for (int i = 0; i < taskPros.Count; i++)
            {
                if (taskPros[i].taskStatus >= (int)TaskStatuEnum.Completed)
                {
                    continue;
                }
                if (taskPros[i].FubenId != fubenid)
                {
                    continue;
                }
                return taskPros[i];
            }
            return null;
        }

        public static void CheckWeeklyTask(this TaskComponent self)
        {
            System.DateTime dateTime = TimeHelper.DateTimeNow();
            if( dateTime.DayOfWeek == System.DayOfWeek.Sunday)
            {
                self.ResetWeeklyTask();
            }
        }

        public static void ResetWeeklyTask(this TaskComponent self)
        {
            for (int i = self.RoleTaskList.Count - 1; i >= 0; i--)
            {
                TaskConfig taskConfig = TaskConfigCategory.Instance.Get(self.RoleTaskList[i].taskID);
                if (taskConfig.TaskType == TaskTypeEnum.Weekly)
                {
                    if (self.RoleComoleteTaskList.Contains(taskConfig.Id))
                    {
                        self.RoleComoleteTaskList.Remove(taskConfig.Id);
                    }
                    self.RoleTaskList.RemoveAt(i);
                    continue;
                }
            }
            for (int i = self.RoleComoleteTaskList.Count - 1; i >= 0; i--)
            {
                TaskConfig taskConfig = TaskConfigCategory.Instance.Get(self.RoleComoleteTaskList[i]);
                if (taskConfig.TaskType == TaskTypeEnum.Weekly)
                {
                    self.RoleComoleteTaskList.RemoveAt(i);
                    continue;
                }
            }
        }

        public static void CheckWeeklyTask(this TaskComponent self, long lastTime, long curTime)
        {
            //判断条件。 超过一周或者过了周末
            float passday = ((curTime - lastTime) * 1f / TimeHelper.OneDay);
            if (passday >= 7)
            {
                self.ResetWeeklyTask();
            }
            else
            {
                DateTime lastdateTime = TimeInfo.Instance.ToDateTime(lastTime);
                DateTime curdateTime = TimeInfo.Instance.ToDateTime(curTime);
                if (curdateTime.DayOfWeek < lastdateTime.DayOfWeek)
                {
                    self.ResetWeeklyTask();
                }
            }
        }

        /// <summary>
        /// 重置每日活跃
        /// </summary> 
        /// <param name="self"></param>
        public static void OnZeroClockUpdate(this TaskComponent self, bool notice)
        {
            self.OnLineTime = 0;
            Unit unit = self.GetParent<Unit>();
            self.UpdateCountryList(notice);
            self.UpdateDayTask(notice);
            self.UpdateTargetTask(notice);
           
            if (notice)
            {
                M2C_TaskCountryUpdate m2C_TaskUpdate = self.m2C_TaskCountryUpdate;
                m2C_TaskUpdate.UpdateMode = 2;
                m2C_TaskUpdate.TaskCountryList = self.TaskCountryList;
                MessageHelper.SendToClient(unit, m2C_TaskUpdate);
            }
            if (notice)
            {
                M2C_TaskUpdate m2C_TaskUpdate = self.M2C_TaskUpdate;
                m2C_TaskUpdate.RoleTaskList = self.RoleTaskList;
                MessageHelper.SendToClient(unit, m2C_TaskUpdate);
            }
        }
    }
}
