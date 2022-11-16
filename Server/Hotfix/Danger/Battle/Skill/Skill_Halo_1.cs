namespace ET
{
    //光环
    public class Skill_Halo_1 : SkillHandler
    {

        public override void OnInit(SkillInfo skillId, Unit theUnitFrom)
        {
            this.BaseOnInit(skillId, theUnitFrom);
            
            OnExecute();
        }

        public override void OnExecute()
        {
            this.InitSelfBuff();
            this.BaseOnUpdate();
        }

        public override void OnUpdate()
        {
            this.BaseOnUpdate();

            IsTriggerHurt = false;
            this.UpdateCheckPoint();
            for (int i = HurtIds.Count - 1; i >= 0; i--)
            {
                Unit unit = TheUnitFrom.Domain.GetComponent<UnitComponent>().Get(HurtIds[i]);
                if (unit == null || unit.IsDisposed || !unit.IsCanBeAttack())
                {
                    HurtIds.RemoveAt(i);
                    continue;
                }
                if (!this.CheckShape(unit.Position))
                {
                    unit.GetComponent<BuffManagerComponent>().BuffRemove(SkillConf.BuffID[0]);
                    HurtIds.RemoveAt(i);
                    continue;
                }
            }
        }

        public override void OnFinished()
        {
            
        }

    }
}
