using System.Collections.Generic;

namespace ET
{

    //持续性伤害
    public class Skill_ComSelfRang_Damge_1 : SkillHandler
    {
     
        public override void OnInit(SkillInfo skillId, Unit theUnitFrom)
        {
            this.BaseOnInit(skillId, theUnitFrom);

            SkillTriggerInvelTime = (long)(float.Parse(SkillConf.GameObjectParameter) * 1000);
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

            this.IsExcuteHurt = false;
            if (this.SkillConf.SkillTargetType == SkillTargetType.SelfFollow)
            {
                this.UpdateCheckPoint(this.TheUnitFrom.Position);
            }
            long curTime = TimeHelper.ServerNow();
            for (int i = HurtIds.Count - 1; i >= 0; i--)
            {
                long unitId = HurtIds[i];
                Unit unit = TheUnitFrom.Domain.GetComponent<UnitComponent>().Get(unitId);
                if (unit == null || unit.IsDisposed)
                {
                    HurtIds.RemoveAt(i);
                    RemoveHurtTime(unitId);
                    continue;
                }

                if (!this.CheckShape(unit.Position))
                {
                    HurtIds.RemoveAt(i);
                    RemoveHurtTime(unitId);
                    continue;
                }

                if (!LastHurtTimes.ContainsKey(unitId))
                {
                    LastHurtTimes.Add(unitId, TimeHelper.ServerNow());
                }

                if (curTime - LastHurtTimes[unitId] > SkillTriggerInvelTime)
                {
                    HurtIds.RemoveAt(i);
                    RemoveHurtTime(unitId);
                }
            }

            this.CheckChiXuHurt();
        }

        private void RemoveHurtTime(long unitId)
        {
            if (!LastHurtTimes.ContainsKey(unitId))
                return;
            LastHurtTimes.Remove(unitId);
        }

        public override void OnFinished()
        {
            this.Clear();
        }
    }
}
