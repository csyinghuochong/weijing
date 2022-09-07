using System;

namespace ET
{

    [ActorMessageHandler]
    public class C2M_ZhanQuReceiveHandler : AMActorLocationRpcHandler<Unit, C2M_ZhanQuReceiveRequest, M2C_ZhanQuReceiveResponse>
    {

        protected override async ETTask Run(Unit unit, C2M_ZhanQuReceiveRequest request, M2C_ZhanQuReceiveResponse response, Action reply)
        {
            ActivityComponent activityComponent = unit.GetComponent<ActivityComponent>();
            if (activityComponent.ZhanQuReceiveIds.Contains(request.ActivityId))
            {
                response.Error = ErrorCore.ERR_AlreadyReceived;
                reply();
                return;
            }

            //判断领取条件
            /////////////
            switch (request.ActivityType)
            {
                case 21:    //战区等级
                case 22:    //战区战力
                    long paimaiServerId = StartSceneConfigCategory.Instance.GetBySceneName(unit.DomainZone(), Enum.GetName(SceneType.Activity)).InstanceId;
                    A2M_ZhanQuReceiveResponse r_GameStatusResponse = (A2M_ZhanQuReceiveResponse)await ActorMessageSenderComponent.Instance.Call
                        (paimaiServerId, new M2A_ZhanQuReceiveRequest()
                        {
                            ActivityId = request.ActivityId,
                            ActivityType = request.ActivityType
                        });
                    if (r_GameStatusResponse.Error != ErrorCore.ERR_Success)
                    {
                        response.Error = ErrorCore.ERR_AlreadyReceived;
                        reply();
                        return;
                    }
                    ActivityConfig activityConfig = ActivityConfigCategory.Instance.Get(request.ActivityId);
                    activityComponent.ZhanQuReceiveIds.Add(request.ActivityId);
                    unit.GetComponent<BagComponent>().OnAddItemData(activityConfig.Par_3, $"{ItemGetWay.Activity}_{TimeHelper.ServerNow()}");
                    break;
                default:
                    break;
            }
            reply();
        }
    }
}
