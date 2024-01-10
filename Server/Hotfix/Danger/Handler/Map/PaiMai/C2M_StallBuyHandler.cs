using System;
using UnityEngine;

namespace ET
{
    [ActorMessageHandler]
    public class C2M_StallBuyHandler: AMActorLocationRpcHandler<Unit, C2M_StallBuyRequest, M2C_StallBuyResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_StallBuyRequest request, M2C_StallBuyResponse response, Action reply)
        {
            //背包是否有位置
            if (unit.GetComponent<BagComponent>().GetBagLeftCell() < 1)
            {
                response.Error = ErrorCode.ERR_BagIsFull;
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
            if (unit.GetComponent<BagComponent>().GetBagLeftCell() < cell)
            {
                response.Error = ErrorCode.ERR_BagIsFull;
                reply();
                return;
            }

            long needGold = (long)paiMaiItemInfo.Price * paiMaiItemInfo.BagInfo.ItemNum;
            if (paiMaiItemInfo.BagInfo.ItemNum < 0 || needGold < 0)
            {
                response.Error = ErrorCode.ERR_GoldNotEnoughError;
                reply();
                return;
            }

            //钱是否足够
            if (unit.GetComponent<UserInfoComponent>().UserInfo.Gold < needGold)
            {
                response.Error = ErrorCode.ERR_GoldNotEnoughError;
                reply();
                return;
            }

            using (await CoroutineLockComponent.Instance.Wait(CoroutineLockType.Buy, unit.Id))
            {
                long paimaiServerId = DBHelper.GetPaiMaiServerId(unit.DomainZone());
                P2M_StallBuyResponse p2MStallBuyResponse = (P2M_StallBuyResponse)await ActorMessageSenderComponent.Instance.Call(paimaiServerId,
                    new M2P_StallBuyRequest()
                    {
                        PaiMaiItemInfo = request.PaiMaiItemInfo, ActorId = unit.GetComponent<UserInfoComponent>().UserInfo.Gold
                    });
                if (p2MStallBuyResponse.Error != ErrorCode.ERR_Success)
                {
                    response.Error = p2MStallBuyResponse.Error;
                    reply();
                    return;
                }

                needGold = (long)p2MStallBuyResponse.PaiMaiItemInfo.Price * p2MStallBuyResponse.PaiMaiItemInfo.BagInfo.ItemNum;

                unit.GetComponent<UserInfoComponent>().UpdateRoleMoneySub(UserDataType.Gold, (needGold * -1).ToString(), true, ItemGetWay.StallBuy);
                //背包添加道具
                unit.GetComponent<BagComponent>()
                        .OnAddItemData(p2MStallBuyResponse.PaiMaiItemInfo.BagInfo, $"{ItemGetWay.StallBuy}_{TimeHelper.ServerNow()}");

                //给出售者邮件发送金币
                MailHelp.SendPaiMaiEmail(unit.DomainZone(), p2MStallBuyResponse.PaiMaiItemInfo, p2MStallBuyResponse.PaiMaiItemInfo.BagInfo.ItemNum)
                        .Coroutine();

                Log.Warning(
                    $"摆摊购买: {unit.Id} 购买 {p2MStallBuyResponse.PaiMaiItemInfo.UserId} 道具ID：{p2MStallBuyResponse.PaiMaiItemInfo.BagInfo.ItemNum} 花费：{needGold} ");
            }

            reply();
            await ETTask.CompletedTask;
        }
    }
}