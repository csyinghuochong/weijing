using System;


namespace ET
{

    [ActorMessageHandler]
    public class C2M_OneChallengeHandler : AMActorLocationRpcHandler<Unit, C2M_OneChallengeRequest, M2C_OneChallengeResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_OneChallengeRequest request, M2C_OneChallengeResponse response, Action reply)
        {
            Unit other = unit.GetParent<UnitComponent>().Get(request.OtherId);
            if (other == null)
            {
                reply();
                return;
            }
            if (unit.DomainScene().GetComponent<MapComponent>().SceneTypeEnum!= SceneTypeEnum.MainCityScene)
            {
                reply();
                return;
            }



            reply();
            await ETTask.CompletedTask;
        }
    }
}
