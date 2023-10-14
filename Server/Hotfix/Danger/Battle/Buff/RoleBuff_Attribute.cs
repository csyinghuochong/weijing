using System.Collections.Generic;
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
            NumericComponent heroCom = this.TheUnitBelongto.GetComponent<NumericComponent>();
            if (heroCom == null)
            {
                Log.Warning("RoleBuff_Attribute.heroCom == null");
                this.BuffState = BuffState.Finished;
                return;
            }

            this.PassTime = TimeHelper.ServerNow() - this.BeginTime;
            //执行buff
            if (!this.IsTrigger && this.PassTime >= this.DelayTime)
            {
                this.IsTrigger = true;
                this.buffSetProperty(heroCom);
            }

            //buff是否为循环触发的
            if (this.InterValTime > 0 )
            {
                this.InterValTimeSum = TimeHelper.ServerNow() - this.InterValTimeSumBegin;
                if (this.InterValTimeSum >= this.InterValTime) 
                {
                    this.InterValTimeSumBegin  = TimeHelper.ServerNow();
                    this.IsTrigger = false;
                }
            }

            //buff执行结束
            if (TimeHelper.ServerNow() >= this.BuffEndTime)
            {
                this.BuffState = BuffState.Finished;
            }
        }


        private void buffSetProperty(NumericComponent heroCom)
        {

            //Log.Info("触发Buff" + this.BuffData.BuffConfig.BuffName);
            switch (this.mBuffConfig.BuffType)
            {
                //属性类buff
                case 1:
                    NowBuffParameterType = this.mBuffConfig.buffParameterType;
                    NowBuffParameterValue = this.mBuffConfig.buffParameterValue + this.GetTianfuProAdd((int)BuffAttributeEnum.AddParameterValue);
                    NowBuffParameterValueType = this.mBuffConfig.buffParameterValueType;
                    
                    int ValueType = this.mBuffConfig.buffParameterValueDef;      //0 表示整数  1表示浮点数
                    NowBuffValue = 0;
                    //乘法算法
                    if (NowBuffParameterValueType != 0)
                    {
                        ValueType = NumericHelp.GetNumericValueType(NowBuffParameterValueType);
                        //临时代吗
                        if (this.mBuffConfig.buffParameterValue < 1 && this.mBuffConfig.buffParameterValueType == 1002)  
                        {
                            ValueType = 1;
                        }

                        if (NowBuffParameterType == 3001 && NowBuffParameterValue > 0f)
                        {
                            //NowBuffParameterValue += heroCom.GetAsFloat(NumericType.Now_ShenNongPro);
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
                        //神农属性额外处理
                        NowBuffValue = NowBuffValue * (1f + heroCom.GetAsFloat(NumericType.Now_ShenNongPro) + heroCom.GetAsFloat(NumericType.Now_ShenNongProNoFight));
                        int nowdamgeType = 2;
                        if (NowBuffValue < 0)
                        {
                            nowdamgeType = 0;
                        }
                        heroCom.ApplyChange(TheUnitFrom, NumericType.Now_Hp, (long)NowBuffValue, 0, true, nowdamgeType);
                    }
                    else if (NowBuffParameterType == 3129)
                    {
                        heroCom.ApplyChange(TheUnitFrom, NumericType.TransformId, (int)(this.mBuffConfig.buffParameterValue), 0, true, 0);
                    }
                    else if (NowBuffParameterType == 3134)
                    {
                        heroCom.ApplyChange(TheUnitFrom, NumericType.SkillUseMP, (long)NowBuffValue, 0, true, 0);
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
                    NowBuffParameterType = this.mBuffConfig.buffParameterType;
                    long sta = (1 << NowBuffParameterType);
                    this.TheUnitBelongto.GetComponent<StateComponent>().StateTypeAdd(sta);
                    break;

                case 3: //释放技能 
                    //buff來源者再次釋放技能
                    if (!this.TheUnitFrom.IsDisposed)
                    {
                        C2M_SkillCmd cmd = new C2M_SkillCmd();
                        cmd.SkillID = this.mBuffConfig.buffParameterType;
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
                    }
                    break;
                case 4:
                    this.TheUnitBelongto.GetComponent<SkillPassiveComponent>().AddRolePassiveSkill(this.mBuffConfig.buffParameterType);
                    break;
                case 5:  //驱散
                    //(buffParameterValue2  ) 需要提前解析要移除的buffid。拓展SkillBuffConfig 放在ConfigPartial
                    List<int> relieveBuffs = SkillBuffConfigCategory.Instance.GetRelieveBuffs(this.mBuffConfig.Id);
                    if (relieveBuffs != null && relieveBuffs.Count > 0)
                    {
                        foreach (int buffId in relieveBuffs)
                        {
                            this.TheUnitBelongto.GetComponent<BuffManagerComponent>().BuffRemove(buffId);
                        }
                    }
                    break;
                case 6: //一次性技能
                    if (this.TheUnitBelongto.Type == UnitType.Player)
                    {
                        //服务器也做个记录
                        this.TheUnitBelongto.GetComponent<UserInfoComponent>().UpdateRoleData(UserDataType.BuffSkill, this.mBuffConfig.buffParameterType.ToString());
                    }
                    break;
                default: 
                    break; 
            }
        }

        public override void OnFinished()
        {
            if (!this.IsTrigger)
            {
                return;
            }

            //移除相关属性
            switch (this.mBuffConfig.BuffType)
            {
                case 1:
                    //Log.Debug("执行buff移除属性...");
                    if (NowBuffParameterType == 3001)
                    {
                        //血量不进行移除
                    }
                    else if (NowBuffParameterType == 3129)
                    {
                        this.TheUnitBelongto.GetComponent<NumericComponent>().ApplyValue(NowBuffParameterType, 0);
                    }
                    else if (NowBuffParameterType == 3134)
                    {
                        //怒气不进行移除
                    }
                    else
                    {
                        int ValueType = this.mBuffConfig.buffParameterValueDef;      //0 表示整数  1表示浮点数

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

                case 4:
                    this.TheUnitBelongto.GetComponent<SkillPassiveComponent>().RemoveRolePassiveSkill(this.mBuffConfig.buffParameterType);
                    break;

                default:
                    break;
            }
        }
    }
}
