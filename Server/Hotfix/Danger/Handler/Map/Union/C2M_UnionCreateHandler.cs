using System;

namespace ET
{

    [ActorMessageHandler]
    public class C2M_UnionCreateHandler : AMActorLocationRpcHandler<Unit, C2M_UnionCreateRequest, M2C_UnionCreateResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_UnionCreateRequest request, M2C_UnionCreateResponse response, Action reply)
        {
            //判断等级、钻石
            UserInfo userInfo = unit.GetComponent<UserInfoComponent>().UserInfo;
            if (userInfo.UnionId != 0)
            {
                response.Error = ErrorCore.ERR_Error;
                reply();
                return;
            }

            int needLevel = int.Parse(GlobalValueConfigCategory.Instance.Get(21).Value);
            int needDiamond = int.Parse(GlobalValueConfigCategory.Instance.Get(22).Value);
            if (userInfo.Lv < needLevel || userInfo.Diamond < needDiamond)
            {
                response.Error = ErrorCore.ERR_Error;
                reply();
                return;
            }

            long dbCacheId = DBHelper.GetUnionServerId(unit.DomainZone());
            U2M_UnionCreateResponse d2GGetUnit = (U2M_UnionCreateResponse)await ActorMessageSenderComponent.Instance.Call(dbCacheId, new M2U_UnionCreateRequest() 
            {
                UnionName =request.UnionName,
                UnionPurpose = request.UnionPurpose,
                UserID = userInfo.UserId
            });

            if (d2GGetUnit.Error == ErrorCore.ERR_Success)
            {
                unit.GetComponent<NumericComponent>().ApplyValue( NumericType.UnionLeader, 1, true);
                unit.GetComponent<UserInfoComponent>().UpdateRoleData(UserDataType.Union, d2GGetUnit.UnionId.ToString()).Coroutine();
                unit.GetComponent<UserInfoComponent>().UpdateRoleData(UserDataType.UnionName, request.UnionName).Coroutine();
                unit.GetComponent<UserInfoComponent>().UpdateRoleDataBroadcast(UserDataType.UnionName, request.UnionName);
            }
            response.Error = d2GGetUnit.Error;
            reply();
            await ETTask.CompletedTask;
        }

    }
}
