using System;
using UnityEngine;

namespace ET
{
    [ActorMessageHandler]
    public class C2M_PaiMaiBuyHandler : AMActorLocationRpcHandler<Unit, C2M_PaiMaiBuyRequest, M2C_PaiMaiBuyResponse>
    {
        //拍卖行购买道具
        protected override async ETTask Run(Unit unit, C2M_PaiMaiBuyRequest request, M2C_PaiMaiBuyResponse response, Action reply)
        {
            //背包是否有位置

            if (unit.GetComponent<BagComponent>().GetLeftSpace() < 1)
            {
                response.Error = ErrorCore.ERR_BagIsFull;
                reply();
                return;
            }
            PaiMaiItemInfo paiMaiItemInfo = request.PaiMaiItemInfo;
            if (request.PaiMaiItemInfo == null || request.PaiMaiItemInfo.BagInfo == null)
            {
                reply();
                return;
            }

            ItemConfig itemConfig = ItemConfigCategory.Instance.Get(paiMaiItemInfo.BagInfo.ItemID);
            int cell = Mathf.CeilToInt(paiMaiItemInfo.BagInfo.ItemNum * 1f / itemConfig.ItemPileSum);
            if (unit.GetComponent<BagComponent>().GetLeftSpace() < cell)
            {
                response.Error = ErrorCore.ERR_BagIsFull;
                reply();
                return;
            }

            long needGold = (long)paiMaiItemInfo.Price * paiMaiItemInfo.BagInfo.ItemNum;
            if (paiMaiItemInfo.BagInfo.ItemNum < 0 || needGold < 0)
            {
                response.Error = ErrorCore.ERR_GoldNotEnoughError;
                reply();
                return;
            }

            //钱是否足够
            if (unit.GetComponent<UserInfoComponent>().UserInfo.Gold < needGold)
            {
                response.Error = ErrorCore.ERR_GoldNotEnoughError;
                reply();
                return;
            }

            using (await CoroutineLockComponent.Instance.Wait(CoroutineLockType.Buy, unit.Id))
            {
                long paimaiServerId = DBHelper.GetPaiMaiServerId( unit.DomainZone() );
                P2M_PaiMaiBuyResponse r_GameStatusResponse = (P2M_PaiMaiBuyResponse)await ActorMessageSenderComponent.Instance.Call
                    (paimaiServerId, new M2P_PaiMaiBuyRequest()
                    {
                        PaiMaiItemInfo = request.PaiMaiItemInfo,
                       ActorId = unit.GetComponent<UserInfoComponent>().UserInfo.Gold
                    });
                if (r_GameStatusResponse.Error != ErrorCore.ERR_Success)
                {
                    response.Error = r_GameStatusResponse.Error;
                    reply();
                    return;
                }
                needGold = (long)r_GameStatusResponse.PaiMaiItemInfo.Price * r_GameStatusResponse.PaiMaiItemInfo.BagInfo.ItemNum;
               
                unit.GetComponent<UserInfoComponent>().UpdateRoleMoneySub(UserDataType.Gold, (needGold * -1).ToString(), true, ItemGetWay.PaiMaiBuy);
                //背包添加道具
                unit.GetComponent<BagComponent>().OnAddItemData(r_GameStatusResponse.PaiMaiItemInfo.BagInfo, $"{ItemGetWay.PaiMaiBuy}_{TimeHelper.ServerNow()}");

                //给出售者邮件发送金币
                MailHelp.SendPaiMaiEmail(unit.DomainZone(), r_GameStatusResponse.PaiMaiItemInfo, r_GameStatusResponse.PaiMaiItemInfo.BagInfo.ItemNum).Coroutine();
            }

            reply();
            await ETTask.CompletedTask;
        }
    }
}
