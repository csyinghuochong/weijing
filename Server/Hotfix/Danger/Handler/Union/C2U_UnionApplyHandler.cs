using System;

namespace ET
{
    [ActorMessageHandler]
    public class C2U_UnionApplyHandler : AMActorRpcHandler<Scene, C2U_UnionApplyRequest, U2C_UnionApplyResponse>
    {
        protected override async ETTask Run(Scene scene, C2U_UnionApplyRequest request, U2C_UnionApplyResponse response, Action reply)
        {
            DBUnionInfo dBUnionInfo =await scene.GetComponent<UnionSceneComponent>().GetDBUnionInfo(request.UnionId);
            if (!dBUnionInfo.UnionInfo.ApplyList.Contains(request.UserId))
            {
                dBUnionInfo.UnionInfo.ApplyList.Add(request.UserId);
            }

            long gateServerId = DBHelper.GetGateServerId(scene.DomainZone());
            G2T_GateUnitInfoResponse g2M_UpdateUnitResponse = (G2T_GateUnitInfoResponse)await ActorMessageSenderComponent.Instance.Call
                  (gateServerId, new T2G_GateUnitInfoRequest()
                  {
                      UserID = dBUnionInfo.UnionInfo.LeaderId
                  });
            if (g2M_UpdateUnitResponse.PlayerState == (int)PlayerState.Game && g2M_UpdateUnitResponse.SessionInstanceId > 0)
            {
                M2C_UnionApplyResult m2C_HorseNoticeInfo = new M2C_UnionApplyResult();
                MessageHelper.SendActor(g2M_UpdateUnitResponse.SessionInstanceId, m2C_HorseNoticeInfo);
            }
            //暂时离线需要通知到map?
            if (g2M_UpdateUnitResponse.PlayerState == (int)PlayerState.None)
            {
                long dbCacheId = DBHelper.GetDbCacheId(scene.DomainZone());
                D2G_GetComponent d2GGetUnit = (D2G_GetComponent)await ActorMessageSenderComponent.Instance.Call(dbCacheId, new G2D_GetComponent() { CharacterId = dBUnionInfo.UnionInfo.LeaderId, Component = DBHelper.ReddotComponent });
                if (d2GGetUnit.Component != null)
                {
                    ReddotComponent reddotComponent = d2GGetUnit.Component as ReddotComponent;
                    if (reddotComponent != null)
                    {
                        reddotComponent.AddReddont((int)ReddotType.UnionApply);
                        D2M_SaveComponent d2M_SaveComponent = (D2M_SaveComponent)await ActorMessageSenderComponent.Instance.Call(dbCacheId, new M2D_SaveComponent() { CharacterId = dBUnionInfo.UnionInfo.LeaderId, Component = reddotComponent, ComponentType = DBHelper.ReddotComponent });
                    }
                }
            }

            reply();
        }
    }
}
