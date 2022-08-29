using System.Collections.Generic;

namespace ET
{
    public static class RechargeHelp
    {

        public static async ETTask SendDiamondToUnit(Unit unit, int rechargeNumber)
        {
            int number = ComHelp.GetDiamondNumber(rechargeNumber);
            long accountId = unit.GetComponent<UserInfoComponent>().UserInfo.AccInfoID;

            long dbCacheId = DBHelper.GetDbCacheId(unit.DomainZone());
            D2G_GetComponent d2GGetUnit = (D2G_GetComponent)await ActorMessageSenderComponent.Instance.Call(dbCacheId, new G2D_GetComponent() { CharacterId = accountId, Component = DBHelper.DBAccountInfo });
            DBAccountInfo accountInfo = d2GGetUnit.Component as DBAccountInfo;
            accountInfo.PlayerInfo.RechargeInfos.Add(new RechargeInfo()
            {
                Amount = rechargeNumber,
                Time = TimeHelper.ServerNow(),
                UserId = unit.GetComponent<UserInfoComponent>().UserInfo.UserId,
            });

            D2M_SaveComponent d2GSave = (D2M_SaveComponent)await ActorMessageSenderComponent.Instance.Call(dbCacheId, new M2D_SaveComponent() { CharacterId = accountInfo.Id, Component = accountInfo, ComponentType = DBHelper.DBAccountInfo });
            await unit.GetComponent<UserInfoComponent>().UpdateRoleData(UserDataType.Diamond, number.ToString());
        }

        public static async ETTask OnPaySucessToUnit(Scene scene,  long userId, int rechargeNumber)
        {
            Player gateUnitInfo = scene.GetComponent<PlayerComponent>().GetByUserId(userId);

            if (gateUnitInfo.PlayerState == PlayerState.Game && gateUnitInfo.InstanceId > 0)
            {
                G2M_RechargeResultRequest r2M_RechargeRequest = new G2M_RechargeResultRequest() { RechargeNumber = rechargeNumber };
                M2G_RechargeResultResponse m2G_RechargeResponse = (M2G_RechargeResultResponse)await ActorLocationSenderComponent.Instance.Call(gateUnitInfo.UnitId, r2M_RechargeRequest);
            }
            else
            {
                //直接存数据库

            }
        }

        public static async ETTask OnPaySucessToScene(Scene scene, int zone, long userId, int rechargeNumber)
        {
            long gateServerId = DBHelper.GetGateServerId(zone);

            R2G_RechargeResultRequest r2M_RechargeRequest = new R2G_RechargeResultRequest() { RechargeNumber = rechargeNumber, UserID = userId };
            G2R_RechargeResultResponse m2G_RechargeResponse = (G2R_RechargeResultResponse)await ActorMessageSenderComponent.Instance.Call(gateServerId, r2M_RechargeRequest);
        }
    }
}
