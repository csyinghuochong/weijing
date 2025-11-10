using System;
using System.Collections.Generic;
using System.Linq;

namespace ET
{
    [ActorMessageHandler]
    public class C2M_MagickaZhuruHandler : AMActorLocationRpcHandler<Unit, C2M_MagickaZhuruRequest, M2C_MagickaZhuruResponse>
    {

        protected override async ETTask Run(Unit unit, C2M_MagickaZhuruRequest request, M2C_MagickaZhuruResponse response, Action reply)
        {
            ChengJiuComponent chengJiuComponent = unit.GetComponent<ChengJiuComponent>();
            int nexid = chengJiuComponent.GetNextMagickaSlotIdByPosition(request.Position);
            int curid = chengJiuComponent.GetCurrentMagickaSlotIdByPosition(request.Position);
            if (nexid <= curid)
            {
                response.Error = ErrorCode.ERR_MagicMaxLevel;
                reply();
                return;
            }

            BagComponent bagComponent = unit.GetComponent<BagComponent>();
            int addExp = 0;
            List<long> bagidList = new List<long>();

            for (int i = 0; i < request.OperateBagID.Count; i++)
            {
                BagInfo bagInfo = bagComponent.GetItemByLoc(ItemLocType.ItemLocBag, request.OperateBagID[i]);
                if (bagInfo == null)
                {
                    continue;
                }
                if (!ConfigHelper.MagicAddShieldExp.ContainsKey(bagInfo.ItemID))
                {
                    continue;
                }

                int addValue = ConfigHelper.MagicAddShieldExp[bagInfo.ItemID];
                if (addValue > 10)
                {
                    addValue = RandomHelper.NextInt((int)(addValue * 0.8f), (int)(addValue * 1.2f));
                }
                addExp += addValue * bagInfo.ItemNum;
                bagidList.Add(request.OperateBagID[i]);
                response.AddExp = addExp;
            }

            chengJiuComponent.OnAddMagickaExpByPosition( request.Position, addExp);

            //扣除装备
            bagComponent.OnCostItemData(bagidList, ItemLocType.ItemLocBag);

            Function_Fight.GetInstance().UnitUpdateProperty_Base(unit, true, true);

            response.MagickaSlotIds = chengJiuComponent.MagickaSlotIdList;

            reply();
            await ETTask.CompletedTask;
        }
    }
}
