using System;

namespace ET
{
    [ActorMessageHandler]
    public class C2M_ChengJiuListHandler : AMActorLocationRpcHandler<Unit, C2M_ChengJiuListRequest, M2C_ChengJiuListResponse>
    {

        protected override async ETTask Run(Unit unit, C2M_ChengJiuListRequest request, M2C_ChengJiuListResponse response, Action reply)
        {
            ChengJiuComponent chengJiuComponent = unit.GetComponent<ChengJiuComponent>();
            response.ChengJiuProgessList = chengJiuComponent.ChengJiuProgessList;
            response.ChengJiuCompleteList = chengJiuComponent.ChengJiuCompleteList;
            response.TotalChengJiuPoint = chengJiuComponent.TotalChengJiuPoint;
            response.AlreadReceivedId = chengJiuComponent.AlreadReceivedId;
            response.JingLingList = chengJiuComponent.JingLingList;
            
            reply();
            await ETTask.CompletedTask;
        }
    }
}
