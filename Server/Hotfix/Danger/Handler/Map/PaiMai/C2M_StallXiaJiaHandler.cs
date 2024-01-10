using System;
using System.Collections.Generic;

namespace ET
{
    [ActorMessageHandler]
    public class C2M_StallXiaJiaHandler: AMActorLocationRpcHandler<Unit, C2M_StallXiaJiaRequest, M2C_StallXiaJiaResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_StallXiaJiaRequest request, M2C_StallXiaJiaResponse response, Action reply)
        {
            using (await CoroutineLockComponent.Instance.Wait(CoroutineLockType.XiaJia, unit.Id))
            {
                if (unit.GetComponent<BagComponent>().GetBagLeftCell() < 1)
                {
                    reply();
                    return;
                }

                long chargeServerId = StartSceneConfigCategory.Instance.GetBySceneName(unit.DomainZone(), Enum.GetName(SceneType.PaiMai)).InstanceId;
                P2M_StallXiaJiaResponse p2MStallXiaJiaResponse =
                        (P2M_StallXiaJiaResponse)await ActorMessageSenderComponent.Instance.Call(chargeServerId,
                            new M2P_StallXiaJiaRequest() { PaiMaiItemInfoId = request.PaiMaiItemInfoId });

                if (p2MStallXiaJiaResponse.Error == ErrorCode.ERR_Success && p2MStallXiaJiaResponse.PaiMaiItemInfo != null)
                {
                    unit.GetComponent<BagComponent>().OnAddItemData(p2MStallXiaJiaResponse.PaiMaiItemInfo.BagInfo,
                        $"{ItemGetWay.XiaJia}_{TimeHelper.ServerNow()}");
                }
                else
                {
                    LogHelper.LogWarning($"C2M_PaiMaiXiaJiaHandler==null  {unit.Id} {request.PaiMaiItemInfoId}");
                }

                reply();
                await ETTask.CompletedTask;
            }
        }
    }
}