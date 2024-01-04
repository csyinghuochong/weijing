using System;

namespace ET
{

    [ActorMessageHandler]
    public class C2M_StallOperationHandler : AMActorLocationRpcHandler<Unit, C2M_StallOperationRequest, M2C_StallOperationResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_StallOperationRequest request, M2C_StallOperationResponse response, Action reply)
        {
            if (request.StallType == 0) //收摊
            {
                unit.GetComponent<NumericComponent>().ApplyValue(NumericType.Now_Stall, 0);

                TransferHelper.RemoveStall(unit );
            }
            if (request.StallType == 1) //摆摊
            {
                UserInfo userInfo = unit.GetComponent<UserInfoComponent>().UserInfo;
                if (string.IsNullOrEmpty(userInfo.StallName))
                {
                    unit.GetComponent<UserInfoComponent>().UpdateRoleData(UserDataType.StallName, $"{userInfo.Name}的摊位");
                }
       
                TransferHelper.RemovePetAndJingLing(unit );
                long stallId = UnitFactory.CreateStall( unit.DomainScene(), unit ).Id;

                unit.GetComponent<NumericComponent>().ApplyValue(NumericType.Now_Stall, stallId);
            }
            if (request.StallType == 2 && request.Value != "" && StringHelper.IsSafeSqlString(request.Value)) //修改名字
            {
                unit.GetComponent<UserInfoComponent>().UpdateRoleData(UserDataType.StallName, request.Value);

                long stallId = unit.GetComponent<NumericComponent>().GetAsLong(NumericType.Now_Stall);
                Unit unitstall = unit.GetParent<UnitComponent>().Get(stallId);
                unitstall.GetComponent<UnitInfoComponent>().UnitName = request.Value;   
                M2C_RoleDataBroadcast m2C_BroadcastRoleData = new M2C_RoleDataBroadcast();
                m2C_BroadcastRoleData.UnitId = stallId;
                m2C_BroadcastRoleData.UpdateType = UserDataType.Name;
                m2C_BroadcastRoleData.UpdateTypeValue = request.Value;
                MessageHelper.Broadcast(unit, m2C_BroadcastRoleData);
            }

            reply();
            await ETTask.CompletedTask;
        }
    }
}
