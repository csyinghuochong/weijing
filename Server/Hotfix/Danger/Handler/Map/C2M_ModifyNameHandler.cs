using System;
using System.Collections.Generic;

namespace ET
{
    //修改名字
    [ActorMessageHandler]
    public class C2M_ModifyNameHandler : AMActorLocationRpcHandler<Unit, C2M_ModifyNameRequest, M2C_ModifyNameResponse>
    {

        protected override async ETTask Run(Unit unit, C2M_ModifyNameRequest request, M2C_ModifyNameResponse response, Action reply)
        {
            if (StringHelper.IsSafeSqlString(request.NewName))
            {
                unit.GetComponent<UserInfoComponent>().UpdateRoleData(UserDataType.Name, request.NewName);

                M2C_RoleDataBroadcast m2C_BroadcastRoleData = new M2C_RoleDataBroadcast();
                m2C_BroadcastRoleData.UnitId = unit.Id;
                m2C_BroadcastRoleData.UpdateType = (int)UserDataType.Name;
                m2C_BroadcastRoleData.UpdateTypeValue = request.NewName;
                MessageHelper.Broadcast(unit, m2C_BroadcastRoleData);
            }
            else
            {
                response.Error = ErrorCore.ERR_UnSafeSqlString;
            }

            reply();
            await ETTask.CompletedTask;
        }
    }
}
