using System.Collections.Generic;
using UnityEngine;

namespace ET
{
    public class Skill_Com_Summon_2 : SkillHandler
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
            if (unitInfoComponent.GetZhaoHuanNumber() >= 10)
            {
                return;
            }
            //'90000102;1;1;1;0.5,0.5,0.5,0.5,0.5;0,0,0,0,0;90000102,90000103
            //召唤ID；是否复刻玩家形象（0不是，1是）；范围；数量；血量比例,攻击比例,魔法比例,物防比例，魔防比例；血量固定值,攻击固定值，魔法固定值，物防固定值，魔防固定值;保留之前的怪
            string gameObjectParameter = this.SkillConf.GameObjectParameter;
            string[] summonParList = gameObjectParameter.Split(';');
            int monsterId = int.Parse(summonParList[0]);
            float range = float.Parse(summonParList[2]);
            int number = int.Parse(summonParList[3]);
            List<int> destoryOldMonsterList = new List<int>();
            if (summonParList.Length >= 7)
            {
                string[] monsterids = summonParList[6].Split(",");
                for (int i = 0; i < monsterids.Length; i++)
                {
                    if (!ComHelp.IfNull(monsterids[i]))
                    {
                        destoryOldMonsterList.Add( int.Parse(monsterids[i]) );
                    }
                }
            }

            if (destoryOldMonsterList.Count > 0)
            {
                List<Unit> entities = theUnitFrom.GetParent<UnitComponent>().GetAll();
                for (int i = entities.Count - 1; i >= 0; i--)
                {
                    Unit uu = entities[i];
                    if (uu.Type == UnitType.Monster && destoryOldMonsterList.Contains(uu.ConfigId) && uu.MasterId == theUnitFrom.Id)
                    {
                        uu.GetComponent<HeroDataComponent>().OnDead(null);
                        unitInfoComponent.ZhaohuanIds.Remove(uu.Id);
                    }
                }
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

                Unit unitMonster = UnitFactory.CreateMonster(theUnitFrom.DomainScene(), monsterId, initPosi, new CreateMonsterInfo()
                { Camp = theUnitFrom.GetBattleCamp(), MasterID = theUnitFrom.Id, AttributeParams = summonParList[1] + ";"+ summonParList[4] + ";" + summonParList[5] });
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
