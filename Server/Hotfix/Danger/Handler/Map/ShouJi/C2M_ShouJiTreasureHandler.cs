using System;
using System.Collections.Generic;
using System.Linq;

namespace ET
{
    [ActorMessageHandler]
    public class C2M_ShouJiTreasureHandler : AMActorLocationRpcHandler<Unit, C2M_ShouJiTreasureRequest, M2C_ShouJiTreasureResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_ShouJiTreasureRequest request, M2C_ShouJiTreasureResponse response, Action reply)
        {
            ShoujiComponent shoujiComponent = unit.GetComponent<ShoujiComponent>();
            KeyValuePairInt keyValuePairInt = shoujiComponent.GetTreasureInfo(request.ShouJiId);
            ShouJiItemConfig shouJiItemConfig = ShouJiItemConfigCategory.Instance.Get(request.ShouJiId);
            if (keyValuePairInt != null && keyValuePairInt.Value > shouJiItemConfig.AcitveNum)
            {
                response.Error = ErrorCore.ERR_ShouJIActived;
                reply();
                return;
            }

            List<long> huishouList = request.ItemIds;
            BagComponent bagComponent = unit.GetComponent<BagComponent>();
            for (int i = 0; i < huishouList.Count; i++)
            {
                BagInfo bagInfo = bagComponent.GetItemByLoc(ItemLocType.ItemLocBag, huishouList[i]);
                if (bagInfo == null)
                {
                    response.Error = ErrorCore.ERR_ItemUseError;
                    reply();
                    return;
                }
            }

            int curNumber   = keyValuePairInt!=null ? (int)keyValuePairInt.Value : 0;  
            int needNumber  = shouJiItemConfig.AcitveNum - curNumber;
            
            for (int i = 0; i < huishouList.Count; i++)
            {
                BagInfo bagInfo = bagComponent.GetItemByLoc(ItemLocType.ItemLocBag, huishouList[i]);

                if (needNumber < bagInfo.ItemNum)
                {
                    curNumber += needNumber;
                    bagComponent.OnCostItemData(huishouList[i], needNumber);
                }
                else
                {
                    needNumber -= bagInfo.ItemNum;
                    curNumber += bagInfo.ItemNum;
                    bagComponent.OnCostItemData(huishouList[i], bagInfo.ItemNum);
                }

                if (curNumber >= needNumber)
                {
                    break;
                }
            }
           
            shoujiComponent.OnShouJiTreasure(request.ShouJiId, curNumber);
            response.ActiveNum = curNumber;
            reply();
            await ETTask.CompletedTask;
        }
    }
}
