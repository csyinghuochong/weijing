using System;
using System.Collections.Generic;
using UnityEngine;

namespace ET
{
    /// <summary>
    /// 召唤物，数量有上限，超出则从前开始销毁
    /// </summary>
    public class Skill_Com_Summon_4: SkillHandler
    {
        //初始化
        public override void OnInit(SkillInfo skillId, Unit theUnitFrom)
        {
            this.BaseOnInit(skillId, theUnitFrom);
        }

        //退出
        public override void OnExecute()
        {
            Unit theUnitFrom = this.TheUnitFrom;
            UnitInfoComponent unitInfoComponent = theUnitFrom.GetComponent<UnitInfoComponent>();
            if (unitInfoComponent.GetZhaoHuanNumber() >= 100)
            {
                return;
            }

            this.InitSelfBuff();

            //'90000102;1;1;1;0.5,0.5,0.5,0.5,0.5;0,0,0,0,0;2
            //召唤ID；是否复刻玩家形象（0不是，1是）；范围；数量；血量比例,攻击比例,魔法比例,物防比例，魔防比例；血量固定值,攻击固定值，魔法固定值，物防固定值，魔防固定值;数量上限
            string gameObjectParameter = this.SkillConf.GameObjectParameter;
            string[] summonParList = gameObjectParameter.Split(';');

            int monsterId = 0;
            float range = 0f;
            int number = 0;
            int maxNum = 0;
            try
            {
                monsterId = int.Parse(summonParList[0]);
                range = float.Parse(summonParList[2]);
                number = int.Parse(summonParList[3]);
                maxNum = int.Parse(summonParList[6]);
            }
            catch (Exception ex)
            {
                Log.Error("Skill_Com_Summon_4:Error:  ", this.SkillConf.Id);
                Log.Error(ex.ToString());
                return;
            }

            List<Unit> haved = new List<Unit>();
            List<Unit> all = theUnitFrom.GetParent<UnitComponent>().GetAll();
            foreach (Unit unit in all)
            {
                if (unit.Type == UnitType.Monster && unit.ConfigId == monsterId && unit.MasterId == theUnitFrom.Id)
                {
                    haved.Add(unit);
                }
            }

            if (haved.Count + number > maxNum)
            {
                int de = haved.Count + number - maxNum;
                while (de > 0 && haved.Count > 0)
                {
                    Unit uu = haved[0];
                    haved.Remove(uu);
                    uu.GetComponent<HeroDataComponent>().OnDead(null);
                    unitInfoComponent.ZhaohuanIds.Remove(uu.Id);
                    --de;
                }
            }

            if (number > 100)
            {
                Log.Error($"Skill_Com_Summon_4: {this.SkillConf.Id}");
                return;
            }

            for (int y = 0; y < number; y++)
            {
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