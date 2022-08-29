using System;

namespace ET
{

    [ActorMessageHandler]
    public class C2M_PaiMaiDuiHuanHandler : AMActorLocationRpcHandler<Unit, C2M_PaiMaiDuiHuanRequest, M2C_PaiMaiDuiHuanResponse>
    {

        protected override async ETTask Run(Unit unit, C2M_PaiMaiDuiHuanRequest request, M2C_PaiMaiDuiHuanResponse response, Action reply)
        {
            long dbCacheId = DBHelper.GetRankServerId(unit.DomainZone());
            R2M_DBServerInfoResponse d2GGetUnit = (R2M_DBServerInfoResponse)await ActorMessageSenderComponent.Instance.Call(dbCacheId, new M2R_DBServerInfoRequest() { });
            long diamond = request.DiamondsNumber;
       
            //判断钻石是否足够
            if (unit.GetComponent<UserInfoComponent>().UserInfo.Diamond >= diamond)
            {
                unit.GetComponent<UserInfoComponent>().UpdateRoleData(UserDataType.Diamond, (diamond * -1).ToString()).Coroutine();
                unit.GetComponent<UserInfoComponent>().UpdateRoleData(UserDataType.Gold, (diamond * d2GGetUnit.ServerInfo.ExChangeGold).ToString()).Coroutine();
            }
            else 
            {
                response.Error = ErrorCore.ERR_DiamondNotEnoughError;
            }

            reply();
            await ETTask.CompletedTask;
        }
    }
}
