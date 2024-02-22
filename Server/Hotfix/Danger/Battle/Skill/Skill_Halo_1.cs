namespace ET
{
    //光环
    public class Skill_Halo_1 : SkillHandler
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

        public override void OnUpdate()
        {
            this.BaseOnUpdate();

            this.IsExcuteHurt = false;
            this.UpdateCheckPoint(this.TheUnitFrom.Position);
            for (int i = HurtIds.Count - 1; i >= 0; i--)
            {
                Unit unit = this.TheUnitFrom.Domain.GetComponent<UnitComponent>().Get(HurtIds[i]);
                if (unit == null || unit.IsDisposed)
                {
                    HurtIds.RemoveAt(i);
                    continue;
                }
                if (!this.CheckShape(unit.Position))
                {
                    unit.GetComponent<BuffManagerComponent>().BuffRemoveByUnit(0, SkillConf.BuffID[0]);
                    this.HurtIds.RemoveAt(i);
                    continue;
                }
                if (!unit.IsCanBeAttack())
                {
                    this.HurtIds.RemoveAt(i);
                    continue;
                }
            }
            this.CheckChiXuHurt();
        }

        public override void OnFinished()
        {
            this.Clear();
        }

    }
}
