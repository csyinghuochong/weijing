using System;


namespace ET
{
    [ActorMessageHandler]
    public class C2M_PetOpenCangKuHandler : AMActorLocationRpcHandler<Unit, C2M_PetOpenCangKu, M2C_PetOpenCangKu>
    {
        protected override async ETTask Run(Unit unit, C2M_PetOpenCangKu request, M2C_PetOpenCangKu response, Action reply)
        {
            string costitem = ConfigHelper.PetOpenCangKu[request.OpenIndex - 1];
            if (!unit.GetComponent<BagComponent>().CheckCostItem(costitem))
            {
                response.Error = ErrorCore.ERR_GoldNotEnoughError;
                reply();
                return;
            }
            if (unit.GetComponent<PetComponent>().PetCangKuOpen.Contains(request.OpenIndex - 1)) 
            {
                response.Error = ErrorCore.ERR_CangKu_Already;
                reply();
                return;
            }

            unit.GetComponent<PetComponent>().PetCangKuOpen.Add(request.OpenIndex - 1);
            unit.GetComponent<BagComponent>().OnCostItemData(costitem);
            reply();
            await ETTask.CompletedTask;
        }
    }
}
