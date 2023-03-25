using System;


namespace ET
{
    [ActorMessageHandler]
    public class C2M_JiaYuanWarehouseHandler : AMActorLocationRpcHandler<Unit, C2M_JiaYuanWarehouseRequest, M2C_JiaYuanWarehouseResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_JiaYuanWarehouseRequest request, M2C_JiaYuanWarehouseResponse response, Action reply)
        {
            switch (request.OperateType)
            {
                case 1: //放入仓库
                    BagInfo useBagInfo = unit.GetComponent<BagComponent>().GetItemByLoc(ItemLocType.ItemLocBag, request.OperateBagID);
                    if (useBagInfo == null)
                    {
                        reply();
                        return;
                    }
                    if (!unit.GetComponent<BagComponent>().IsHourseFullByLoc(int.Parse(request.OperatePar)))
                    {
                        response.Error = ErrorCore.ERR_WarehouseFul;
                        reply();
                        return;
                    }

                    break;
                case 2: //放回背包


                    break;
            }

            reply();
            await ETTask.CompletedTask;
        }
    }
}
