using System;

namespace ET
{

    [ActorMessageHandler]
    public class C2M_BuChangeRequestHandler : AMActorLocationRpcHandler<Unit, C2M_BuChangeRequest, M2C_BuChangeResponse>
    {

        protected override async ETTask Run(Unit unit, C2M_BuChangeRequest request, M2C_BuChangeResponse response, Action reply)
        {
            long accountZone = DBHelper.GetAccountCenter();
            UserInfoComponent userInfoComponent = unit.GetComponent<UserInfoComponent>();
            Center2M_BuChangeResponse centerAccount = (Center2M_BuChangeResponse)await ActorMessageSenderComponent.Instance.Call(accountZone, new M2Center_BuChangeRequest()
            { 
                BuChangId = request.BuChangId,
                UserId = userInfoComponent.Id,
                AccountId = userInfoComponent.UserInfo.AccInfoID
            });
            int rechargeNum = unit.GetComponent<NumericComponent>().GetAsInt(NumericType.RechargeNumber);
            rechargeNum += centerAccount.BuChangRecharge;
            unit.GetComponent<NumericComponent>().ApplyValue( NumericType.RechargeNumber, rechargeNum);
            unit.GetComponent<UserInfoComponent>().UpdateRoleMoneyAdd( UserDataType.Diamond, centerAccount.BuChangDiamond.ToString(), true, ItemGetWay.BuChang);
            response.PlayerInfo = centerAccount.PlayerInfo;
            reply();
            await ETTask.CompletedTask;
        }
    }
}
