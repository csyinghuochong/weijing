using System;

namespace ET
{

    [ActorMessageHandler]
    public class C2M_EnergyAnswerHandler : AMActorLocationRpcHandler<Unit, C2M_EnergyAnswerRequest, M2C_EnergyAnswerResponse>
    {

        protected override async ETTask Run(Unit unit, C2M_EnergyAnswerRequest request, M2C_EnergyAnswerResponse response, Action reply)
        {
            EnergyComponent energyComponent = unit.GetComponent<EnergyComponent>();
            energyComponent.QuestionIndex++;

            if (request.AnswerIndex == 1)
            {
                GlobalValueConfig globalValueConfig = GlobalValueConfigCategory.Instance.Get(15);
                unit.GetComponent<BagComponent>().OnAddItemData(globalValueConfig.Value, $"{ItemGetWay.ChouKa}_{TimeHelper.ServerNow()}");
            }

            reply();
            await ETTask.CompletedTask;
        }
    }
}
