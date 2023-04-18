using System;

namespace ET
{

    [ActorMessageHandler]
    public class C2A_MysteryListHandler : AMActorRpcHandler<Scene, C2A_MysteryListRequest, A2C_MysteryListResponse>
    {
        protected override async ETTask Run(Scene scene, C2A_MysteryListRequest request, A2C_MysteryListResponse response, Action reply)
        {
            ActivitySceneComponent activitySceneComponent = scene.GetComponent<ActivitySceneComponent>();
            if (activitySceneComponent.DBDayActivityInfo.MysteryItemInfos.Count == 0)
            {
                LogHelper.LogDebug($"神秘商店为空: {scene.DomainZone()}");
                int openServerDay = DBHelper.GetOpenServerDay(scene.DomainZone());
                activitySceneComponent.DBDayActivityInfo.MysteryItemInfos = MysteryShopHelper.InitMysteryItemInfos(openServerDay);
            }
            response.MysteryItemInfos = activitySceneComponent.DBDayActivityInfo.MysteryItemInfos;

            reply();
            await ETTask.CompletedTask;
        }
    }
}
