using System;
using System.Collections.Generic;

namespace ET
{

    [Timer(TimerType.BuffTimer)]
    public class BuffTimer : ATimer<BuffManagerComponent>
    {
        public override void Run(BuffManagerComponent self)
        {
            try
            {
                self.Check();
            }
            catch (Exception e)
            {
                Log.Error($"move timer error: {self.Id}\n{e}");
            }
        }
    }

    [ObjectSystem]
    public class BuffManagerComponentAwakeSystem : AwakeSystem<BuffManagerComponent>
    {
        public override void Awake(BuffManagerComponent self)
        {
            self.Type = self.GetParent<Unit>().Type;
        }
    }

    [ObjectSystem]
    public class BuffManagerComponentDestroySystem : DestroySystem<BuffManagerComponent>
    {
        public override void Destroy(BuffManagerComponent self)
        {
            for (int i = self.m_Buffs.Count - 1; i >= 0; i--)
            {
                BuffHandler buffHandler = self.m_Buffs[i];
                ObjectPool.Instance.Recycle(buffHandler);
                self.m_Buffs.RemoveAt(i);
            }
            TimerComponent.Instance?.Remove(ref self.Timer);
        }
    }

    public static class BuffManagerComponetSystem
    {

        public static bool HaveBuff(this BuffManagerComponent self, int buffId)
        {
            for (int i = self.m_Buffs.Count - 1; i >= 0; i--)
            {
                if (self.m_Buffs[i].BuffData.BuffConfig.Id == buffId)
                {
                    return true;
                }
            }
            return false;
        }

        public static void BuffRemove(this BuffManagerComponent self, int buffId)
        {
            //判断玩家身上是否有相同的buff,如果有就注销此Buff
            List<BuffHandler> nowAllBuffList = self.m_Buffs;
            for (int i = nowAllBuffList.Count - 1; i >=0 ; i--)
            {
                if (nowAllBuffList[i].BuffData.BuffConfig.Id == buffId)
                {
                    //移除目标buff
                    nowAllBuffList[i].BuffState = BuffState.Finished;
                    ObjectPool.Instance.Recycle(nowAllBuffList[i]);
                    nowAllBuffList[i].OnFinished();
                    self.m_Buffs.RemoveAt(i);
                }
            }

            MessageHelper.Broadcast(self.GetParent<Unit>(), new M2C_UnitBuffUpdate() { UnitIdBelongTo = self.GetParent<Unit>().Id, BuffID = buffId, BuffOperateType = 2 });
        }

        public static void BulletFactory(this BuffManagerComponent self, BuffData buffData, Unit from, SkillHandler skillHandler)
        {
            Unit to = self.GetParent<Unit>();
            BuffHandler buffHandler = (BuffHandler)ObjectPool.Instance.Fetch(BuffDispatcherComponent.Instance.BuffTypes[buffData.BuffClassScript]);
            buffHandler.OnInit(buffData, from, to, skillHandler);
            self.m_Buffs.Insert(0, buffHandler);     //添加至buff列表中

            self.AddTimer();
        }

        public static void AddTimer(this BuffManagerComponent self)
        {
            if (self.Timer == 0)
            {
                self.Timer = TimerComponent.Instance.NewRepeatedTimer(200, TimerType.BuffTimer, self);
            }
        }

