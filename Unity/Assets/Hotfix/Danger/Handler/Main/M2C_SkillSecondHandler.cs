using UnityEngine;

namespace ET
{
    [MessageHandler]
    public class M2C_SkillSecondHandler : AMHandler<M2C_SkillSecondResult>
    {
        protected override void Run(Session session, M2C_SkillSecondResult message)
        {
            Unit unit = session.ZoneScene().CurrentScene().GetComponent<UnitComponent>().Get(message.UnitId);
            if (unit == null || !unit.MainHero)
            {
                return;
            }

            EventType.M2C_SkillSecond.Instance.ZoneScene = session.ZoneScene();
            EventType.M2C_SkillSecond.Instance.M2C_SkillSecondResult = message;
            EventType.M2C_SkillSecond.Instance.Unit = unit;
            EventSystem.Instance.PublishClass(EventType.M2C_SkillSecond.Instance);
        }
    }
}