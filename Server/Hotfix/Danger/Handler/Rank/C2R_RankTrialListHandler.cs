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


                List<KeyValuePairLong> ranklist = rankComponent.DBRankInfo.rankingTrial;
                //List<KeyValuePairLong> list = all.GetRange(0, all.Count > ComHelp.RankNumber ? ComHelp.RankNumber : all.Count);


                List<long> idlist = new List<long>();
                List<long> idremove = new List<long> (); 

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
                    response.RankList.Add(new RankingTrialInfo()
                    { 
                        UserId = ranklist[i].KeyId,
                        Hurt = ranklist[i].Value,
                        FubenId = (int)(ranklist[i].Value2),
                        PlayerLv = userinfoComponent.UserInfo.Lv,
                        PlayerName = userinfoComponent.UserInfo.Name,   
                        Occ = userinfoComponent.UserInfo.Occ,
                    });
                }
                rankComponent.RankingTrialLastTime = TimeHelper.ServerNow();
                rankComponent.RankingTrials = response.RankList;

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
