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

			if (bagComponent.QiangHuaLevel.Count == 0)
			{
				for (int i = 0; i < 13; i++)
				{
					bagComponent.QiangHuaLevel.Add(0);
				}
			}
			if (bagComponent.QiangHuaFails.Count == 0)
			{
				for (int i = 0; i < 13; i++)
				{
					bagComponent.QiangHuaFails.Add(0);
				}
			}
			//初始化
			for (int i = 0; i < bagInfos.Count; i++)
			{
				if (string.IsNullOrEmpty(bagInfos[i].GemIDNew))
				{
					bagInfos[i].GemIDNew = "0_0_0_0";
				}
				if (string.IsNullOrEmpty(bagInfos[i].GemHole))
				{
					bagInfos[i].GemHole = "0_0_0_0";
				}
			}

			response.BagInfos = bagInfos;
			response.QiangHuaLevel = bagComponent.QiangHuaLevel;
			response.QiangHuaFails = bagComponent.QiangHuaFails;
			reply();
			await ETTask.CompletedTask;
		}
	}
}