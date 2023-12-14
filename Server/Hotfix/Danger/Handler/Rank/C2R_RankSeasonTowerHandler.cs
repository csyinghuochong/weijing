using System;
using System.Collections.Generic;

namespace ET
{
    [ActorMessageHandler]
    public class C2R_RankSeasonTowerHandler : AMActorRpcHandler<Scene, C2R_RankSeasonTowerRequest, R2C_RankSeasonTowerResponse>
    {
        protected override async ETTask Run(Scene scene, C2R_RankSeasonTowerRequest request, R2C_RankSeasonTowerResponse response, Action reply)
        {
            long timeNow = TimeHelper.ServerNow();
            RankSceneComponent rankComponent = scene.GetComponent<RankSceneComponent>();

            if (timeNow - rankComponent.RankSeasonTowerLastTime < TimeHelper.Minute)
            {
                response.RankList = rankComponent.RankSeasonTowers;
            }
            else
            {
                long dbCacheId = DBHelper.GetDbCacheId(scene.DomainZone());
                List<KeyValuePairLong> ranklist = rankComponent.DBRankInfo.rankSeasonTower;

                List<long> idlist = new List<long>();
                List<long> idremove = new List<long>();

                for (int i = 0; i < ranklist.Count; i++)
                {
                    if (idlist.Contains(ranklist[i].KeyId))
                    {
                        idremove.Add(ranklist[i].KeyId);
                        continue;
                    }

                    idlist.Add(ranklist[i].KeyId);
                    D2G_GetComponent d2GGetUnit = (D2G_GetComponent)await ActorMessageSenderComponent.Instance.Call(dbCacheId, new G2D_GetComponent() { UnitId = ranklist[i].KeyId, Component = DBHelper.UserInfoComponent });
                    if (d2GGetUnit.Component == null)
                    {
                        continue;
                    }
                    UserInfoComponent userinfoComponent = (d2GGetUnit.Component as UserInfoComponent);
                    response.RankList.Add(new RankSeasonTowerInfo()
                    {
                        UserId = ranklist[i].KeyId,
                        TotalTime = ranklist[i].Value,        //时间
                        FubenId = (int)(ranklist[i].Value2),  //副本
                        PlayerLv = userinfoComponent.UserInfo.Lv,
                        PlayerName = userinfoComponent.UserInfo.Name,
                        Occ = userinfoComponent.UserInfo.Occ,
                    });
                }
                rankComponent.RankSeasonTowerLastTime = TimeHelper.ServerNow();
                rankComponent.RankSeasonTowers = response.RankList;

                for (int remove = 0; remove < idremove.Count; remove++)
                {
                    for (int i = ranklist.Count - 1; i >= 0; i--)
                    {
                        if (ranklist[i].KeyId == idremove[remove])
                        {
                            ranklist.RemoveAt(i);
                            break;
                        }
                    }
                }
            }

            reply();
            await ETTask.CompletedTask;
        }
    }
}
