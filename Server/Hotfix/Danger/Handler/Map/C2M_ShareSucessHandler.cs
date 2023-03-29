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

            List<DBCenterAccountInfo> dBAccountInfos = await Game.Scene.GetComponent<DBComponent>().Query<DBCenterAccountInfo>(202, d => d.Id == userInfo.AccInfoID);
            if (dBAccountInfos.Count == 0)
            {
                reply();
                return;
            }
            int totalTimes = 0;
            long serverNow = TimeHelper.ServerNow();
            List<long> ShareTimes = dBAccountInfos[0].PlayerInfo.ShareTimes;
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

            dBAccountInfos[0].PlayerInfo.ShareTimes.Add(serverNow);
            long dbCacheId = DBHelper.GetDbCacheId(unit.DomainZone());
            D2M_SaveComponent d2GSave = (D2M_SaveComponent)await ActorMessageSenderComponent.Instance.Call(dbCacheId, new M2D_SaveComponent() { UnitId = dBAccountInfos[0].Id, EntityByte = MongoHelper.ToBson(dBAccountInfos[0]), ComponentType = DBHelper.DBAccountInfo });
            long accountZone = DBHelper.GetAccountCenter();
            Center2A_SaveAccount saveAccount = (Center2A_SaveAccount)await ActorMessageSenderComponent.Instance.Call(accountZone, new A2Center_SaveAccount()
            {
                AccountId = dBAccountInfos[0].Id,
                AccountName = dBAccountInfos[0].Account,
                Password = dBAccountInfos[0].Password,
                PlayerInfo = dBAccountInfos[0].PlayerInfo,
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
