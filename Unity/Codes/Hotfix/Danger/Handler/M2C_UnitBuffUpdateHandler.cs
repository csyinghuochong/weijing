using UnityEngine;

namespace ET
{
    //接受Buff改变消息
    [MessageHandler]
    public class M2C_UnitBuffUpdateHandler : AMHandler<M2C_UnitBuffUpdate>
    {
        protected override void Run(Session session, M2C_UnitBuffUpdate message)
        {
            //抛出事件处理属性改变
            Unit msgUnitBelongTo = session.ZoneScene().CurrentScene()?.GetComponent<UnitComponent>().Get(message.UnitIdBelongTo);
            if (msgUnitBelongTo == null)
            {
                Log.Debug($"{message.UnitIdBelongTo}  == null");
                return;
            }

            switch (message.BuffOperateType)
            {
                case 1: //增加
                        //触发Buff
                    BuffData buffData = new BuffData();
                    buffData.TargetAngle = 0;
                    buffData.BuffConfig = SkillBuffConfigCategory.Instance.Get((int)message.BuffID);
                    buffData.BuffClassScript = buffData.BuffConfig.BuffScript;
                    buffData.TargetPosition = new Vector3(message.TargetPostion[0], message.TargetPostion[1], message.TargetPostion[2] );
                    msgUnitBelongTo.GetComponent<BuffManagerComponent>().BuffFactory(buffData);
                    break;
                case 2: //移除
                    msgUnitBelongTo.GetComponent<BuffManagerComponent>().RemoveBuff(message.BuffID);
                    break;
                case 3: //重置
                    ABuffHandler buffHandler = msgUnitBelongTo.GetComponent<BuffManagerComponent>().GetBuffById(message.BuffID);
                    if (buffHandler != null)
                    {
                        buffHandler.OnReset();
                    }
                    break;
            }
        }
    }
}
