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
                string name = unit.GetComponent<UserInfoComponent>().UserInfo.Name;
                unit.GetComponent<NumericComponent>().ApplyValue(NumericType.Now_Stall, request.StallType);
                M2C_RoleDataBroadcast m2C_BroadcastRoleData = new M2C_RoleDataBroadcast();
                m2C_BroadcastRoleData.UnitId = unit.Id;
                m2C_BroadcastRoleData.UpdateType = (int)UserDataType.StallName;
                m2C_BroadcastRoleData.UpdateTypeValue = $"{name}的摊位";
                MessageHelper.Broadcast(unit, m2C_BroadcastRoleData);
                unit.GetComponent<UnitInfoComponent>().StallName = $"{name}的摊位";
            }
            if (request.StallType == 2 && request.Value != "" && StringHelper.IsSafeSqlString(request.Value))
            {
                unit.GetComponent<UnitInfoComponent>().StallName = request.Value;

                M2C_RoleDataBroadcast m2C_BroadcastRoleData = new M2C_RoleDataBroadcast();
                m2C_BroadcastRoleData.UnitId = unit.Id;
                m2C_BroadcastRoleData.UpdateType = (int)UserDataType.StallName;
                m2C_BroadcastRoleData.UpdateTypeValue = request.Value;
                MessageHelper.Broadcast(unit, m2C_BroadcastRoleData);
                unit.GetComponent<UnitInfoComponent>().StallName = request.Value;
            }

            reply();
            await ETTask.CompletedTask;
        }
    }
}
