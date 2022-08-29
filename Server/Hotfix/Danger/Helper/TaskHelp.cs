using System.Collections.Generic;

namespace ET
{

    public class TaskHelp : Singleton<TaskHelp>
    {

        public List<int> GetTaskCountrys()
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

        //1：杀怪
        //2：道具ID
        //3：找人
        //4：等级达到指定等级
        //5：击杀任意怪物
        //6：击杀任意BOSS级别怪物
        //7：通关某个副本
        //101：击杀挑战难度的指定ID怪物(击杀地狱也算)
        //102：击杀地狱你拿度指定ID怪物
        //111：通关挑战难度的副本(通关地狱也算)
        //112：通关地狱难度的副本
        //121：击败挑战难度任意数量怪物(通关地狱也算)
        //122：击败地狱难度任意数量怪物
        //131：击败挑战难度任意boss怪物(通关地狱也算)
        //132：击败地狱难度任意boss怪物
        protected override void InternalInit()
        {
            base.InternalInit();
        }

        public List<RewardItem> GetTaskRewards(int taskid, TaskConfig taskConfig = null)
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
