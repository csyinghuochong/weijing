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
                TaskComponent taskComponent = unit.GetComponent<TaskComponent>();
                for (int i = 0; i < taskComponent.TaskCountryList.Count; i++)
                {
                    if (taskComponent.TaskCountryList[i].taskID != request.TaskId)
                    {
                        continue;
                    }
                    taskComponent.TaskCountryList[i].taskStatus = (int)TaskStatuEnum.Commited;
                    break;
                }

                TaskCountryConfig taskCountryConfig = TaskCountryConfigCategory.Instance.Get(request.TaskId);
                unit.GetComponent<BagComponent>().OnAddItemData(taskCountryConfig.RewardItem, $"{ItemGetWay.TaskCountry}_{TimeHelper.ServerNow()}");

                //添加金币
                unit.GetComponent<UserInfoComponent>().UpdateRoleData(UserDataType.Gold, taskCountryConfig.RewardGold.ToString()).Coroutine();
                //添加活跃
                unit.GetComponent<UserInfoComponent>().UpdateRoleData(UserDataType.HuoYue, taskCountryConfig.EveryTaskRewardNum.ToString()).Coroutine();

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
