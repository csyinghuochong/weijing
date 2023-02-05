using System;

namespace ET
{
    [ActorMessageHandler]
    public class C2M_PaiMaiSellHandler : AMActorLocationRpcHandler<Unit, C2M_PaiMaiSellRequest, M2C_PaiMaiSellResponse>
    {

		protected override async ETTask Run(Unit unit, C2M_PaiMaiSellRequest request, M2C_PaiMaiSellResponse response, Action reply)
		{
			using (await CoroutineLockComponent.Instance.Wait(CoroutineLockType.Sell, unit.Id))
			{
				if (request.PaiMaiItemInfo.BagInfo.ItemNum <= 0)
				{
					reply();
					return;
				}
				//获取出售数据
				request.PaiMaiItemInfo.Id = IdGenerater.Instance.GenerateId();
				request.PaiMaiItemInfo.PlayerName = unit.GetComponent<UserInfoComponent>().UserInfo.Name;
				request.PaiMaiItemInfo.UserId = unit.GetComponent<UserInfoComponent>().UserInfo.UserId;

				//获取时间戳
				long currentTime = TimeHelper.ServerNow();
				request.PaiMaiItemInfo.SellTime = currentTime;

				//对比出售数量和道具是否匹配
				long bagInfoId = request.PaiMaiItemInfo.BagInfo.BagInfoID;
				BagInfo bagInfo = unit.GetComponent<BagComponent>().GetItemByLoc(ItemLocType.ItemLocBag, bagInfoId);
				if (bagInfo == null)
				{
					response.Error = ErrorCore.ERR_ItemNotEnoughError;      //道具不足
					reply();
					return;
				}
				if (bagInfo.ItemNum < request.PaiMaiItemInfo.BagInfo.ItemNum)
				{
					response.Error = ErrorCore.ERR_ItemNotEnoughError;      //道具不足
					reply();
					return;
				}
				//发送对应拍卖行信息
				long paimaiServerId = StartSceneConfigCategory.Instance.GetBySceneName(unit.DomainZone(), Enum.GetName(SceneType.PaiMai)).InstanceId;
				P2M_PaiMaiSellResponse r_GameStatusResponse = (P2M_PaiMaiSellResponse)await ActorMessageSenderComponent.Instance.Call
					(paimaiServerId, new M2P_PaiMaiSellRequest()
					{
						PaiMaiItemInfo = request.PaiMaiItemInfo
					});

				if (r_GameStatusResponse.Error == ErrorCore.ERR_Success)
				{
					//扣除对应道具
					unit.GetComponent<BagComponent>().OnCostItemData(request.PaiMaiItemInfo.BagInfo.BagInfoID, request.PaiMaiItemInfo.BagInfo.ItemNum);
					unit.GetComponent<TaskComponent>().TriggerTaskCountryEvent(TaskCountryTargetType.PaiMaiSell_15, 0, 1);
					response.PaiMaiItemInfo = request.PaiMaiItemInfo;
					Log.Debug(response.PaiMaiItemInfo.PlayerName + "上架道具：" + request.PaiMaiItemInfo.BagInfo.ItemID + "数量" + request.PaiMaiItemInfo.BagInfo.ItemNum + "时间戳:" + currentTime.ToString());
				}
				response.Error = r_GameStatusResponse.Error;
				reply();
				await ETTask.CompletedTask;
			}
		}
	}
}
