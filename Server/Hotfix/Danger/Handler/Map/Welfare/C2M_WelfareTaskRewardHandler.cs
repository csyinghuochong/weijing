using System;
using System.Collections.Generic;

namespace ET
{
    [ActorMessageHandler]
    public class C2M_WelfareTaskRewardHandler : AMActorLocationRpcHandler<Unit, C2M_WelfareTaskRewardRequest, M2C_WelfareTaskRewardResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_WelfareTaskRewardRequest request, M2C_WelfareTaskRewardResponse response, Action reply)
        {
            TaskComponent taskComponent = unit.GetComponent<TaskComponent>();   
            bool canget = TaskHelper.IsDayTaskComplete(taskComponent.RoleComoleteTaskList, request.day);
            if (!canget)
            {
                response.Error = ErrorCode.Pre_Condition_Error;
                reply();
                return;
            }
            if (!unit.GetComponent<UserInfoComponent>().UserInfo.WelfareTaskRewards.Contains(request.day))
            {
                response.Error = ErrorCode.ERR_AlreadyReceived;
                reply();
                return;
            }

            string reward = ConfigHelper.WelfareTaskReward[request.day];
            if (!unit.GetComponent<BagComponent>().OnAddItemData(reward, $"{ItemGetWay.Welfare}_{TimeHelper.ServerNow()}"))
            { 
                response.Error = ErrorCode.ERR_BagIsFull;
                reply();
                return;
            }
            unit.GetComponent<UserInfoComponent>().UserInfo.WelfareTaskRewards.Add(request.day);

            reply();
            await ETTask.CompletedTask;
        }
    }
}
