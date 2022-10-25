using System;
using System.Collections.Generic;

namespace ET
{
    [ActorMessageHandler]
    public class C2M_TaskLoopGetHandler : AMActorLocationRpcHandler<Unit, C2M_TaskLoopGetRequest, M2C_TaskLoopGetResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_TaskLoopGetRequest request, M2C_TaskLoopGetResponse response, Action reply)
        {
            TaskComponent taskComponent = unit.GetComponent<TaskComponent>();
            if (taskComponent.GetTaskList(TaskTypeEnum.EveryDay).Count > 0)
            {
                reply();
                return;
            }
            List<int> allTaskIds = new List<int>();
            Dictionary<int, TaskConfig> keyValuePairs = TaskConfigCategory.Instance.GetAll();
            foreach (var item in keyValuePairs)
            {
                if (item.Value.TargetType == TaskTypeEnum.EveryDay)
                {
                    allTaskIds.Add(item.Key);
                }
            }
            int taskId = allTaskIds[RandomHelper.RandomNumber(0, allTaskIds.Count)];
            TaskPro taskPro = taskComponent.OnGetTask(taskId);
            response.TaskLoop = taskPro;

            reply();
            await ETTask.CompletedTask;
        }
    }
}
