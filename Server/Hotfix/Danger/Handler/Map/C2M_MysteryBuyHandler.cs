using System;
using System.Collections.Generic;

namespace ET
{

    [ActorMessageHandler]
    public class C2M_MysteryBuyHandler : AMActorLocationRpcHandler<Unit, C2M_MysteryBuyRequest, M2C_MysteryBuyResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_MysteryBuyRequest request, M2C_MysteryBuyResponse response, Action reply)
        {
            switch(request.NpcId)
            {
                case ComHelp.ShenMiNpcId:
                    long chargeServerId = StartSceneConfigCategory.Instance.GetBySceneName(unit.DomainZone(), Enum.GetName(SceneType.Activity)).InstanceId;
                    A2M_MysteryBuyResponse r_GameStatusResponse = (A2M_MysteryBuyResponse)await ActorMessageSenderComponent.Instance.Call
                        (chargeServerId, new M2A_MysteryBuyRequest()
                        {
                            MysteryItemInfo = request.MysteryItemInfo
                        });

                    if (r_GameStatusResponse.Error != ErrorCore.ERR_Success)
                    {
                        response.Error = r_GameStatusResponse.Error;
                        reply();
                        return;
                    }
                    break;
                case ComHelp.MoNengNpcId:
                    List<MysteryItemInfo> MysteryItemInfos =  unit.DomainScene().GetComponent<CellDungeonComponent>().MysteryItemInfos;
                    for (int i = 0; i < MysteryItemInfos.Count; i++)
                    {
                        MysteryItemInfo mysteryItemInfo1 = MysteryItemInfos[i];

                        if (mysteryItemInfo1.ItemID != request.MysteryItemInfo.ItemID)
                        {
                            continue;
                        }
                        if (mysteryItemInfo1.ItemNumber < request.MysteryItemInfo.ItemNumber)
                        {
                            response.Error =  ErrorCore.ERR_ItemNotEnoughError;
                            reply();
                            return;
                        }
                        mysteryItemInfo1.ItemNumber -= request.MysteryItemInfo.ItemNumber;
                        break;
                    }
                    break;
            }

            MysteryConfig mysteryConfig = MysteryConfigCategory.Instance.Get(request.MysteryItemInfo.MysteryId);
            unit.GetComponent<UserInfoComponent>().UpdateRoleData(UserDataType.Gold, (mysteryConfig.SellValue * -1).ToString()).Coroutine();
            unit.GetComponent<BagComponent>().OnAddItemData($"{request.MysteryItemInfo.ItemID};{request.MysteryItemInfo.ItemNumber}",
                $"{ItemGetWay.MysteryBuy}_{TimeHelper.ServerNow()}");
            reply();
        }
    }
}
