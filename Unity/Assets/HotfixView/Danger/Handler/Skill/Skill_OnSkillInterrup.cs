using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class Skill_OnSkillInterrup : AEventClass<EventType.SkillInterrup>
    {
        protected override void Run(object numerice)
        {
            EventType.SkillInterrup args = numerice as EventType.SkillInterrup;

            Unit nowNunt = args.Unit;
            if (nowNunt.MainHero)
            {
                nowNunt.GetComponent<SingingComponent>().OnInterrupt();
            }
            FsmComponent fsmComponent = nowNunt.GetComponent<FsmComponent>();
            fsmComponent?.ChangeState(FsmStateEnum.FsmIdleState);
        }
    }
}
