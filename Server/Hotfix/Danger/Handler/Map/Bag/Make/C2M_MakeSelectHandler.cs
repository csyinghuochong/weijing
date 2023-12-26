using System;
using System.Collections.Generic;

namespace ET
{

    [ActorMessageHandler]
    public class C2M_MakeSelectHandler : AMActorLocationRpcHandler<Unit, C2M_MakeSelectRequest, M2C_MakeSelectResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_MakeSelectRequest request, M2C_MakeSelectResponse response, Action reply)
        {
            int makeTypeNumeric = request.Plan == 1 ? NumericType.MakeType_1 : NumericType.MakeType_2;
            int shulianduNumeric = request.Plan == 1 ? NumericType.MakeShuLianDu_1 : NumericType.MakeShuLianDu_2;
            int oldMakeType = unit.GetComponent<NumericComponent>().GetAsInt(makeTypeNumeric);
            unit.GetComponent<UserInfoComponent>().ClearMakeListByType(oldMakeType);
            unit.GetComponent<UserInfoComponent>().UserInfo.MakeList.AddRange(MakeHelper.GetInitMakeList(request.MakeType));
            unit.GetComponent<NumericComponent>().ApplyValue( makeTypeNumeric, request.MakeType);
            unit.GetComponent<NumericComponent>().ApplyValue( shulianduNumeric, 0);
            unit.GetComponent<ChengJiuComponent>().OnSkillShuLianDu(0);
            response.MakeList = unit.GetComponent<UserInfoComponent>().UserInfo.MakeList;
            reply();
            await ETTask.CompletedTask;
        }
    }
}
