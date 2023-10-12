using System;
using System.Collections.Generic;

namespace ET
{

    [ActorMessageHandler]
    public class C2R_RankTrialListHandler : AMActorRpcHandler<Scene, C2R_RankTrialListRequest, R2C_RankTrialListResponse>
    {

        protected override async ETTask Run(Scene scene, C2R_RankTrialListRequest request, R2C_RankTrialListResponse response, Action reply)
        {
            long timeNow = TimeHelper.ServerNow();
            RankSceneComponent rankComponent = scene.GetComponent<RankSceneComponent>();

            if (timeNow - rankComponent.RankingTrialLastTime < TimeHelper.Minute)
            {
                response.RankList = rankComponent.RankingTrials;
            }
            else
            {
                long dbCacheId = DBHelper.GetDbCacheId(scene.DomainZone());
                List<KeyValuePairLong> all = rankComponent.DBRankInfo.rankingTrials;
                List<KeyValuePairLong> list = all.GetRange(0, all.Count > ComHelp.RankNumber ? ComHelp.RankNumber : all.Count);

                for (int i = 0; i < list.Count; i++)
                {
                    D2G_GetComponent d2GGetUnit = (D2G_GetComponent)await ActorMessageSenderComponent.Instance.Call(dbCacheId, new G2D_GetComponent() { UnitId = list[i].KeyId, Component = DBHelper.UserInfoComponent });
                    if (d2GGetUnit.Component == null)
                    {
                        continue;
                    }
                    UserInfoComponent userinfoComponent = (d2GGetUnit.Component as UserInfoComponent);
                    response.RankList.Add(new RankingInfo()
                    { 
                        UserId = list[i].KeyId,
                        Combat = list[i].Value,
                        PlayerLv = userinfoComponent.UserInfo.Lv,
                        PlayerName = userinfoComponent.UserInfo.Name,   
                        Occ = userinfoComponent.UserInfo.Occ
                    });
                }
            }

            reply();
            await ETTask.CompletedTask;
        }
    }
}
