using System;
using System.Collections.Generic;


namespace ET
{

    [ActorMessageHandler]
    public class C2A_PetMingChanChuHandler : AMActorRpcHandler<Scene, C2A_PetMingChanChuRequest, A2C_PetMingChanChuResponse>
    {
        protected override async ETTask Run(Scene scene, C2A_PetMingChanChuRequest request, A2C_PetMingChanChuResponse response, Action reply)
        {
            ActivitySceneComponent activitySceneComponent = scene.GetComponent<ActivitySceneComponent>();

            long chanchu = 0;
            if (activitySceneComponent.DBDayActivityInfo.PetMingChanChu.ContainsKey(request.ActorId))
            {
                chanchu = activitySceneComponent.DBDayActivityInfo.PetMingChanChu[request.ActorId];
                activitySceneComponent.DBDayActivityInfo.PetMingChanChu[request.ActorId] = 0;
            }

            A2M_PetMingChanChuRequest a2M_PetMing  = new A2M_PetMingChanChuRequest()
            {
               UnitID = request.ActorId,
               ChanChu = chanchu,   
            };

            M2A_PetMingChanChuResponse m2G_RechargeResponse = (M2A_PetMingChanChuResponse)await ActorLocationSenderComponent.Instance.Call(request.ActorId, a2M_PetMing);
            if (m2G_RechargeResponse.Error == ErrorCode.ERR_Success)
            {
            }

            reply();
            await ETTask.CompletedTask;
        }
    }
}
