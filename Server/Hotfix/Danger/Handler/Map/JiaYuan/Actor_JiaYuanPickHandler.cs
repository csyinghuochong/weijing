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
            if (unit.Id != request.MasterId)
            {
                NumericComponent numericComponent = unit.GetComponent<NumericComponent>();
                if (numericComponent.GetAsInt(NumericType.JiaYuanPickOther) >= 10)
                {
                    response.Error = ErrorCore.ERR_TimesIsNot;
                    reply();
                    return;
                }
            }

            EventType.NumericChangeEvent.Instance.Attack = unit;
            EventType.NumericChangeEvent.Instance.Parent = boxUnit;
            boxUnit.GetComponent<HeroDataComponent>().OnDead(EventType.NumericChangeEvent.Instance);

            JiaYuanComponent jiaYuanComponent_2 = await DBHelper.GetComponentCache<JiaYuanComponent>(unit.DomainZone(), request.MasterId);
            jiaYuanComponent_2.OnRemoveUnit(request.UnitId);
            await DBHelper.SaveComponent(unit.DomainZone(), request.MasterId, jiaYuanComponent_2);
            if (unit.Id == request.MasterId)
            {
                JiaYuanComponent jiaYuanComponent = unit.GetComponent<JiaYuanComponent>();
                jiaYuanComponent.JiaYuanMonster_2 = jiaYuanComponent_2.JiaYuanMonster_2;
            }
            else
            {
                unit.GetComponent<NumericComponent>().ApplyChange(null, NumericType.JiaYuanPickOther, 1, 0);
            }

            response.Error = ErrorCore.ERR_Success;
            reply();
            await ETTask.CompletedTask;
        }
    }
}
