using System;

namespace ET
{
    [ActorMessageHandler]
    public class C2M_MagickaSlotOpenHandler : AMActorLocationRpcHandler<Unit, C2M_MagickaSlotOpenRequest, M2C_MagickaSlotOpenResponse>
    {

        protected override async ETTask Run(Unit unit, C2M_MagickaSlotOpenRequest request, M2C_MagickaSlotOpenResponse response, Action reply)
        {
            ChengJiuComponent chengJiuComponent = unit.GetComponent<ChengJiuComponent>();

            int curid = chengJiuComponent.GetCurrentMagickaSlotIdByPosition(request.Position);
            //if (curid > 0)
            //{
            //    response.Error = ErrorCode.ERR_AlreadyOpen;
            //    reply();
            //    return;
            //}

            int nexid = chengJiuComponent.GetNextMagickaSlotIdByPosition(request.Position);
            if (curid == nexid)
            {
                response.Error = ErrorCode.ERR_MagicMaxLevel;
                reply();
                return;
            }
            MagickaSlotConfig magickaSlotConfig = MagickaSlotConfigCategory.Instance.Get(nexid);

            int totallevel = chengJiuComponent.GetCurrentMagickaTotalLevel();
            if (totallevel < magickaSlotConfig.NeedTotalLevel)
            {
                response.Error = ErrorCode.ERR_MagicLevelNotEnough;
                reply();
                return;
            }

            BagComponent bagComponent = unit.GetComponent<BagComponent>();
           
            bool sucesss = bagComponent.OnCostItemData(magickaSlotConfig.OpenCostItem,ItemLocType.ItemLocBag, ItemGetWay.CostItem );
            if (!sucesss)
            {
                response.Error = ErrorCode.ERR_ItemNotEnoughError;
                reply();
                return;
            }

            chengJiuComponent.OnOpenMagicka(request.Position, nexid);
            response.MagickaSlotIds = chengJiuComponent.MagickaSlotIdList;
            reply();
            await ETTask.CompletedTask;
        }
    }
}
