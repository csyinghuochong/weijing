using System;
using System.Collections.Generic;

namespace ET
{
    [ActorMessageHandler]
    public class M2P_PaiMaiBuyHandler : AMActorRpcHandler<Scene, M2P_PaiMaiBuyRequest, P2M_PaiMaiBuyResponse>
    {

        protected override async ETTask Run(Scene scene, M2P_PaiMaiBuyRequest request, P2M_PaiMaiBuyResponse response, Action reply)
        {
            long needGold = 0 ;
            PaiMaiItemInfo paiMaiItemInfo = null;
            List<PaiMaiItemInfo> paiMaiItemInfos =  scene.GetComponent<PaiMaiSceneComponent>().dBPaiMainInfo.PaiMaiItemInfos;
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
                response.Error = ErrorCode.ERR_ModifyData;
                reply();
                return;
            }
            
            if (request.BuyNum < 0 || request.BuyNum > paiMaiItemInfo.BagInfo.ItemNum)
            {
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

            //获取列表,对应的缓存进行清空
            if (!ItemConfigCategory.Instance.Contain(request.PaiMaiItemInfo.BagInfo.ItemID))
            {
                response.Error = ErrorCode.ERR_ItemNotExist;
                reply();
                return;
            }

            ItemConfig itemCof = ItemConfigCategory.Instance.Get(request.PaiMaiItemInfo.BagInfo.ItemID);
            switch (itemCof.ItemType) {

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
