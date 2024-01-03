using System;

namespace ET
{

    [ActorMessageHandler]
    public class C2M_PaiMaiStallHandler : AMActorLocationRpcHandler<Unit, C2M_StallOperationRequest, M2C_StallOperationResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_StallOperationRequest request, M2C_StallOperationResponse response, Action reply)
        {
            if (request.StallType == 0) //收摊
            {
                unit.GetComponent<NumericComponent>().ApplyValue(NumericType.Now_Stall, request.StallType);
            }
            if (request.StallType == 1) //摆摊
            {
                UserInfo userInfo = unit.GetComponent<UserInfoComponent>().UserInfo;
                if (string.IsNullOrEmpty(userInfo.StallName))
                {
                    unit.GetComponent<UserInfoComponent>().UpdateRoleData(UserDataType.StallName, "商品摊位");
                    unit.GetComponent<UserInfoComponent>().UpdateRoleDataBroadcast(UserDataType.StallName, "商品摊位");
                }
                unit.GetComponent<NumericComponent>().ApplyValue(NumericType.Now_Stall, request.StallType);
                M2C_RoleDataBroadcast m2C_BroadcastRoleData = new M2C_RoleDataBroadcast();
                m2C_BroadcastRoleData.UnitId = unit.Id;
                m2C_BroadcastRoleData.UpdateType = (int)UserDataType.StallName;
                m2C_BroadcastRoleData.UpdateTypeValue = userInfo.StallName;
                MessageHelper.Broadcast(unit, m2C_BroadcastRoleData);
                unit.GetComponent<UnitInfoComponent>().StallName = userInfo.StallName;

                TransferHelper.RemovePetAndJingLing(unit );
            }
            if (request.StallType == 2 && request.Value != "" && StringHelper.IsSafeSqlString(request.Value))
            {
                unit.GetComponent<UnitInfoComponent>().StallName = request.Value;
                unit.GetComponent<UserInfoComponent>().UpdateRoleData(UserDataType.StallName, request.Value);
                unit.GetComponent<UserInfoComponent>().UpdateRoleDataBroadcast(UserDataType.StallName, request.Value);
                M2C_RoleDataBroadcast m2C_BroadcastRoleData = new M2C_RoleDataBroadcast();
                m2C_BroadcastRoleData.UnitId = unit.Id;
                m2C_BroadcastRoleData.UpdateType = (int)UserDataType.StallName;
                m2C_BroadcastRoleData.UpdateTypeValue = request.Value;
                MessageHelper.Broadcast(unit, m2C_BroadcastRoleData);
            }

            reply();
            await ETTask.CompletedTask;
        }
    }
}
