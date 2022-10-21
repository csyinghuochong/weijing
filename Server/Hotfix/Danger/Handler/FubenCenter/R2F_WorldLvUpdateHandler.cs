using System;
using System.Collections.Generic;

namespace ET
{

    [ActorMessageHandler]
    public class R2F_WorldLvUpdateHandler : AMActorRpcHandler<Scene, R2F_WorldLvUpdateRequest, F2R_WorldLvUpdateResponse>
    {
        protected override async ETTask Run(Scene scene, R2F_WorldLvUpdateRequest request, F2R_WorldLvUpdateResponse response, Action reply)
        {
            List<long> mapIdList = new List<long>();
            FubenCenterComponent fubenCenterComponent = scene.GetComponent<FubenCenterComponent>();
            mapIdList.Add(StartSceneConfigCategory.Instance.GetBySceneName(scene.DomainZone(), $"Map{ComHelp.MainCityID()}").InstanceId);
            mapIdList.AddRange(fubenCenterComponent.FubenInstanceList );
            for (int i = mapIdList.Count - 1; i >= 0; i--)
            {
                M2F_ServerInfoUpdateResponse m2m_TrasferUnitResponse = (M2F_ServerInfoUpdateResponse)await ActorMessageSenderComponent.Instance.Call
                        (mapIdList[i], new F2M_ServerInfoUpdateRequest() { ServerInfo = request.ServerInfo  });

                if (i!= 0 && m2m_TrasferUnitResponse.Error != ErrorCore.ERR_Success)
                {
                    mapIdList.Remove(i);
                }
            }
            fubenCenterComponent.ServerInfo = request.ServerInfo;
            reply();
            await ETTask.CompletedTask;
        }
    }
}
