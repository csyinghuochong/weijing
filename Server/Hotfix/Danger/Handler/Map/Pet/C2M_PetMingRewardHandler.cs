using System;


namespace ET
{

    [ActorMessageHandler]
    public class C2M_PetMingRewardHandler : AMActorLocationRpcHandler<Unit, C2M_PetMingRewardRequest, M2C_PetMingRewardResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_PetMingRewardRequest request, M2C_PetMingRewardResponse response, Action reply)
        {
            if (ConfigHelper.PetMiningReward.ContainsKey(request.Number))
            {
                response.Error = ErrorCode.ERR_ModifyData;
                reply();
                return;
            }

            if (unit.GetComponent<UserInfoComponent>().UserInfo.PetMingRewards.Contains(request.Number  ))
            {
                response.Error = ErrorCode.ERR_AlreadyReceived;
                reply();
                return;
            }

            int petmingNumber = unit.GetComponent<NumericComponent>().GetAsInt( NumericType.PetMineNumber );
            if (petmingNumber < request.Number)
            {
                response.Error = ErrorCode.Pre_Condition_Error;
                reply();
                return;
            }

            string rewarditems = ConfigHelper.PetMiningReward[request.Number];
            if (!unit.GetComponent<BagComponent>().OnAddItemData(rewarditems, $"{ItemGetWay.PetMine}_{TimeHelper.ServerNow()}"))
            {
                response.Error = ErrorCode.ERR_BagIsFull;
                reply();
                return;
            }

            unit.GetComponent<UserInfoComponent>().UserInfo.PetMingRewards.Add(request.Number);
            reply();
            await ETTask.CompletedTask;
        }
    }
}
