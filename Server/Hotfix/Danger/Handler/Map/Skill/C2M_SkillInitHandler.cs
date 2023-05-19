using System;
using System.Collections.Generic;

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
			response.SkillSetInfo.LifeShieldList = skillSetComponent.LifeShieldList;
			response.SkillSetInfo.TianFuPlan = skillSetComponent.TianFuPlan;

			List<int> tianfulist = new List<int>();
			for (int i = 0; i < skillSetComponent.TianFuList.Count; i++)
			{
				if (!tianfulist.Contains(skillSetComponent.TianFuList[i]))
				{
					tianfulist.Add(skillSetComponent.TianFuList[i]);
				}
			}
			response.SkillSetInfo.TianFuList = tianfulist;

			List<int> tianfulist1 = new List<int>();
			for (int i = 0; i < skillSetComponent.TianFuList1.Count; i++)
			{
				if (!tianfulist1.Contains(skillSetComponent.TianFuList1[i]))
				{
					tianfulist1.Add(skillSetComponent.TianFuList1[i]);
				}
			}
			response.SkillSetInfo.TianFuList1 = tianfulist1;

			reply();
			await ETTask.CompletedTask;
		}
	}
}
