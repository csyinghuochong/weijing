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
            response.PaiMaiShopItemInfo = paimaiCompontent.GetPaiMaiShopInfo(request.ItemID);

            //后面记录购买的数量
            paimaiCompontent.PaiMaiShopInfoAddBuyNum( request.ItemID, request.BuyNum);

            //扣除对应的上架道具
            PaiMaiItemInfo paiMaiItemInfo = paimaiCompontent.GetPaiMaiItemInfo(request.ItemID);
            if (paiMaiItemInfo!= null)
            {
                int costNum = request.BuyNum;
                if (paiMaiItemInfo.BagInfo.ItemNum > request.BuyNum)
                {
                    //出售部分
                    paiMaiItemInfo.BagInfo.ItemNum -= request.BuyNum;
                }
                else {
                    //出售全部
                    paimaiCompontent.dBPaiMainInfo.PaiMaiItemInfos.Remove(paiMaiItemInfo);
                    costNum = paiMaiItemInfo.BagInfo.ItemNum;
                }

                MailHelp.SendPaiMaiEmail(scene.DomainZone(), paiMaiItemInfo, costNum).Coroutine();
            }

            //返回消息
            reply();
            await ETTask.CompletedTask;
        }
    }
}
