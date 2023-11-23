using System;
using System.Collections.Generic;
using System.Linq;

namespace ET
{
    [ActorMessageHandler]
    public class C2M_JingHeActivateRequestHandler : AMActorLocationRpcHandler<Unit, C2M_JingHeActivateRequest, M2C_JingHeActivateResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_JingHeActivateRequest request, M2C_JingHeActivateResponse response, Action reply)
        {
            BagComponent bagComponent = unit.GetComponent<BagComponent>();
            BagInfo bagInfoJinHe = bagComponent.GetItemByLoc(ItemLocType.ItemLocBag, request.BagInfoId);
            if (bagInfoJinHe == null)
            {
                response.Error = ErrorCode.ERR_ItemNotExist;
                reply();
                return;
            }
            //通知客户端背包刷新
            M2C_RoleBagUpdate m2c_bagUpdate = new M2C_RoleBagUpdate();

            bagInfoJinHe.XiLianHideProLists.Clear();
            HideProList hideProList = ItemHelper.GetJingHeHidePro(bagInfoJinHe.ItemID, int.Parse(bagInfoJinHe.ItemPar));
            if (hideProList != null)
            {
                bagInfoJinHe.XiLianHideProLists.Add(hideProList);
            }
            else
            {
                Log.Console($"晶核激活失败: {bagInfoJinHe.ItemID}");
            }
            bagInfoJinHe.IfJianDing = false;
            m2c_bagUpdate.BagInfoUpdate.Add(bagInfoJinHe);
            MessageHelper.SendToClient(unit, m2c_bagUpdate);

            reply();
            await ETTask.CompletedTask;
        }
    }
}
