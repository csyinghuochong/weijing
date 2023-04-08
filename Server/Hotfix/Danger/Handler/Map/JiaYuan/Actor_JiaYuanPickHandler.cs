using System;

namespace ET
{

    [ActorMessageHandler]
    public class Actor_JiaYuanPickHandler : AMActorLocationRpcHandler<Unit, Actor_JiaYuanPickRequest, Actor_JiaYuanPickResponse>
    {
        protected override async ETTask Run(Unit unit, Actor_JiaYuanPickRequest request, Actor_JiaYuanPickResponse response, Action reply)
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
            if (monsterConfig.MonsterSonType != 60)
            {
                response.Error = ErrorCore.ERR_Success;
                reply();
                return;
            }

            EventType.NumericChangeEvent.Instance.Attack = unit;
            EventType.NumericChangeEvent.Instance.Parent = boxUnit;
            boxUnit.GetComponent<HeroDataComponent>().OnDead(EventType.NumericChangeEvent.Instance);

            JiaYuanComponent jiaYuanComponent_2 = await DBHelper.GetComponentCache<JiaYuanComponent>(unit.DomainZone(), request.MasterId);
            jiaYuanComponent_2.OnRemoveUnit(request.UnitId);
            await DBHelper.SaveComponent(unit.DomainZone(), request.MasterId, jiaYuanComponent_2);
            if (unit.Id == request.UnitId)
            {
                JiaYuanComponent jiaYuanComponent = unit.GetComponent<JiaYuanComponent>();
                jiaYuanComponent.JiaYuanMonster_1 = jiaYuanComponent_2.JiaYuanMonster_1;
            }

            response.Error = ErrorCore.ERR_Success;
            reply();
            await ETTask.CompletedTask;
        }
    }
}
