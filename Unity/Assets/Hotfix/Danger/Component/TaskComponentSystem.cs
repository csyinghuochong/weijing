using System;
using UnityEngine;
using System.Linq;
using System.Collections.Generic;

namespace ET
{

    public static class TaskComponentSystem
    {

        public static void OnZeroClockUpdate(this TaskComponent self)
        {
            self.ReceiveHuoYueIds.Clear();
        }

        public static List<int> GetOpenTaskIds(this TaskComponent self, int npcid)
        {
            List<int> openTaskids = new List<int>();
            NpcConfig npcConfig = NpcConfigCategory.Instance.Get(npcid);
            if (npcConfig == null)
            {
                return openTaskids;
            }
            int[] taskid = npcConfig.TaskID;
            if (taskid == null)
            {
                return openTaskids;
            }
            Scene unit = self.ZoneScene();
            for (int i = 0; i < taskid.Length; i++)
            {
                if (taskid[i] == 0)
                    continue;
                if (self.GetTaskById(taskid[i]) != null)
                    continue;
                if (self.IsTaskFinished(taskid[i]))
                    continue;
                if (!TaskConfigCategory.Instance.Contain(taskid[i]))
                {
                    Log.Debug($"无效的任务ID {taskid[i]}");
                    continue;
                }

                TaskConfig taskConfig = TaskConfigCategory.Instance.Get(taskid[i]);
                if (FunctionHelp.CheckTaskOn(unit.DomainScene(),taskConfig.TriggerType,taskConfig.TriggerValue))
                {
                    openTaskids.Add(taskid[i]);
                }
            }
            return openTaskids;
        }

        public static List<TaskPro> GetCompltedTaskByNpc(this TaskComponent self, int npc)
        {
            List<TaskPro> taskPros = new List<TaskPro>();
            for (int k = 0; k < self.RoleTaskList.Count; k++)
            {
                if (!TaskConfigCategory.Instance.Contain(self.RoleTaskList[k].taskID))
                {
                    Log.Debug($"无效的任务ID {self.RoleTaskList[k].taskID}");
                    continue;
                }
                TaskConfig taskConfig = TaskConfigCategory.Instance.Get(self.RoleTaskList[k].taskID);
                if (taskConfig.CompleteNpcID == npc && self.RoleTaskList[k].taskStatus == (int)TaskStatuEnum.Completed)
                {
                    taskPros.Add(self.RoleTaskList[k]);
                }
            }
            return taskPros;
        }

