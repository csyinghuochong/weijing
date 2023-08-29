using System.Collections.Generic;
using UnityEngine;


namespace ET
{

    //范围轰炸
    public class Skill_Range_Bomb_1 : SkillHandler
    {

        private Unit BulletUnit;
        private int TriggeSkillId;

        //初始化
        public override void OnInit(SkillInfo skillId, Unit theUnitFrom)
        {
            this.BaseOnInit(skillId, theUnitFrom);

            //1; 60031162
            string[] paramsinfo = SkillConf.GameObjectParameter.Split(';');
            this.SkillTriggerInvelTime = (long)(float.Parse(paramsinfo[0]) * 1000);
            this.SkillTriggerLastTime = 0;
            this.TriggeSkillId = int.Parse(paramsinfo[1]);  
        }

        public override void OnExecute()
        {
            this.BulletUnit = UnitFactory.CreateBullet(this.TheUnitFrom.DomainScene(), this.TheUnitFrom.Id, this.SkillConf.Id, 0, this.TheUnitFrom.Position, new CreateMonsterInfo()); ;
        }

        public override void OnUpdate()
        {
            this.BaseOnUpdate();

            long servernow = TimeHelper.ServerNow();
            if (servernow - this.SkillTriggerLastTime < this.SkillTriggerInvelTime)
            {
                return;
            }

            this.SkillTriggerLastTime = servernow;
            List<Unit> entities = this.TheUnitFrom.GetParent<UnitComponent>().GetAll();
            for (int i = entities.Count - 1; i >= 0; i--)
            {
                Unit target = entities[i];
                //检测目标是否在技能范围
                if (!this.TheUnitFrom.IsCanAttackUnit(target))
                {
                    continue;
                }
                if (!this.CheckShape(target.Position) )
                {
                    continue;
                }

                Vector3 direction = target.Position - this.BulletUnit.Position;
                float ange = Mathf.Rad2Deg(Mathf.Atan2(direction.x, direction.z));
                C2M_SkillCmd cmd = new C2M_SkillCmd();
                //触发技能
                cmd.TargetID = target.Id;
                cmd.SkillID = this.TriggeSkillId;
                cmd.TargetAngle = Mathf.FloorToInt(ange);
                cmd.TargetDistance = Vector3.Distance(this.BulletUnit.Position, target.Position);
                this.TheUnitFrom.GetComponent<SkillManagerComponent>().OnUseSkill(cmd, false);
            }
        }

        public override void OnFinished()
        {
            //移除Unity
            if (this.BulletUnit != null && !this.BulletUnit.IsDisposed)
            {
                this.BulletUnit.GetParent<UnitComponent>().Remove(BulletUnit.Id);
            }
           
            this.Clear();
        }
    }
}
