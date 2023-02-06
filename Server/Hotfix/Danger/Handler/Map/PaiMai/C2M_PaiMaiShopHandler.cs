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
			if (unit.GetComponent<BagComponent>().GetSpaceNumber() < 1)
			{
				response.Error = ErrorCore.ERR_BagIsFull;
				reply();
				return;
			}
			if (request.BuyNum < 0)
			{
				response.Error = ErrorCore.ERR_NetWorkError;
				reply();
				return;
			}

			PaiMaiSellConfig paiMaiSellConfig = PaiMaiSellConfigCategory.Instance.Get(request.PaiMaiId);
			if (paiMaiSellConfig == null)
			{
				response.Error = ErrorCore.ERR_NetWorkError;
				reply();
				return;
			}

			using (await CoroutineLockComponent.Instance.Wait(CoroutineLockType.Buy, unit.Id))
			{

				M2P_PaiMaiShopRequest m2P_PaiMaiShopRequest = new M2P_PaiMaiShopRequest()
				{
					ItemID = paiMaiSellConfig.ItemID,
					BuyNum = request.BuyNum,
					//Price = r_PaiMaiShopResponse.PaiMaiShopItemInfo.Price,
					ActorId = unit.GetComponent<UserInfoComponent>().UserInfo.Gold,
				};

				long paimaiServerId = StartSceneConfigCategory.Instance.GetBySceneName(unit.DomainZone(), Enum.GetName(SceneType.PaiMai)).InstanceId;
				P2M_PaiMaiShopResponse r_PaiMaiShopResponse = (P2M_PaiMaiShopResponse)await ActorMessageSenderComponent.Instance.Call(paimaiServerId, m2P_PaiMaiShopRequest);

				if (r_PaiMaiShopResponse.Error != ErrorCore.ERR_Success)
				{
					response.Error = r_PaiMaiShopResponse.Error;
					reply();
					return;
				}

				//消耗金币
				long costGold = r_PaiMaiShopResponse.PaiMaiShopItemInfo.Price * request.BuyNum;
				if (costGold > 0 && unit.GetComponent<UserInfoComponent>().UserInfo.Gold >= costGold)
				{
					//发送金币
					unit.GetComponent<UserInfoComponent>().UpdateRoleMoneySub(UserDataType.Gold, (costGold * -1).ToString(), true, ItemGetWay.PaiMaiShop);

					//添加道具
					List<RewardItem> rewardItems = new List<RewardItem>();
					rewardItems.Add(new RewardItem() { ItemID = paiMaiSellConfig.ItemID, ItemNum = request.BuyNum });
					unit.GetComponent<BagComponent>().OnAddItemData(rewardItems, string.Empty, $"{ItemGetWay.PaiMaiShop}_{TimeHelper.ServerNow()}");
					Log.Debug($"拍卖行购买道具 : {unit.Id}  {paiMaiSellConfig.ItemID}  {request.BuyNum}");
				}
				else
				{
					response.Error = ErrorCore.ERR_GoldNotEnoughError;
				}
			}
			reply();
			await ETTask.CompletedTask;
		}

	}
}
