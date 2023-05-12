using System;
using System.Collections.Generic;

namespace ET
{
    [ActorMessageHandler]
    public class C2U_UnionRaceInfoHandler : AMActorRpcHandler<Scene, C2U_UnionRaceInfoRequest, U2C_UnionRaceInfoResponse>
    {
        protected override async ETTask Run(Scene scene, C2U_UnionRaceInfoRequest request, U2C_UnionRaceInfoResponse response, Action reply)
        {
            UnionSceneComponent unionSceneComponent = scene.GetComponent<UnionSceneComponent>();


            response.TotalDonation = 2000000 + (int)(unionSceneComponent.DBUnionManager.TotalDonation * 0.5f);

            for (int i = 0; i < unionSceneComponent.DBUnionManager.SignupUnions.Count; i++)
            {
                List<DBUnionInfo> result = await Game.Scene.GetComponent<DBComponent>().Query<DBUnionInfo>(scene.DomainZone(), _account => _account.UnionInfo.UnionId == unionSceneComponent.DBUnionManager.SignupUnions[i]);
                if (result.Count == 0)
                {
                    continue;
                }
                DBUnionInfo dBUnionInfo = result[0];
                UnionListItem unionListItem = new UnionListItem();
                unionListItem.UnionName = dBUnionInfo.UnionInfo.UnionName;
                unionListItem.PlayerNumber = dBUnionInfo.UnionInfo.UnionPlayerList.Count;
                unionListItem.UnionId = dBUnionInfo.UnionInfo.UnionId;
                response.UnionInfoList.Add(unionListItem);
            }

            reply();
            await ETTask.CompletedTask;
        }
    }
}
