using System;


namespace ET
{
    [ActorMessageHandler]
    public class C2U_UnionMysteryListHandler : AMActorRpcHandler<Scene, C2U_UnionMysteryListRequest, U2C_UnionMysteryListResponse>
    {
        protected override async ETTask Run(Scene scene, C2U_UnionMysteryListRequest request, U2C_UnionMysteryListResponse response, Action reply)
        {
            DBUnionInfo dBUnionInfo = await scene.GetComponent<UnionSceneComponent>().GetDBUnionInfo(request.UnionId);
            if (dBUnionInfo == null)
            {
                response.Error = ErrorCode.ERR_Union_Not_Exist;
                reply();
                return;
            }

            if (ComHelp.GetDayByTime(dBUnionInfo.MysteryFreshTime) != ComHelp.GetDayByTime(TimeHelper.ServerNow()))
            {
                int openDay = ServerHelper.GetOpenServerDay(false, scene.DomainZone());
                dBUnionInfo.MysteryItemInfos = UnionHelper.InitMysteryItemInfos(openDay);
                dBUnionInfo.MysteryFreshTime = TimeHelper.ServerNow();
                DBHelper.SaveComponent(scene.DomainZone(), request.UnionId, dBUnionInfo).Coroutine();
            }

            response.MysteryItemInfos = dBUnionInfo.MysteryItemInfos;
            reply();
        }
    }
}
