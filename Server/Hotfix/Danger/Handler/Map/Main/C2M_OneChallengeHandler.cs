using System;


namespace ET
{

    [ActorMessageHandler]
    public class C2M_OneChallengeHandler : AMActorLocationRpcHandler<Unit, C2M_OneChallengeRequest, M2C_OneChallengeResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_OneChallengeRequest request, M2C_OneChallengeResponse response, Action reply)
        {
            if (request.Operatate == 1)  //发起挑战
            {
                Unit other = unit.GetParent<UnitComponent>().Get(request.OtherId);
                if (other == null)
                {
                    reply();
                    return;
                }
                if (unit.DomainScene().GetComponent<MapComponent>().SceneTypeEnum != SceneTypeEnum.MainCityScene)
                {
                    reply();
                    return;
                }

                M2C_OneChallenge m2CCreateUnits = new M2C_OneChallenge();
                m2CCreateUnits.OtherId = unit.Id;
                m2CCreateUnits.OtherName = unit.GetComponent<UserInfoComponent>().UserName;
                MessageHelper.SendToClient(other, m2CCreateUnits);
            }
            if (request.Operatate == 2) //迎接挑战
            {

            }

            reply();
            await ETTask.CompletedTask;
        }
    }
}
