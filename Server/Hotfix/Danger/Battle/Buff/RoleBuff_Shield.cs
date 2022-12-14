namespace ET
{
    public class RoleBuff_Shield : BuffHandler
    {
        public override void OnInit(BuffData buffData, Unit theUnitFrom, Unit theUnitBelongto, SkillHandler skillHandler = null)
        {
            this.OnBaseBuffInit(buffData,  theUnitFrom,  theUnitBelongto);

            NumericComponent numericComponent = this.TheUnitBelongto.GetComponent<NumericComponent>();
            int maxHp = numericComponent.GetAsInt(NumericType.Now_MaxHp);
            //1百分比 2固定伤害
            int totalValue = 0;
            if (buffData.BuffConfig.buffParameterType == 1)
            {
                numericComponent.ApplyValue(NumericType.Now_Shield_HP, (int)buffData.BuffConfig.buffParameterValue * theUnitFrom.GetComponent<NumericComponent>().GetAsLong(NumericType.Now_Hp), true);
                totalValue = (int)(maxHp * 1f * buffData.BuffConfig.buffParameterValue);
            }
            else
            {
                totalValue = (int)buffData.BuffConfig.buffParameterValue;
            }
            numericComponent.ApplyValue(NumericType.Now_Shield_HP, totalValue, true);
            numericComponent.ApplyValue(NumericType.Now_Shield_MaxHP, totalValue, true);
            numericComponent.Set(NumericType.Now_Shield_DamgeCostPro, buffData.BuffConfig.DamgePro, false);
            this.OnUpdate();
        }

        public override void OnUpdate()
        {
            NumericComponent numericComponent = this.TheUnitBelongto.GetComponent<NumericComponent>();

            if (numericComponent.GetAsLong(NumericType.Now_Shield_HP) <= 0)
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
            NumericComponent numericComponent = this.TheUnitBelongto.GetComponent<NumericComponent>();
            numericComponent.ApplyValue(NumericType.Now_Shield_HP, 0);
        }
    }
}
