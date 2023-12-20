using System;

namespace ET
{
    [ActorMessageHandler]
    public class C2M_ActivityGuessHandler : AMActorLocationRpcHandler<Unit, C2M_ActivityGuessRequest, M2C_ActivityGuessResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_ActivityGuessRequest request, M2C_ActivityGuessResponse response, Action reply)
        {
            long activitySceneid = DBHelper.GetActivityServerId(unit.DomainZone());
            ActivityV1Info activityV1Info = unit.GetComponent<ActivityComponent>().ActivityV1Info;
            if (activityV1Info.GuessIds.Contains(request.GuessId))
            {
                response.Error = ErrorCode.ERR_Already_Guess;
                reply();
                return;
            }
            string costItem = ActivityConfigHelper.GetGuessCostItem(activityV1Info.GuessIds.Count);
            if (!unit.GetComponent<BagComponent>().CheckCostItem(costItem))
            {
                response.Error = ErrorCode.ERR_ItemNotEnoughError;
                reply();
                return;
            }

            A2M_ActivityGuessResponse r_GameStatusResponse = (A2M_ActivityGuessResponse)await ActorMessageSenderComponent.Instance.Call
                   (activitySceneid, new M2A_ActivityGuessRequest()
                   {
                       UnitId = unit.Id,
                       GuessId = request.GuessId,   
                   });
            if (activityV1Info.GuessIds.Contains(request.GuessId))
            {
                response.Error = ErrorCode.ERR_Already_Guess;
                reply();
                return;
            }
            activityV1Info.GuessIds.Add(request.GuessId);
            unit.GetComponent<BagComponent>().OnCostItemData(costItem);
            reply();
            await ETTask.CompletedTask;
        }
    }
}