        public static void BuffFactory(this BuffManagerComponent self, BuffData buffData, Unit from, SkillHandler skillHandler, bool notice = true)
        {
            Unit unit =self.GetParent<Unit>();
            float now_DiKangPro = unit.GetComponent<NumericComponent>().GetAsFloat(NumericType.Now_DiKangPro);
            if (RandomHelper.RandFloat01() < now_DiKangPro && buffData.BuffConfig.BuffBenefitType == 2)
            {
                return;
            }
            StateComponent stateComponent = unit.GetComponent<StateComponent>();
            if (stateComponent.StateTypeGet( StateTypeEnum.SilenceImmune) && buffData.BuffConfig.buffParameterType == StateTypeEnum.Silence)
            {
                return;
            }
            if (stateComponent.StateTypeGet(StateTypeEnum.DizzinessImmune) && buffData.BuffConfig.buffParameterType == StateTypeEnum.Dizziness)
            {
                return;
            }

            int addBufStatus = 1;   //1新增buff  2 移除 3 重置 4同状态返回
            BuffHandler buffHandler = null;
            List<BuffHandler> nowAllBuffList = self.m_Buffs;
            for (int i = nowAllBuffList.Count - 1; i >=0 ; i--)
            {
                bool remove = false;
                buffHandler = nowAllBuffList[i];
                SkillBuffConfig tempBuffConfig = buffHandler.BuffData.BuffConfig;
                if (tempBuffConfig.Id == buffData.BuffConfig.Id && buffData.BuffConfig.BuffAddClass == 0)
                {
                    remove = true;
                }

                //操作同状态的Buff
                if (tempBuffConfig.BuffType == 2 && tempBuffConfig.BuffType == buffData.BuffConfig.BuffType
                    && tempBuffConfig.buffParameterType == buffData.BuffConfig.buffParameterType)   
                {
                    long newEndTime = TimeHelper.ServerNow() + buffData.BuffConfig.BuffTime;
                    if (newEndTime < buffHandler.BuffEndTime)
                    {
                        addBufStatus = 4;
                    }
                }

                if (remove)
                {
                    MessageHelper.Broadcast(self.GetParent<Unit>(), new M2C_UnitBuffUpdate() { UnitIdBelongTo = unit.Id, BuffID = tempBuffConfig.Id, BuffOperateType = 2 });
                    buffHandler.BuffState = BuffState.Finished;
                    ObjectPool.Instance.Recycle(buffHandler);
                    buffHandler.OnFinished();
                    self.m_Buffs.RemoveAt(i);
                }
            }

            if (addBufStatus == 4)
            {
                return;
            }
            //添加Buff
            if (addBufStatus == 1)
            {
                buffHandler = (BuffHandler)ObjectPool.Instance.Fetch(BuffDispatcherComponent.Instance.BuffTypes[buffData.BuffClassScript]);
                buffHandler.OnInit(buffData, from, unit, skillHandler);
                self.m_Buffs.Insert(0, buffHandler);     //添加至buff列表中
                self.AddTimer();
            }
            //发送改变属性的相关消息
            //buffData.BuffConfig==null 是子弹之类的buff不广播
            if (notice)
            {
                M2C_UnitBuffUpdate m2C_UnitBuffUpdate = self.m2C_UnitBuffUpdate;
                m2C_UnitBuffUpdate.UnitIdBelongTo = unit.Id;
                m2C_UnitBuffUpdate.BuffID = buffData.BuffConfig.Id;
                m2C_UnitBuffUpdate.BuffOperateType = addBufStatus;
                m2C_UnitBuffUpdate.TargetPostion.Clear();
                m2C_UnitBuffUpdate.TargetPostion.Add(buffHandler.TargetPosition.x);
                m2C_UnitBuffUpdate.TargetPostion.Add(buffHandler.TargetPosition.y);
                m2C_UnitBuffUpdate.TargetPostion.Add(buffHandler.TargetPosition.z);
                if (unit.GetComponent<AOIEntity>() == null)
                {
                    Log.Error($"unit.GetComponent<AOIEntity>() == null  {unit.Type}");
                    return;
                }
                MessageHelper.Broadcast(unit, m2C_UnitBuffUpdate);
            }
        }

        public static void Check(this BuffManagerComponent self)
        {
            for (int i = self.m_Buffs.Count - 1; i >= 0; i--)
            {
                if (self.m_Buffs.Count == 0)
                {
                    Log.Debug($"BuffManager: self.Type: {self.Type} intanceid :{self.InstanceId} timerId: {self.Timer}");
                    break;
                }

                if (self.m_Buffs[i].BuffState == BuffState.Finished)
                {
                    BuffHandler buffHandler = self.m_Buffs[i];
                    ObjectPool.Instance.Recycle(buffHandler);
                    buffHandler.OnFinished();
                    self.m_Buffs.RemoveAt(i);
                    continue;
                }
                self.m_Buffs[i].OnUpdate();
            }
            if (self.m_Buffs.Count == 0)
            {
                self.Buffs.Clear();
                TimerComponent.Instance?.Remove(ref self.Timer);
            }
        }

        public static void InitBuff(this BuffManagerComponent self)
        {
            UnitInfoComponent unitInfoComponent = self.GetParent<Unit>().GetComponent<UnitInfoComponent>();
            for (int i = 0; i < unitInfoComponent.Buffs.Count; i++)
            {
                BuffData buffData_1 = new BuffData();
                buffData_1.BuffConfig = SkillBuffConfigCategory.Instance.Get(unitInfoComponent.Buffs[i].KeyId);
                buffData_1.BuffClassScript = buffData_1.BuffConfig.BuffScript;
                buffData_1.BuffEndTime = long.Parse(unitInfoComponent.Buffs[i].Value2);
                self.BuffFactory(buffData_1, self.GetParent<Unit>(), null, true);
            }
            unitInfoComponent.Buffs.Clear();
        }

        public static List<KeyValuePair> GetMessageBuff(this BuffManagerComponent self)
        {
            self.Buffs.Clear();
            for (int i = 0; i < self.m_Buffs.Count; i++)
            {
                BuffHandler buffHandler = self.m_Buffs[i];
                if (buffHandler.BuffData.BuffConfig == null)
                {
                    continue;
                }
                self.Buffs.Add(new KeyValuePair() { KeyId = buffHandler.BuffData.BuffConfig.Id, Value2 = buffHandler.BuffEndTime.ToString() });
            }
            return self.Buffs;
        }

        public static void BeforeTransfer(this BuffManagerComponent self)
        {
            UnitInfoComponent unitInfoComponent = self.GetParent<Unit>().GetComponent<UnitInfoComponent>();
            unitInfoComponent.Buffs.Clear();
            for (int i = 0; i < self.m_Buffs.Count; i++)
            {
                BuffHandler buffHandler = self.m_Buffs[i];
                buffHandler.OnFinished();
                if (buffHandler.BuffData.BuffConfig.Transfer != 1)
                {
                    continue;
                }
                unitInfoComponent.Buffs.Add(new KeyValuePair() { KeyId = buffHandler.BuffData.BuffConfig.Id, Value2 = buffHandler.BuffEndTime.ToString() });
            }
        }
    }
}