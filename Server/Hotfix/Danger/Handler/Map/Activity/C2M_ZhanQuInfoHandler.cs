using System;

namespace ET
{

    [ActorMessageHandler]
    public class C2M_ZhanQuInfoHandler : AMActorLocationRpcHandler<Unit, C2M_ZhanQuInfoRequest, M2C_ZhanQuInfoResponse>
    {

        protected override async ETTask Run(Unit unit, C2M_ZhanQuInfoRequest request, M2C_ZhanQuInfoResponse response, Action reply)
        {

            long paimaiServerId = StartSceneConfigCategory.Instance.GetBySceneName(unit.DomainZone(), Enum.GetName(SceneType.Activity)).InstanceId;
            A2M_ZhanQuInfoResponse r_GameStatusResponse = (A2M_ZhanQuInfoResponse)await ActorMessageSenderComponent.Instance.Call
                (paimaiServerId, new M2A_ZhanQuInfoRequest()
                {
                    UserId = unit.GetComponent<UserInfoComponent>().UserInfo.UserId
                });

            ActivityComponent activityComponent = unit.GetComponent<ActivityComponent>();
            response.ReceiveNum = r_GameStatusResponse.ReceiveNum;
            response.ReceiveIds = activityComponent.ZhanQuReceiveIds;
           
            reply();
            await ETTask.CompletedTask;
        }
    }
}
