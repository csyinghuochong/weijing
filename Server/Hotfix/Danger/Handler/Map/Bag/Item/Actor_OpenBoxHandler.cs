using System;

namespace ET
{

    [ActorMessageHandler]
    public class Actor_OpenBoxHandler : AMActorLocationRpcHandler<Unit, Actor_OpenBoxRequest, Actor_OpenBoxResponse>
    {

        protected override async ETTask Run(Unit unit, Actor_OpenBoxRequest request, Actor_OpenBoxResponse response, Action reply)
        {
            Unit boxUnit = unit.GetParent<UnitComponent>().Get(request.UnitId);
            if (boxUnit == null)
            {
                response.Error = ErrorCode.ERR_Success;
                reply();
                return;
            }
            if (boxUnit.GetComponent<NumericComponent>().GetAsInt(NumericType.Now_Dead) == 1)
            {
                response.Error = ErrorCode.ERR_Success;
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
                response.Error = ErrorCode.ERR_ItemNotEnoughError;
                reply();
                return;
            }

            if (monsterConfig.MonsterSonType == 57) 
            {
                //背包是否满
                if (unit.GetComponent<BagComponent>().IsBagFull())
                {
                    response.Error = ErrorCode.ERR_BagIsFull;
                    reply();
                    return;
                }

                //宠物已满
                if (unit.GetComponent<PetComponent>().PetIsFull())
                {
                    response.Error = ErrorCode.ERR_PetIsFull;
                    reply();
                    return;
                }
            }

            boxUnit.GetComponent<HeroDataComponent>().OnDead(unit);

            unit.GetComponent<TaskComponent>().TriggerTaskEvent(TaskTargetType.OpenBox_137, 0, 1);
            unit.GetComponent<TaskComponent>().TriggerTaskCountryEvent(TaskTargetType.OpenBox_137, 0, 1);

            response.Error = ErrorCode.ERR_Success;

            reply();
            await ETTask.CompletedTask;
        }
    }
}
