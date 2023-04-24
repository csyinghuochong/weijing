using System;
using UnityEngine;

namespace ET
{
    [ActorMessageHandler]
    public class C2M_XiuLianCenterHandler : AMActorLocationRpcHandler<Unit, C2M_XiuLianCenterRequest, M2C_XiuLianCenterResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_XiuLianCenterRequest request, M2C_XiuLianCenterResponse response, Action reply)
        {

            int level = unit.GetComponent<UserInfoComponent>().UserInfo.Lv;
            //1 经验  2金币
            if (request.XiuLianType == 1)
            {
                int xiulianNumber = unit.GetComponent<NumericComponent>().GetAsInt(NumericType.XiuLian_ExpNumber);
                if (xiulianNumber >= 3)
                {
                    reply();
                    return;
                }
            
                unit.GetComponent<NumericComponent>().ApplyValue(NumericType.XiuLian_ExpNumber, xiulianNumber+1);
                unit.GetComponent<NumericComponent>().ApplyValue(NumericType.XiuLian_ExpTime, TimeHelper.ServerNow());
                float coefficient = float.Parse(GlobalValueConfigCategory.Instance.Get(29).Value);
                int addValue = Mathf.CeilToInt(coefficient * level);
                unit.GetComponent<UserInfoComponent>().UpdateRoleData( UserDataType.Exp, addValue.ToString());
            }
            if (request.XiuLianType == 2)
            {
                int xiulianNumber = unit.GetComponent<NumericComponent>().GetAsInt(NumericType.XiuLian_CoinNumber);
                if (xiulianNumber >= 3)
                {
                    reply();
                    return;
                }
                unit.GetComponent<NumericComponent>().ApplyValue(NumericType.XiuLian_CoinNumber, xiulianNumber + 1);
                unit.GetComponent<NumericComponent>().ApplyValue(NumericType.XiuLian_CoinTime, TimeHelper.ServerNow());
                float coefficient = float.Parse(GlobalValueConfigCategory.Instance.Get(30).Value);
                int addValue = Mathf.CeilToInt(coefficient * level);
                unit.GetComponent<UserInfoComponent>().UpdateRoleMoneyAdd(UserDataType.Gold, addValue.ToString(), true, 37);// ItemGetWay.XiuLian);
            }
            reply();
            await ETTask.CompletedTask;
        }
    }
}
