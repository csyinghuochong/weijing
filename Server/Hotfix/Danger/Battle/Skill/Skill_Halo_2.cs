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

        public void Check_Map(Unit teammate)
        {
            this.OnCollisionUnit(teammate);

            RolePetInfo fightId = teammate.GetComponent<PetComponent>().GetFightPet();
            if (fightId != null)
            {
                Unit pet = teammate.GetParent<UnitComponent>().Get(fightId.Id);
                this.OnCollisionUnit(pet);
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
