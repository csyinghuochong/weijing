using System;

namespace ET
{
    [ActorMessageHandler]
    public class C2M_ShareSucessHandler : AMActorLocationRpcHandler<Unit, C2M_ShareSucessRequest, M2C_ShareSucessResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_ShareSucessRequest request, M2C_ShareSucessResponse response, Action reply)
        {
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
            
            if (request.ShareType != 1 && request.ShareType != 2)
            {
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
            DBCenterAccountInfo
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
