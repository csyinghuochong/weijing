using System.Collections.Generic;

namespace ET
{

    public static class TaskHelp
    {

        /// <summary>
        /// 活跃任务
        /// </summary>
        /// <returns></returns>
        public static List<int> GetTaskCountrys()
        {
            //活跃任务
            List<int> taskCountryList = new List<int>();
            string[] dayTaskID =  GlobalValueConfigCategory.Instance.Get(8).Value.Split(';');
            for (int i = 0; i < dayTaskID.Length; i++)
            {
  
                //获取任务概率
                float taskRandValue = RandomHelper.RandFloat01();
                int writeTaskID = int.Parse( dayTaskID[i] );
                int writeTaskID_Next = writeTaskID;
                double triggerPro = 0;
                do
                {
                    writeTaskID = writeTaskID_Next;
                    TaskCountryConfig taskCountryConfig = TaskCountryConfigCategory.Instance.Get(writeTaskID);
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
            string[] ids = ItemIDs.Split(';');
            for (int i = 0; i < ids.Length; i++)
            {
                if (ids[i] == "0" || ids[i] == "")
                {
                    continue;
                }
                RewardItem taskReward = new RewardItem();
                taskReward.ItemID = int.Parse(ids[i]);
                taskReward.ItemNum = 1;
                taskRewards.Add(taskReward);
            }
            return taskRewards;
        }
    }
}
