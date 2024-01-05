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
            if (!ActivityConfigHelper.FeedItemReward.ContainsKey(costItemId))
            {
                response.Error = ErrorCode.ERR_ItemNotExist;
                reply();
                return;
            }
            BagComponent bagComponent = unit.GetComponent<BagComponent>();
            if (bagComponent.GetLeftSpace() < 1)
            {
                response.Error = ErrorCode.ERR_BagIsFull;
                reply();
                return;
            }
            if (bagComponent.GetItemNumber(costItemId) < 1)
            {
                response.Error = ErrorCode.ERR_ItemNotEnoughError;
                reply();
                return;
            }
            bagComponent.OnCostItemData($"{costItemId};1");
            bagComponent.OnAddItemData(ActivityConfigHelper.FeedItemReward[costItemId], $"{ItemGetWay.Activity}_{TimeHelper.ServerNow()}");
            long activitySceneid = DBHelper.GetActivityServerId(unit.DomainZone());
            A2M_ActivityFeedResponse r_GameStatusResponse = (A2M_ActivityFeedResponse)await ActorMessageSenderComponent.Instance.Call
                 (activitySceneid, new M2A_ActivityFeedRequest()
                 {
                     UnitID = unit.Id,
                 });

            response.ActivityV1Info = unit.GetComponent<ActivityComponent>().ActivityV1Info;
            response.ActivityV1Info.BaoShiDu = r_GameStatusResponse.BaoShiDu;
            reply();
            await ETTask.CompletedTask;
        }
    }
}
