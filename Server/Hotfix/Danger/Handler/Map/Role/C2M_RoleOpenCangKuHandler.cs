using System;

namespace ET
{
    [ActorMessageHandler]
    public class C2M_RoleOpenCangKuHandler : AMActorLocationRpcHandler<Unit, C2M_RoleOpenCangKuRequest, M2C_RoleOpenCangKuResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_RoleOpenCangKuRequest request, M2C_RoleOpenCangKuResponse response, Action reply)
        {
            int cangkuNumber = unit.GetComponent<NumericComponent>().GetAsInt(NumericType.CangKuNumber);
            if (cangkuNumber >= 4)
            {
                response.Error = ErrorCore.ERR_Error;
                reply();
                return;
            }

            string costItems = GlobalValueConfigCategory.Instance.Get(38).Value;
            if (!unit.GetComponent<BagComponent>().OnCostItemData(costItems))
            {
                response.Error = ErrorCore.ERR_ItemNotEnoughError;
                reply();
                return;
            }

            unit.GetComponent<NumericComponent>().ApplyValue(NumericType.CangKuNumber, cangkuNumber+1);
            reply();
            await ETTask.CompletedTask;
        }
    }
}
