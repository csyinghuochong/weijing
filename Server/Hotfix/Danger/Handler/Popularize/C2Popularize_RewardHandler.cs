using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{

    [ActorMessageHandler]
    public class C2Popularize_RewardHandler : AMActorRpcHandler<Scene, C2Popularize_RewardRequest, Popularize2C_RewardResponse>
    {
        protected override async ETTask Run(Scene scene, C2Popularize_RewardRequest request, Popularize2C_RewardResponse response, Action reply)
        {
            DBPopularizeInfo dBPopularizeInfo = await DBHelper.GetComponentCache<DBPopularizeInfo>(scene.DomainZone(), request.ActorId);
            if (dBPopularizeInfo == null)
            {
                reply();
                return;
            }

            for (int i = 0; i < dBPopularizeInfo.MyPopularizeList.Count; i++)
            {
                long unitid = dBPopularizeInfo.MyPopularizeList[i].UnitId;
                int oldZone = UnitIdStruct.GetUnitZone(unitid);
                int newZone = ServerHelper.GetNewServerId(false, oldZone);
                UserInfoComponent userInfoComponent = await DBHelper.GetComponentCache<UserInfoComponent>(newZone, unitid);
                if (userInfoComponent == null)
                {
                    continue;
                }
                dBPopularizeInfo.MyPopularizeList[i].Nmae = userInfoComponent.UserInfo.Name;
                dBPopularizeInfo.MyPopularizeList[i].Level = userInfoComponent.UserInfo.Lv;
                dBPopularizeInfo.MyPopularizeList[i].Occ = userInfoComponent.UserInfo.Occ;
                dBPopularizeInfo.MyPopularizeList[i].OccTwo = userInfoComponent.UserInfo.OccTwo;
            }
            List<RewardItem> rewardItems = PopularizeHelper.GetRewardList(dBPopularizeInfo.MyPopularizeList);
            Popularize2M_RewardRequest  rewardRequest = new Popularize2M_RewardRequest() { ReardList = rewardItems };
            M2Popularize_RewardResponse reqEnter = (M2Popularize_RewardResponse)await ActorLocationSenderComponent.Instance.Call(request.ActorId, rewardRequest);
            //(M2Popularize_RewardResponse)await MessageHelper.CallLocationActor(request.ActorId, rewardRequest);
            if (reqEnter.Error == ErrorCore.ERR_Success)
            {
                await DBHelper.SaveComponent(scene.DomainZone(), request.ActorId, dBPopularizeInfo);
            }

            reply();
            await ETTask.CompletedTask;
        }
    }
}
