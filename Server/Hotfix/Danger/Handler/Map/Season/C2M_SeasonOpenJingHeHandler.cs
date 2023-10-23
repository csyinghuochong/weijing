using System;


namespace ET
{
    [ActorMessageHandler]
    public class C2M_SeasonOpenJingHeHandler : AMActorLocationRpcHandler<Unit, C2M_SeasonOpenJingHeRequest, M2C_SeasonOpenJingHeResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_SeasonOpenJingHeRequest request, M2C_SeasonOpenJingHeResponse response, Action reply)
        {
            UserInfoComponent userInfoComponent = unit.GetComponent<UserInfoComponent>();   
            if (userInfoComponent.UserInfo.OpenJingHeIds.Contains(request.JingHeId))
            {
                response.Error = ErrorCode.ERR_AlreadyLearn;
                reply();
                return;
            }

            if (!SeasonJingHeConfigCategory.Instance.Contain(request.JingHeId))
            {
                response.Error = ErrorCode.ERR_ModifyData;
                reply();
                return;
            }

            SeasonJingHeConfig seasonJingHeConfig = SeasonJingHeConfigCategory.Instance.Get(request.JingHeId);
            BagComponent bagComponent = unit.GetComponent<BagComponent>();  
            if (!bagComponent.CheckCostItem(seasonJingHeConfig.Cost))
            {
                response.Error = ErrorCode.ERR_ItemNotEnoughError;
                reply();
                return;
            }

            bagComponent.OnCostItemData(seasonJingHeConfig.Cost);
            userInfoComponent.UserInfo.OpenJingHeIds.Add(request.JingHeId);

            reply();
            await ETTask.CompletedTask;
        }
    }
}
