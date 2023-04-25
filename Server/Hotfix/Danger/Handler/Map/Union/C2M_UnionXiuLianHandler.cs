using System;
using System.Collections.Generic;

namespace ET
{
    [ActorMessageHandler]
    public class C2M_UnionXiuLianHandler : AMActorLocationRpcHandler<Unit, C2M_UnionXiuLianRequest, M2C_UnionXiuLianResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_UnionXiuLianRequest request, M2C_UnionXiuLianResponse response, Action reply)
        {
            int numerType = UnionHelper.GetXiuLianId(request.Position);
            if (numerType == 0)
            {
                reply();
                return;
            }

            NumericComponent numericComponent = unit.GetComponent<NumericComponent>();
            int xiulianid = numericComponent.GetAsInt(numerType);

            if (xiulianid >= UnionQiangHuaConfigCategory.Instance.GetMaxId(request.Position))
            {
                response.Error = ErrorCore.ERR_UnionXiuLianMax;
                reply();
                return;
            }

            UnionQiangHuaConfig unionQiangHuaConfig = UnionQiangHuaConfigCategory.Instance.Get(xiulianid);
            if (unit.GetComponent<UserInfoComponent>().UserInfo.UnionZiJin < unionQiangHuaConfig.CostGold)
            {
                response.Error = ErrorCore.ERR_HouBiNotEnough;
                reply();
                return;
            }

            unit.GetComponent<NumericComponent>().ApplyValue( numerType, xiulianid+1);
            unit.GetComponent<UserInfoComponent>().UpdateRoleMoneySub( UserDataType.UnionZiJin,(unionQiangHuaConfig.CostGold * -1).ToString(), true, ItemGetWay.UnionXiuLian);

            reply();
            await ETTask.CompletedTask;
        }
    }
}
