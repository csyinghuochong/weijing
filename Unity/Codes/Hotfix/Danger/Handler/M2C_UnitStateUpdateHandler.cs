
namespace ET
{
    //接受状态改变消息
    [MessageHandler]
    public class M2C_UnitStateUpdateHandler : AMHandler<M2C_UnitStateUpdate>
    {
        protected override void Run(Session session, M2C_UnitStateUpdate message)
        {
            //Log.Info("获取最新的状态222...");
            //同步我当前的属性
            Unit nowNunt = session.ZoneScene().CurrentScene().GetComponent<UnitComponent>().Get(message.UnitId);
            if (nowNunt == null)
            {
                return;
            }
            //HeroDataComponent hero = session.DomainScene().GetComponent<UnitComponent>().Get(message.UnitId).GetComponent<HeroDataComponent>();
            //nowNunt.GetComponent<NumericComponent>().Set((NumericType)message.NumericType, message.ChangeValue);
            // 添加状态
            if (message.StateOperateType == 1)
            {
                nowNunt.GetComponent<StateComponent>().StateTypeAdd((StateTypeData)message.StateType, message.StateValue);
            }

            //移除状态
            if (message.StateOperateType == 2)
            {
                nowNunt.GetComponent<StateComponent>().StateTypeRemove((StateTypeData)message.StateType);
            }

            if (message.StateOperateType == 1 && message.StateType == (long)StateTypeData.Interrupt)
            {
                //打断技能
                nowNunt.GetComponent<SkillManagerComponent>().InterruptSkill(int.Parse(message.StateValue));
            }

            EventType.StateChange.Instance.m2C_UnitStateUpdate = message;
            EventType.StateChange.Instance.Unit = nowNunt;
            Game.EventSystem.PublishClass(EventType.StateChange.Instance);
        }
    }

}
