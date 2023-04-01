using System;

namespace ET
{
    //设置技能位置
    [ActorMessageHandler]
	public class C2M_SkillInitHandler : AMActorLocationRpcHandler<Unit, C2M_SkillInitRequest, M2C_SkillInitResponse>
	{
		protected override async ETTask Run(Unit unit, C2M_SkillInitRequest request, M2C_SkillInitResponse response, Action reply)
		{
			SkillSetComponent skillSetComponent = unit.GetComponent<SkillSetComponent>();
			response.SkillSetInfo = new SkillSetInfo();
			//for (int i = skillSetComponent.SkillList.Count - 1; i >= 0; i--)
			//{
			//	SkillPro skillPro = skillSetComponent.SkillList[i];
			//	if (skillPro.SkillPosition == 0)
			//	{
			//		continue;
			//	}
			//	if (skillPro.SkillSetType == (int)SkillSetEnum.Skill)
			//	{
			//		if (!SkillConfigCategory.Instance.Contain(skillPro.SkillID))
			//		{
			//			skillSetComponent.SkillList.RemoveAt(i);
			//		}
			//		continue;
			//	}
			//}

			response.SkillSetInfo.SkillList = skillSetComponent.SkillList;
			response.SkillSetInfo.TianFuList = skillSetComponent.TianFuList;
			response.SkillSetInfo.LifeShieldList = skillSetComponent.LifeShieldList;
			response.SkillSetInfo.TianFuList1 = skillSetComponent.TianFuList1;
			response.SkillSetInfo.TianFuPlan = skillSetComponent.TianFuPlan;

			reply();
			await ETTask.CompletedTask;
		}
	}
}
