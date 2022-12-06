using System;

namespace ET
{

    [ActorMessageHandler]
    public class M2P_PaiMaiSellHandler : AMActorRpcHandler<Scene, M2P_PaiMaiSellRequest, P2M_PaiMaiSellResponse>
    {

        protected override async ETTask Run(Scene scene, M2P_PaiMaiSellRequest request, P2M_PaiMaiSellResponse response, Action reply)
        {

            //判定出售价格最低不能低于快捷拍卖列表的50%
            PaiMaiShopItemInfo shopinfo = scene.GetComponent<PaiMaiSceneComponent>().GetPaiMaiShopInfo(request.PaiMaiItemInfo.BagInfo.ItemID);
            if (shopinfo != null)
            {
                int nowPrice = (int)((float)request.PaiMaiItemInfo.Price / (float)request.PaiMaiItemInfo.BagInfo.ItemNum);
                if (nowPrice < shopinfo.Price * 0.5f)
                {
                    response.Error = ErrorCore.Err_PaiMaiPriceLow;
                    reply();
                    return;
                }
            }
            scene.GetComponent<PaiMaiSceneComponent>().dBPaiMainInfo.PaiMaiItemInfos.Add(request.PaiMaiItemInfo);

            reply();
            await ETTask.CompletedTask;
        }
    }
}
