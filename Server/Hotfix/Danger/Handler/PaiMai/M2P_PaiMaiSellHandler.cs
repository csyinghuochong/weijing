using System;
using System.Collections.Generic;

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

            PaiMaiSceneComponent paiMaiComponent = scene.GetComponent<PaiMaiSceneComponent>();
            List<PaiMaiItemInfo> paiMaiItemsTo = new List<PaiMaiItemInfo>();
            paiMaiItemsTo.AddRange(paiMaiComponent.GetItemListByUser(request.UnitID, paiMaiComponent.dBPaiMainInfo_Consume.PaiMaiItemInfos));
            paiMaiItemsTo.AddRange(paiMaiComponent.GetItemListByUser(request.UnitID, paiMaiComponent.dBPaiMainInfo_Material.PaiMaiItemInfos));
            paiMaiItemsTo.AddRange(paiMaiComponent.GetItemListByUser(request.UnitID, paiMaiComponent.dBPaiMainInfo_Equipment.PaiMaiItemInfos));
            paiMaiItemsTo.AddRange(paiMaiComponent.GetItemListByUser(request.UnitID, paiMaiComponent.dBPaiMainInfo_Gemstone.PaiMaiItemInfos));

            long paimaiingGold = 0;
            for (int i = 0; i < paiMaiItemsTo.Count; i++)
            {
                paimaiingGold += (paiMaiItemsTo[i].Price * paiMaiItemsTo[i].BagInfo.ItemNum);
            }

            if (paimaiingGold + request.PaiMaiTodayGold >= 50000000)
            {
                response.Error = ErrorCode.ERR_PaiMaiSellLimit;
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
