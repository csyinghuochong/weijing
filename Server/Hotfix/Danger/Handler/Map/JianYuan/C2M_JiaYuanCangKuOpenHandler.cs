using System;

namespace ET
{
    [ActorMessageHandler]

    public class C2M_JiaYuanCangKuOpenHandler : AMActorLocationRpcHandler<Unit, C2M_JiaYuanCangKuOpenRequest, M2C_JiaYuanCangKuOpenResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_JiaYuanCangKuOpenRequest request, M2C_JiaYuanCangKuOpenResponse response, Action reply)
        {
            int cangkuNumber = unit.GetComponent<NumericComponent>().GetAsInt(NumericType.JianYuanCangKu);
            if (cangkuNumber >= 4)
            {
                response.Error = ErrorCore.ERR_Error;
                reply();
                return;
            }

            string costItems = GlobalValueConfigCategory.Instance.Get(86).Value;
            if (!unit.GetComponent<BagComponent>().OnCostItemData(costItems))
            {
                response.Error = ErrorCore.ERR_ItemNotEnoughError;
                reply();
                return;
            }

            unit.GetComponent<NumericComponent>().ApplyValue(NumericType.JianYuanCangKu, cangkuNumber + 1);
            reply();
            await ETTask.CompletedTask;
        }
    }
}
