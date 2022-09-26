using System;
using System.Collections.Generic;

namespace ET
{

    [ActorMessageHandler]
    public class C2M_PaiMaiXiaJiaHandler : AMActorLocationRpcHandler<Unit, C2M_PaiMaiXiaJiaRequest, M2C_PaiMaiXiaJiaResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_PaiMaiXiaJiaRequest request, M2C_PaiMaiXiaJiaResponse response, Action reply)
        {
            long chargeServerId = StartSceneConfigCategory.Instance.GetBySceneName(unit.DomainZone(), Enum.GetName(SceneType.PaiMai)).InstanceId;
            P2M_PaiMaiXiaJiaResponse r_GameStatusResponse = (P2M_PaiMaiXiaJiaResponse)await ActorMessageSenderComponent.Instance.Call
                (chargeServerId, new M2P_PaiMaiXiaJiaRequest()
                {
                    PaiMaiItemInfoId = request.PaiMaiItemInfoId
                });

            if (r_GameStatusResponse.Error == ErrorCore.ERR_Success && r_GameStatusResponse.PaiMaiItemInfo != null)
            {
                unit.GetComponent<BagComponent>().OnAddItemData(r_GameStatusResponse.PaiMaiItemInfo.BagInfo);
            }
            else
            {
                Log.Info($"C2M_PaiMaiXiaJiaHandler==null  {unit.Id} {request.PaiMaiItemInfoId}");
            }
            
            reply();
        }
    }
}
