using System;
using System.Collections.Generic;
using UnityEngine;

namespace ET
{
    /// <summary>
    /// 自身释放一个指定技能后，如果自身有一个或多个特定的召唤物，其召唤物会跟随角色本身一起释放角色当前技能
    /// </summary>
    public class Skill_Com_Summon_6: SkillHandler
    {
        public override void OnInit(SkillInfo skillId, Unit theUnitFrom)
        {
            this.BaseOnInit(skillId, theUnitFrom);
        }

        public override void OnExecute()
        {
            this.InitSelfBuff();

            Unit theUnitFrom = this.TheUnitFrom;

            if (theUnitFrom.Type == UnitType.Player)
            {
                // 召唤物释放相同技能
                // '90000102,90000103(如果填0是所有)
                // 召唤ID,召唤ID
                string[] summonParList = this.SkillConf.GameObjectParameter.Split(';');
                List<int> monsterIds = new List<int>();
                bool allMonster = false;
                try
                {
                    foreach (string s in summonParList)
                    {
                        if (s == "0")
                        {
                            allMonster = true;
                            break;
                        }

                        monsterIds.Add(int.Parse(s));
                    }
                }
                catch (Exception ex)
                {
                    Log.Error("Skill_Com_Summon_6:Error:  ", this.SkillConf.Id);
                    Log.Error(ex.ToString());
                    return;
                }

                List<Unit> all = theUnitFrom.GetParent<UnitComponent>().GetAll();
                foreach (Unit unit in all)
                {
                    if (unit.Type == UnitType.Monster && unit.MasterId == theUnitFrom.Id && (allMonster || monsterIds.Contains(unit.ConfigId)))
                    {
                        C2M_SkillCmd cmd = unit.GetComponent<AIComponent>().c2M_SkillCmd;
                        cmd.TargetID = this.SkillInfo.TargetID;
                        cmd.SkillID = this.SkillConf.Id;
                        if (this.SkillConf.SkillZhishiTargetType == 1) //自身点
                        {
                            cmd.TargetAngle = 0;
                            cmd.TargetDistance = 0;
                        }
                        else
                        {
                            if (this.TheUnitTarget != null)
                            {
                                Vector3 direction = this.TheUnitTarget.Position - unit.Position;
                                float ange = Mathf.Rad2Deg(Mathf.Atan2(direction.x, direction.z));
                                cmd.TargetAngle = Mathf.FloorToInt(ange);
                                cmd.TargetDistance = Vector3.Distance(unit.Position, this.TheUnitTarget.Position);
                            }
                        }

                        unit.GetComponent<SkillManagerComponent>().OnUseSkill(cmd, true);
                    }
                }
            }

            this.OnUpdate();
        }

        public override void OnUpdate()
        {
            this.BaseOnUpdate();
            this.CheckChiXuHurt();
        }

        public override void OnFinished()
        {
            this.Clear();
        }
    }
}