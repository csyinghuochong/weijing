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
            TaskPro taskPro = null;
            NumericComponent numericComponent = unit.GetComponent<NumericComponent>();
            int giveUpId = numericComponent.GetAsInt(NumericType.TaskLoopGiveId);
            if (giveUpId > 0)
            {
                taskPro = taskComponent.OnGetTask(giveUpId);
                response.TaskLoop = taskPro;
                numericComponent.ApplyChange(null,NumericType.TaskLoopNumber,1,0);
                reply();
                return;
            }

            //获取当前任务是否已达上限
            if (unit.GetComponent<NumericComponent>().GetAsInt(NumericType.TaskLoopNumber) >= GlobalValueConfigCategory.Instance.Get(58).Value2)
            {
                response.Error = ErrorCore.ERR_ShangJinNumFull;
                reply();
                return;
            }

            List<int> allTaskIds = new List<int>();
            Dictionary<int, TaskConfig> keyValuePairs = TaskConfigCategory.Instance.GetAll();
            int roleLv = unit.GetComponent<UserInfoComponent>().UserInfo.Lv;
            foreach (var item in keyValuePairs)
            {
                if (item.Value.TaskType == TaskTypeEnum.EveryDay && roleLv >= item.Value.TaskLv && roleLv <= item.Value.TaskMaxLv)
                {
                    allTaskIds.Add(item.Key);
                }
            }
            int taskId = allTaskIds[RandomHelper.RandomNumber(0, allTaskIds.Count)];
            taskPro = taskComponent.OnGetTask(taskId);
            response.TaskLoop = taskPro;
            numericComponent.ApplyChange(null, NumericType.TaskLoopNumber, 1, 0);
            reply();
            await ETTask.CompletedTask;
        }
    }
}
