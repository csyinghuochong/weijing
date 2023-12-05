using System.Collections.Generic;

namespace ET
{

    //闪电链2
    //选中范围释放类型技能。 Skill_ChainLightning2 GameObjectParameter 人数;伤害提升@人数;伤害提升  1;0.1@6;0.3
    //根据人数计算出伤害提升系数 
    public class Skill_ChainLightning_2 : SkillHandler
    {

        public override void OnInit(SkillInfo skillId, Unit theUnitFrom)
        {
            this.BaseOnInit(skillId, theUnitFrom);
        }

        public override void OnExecute()
        {
            this.InitSelfBuff();
            this.OnUpdate();
        }

        public void BroadcastSkill(long unitid, long targetId, float x, float y, float z)
        {
            MessageHelper.Broadcast(this.TheUnitFrom, new M2C_ChainLightning()
            {
                UnitId = unitid,
                TargetID = targetId,
                SkillID = this.SkillInfo.WeaponSkillID,
                PosX = x,
                PosY = y,
                PosZ = z
            });
        }

        public override void OnUpdate()
        {
            long serverNow = TimeHelper.ServerNow();
            if (serverNow < this.SkillExcuteHurtTime)
            {
                return;
            }

            if (!this.IsExcuteHurt)
            {
                this.IsExcuteHurt = true;

                List<Unit> enemyList = new List<Unit>();
                List<Unit> entities = this.TheUnitFrom.GetParent<UnitComponent>().GetAll();

                for (int i = entities.Count - 1; i >= 0; i--)
                {
                    Unit uu = entities[i];

                    //检测目标是否在技能范围
                    if (!this.CheckShape(uu.Position))
                    {
                        continue;
                    }

                    if (!this.TheUnitFrom.IsCanAttackUnit(uu))
                    {
                        continue;
                    }

                    enemyList.Add(uu);
                }

                //1;0.1@6;0.3
                int enemyNumber = enemyList.Count;
                string[] gameparaminfo = this.SkillConf.GameObjectParameter.Split('@');
                for (int i = gameparaminfo.Length - 1; i >= 0; i--)
                {
                    string[] hurtaddInfo = gameparaminfo[i].Split(';');
                    if (int.Parse(hurtaddInfo[0]) >= enemyNumber)
                    {
                        this.HurtAddPro = float.Parse(hurtaddInfo[1]);
                        break;
                    }
                }

                for (int i = 0; i < enemyList.Count; i++)
                {
                    this.OnCollisionUnit(enemyList[i]);
                    this.BroadcastSkill(this.TheUnitFrom.Id, enemyList[i].Id, 0f, 0f, 0f);
                }

                ///根据范围内敌人数量计算伤害加成
                this.HurtAddPro = 0f;

            }

            if (serverNow > this.SkillEndTime || this.HurtIds.Count >= 5)
            {
                this.SetSkillState(SkillState.Finished);
            }

            this.CheckChiXuHurt();
        }

        public override void OnFinished()
        {
            this.Clear();
        }
    }
}
