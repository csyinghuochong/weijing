using System;
using System.Collections.Generic;

namespace ET
{
    //游戏设置
    [ActorMessageHandler]
    public class C2M_GameSettingHandler : AMActorLocationRpcHandler<Unit, C2M_GameSettingRequest, M2C_GameSettingResponse>
    {
		protected override async ETTask Run(Unit unit, C2M_GameSettingRequest request, M2C_GameSettingResponse response, Action reply)
		{
			//读取数据库
			UserInfo userInfo = unit.GetComponent<UserInfoComponent>().GetUserInfo();

			for (int i = 0; i < request.GameSettingInfos.Count; i++)
			{
				bool exist = false;

				if (request.GameSettingInfos[i].KeyId == (int)GameSettingEnum.AttackMode)
				{
					unit.GetComponent<NumericComponent>().ApplyValue(NumericType.AttackMode, int.Parse(request.GameSettingInfos[i].Value));
				}

				for (int k = 0; k < userInfo.GameSettingInfos.Count; k++)
				{
					if (userInfo.GameSettingInfos[k].KeyId == request.GameSettingInfos[i].KeyId)
					{
						exist = true;
						userInfo.GameSettingInfos[k].Value = request.GameSettingInfos[i].Value;
						break;
					}
				}
				if (!exist)
				{
					userInfo.GameSettingInfos.Add(request.GameSettingInfos[i]);
				}
			}
			reply();
			await ETTask.CompletedTask;
		}
	}
}
