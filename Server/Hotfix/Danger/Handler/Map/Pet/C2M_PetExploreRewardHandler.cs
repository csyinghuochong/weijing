using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    [ActorMessageHandler]
    public class C2M_PetExploreRewardHandler: AMActorLocationRpcHandler<Unit, C2M_PetExploreReward, M2C_PetExploreReward>
    {
        protected override async ETTask Run(Unit unit, C2M_PetExploreReward request, M2C_PetExploreReward response, Action reply)
        {
            UserInfoComponent userInfoComponent = unit.GetComponent<UserInfoComponent>();
            if (userInfoComponent.UserInfo.PetExploreRewardIds.Contains(request.RewardId))
            {
                response.Error = ErrorCode.ERR_AlreadyReceived;
                reply();
                return;
            }

            if (!ConfigHelper.PetExploreReward.Keys.Contains(request.RewardId))
            {
                response.Error = ErrorCode.ERR_ModifyData;
                reply();
                return;
            }

            if (unit.GetComponent<NumericComponent>().GetAsInt(NumericType.PetExploreNumber) < request.RewardId)
            {
                response.Error = ErrorCode.Pre_Condition_Error;
                reply();
                return;
            }

            string[] reward = ConfigHelper.PetExploreReward[request.RewardId].Split('$');
            string[] items = reward[0].Split('@');
            string[] diamond = reward[1].Split(';')[1].Split(',');
            if (unit.GetComponent<BagComponent>().GetLeftSpace() < items.Length)
            {
                response.Error = ErrorCode.ERR_BagIsFull;
                reply();
                return;
            }

            userInfoComponent.UserInfo.PetExploreRewardIds.Add(request.RewardId);
            int randomZuanshi = RandomHelper.RandomNumber(int.Parse(diamond[0]), int.Parse(diamond[1]));
            unit.GetComponent<BagComponent>().OnAddItemData(reward[0], $"{ItemGetWay.PetChouKa}_{TimeHelper.ServerNow()}");
            unit.GetComponent<UserInfoComponent>().UpdateRoleMoneyAdd(UserDataType.Diamond, randomZuanshi.ToString(), true, ItemGetWay.PetChouKa);

            reply();
            await ETTask.CompletedTask;
        }
    }
}