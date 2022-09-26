using System;

namespace ET
{
    [ActorMessageHandler]
    public class C2M_PaiMaiBuyHandler : AMActorLocationRpcHandler<Unit, C2M_PaiMaiBuyRequest, M2C_PaiMaiBuyResponse>
    {
        //拍卖行购买道具
        protected override async ETTask Run(Unit unit, C2M_PaiMaiBuyRequest request, M2C_PaiMaiBuyResponse response, Action reply)
        {
         
            //背包是否有位置
            if (unit.GetComponent<BagComponent>().GetSpaceNumber() < 1)
            {
                response.Error = ErrorCore.ERR_BagIsFull;
                reply();
                return;
            }
            if (request.PaiMaiItemInfo == null || request.PaiMaiItemInfo.BagInfo == null)
            {
                reply();
                return;
            }

            PaiMaiItemInfo paiMaiItemInfo = request.PaiMaiItemInfo;
            long needGold = paiMaiItemInfo.Price * paiMaiItemInfo.BagInfo.ItemNum;
            //钱是否足够
            if (unit.GetComponent<UserInfoComponent>().UserInfo.Gold < needGold)
            {
                response.Error = ErrorCore.ERR_GoldNotEnoughError;
                reply();
                return;
            }

            long paimaiServerId = StartSceneConfigCategory.Instance.GetBySceneName(unit.DomainZone(), Enum.GetName(SceneType.PaiMai)).InstanceId;
            P2M_PaiMaiBuyResponse r_GameStatusResponse = (P2M_PaiMaiBuyResponse)await ActorMessageSenderComponent.Instance.Call
                (paimaiServerId, new M2P_PaiMaiBuyRequest()
                {
                    PaiMaiItemInfo = request.PaiMaiItemInfo
                });

            await unit.GetComponent<UserInfoComponent>().UpdateRoleData(UserDataType.Gold, (needGold * -1).ToString());

            //背包添加道具
            unit.GetComponent<BagComponent>().OnAddItemData(r_GameStatusResponse.PaiMaiItemInfo.BagInfo);

            //给出售者邮件发送金币
            MailHelp.SendPaiMaiEmail(unit.DomainZone() ,r_GameStatusResponse.PaiMaiItemInfo, r_GameStatusResponse.PaiMaiItemInfo.BagInfo.ItemNum).Coroutine();
            reply();
            await ETTask.CompletedTask;
        }
    }
}
