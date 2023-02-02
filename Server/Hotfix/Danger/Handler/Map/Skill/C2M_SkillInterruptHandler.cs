using UnityEngine;

namespace ET
{

    [ActorMessageHandler]
    public class C2M_SkillInterruptHandler : AMActorLocationHandler<Unit, C2M_SkillInterruptRequest>
    {

		protected override async ETTask Run(Unit unit, C2M_SkillInterruptRequest message)
		{
			unit.GetComponent<SkillManagerComponent>().InterruptSkill(message.SkillID);

			M2C_SkillInterruptResult m2C_SkillInterruptResult = new M2C_SkillInterruptResult() { UnitId = unit.Id, SkillId=message.SkillID };
			MessageHelper.Broadcast(unit, m2C_SkillInterruptResult);
			await ETTask.CompletedTask;
		}
	}
}
