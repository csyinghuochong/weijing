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
        }

        
        public override void OnExecute()
        {
            Unit theUnitFrom = this.TheUnitFrom;
            //获取参数
            UnitInfoComponent unitInfoComponent = theUnitFrom.GetComponent<UnitInfoComponent>();
            if (unitInfoComponent.GetZhaoHuanNumber() >= 100)
            {
                return;
            }
            this.InitSelfBuff();
            //70009001;0;1;1
            string[] summonParList = SkillConfigCategory.Instance.Get(this.SkillInfo.WeaponSkillID).GameObjectParameter.Split('@');
            for (int y = 0; y < summonParList.Length; y++)
            {
                string[] skillParList = summonParList[y].Split(';');
                int createMonsterID = int.Parse(skillParList[0]);
                if (!MonsterConfigCategory.Instance.Contain(createMonsterID))
                {
                    Log.Error($"config==null  monsterid {createMonsterID}");
                    break;
                }

                //触发召唤
                string[] vec3Str = skillParList[1].Split(',');

                if(int.Parse(skillParList[2]) > 100)
                {
                    Log.Error($"skillParList[2]) > 100 {this.SkillInfo.WeaponSkillID}");
                    break;
                }
                
                int maxNum = MonsterConfigCategory.Instance.Get(createMonsterID).SummonLimit;
                UnitComponent unitComponent = theUnitFrom.GetParent<UnitComponent>();
                for (int i = 0; i < int.Parse(skillParList[2]); i++)
                {
                    int haveNum = 0;
                    long haveId = 0;
                    foreach (long id in unitInfoComponent.ZhaohuanIds)
                    {
                        Unit uu = unitComponent.Get(id);
                        if (uu == null || uu.ConfigId != createMonsterID)
                        {
                            continue;
                        }

                        if (haveNum == 0)
                        {
                            haveId = id;
                        }

                        haveNum++;
                    }
                    
                    if (haveNum >= maxNum)
                    {
                        Unit uu = unitComponent.Get(haveId);
                        if (uu != null && uu.Type == UnitType.Monster)
                        {
                            uu.GetComponent<HeroDataComponent>().OnDead(null);
                            unitInfoComponent.ZhaohuanIds.Remove(uu.Id);
                        }
                    }

                    //随机坐标
                    float rangValue = float.Parse(skillParList[3]);
                    float ran_x = Function_Role.GetInstance().ReturnRamdomValue_Float(0, rangValue) - rangValue / 2;
                    float ran_z = Function_Role.GetInstance().ReturnRamdomValue_Float(0, rangValue) - rangValue / 2;

                    //获取追踪目标点
                    Vector3 initPosi = Vector3.zero;
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
                    Unit unit = UnitFactory.CreateMonster(theUnitFrom.DomainScene(), createMonsterID, initPosi, new CreateMonsterInfo()
                    { Camp = theUnitFrom.GetBattleCamp(), MasterID = theUnitFrom.Id });
                    unitInfoComponent.ZhaohuanIds.Add(unit.Id);
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
