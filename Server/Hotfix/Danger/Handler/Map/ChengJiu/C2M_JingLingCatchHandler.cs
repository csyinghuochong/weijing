using System;
using System.Collections.Generic;

namespace ET
{
    [ActorMessageHandler]
    public class C2M_JingLingCatchHandler : AMActorLocationRpcHandler<Unit, C2M_JingLingCatchRequest, M2C_JingLingCatchResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_JingLingCatchRequest request, M2C_JingLingCatchResponse response, Action reply)
        {

            Unit zhupuUnit = unit.GetParent<UnitComponent>().Get(request.JingLingId);
            if (zhupuUnit == null)
            {
                reply();
                return;
            }

            if (unit.GetComponent<BagComponent>().GetBagLeftCell() < 1)
            {
                response.Error = ErrorCode.ERR_BagIsFull;
                reply();
                return;
            }

            if (request.ItemId != 0)
            {
                bool costresult =  unit.GetComponent<BagComponent>().OnCostItemData($"{request.ItemId};1");
                if (costresult == false)
                {
                    response.Error = ErrorCode.ERR_ItemNotEnoughError;
                    reply();
                    return;
                }
            }

            int gailv = ComHelp.GetZhuPuGaiLv(zhupuUnit.ConfigId, request.ItemId, int.Parse(request.OperateType));
            if (RandomHelper.RandFloat01() <= gailv * 0.0001f)
            {
                response.Message = String.Empty;
                int skinId = zhupuUnit.GetComponent<NumericComponent>().GetAsInt(NumericType.PetSkin);

                MonsterConfig monsterConfig = MonsterConfigCategory.Instance.Get(zhupuUnit.ConfigId);
                int getItemid = monsterConfig.Parameter[1];
                unit.GetComponent<BagComponent>().OnAddItemData($"{getItemid};1",$"{ItemGetWay.PickItem}_{TimeHelper.ServerNow()}");

                List<BagInfo> bagInfolist = unit.GetComponent<BagComponent>().GetIdItemList(getItemid);
                if (bagInfolist.Count > 0)
                {
                    bagInfolist[bagInfolist.Count - 1].ItemPar = skinId.ToString();
                }
            }
            else
            {
                response.Error = ErrorCode.ERR_ZhuaBuFail;
            }

            unit.GetParent<UnitComponent>().Remove(request.JingLingId);
            reply();
            await ETTask.CompletedTask;
        }
    }

}