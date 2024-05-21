using System;

namespace ET
{

    [ActorMessageHandler]
    public class C2M_EnergyAnswerHandler : AMActorLocationRpcHandler<Unit, C2M_EnergyAnswerRequest, M2C_EnergyAnswerResponse>
    {

        protected override async ETTask Run(Unit unit, C2M_EnergyAnswerRequest request, M2C_EnergyAnswerResponse response, Action reply)
        {
            if (unit.DomainZone() != 0)
            {
                Log.Error($"C2M_EnergyAnswerRequest 1");
                response.Error = ErrorCode.ERR_ModifyData;
                reply();
                return;
            }

            EnergyComponent energyComponent = unit.GetComponent<EnergyComponent>();
            energyComponent.QuestionIndex++;
            if (request.AnswerIndex == 1)
            {
                GlobalValueConfig globalValueConfig = GlobalValueConfigCategory.Instance.Get(15);
                unit.GetComponent<BagComponent>().OnAddItemData(globalValueConfig.Value, $"{ItemGetWay.Energy}_{TimeHelper.ServerNow()}");
            }

            reply();
            await ETTask.CompletedTask;
        }
    }
}
