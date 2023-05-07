using System;
using System.Collections.Generic;
using System.Linq;


namespace ET
{

    [ActorMessageHandler]
    public class C2M_SoloMatchHandler : AMActorLocationRpcHandler<Unit, C2M_SoloMatchRequest, M2C_SoloMatchResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_SoloMatchRequest request, M2C_SoloMatchResponse response, Action reply)
        {
            MapComponent mapComponent = unit.DomainScene().GetComponent<MapComponent>();
            if (mapComponent.SceneTypeEnum != SceneTypeEnum.MainCityScene)
            {
                reply();
                return;
            }
            long soloServerId = DBHelper.GetSoloServerId(unit.DomainZone());
            SoloPlayerInfo soloPlayerInfo = new SoloPlayerInfo();
            soloPlayerInfo.UnitId = unit.Id;
            soloPlayerInfo.Combat = unit.GetComponent<UserInfoComponent>().UserInfo.Combat;
            soloPlayerInfo.MatchTime = TimeHelper.ServerNow();
            S2M_SoloMatchResponse d2GGetUnit = (S2M_SoloMatchResponse)await ActorMessageSenderComponent.Instance.Call(soloServerId, new M2S_SoloMatchRequest()
            {
                SoloPlayerInfo = soloPlayerInfo,    
            });

            reply();
            await ETTask.CompletedTask;
        }
    }
}
