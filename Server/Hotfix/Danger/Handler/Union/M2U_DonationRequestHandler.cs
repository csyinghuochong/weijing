using System;

namespace ET
{

    [ActorMessageHandler]
    public class M2U_DonationRequestHandler : AMActorRpcHandler<Scene, M2U_DonationRequest, U2M_DonationResponse>
    {
        protected override async ETTask Run(Scene scene, M2U_DonationRequest request, U2M_DonationResponse response, Action reply)
        {
            Log.Console("M2U_DonationRequestHandler");
            UnionSceneComponent rankSceneComponent = scene.GetComponent<UnionSceneComponent>();
            DBUnionManager dBRankInfo = rankSceneComponent.DBUnionManager;
            dBRankInfo.TotalDonation += (long)(0.5f * request.RankingInfo.Combat);

            int oldrank = -1;
            int newrank = -1;
            ListComponent<long> userlist = new ListComponent<long>();   
            for (int i = dBRankInfo.rankingDonation.Count - 1; i >= 0; i--)
            {
                RankingInfo rankingInfoTemp = dBRankInfo.rankingDonation[i];
                if (rankingInfoTemp.UserId == 0)
                {
                    dBRankInfo.rankingDonation.RemoveAt(i);
                    continue;
                }

                if (rankingInfoTemp.UserId == request.RankingInfo.UserId)
                {
                    rankingInfoTemp.Combat += request.RankingInfo.Combat;
                    oldrank = i;
                }
                if (userlist.Count < 10)
                {
                    userlist.Add(rankingInfoTemp.UserId);
                }
            }
            if (oldrank == -1)
            {
                dBRankInfo.rankingDonation.Add(request.RankingInfo);
            }
            dBRankInfo.rankingDonation.Sort(delegate (RankingInfo a, RankingInfo b)
            {
                return (int)b.Combat - (int)a.Combat;
            });
            newrank = rankSceneComponent.GetDonationRank(request.RankingInfo.UserId);

            //前五名排名有变化则通知
            if (oldrank != newrank && (oldrank < 10 || newrank < 10))
            {
                int number = Math.Min(dBRankInfo.rankingDonation.Count, 10);
                for (int i = 0; i < number;i++)
                {
                    if (userlist.Count < 10 && !userlist.Contains(dBRankInfo.rankingDonation[i].UserId))
                    {
                        userlist.Add(dBRankInfo.rankingDonation[i].UserId);
                    }
                }

                long gateServerId = StartSceneConfigCategory.Instance.GetBySceneName(scene.DomainZone(), "Gate1").InstanceId;
                for (int i = 0; i < userlist.Count; i++)
                {
                    G2T_GateUnitInfoResponse g2M_UpdateUnitResponse = (G2T_GateUnitInfoResponse)await ActorMessageSenderComponent.Instance.Call
                        (gateServerId, new T2G_GateUnitInfoRequest()
                        {
                            UserID = userlist[i]
                        });
                   
                    if (g2M_UpdateUnitResponse.PlayerState == (int)PlayerState.Game && g2M_UpdateUnitResponse.SessionInstanceId > 0)
                    {
                        R2M_RankUpdateMessage r2M_RankUpdateMessage = new R2M_RankUpdateMessage();
                        r2M_RankUpdateMessage.RankType = 3;
                        r2M_RankUpdateMessage.RankId = rankSceneComponent.GetDonationRank(userlist[i]);
                        MessageHelper.SendToLocationActor(userlist[i], r2M_RankUpdateMessage);
                    }
                }
            }

            response.RankId = newrank;
            reply();
            await ETTask.CompletedTask;
        }
    }
}
