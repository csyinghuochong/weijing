using System.Collections.Generic;

namespace ET
{
    //光环2
    public class Skill_Halo_2 : SkillHandler
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

        public void Check_Map()
        {
            List<Unit> entities = this.TheUnitFrom.DomainScene().GetComponent<UnitComponent>().GetAll();
            for (int i = entities.Count - 1; i >= 0; i--)
            {
                Unit unit = entities[i];
                if (unit == null || unit.IsDisposed)
                {
                    continue;
                }
                if (this.HurtIds.Contains(unit.Id))
                {
                    continue;
                }

                if (unit.GetTeamId() != this.TheUnitFrom.GetTeamId())
                {
                    continue;
                }

                this.HurtIds.Add(unit.Id);
                this.OnCollisionUnit(unit);
            }
        }

        public void Check_Sight()
        { 
            
        }

        public override void OnUpdate()
        {
            this.BaseOnUpdate();
            
            this.CheckChiXuHurt();

            //this.UpdateCheckPoint(this.TheUnitFrom.Position);
        }

        public override void OnFinished()
        {
            this.Clear();
        }

    }
}
