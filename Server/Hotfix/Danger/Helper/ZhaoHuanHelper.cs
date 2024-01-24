using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public static class ZhaoHuanHelper
    {
        public static void DeadCreateZhaoHuan(EventType.NumericChangeEvent args)
        {
            // 攻击者创建召唤怪。属性也是复制攻击者
            // '1;90000102;1;1;1;0.5,0.5,0.5,0.5,0.5;0,0,0,0,0;5
            // 时间间隔；召唤ID,召唤ID(随机从中召唤一个)；是否复刻玩家形象（0不是，1是）；范围；数量；血量比例,攻击比例,魔法比例,物防比例，魔防比例；血量固定值,攻击固定值，魔法固定值，物防固定值，魔防固定值;数量上限
            UnitInfoComponent unitInfoComponentAttack = args.Attack.GetComponent<UnitInfoComponent>();
            if (unitInfoComponentAttack.GetZhaoHuanNumber() >= 100)
            {
                Log.Error("Skill_Com_Summon_5:Error:  死亡召唤数量超过100！！！");
                return;
            }

            SkillConfig skillConfig = SkillConfigCategory.Instance.Get(args.SkillId);
            string gameObjectParameter = skillConfig.GameObjectParameter;
            string[] summonParListold = gameObjectParameter.Split(';');
            string[] summonParList = new string[summonParListold.Length - 1];
            Array.Copy(summonParListold, 1, summonParList, 0, summonParList.Length);

            int monsterId = 0;
            int maxNum = 0;
            List<int> monsterIds = new List<int>();
            try
            {
                foreach (string id in summonParList[0].Split(','))
                {
                    monsterIds.Add(int.Parse(id));
                }

                maxNum = int.Parse(summonParList[6]);
            }
            catch (Exception ex)
            {
                Log.Error("Skill_Com_Summon_5:Error:  ", skillConfig.Id);
                Log.Error(ex.ToString());
                return;
            }

            List<Unit> haved = new List<Unit>();
            List<Unit> all = args.Attack.GetParent<UnitComponent>().GetAll();
            foreach (Unit uu in all)
            {
                if (uu.Type == UnitType.Monster && monsterIds.Contains(uu.ConfigId) && uu.MasterId == args.Attack.Id)
                {
                    haved.Add(uu);
                }
            }

            if (haved.Count + 1 > maxNum)
            {
                int de = haved.Count + 1 - maxNum;
                while (de > 0 && haved.Count > 0)
                {
                    Unit uu = haved[0];
                    haved.Remove(uu);
                    uu.GetComponent<HeroDataComponent>().OnDead(null);
                    unitInfoComponentAttack.ZhaohuanIds.Remove(uu.Id);
                    --de;
                }
            }

            monsterId = monsterIds[RandomHelper.RandomNumber(0, monsterIds.Count)];
            Unit unitMonster = UnitFactory.CreateMonster(args.Attack.DomainScene(), monsterId, args.Defend.Position,
                new CreateMonsterInfo()
                {
                    Camp = args.Attack.GetBattleCamp(),
                    MasterID = args.Attack.Id,
                    AttributeParams = summonParList[1] + ";" + summonParList[4] + ";" + summonParList[5]
                });
            unitInfoComponentAttack.ZhaohuanIds.Add(unitMonster.Id);
        }
    }
}