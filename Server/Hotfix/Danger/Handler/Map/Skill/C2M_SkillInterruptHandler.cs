using UnityEngine;

namespace ET
{

    [ActorMessageHandler]
    public class C2M_SkillInterruptHandler : AMActorLocationHandler<Unit, C2M_SkillInterruptRequest>
    {

		protected override async ETTask Run(Unit unit, C2M_SkillInterruptRequest message)
		{
			unit.GetComponent<SkillManagerComponent>().InterruptSkill(message.SkillID);

			await ETTask.CompletedTask;
		}
	}
}
