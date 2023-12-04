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
            if (serverNow - this.SkillTriggerLastTime < 500)
            {
                return;
            }
            this.SkillTriggerLastTime = serverNow;

            ///根据范围内敌人数量计算伤害加成
            this.HurtAddPro = 0f;

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
