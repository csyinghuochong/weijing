using System;
using System.Collections.Generic;
using System.Linq;


namespace ET
{

    [ActorMessageHandler]
    public class C2M_LifeShieldCostHandler : AMActorLocationRpcHandler<Unit, C2M_LifeShieldCostRequest, M2C_LifeShieldCostResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_LifeShieldCostRequest request, M2C_LifeShieldCostResponse response, Action reply)
        {
            BagComponent bagComponent = unit.GetComponent<BagComponent>();
            int addExp =  0;
            List<long> bagidList = new List<long>();
        
            for (int i = 0; i < request.OperateBagID.Count; i++)
            {
                BagInfo bagInfo = bagComponent.GetItemByLoc(ItemLocType.ItemLocBag, request.OperateBagID[i]);
                if (bagInfo == null)
                {
                    continue;
                }
                if (!ConfigHelper.ItemAddShieldExp.ContainsKey(bagInfo.ItemID))
                {
                    continue;
                }

                int addValue = ConfigHelper.ItemAddShieldExp[bagInfo.ItemID];
                if (addValue > 10) {
                    addValue = RandomHelper.NextInt((int)(addValue * 0.8f), (int)(addValue * 1.2f));
                }
                addExp += addValue * bagInfo.ItemNum;
                bagidList.Add(request.OperateBagID[i]);
                response.AddExp = addExp;
            }

            SkillSetComponent skillsetComponent = unit.GetComponent<SkillSetComponent>();

            //其他盾的等级要大于生命之盾
            if (request.OperateType == 6)
            {
                reply();
                return;
            }

            skillsetComponent.OnShieldAddExp(request.OperateType, addExp);

            //扣除装备
            bagComponent.OnCostItemData(bagidList, ItemLocType.ItemLocBag);

            Function_Fight.GetInstance().UnitUpdateProperty_Base(unit, true, true);

            response.ShieldList = skillsetComponent.LifeShieldList;
            reply();
            await ETTask.CompletedTask;
        }
    }
}
