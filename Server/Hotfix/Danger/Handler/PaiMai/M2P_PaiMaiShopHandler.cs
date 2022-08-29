using System;

namespace ET
{

    [ActorMessageHandler]
    public class M2P_PaiMaiShopHandler : AMActorRpcHandler<Scene, M2P_PaiMaiShopRequest, P2M_PaiMaiShopResponse>
    {

        protected override async ETTask Run(Scene scene, M2P_PaiMaiShopRequest request, P2M_PaiMaiShopResponse response, Action reply)
        {
            //获取当前的数据
            PaiMaiSceneComponent paimaiCompontent = scene.GetComponent<PaiMaiSceneComponent>();
            response.PaiMaiShopItemInfo = PaiMaiHelper.Instance.GetPaiMaiShopInfo(paimaiCompontent.dBPaiMainInfo.PaiMaiShopItemInfos, request.ItemID);

            //后面记录购买的数量
            PaiMaiHelper.Instance.PaiMaiShopInfoAddBuyNum(paimaiCompontent.dBPaiMainInfo.PaiMaiShopItemInfos, request.ItemID, request.BuyNum);

            //返回消息
            reply();
            await ETTask.CompletedTask;
        }
    }
}
