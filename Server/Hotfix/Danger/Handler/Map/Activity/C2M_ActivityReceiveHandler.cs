using System;
using System.Collections.Generic;

namespace ET
{
    [ActorMessageHandler]
    public class C2M_ActivityReceiveHandler : AMActorLocationRpcHandler<Unit, C2M_ActivityReceiveRequest, M2C_ActivityReceiveResponse>
    {

        protected override async ETTask Run(Unit unit, C2M_ActivityReceiveRequest request, M2C_ActivityReceiveResponse response, Action reply)
        {
            using (await CoroutineLockComponent.Instance.Wait(CoroutineLockType.Received, unit.Id))
            {
                ActivityComponent activityComponent = unit.GetComponent<ActivityComponent>();
                if (!ActivityHelper.HaveReceiveTimes(activityComponent.ActivityReceiveIds, request.ActivityId))
                {
                    response.Error = ErrorCore.ERR_AlreadyReceived;
                    reply();
                    return;
                }
                Log.Debug($"C2M_ActivityReceive:  {unit.Id} {request.ActivityId} {request.ReceiveIndex} {TimeHelper.ServerNow().ToString()}");
                ActivityConfig activityConfig = ActivityConfigCategory.Instance.Get(request.ActivityId);
                switch (request.ActivityType)
                {
                    case 2: //每日特惠
                        if (!unit.GetComponent<BagComponent>().OnCostItemData(activityConfig.Par_2))
                        {
                            response.Error = ErrorCore.ERR_DiamondNotEnoughError;
                            reply();
                            return;
                        }

                        string[] needList = activityConfig.Par_3.Split('@');
                        if (unit.GetComponent<BagComponent>().GetLeftSpace() < needList.Length)
                        {
                            response.Error = ErrorCore.ERR_BagIsFull;
                            reply();
                            return;
                        }

                        activityComponent.ActivityReceiveIds.Add(request.ActivityId);
                        unit.GetComponent<BagComponent>().OnAddItemData(activityConfig.Par_3, $"{ItemGetWay.Activity}_{TimeHelper.ServerNow()}");
                        break;
                    case 23:    //签到
                        if (activityComponent.TotalSignNumber == 30)
                        {
                            response.Error = ErrorCore.ERR_AlreadyReceived;
                            reply();
                            return;
                        }
                        long serverNow = TimeHelper.ServerNow();
                        if (ComHelp.GetDayByTime(serverNow) == ComHelp.GetDayByTime(activityComponent.LastSignTime))
                        {
                            response.Error = ErrorCore.ERR_AlreadyReceived;
                            reply();
                            return;
                        }
                        string[] rewarditems = activityConfig.Par_3.Split('@');
                        if (rewarditems.Length > unit.GetComponent<BagComponent>().GetLeftSpace())
                        {
                            response.Error = ErrorCore.ERR_BagIsFull;
                            reply();
                            return;
                        }

                        activityComponent.TotalSignNumber++;
                        activityComponent.LastSignTime = TimeHelper.ServerNow();
                        activityComponent.ActivityReceiveIds.Add(request.ActivityId);
                        unit.GetComponent<BagComponent>().OnAddItemData(activityConfig.Par_3, $"{ItemGetWay.Activity}_{TimeHelper.ServerNow()}");
                        break;
                    case 24:    //令牌
                        List<TokenRecvive> zhanQuTokenRecvives = activityComponent.QuTokenRecvive;
                        for (int i = 0; i < zhanQuTokenRecvives.Count; i++)
                        {
                            if (zhanQuTokenRecvives[i].ActivityId == request.ActivityId
                                && zhanQuTokenRecvives[i].ReceiveIndex == (request.ReceiveIndex))
                            {
                                response.Error = ErrorCore.ERR_AlreadyReceived;
                                reply();
                                return;
                            }
                        }
                        UserInfoComponent userInfoComponent = unit.GetComponent<UserInfoComponent>();
                        if (userInfoComponent.UserInfo.Lv < int.Parse(activityConfig.Par_1))
                        {
                            reply();
                            return;
                        }
                        int selfRechage = unit.GetComponent<NumericComponent>().GetAsInt(NumericType.RechargeNumber);
                        if (request.ReceiveIndex == 3 && selfRechage < 298)
                        {
                            reply();
                            return;
                        }
                        if (request.ReceiveIndex == 2 && selfRechage < 98)
                        {
                            reply();
                            return;
                        }
                        zhanQuTokenRecvives.Add(new TokenRecvive() { ActivityId = request.ActivityId, ReceiveIndex = request.ReceiveIndex });
                        activityConfig = ActivityConfigCategory.Instance.Get(request.ActivityId);
                        string rewards = "";
                        if (request.ReceiveIndex == 1) rewards = activityConfig.Par_2;
                        if (request.ReceiveIndex == 2) rewards = activityConfig.Par_3;
                        if (request.ReceiveIndex == 3) rewards = activityConfig.Par_4;

                        rewarditems = rewards.Split('@');
                        if (rewarditems.Length > unit.GetComponent<BagComponent>().GetLeftSpace())
                        {
                            response.Error = ErrorCore.ERR_BagIsFull;
                            reply();
                            return;
                        }
                        unit.GetComponent<BagComponent>().OnAddItemData(rewards, $"{ItemGetWay.Activity}_{TimeHelper.ServerNow()}");
                        break;
                    case 31:    //登录奖励
                        userInfoComponent = unit.GetComponent<UserInfoComponent>();
                        if (userInfoComponent.UserInfo.Lv < 10)
                        {
                            reply();
                            return;
                        }
                        serverNow = TimeHelper.ServerNow();
                        if (ComHelp.GetDayByTime(serverNow) == ComHelp.GetDayByTime(activityComponent.LastLoginTime))
                        {
                            response.Error = ErrorCore.ERR_AlreadyReceived;
                            reply();
                            return;
                        }

                        rewarditems = activityConfig.Par_3.Split('@');
                        if (rewarditems.Length > unit.GetComponent<BagComponent>().GetLeftSpace())
                        {
                            response.Error = ErrorCore.ERR_BagIsFull;
                            reply();
                            return;
                        }

                        activityComponent.LastLoginTime = serverNow;
                        unit.GetComponent<ActivityComponent>().ActivityReceiveIds.Add(request.ActivityId);
                        unit.GetComponent<BagComponent>().OnAddItemData(activityConfig.Par_3, $"{ItemGetWay.Activity}_{TimeHelper.ServerNow()}");
                        break;
                    case 32:    //新年集字
                        rewarditems = activityConfig.Par_3.Split('@');
                        if (rewarditems.Length > unit.GetComponent<BagComponent>().GetLeftSpace())
                        {
                            response.Error = ErrorCore.ERR_BagIsFull;
                            reply();
                            return;
                        }
                        if (unit.GetComponent<BagComponent>().OnCostItemData(activityConfig.Par_2))
                        {
                            unit.GetComponent<ActivityComponent>().ActivityReceiveIds.Add(request.ActivityId);
                            unit.GetComponent<BagComponent>().OnAddItemData(activityConfig.Par_3, $"{ItemGetWay.Activity}_{TimeHelper.ServerNow()}");
                        }
                        else
                        {
                            response.Error = ErrorCore.ERR_ItemNotEnoughError;
                        }
                        break;
                    case 33://节日活动
                        if (unit.GetComponent<UserInfoComponent>().TodayOnLine < 30)
                        {
                            response.Error = ErrorCore.Err_OnLineTimeNot;
                            reply();
                            return;
                        }
                        string rewardItemlist = ActivityHelper.GetJieRiReward(unit.GetComponent<UserInfoComponent>());
                        if (unit.GetComponent<BagComponent>().GetLeftSpace() < rewardItemlist.Split('@').Length)
                        {
                            response.Error = ErrorCore.ERR_BagIsFull;
                            reply();
                            return;
                        }
                        if (!ActivityHelper.IsJieRiActivityId(request.ActivityId))
                        {
                            response.Error = ErrorCore.ERR_AlreadyFinish;
                            reply();
                            return;
                        }

                        if (unit.GetComponent<UserInfoComponent>().UserInfo.Lv < 20)
                        {
                            response.Error = ErrorCore.ERR_EquipLvLimit;
                            reply();
                            return;
                        }

                        unit.GetComponent<ActivityComponent>().ActivityReceiveIds.Add(request.ActivityId);
                        unit.GetComponent<BagComponent>().OnAddItemData(rewardItemlist, $"{ItemGetWay.Activity}_{TimeHelper.ServerNow()}");
                        break;
                    case 34:
                        userInfoComponent = unit.GetComponent<UserInfoComponent>();
                        if (userInfoComponent.UserInfo.Lv < int.Parse(activityConfig.Par_1))
                        {
                            response.Error = ErrorCore.ERR_EquipLvLimit;
                            reply();
                            return;
                        }

                        rewarditems = activityConfig.Par_3.Split('@');
                        if (rewarditems.Length > unit.GetComponent<BagComponent>().GetLeftSpace())
                        {
                            response.Error = ErrorCore.ERR_BagIsFull;
                            reply();
                            return;
                        }

                        unit.GetComponent<ActivityComponent>().ActivityReceiveIds.Add(request.ActivityId);
                        unit.GetComponent<BagComponent>().OnAddItemData(activityConfig.Par_3, $"{ItemGetWay.Activity}_{TimeHelper.ServerNow()}");
                        break;
                    case 101:   //冒险家
                                //需要从dbaccountinfo中获取当前角色重置额度

                        rewarditems = activityConfig.Par_3.Split('@');
                        if (rewarditems.Length > unit.GetComponent<BagComponent>().GetLeftSpace())
                        {
                            response.Error = ErrorCore.ERR_BagIsFull;
                            reply();
                            return;
                        }

                        unit.GetComponent<ActivityComponent>().ActivityReceiveIds.Add(request.ActivityId);
                        unit.GetComponent<BagComponent>().OnAddItemData(activityConfig.Par_3, $"{ItemGetWay.Activity}_{TimeHelper.ServerNow()}");
                        break;
                    default:
                        bool success = unit.GetComponent<BagComponent>().OnCostItemData(activityConfig.Par_2);
                        if (success)
                        {
                            unit.GetComponent<ActivityComponent>().ActivityReceiveIds.Add(request.ActivityId);
                            unit.GetComponent<BagComponent>().OnAddItemData(activityConfig.Par_3, $"{ItemGetWay.Activity}_{TimeHelper.ServerNow()}");
                        }
                        else
                        {
                            response.Error = ErrorCore.ERR_GoldNotEnoughError;
                        }
                        break;
                }
            }
            Log.Debug($"C2M_ActivityReceive[成功]:  {unit.Id} {request.ActivityId} {request.ReceiveIndex} {TimeHelper.ServerNow().ToString()}");
            reply();
            await ETTask.CompletedTask;
        }
    }
}
