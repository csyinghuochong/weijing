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
            List<PaiMaiItemInfo> PaiMaiItemInfo = paiMaiComponent.dBPaiMainInfo.PaiMaiItemInfos;

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

            List<PaiMaiItemInfo> paimaiListShow = new List<PaiMaiItemInfo>();
            ItemConfig itemConfig = ItemConfigCategory.Instance.Get(paiMaiItemInfo.BagInfo.ItemID);
            // 通过链接点开拍卖行的时候就刷新了
            switch (itemConfig.ItemType)
            {
                //消耗品
                case 1:
                    if (paiMaiComponent.PaiMaiItemInfos_Consume_New.ContainsKey(0))
                    {
                        paimaiListShow = paiMaiComponent.PaiMaiItemInfos_Consume_New[0];
                    }

                    break;
                //材料
                case 2:
                    if (paiMaiComponent.PaiMaiItemInfos_Material_New.ContainsKey(0))
                    {
                        paimaiListShow = paiMaiComponent.PaiMaiItemInfos_Material_New[0];
                    }

                    break;
                //装备
                case 3:
                    if (paiMaiComponent.PaiMaiItemInfos_Equipment_New.ContainsKey(0))
                    {
                        paimaiListShow = paiMaiComponent.PaiMaiItemInfos_Equipment_New[0];
                    }

                    break;
                //宝石
                case 4:
                    if (paiMaiComponent.PaiMaiItemInfos_Gemstone_New.ContainsKey(0))
                    {
                        paimaiListShow = paiMaiComponent.PaiMaiItemInfos_Gemstone_New[0];
                    }

                    break;
            }

            for (int i = 0; i < paimaiListShow.Count; i++)
            {
                if (paimaiListShow[i].Id == paiMaiItemInfo.Id)
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