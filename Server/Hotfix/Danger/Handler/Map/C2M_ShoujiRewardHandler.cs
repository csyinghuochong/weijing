using System;

namespace ET
{
    [ActorMessageHandler]
    public class C2M_ShoujiRewardHandler : AMActorLocationRpcHandler<Unit, C2M_ShoujiRewardRequest, M2C_ShoujiRewardResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_ShoujiRewardRequest request, M2C_ShoujiRewardResponse response, Action reply)
        {
            ShoujiComponent shoujiComponent = unit.GetComponent<ShoujiComponent>();
            ShouJiChapterInfo shouJiChapterInfo = shoujiComponent.GetShouJiChapterInfo(request.ChapterId);
            ShouJiConfig shouJiConfig = ShouJiConfigCategory.Instance.Get(request.ChapterId);

            if (request.RewardIndex == 1 && shouJiChapterInfo.StarNum < shouJiConfig.ProList1_StartNum)
            {
                reply();
                return;
            }
            if (request.RewardIndex == 2 && shouJiChapterInfo.StarNum < shouJiConfig.ProList2_StartNum)
            {
                reply();
                return;
            }
            if (request.RewardIndex == 3 && shouJiChapterInfo.StarNum < shouJiConfig.ProList3_StartNum)
            {
                reply();
                return;
            }
            if ((shouJiChapterInfo.RewardInfo & 1 << request.RewardIndex) > 0)
            {
                reply();
                return;
            }

            string rewards = "";
            if (request.RewardIndex == 3) rewards = shouJiConfig.RewardList_3;
            if (request.RewardIndex == 2) rewards = shouJiConfig.RewardList_2;
            if (request.RewardIndex == 1) rewards = shouJiConfig.RewardList_1;
            if (!unit.GetComponent<BagComponent>().OnAddItemData(rewards))
            {
                reply();
                return;
            }
            shouJiChapterInfo.RewardInfo |= (1 << request.RewardIndex);
            reply();
            await ETTask.CompletedTask;
        }

    }
}
