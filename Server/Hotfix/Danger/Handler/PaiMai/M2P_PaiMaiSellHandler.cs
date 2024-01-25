using System;

namespace ET
{

    [ActorMessageHandler]
    public class M2P_PaiMaiSellHandler : AMActorRpcHandler<Scene, M2P_PaiMaiSellRequest, P2M_PaiMaiSellResponse>
    {

        protected override async ETTask Run(Scene scene, M2P_PaiMaiSellRequest request, P2M_PaiMaiSellResponse response, Action reply)
        {
            if (!ItemConfigCategory.Instance.Contain(request.PaiMaiItemInfo.BagInfo.ItemID))
            {
                response.Error = ErrorCode.ERR_ItemNotExist;
                reply();
                return;
            }

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
            // 上架紫色道具刷新该类型的道具
            ItemConfig itemConfig = ItemConfigCategory.Instance.Get(request.PaiMaiItemInfo.BagInfo.ItemID);
            DBPaiMainInfo dBPaiMainInfo = scene.GetComponent<PaiMaiSceneComponent>().GetPaiMaiDBByType(itemConfig.ItemType);
            if (dBPaiMainInfo == null)
            {
                response.Error = ErrorCode.ERR_ItemNotExist;
                reply();
                return;
            }

            dBPaiMainInfo.PaiMaiItemInfos.Add(request.PaiMaiItemInfo);
            reply();
            await ETTask.CompletedTask;
        }
    }
}
