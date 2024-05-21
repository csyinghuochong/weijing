using System;


namespace ET
{

    [ActorMessageHandler]
    public class C2M_EnergyReceiveHandler : AMActorLocationRpcHandler<Unit, C2M_EnergyReceiveRequest, M2C_EnergyReceiveResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_EnergyReceiveRequest request, M2C_EnergyReceiveResponse response, Action reply)
        {
            if (unit.DomainZone() != 3)
            {
                Log.Error($"C2M_EnergyReceiveRequest.1");
                response.Error = ErrorCode.ERR_ModifyData;
                reply();
                return;
            }

            EnergyComponent energyComponent = unit.GetComponent<EnergyComponent>();
            if (request.RewardType < 0 || request.RewardType >= energyComponent.GetRewards.Count)
            {
                Log.Error($"C2M_EnergyReceiveRequest.2");
                response.Error = ErrorCode.ERR_ModifyData;
                reply();
                return;
            }
            if (energyComponent.GetRewards[request.RewardType] == 1)
            {
                Log.Error($"C2M_EnergyReceiveRequest.3");
                response.Error = ErrorCode.ERR_ModifyData;
                reply();
                return;
            }
            //0 早起  1早睡 2 答题
            if (request.RewardType == 1 && !energyComponent.EarlySleepReward)
            {
                Log.Error($"C2M_EnergyReceiveRequest.4");
                response.Error = ErrorCode.ERR_ModifyData;
                reply();
                return;
            }

            unit.GetComponent<EnergyComponent>().GetRewards[request.RewardType] = 1;

            string rewardItems = "";
            if (request.RewardType == 0)
                rewardItems = GlobalValueConfigCategory.Instance.Get(13).Value;
            else if (request.RewardType == 1)
                rewardItems = GlobalValueConfigCategory.Instance.Get(14).Value;
            else
                rewardItems = "";

            unit.GetComponent<BagComponent>().OnAddItemData(rewardItems, $"{ItemGetWay.Energy}_{TimeHelper.ServerNow()}");

            reply();
            await ETTask.CompletedTask;
        }

    }
}
