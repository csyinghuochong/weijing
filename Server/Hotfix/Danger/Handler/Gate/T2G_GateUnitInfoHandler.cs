using System;

namespace ET
{
    [ActorMessageHandler]
    public class T2G_GateUnitInfoHandler : AMActorRpcHandler<Scene, T2G_GateUnitInfoRequest, G2T_GateUnitInfoResponse>
    {
        protected override async ETTask Run(Scene scene, T2G_GateUnitInfoRequest request, G2T_GateUnitInfoResponse response, Action reply)
        {
            Player gateUnitInfo = scene.GetComponent<PlayerComponent>().GetByUserId(request.UserID);

            response.SessionInstanceId = gateUnitInfo!=null ? gateUnitInfo.InstanceId : 0;
            response.PlayerState = gateUnitInfo != null ? (int)gateUnitInfo.PlayerState : (int)PlayerState.None;
            response.UnitId = gateUnitInfo != null ? gateUnitInfo.UnitId : 0;
            reply();
            await ETTask.CompletedTask;
        }
    }
}
