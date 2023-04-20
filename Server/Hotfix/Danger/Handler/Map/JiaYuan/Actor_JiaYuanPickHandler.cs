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
            //int monsterid = boxUnit.ConfigId;
            //MonsterConfig monsterConfig = MonsterConfigCategory.Instance.Get(monsterid);
            //if (monsterConfig.MonsterSonType != 60)
            //{
            //    response.Error = ErrorCore.ERR_Success;
            //    reply();
            //    return;
            //}
            if (unit.Id != request.MasterId)
            {
                NumericComponent numericComponent = unit.GetComponent<NumericComponent>();
                if (numericComponent.GetAsInt(NumericType.JiaYuanPickOther) >= 5)
                {
                    response.Error = ErrorCore.ERR_TimesIsNot;
                    reply();
                    return;
                }
            }

            EventType.NumericChangeEvent.Instance.Attack = unit;
            EventType.NumericChangeEvent.Instance.Parent = boxUnit;
            boxUnit.GetComponent<HeroDataComponent>().OnDead(EventType.NumericChangeEvent.Instance);

            if (unit.Id == request.MasterId)
            {
                JiaYuanComponent jiaYuanComponent = unit.GetComponent<JiaYuanComponent>();
                jiaYuanComponent.OnRemoveUnit(request.UnitId);

                await DBHelper.SaveComponent(unit.DomainZone(), unit.Id, jiaYuanComponent);
            }
            else
            {
                unit.GetComponent<NumericComponent>().ApplyChange(null, NumericType.JiaYuanPickOther, 1, 0);

                JiaYuanComponent jiaYuanComponent_2 = await DBHelper.GetComponentCache<JiaYuanComponent>(unit.DomainZone(), request.MasterId);
                long gateServerId = DBHelper.GetGateServerId(unit.DomainZone());
                G2T_GateUnitInfoResponse g2M_UpdateUnitResponse = (G2T_GateUnitInfoResponse)await ActorMessageSenderComponent.Instance.Call
                    (gateServerId, new T2G_GateUnitInfoRequest()
                    {
                        UserID = request.MasterId
                    });

                //玩家在线
                if (g2M_UpdateUnitResponse.PlayerState == (int)PlayerState.Game && g2M_UpdateUnitResponse.SessionInstanceId > 0)
                {
                    JiaYuanOperate jiaYuanOperate = new JiaYuanOperate();
                    jiaYuanOperate = new JiaYuanOperate();
                    jiaYuanOperate.OperateType = JiaYuanOperateType.Pick;
                    jiaYuanOperate.UnitId = request.UnitId;
                    jiaYuanOperate.PlayerName = unit.GetComponent<UserInfoComponent>().UserInfo.Name;
                    M2M_JiaYuanOperateMessage opmessage = new M2M_JiaYuanOperateMessage()
                    {
                        JiaYuanOperate = jiaYuanOperate,
                    };
                    MessageHelper.SendToLocationActor(request.MasterId, opmessage);
                }
                else
                {
                    jiaYuanComponent_2.OnRemoveUnit(request.UnitId);
                    await DBHelper.SaveComponent(unit.DomainZone(), request.MasterId, jiaYuanComponent_2);
                }
            }
            
            response.Error = ErrorCore.ERR_Success;
            reply();
            await ETTask.CompletedTask;
        }
    }
}
