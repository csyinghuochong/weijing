using UnityEngine;


namespace ET
{

    [MessageHandler]
    public class M2C_SkillInterruptResultHandler : AMHandler<M2C_SkillInterruptResult>
    {
        protected override void Run(Session session, M2C_SkillInterruptResult message)
        {
            Unit unit = session.ZoneScene().CurrentScene().GetComponent<UnitComponent>().Get(message.UnitId);
            if (unit == null)
            {
                return;
            }
            unit.GetComponent<SkillManagerComponent>().InterruptSkill(message.SkillId);

            EventType.SkillInterrup.Instance.ZoneScene = session.ZoneScene();
            EventType.SkillInterrup.Instance.Unit = unit;
            EventSystem.Instance.PublishClass(EventType.SkillInterrup.Instance);
        }
    }
}
