using System;

namespace ET
{

    [ActorMessageHandler]
    public class C2M_EnergyInfoHandler : AMActorLocationRpcHandler<Unit, C2M_EnergyInfoRequest, M2C_EnergyInfoResponse>
    {

        protected override async ETTask Run(Unit unit, C2M_EnergyInfoRequest request, M2C_EnergyInfoResponse response, Action reply)
        {
            response.GetRewards = unit.GetComponent<EnergyComponent>().GetRewards;
            response.QuestionList = unit.GetComponent<EnergyComponent>().QuestionList;
            response.QuestionIndex = unit.GetComponent<EnergyComponent>().QuestionIndex;

            reply();
            await ETTask.CompletedTask;
        }
    }
}
