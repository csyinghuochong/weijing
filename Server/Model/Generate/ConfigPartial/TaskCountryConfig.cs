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

                int taskNumber = 0; //数量

                if (taskCountryConfig.Id >= 600101 && taskCountryConfig.Id <= 600200)
                {
                    taskNumber = 5;
                }
                if (taskCountryConfig.Id >= 600201 && taskCountryConfig.Id <= 600300)
                {
                    taskNumber = 3;
                }
                if (taskCountryConfig.Id >= 600301 && taskCountryConfig.Id <= 600400)
                {
                    taskNumber = 2;
                }
                if (taskNumber == 0)
                {
                    continue;
                }

                if (!SeasonTaskList.ContainsKey(taskNumber))
                {
                    SeasonTaskList.Add(taskNumber, new List<int>());
                }
                SeasonTaskList[taskNumber].Add(taskCountryConfig.Id);
            }
        }
    }
}
