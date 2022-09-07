using System;
using System.Collections.Generic;

namespace ET
{

    [ActorMessageHandler]
    public  class C2M_PaiMaiShopHandler : AMActorLocationRpcHandler<Unit, C2M_PaiMaiShopRequest, M2C_PaiMaiShopResponse>
    {
		//拍卖快捷列表购买道具
		protected override async ETTask Run(Unit unit, C2M_PaiMaiShopRequest request, M2C_PaiMaiShopResponse response, Action reply)
		{

			PaiMaiSellConfig paiMaiSellConfig = PaiMaiSellConfigCategory.Instance.Get(request.PaiMaiId);

			//测试增加
			M2P_PaiMaiShopRequest m2P_PaiMaiShopRequest = new M2P_PaiMaiShopRequest()
			{
				ItemID = paiMaiSellConfig.ItemID,
				BuyNum = request.BuyNum,
			};

			long paimaiServerId = StartSceneConfigCategory.Instance.GetBySceneName(unit.DomainZone(), Enum.GetName(SceneType.PaiMai)).InstanceId;
			P2M_PaiMaiShopResponse r_PaiMaiShopResponse = (P2M_PaiMaiShopResponse)await ActorMessageSenderComponent.Instance.Call(paimaiServerId, m2P_PaiMaiShopRequest);

			if (unit.GetComponent<BagComponent>().GetSpaceNumber() >= 1)
			{
				long costGold = r_PaiMaiShopResponse.PaiMaiShopItemInfo.Price * request.BuyNum;

				//消耗金币
				if (unit.GetComponent<UserInfoComponent>().UserInfo.Gold >= costGold)
				{
					await unit.GetComponent<UserInfoComponent>().UpdateRoleData(UserDataType.Gold, (costGold * -1).ToString());

					//添加道具
					List<RewardItem> rewardItems = new List<RewardItem>();
					rewardItems.Add(new RewardItem() { ItemID = paiMaiSellConfig.ItemID, ItemNum = request.BuyNum });
					unit.GetComponent<BagComponent>().OnAddItemData(rewardItems, 0, $"{ItemGetWay.PaiMaiShop}_{TimeHelper.ServerNow()}");
				}
				else
				{
					response.Error = ErrorCore.ERR_GoldNotEnoughError;
				}
			}
			else {
				response.Error = ErrorCore.ERR_BagIsFull;
			}

			reply();
			await ETTask.CompletedTask;
		}

	}
}
