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
                int number = ComHelp.GetDiamondNumber(rechargeNumber);
                long accountId = gateUnitInfo.AccountId;
                A2Center_RechargeRequest rechargeRequest = new A2Center_RechargeRequest()
                {
                    AccountId = accountId,
                    RechargeInfo = new RechargeInfo()
                    {
                        Amount = rechargeNumber,
                        Time = TimeHelper.ServerNow(),
                        UserId =userId
                    }
                };
                long accountZone = DBHelper.GetAccountCenter();
                Center2A_RechargeResponse saveAccount = (Center2A_RechargeResponse)await ActorMessageSenderComponent.Instance.Call(accountZone, rechargeRequest);
                
                long dbCacheId = DBHelper.GetDbCacheId(scene.DomainZone());
                D2G_GetComponent d2GGetUnit = (D2G_GetComponent)await ActorMessageSenderComponent.Instance.Call(dbCacheId, new G2D_GetComponent() { CharacterId =userId, Component = DBHelper.UserInfoComponent });
                UserInfoComponent userInfoComponent = (d2GGetUnit.Component as UserInfoComponent);
                userInfoComponent.UserInfo.Diamond += number;
                
                d2GGetUnit = (D2G_GetComponent)await ActorMessageSenderComponent.Instance.Call(dbCacheId, new G2D_GetComponent() { CharacterId = userId, Component = DBHelper.NumericComponent });
                NumericComponent numericComponent = (d2GGetUnit.Component as NumericComponent);
                    numericComponent.ApplyChange(null, NumericType.RechargeNumber, number, 0, false);
                D2M_SaveComponent d2GSave = (D2M_SaveComponent)await ActorMessageSenderComponent.Instance.Call(dbCacheId, new M2D_SaveComponent()
                {
                    CharacterId = userId,
                    Component = userInfoComponent,
                    ComponentType = DBHelper.UserInfoComponent
                });
                d2GSave = (D2M_SaveComponent)await ActorMessageSenderComponent.Instance.Call(dbCacheId, new M2D_SaveComponent()
                {
                    CharacterId = userId,
                    Component = numericComponent,
                    ComponentType = DBHelper.NumericComponent
                });
                await ETTask.CompletedTask;
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
