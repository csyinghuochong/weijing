using System.Collections.Generic;

namespace ET
{
    public static class RechargeHelp
    {

        public static void  SendDiamondToUnit(Unit unit, int rechargeNumber, string orderInfo)
        {
            LogHelper.LogWarning($"RechargeHelp.SendDiamond {unit.Id} {rechargeNumber} {orderInfo}");
            OnRechage(unit, rechargeNumber, true);
            long accountId = unit.GetComponent<UserInfoComponent>().UserInfo.AccInfoID;
            long userId = unit.GetComponent<UserInfoComponent>().UserInfo.UserId;
            SendToAccountCenter(accountId, userId, rechargeNumber, orderInfo).Coroutine();
            unit.GetComponent<DBSaveComponent>().UpdateCacheDB();
        }

        public static void OnRechage(Unit unit, int rechargeNumber, bool notice)
        {
            if (rechargeNumber <= 0)
            { 
                return; 
            }
            int number = ComHelp.GetDiamondNumber(rechargeNumber);
            unit.GetComponent<UserInfoComponent>().UpdateRoleData(UserDataType.Diamond, number.ToString(), notice);
            NumericComponent numericComponent = unit.GetComponent<NumericComponent>();
            numericComponent.ApplyChange(null, NumericType.RechargeNumber, rechargeNumber, 0, notice);
            //已经领取的不充值
            if (numericComponent.GetAsInt(NumericType.RechargeSign) != 2)
            {
                numericComponent.ApplyValue(NumericType.RechargeSign, 1, notice);
            }
        }

        public static async ETTask SendToAccountCenter(long accountId, long userId, int rechargeNumber, string ordinfo)
        {
            A2Center_RechargeRequest rechargeRequest = new A2Center_RechargeRequest()
            {
                AccountId = accountId,
                RechargeInfo = new RechargeInfo()
                {
                    Amount = rechargeNumber,
                    Time = TimeHelper.ServerNow(),
                    UserId = userId,
                    OrderInfo = ordinfo
                }
            };
            long accountZone = DBHelper.GetAccountCenter();
            Center2A_RechargeResponse saveAccount = (Center2A_RechargeResponse)await ActorMessageSenderComponent.Instance.Call(accountZone, rechargeRequest);
        }

        public static async ETTask OnPaySucessToUnit(Scene scene,  long userId, int rechargeNumber, string orderInfo)
        {
            Player gateUnitInfo = scene.GetComponent<PlayerComponent>().GetByUserId(userId);
            //&& gateUnitInfo.ClientSession!=null
            if (gateUnitInfo != null  && gateUnitInfo.PlayerState == PlayerState.Game && gateUnitInfo.InstanceId > 0)
            {
                LogHelper.LogWarning($"充值OnPaySucess PlayerState.Game: {userId}  rechargeNumber:{rechargeNumber}");
                G2M_RechargeResultRequest r2M_RechargeRequest = new G2M_RechargeResultRequest() { RechargeNumber = rechargeNumber , OrderInfo = orderInfo};
                M2G_RechargeResultResponse m2G_RechargeResponse = (M2G_RechargeResultResponse)await ActorLocationSenderComponent.Instance.Call(gateUnitInfo.UnitId, r2M_RechargeRequest);
            }
            else
            {
                LogHelper.LogWarning($"充值OnPaySucess PlayerState.None: {userId}  rechargeNumber:{rechargeNumber}");
                //直接存数据库
                //int number = ComHelp.GetDiamondNumber(rechargeNumber);
                long dbCacheId = DBHelper.GetDbCacheId(scene.DomainZone());
                D2G_GetComponent d2GGetUnit = (D2G_GetComponent)await ActorMessageSenderComponent.Instance.Call(dbCacheId, new G2D_GetComponent() { UnitId = userId, Component = DBHelper.NumericComponent });
                NumericComponent numericComponent = (d2GGetUnit.Component as NumericComponent);
                numericComponent.ApplyChange(null, NumericType.RechargeBuChang, rechargeNumber, 0, false);
                D2M_SaveComponent d2GSave = (D2M_SaveComponent)await ActorMessageSenderComponent.Instance.Call(dbCacheId, new M2D_SaveComponent()
                {
                    UnitId = userId,
                    EntityByte = MongoHelper.ToBson(numericComponent),
                    ComponentType = DBHelper.NumericComponent
                });

                d2GGetUnit = (D2G_GetComponent)await ActorMessageSenderComponent.Instance.Call(dbCacheId, new G2D_GetComponent() { UnitId = userId, Component = DBHelper.UserInfoComponent });
                UserInfoComponent userInfoComponent = (d2GGetUnit.Component as UserInfoComponent);
                
                long accountId = userInfoComponent.UserInfo.AccInfoID;
                SendToAccountCenter(accountId, userId, rechargeNumber, orderInfo).Coroutine();
                await ETTask.CompletedTask;
            }
        }

        public static async ETTask OnPaySucessToGate( int zone, long userId, int rechargeNumber, string orderInfo)
        {
            long gateServerId = DBHelper.GetGateServerId(zone);
            R2G_RechargeResultRequest r2M_RechargeRequest = new R2G_RechargeResultRequest() { RechargeNumber = rechargeNumber, UserID = userId , OrderInfo = orderInfo};
            G2R_RechargeResultResponse m2G_RechargeResponse = (G2R_RechargeResultResponse)await ActorMessageSenderComponent.Instance.Call(gateServerId, r2M_RechargeRequest);
        }
    }
}
