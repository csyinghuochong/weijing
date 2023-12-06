using System;
using System.Collections.Generic;
using System.Linq;

namespace ET
{
    public partial class TaskCountryConfigCategory
    {

        public Dictionary<int, List<int>> SeasonTaskList = new Dictionary<int, List<int>>();

        public override void AfterEndInit()
        {
            foreach (TaskCountryConfig taskCountryConfig in this.GetAll().Values)
            {

                if (taskCountryConfig.TaskType != TaskCountryType.Season)
                {
                    continue;
                }

                int taskIndex = 0;

                if (taskCountryConfig.Id >= 600101 && taskCountryConfig.Id <= 600200)
                {
                    taskIndex = 5;
                }
                if (taskCountryConfig.Id >= 600201 && taskCountryConfig.Id <= 600300)
                {
                    taskIndex = 3;
                }
                if (taskCountryConfig.Id >= 600301 && taskCountryConfig.Id <= 600400)
                {
                    taskIndex = 2;
                }
                if (taskIndex == 0)
                {
                    continue;
                }

                if (!SeasonTaskList.ContainsKey(taskIndex))
                {
                    SeasonTaskList.Add(taskIndex, new List<int>());
                }
                SeasonTaskList[taskIndex].Add(taskCountryConfig.Id);
            }
        }
    }
}
