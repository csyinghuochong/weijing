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
            int costNumber = 0;
            List<long> bagidList = new List<long>();
            List<long> petHexins = new List<long>();
            List<BagInfo> bagInfoList = new List<BagInfo>();    
            for (int i = 0; i < request.OperateBagID.Count; i++)
            {
                BagInfo bagInfo = bagComponent.GetItemByLoc(ItemLocType.ItemLocBag, request.OperateBagID[i]);
                if (bagInfo != null)
                {
                    costNumber += bagInfo.ItemNum;
                    bagidList.Add(request.OperateBagID[i]);
                    bagInfoList.Add(bagInfo);
                    continue;
                }
                bagInfo = bagComponent.GetItemByLoc(ItemLocType.ItemPetHeXinBag, request.OperateBagID[i]);
                if (bagInfo != null)
                {
                    costNumber += bagInfo.ItemNum;
                    petHexins.Add(request.OperateBagID[i]);
                    bagInfoList.Add(bagInfo);
                    continue;
                }
            }

            SkillSetComponent skillsetComponent = unit.GetComponent<SkillSetComponent>();
            int addExp = costNumber * 10;

            //其他盾的等级要大于生命之盾
            if (request.OperateType == 6)
            {
                reply();
                return;
            }

            skillsetComponent.OnShieldAddExp(request.OperateType, addExp);

            //扣除装备
            bagComponent.OnCostItemData(petHexins, ItemLocType.ItemPetHeXinBag);
            bagComponent.OnCostItemData(bagidList, ItemLocType.ItemLocBag);

            response.ShieldList = skillsetComponent.LifeShieldList;
            reply();
            await ETTask.CompletedTask;
        }
    }
}
