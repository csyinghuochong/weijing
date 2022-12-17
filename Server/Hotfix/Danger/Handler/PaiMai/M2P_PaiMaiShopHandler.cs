using System;
using System.Collections.Generic;

namespace ET
{

    [ActorMessageHandler]
    public class M2P_PaiMaiShopHandler : AMActorRpcHandler<Scene, M2P_PaiMaiShopRequest, P2M_PaiMaiShopResponse>
    {

        protected override async ETTask Run(Scene scene, M2P_PaiMaiShopRequest request, P2M_PaiMaiShopResponse response, Action reply)
        {
            try
            {
                //获取当前的数据
                PaiMaiSceneComponent paimaiCompontent = scene.GetComponent<PaiMaiSceneComponent>();
                response.PaiMaiShopItemInfo = paimaiCompontent.GetPaiMaiShopInfo(request.ItemID);

                long costGold = response.PaiMaiShopItemInfo.Price * request.BuyNum;
                if (request.ActorId < costGold || costGold < 0)
                {
                    response.Error = ErrorCore.ERR_GoldNotEnoughError;
                    reply();
                    return;
                }

                //后面记录购买的数量
                paimaiCompontent.PaiMaiShopInfoAddBuyNum(request.ItemID, request.BuyNum);
                //扣除对应的上架道具
                List<PaiMaiItemInfo> paiMaiItemInfo = paimaiCompontent.GetPaiMaiItemInfo(request.ItemID, response.PaiMaiShopItemInfo.Price);
                if (paiMaiItemInfo != null)
                {
                    //int sellSingPri = (int)((float)paiMaiItemInfo.Price / paiMaiItemInfo.BagInfo.ItemNum * 0.9f);
                    /*
                    if (sellSingPri < response.PaiMaiShopItemInfo.Price) {

                        int costNum = request.BuyNum;
                        if (paiMaiItemInfo.BagInfo.ItemNum > request.BuyNum)
                        {
                            //出售部分
                            paiMaiItemInfo.BagInfo.ItemNum -= request.BuyNum;
                        }
                        else
                        { 
                            //出售全部
                            paimaiCompontent.dBPaiMainInfo.PaiMaiItemInfos.Remove(paiMaiItemInfo);
                            costNum = paiMaiItemInfo.BagInfo.ItemNum;
                        }
                        MailHelp.SendPaiMaiEmail(scene.DomainZone(), paiMaiItemInfo, costNum).Coroutine();

                    }
                    */
                    

                    foreach (PaiMaiItemInfo info in paiMaiItemInfo) {

                        bool ifEndFor = false;
                        int costNum = request.BuyNum;
                        int costItemNum = request.BuyNum;

                        if (info.BagInfo.ItemNum > request.BuyNum)
                        {
                            //出售部分
                            int nowSingPri = (int)((float)info.Price / (float)info.BagInfo.ItemNum);
                            info.BagInfo.ItemNum -= request.BuyNum;
                            //设置剩余价格
                            info.Price = nowSingPri * info.BagInfo.ItemNum;
                            costItemNum -= request.BuyNum;
                        }
                        else
                        {
                            //出售全部
                            paimaiCompontent.dBPaiMainInfo.PaiMaiItemInfos.Remove(info);
                            costNum = info.BagInfo.ItemNum;
                            costItemNum -= info.BagInfo.ItemNum;
                        }

                        MailHelp.SendPaiMaiEmail(scene.DomainZone(), info, costNum).Coroutine();

                        if (costItemNum <= 0) {
                            ifEndFor = true;
                        }

                        //结束循环
                        if (ifEndFor) {
                            break;
                        }
                    }

                }
                
              
                //返回消息
                reply();
                await ETTask.CompletedTask;
            }
            catch (Exception ex)
            {
                Log.Error(ex.ToString());
            }
        }
    }
}
