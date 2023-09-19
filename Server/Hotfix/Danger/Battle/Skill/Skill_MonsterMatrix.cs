using UnityEngine;

namespace ET
{

    //创建怪物矩阵
    public class Skill_MonsterMatrix : SkillHandler
    {
        //初始化
        public override void OnInit(SkillInfo skillId, Unit theUnitFrom)
        {
            this.BaseOnInit(skillId, theUnitFrom);
        }

        public override void OnExecute()
        {
            string gameObjectParameter = this.SkillConf.GameObjectParameter;
            //召唤ID；是否复刻玩家形象（0不是，1是）；行数量，列数量；行间距，列间距；血量比例,攻击比例,魔法比例,物防比例，魔防比例；血量固定值,攻击固定值，魔法固定值，物防固定值，魔防固定值
            //'90000001;1;3,4;1,1;0.5,0.5,0.5,0.5,0.5;0,0,0,0,0
            //'90000101;0;3,4;2,2;0.5,0.5,0.5,0.5,0.5;0,0,0,0,0
            Log.Console($" {gameObjectParameter} {this.TargetPosition.x}  {this.TargetPosition.z}");
            string[] summonParList = gameObjectParameter.Split(';');

            int monsterId = int.Parse(summonParList[0]);

            int rowNumber = int.Parse(summonParList[2].Split(',')[0]);
            int columnNumber = int.Parse(summonParList[2].Split(',')[1]);

            float rowSpace = float.Parse(summonParList[3].Split(',')[0]);
            float columnSpace = float.Parse(summonParList[3].Split(',')[1]);

            //以this.TargetPosition 为中心  计算坐标点 创建怪物矩形UnitFactory.CreateMonster
            //矩形需要根据TargetAngle旋转
            int centerX = rowNumber / 2;
            int centerZ = columnNumber / 2;
            for (int x = 0; x < rowNumber; x++)
            {
                for (int z = 0; z < columnNumber; z++)
                {
                    float newX = this.TargetPosition.x + (x - centerX) * rowSpace;     
                    float newZ = this.TargetPosition.z + (z - centerZ) * columnSpace; 
                    Vector3 createVector3 = new Vector3(newX, this.TargetPosition.y, newZ);
                    Unit unit = UnitFactory.CreateMonster(this.TheUnitFrom.DomainScene(), monsterId, createVector3,
                        new CreateMonsterInfo()
                        {
                            Camp = this.TheUnitFrom.GetBattleCamp(),
                            MasterID = this.TheUnitFrom.Id,
                            AttributeParams = summonParList[1] + ";" + summonParList[4] + ";" + summonParList[5]
                        });
                    this.TheUnitFrom.GetComponent<UnitInfoComponent>().ZhaohuanIds.Add(unit.Id);
                }
            }

            this.OnUpdate();
        }

        public override void OnUpdate()
        {
            this.BaseOnUpdate();
        }

        public override void OnFinished()
        {
            this.Clear();
        }
    }
}
