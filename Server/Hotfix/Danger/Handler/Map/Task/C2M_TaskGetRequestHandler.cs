using System;

namespace ET
{ 

    [ActorMessageHandler]
    public class C2M_TaskGetRequestHandler : AMActorLocationRpcHandler<Unit, C2M_TaskGetRequest, M2C_TaskGetResponse>
    {

        protected override async ETTask Run(Unit unit, C2M_TaskGetRequest request, M2C_TaskGetResponse response, Action reply)
        {
            TaskConfig taskConfig = TaskConfigCategory.Instance.Get(request.TaskId);
            if (taskConfig.TaskType == TaskTypeEnum.EveryDay)
            {
                TaskComponent taskComponent = unit.GetComponent<TaskComponent>();
                if (taskComponent.GetTaskList(TaskTypeEnum.EveryDay).Count > 0)
                {
                    response.Error = ErrorCore.ERR_TaskCanNotGet;
                    reply();
                    return;
                }

                //获取当前任务是否已达上限
                if (unit.GetComponent<NumericComponent>().GetAsInt(NumericType.LoopTaskNumber) >= GlobalValueConfigCategory.Instance.Get(58).Value2)
                {
                    response.Error = ErrorCore.ERR_ShangJinNumFull;
                    reply();
                    return;
                }

                NumericComponent numericComponent = unit.GetComponent<NumericComponent>();
                int taskLoopId = numericComponent.GetAsInt(NumericType.LoopTaskID);
                if (taskLoopId == 0)
                {
                    LogHelper.LogDebug($"{unit.Id}  taskLoopId == 0");
                    response.Error = ErrorCore.ERR_TaskCanNotGet;
                    reply();
                    return;
                }
                numericComponent.ApplyChange(null, NumericType.LoopTaskNumber, 1, 0);
                response.TaskPro = taskComponent.OnGetLoopTask(taskLoopId);
            }
            else if (taskConfig.TaskType == TaskTypeEnum.Union)
            {
                TaskComponent taskComponent = unit.GetComponent<TaskComponent>();
                if (taskComponent.GetTaskList(TaskTypeEnum.Union).Count > 0)
                {
                    response.Error = ErrorCore.ERR_TaskCanNotGet;
                    reply();
                    return;
                }

                //获取当前任务是否已达上限
                if (unit.GetComponent<NumericComponent>().GetAsInt(NumericType.UnionTaskNumber) >= 1)
                {
                    response.Error = ErrorCore.ERR_TaskCanNotGet;
                    reply();
                    return;
                }

                NumericComponent numericComponent = unit.GetComponent<NumericComponent>();
                int taskLoopId = numericComponent.GetAsInt(NumericType.UnionTaskId);
                if (taskLoopId == 0)
                {
                    LogHelper.LogDebug($"{unit.Id}  taskLoopId == 0");
                    response.Error = ErrorCore.ERR_TaskCanNotGet;
                    reply();
                    return;
                }
                numericComponent.ApplyChange(null, NumericType.UnionTaskNumber, 1, 0);
                response.TaskPro = taskComponent.OnGetLoopTask(taskLoopId);
            }
            else
            {
                TaskPro taskPro = unit.GetComponent<TaskComponent>().OnGetTask(request.TaskId);
                response.Error = taskPro != null ? ErrorCore.ERR_Success : ErrorCore.ERR_TaskCanNotGet;
                response.TaskPro = taskPro;
            }
           
            reply();
            await ETTask.CompletedTask;
        }
    }
}
