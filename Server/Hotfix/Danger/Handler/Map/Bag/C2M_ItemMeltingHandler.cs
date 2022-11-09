using System;
using System.Collections.Generic;
using System.Linq;


namespace ET
{

    [ActorMessageHandler]
    public class C2M_ItemMeltingHandler : AMActorLocationRpcHandler<Unit, C2M_ItemMeltingRequest, M2C_ItemMeltingResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_ItemMeltingRequest request, M2C_ItemMeltingResponse response, Action reply)
        {
            //通过回收列表计算所得
            int getItemId = ComHelp.MeltingItemId;
            int getNumber = 1;

            List<long> huishouIdList = request.OperateBagID;
            BagComponent bagComponent = unit.GetComponent<BagComponent>();
            for (int i = 0; i < huishouIdList.Count; i++)
            {
                BagInfo bagInfo = bagComponent.GetItemByLoc(ItemLocType.ItemLocBag, huishouIdList[i]);
                if (bagInfo == null)
                {
                    Log.Info("C2M_ItemMelting无效的物品ID: " + huishouIdList[i]);
                    continue;
                }
                
                //to do
            }

            //扣除装备
            bagComponent.OnCostItemData(huishouIdList);

            bagComponent.OnAddItemData($"{getItemId};{getNumber}", $"{ItemGetWay.Melting}_{TimeHelper.ServerNow()}");
            reply();
            await ETTask.CompletedTask;

            await ETTask.CompletedTask;
        }
    }
}
