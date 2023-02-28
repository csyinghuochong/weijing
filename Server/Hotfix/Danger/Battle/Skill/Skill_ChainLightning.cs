namespace ET
{

    //闪电链
    public class Skill_ChainLightning : SkillHandler
    {

        public override void OnInit(SkillInfo skillId, Unit theUnitFrom)
        {
            this.BaseOnInit(skillId, theUnitFrom);
            OnExecute();
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
                PosX = x, PosY = y, PosZ = z
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

            //从目标点最近的位置开始释放闪电链。最多连5米以内的5个单位
            Unit lastTarget = this.TheUnitFrom;
            Unit target = null;
            if (this.HurtIds.Count == 0)
            {
                target = AIHelp.GetNearestEnemy(lastTarget);
                if (target == null ||( target!= null && !this.CheckShape(target.Position)))
                {
                    this.SetSkillState(SkillState.Finished);
                    this.BroadcastSkill(this.TheUnitFrom.Id, 0, this.TargetPosition.x, this.TargetPosition.y, this.TargetPosition.z);
                    return;
                }
            }
            else
            {
                lastTarget = this.TheUnitFrom.DomainScene().GetComponent<UnitComponent>().Get(this.HurtIds[this.HurtIds.Count - 1]);
                if (lastTarget == null)
                {
                    this.SetSkillState(SkillState.Finished);
                    return;
                }
                target = AIHelp.GetNearestUnit(lastTarget, 5f, this.HurtIds, this.TheUnitFrom.Id);
                if (target == null)
                {
                    this.SetSkillState(SkillState.Finished);
                    return;
                }
            }

            if (lastTarget != null && target != null)
            {
                this.HurtIds.Add(target.Id);
                this.OnCollisionUnit(target);
                this.BroadcastSkill(lastTarget.Id, target.Id, 0f,0f,0f);
            }

            if (serverNow > this.SkillEndTime || this.HurtIds.Count >= 5)
            {
                this.SetSkillState(SkillState.Finished);
            }
        }

        public override void OnFinished()
        {
            this.Clear();
        }
    }
}
