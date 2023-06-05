using UnityEngine;

namespace ET
{

    //接受Buff改变消息
    [MessageHandler]
    public class M2C_UnitBuffStatusHandle : AMHandler<M2C_UnitBuffStatus>
    {
        protected override void Run(Session session, M2C_UnitBuffStatus message)
        {
            Unit msgUnitBelongTo = session.ZoneScene().CurrentScene()?.GetComponent<UnitComponent>().Get(message.UnitID);
            if (msgUnitBelongTo == null)
            {

                //long nowHpValue = numericComponentDefend.GetAsLong(NumericType.Now_Hp);
                //long costHp = (nowHpValue - args.OldValue);
                //瓢字
                EventType.UnitHpUpdate.Instance.Unit = msgUnitBelongTo;
                EventType.UnitHpUpdate.Instance.ChangeHpValue = 0;
                EventType.UnitHpUpdate.Instance.DamgeType = message.FlyType;
                EventType.UnitHpUpdate.Instance.SkillID = 0;
                Game.EventSystem.PublishClass(EventType.UnitHpUpdate.Instance);

                //return;
            }
            //移除
            //msgUnitBelongTo.GetComponent<BuffManagerComponent>().RemoveBuff(message.BuffID);
        }
    }
}
