using System;
using System.Collections.Generic;

namespace ET
{

    [ActorMessageHandler]
    public class C2M_JiaYuanPurchaseHandler : AMActorLocationRpcHandler<Unit, C2M_JiaYuanPurchaseRequest, M2C_JiaYuanPurchaseResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_JiaYuanPurchaseRequest request, M2C_JiaYuanPurchaseResponse response, Action reply)
        {
            JiaYuanComponent jiaYuanComponent = unit.GetComponent<JiaYuanComponent>();
            List<JiaYuanPurchaseItem> purchaselist = jiaYuanComponent.PurchaseItemList_7;
            JiaYuanPurchaseItem jiaYuanPurchaseItem = null;
            for (int i = 0; i < purchaselist.Count; i++)
            {
                if (purchaselist[i].PurchaseId == request.PurchaseId)
                {
                    jiaYuanPurchaseItem = purchaselist[i];
                    purchaselist.RemoveAt(i);
                    break;
                }
            }
            if (jiaYuanPurchaseItem == null)
            {
                response.Error = ErrorCore.ERR_NetWorkError;
                reply();
                return;
            }
            if (unit.GetComponent<BagComponent>().GetItemNumber(request.ItemId) < 1)
            {
                response.Error = ErrorCore.ERR_ItemNotEnoughError;
                reply();
                return;
            }

            unit.GetComponent<UserInfoComponent>().UpdateRoleData(UserDataType.JiaYuanFund, jiaYuanPurchaseItem.BuyZiJin.ToString());
            unit.GetComponent<BagComponent>().OnCostItemData($"{request.ItemId};1");
            response.PurchaseItemList = jiaYuanComponent.PurchaseItemList_7;
            DBHelper.SaveComponent( unit.DomainZone(), unit.Id, jiaYuanComponent).Coroutine();
            reply();
            await ETTask.CompletedTask;
        }
    }
}
