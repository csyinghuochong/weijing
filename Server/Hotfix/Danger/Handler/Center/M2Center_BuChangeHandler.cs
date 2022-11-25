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

            //指定某个角色
            if (request.BuChangId > 0)
            {
                for (int i = 0; i < playerInfo.RechargeInfos.Count; i++)
                {
                    RechargeInfo rechargeInfo = playerInfo.RechargeInfos[i];
                    if (rechargeInfo.UserId == request.BuChangId)
                    {
                        response.BuChangRecharge += rechargeInfo.Amount;
                        response.BuChangDiamond += ComHelp.GetDiamondNumber(rechargeInfo.Amount);
                    }
                }
                playerInfo.DeleteUserList.Clear();
            }
            else
            {
                KeyValuePairInt keyValuePairInt = BuChangHelper.GetBuChangRecharge(playerInfo);
                response.BuChangRecharge = keyValuePairInt.KeyId;
                response.BuChangDiamond = (int)keyValuePairInt.Value;
                playerInfo.BuChangZone.Add(UnitIdStruct.GetUnitZone(request.UserId));
            }

            Game.Scene.GetComponent<DBComponent>().Save<DBCenterAccountInfo>(scene.DomainZone(), centerAccountInfoList[0]).Coroutine();
            response.PlayerInfo = playerInfo;
            reply();
            await ETTask.CompletedTask;
        }
    }
}
