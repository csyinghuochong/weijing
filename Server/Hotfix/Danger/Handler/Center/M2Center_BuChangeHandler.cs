using System;
using System.Collections.Generic;


namespace ET
{

    [ActorMessageHandler]
    public class M2Center_BuChangeHandler : AMActorRpcHandler<Scene, M2Center_BuChangeRequest, Center2M_BuChangeResponse>
    {

        protected override async ETTask Run(Scene scene, M2Center_BuChangeRequest request, Center2M_BuChangeResponse response, Action reply)
        {
            List<DBCenterAccountInfo> centerAccountInfoList = await Game.Scene.GetComponent<DBComponent>().Query<DBCenterAccountInfo>(scene.DomainZone(), d => d.Id == request.AccountId);
            PlayerInfo playerInfo = centerAccountInfoList[0].PlayerInfo;
            for (int i = 0; i < playerInfo.RechargeInfos.Count; i++)
            {
                if (playerInfo.RechargeInfos[i].UserId == request.BuChangId)
                {
                    playerInfo.RechargeInfos[i].UserId = request.UserId;
                }
            }
            playerInfo.DeleteUserList.Clear();
            Game.Scene.GetComponent<DBComponent>().Save<DBCenterAccountInfo>(scene.DomainZone(), centerAccountInfoList[0]).Coroutine();

            response.RechargeInfos = playerInfo.RechargeInfos;
            reply();
            await ETTask.CompletedTask;
        }
    }
}
