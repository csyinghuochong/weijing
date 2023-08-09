using System;


namespace ET
{

    [ActorMessageHandler]
    public class C2M_FashionWearHandler : AMActorLocationRpcHandler<Unit, C2M_FashionWearRequest, M2C_FashionWearResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_FashionWearRequest request, M2C_FashionWearResponse response, Action reply)
        {
            BagComponent bagComponent = unit.GetComponent<BagComponent>();
            if (!bagComponent.FashionActiveIds.Contains(request.FashionId))
            {
                response.Error = ErrorCore.ERR_ModifyData;
                reply();
                return;
            }

            int occ = unit.GetComponent<UserInfoComponent>().UserInfo.Occ;
            FashionConfig fashionConfig = FashionConfigCategory.Instance.Get(request.FashionId);

            bool canwear = false;
            for (int i = 0; i < fashionConfig.Occ.Length; i++)
            {
                if (fashionConfig.Occ[i] == occ)
                {
                    canwear = true;
                    break;
                }
            }

            if (!canwear)
            {
                response.Error = ErrorCore.ERR_ModifyData;
                reply();
                return;
            }

            if (request.OperatateType == 1)
            {
                if (bagComponent.FashionEquipList.Contains(request.FashionId))
                {
                    response.Error = ErrorCore.ERR_AlreadyLearn;
                    reply();
                    return;
                }
                bagComponent.FashionEquipList.Add(request.FashionId);
            }
            else
            {
                if (!bagComponent.FashionEquipList.Contains(request.FashionId))
                {
                    response.Error = ErrorCore.ERR_NetWorkError;
                    reply();
                    return;
                }
                bagComponent.FashionEquipList.Remove(request.FashionId);
            }
            

            M2C_FashionUpdate m2C_FashionUpdate = new M2C_FashionUpdate();
            m2C_FashionUpdate.UnitID = unit.Id;
            m2C_FashionUpdate.FashionEquipList = bagComponent.FashionEquipList;
            MessageHelper.Broadcast(unit, m2C_FashionUpdate);

            reply();
            await ETTask.CompletedTask;
        }
    }
}
