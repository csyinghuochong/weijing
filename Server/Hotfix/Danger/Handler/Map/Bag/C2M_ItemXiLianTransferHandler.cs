using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{

    [ActorMessageHandler]
    public class C2M_ItemXiLianTransferHandler : AMActorLocationRpcHandler<Unit, C2M_ItemXiLianTransferRequest, M2C_ItemXiLianTransferResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_ItemXiLianTransferRequest request, M2C_ItemXiLianTransferResponse response, Action reply)
        {
            BagInfo bagInfo_1 = unit.GetComponent<BagComponent>().GetItemByLoc(ItemLocType.ItemLocBag, request.OperateBagID_1);
            BagInfo bagInfo_2 = unit.GetComponent<BagComponent>().GetItemByLoc(ItemLocType.ItemLocBag, request.OperateBagID_2);
            if (bagInfo_1 == null || bagInfo_2 == null)
            {
                reply();
                return;
            }
            string costItem = GlobalValueConfigCategory.Instance.Get(51).Value;
            if (!unit.GetComponent<BagComponent>().OnCostItemData(costItem))
            {
                response.Error = ErrorCore.ERR_ItemNotEnoughError;
                reply();
                return;
            }

            bagInfo_2.XiLianHideTeShuProLists.Clear();
            bagInfo_2.XiLianHideProLists.Clear();
            bagInfo_2.HideSkillLists.Clear();
            bagInfo_2.XiLianHideTeShuProLists.AddRange( bagInfo_1.XiLianHideTeShuProLists);
            bagInfo_2.XiLianHideProLists.AddRange(bagInfo_1.XiLianHideProLists);
            bagInfo_2.HideSkillLists.AddRange(bagInfo_1.HideSkillLists);

            bagInfo_1.XiLianHideTeShuProLists.Clear();
            bagInfo_1.XiLianHideProLists.Clear();
            bagInfo_1.HideSkillLists.Clear();

            M2C_RoleBagUpdate m2c_bagUpdate = new M2C_RoleBagUpdate();
            //通知客户端背包道具发生改变
            m2c_bagUpdate.BagInfoUpdate = new List<BagInfo>();
            m2c_bagUpdate.BagInfoUpdate.Add(bagInfo_1);
            m2c_bagUpdate.BagInfoUpdate.Add(bagInfo_2);
            MessageHelper.SendToClient(unit, m2c_bagUpdate);

            reply();
            await ETTask.CompletedTask;
        }
    }
}
