using UnityEngine;

namespace ET
{

    //召唤类型技能
    public class Skill_Com_Summon_1 : SkillHandler
    {
    
        //初始化
        public override void OnInit(SkillInfo skillId, Unit theUnitFrom)
        {
            this.BaseOnInit(skillId, theUnitFrom);

            OnExecute();

            int fubenDifficulty = UnitHelper.GetFubenDifficulty(theUnitFrom);
            //获取参数
            string[] summonParList = SkillConfigCategory.Instance.Get(skillId.WeaponSkillID).GameObjectParameter.Split('@');
            for (int y = 0; y < summonParList.Length; y++) {

                string[] skillParList = summonParList[y].Split(';');
                int createMonsterID = int.Parse(skillParList[0]);
                if (!MonsterConfigCategory.Instance.Contain(createMonsterID))
                {
                    Log.Debug($"config==null  monsterid {createMonsterID}");
                    break;
                }

                //触发召唤
                string[] vec3Str = skillParList[1].Split(',');

                for (int i = 0; i < int.Parse(skillParList[2]); i++)
                {
                    //随机坐标
                    float rangValue = float.Parse(skillParList[3]);
                    float ran_x = Function_Role.GetInstance().ReturnRamdomValue_Float(0, rangValue) - rangValue / 2;
                    float ran_z = Function_Role.GetInstance().ReturnRamdomValue_Float(0, rangValue) - rangValue / 2;

                    //获取追踪目标点
                    Vector3 initPosi = new Vector3();

                    if (vec3Str.Length >= 3)
                    {
                        //设置坐标点
                        initPosi = new Vector3(float.Parse(vec3Str[0]) + ran_x, float.Parse(vec3Str[1]), float.Parse(vec3Str[2]) + ran_z);
                    }
                    else
                    {
                        //创建在自己脚下
                        initPosi = new Vector3(theUnitFrom.Position.x + ran_x, theUnitFrom.Position.y, theUnitFrom.Position.z + ran_z); ;
                    }

                    //创建怪物
                    Unit unit = UnitFactory.CreateMonster(theUnitFrom.DomainScene(), createMonsterID, initPosi,  new CreateMonsterInfo()
                    { Camp = theUnitFrom.GetBattleCamp()});
                    theUnitFrom.GetComponent<UnitInfoComponent>().ZhaohuanIds.Add(unit.Id);
                }
            }
        }

        //退出
        public override void OnExecute()
        {
        }

        public override void OnUpdate()
        {
            this.BaseOnUpdate();
        }

        public override void OnFinished()
        {
            
        }
    }
}
