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
            Log.Warning($"C2M_ModifyNameRequest:  {unit.DomainZone()} {unit.Id}");
            if (!StringHelper.IsSafeSqlString(request.NewName))
            {
                response.Error = ErrorCode.ERR_UnSafeSqlString;
                reply();
                return;
            }
            
            if (string.IsNullOrEmpty(request.NewName))
            {
                response.Error = ErrorCode.ERR_CreateRoleName;
                response.Message = "角色名字过短!";
                reply();
                return;
            }

            if (request.NewName.Contains(" "))
            {
                Log.Error($"C2M_ModifyNameRequest 1");
                response.Error = ErrorCode.ERR_ModifyData;
                reply();
                return;
            }
            request.NewName = request.NewName.Trim();   

            if (request.NewName.Length >= 8)
            {
                response.Error = ErrorCode.ERR_CreateRoleName;
                response.Message = "角色名字过长!";
                reply();
                return;
            }

            List<UserInfoComponent> result = await Game.Scene.GetComponent<DBComponent>().Query<UserInfoComponent>(unit.DomainZone(), _account => _account.UserName == request.NewName);
            if (result.Count > 0)
            {
                response.Error = ErrorCode.ERR_RoleNameRepeat;
                reply();
                return;
            }

            GlobalValueConfig globalValueConfig = GlobalValueConfigCategory.Instance.Get(70);
            if (unit.GetComponent<BagComponent>().OnCostItemData(globalValueConfig.Value, ItemLocType.ItemLocBag, ItemGetWay.CostItem))
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
                response.Error = ErrorCode.ERR_ItemNotEnoughError;
            }

            reply();
            await ETTask.CompletedTask;
        }
    }
}
