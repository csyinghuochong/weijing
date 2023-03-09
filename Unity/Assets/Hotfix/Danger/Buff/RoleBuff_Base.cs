namespace ET
{
    [BuffHandler]
    public class RoleBuff_Base : ABuffHandler
    {
        public override void OnInit(BuffData buffData, Unit theUnitBelongto)
        {
            this.BaseOnBuffInit(buffData,  theUnitBelongto);
            this.OnExecute();

            //if (buffData.BuffConfig.IfShowIconTips == 0)
            //{
            //    return;
            //}
            if (this.TheUnitBelongto.MainHero || this.TheUnitBelongto.IsBoss())
            {
                EventType.BuffUpdate.Instance.Unit = this.TheUnitBelongto;
                EventType.BuffUpdate.Instance.ZoneScene = this.TheUnitBelongto.ZoneScene();
                EventType.BuffUpdate.Instance.ABuffHandler = this;
                EventType.BuffUpdate.Instance.OperateType = 1;
                //EventType.DataUpdate.Instance.DataParams = $"{buffData.BuffConfig.Id}@1";
                EventSystem.Instance.PublishClass(EventType.BuffUpdate.Instance);
            }
        }

        public override void OnExecute()
        {
            EffectInstanceId = this.PlayBuffEffects();
            this.BuffState = BuffState.Running;
        }

        public override void OnReset()
        {
            this.PassTime = 0f;
            this.BuffBeginTime = TimeHelper.ClientNow();
            this.BuffEndTime = TimeHelper.ClientNow() + this.mSkillBuffConf.BuffTime;
            EventType.SkillEffectReset.Instance.Unit = TheUnitBelongto;
            EventType.SkillEffectReset.Instance.EffectInstanceId = this.EffectInstanceId;
            EventSystem.Instance.PublishClass(EventType.SkillEffectReset.Instance);

            //if (this.BuffData.BuffConfig.IfShowIconTips == 0)
            //{
            //    return;
            //}
            if (this.TheUnitBelongto.MainHero || this.TheUnitBelongto.IsBoss())
            {
                EventType.BuffUpdate.Instance.Unit = this.TheUnitBelongto;
                EventType.BuffUpdate.Instance.ZoneScene = this.TheUnitBelongto.ZoneScene();
                EventType.BuffUpdate.Instance.ABuffHandler = this;
                EventType.BuffUpdate.Instance.OperateType = 3;
                EventSystem.Instance.PublishClass(EventType.BuffUpdate.Instance);
            }
        }

        public override void OnUpdate()
        {
            this.BaseOnUpdate();
            if (TimeHelper.ClientNow() > this.BuffEndTime)
            {
                this.BuffState = BuffState.Finished;
            }
        }

        public override void OnFinished()
        {
            EventType.SkillEffectFinish.Instance.EffectInstanceId = this.EffectInstanceId;
            EventType.SkillEffectFinish.Instance.Unit = this.TheUnitBelongto;
            EventSystem.Instance.PublishClass(EventType.SkillEffectFinish.Instance);

            //if (this.BuffData.BuffConfig.IfShowIconTips == 0)
            //{
            //    return;
            //}
            if (this.TheUnitBelongto.MainHero || this.TheUnitBelongto.IsBoss())
            {
                EventType.BuffUpdate.Instance.Unit = this.TheUnitBelongto;
                EventType.BuffUpdate.Instance.ZoneScene = this.TheUnitBelongto.ZoneScene();
                EventType.BuffUpdate.Instance.ABuffHandler = this;
                EventType.BuffUpdate.Instance.OperateType = 2;
                EventSystem.Instance.PublishClass(EventType.BuffUpdate.Instance);
            }
        }
    }
}
