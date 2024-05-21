using System;
using System.Collections.Generic;

namespace ET
{
    [ActorMessageHandler]
    public class M2P_PaiMaiBuyHandler : AMActorRpcHandler<Scene, M2P_PaiMaiBuyRequest, P2M_PaiMaiBuyResponse>
    {

        protected override async ETTask Run(Scene scene, M2P_PaiMaiBuyRequest request, P2M_PaiMaiBuyResponse response, Action reply)
        {
            //获取列表,对应的缓存进行清空
            if (!ItemConfigCategory.Instance.Contain(request.PaiMaiItemInfo.BagInfo.ItemID))
            {
                response.Error = ErrorCode.ERR_ItemNotExist;
                reply();
                return;
            }
            ItemConfig itemCof = ItemConfigCategory.Instance.Get(request.PaiMaiItemInfo.BagInfo.ItemID);
            int itemType = itemCof.ItemType;
            DBPaiMainInfo dBPaiMainInfo = scene.GetComponent<PaiMaiSceneComponent>().GetPaiMaiDBByType(itemType);
            if (dBPaiMainInfo == null)
            {
                response.Error = ErrorCode.ERR_ItemNotExist;
                reply();
                return;
            }

            long needGold = 0 ;
            PaiMaiItemInfo paiMaiItemInfo = null;
            List<PaiMaiItemInfo> paiMaiItemInfos = dBPaiMainInfo.PaiMaiItemInfos;
            for (int i = paiMaiItemInfos.Count - 1; i >= 0; i--)
            {
                if (paiMaiItemInfos[i].Id == request.PaiMaiItemInfo.Id)
                {
                    paiMaiItemInfo = paiMaiItemInfos[i];
                    break;
                }
            }

            if (paiMaiItemInfo == null)
            {
                reply();
                return;
            }
            
            if (request.BuyNum < 0 || request.BuyNum > paiMaiItemInfo.BagInfo.ItemNum)
            {
                Log.Error("M2P_PaiMaiBuyHandler 1");
                response.Error = ErrorCode.ERR_ModifyData;
                reply();
                return;
            }
            
            needGold = (long)paiMaiItemInfo.Price * request.BuyNum;
            if (request.Gold < needGold)
            {
                response.Error = ErrorCode.ERR_GoldNotEnoughError;
                reply();
                return;
            }

            BagInfo bagInfo = paiMaiItemInfo.BagInfo;
            if (request.BuyNum == bagInfo.ItemNum)
            {
                response.PaiMaiItemInfo = paiMaiItemInfo;
                paiMaiItemInfos.Remove(paiMaiItemInfo);
            }
            else
            {
                bagInfo.ItemNum -= request.BuyNum;
                PaiMaiItemInfo paiMaiItemInfo2 = new PaiMaiItemInfo();
                
                BagInfo useBagInfo = new BagInfo();
                useBagInfo.ItemID = bagInfo.ItemID;
                useBagInfo.ItemNum = request.BuyNum;
                useBagInfo.Loc = itemCof.ItemType == (int)ItemTypeEnum.PetHeXin ? (int)ItemLocType.ItemPetHeXinBag : (int)ItemLocType.ItemLocBag;
                useBagInfo.BagInfoID = IdGenerater.Instance.GenerateId();
                useBagInfo.GemHole = ItemHelper.DefaultGem;
                useBagInfo.GemIDNew = ItemHelper.DefaultGem;
                useBagInfo.GetWay = bagInfo.GetWay;
                useBagInfo.isBinging = bagInfo.isBinging;
                
                paiMaiItemInfo2.Id = IdGenerater.Instance.GenerateId();
                paiMaiItemInfo2.BagInfo = useBagInfo;
                paiMaiItemInfo2.UserId = paiMaiItemInfo.UserId;
                paiMaiItemInfo2.Price = paiMaiItemInfo.Price;
                paiMaiItemInfo2.PlayerName = paiMaiItemInfo.PlayerName;
                paiMaiItemInfo2.SellTime = paiMaiItemInfo.SellTime;
                
                response.PaiMaiItemInfo = paiMaiItemInfo2;
            }
            reply();
            await ETTask.CompletedTask;
        }
    }
}
