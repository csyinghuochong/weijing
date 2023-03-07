using UnityEngine;

namespace ET
{

    //接受Buff改变消息
    [MessageHandler]
    public class M2C_UnitBuffRemoveHandler : AMHandler<M2C_UnitBuffRemove>
    {
        protected override void Run(Session session, M2C_UnitBuffRemove message)
        {
            Unit msgUnitBelongTo = session.ZoneScene().CurrentScene()?.GetComponent<UnitComponent>().Get(message.UnitIdBelongTo);
            if (msgUnitBelongTo == null)
            {
                return;
            }
            //移除
            msgUnitBelongTo.GetComponent<BuffManagerComponent>().RemoveBuff(message.BuffID);
        }
    }
}
