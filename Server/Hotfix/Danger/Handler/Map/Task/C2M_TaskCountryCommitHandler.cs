using System;


namespace ET
{

    [ActorMessageHandler]
    public class C2M_TaskCountryCommitHandler : AMActorLocationRpcHandler<Unit, C2M_CommitTaskCountryRequest, M2C_CommitTaskCountryResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_CommitTaskCountryRequest request, M2C_CommitTaskCountryResponse response, Action reply)
        {
            try
            {
                int errorCode = ErrorCore.ERR_Success;
                TaskComponent taskComponent = unit.GetComponent<TaskComponent>();
                for (int i = 0; i < taskComponent.TaskCountryList.Count; i++)
                {
                    TaskPro taskPro = taskComponent.TaskCountryList[i]; 
                    if (taskPro.taskID != request.TaskId)
                    {
                        continue;
                    }
                    if (taskPro.taskStatus >= (int)TaskStatuEnum.Commited)
                    {
                        errorCode = ErrorCore.ERR_OperationOften;
                        break;
                    }
                    taskPro.taskStatus = (int)TaskStatuEnum.Commited;
                    break;
                }
                if (errorCode!= ErrorCore.ERR_Success)
                {
                    response.Error = errorCode; 
                    reply();
                    return;
                }
                TaskCountryConfig taskCountryConfig = TaskCountryConfigCategory.Instance.Get(request.TaskId);
                int itemItem = taskCountryConfig.RewardItem.Split('@').Length;
                if (unit.GetComponent<BagComponent>().GetSpaceNumber() < itemItem)
                {
                    response.Error = ErrorCore.ERR_BagIsFull;
                    reply();
                    return;
                }

                unit.GetComponent<BagComponent>().OnAddItemData(taskCountryConfig.RewardItem, $"{ItemGetWay.TaskCountry}_{TimeHelper.ServerNow()}");

                //添加金币
                unit.GetComponent<UserInfoComponent>().UpdateRoleData(UserDataType.Gold, taskCountryConfig.RewardGold.ToString());
                //添加活跃
                unit.GetComponent<UserInfoComponent>().UpdateRoleData(UserDataType.HuoYue, taskCountryConfig.EveryTaskRewardNum.ToString());
                Log.Debug($"TaskCountry:  {unit.Id} gold: {taskCountryConfig.RewardGold} task: {request.TaskId}");
                reply();
                await ETTask.CompletedTask;
            }
            catch (Exception ex)
            {
                Log.Debug(ex.ToString());
            }
        }
    }
}
