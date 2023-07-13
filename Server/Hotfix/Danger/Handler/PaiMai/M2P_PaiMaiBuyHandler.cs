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
                response.Error = ErrorCore.ERR_ModifyData;
                reply();
                return;
            }

            needGold = (long)paiMaiItemInfo.Price * paiMaiItemInfo.BagInfo.ItemNum;
            if (request.ActorId < needGold)
            {
                response.Error = ErrorCore.ERR_GoldNotEnoughError;
                reply();
                return;
            }

            //获取列表,对应的缓存进行清空
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

            response.PaiMaiItemInfo = paiMaiItemInfo;
            paiMaiItemInfos.Remove(paiMaiItemInfo);
            reply();
            await ETTask.CompletedTask;
        }
    }
}
