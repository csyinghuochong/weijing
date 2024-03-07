using System;

namespace ET
{

    [ActorMessageHandler]
    public class M2A_ZhanQuInfoHandler : AMActorRpcHandler<Scene, M2A_ZhanQuInfoRequest, A2M_ZhanQuInfoResponse>
    {
        protected override async ETTask Run(Scene scene, M2A_ZhanQuInfoRequest request, A2M_ZhanQuInfoResponse response, Action reply)
        {
            DBDayActivityInfo dBDayActivityInfo = scene.GetComponent<ActivitySceneComponent>().DBDayActivityInfo;

            if(scene.DomainZone() == 76)
            {
                for (int i = 0; i < dBDayActivityInfo.ZhanQuReveives.Count; i++ )
                {
                    dBDayActivityInfo.ZhanQuReveives[i].ReceiveUnitIds.Clear();
                }
            }

            response.ReceiveNum= dBDayActivityInfo.ZhanQuReveives;

            reply();
            await ETTask.CompletedTask;
        }

    }
}
