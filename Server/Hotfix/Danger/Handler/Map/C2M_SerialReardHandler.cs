using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{

    [ActorMessageHandler]
    public class C2M_SerialReardHandler : AMActorLocationRpcHandler<Unit, C2M_SerialReardRequest, M2C_SerialReardResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_SerialReardRequest request, M2C_SerialReardResponse response, Action reply)
        {
            if (unit.GetComponent<BagComponent>().GetLeftSpace() < 5)
            {
                response.Error = ErrorCore.ERR_BagIsFull;
                reply();
                return;
            }
            NumericComponent numericComponent = unit.GetComponent<NumericComponent>();
            if (numericComponent.GetAsInt(NumericType.SerialNumber) >= 5)
            {
                response.Error = ErrorCore.ERR_TimesIsNot;
                reply();
                return;
            }

            using (await CoroutineLockComponent.Instance.Wait(CoroutineLockType.Received, unit.Id))
            {
                M2Center_SerialReardRequest m2Center_Serial = new M2Center_SerialReardRequest() { SerialNumber = request.SerialNumber };
                long centerid = DBHelper.GetAccountCenter();
                Center2M_SerialReardResponse m2m_TrasferUnitResponse = (Center2M_SerialReardResponse)await ActorMessageSenderComponent.Instance.Call
                          (centerid, m2Center_Serial);

                response.Error = m2m_TrasferUnitResponse.Error;
                if (m2m_TrasferUnitResponse.Error == ErrorCore.ERR_Success)
                {
                    int serialIndex = int.Parse(m2m_TrasferUnitResponse.Message);
                    string reward = ConfigHelper.SerialReward[serialIndex];
                    unit.GetComponent<BagComponent>().OnAddItemData(reward, $"{48}_{TimeHelper.ServerNow()}");
                    numericComponent.ApplyChange( null, NumericType.SerialNumber,  1, 0);
                }
            }

            reply();
            await ETTask.CompletedTask;
        }
    }
}
