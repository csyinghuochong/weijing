using System;

namespace ET
{
    //设置技能位置
    [ActorMessageHandler]
	public class C2M_SkillSetHandler : AMActorLocationRpcHandler<Unit, C2M_SkillSet, M2C_SkillSet>
    {
		protected override async ETTask Run(Unit unit, C2M_SkillSet request, M2C_SkillSet response, Action reply)
		{
			unit.GetComponent<SkillSetComponent>().SetSkillIdByPosition(request);
			reply();
			await ETTask.CompletedTask;
		}
	}
}
