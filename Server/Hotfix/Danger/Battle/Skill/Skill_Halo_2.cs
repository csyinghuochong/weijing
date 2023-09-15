using System.Collections.Generic;

namespace ET
{
    //光环2
    public class Skill_Halo_2 : SkillHandler
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

        public void Check_Map( )
        {
            List<Unit> entities = this.TheUnitFrom.DomainScene().GetComponent<UnitComponent>().GetAll();
            for (int i = 0; i < entities.Count; i++)
            {
                if (this.TheUnitFrom.IsSameTeam(entities[i]))
                {
                    this.OnCollisionUnit(entities[i]);
                }
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
