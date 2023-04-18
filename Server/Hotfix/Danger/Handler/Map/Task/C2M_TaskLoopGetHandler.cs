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
                response.Error = ErrorCore.ERR_TaskCanNotGet;
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

            NumericComponent numericComponent = unit.GetComponent<NumericComponent>();
            int taskLoopId = numericComponent.GetAsInt(NumericType.TaskLoopID);
            if (taskLoopId == 0)
            {
                LogHelper.LogDebug($"{unit.Id}  taskLoopId == 0");
                response.Error = ErrorCore.ERR_TaskCanNotGet;
                reply();
                return;
            }
            numericComponent.ApplyChange(null, NumericType.TaskLoopNumber, 1, 0);
            response.TaskLoop = taskComponent.OnGetLoopTask(taskLoopId);
            reply();

            await ETTask.CompletedTask;
        }
    }
}
