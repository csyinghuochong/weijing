using System.Collections.Generic;

namespace ET
{
    public static class RechargeHelp
    {

        public static async ETTask SendDiamondToUnit(Unit unit, int rechargeNumber)
        {
            int number = ComHelp.GetDiamondNumber(rechargeNumber);
            long accountId = unit.GetComponent<UserInfoComponent>().UserInfo.AccInfoID;
            A2Center_RechargeRequest rechargeRequest = new A2Center_RechargeRequest()
            {
                AccountId = accountId,
                RechargeInfo = new RechargeInfo()
                {
                    Amount = rechargeNumber,
                    Time = TimeHelper.ServerNow(),
                    UserId = unit.GetComponent<UserInfoComponent>().UserInfo.UserId,
                }
            };
            long accountZone = DBHelper.GetAccountCenter();
            Center2A_RechargeResponse saveAccount = (Center2A_RechargeResponse)await ActorMessageSenderComponent.Instance.Call(accountZone, rechargeRequest);
            unit.GetComponent<UserInfoComponent>().UpdateRoleData(UserDataType.Diamond, number.ToString()).Coroutine();
            unit.GetComponent<NumericComponent>().ApplyChange(null, NumericType.RechargeNumber, rechargeNumber, 0);
            await ETTask.CompletedTask;
        }

        public static async ETTask OnPaySucessToUnit(Scene scene,  long userId, int rechargeNumber)
        {
            Player gateUnitInfo = scene.GetComponent<PlayerComponent>().GetByUserId(userId);

            if (gateUnitInfo.PlayerState == PlayerState.Game && gateUnitInfo.InstanceId > 0)
            {
                G2M_RechargeResultRequest r2M_RechargeRequest = new G2M_RechargeResultRequest() { RechargeNumber = rechargeNumber };
                M2G_RechargeResultResponse m2G_RechargeResponse = (M2G_RechargeResultResponse)await ActorLocationSenderComponent.Instance.Call(gateUnitInfo.UnitId, r2M_RechargeRequest);
            }
            else
            {
                //直接存数据库
            }
        }

        public static async ETTask OnPaySucessToScene(Scene scene, int zone, long userId, int rechargeNumber)
        {
            long gateServerId = DBHelper.GetGateServerId(zone);
            R2G_RechargeResultRequest r2M_RechargeRequest = new R2G_RechargeResultRequest() { RechargeNumber = rechargeNumber, UserID = userId };
            G2R_RechargeResultResponse m2G_RechargeResponse = (G2R_RechargeResultResponse)await ActorMessageSenderComponent.Instance.Call(gateServerId, r2M_RechargeRequest);
        }
    }
}
