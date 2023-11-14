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
                int nowPrice = (int)((float)request.PaiMaiItemInfo.Price);
                if (nowPrice < shopinfo.Price * 0.5f)
                {
                    response.Error = ErrorCode.Err_PaiMaiPriceLow;
                    reply();
                    return;
                }
            }
            scene.GetComponent<PaiMaiSceneComponent>().dBPaiMainInfo.PaiMaiItemInfos.Add(request.PaiMaiItemInfo);
            
            // 上架紫色道具刷新该类型的道具
            ItemConfig itemConfig = ItemConfigCategory.Instance.Get(request.PaiMaiItemInfo.BagInfo.ItemID);
            if (itemConfig.ItemQuality >= 4)
            {
                switch (itemConfig.ItemType)
                {
                    //消耗品
                    case 1:
                        scene.GetComponent<PaiMaiSceneComponent>().UpdateTimeConsume = 0;
                        break;
                    //材料
                    case 2:
                        scene.GetComponent<PaiMaiSceneComponent>().UpdateTimeMaterial = 0;
                        break;
                    //装备
                    case 3:
                        scene.GetComponent<PaiMaiSceneComponent>().UpdateTimeEquipment = 0;
                        break;
                    //宝石
                    case 4:
                        scene.GetComponent<PaiMaiSceneComponent>().UpdateTimeGemstone = 0;
                        break;
                    //宠物之核
                    case 5:
                        scene.GetComponent<PaiMaiSceneComponent>().UpdateTimeMaterial = 0;
                        break;
                }
            }

            reply();
            await ETTask.CompletedTask;
        }
    }
}
