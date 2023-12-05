using System;
using System.Collections.Generic;
using System.Linq;

namespace ET
{
    [ActorMessageHandler]
    public class C2M_LeavlRewardHandler: AMActorLocationRpcHandler<Unit, C2M_LeavlRewardRequest, M2C_LeavlRewardResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_LeavlRewardRequest request, M2C_LeavlRewardResponse response, Action reply)
        {
            if (!ConfigHelper.LeavlRewardItem.Keys.Contains(request.LvKey))
            {
                response.Error = ErrorCode.ERR_ModifyData;
                reply();
                return;
            }

            if (unit.GetComponent<NumericComponent>().GetAsInt(NumericType.LeavlReward) >= request.LvKey)
            {
                response.Error = ErrorCode.ERR_ModifyData;
                reply();
                return;
            }

            if (unit.GetComponent<UserInfoComponent>().UserInfo.Lv < request.LvKey)
            {
                response.Error = ErrorCode.ERR_ModifyData;
                reply();
                return;
            }

            string[] items = ConfigHelper.LeavlRewardItem[request.LvKey].Split('@');
            if (items.Length < request.Index + 1 || request.Index < 0)
            {
                response.Error = ErrorCode.ERR_ModifyData;
                reply();
                return;
            }

            string item = items[request.Index];
            unit.GetComponent<NumericComponent>().ApplyValue(NumericType.LeavlReward, request.LvKey);
            unit.GetComponent<BagComponent>().OnAddItemData(item, $"{ItemGetWay.LeavlReward}_{TimeHelper.ServerNow()}");
            reply();
            await ETTask.CompletedTask;
        }
    }
}