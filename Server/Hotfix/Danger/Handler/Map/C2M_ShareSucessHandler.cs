using System;
using System.Collections.Generic;

namespace ET
{
    [ActorMessageHandler]
    public class C2M_ShareSucessHandler : AMActorLocationRpcHandler<Unit, C2M_ShareSucessRequest, M2C_ShareSucessResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_ShareSucessRequest request, M2C_ShareSucessResponse response, Action reply)
        {
            if (request.ShareType != 1 && request.ShareType != 2)
            {
                reply();
                return;
            }

            UserInfo userInfo = unit.GetComponent<UserInfoComponent>().UserInfo;
            if (userInfo.Lv < 10)
            {
                response.Error = ErrorCore.ERR_LevelIsNot;
                reply();
                return;
            }
            TaskComponent taskComponent = unit.GetComponent<TaskComponent>();
            if (taskComponent.OnLineTime < 30)
            {
                response.Error = ErrorCore.Err_OnLineTimeNot;
                reply();
                return;
            }
            NumericComponent numericComponent = unit.GetComponent<NumericComponent>();
            long shareSet = numericComponent.GetAsLong(NumericType.FenShangSet);
            if ((shareSet & request.ShareType) > 0)
            {
                reply();
                return;
            }

            DBCenterAccountInfo dBAccountInfos =await DBHelper.GetComponentCache<DBCenterAccountInfo>(unit.DomainZone(), userInfo.AccInfoID);
            //await Game.Scene.GetComponent<DBComponent>().Query<DBCenterAccountInfo>(202, d => d.Id == userInfo.AccInfoID);
            if (dBAccountInfos == null)
            {
                reply();
                return;
            }
            int totalTimes = 0;
            long serverNow = TimeHelper.ServerNow();
            List<long> ShareTimes = dBAccountInfos.PlayerInfo.ShareTimes;
            for (int i = 0; i < ShareTimes.Count; i++)
            {
                if (ComHelp.GetDayByTime(serverNow) == ComHelp.GetDayByTime(ShareTimes[i]))
                {
                    totalTimes++;
                }
            }
            if (totalTimes >= 4)
            {
                response.Error = ErrorCore.ERR_TimesIsNot;
                reply();
                return;
            }

            dBAccountInfos.PlayerInfo.ShareTimes.Add(serverNow);
            long dbCacheId = DBHelper.GetDbCacheId(unit.DomainZone());
            D2M_SaveComponent d2GSave = (D2M_SaveComponent)await ActorMessageSenderComponent.Instance.Call(dbCacheId, new M2D_SaveComponent() { UnitId = dBAccountInfos.Id, EntityByte = MongoHelper.ToBson(dBAccountInfos), ComponentType = DBHelper.DBAccountInfo });
            long accountZone = DBHelper.GetAccountCenter();
            Center2A_SaveAccount saveAccount = (Center2A_SaveAccount)await ActorMessageSenderComponent.Instance.Call(accountZone, new A2Center_SaveAccount()
            {
                AccountId = dBAccountInfos.Id,
                AccountName = dBAccountInfos.Account,
                Password = dBAccountInfos.Password,
                PlayerInfo = dBAccountInfos.PlayerInfo,
            });

            shareSet = shareSet | (long)request.ShareType;
            numericComponent.ApplyValue(NumericType.FenShangSet, shareSet);

            //给钻石
            unit.GetComponent<UserInfoComponent>().UpdateRoleMoneyAdd( UserDataType.Diamond, "120", true, ItemGetWay.Share);

            unit.GetComponent<ChengJiuComponent>().TriggerEvent(ChengJiuTargetEnum.ShareTotalNumber_220, 0, 1);
            reply();
            await ETTask.CompletedTask;
        }
    }
}
