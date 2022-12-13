namespace ET
{
    [BuffHandler]
    public class RoleBuff_Base : ABuffHandler
    {
        public override void OnInit(BuffData buffData, Unit theUnitBelongto)
        {
            this.BaseOnBuffInit(buffData,  theUnitBelongto);
            this.OnExecute();

            if (!this.TheUnitBelongto.MainHero)
            {
                return;
            }
            //if (buffData.BuffConfig.IfShowIconTips == 0)
            //{
            //    return;
            //}
            EventType.DataUpdate.Instance.DataType = DataType.BuffUpdate;
            EventType.DataUpdate.Instance.DataParams = $"{buffData.BuffConfig.Id}@1@{this.BuffEndTime}";
            EventSystem.Instance.PublishClass(EventType.DataUpdate.Instance);
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

            if (!this.TheUnitBelongto.MainHero)
            {
                return;
            }
            //if (this.BuffData.BuffConfig.IfShowIconTips == 0)
            //{
            //    return;
            //}
            EventType.DataUpdate.Instance.DataType = DataType.BuffUpdate;
            EventType.DataUpdate.Instance.DataParams = $"{this.BuffData.BuffConfig.Id}@3";
            EventSystem.Instance.PublishClass(EventType.DataUpdate.Instance);
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

            if (this.BuffData.BuffConfig.IfShowIconTips == 0)
            {
                return;
            }
            if (!this.TheUnitBelongto.MainHero)
            {
                return;
            }
            EventType.DataUpdate.Instance.DataType = DataType.BuffUpdate;
            EventType.DataUpdate.Instance.DataParams = $"{this.BuffData.BuffConfig.Id}@2";
            EventSystem.Instance.PublishClass(EventType.DataUpdate.Instance);
        }
    }
}
