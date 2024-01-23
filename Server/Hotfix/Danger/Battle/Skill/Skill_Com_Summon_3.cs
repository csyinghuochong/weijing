using System;
using System.Collections.Generic;
using UnityEngine;

namespace ET
{
    /// <summary>
    /// 随机召唤一个曾经击败过的boss协助战斗
    /// </summary>
    public class Skill_Com_Summon_3: SkillHandler
    {
        public override void OnInit(SkillInfo skillId, Unit theUnitFrom)
        {
            this.BaseOnInit(skillId, theUnitFrom);
        }

        public override void OnExecute()
        {
            Unit theUnitFrom = this.TheUnitFrom;
            UnitInfoComponent unitInfoComponent = theUnitFrom.GetComponent<UnitInfoComponent>();
            if (unitInfoComponent.GetZhaoHuanNumber() >= 100)
            {
                return;
            }

            this.InitSelfBuff();

            //'90000102;1;1;1;0.5,0.5,0.5,0.5,0.5;0,0,0,0,0
            //召唤ID；是否复刻玩家形象（0不是，1是）；范围；数量；血量比例,攻击比例,魔法比例,物防比例，魔防比例；血量固定值,攻击固定值，魔法固定值，物防固定值，魔防固定值
            string gameObjectParameter = this.SkillConf.GameObjectParameter;
            string[] summonParList = gameObjectParameter.Split(';');

            UserInfo userInfo = theUnitFrom.GetComponent<UserInfoComponent>()?.UserInfo;
            if (userInfo != null && userInfo.DefeatedBossIds.Count > 0)
            {
                int monsterId = 0;
                float range = 0f;
                int number = 0;

                monsterId = ConfigHelper.DefeatedBossIds[userInfo.DefeatedBossIds[RandomHelper.RandomNumber(0, userInfo.DefeatedBossIds.Count)]];

                try
                {
                    range = float.Parse(summonParList[2]);
                    number = int.Parse(summonParList[3]);
                }
                catch (Exception ex)
                {
                    Log.Error("Skill_Com_Summon_3:Error:  ", this.SkillConf.Id);
                    Log.Error(ex.ToString());
                    return;
                }

                if (number > 100)
                {
                    Log.Error($"Skill_Com_Summon_3: {this.SkillConf.Id}");
                    return;
                }

                int maxNum = GlobalValueConfigCategory.Instance.Get(120).Value2;
                UnitComponent unitComponent = theUnitFrom.GetParent<UnitComponent>();
                for (int y = 0; y < number; y++)
                {
                    if (unitInfoComponent.ZhaohuanIds.Count >= maxNum)
                    {
                        Unit unit = unitComponent.Get(unitInfoComponent.ZhaohuanIds[0]);
                        if (unit != null && unit.Type == UnitType.Monster)
                        {
                            unit.GetComponent<HeroDataComponent>().OnDead(null);
                            unitInfoComponent.ZhaohuanIds.Remove(unit.Id);
                        }
                    }

                    //随机坐标
                    float ran_x = RandomHelper.RandomNumberFloat(-1 * range, range);
                    float ran_z = RandomHelper.RandomNumberFloat(-1 * range, range);
                    Vector3 initPosi = new Vector3(theUnitFrom.Position.x + ran_x, theUnitFrom.Position.y, theUnitFrom.Position.z + ran_z);

                    if (this.SkillConf.SkillZhishiType == 1)
                    {
                        initPosi = this.TargetPosition;
                    }

                    Unit unitMonster = UnitFactory.CreateMonster(theUnitFrom.DomainScene(), monsterId, initPosi,
                        new CreateMonsterInfo()
                        {
                            Camp = theUnitFrom.GetBattleCamp(),
                            MasterID = theUnitFrom.Id,
                            AttributeParams = summonParList[1] + ";" + summonParList[4] + ";" + summonParList[5]
                        });
                    unitInfoComponent.ZhaohuanIds.Add(unitMonster.Id);
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