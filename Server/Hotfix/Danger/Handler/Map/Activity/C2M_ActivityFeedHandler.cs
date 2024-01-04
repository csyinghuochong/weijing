using System;
using System.Collections.Generic;

namespace ET
{

    [ActorMessageHandler]
    public class C2M_ActivityFeedHandler : AMActorLocationRpcHandler<Unit, C2M_ActivityFeedRequest, M2C_ActivityFeedResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_ActivityFeedRequest request, M2C_ActivityFeedResponse response, Action reply)
        {
            int costItemId = request.ItemID;
            BagComponent bagComponent = unit.GetComponent<BagComponent>();  
            if (!ActivityConfigHelper.FeedItemReward.ContainsKey(costItemId))
            {
                response.Error = ErrorCode.ERR_ItemNotExist;
                reply();
                return;
            }
            if(bagComponent.GetItemNumber(costItemId) < 1)
            {
                response.Error = ErrorCode.ERR_ItemNotEnoughError;
                reply();
                return;
            }

            long activitySceneid = DBHelper.GetActivityServerId(unit.DomainZone());
            A2M_ActivityFeedResponse r_GameStatusResponse = (A2M_ActivityFeedResponse)await ActorMessageSenderComponent.Instance.Call
                 (activitySceneid, new M2A_ActivityFeedRequest()
                 {
                     UnitID = unit.Id,
                 });


            reply();
            await ETTask.CompletedTask;
        }
    }
}
