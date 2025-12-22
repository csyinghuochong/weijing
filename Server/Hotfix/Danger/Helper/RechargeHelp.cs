using NLog.Fluent;
using System;
using System.Collections.Generic;

namespace ET
{
    public static class RechargeHelp
    {

        public static void  SendDiamondToUnit(Unit unit, int rechargeNumber, string orderInfo, int rechargeType)
        {
            //Log.Warning($"RechargeHelp.SendDiamond {unit.Id} {rechargeNumber} {orderInfo}");
            OnRechage(unit, rechargeNumber, rechargeType, true);
            long accountId = unit.GetComponent<UserInfoComponent>().UserInfo.AccInfoID;
            long userId = unit.GetComponent<UserInfoComponent>().UserInfo.UserId;
            SendToAccountCenter(accountId, userId, rechargeNumber, orderInfo).Coroutine();
            unit.GetComponent<DBSaveComponent>().UpdateCacheDB();
        }

        public static void OnRechage(Unit unit, int rechargeNumber, int rechargetType, bool notice)
        {
            if (rechargeNumber <= 0)
            { 
                return; 
            }
        
            NumericComponent numericComponent = unit.GetComponent<NumericComponent>();

            //0 砖石  1周卡
            if (rechargetType == 0)
            {
                int number = ConfigHelper.GetDiamondNumber(rechargeNumber, unit.DomainZone());
                unit.GetComponent<UserInfoComponent>().UpdateRoleMoneyAdd(UserDataType.Diamond, number.ToString(), notice, ItemGetWay.Recharge);
            }
            else
            {

                Console.WriteLine($"OnRechage: {unit.Id}   {rechargetType}  {rechargeNumber}");

                if (rechargeNumber == 30)
                {
                    long serverTime = TimeHelper.ServerNow();
                    long cardtime = unit.GetComponent<NumericComponent>().GetAsLong(NumericType.GoldWeeklyCard);

                    //如果是在第七天开启的， 当天不能领取奖励， 则把时间设置到零点
                    if (serverTime > cardtime && ComHelp.GetDaysDiffByDate(serverTime, cardtime) == 6)
                    {
                        cardtime = ComHelp.GetNextDayZeroOneTimestampMilliseconds(serverTime);
                    }
                    else
                    {
                        cardtime = serverTime;
                    }

                    unit.GetComponent<NumericComponent>().ApplyValue(NumericType.GoldWeeklyCard, cardtime);
                    unit.GetComponent<ActivityComponent>().ActivityV1Info.GoldWeeklyCardRewards.Clear();
                }
                else if (rechargeNumber == 98)
                {
                    long serverTime = TimeHelper.ServerNow();
                    long cardtime = unit.GetComponent<NumericComponent>().GetAsLong(NumericType.DiamondWeeklyCard);

                    //如果是在第七天开启的， 当天不能领取奖励， 则把时间设置到零点
                    if (serverTime > cardtime && ComHelp.GetDaysDiffByDate(serverTime, cardtime) == 6)
                    {
                        cardtime = ComHelp.GetNextDayZeroOneTimestampMilliseconds(serverTime);
                    }
                    else
                    {
                        cardtime = serverTime;
                    }

                    unit.GetComponent<NumericComponent>().ApplyValue(NumericType.DiamondWeeklyCard, cardtime);
                    unit.GetComponent<ActivityComponent>().ActivityV1Info.DiamondWeeklyCardRewards.Clear();
                }
                else
                {
                    Console.WriteLine($"OnRechage.Error: {unit.Id}   {rechargetType}  {rechargeNumber}");
                }
            }

            numericComponent.ApplyChange(null, NumericType.RechargeNumber, rechargeNumber, 1, notice);    
            numericComponent.ApplyChange(null, NumericType.V1RechageNumber, rechargeNumber, 0, notice);    
            //充值签到标记，已经领取的不充值
            if (numericComponent.GetAsInt(NumericType.RechargeSign) != 2)
            {
                numericComponent.ApplyValue(NumericType.RechargeSign, 1, notice);
            }
            // 单笔充值奖励记录
            if (!unit.GetComponent<UserInfoComponent>().UserInfo.SingleRechargeIds.Contains(rechargeNumber))
            {
                unit.GetComponent<UserInfoComponent>().UserInfo.SingleRechargeIds.Add(rechargeNumber);
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="scene"></param>
        /// <param name="userId"></param>
        /// <param name="rechargeNumber"></param>
        /// <param name="orderInfo"></param>
        /// <param name="rechargeType">//0充值钻石   1购买周卡</param>
        /// <returns></returns>
        public static async ETTask OnPaySucessToUnit(Scene scene,  long userId, int rechargeNumber, string orderInfo, int rechargeType)
        {
            Player gateUnitInfo = scene.GetComponent<PlayerComponent>().GetByUserId(userId);
            //&& gateUnitInfo.ClientSession!=null
            if (gateUnitInfo != null  && gateUnitInfo.PlayerState == PlayerState.Game && gateUnitInfo.InstanceId > 0)
            {
                Log.Warning($"充值OnPaySucess PlayerState.Game: {scene.DomainZone()}   {userId}  rechargeNumber:{rechargeNumber}", true);
                G2M_RechargeResultRequest r2M_RechargeRequest = new G2M_RechargeResultRequest() { RechargeNumber = rechargeNumber , OrderInfo = orderInfo, RechargeType = rechargeType};
                M2G_RechargeResultResponse m2G_RechargeResponse = (M2G_RechargeResultResponse)await ActorLocationSenderComponent.Instance.Call(gateUnitInfo.UnitId, r2M_RechargeRequest);
            }
            else
            {
                Log.Warning($"充值OnPaySucess PlayerState.None: {scene.DomainZone()}   {userId}  rechargeNumber:{rechargeNumber}");
                //直接存数据库
                //int number = ComHelp.GetDiamondNumber(rechargeNumber);
                long dbCacheId = DBHelper.GetDbCacheId(scene.DomainZone());
                D2G_GetComponent d2GGetUnit = (D2G_GetComponent)await ActorMessageSenderComponent.Instance.Call(dbCacheId, new G2D_GetComponent() { UnitId = userId, Component = DBHelper.NumericComponent });
                NumericComponent numericComponent = (d2GGetUnit.Component as NumericComponent);
                numericComponent.ApplyChange(null, NumericType.RechargeBuChang, rechargeNumber, 1, false);
                numericComponent.ApplyValue(null, NumericType.RechargeType, rechargeType, 0, false);
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

        /// <summary>
        /// /
        /// </summary>
        /// <param name="zone"></param>
        /// <param name="userId"></param>
        /// <param name="rechargeNumber"></param>
        /// <param name="orderInfo"></param>
        /// <param name="paytype"></param>
        /// <param name="rechargeType">0充值钻石 1购买周卡</param>
        /// <returns></returns>
        public static async ETTask OnPaySucessToGate( int zone, long userId, int rechargeNumber, string orderInfo, int paytype,  int rechargeType)
        {
            long gateServerId = DBHelper.GetGateServerId(zone);
            R2G_RechargeResultRequest r2M_RechargeRequest = new R2G_RechargeResultRequest() {
                RechargeNumber = rechargeNumber,
                UserID = userId ,
                OrderInfo = orderInfo, 
                PayType = paytype,
                RechargeType = rechargeType};
            G2R_RechargeResultResponse m2G_RechargeResponse = (G2R_RechargeResultResponse)await ActorMessageSenderComponent.Instance.Call(gateServerId, r2M_RechargeRequest);
        }
    }
}
