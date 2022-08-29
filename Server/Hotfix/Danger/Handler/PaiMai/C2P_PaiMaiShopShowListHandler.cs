using System;
using System.Collections.Generic;

namespace ET
{

    [ActorMessageHandler]
    public  class C2P_PaiMaiShopShowListHandler : AMActorRpcHandler<Scene, C2P_PaiMaiShopShowListRequest, P2C_PaiMaiShopShowListResponse>
    {
		//拍卖快捷列表购买道具
		protected override async ETTask Run(Scene scene, C2P_PaiMaiShopShowListRequest request, P2C_PaiMaiShopShowListResponse response, Action reply)
		{

			PaiMaiSceneComponent paimaiCompontent = scene.GetComponent<PaiMaiSceneComponent>();
			List<PaiMaiShopItemInfo> paiMaiItemInfos = paimaiCompontent.dBPaiMainInfo.PaiMaiShopItemInfos;
			response.PaiMaiShopItemInfos = paiMaiItemInfos;

			reply();
			await ETTask.CompletedTask;
		}

	}
}
