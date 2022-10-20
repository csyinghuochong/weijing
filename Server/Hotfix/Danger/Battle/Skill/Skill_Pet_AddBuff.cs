using System.Collections.Generic;

namespace ET
{

    //给主人(宠物)加Buff
    public class Skill_Pet_AddBuff : SkillHandler
    {

        public override void OnInit(SkillInfo skillId, Unit theUnitFrom)
        {
            this.BaseOnInit(skillId, theUnitFrom);

            OnExecute();
        }

        public Unit GetPetOrMaster()
        {
            if (this.TheUnitFrom.Type == UnitType.Pet)
            {
                long unitid = this.TheUnitFrom.GetComponent<NumericComponent>().GetAsLong(NumericType.MasterId);
                return this.TheUnitFrom.GetParent<UnitComponent>().Get(unitid);
            }
            else if (this.TheUnitFrom.Type == UnitType.Player)
            {
                RolePetInfo rolePetInfo = this.TheUnitFrom.GetComponent<PetComponent>().GetFightPet();
                return rolePetInfo == null ? null : this.TheUnitFrom.GetParent<UnitComponent>().Get(rolePetInfo.Id);
            }
            return null;
        }

        public override void OnExecute()
        {
            Unit other = GetPetOrMaster();

            //触发初始化BUFF
            if (SkillConf.InitBuffID[0] != 0)
            {
                for (int y = 0; y < SkillConf.InitBuffID.Length; y++)
                {
                    this.SkillBuff(SkillConf.InitBuffID[y], TheUnitFrom);
                    this.SkillBuff(SkillConf.InitBuffID[y], other);
                }
            }

            SkillSetComponent skillSetComponent = TheUnitFrom.GetComponent<SkillSetComponent>();
            List<int> buffInitAdd = skillSetComponent != null ? skillSetComponent.GetBuffInitIdAdd(SkillConf.Id) : null;
            if (buffInitAdd != null)
            {
                for (int i = 0; i < buffInitAdd.Count; i++)
                {
                    this.SkillBuff(buffInitAdd[i], TheUnitFrom);
                    this.SkillBuff(buffInitAdd[i], other);
                }
            }
        }

        public override void OnUpdate()
        {
            this.BaseOnUpdate();
        }

        public override void OnFinished()
        {

        }

    }
}
