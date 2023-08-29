using System;
using System.Collections.Generic;

namespace ET
{

    [ActorMessageHandler]
    public class M2U_UnionMysteryBuyHandler : AMActorRpcHandler<Scene, M2U_UnionMysteryBuyRequest, U2M_UnionMysteryBuyResponse>
    {
        protected override async ETTask Run(Scene scene, M2U_UnionMysteryBuyRequest request, U2M_UnionMysteryBuyResponse response, Action reply)
        {

            DBUnionInfo dBUnionInfo = await scene.GetComponent<UnionSceneComponent>().GetDBUnionInfo(request.UnionId);
            if (dBUnionInfo == null)
            {
                response.Error = ErrorCode.ERR_Union_Not_Exist;
                reply();
                return;
            }

            bool haveItem = false;
            List<MysteryItemInfo> mysteryItemInfos = dBUnionInfo.MysteryItemInfos;
            for (int i = 0; i < mysteryItemInfos.Count; i++)
            {
                if (mysteryItemInfos[i].MysteryId != request.MysteryId)
                {
                    continue;
                }

                if (mysteryItemInfos[i].ItemNumber >= request.BuyNumber)
                {
                    mysteryItemInfos[i].ItemNumber -= request.BuyNumber;
                    haveItem = true;
                    break;
                }
            }
            if (!haveItem)
            {
                response.Error = ErrorCode.ERR_ItemNotEnoughError;
            }
            DBHelper.SaveComponent(scene.DomainZone(), request.UnionId, dBUnionInfo).Coroutine();
            reply();
            await ETTask.CompletedTask;
        }
    }
}
