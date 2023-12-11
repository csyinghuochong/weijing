using System;

namespace ET
{
    [ActorMessageHandler]
    public class C2M_UnionKeJiLearnHandler : AMActorLocationRpcHandler<Unit, C2M_UnionKeJiLearnRequest, M2C_UnionKeJiLearnResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_UnionKeJiLearnRequest request, M2C_UnionKeJiLearnResponse response, Action reply)
        {
            UserInfoComponent userInfoComponent = unit.GetComponent<UserInfoComponent>();   
            int kejiid = userInfoComponent.UserInfo.UnionKeJiList[request.Position];

            UnionKeJiConfig unionKeJiConfig = UnionKeJiConfigCategory.Instance.Get(kejiid);
            if (unionKeJiConfig.NextID == 0)
            {
                response.Error = ErrorCode.ERR_UnionXiuLianMax;
                reply();
                return;
            }

            BagComponent bagComponent = unit.GetComponent<BagComponent>();
            if (!bagComponent.CheckCostItem( unionKeJiConfig.LearnCost ))
            {
                response.Error = ErrorCode.ERR_ItemNotEnoughError;
                reply();
                return;
            }

            long dbCacheId = DBHelper.GetUnionServerId(unit.DomainZone());
            U2M_UnionKeJiLearnResponse d2GGetUnit = (U2M_UnionKeJiLearnResponse)await ActorMessageSenderComponent.Instance.Call(dbCacheId, new M2U_UnionKeJiLearnRequest()
            {
               KeJiId = unionKeJiConfig.NextID
            });

            if(d2GGetUnit.Error != ErrorCode.ERR_Success) 
            {
                response.Error = d2GGetUnit.Error;
                reply();
                return;
            }

            bagComponent.OnCostItemData(unionKeJiConfig.LearnCost);
            userInfoComponent.UserInfo.UnionKeJiList[request.Position] = unionKeJiConfig.NextID;
            response.UnionKeJiList = userInfoComponent.UserInfo.UnionKeJiList;
            reply();
            await ETTask.CompletedTask;
        }
    }
}
