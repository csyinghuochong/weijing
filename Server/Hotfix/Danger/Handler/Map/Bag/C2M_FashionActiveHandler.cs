using System;

namespace ET
{

    [ActorMessageHandler]
    public class C2M_FashionActiveHandler : AMActorLocationRpcHandler<Unit, C2M_FashionActiveRequest, M2C_FashionActiveResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_FashionActiveRequest request, M2C_FashionActiveResponse response, Action reply)
        {
            if (request.FashionId == 0 || !FashionConfigCategory.Instance.Contain(request.FashionId))
            {
                response.Error = ErrorCore.ERR_ModifyData;
                reply();
                return;
            }

            BagComponent bagComponent = unit.GetComponent<BagComponent>();
            if (bagComponent.FashionActiveIds.Contains(request.FashionId))
            {
                response.Error = ErrorCore.ERR_AlreadyLearn;
                reply();
                return;
            }

            FashionConfig fashionConfig = FashionConfigCategory.Instance.Get(request.FashionId  );
            if (!bagComponent.CheckCostItem(fashionConfig.ActiveCost))
            {
                response.Error = ErrorCore.ERR_HouBiNotEnough;
                reply();
                return;
            }

            bagComponent.OnCostItemData(fashionConfig.ActiveCost);
            bagComponent.FashionActiveIds.Add( request.FashionId );

            reply();
            await ETTask.CompletedTask;
        }
    }
}
