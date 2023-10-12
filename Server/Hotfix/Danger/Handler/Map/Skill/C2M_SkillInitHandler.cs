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

            int occ = unit.GetComponent<UserInfoComponent>().UserInfo.Occ;
			int occTwo = unit.GetComponent<UserInfoComponent>().UserInfo.OccTwo;
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

			//强化技能可以激活
			bool haveqianghuaskill = false;
			for (int i = 0; i < skillSetComponent.SkillList.Count; i++)
			{
				if (SkillHelp.IsQiangHuaSkill(occ, skillSetComponent.SkillList[i].SkillID))
				{
					haveqianghuaskill = true;
					break;
				}
			}

			if (!haveqianghuaskill)
			{
				int[] baseSkilllist = OccupationConfigCategory.Instance.Get(occ).BaseSkill;
				for( int i = 0; i < baseSkilllist.Length; i++ )
				{
					if (skillSetComponent.GetBySkillID(baseSkilllist[i]) !=null)
					{
						continue;
					}
					skillSetComponent.SkillList.Add(new SkillPro() { SkillID = baseSkilllist[i] });
                }
            }

			//刷新猎人转职技能
			if (occ == 3 && occTwo != 0)
			{
				OccupationTwoConfig occupationTwo = OccupationTwoConfigCategory.Instance.Get(occTwo);
				List<int> occTwoSkillList = new List<int>(occupationTwo.SkillID) {  };
				
				for (int i = 0; i < skillSetComponent.SkillList.Count; i++)
				{
					int initskillid = SkillConfigCategory.Instance.GetInitSkill(skillSetComponent.SkillList[i].SkillID);
					if (initskillid == 0)
					{
						continue;
					}
					if (occTwoSkillList.Contains(initskillid))
                    {
                        occTwoSkillList.Remove(initskillid);
                    }
                }

				for (int i = 0; i < occTwoSkillList.Count; i++)
				{
                    skillSetComponent.SkillList.Add(new SkillPro() { SkillID = occTwoSkillList[i] });
                }
			}

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
			skillSetComponent.TianFuList = tianfulist;

			List<int> tianfulist1 = new List<int>();
			for (int i = 0; i < skillSetComponent.TianFuList1.Count; i++)
			{
				if (!tianfulist1.Contains(skillSetComponent.TianFuList1[i]))
				{
					tianfulist1.Add(skillSetComponent.TianFuList1[i]);
				}
			}
			response.SkillSetInfo.TianFuList1 = tianfulist1;
			skillSetComponent.TianFuList1 = tianfulist1;

			reply();
			await ETTask.CompletedTask;
		}
	}
}
