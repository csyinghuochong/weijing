using System;

namespace ET
{

    [ActorMessageHandler]
    public class C2M_JiaYuanExchangeHandler : AMActorLocationRpcHandler<Unit, C2M_JiaYuanExchangeRequest, M2C_JiaYuanExchangeResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_JiaYuanExchangeRequest request, M2C_JiaYuanExchangeResponse response, Action reply)
        {
            NumericComponent numericComponent = unit.GetComponent<NumericComponent>();
            UserInfoComponent userInfoComponent=unit.GetComponent<UserInfoComponent>();
            UserInfo userInfo = userInfoComponent.UserInfo;
            JiaYuanConfig jiaYuanConfig = JiaYuanConfigCategory.Instance.Get(userInfo.JiaYuanLv);
            switch (request.ExchangeType)
            {
                case 1: //金币兑换资金
                    if (numericComponent.GetAsInt(NumericType.JiaYuanExchangeZiJin) >= 10)
                    {
                        response.Error = ErrorCore.ERR_TimesIsNot;
                        reply();
                        return;
                    }
                   
                    if (userInfo.Gold < jiaYuanConfig.ExchangeZiJinCostGold)
                    {
                        response.Error = ErrorCore.ERR_ItemNotEnoughError;
                        reply();
                        return;
                    }

                    userInfoComponent.UpdateRoleMoneySub(UserDataType.Gold, (jiaYuanConfig.ExchangeZiJinCostGold * -1).ToString(), true, ItemGetWay.JiaYuanCost);
                    userInfoComponent.UpdateRoleMoneyAdd(UserDataType.JiaYuanFund, (jiaYuanConfig.ExchangeZiJin).ToString(), true, ItemGetWay.JiaYuanExchange);
                    break;
                case 2: //资金兑换经验
                    if (numericComponent.GetAsInt(NumericType.JiaYuanExchangeExp) >= 10)
                    {
                        response.Error = ErrorCore.ERR_TimesIsNot;
                        reply();
                        return;
                    }
                   
                    if (userInfo.JiaYuanFund < jiaYuanConfig.ExchangeExpCostZiJin)
                    {
                        response.Error = ErrorCore.ERR_ItemNotEnoughError;
                        reply();
                        return;
                    }

                    userInfoComponent.UpdateRoleMoneySub(UserDataType.JiaYuanFund, (jiaYuanConfig.ExchangeExpCostZiJin * -1).ToString(), true, ItemGetWay.JiaYuanCost);
                    userInfoComponent.UpdateRoleMoneyAdd(UserDataType.JiaYuanExp, (jiaYuanConfig.ExchangeExp).ToString(), true, ItemGetWay.JiaYuanExchange);
                    break;
                default:
                    break;
            }

            reply();
            await ETTask.CompletedTask;
        }
    }
}
