using System;
using System.Collections.Generic;

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
                response.Error = ErrorCode.ERR_OtherNotExist;
                reply();
                return;
            }
            if (unit.DomainScene().GetComponent<MapComponent>().SceneTypeEnum != SceneTypeEnum.MainCityScene)
            {
                response.Error = ErrorCode.ERR_OtherNotExist;
                reply();
                return;
            }

            if (request.Operatate == 1)  //发起挑战
            {
                M2C_OneChallenge m2CCreateUnits = new M2C_OneChallenge();
                m2CCreateUnits.Operatate = 1;
                m2CCreateUnits.OtherId = unit.Id;
                m2CCreateUnits.OtherName = unit.GetComponent<UserInfoComponent>().UserName;
                MessageHelper.SendToClient(other, m2CCreateUnits);
            }
            if (request.Operatate == 2) //迎接挑战
            {
                List<Unit> allUnits = new List<Unit> { unit, other };  
                M2C_OneChallenge m2CCreateUnits = new M2C_OneChallenge();
                m2CCreateUnits.Operatate = 2;
                m2CCreateUnits.OtherId =  0;
                MessageHelper.SendToClient(allUnits, m2CCreateUnits);
            }

            reply();
            await ETTask.CompletedTask;
        }
    }
}
