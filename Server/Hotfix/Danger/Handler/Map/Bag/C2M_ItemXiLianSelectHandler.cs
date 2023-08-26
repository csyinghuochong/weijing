using System;
using System.Collections.Generic;

namespace ET
{
    [ActorMessageHandler]
    public class C2M_ItemXiLianSelectHandler : AMActorLocationRpcHandler<Unit, C2M_ItemXiLianSelectRequest, M2C_ItemXiLianSelectResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_ItemXiLianSelectRequest request, M2C_ItemXiLianSelectResponse response, Action reply)
        {
            BagInfo bagInfo = unit.GetComponent<BagComponent>().GetItemByLoc(ItemLocType.ItemLocBag, request.OperateBagID);
            ItemXiLianResult itemXiLian = request.ItemXiLianResult;
            bagInfo.XiLianHideProLists = itemXiLian.XiLianHideProLists;              //基础属性洗炼
            bagInfo.HideSkillLists = itemXiLian.HideSkillLists;                      //隐藏技能
            bagInfo.XiLianHideTeShuProLists = itemXiLian.XiLianHideTeShuProLists;    //特殊属性洗炼

            M2C_RoleBagUpdate m2c_bagUpdate = new M2C_RoleBagUpdate();
            //通知客户端背包道具发生改变
            m2c_bagUpdate.BagInfoUpdate = new List<BagInfo>();
            m2c_bagUpdate.BagInfoUpdate.Add(bagInfo);
            MessageHelper.SendToClient(unit, m2c_bagUpdate);

            reply();
            await ETTask.CompletedTask;
        }
    }
}
