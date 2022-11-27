using UnityEngine;

namespace ET
{

    /// <summary>
    /// 属性类Buff
    /// </summary>
    public class RoleBuff_Attribute : BuffHandler
    {
      
        public override void OnInit(BuffData buffData, Unit theUnitFrom, Unit theUnitBelongto, SkillHandler skillHandler = null)
        {
            this.OnBaseBuffInit(buffData,  theUnitFrom, theUnitBelongto);
            this.InterValTimeSumBegin = TimeHelper.ServerNow();

            this.OnUpdate();
        }

        public override void OnUpdate()
        {
            PassTime = TimeHelper.ServerNow() - this.BeginTime;

            NumericComponent heroCom = this.TheUnitBelongto.GetComponent<NumericComponent>();
            if (heroCom == null)
            {
                this.BuffState = BuffState.Finished;
                return;
            }

            //执行buff
            if (!IsTrigger && PassTime >= DelayTime)
            {
                IsTrigger = true;
                buffSetProperty();
            }

            //buff是否为循环触发的
            if (InterValTime > 0 )
            {
                InterValTimeSum = TimeHelper.ServerNow() - this.InterValTimeSumBegin;
                if (InterValTimeSum >= InterValTime) {
                    this.InterValTimeSumBegin  = TimeHelper.ServerNow();
                    IsTrigger = false;
                }
            }

            //buff执行结束
            if (TimeHelper.ServerNow() > this.BuffEndTime)
            {
                this.BuffState = BuffState.Finished;
            }
        }

        private void buffSetProperty()
        {

            //Log.Info("触发Buff" + this.BuffData.BuffConfig.BuffName);

            switch (this.BuffData.BuffConfig.BuffType)
            {
                //属性类buff
                case 1:
                    NumericComponent heroCom = this.TheUnitBelongto.GetComponent<NumericComponent>();
                    NowBuffParameterType = this.BuffData.BuffConfig.buffParameterType;
                    NowBuffParameterValue = this.BuffData.BuffConfig.buffParameterValue + this.GetTianfuProAdd((int)BuffAttributeEnum.AddParameterValue);
                    NowBuffParameterValueType = this.BuffData.BuffConfig.buffParameterValueType;
                    
                    int ValueType = this.BuffData.BuffConfig.buffParameterValueDef;      //0 表示整数  1表示浮点数
                    NowBuffValue = 0;
                    //乘法算法
                    if (NowBuffParameterValueType != 0)
                    {
                        ValueType = NumericHelp.GetNumericValueType(NowBuffParameterValueType);
                        //临时代吗
                        if (this.BuffData.BuffConfig.buffParameterValue < 1 && this.BuffData.BuffConfig.buffParameterValueType == 1002)  
                        {
                            ValueType = 1;
                        }

                        if (NowBuffParameterType == 3001 && NowBuffParameterValue > 0f)
                        {
                            NowBuffParameterValue += heroCom.GetAsFloat(NumericType.Now_ShenNongPro);
                        }

                        //取整数
                        if (ValueType == 1)
                        {
                            NowBuffValue = heroCom.GetAsLong(NowBuffParameterValueType) * NowBuffParameterValue;
                        }

                        //取浮点数
                        if (ValueType == 2)
                        {
                            NowBuffValue = heroCom.GetAsFloat(NowBuffParameterValueType) * NowBuffParameterValue;
                        }
                    }
                    else
                    {

                        //加法算法
                        NowBuffValue = NowBuffParameterValue;
                    }

                    if (NowBuffParameterType == 3001)
                    {
                       
                        //血量单独处理
                        this.TheUnitBelongto.GetComponent<NumericComponent>().ApplyChange(TheUnitFrom, NumericType.Now_Hp, (long)NowBuffValue, 0, true, 2);
                    }
                    else
                    {
                        //整数
                        if (ValueType == 0)
                        {
                            this.TheUnitBelongto.GetComponent<HeroDataComponent>().BuffPropertyUpdate_Long(NowBuffParameterType, (long)NowBuffValue);
                        }

                        //浮点数
                        if (ValueType == 1)
                        {
                            this.TheUnitBelongto.GetComponent<HeroDataComponent>().BuffPropertyUpdate_Float(NowBuffParameterType, (float)NowBuffValue);
                        }
                    }
                    break;

                //状态类buff
                case 2:
                    NowBuffParameterType = this.BuffData.BuffConfig.buffParameterType;
                    long sta = (1 << NowBuffParameterType);
                    this.TheUnitBelongto.GetComponent<StateComponent>().StateTypeAdd(sta);
                    break;
                case 3: //释放技能 
                    //buff來源者再次釋放技能
                    C2M_SkillCmd cmd = new C2M_SkillCmd();
                    cmd.SkillID = this.BuffData.BuffConfig.buffParameterType;
                    cmd.TargetID = this.TheUnitBelongto.Id;
                    Vector3 direction = this.TheUnitBelongto.Position - this.TheUnitFrom.Position;
                    float ange = Mathf.Rad2Deg(Mathf.Atan2(direction.x, direction.z));
                    if (direction == Vector3.zero)
                    {
                        cmd.TargetAngle = (int)Quaternion.QuaternionToEuler(this.TheUnitBelongto.Rotation).y;
                    }
                    else
                    {
                        cmd.TargetAngle = Mathf.FloorToInt(ange);
                    }
                    cmd.TargetDistance = Vector3.Distance(this.TheUnitBelongto.Position, this.TheUnitFrom.Position);
                    this.TheUnitFrom.GetComponent<SkillManagerComponent>().OnUseSkill(cmd, true);
                    break;
            }
        }

        public override void OnFinished()
        {
            //移除相关属性
            switch (this.BuffData.BuffConfig.BuffType)
            {
                case 1:
                    //Log.Debug("执行buff移除属性...");
                    if (NowBuffParameterType != 3001)       //血量不进行移除
                    {
                        int ValueType = this.BuffData.BuffConfig.buffParameterValueDef;      //0 表示整数  1表示浮点数

                        //整数
                        if (ValueType == 0)
                        {
                            this.TheUnitBelongto.GetComponent<HeroDataComponent>().BuffPropertyUpdate_Long(NowBuffParameterType, (long)NowBuffValue * -1);
                        }

                        //浮点数
                        if (ValueType == 1)
                        {
                            this.TheUnitBelongto.GetComponent<HeroDataComponent>().BuffPropertyUpdate_Float(NowBuffParameterType, (float)NowBuffValue * -1);
                        }
                    }
                    break;

                case 2:
                    this.TheUnitBelongto.GetComponent<StateComponent>().StateTypeRemove(1<<NowBuffParameterType);
                    break;
            }
        }
    }
}
