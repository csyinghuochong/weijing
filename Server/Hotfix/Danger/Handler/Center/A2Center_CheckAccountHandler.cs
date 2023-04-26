using System;
using System.Collections.Generic;

namespace ET
{

    [ActorMessageHandler]
    public class A2Center_CheckAccountHandler : AMActorRpcHandler<Scene, A2Center_CheckAccount, Center2A_CheckAccount>
    {
        protected override async ETTask Run(Scene scene, A2Center_CheckAccount request, Center2A_CheckAccount response, Action reply)
        {
            List<DBCenterAccountInfo> centerAccountInfoList = await Game.Scene.GetComponent<DBComponent>().Query<DBCenterAccountInfo>(scene.DomainZone(), d => d.Account == request.AccountName && d.Password == request.Password); ;

            //绑定手机号的账号
            if (centerAccountInfoList.Count == 0 && request.ThirdLogin == "3") 
            {
                centerAccountInfoList = await Game.Scene.GetComponent<DBComponent>().Query<DBCenterAccountInfo>(scene.DomainZone(),
                   _account => _account.PlayerInfo != null && _account.PlayerInfo.PhoneNumber.Equals(request.AccountName));
            }

            DBCenterAccountInfo dBCenterAccountInfo = centerAccountInfoList != null && centerAccountInfoList.Count > 0 ? centerAccountInfoList[0] : null;
            response.PlayerInfo = dBCenterAccountInfo !=null ? dBCenterAccountInfo.PlayerInfo : null;
            response.AccountId = dBCenterAccountInfo != null ? dBCenterAccountInfo.Id : 0;
            if (dBCenterAccountInfo!=null &&dBCenterAccountInfo.AccountType == (int)AccountType.Delete)
            {
                response.PlayerInfo = null;
            }
            if (response.PlayerInfo != null)
            {
                for (int i = 0; i < response.PlayerInfo.RechargeInfos.Count; i++)
                {
                    response.PlayerInfo.RechargeInfos[i].OrderInfo = string.Empty;
                }
            }
            response.IsHoliday = scene.GetComponent<FangChenMiComponent>().IsHoliday;
            response.StopServer = scene.GetComponent<FangChenMiComponent>().StopServer;
            reply();
            await ETTask.CompletedTask;
        }
    }
}
