using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{

    /// <summary>
    /// 放入可以堆叠的道具
    /// </summary>

    [ActorMessageHandler]
    public class C2M_ItemQuickPutHandler : AMActorLocationRpcHandler<Unit, C2M_ItemQuickPutRequest, M2C_ItemQuickPutResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_ItemQuickPutRequest request, M2C_ItemQuickPutResponse response, Action reply)
        {
            int hourseId = request.HorseId;
            if (hourseId < (int)ItemLocType.ItemWareHouse1 || hourseId > (int)ItemLocType.ItemWareHouse4)
            {
                response.Error = ErrorCode.ERR_ModifyData;
                reply();
                return;
            }

            M2C_RoleBagUpdate m2c_bagUpdate = new M2C_RoleBagUpdate();

            BagComponent bagComponent = unit.GetComponent<BagComponent>();  

            List<BagInfo> warehourselist = bagComponent.GetItemByLoc((ItemLocType)hourseId);

            List<BagInfo> bagList = bagComponent.GetItemByLoc(ItemLocType.ItemLocBag);

            for (int w = 0; w < warehourselist.Count; w++)
            {
                BagInfo warehourseInfo = warehourselist[w];

                for (int b = bagList.Count - 1; b >= 0; b-- )
                {
                    BagInfo bagInfo = bagList[b];

                    if (warehourseInfo.ItemID != bagInfo.ItemID)
                    {
                        continue;
                    }

                    ItemConfig itemCof = ItemConfigCategory.Instance.Get(bagInfo.ItemID);
                    if ( (warehourseInfo.ItemNum + bagInfo.ItemNum) > itemCof.ItemPileSum)
                    {
                        continue;
                    }


                    warehourseInfo.ItemNum = warehourseInfo.ItemNum + bagInfo.ItemNum;
                    m2c_bagUpdate.BagInfoUpdate.Add(warehourseInfo);
                    m2c_bagUpdate.BagInfoDelete.Add(bagInfo);
                    bagList.RemoveAt(b);
                }
            }


            MessageHelper.SendToClient(unit, m2c_bagUpdate);
            reply();
            await ETTask.CompletedTask;
        }
    }
}
