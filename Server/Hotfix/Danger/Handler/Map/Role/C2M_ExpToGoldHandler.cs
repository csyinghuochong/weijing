using System;

namespace ET
{
    [ActorMessageHandler]
    public class C2M_ExpToGoldHandler : AMActorLocationRpcHandler<Unit, C2M_ExpToGoldRequest, M2C_ExpToGoldResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_ExpToGoldRequest request, M2C_ExpToGoldResponse response, Action reply)
        {
            UserInfoComponent userInfoComponent = unit.GetComponent<UserInfoComponent>();
            UserInfo userInfo = userInfoComponent.UserInfo;
            ServerInfo serverInfo = unit.DomainScene().GetComponent<ServerInfoComponent>().ServerInfo;
            if (userInfo.Lv < serverInfo.WorldLv)
            {
                reply();
                return;
            }
    
            //低于20%经验无法兑换
            ExpConfig expCof = ExpConfigCategory.Instance.Get(userInfo.Lv);
            int costExp = (int)(expCof.UpExp * 0.2f);
            if (userInfo.Exp < costExp) {
                reply();
                return;
            }

            int sendGold = (int)(10000 + expCof.RoseGoldPro * 10);

            userInfoComponent.UpdateRoleMoneyAdd(UserDataType.Gold, sendGold.ToString(), true, ItemGetWay.System);
            userInfoComponent.UpdateRoleData(UserDataType.Exp , (costExp * -1).ToString());
            Log.Debug($"Gold:  {userInfoComponent.Id} {sendGold} excharge");

            unit.GetComponent<NumericComponent>().ApplyChange(null, NumericType.ExpToGoldTimes, 1, 0);
            reply();
            await ETTask.CompletedTask;
        }
    }
}
