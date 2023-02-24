using System.Collections.Generic;
using System.Linq;

namespace ET
{

    public static class TaskHelp
    {

        public static int GetLoopTaskId(int roleLv)
        {
            List<int> allTaskIds = new List<int>();
            Dictionary<int, TaskConfig> keyValuePairs = TaskConfigCategory.Instance.GetAll();
            foreach (var item in keyValuePairs)
            {
                if (item.Value.TaskType == TaskTypeEnum.EveryDay
                    && roleLv >= item.Value.TaskLv
                    && roleLv <= item.Value.TaskMaxLv)
                {
                    allTaskIds.Add(item.Key);
                }
            }
            if (allTaskIds.Count == 0)
            {
                return 0;
            }
            return allTaskIds[RandomHelper.RandomNumber(0, allTaskIds.Count)];
        }

        public static int GetWeeklyTaskId()
        { 
            List<int> taskids = new List<int>();
            Dictionary<int, TaskConfig> taskConfigs = TaskConfigCategory.Instance.GetAll();
            foreach ((int id, TaskConfig TaskConfig) in taskConfigs)
            {
                if (TaskConfig.TaskType == TaskTypeEnum.Weekly)
                {
                    taskids.Add(id);
                }
            }
            return taskids[RandomHelper.RandomNumber(0, taskids.Count)];
        }

        /// <summary>
        /// 活跃任务
        /// </summary>
        /// <returns></returns>
        public static List<int> GetTaskCountrys(Unit unit)
        {
            //活跃任务
            int playerLv = unit.GetComponent<UserInfoComponent>().UserInfo.Lv;  

            List<int> taskCountryList = new List<int>();
            string[] dayTaskID =  GlobalValueConfigCategory.Instance.Get(8).Value.Split(';');
            for (int i = 0; i < dayTaskID.Length; i++)
            {
  
                //获取任务概率
                float taskRandValue = RandomHelper.RandFloat01();
                int writeTaskID = int.Parse( dayTaskID[i] );
                int writeTaskID_Next = writeTaskID;
                TaskCountryConfig taskCountryConfig = null;
                double triggerPro = 0;
                do
                {
                    writeTaskID = writeTaskID_Next;
                    taskCountryConfig = TaskCountryConfigCategory.Instance.Get(writeTaskID);

                    if (taskCountryConfig.TriggerType == 1 && playerLv < taskCountryConfig.TargetValue)
                    {
                        //条件不满足
                        if (taskCountryConfig.NextTask == 0)
                        {
                            break;
                        }
                        else
                        {
                            writeTaskID_Next = taskCountryConfig.NextTask;
                            continue;
                        }
                    }


                    triggerPro = taskCountryConfig.TriggerPro;
                    writeTaskID_Next = taskCountryConfig.NextTask;


                    if (writeTaskID_Next == 0)
                    {
                        taskRandValue = -1;
                    }

                } while (taskRandValue >= triggerPro);

                taskCountryList.Add(writeTaskID);
            }

            return taskCountryList;
        }


        public static List<int> GetBattleTask()
        {
            List<int> taskIds = new List<int>();
            Dictionary<int, TaskCountryConfig> keyValuePairs = TaskCountryConfigCategory.Instance.GetAll();
            foreach (var item in keyValuePairs)
            {
                if (item.Value.TaskType == TaskCountryType.Battle)
                {
                    taskIds.Add(item.Key);
                }
            }
            return taskIds;
        }
        
        public static List<RewardItem> GetTaskRewards(int taskid, TaskConfig taskConfig = null)
        {
            if (taskConfig == null)
            {
                taskConfig = TaskConfigCategory.Instance.Get(taskid);
            }

            List<RewardItem> taskRewards = new List<RewardItem>();
            string ItemIDs = taskConfig.ItemID;
            string ItemNum = taskConfig.ItemNum;
            string[] ids = ItemIDs.Split(';');
            string[] nums = ItemNum.Split(';');
            for (int i = 0; i < ids.Length; i++)
            {
                if (ids[i] == "0" || ids[i] == "")
                {
                    continue;
                }
                RewardItem taskReward = new RewardItem();
                taskReward.ItemID = int.Parse(ids[i]);
                taskReward.ItemNum = int.Parse(nums[i]);
                taskRewards.Add(taskReward);
            }
            return taskRewards;
        }
    }
}
