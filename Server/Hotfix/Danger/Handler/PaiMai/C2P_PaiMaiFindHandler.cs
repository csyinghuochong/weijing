using System;
using System.Collections.Generic;

namespace ET
{
    /// <summary>
    /// 查找装备所在拍卖行那一页(待实现)
    /// </summary>
    [ActorMessageHandler]
    public class C2P_PaiMaiFindHandler: AMActorRpcHandler<Scene, C2P_PaiMaiFindRequest, P2C_PaiMaiFindResponse>
    {
        protected override async ETTask Run(Scene scene, C2P_PaiMaiFindRequest request, P2C_PaiMaiFindResponse response, Action reply)
        {
            PaiMaiSceneComponent paiMaiComponent = scene.GetComponent<PaiMaiSceneComponent>();
            DBPaiMainInfo dBPaiMainInfo = paiMaiComponent.GetPaiMaiDBByType(request.ItemType);
            if (dBPaiMainInfo == null)
            {
                response.Page = 0;
                reply();
                return;
            }

            List<PaiMaiItemInfo> PaiMaiItemInfo = dBPaiMainInfo.PaiMaiItemInfos;

            PaiMaiItemInfo paiMaiItemInfo = null;
            for (int i = 0; i < PaiMaiItemInfo.Count; i++)
            {
                if (PaiMaiItemInfo[i].Id == request.PaiMaiItemInfoId)
                {
                    paiMaiItemInfo = PaiMaiItemInfo[i];
                    break;
                }
            }

            if (paiMaiItemInfo == null)
            {
                response.Page = 0;
                reply();
                return;
            }

            int pagenum = int.Parse(GlobalValueConfigCategory.Instance.Get(104).Value); //每页的数量
            ItemConfig itemConfig = ItemConfigCategory.Instance.Get(paiMaiItemInfo.BagInfo.ItemID);
            for (int i = 0; i < PaiMaiItemInfo.Count; i++)
            {
                if (PaiMaiItemInfo[i].Id == paiMaiItemInfo.Id)
                {
                    response.Page = i / pagenum + 1;
                    reply();
                    return;
                }
            }
            response.Page = 0;
            reply();
            await ETTask.CompletedTask;
        }
    }
}