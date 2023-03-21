using System;
using System.Collections.Generic;

namespace ET
{
	//游戏背包
	[ActorMessageHandler]
	public class Actor_ItemInitHandler : AMActorLocationRpcHandler<Unit, Actor_ItemInitRequest, Actor_ItemInitResponse>
	{
		protected override async ETTask Run(Unit unit, Actor_ItemInitRequest request, Actor_ItemInitResponse response, Action reply)
		{
			BagComponent bagComponent = unit.GetComponent<BagComponent>();

			//读取数据库
			List<BagInfo> bagInfos = bagComponent.GetAllItems();

			/*
			for (int i = 0; i < bagInfos.Count; i++) {
				Log.Info("道具ID：" + bagInfos[i]  + bagInfos[i].GetWay);
			}
			*/

			if (bagComponent.WarehouseAddedCell.Count == 0)
			{
				for (int i = 0; i < 4; i++)
				{
					bagComponent.WarehouseAddedCell.Add(0);
				}
			}

			if (bagComponent.QiangHuaLevel.Count == 0)
			{
				for (int i = 0; i <= 11; i++)
				{
					bagComponent.QiangHuaLevel.Add(0);
					bagComponent.QiangHuaFails.Add(0);
				}
			}
			else
            {
				for (int i = 0; i <= 11; i++)
				{
					int maxLevel = QiangHuaHelper.GetQiangHuaMaxLevel(i);
					if (bagComponent.QiangHuaLevel[i] >= maxLevel)
					{
						bagComponent.QiangHuaLevel[i] = maxLevel - 1;
					}
				}
			}

			//初始化
			for (int i = 0; i < bagInfos.Count; i++)
			{
				if (bagInfos[i].FumoProLists.Count > 0
					&& bagInfos[i].FumoProLists[0].HideValue > 10000)
				{
					bagInfos[i].FumoProLists.Clear();
				}
				if (string.IsNullOrEmpty(bagInfos[i].GemIDNew))
				{
					bagInfos[i].GemIDNew = "0_0_0_0";
					bagInfos[i].GemHole = "0_0_0_0";
				}

				//鉴定符错误
				//ItemConfig itemConfig = ItemConfigCategory.Instance.Get(bagInfos[i].ItemID);
				//if(itemConfig.ItemSubType == 121)
				//{
				//	try
				//	{
				//		int quality = int.Parse(bagInfos[i].ItemPar);
				//	}
				//	catch (Exception ex)
				//	{
				//		Log.Debug(ex.ToString()+ "_____" + bagInfos[i].ItemPar);
				//	}
				//	bagInfos[i].ItemPar = "99";
				//}
			}

			response.BagInfos = bagInfos;
			response.QiangHuaLevel = bagComponent.QiangHuaLevel;
			response.QiangHuaFails = bagComponent.QiangHuaFails;
			response.BagAddedCell = bagComponent.BagAddedCell;
			response.WarehouseAddedCell = bagComponent.WarehouseAddedCell;

			reply();
			await ETTask.CompletedTask;
		}
	}
}