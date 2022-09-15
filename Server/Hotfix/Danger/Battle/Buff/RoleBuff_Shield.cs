namespace ET
{
    public class RoleBuff_Shield : BuffHandler
    {
        public override void OnInit(BuffData buffData, Unit theUnitFrom, Unit theUnitBelongto, SkillHandler skillHandler = null)
        {
            this.OnBaseBuffInit(buffData,  theUnitFrom,  theUnitBelongto);

            NumericComponent numericComponent = this.TheUnitBelongto.GetComponent<NumericComponent>();
            this.TheUnitBelongto.GetComponent<StateComponent>().StateTypeAdd(StateTypeEnum.Shield);
            //1百分比 2固定伤害
            numericComponent.ApplyValue(NumericType.Now_Shield_Type, buffData.BuffConfig.buffParameterType,  false);
            if (numericComponent.GetAsLong(NumericType.Now_Shield_Type) == 1)
                numericComponent.Set(NumericType.Now_Shield_HP, buffData.BuffConfig.buffParameterValue);
            else
                numericComponent.ApplyValue( NumericType.Now_Shield_HP, (int)buffData.BuffConfig.buffParameterValue, true);

            this.OnUpdate();
        }

        public override void OnUpdate()
        {
            NumericComponent numericComponent = this.TheUnitBelongto.GetComponent<NumericComponent>();
            if (numericComponent.GetAsLong(NumericType.Now_Shield_Type) == 2 &&  numericComponent.GetAsLong(NumericType.Now_Shield_HP) <= 0)
            {
                this.BuffState = BuffState.Finished;
                return;
            }
            if (TimeHelper.ServerNow() > this.BuffEndTime)
            {
                this.BuffState = BuffState.Finished;
            }
        }

        public override void OnFinished()
        {
            this.TheUnitBelongto.GetComponent<StateComponent>().StateTypeRemove(StateTypeEnum.Shield);
        }
    }
}
