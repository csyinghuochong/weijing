using System;
using System.Collections.Generic;
using System.Linq;

namespace ET
{
    [ActorMessageHandler]
    public class C2M_KillMonsterRewardHandler: AMActorLocationRpcHandler<Unit, C2M_KillMonsterRewardRequest, M2C_KillMonsterRewardResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_KillMonsterRewardRequest request, M2C_KillMonsterRewardResponse response, Action reply)
        {
            if (!ConfigHelper.KillMonsterReward.Keys.Contains(request.Key))
            {
                response.Error = ErrorCode.ERR_ModifyData;
                reply();
                return;
            }

            if (unit.GetComponent<NumericComponent>().GetAsInt(NumericType.KillMonsterReward) >= request.Key)
            {
                response.Error = ErrorCode.ERR_ModifyData;
                reply();
                return;
            }

            if (unit.GetComponent<NumericComponent>().GetAsInt(NumericType.KillMonsterNumber) < request.Key)
            {
                response.Error = ErrorCode.ERR_ModifyData;
                reply();
                return;
            }

            UserInfoComponent userInfoComponent = unit.GetComponent<UserInfoComponent>();
            string[] occItems = ConfigHelper.KillMonsterReward[request.Key].Split('&');
            string[] items;
            if (occItems.Length == 3)
            {
                items = occItems[userInfoComponent.UserInfo.Occ - 1].Split('@');
            }
            else
            {
                items = occItems[0].Split('@');
            }

            if (items.Length < request.Index + 1 || request.Index < 0)
            {
                response.Error = ErrorCode.ERR_ModifyData;
                reply();
                return;
            }

            string item = items[request.Index];
            unit.GetComponent<NumericComponent>().ApplyValue(NumericType.KillMonsterReward, request.Key);
            unit.GetComponent<BagComponent>().OnAddItemData(item, $"{ItemGetWay.KillMonsterReward}_{TimeHelper.ServerNow()}");
            reply();
            await ETTask.CompletedTask;
        }
    }
}