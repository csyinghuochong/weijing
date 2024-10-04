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
                for (int i = 0; i < baseSkilllist.Length; i++)
                {
                    if (skillSetComponent.GetBySkillID(baseSkilllist[i]) != null)
                    {
                        continue;
                    }
                    skillSetComponent.SkillList.Add(new SkillPro() { SkillID = baseSkilllist[i] });
                }
            }

            //刷新转职技能
            if (occTwo != 0)
            {
                ///移除重复的转职技能

                OccupationTwoConfig occupationTwo = OccupationTwoConfigCategory.Instance.Get(occTwo);

                List<int> occTwoSkillList = new List<int>(occupationTwo.SkillID) { };
                List<int> selfoccTwoSkill = new List<int>() { };

                int removeSkillIndex = 0;
                for (int i = 0; i < skillSetComponent.SkillList.Count; i++)
                {
                    int initskillid = SkillConfigCategory.Instance.GetInitSkill(skillSetComponent.SkillList[i].SkillID);

                    //if (skillSetComponent.SkillList[i].SkillID >= 64015201 && skillSetComponent.SkillList[i].SkillID <= 64015206)
                    //{
                    //    Console.WriteLine($"initskillid: {skillSetComponent.SkillList[i].SkillID}   {initskillid}");
                    //}

                    if (initskillid == 0)
                    {
                        continue;
                    }
                    if (!occTwoSkillList.Contains(initskillid))
                    {
                        continue;
                    }

                    if (selfoccTwoSkill.Contains(initskillid))
                    {
                        removeSkillIndex = (i);
                    }
                    else
                    {
                        selfoccTwoSkill.Add(initskillid);
                    }
                }

                if (removeSkillIndex != 0)
                {
                    skillSetComponent.SkillList.RemoveAt(removeSkillIndex);
                }

                for (int i = 0; i < occTwoSkillList.Count; i++)
                {
                    if (selfoccTwoSkill.Contains(occTwoSkillList[i]))
                    {
                        continue;
                    }

                    if (skillSetComponent.GetBySkillID(occTwoSkillList[i]) == null)
                    {
                        Console.WriteLine($"区{unit.DomainZone()}   玩家:{unit.Id}   添加技能ID:{occTwoSkillList[i]}");

                        //skillSetComponent.SkillList.Add(new SkillPro() { SkillID = occTwoSkillList[i] });
                    }
                }
            }


            //刷新转职技能-猎人被动技能强制刷新
            if (occTwo == 401 || occTwo == 402 || occTwo == 403)
            {
                ///移除重复的转职技能
                //63203002   -   63303002
                //63201003   -   63301003
                //63202002   -   63302002

                for (int occskill = 0; occskill < skillSetComponent.SkillList.Count; occskill++)
                {
                    if (skillSetComponent.SkillList[occskill].SkillID == 63203002)
                    {
                        skillSetComponent.SkillList[occskill].SkillID = 63303002;

                        Console.WriteLine($"63203002->63303002:   {unit.Id}");
                    }

                    if (skillSetComponent.SkillList[occskill].SkillID == 63201003)
                    {
                        skillSetComponent.SkillList[occskill].SkillID = 63301003;

                        Console.WriteLine($"63201003->63301003:   {unit.Id}");
                    }

                    if (skillSetComponent.SkillList[occskill].SkillID == 63202002)
                    {
                        skillSetComponent.SkillList[occskill].SkillID = 63302002;

                        Console.WriteLine($"63202002->63302002:   {unit.Id}");
                    }
                }
            }
            //if (unit.Id == 2294043601589567488)
            //{
            //    Console.WriteLine("重置雨天坏蛋生命之魂！");

            //    for (int i = 0; i < skillSetComponent.LifeShieldList.Count; i++)
            //    {
            //        skillSetComponent.LifeShieldList[i].Level = 9;
            //        skillSetComponent.LifeShieldList[i].Exp = 0;
            //    }
            //}

            List<int> allskill = new List<int>();
            List<int> repeatlist = new List<int>();
            string repeatskill = string.Empty;
            for (int i = 0; i < skillSetComponent.SkillList.Count; i++)
            {
                if (allskill.Contains(skillSetComponent.SkillList[i].SkillID))
                {
                    repeatlist.Add(skillSetComponent.SkillList[i].SkillID);
                    repeatskill += $"{skillSetComponent.SkillList[i].SkillID}   ";
                }
                else
                {
                    allskill.Add(skillSetComponent.SkillList[i].SkillID);
                }
            }
            if (!string.IsNullOrEmpty(repeatskill))
            {
                UserInfoComponent userInfoComponent = unit.GetComponent<UserInfoComponent>();
                Console.WriteLine($"区{unit.DomainZone()}   玩家:{unit.Id}   重复技能ID: {repeatskill}  职业:{userInfoComponent.UserInfo.OccTwo}");

                if (repeatskill.Contains("6102340") && repeatlist.Count >= 2 && userInfoComponent.UserInfo.OccTwo == 103) //61023401 
                {
                    Console.WriteLine($"区{unit.DomainZone()}   玩家:{unit.Id}   重置技能！！");
                    int level = userInfoComponent.UserInfo.Lv;
                    int sp = userInfoComponent.UserInfo.Sp;
                    userInfoComponent.UpdateRoleData(UserDataType.Sp, (level - sp - 1).ToString(), false);
                    unit.GetComponent<SkillSetComponent>().ResetNengLiangZhiDi();
                    unit.GetComponent<SkillSetComponent>().OnSkillReset(false);
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
