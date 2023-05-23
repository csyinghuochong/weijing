using System.Collections.Generic;

namespace ET
{

    //持续性伤害
    public class Skill_ComSelfRang_Damge_1 : SkillHandler
    {
     
        public override void OnInit(SkillInfo skillId, Unit theUnitFrom)
        {
            this.BaseOnInit(skillId, theUnitFrom);
            this.SkillTriggerInvelTime = (long)(float.Parse(SkillConf.GameObjectParameter) * 1000);
            OnExecute();
        }

        public override void OnExecute()
        {
            this.InitSelfBuff();
            this.BaseOnUpdate();
        }

        public override void OnUpdate()
        {
            this.IsExcuteHurt = false;
            if (this.SkillConf.SkillTargetType == SkillTargetType.SelfFollow)
            {
                this.UpdateCheckPoint(this.TheUnitFrom.Position);
            }

            long curTime = TimeHelper.ServerNow();
            for (int i = HurtIds.Count - 1; i >= 0; i--)
            {
                long unitId = this.HurtIds[i];
                Unit unit = this.TheUnitFrom.Domain.GetComponent<UnitComponent>().Get(unitId);
                if (unit == null || unit.IsDisposed)
                {
                    this.HurtIds.RemoveAt(i);
                    RemoveHurtTime(unitId);
                    continue;
                }

                if (!this.CheckShape(unit.Position))
                {
                    this.HurtIds.RemoveAt(i);
                    RemoveHurtTime(unitId);
                    continue;
                }
                if (!this.LastHurtTimes.ContainsKey(unitId))
                {
                    continue;
                }
           
                if (curTime - this.LastHurtTimes[unitId] >= this.SkillTriggerInvelTime)
                {
                    this.HurtIds.RemoveAt(i);
                    RemoveHurtTime(unitId);
                }
            }

            this.BaseOnUpdate();
            this.CheckChiXuHurt();

            for (int i = HurtIds.Count - 1; i >= 0; i--)
            {
                long unitId = this.HurtIds[i];
                if (!this.LastHurtTimes.ContainsKey(unitId))
                {
                    this.LastHurtTimes.Add(unitId, TimeHelper.ServerNow());
                }
            }
        }

        private void RemoveHurtTime(long unitId)
        {
            if (!this.LastHurtTimes.ContainsKey(unitId))
                return;
            this.LastHurtTimes.Remove(unitId);
        }

        public override void OnFinished()
        {
            this.Clear();
        }
    }
}