        public static List<TaskPro> GetCompltedTaskList(this TaskComponent self)
        {
            List<TaskPro> taskPros = new List<TaskPro>();
            for (int k = 0; k < self.RoleTaskList.Count; k++)
            {
                TaskConfig taskConfig = TaskConfigCategory.Instance.Get(self.RoleTaskList[k].taskID);
                if (self.RoleTaskList[k].taskStatus == (int)TaskStatuEnum.Completed)
                {
                    taskPros.Add(self.RoleTaskList[k]);
                }
            }
            return taskPros;
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

        public static TaskPro GetTaskComplted(this TaskComponent self, List<int> taskids)
        {
            TaskPro taskPro = null;
            for (int i = 0; i < taskids.Count; i++)
            {
                for (int k = 0; k < self.RoleTaskList.Count; k++)
                {
                    taskPro = self.RoleTaskList[k];
                    if (taskPro.taskID == taskids[i] && taskPro.taskStatus == (int)TaskStatuEnum.Completed)
                    {
                        return taskPro;
                    }
                }
            }
            return null;
        }

        /// <summary>
        /// 放弃任务
        /// </summary>
        /// <param name="self"></param>
        /// <param name="taskI"></param>
        /// <returns></returns>
        public static async ETTask SendGiveUpTask(this TaskComponent self, int taskId)
        {
            C2M_TaskGiveUpRequest m_GetTaskRequest = new C2M_TaskGiveUpRequest() { TaskId = taskId };
            M2C_TaskGiveUpResponse m2C_GetTaskResponse = (M2C_TaskGiveUpResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(m_GetTaskRequest);

            for (int i = self.RoleTaskList.Count - 1; i >= 0; i--)
            {
                if (self.RoleTaskList[i].taskID == taskId)
                {
                    self.RoleTaskList.RemoveAt(i);
                    break;
                }
            }
            HintHelp.GetInstance().DataUpdate(DataType.TaskGiveUp);
        }

        //任务追踪
        public static async ETTask SendTaskTrack(this TaskComponent self, int taskId, int trackStatus)
        {
            C2M_TaskTrackRequest m_GetTaskRequest = new C2M_TaskTrackRequest() { TaskId = taskId, TrackStatus = trackStatus };
            M2C_TaskTrackResponse m2C_GetTaskResponse = (M2C_TaskTrackResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(m_GetTaskRequest);

            for (int i = 0; i < self.RoleTaskList.Count; i++)
            {
                if (self.RoleTaskList[i].taskID == taskId)
                {
                    self.RoleTaskList[i].TrackStatus = trackStatus;
                }
            }
            HintHelp.GetInstance().DataUpdate(DataType.TaskTrace);
        }

        //对话完成
        public static async ETTask SendTaskNotice(this TaskComponent self, int taskId)
        {
            for (int k = 0; k < self.RoleTaskList.Count; k++)
            {
                if (self.RoleTaskList[k].taskID == taskId)
                {
                    self.RoleTaskList[k].taskTargetNum_1 = 1;
                    self.RoleTaskList[k].taskStatus = (int)TaskStatuEnum.Completed;
                }
            }

            C2M_TaskNoticeRequest m_GetTaskRequest = new C2M_TaskNoticeRequest() { TaskId = taskId };
            M2C_TaskNoticeResponse m2C_GetTaskResponse = (M2C_TaskNoticeResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(m_GetTaskRequest);

            HintHelp.GetInstance().DataUpdate(DataType.TaskUpdate);
        }

        public static async ETTask SendIniTask(this TaskComponent self)
        {
            C2M_TaskInitRequest m_GetTaskRequest = new C2M_TaskInitRequest() { };
            M2C_TaskInitResponse m2C_GetTaskResponse = (M2C_TaskInitResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(m_GetTaskRequest);

            self.RoleTaskList = m2C_GetTaskResponse.RoleTaskList;
            self.RoleComoleteTaskList = m2C_GetTaskResponse.RoleComoleteTaskList;
            self.TaskCountryList = m2C_GetTaskResponse.TaskCountryList;
            self.ReceiveHuoYueIds = m2C_GetTaskResponse.ReceiveHuoYueIds;
            self.CampTaskList = m2C_GetTaskResponse.CampTaskList;
        }

        //接取任务
        public static async ETTask SendGetTask(this TaskComponent self, int taskId)
        {
            C2M_TaskGetRequest m_GetTaskRequest = new C2M_TaskGetRequest() { TaskId = taskId };
            M2C_TaskGetResponse m2C_GetTaskResponse = (M2C_TaskGetResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(m_GetTaskRequest);
            if (m2C_GetTaskResponse.Error != 0)
            {
                return;
            }

            TaskPro taskPro = m2C_GetTaskResponse.TaskPro;
            self.RoleTaskList.Add(taskPro);
            HintHelp.GetInstance().DataUpdate(DataType.TaskGet, taskId.ToString());

            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            TaskConfig taskConfig = TaskConfigCategory.Instance.Get(taskId);
            if (unit.MainHero && UnitHelper.IsRobot(unit) && taskConfig.TargetType == (int)TaskTargetType.ItemID_Number_2)
            {
                C2M_GMCommandRequest c2M_GMCommandRequest = new C2M_GMCommandRequest() { GMMsg = $"1#{taskConfig.Target[0]}#{taskConfig.TargetValue[0]}" };
                Log.ILog.Debug($"Behaviour_Task: C2M_GMCommandRequest {c2M_GMCommandRequest.GMMsg}");
                self.ZoneScene().GetComponent<SessionComponent>().Session.Send(c2M_GMCommandRequest);
            }
        }

        public static TaskPro GetTaskById(this TaskComponent self, int taskId)
        {
            for (int i = 0; i < self.RoleTaskList.Count; i++)
            {
                if (self.RoleTaskList[i].taskID == taskId)
                    return self.RoleTaskList[i];
            }
            return null;
        }

        public static List<TaskPro> GetAllTrackList(this TaskComponent self)
        {
            List<TaskPro> taskPros = new List<TaskPro>();
            for (int i = 0; i < self.RoleTaskList.Count; i++)
            {
                if (self.RoleTaskList[i].TrackStatus == 0)
                {
                    continue;
                }
                taskPros.Add(self.RoleTaskList[i]);
            }
            return taskPros;
        }

        public static List<TaskPro> GetTrackTaskTypeList(this TaskComponent self, int taskTypeEnum)
        {
            List<TaskPro> taskPros = new List<TaskPro>();
            for (int i = 0; i < self.RoleTaskList.Count; i++)
            {
                TaskConfig taskConfig = TaskConfigCategory.Instance.Get(self.RoleTaskList[i].taskID);
                if (taskConfig.TaskType != (int)taskTypeEnum && self.RoleTaskList[i].TrackStatus == 0)
                {
                    continue;
                }
                taskPros.Add(self.RoleTaskList[i]);
            }
            return taskPros;
        }

        public static int GetNextMainTask(this TaskComponent self)
        {
            int maxTask = 0;
            int nextTask = 0;
            List<int> completeTask = self.RoleComoleteTaskList;
            for (int i = 0; i < completeTask.Count; i++)
            {
                TaskConfig taskConfig = TaskConfigCategory.Instance.Get(completeTask[i]);
                if (taskConfig.TaskType != TaskTypeEnum.Main)
                {
                    continue;
                }
                if (taskConfig.Id > maxTask)
                {
                    maxTask = taskConfig.Id;
                }
            }
            List<TaskConfig> taskConfigs = TaskConfigCategory.Instance.GetAll().Values.ToList();
            for (int i = 0; i < taskConfigs.Count; i++)
            {
                if (taskConfigs[i].TaskType != TaskTypeEnum.Main)
                {
                    continue;
                }
                if (taskConfigs[i].Id > maxTask)
                {
                    nextTask = taskConfigs[i].Id;
                    break;
                }
            }
            return nextTask;
        }

        public static List<TaskPro> GetTaskTypeList(this TaskComponent self, int taskTypeEnum)
        {
            List<TaskPro> taskPros = new List<TaskPro>();
            for (int i = 0; i < self.RoleTaskList.Count; i++)
            {
                TaskConfig taskConfig = TaskConfigCategory.Instance.Get(self.RoleTaskList[i].taskID);
                if (taskConfig.TaskType != (int)taskTypeEnum)
                {
                    continue;
                }
                taskPros.Add(self.RoleTaskList[i]);
            }
            return taskPros;
        }

        public static void OnRecvTaskUpdate(this TaskComponent self, M2C_TaskUpdate message)
        {
            self.RoleTaskList = message.RoleTaskList;
            HintHelp.GetInstance().DataUpdate(DataType.TaskUpdate);
        }

        public static bool IsTaskFinished(this TaskComponent self, int taskId)
        {
            return self.RoleComoleteTaskList.Contains(taskId);
        }

        public static async ETTask SendCommitTaskCountry(this TaskComponent self, int taskId)
        {
            for (int i = 0; i < self.TaskCountryList.Count; i++)
            {
                if (self.TaskCountryList[i].taskID == taskId)
                {
                    self.TaskCountryList[i].taskStatus = (int)TaskStatuEnum.Commited;
                }
            }

            C2M_CommitTaskCountryRequest c2M_CommitTaskRequest = new C2M_CommitTaskCountryRequest() { TaskId = taskId };
            M2C_CommitTaskCountryResponse m2C_CommitTaskResponse = (M2C_CommitTaskCountryResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(c2M_CommitTaskRequest);
        }

        public static async ETTask RuqestHuoYueReward(this TaskComponent self, int huoyueId)
        {
            C2M_TaskHuoYueRewardRequest c2M_CommitTaskRequest = new C2M_TaskHuoYueRewardRequest() { HuoYueId = huoyueId };
            M2C_TaskHuoYueRewardResponse m2C_CommitTaskResponse = (M2C_TaskHuoYueRewardResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(c2M_CommitTaskRequest);
            //self.ReceiveHuoYueIds.Add(huoyueId);
        }

        //提交任务
        public static async ETTask<int> SendCommitTask(this TaskComponent self, int taskId)
        {
            try
            {
                C2M_TaskCommitRequest c2M_CommitTaskRequest = new C2M_TaskCommitRequest() { TaskId = taskId };
                M2C_TaskCommitResponse m2C_CommitTaskResponse = (M2C_TaskCommitResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(c2M_CommitTaskRequest);
                for (int i = self.RoleTaskList.Count - 1; i >= 0; i--)
                {
                    if (self.RoleTaskList[i].taskID == taskId)
                    {
                        self.RoleTaskList.RemoveAt(i);
                        break;
                    }
                }
                self.RoleComoleteTaskList.Add(taskId);
                HintHelp.GetInstance().DataUpdate(DataType.TaskComplete, taskId.ToString());
                return m2C_CommitTaskResponse.Error;
            }
            catch (Exception e)
            {
                Log.Error(e);
                return ErrorCore.ERR_NetWorkError;
            }
        }

        public static int GetTaskFubenId(this TaskComponent self)
        { 
            int maxTask = 0;
            bool completed = false;
            if (self.RoleTaskList.Count == 0)
            {
                self.RoleComoleteTaskList.Sort();
                maxTask = self.RoleComoleteTaskList[0];
            }
            else
            {
                maxTask = self.RoleTaskList[0].taskID;
                completed = self.RoleTaskList[0].taskStatus ==(int)TaskStatuEnum.Completed;
            }

            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            int fubenId = unit.GetComponent<NumericComponent>().GetAsInt(NumericType.TaskDungeonId);
            Log.ILog.Debug($"Behaviour_Task: GetTaskFubenId {fubenId}");

            TaskConfig taskConfig = TaskConfigCategory.Instance.Get(maxTask);
            List<DungeonConfig> dungeonConfigs = DungeonConfigCategory.Instance.GetAll().Values.ToList();
 
            for (int i = 0; i < dungeonConfigs.Count; i++)
            {
                if (completed)
                {
                    if (dungeonConfigs[i].NpcList == null)
                    {
                        continue;
                    }
                    List<int> npcList = new List<int>(dungeonConfigs[i].NpcList);
                    if (npcList.Contains(taskConfig.CompleteNpcID))
                    {
                        fubenId = dungeonConfigs[i].Id;
                        break;
                    }
                    continue;
                }

                if (dungeonConfigs[i].Id < fubenId)
                {
                    continue;
                }
                if (taskConfig.TargetType == (int)TaskTargetType.KillMonsterID_1)
                {
                    if (dungeonConfigs[i].CreateMonster.Contains(taskConfig.Target[0].ToString()))
                    {
                        fubenId = dungeonConfigs[i].Id;
                        break;
                    }
                    if (dungeonConfigs[i].MonsterGroup != 0 &&
                        MonsterGroupConfigCategory.Instance.Get(dungeonConfigs[i].MonsterGroup).CreateMonster.Contains(taskConfig.Target[0].ToString()))
                    {
                        fubenId = dungeonConfigs[i].Id;
                        break;
                    }
                    continue;
                }
                //其他类型任务可能会断
            }

            return fubenId;
        }

        public static async ETTask CheckTaskList(this TaskComponent self)
        {
            MapComponent mapComponent = self.ZoneScene().GetComponent<MapComponent>();
            if (mapComponent.SceneTypeEnum != (int)SceneTypeEnum.LocalDungeon)
            {
                return;
            }
            DungeonConfig dungeonConfig = DungeonConfigCategory.Instance.Get(mapComponent.SceneId);
            int[] npcList = dungeonConfig.NpcList;
            for(int i = 0; i < npcList.Length; i++)
            {
                TaskComponent taskComponent = self.ZoneScene().GetComponent<TaskComponent>();
                List<TaskPro> taskProCompleted = taskComponent.GetCompltedTaskByNpc(npcList[i]);
                for (int t = 0; t < taskProCompleted.Count; t++)
                {
                    Log.ILog.Debug($"Behaviour_Task: SendCommitTask {taskProCompleted[t].taskID}");
                    await self.SendCommitTask(taskProCompleted[t].taskID);
                }
                List<int> canGets = taskComponent.GetOpenTaskIds(npcList[i]);
                for (int g = 0;  g < canGets.Count; g++)
                {
                    Log.ILog.Debug($"Behaviour_Task: SendGetTask {canGets[g]}");
                    await self.SendGetTask(canGets[g]);
                }
            }
        }

        //只执行杀怪任务
        public static async ETTask<int> OnExcuteTask(this TaskComponent self)
        {
            if (self.RoleTaskList.Count == 0)
            {
                return -1;
            }
            TaskPro taskPro = self.RoleTaskList[0];
            TaskConfig taskConfig = TaskConfigCategory.Instance.Get(taskPro.taskID);
            if (taskConfig.TargetType != (int)TaskTargetType.KillMonsterID_1)
            {
                return -1;
            }

            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            int fubenId = self.ZoneScene().GetComponent<MapComponent>().SceneId;
            DungeonConfig dungeonConfig = DungeonConfigCategory.Instance.Get(fubenId);
            string createMonster = dungeonConfig.CreateMonster;
            if (createMonster.Contains(taskConfig.Target[0].ToString()))
            {
                Log.ILog.Debug($"Robot MoveToAsync2   {taskPro.taskID}");
                Vector3 targetPostion = self.GetMonsterPosition(createMonster, taskConfig.Target[0]);
                int ret = await MoveHelper.MoveToAsync(unit, targetPostion);
                return ret;
            }
            else
            {
                createMonster = MonsterGroupConfigCategory.Instance.Get(dungeonConfig.MonsterGroup).CreateMonster;
                Log.ILog.Debug($"Robot MoveToAsync2  {taskPro.taskID}"); 
               
                Vector3 targetPostion = self.GetMonsterPosition(createMonster, taskConfig.Target[0]);
                int ret = await MoveHelper.MoveToAsync(unit, targetPostion);
                return ret;
            }
        }

        public static Vector3 GetMonsterPosition(this TaskComponent self, string createMonster, int monsterId)
        {
            Vector3 vector31 = new Vector3();
            string[] monsters = createMonster.Split('@');
            for (int i = 0; i < monsters.Length; i++)
            {
                if (monsters[i] == "0")
                {
                    continue;
                }
                //1;37.65,0,3.2;70005005;1
                string[] mondels = monsters[i].Split(';');
                string[] mtype = mondels[0].Split(',');
                string[] position = mondels[1].Split(',');
                string[] monsterid = mondels[2].Split(',');
                string[] mcount = mondels[3].Split(',');

                vector31 = new Vector3(float.Parse(position[0]), float.Parse(position[1]), float.Parse(position[2]));
                if (int.Parse(monsterid[0]) == monsterId)
                {
                    return vector31; 
                }
            }
            return vector31;
        }

        public static void OnRecvTaskCountryUpdate(this TaskComponent self, M2C_TaskCountryUpdate message)
        {
            //1增量更新   2全量更新
            if (message.UpdateMode == 2)
            {
                self.TaskCountryList = message.TaskCountryList;
                return;
            }
            for (int i = 0; i < message.TaskCountryList.Count; i++)
            {
                for (int k = 0; k < self.TaskCountryList.Count; k++)
                {
                    if (message.TaskCountryList[i].taskID == self.TaskCountryList[k].taskID)
                    {
                        self.TaskCountryList[k] = message.TaskCountryList[i];
                    }
                }
            }
        }
    }

}
