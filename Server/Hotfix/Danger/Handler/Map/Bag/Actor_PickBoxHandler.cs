using System;

namespace ET
{

    [ActorMessageHandler]
    public class Actor_PickBoxHandler : AMActorLocationRpcHandler<Unit, Actor_PickBoxRequest, Actor_PickBoxResponse>
    {

        protected override async ETTask Run(Unit unit, Actor_PickBoxRequest request, Actor_PickBoxResponse response, Action reply)
        {
            Unit boxUnit = unit.GetParent<UnitComponent>().Get(request.UnitId);
            if (boxUnit == null)
            {
                response.Error = ErrorCore.ERR_Success;
                reply();
                return;
            }
            if (boxUnit.GetComponent<NumericComponent>().GetAsInt(NumericType.Now_Dead) == 1)
            {
                response.Error = ErrorCore.ERR_Success;
                reply();
                return;
            }
            int monsterid = boxUnit.ConfigId;
            MonsterConfig monsterConfig = MonsterConfigCategory.Instance.Get(monsterid);
            string itemneeds = "";
            if (monsterConfig.Parameter != null && monsterConfig.Parameter.Length > 0
                && monsterConfig.Parameter[0]>0)
            {
                itemneeds = $"{monsterConfig.Parameter[0]};{monsterConfig.Parameter[1]}";
            }
            if (itemneeds.Length >2 && !unit.GetComponent<BagComponent>().OnCostItemData(itemneeds))
            {
                response.Error = ErrorCore.ERR_ItemNotEnoughError;
                reply();
                return;
            }
           
            EventType.NumericChangeEvent.Instance.Attack = unit;
            EventType.NumericChangeEvent.Instance.Parent = boxUnit;
            boxUnit.GetComponent<HeroDataComponent>().OnDead(EventType.NumericChangeEvent.Instance);
            response.Error = ErrorCore.ERR_Success;

            reply();
            await ETTask.CompletedTask;
        }
    }
}
