using System;

namespace ET
{
    [ActorMessageHandler]
    public class C2M_UserInfoRequestHandler : AMActorLocationRpcHandler<Unit, C2M_UserInfoRequest, M2C_UserInfoInitResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_UserInfoRequest request, M2C_UserInfoInitResponse response, Action reply)
        {
            unit.GetComponent<ShoujiComponent>().UpdateShouJIStar();

            response.UserInfo = unit.GetComponent<UserInfoComponent>().UserInfo;
            response.ReddontList =  unit.GetComponent<ReddotComponent>().ReddontList;
            response.TreasureInfo = unit.GetComponent<ShoujiComponent>().TreasureInfo;
            response.ShouJiChapterInfos = unit.GetComponent<ShoujiComponent>().ShouJiChapterInfos;
            reply();
            await ETTask.CompletedTask;
        }
    }
}
