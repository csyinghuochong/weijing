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

                List<int> reward = dBPopularizeInfo.MyPopularizeList[i].Rewards;
                int Level = userInfoComponent.UserInfo.Lv;
                //计算出奖励
            }
           
            reply();
            await ETTask.CompletedTask;
        }
    }
}
