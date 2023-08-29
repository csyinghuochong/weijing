using System;


namespace ET
{

    [ActorMessageHandler]
    public class C2M_PetFragmentDuiHuanHandler : AMActorLocationRpcHandler<Unit, C2M_PetFragmentDuiHuan, M2C_PetFragmentDuiHuan>
    {
        protected override async ETTask Run(Unit unit, C2M_PetFragmentDuiHuan request, M2C_PetFragmentDuiHuan response, Action reply)
        {
            if (!PetHelper.IsShenShouFull(unit.GetComponent<PetComponent>().RolePetInfos))
            {
                response.Error = ErrorCode.ERR_ModifyData;
                reply();
                return;
            }

            if (unit.GetComponent<BagComponent>().GetItemNumber(10000136) < 1)
            {
                response.Error = ErrorCode.ERR_ItemNotEnoughError ;
                reply();
                return;
            }

            unit.GetComponent<BagComponent>().OnCostItemData("10000136;1");
            unit.GetComponent<BagComponent>().OnAddItemData($"{ConfigHelper.PetFramgeItemId};1", $"{ItemGetWay.DuiHuan}_{TimeHelper.ServerNow()}");
            reply();
            await ETTask.CompletedTask;
        }
    }
}
