using System;
using System.Collections.Generic;
using System.Linq;

namespace ET
{
    [ActorMessageHandler]
    public class C2M_SeasonUseFruitHandler : AMActorLocationRpcHandler<Unit, C2M_SeasonUseFruitRequest, M2C_SeasonUseFruitResponse>
    {

        protected override async ETTask Run(Unit unit, C2M_SeasonUseFruitRequest request, M2C_SeasonUseFruitResponse response, Action reply)
        {
            long reduceTime = 0;
            List<long> huishouList = request.BagInfoIDs;
            BagComponent bagComponent = unit.GetComponent<BagComponent>();

            for (int i = 0; i < huishouList.Count; i++)
            {
                BagInfo bagInfo = bagComponent.GetItemByLoc(ItemLocType.ItemLocBag, huishouList[i]);
                if (bagInfo == null)
                {
                    continue;
                }

                ItemConfig itemConfig = ItemConfigCategory.Instance.Get( bagInfo.ItemID );
                if (itemConfig.ItemType != ItemTypeEnum.Consume ||  itemConfig.ItemSubType != 132 )
                {
                    continue;
                }

                reduceTime += long.Parse(itemConfig.ItemUsePar);
            }
            
            bagComponent.OnCostItemData(request.BagInfoIDs, ItemLocType.ItemLocBag);
            unit.GetComponent<NumericComponent>().ApplyChange( null, NumericType.SeasonBossRefreshTime, -1 * reduceTime, 0 );

            reply();
            await ETTask.CompletedTask;
        }
    }
}
