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
            self.m_Buffs.Clear();
            self.SceneType = self.DomainScene().GetComponent<MapComponent>().SceneTypeEnum;
        }
    }

    [ObjectSystem]
    public class BuffManagerComponentDestroySystem : DestroySystem<BuffManagerComponent>
    {
        public override void Destroy(BuffManagerComponent self)
        {
            self.OnDispose();
        }
    }

    public static class BuffManagerComponentSystem
    {

        public static void OnDispose(this BuffManagerComponent self)
        {
            int buffcnt = self.m_Buffs.Count;
            for (int i = buffcnt - 1; i >= 0; i--)
            {
                BuffHandler buffHandler = self.m_Buffs[i];
                ObjectPool.Instance.Recycle(buffHandler);
                self.m_Buffs.RemoveAt(i);
            }
            TimerComponent.Instance?.Remove(ref self.Timer);
        }

        public static void OnDeadRemoveBuffBy(this BuffManagerComponent self, long unitId)
        {
            int buffcnt = self.m_Buffs.Count;
            for (int i = buffcnt - 1; i >= 0; i--)
            {


                if (self.m_Buffs[i].TheUnitFrom.Id == unitId)
                {
                    self.OnRemoveBuffItem(self.m_Buffs[i]);
                    self.m_Buffs.RemoveAt(i);
                }
            }
        }

        public static void OnRetreatRemoveBuff(this BuffManagerComponent self, long unitId)
        {
            int buffcnt = self.m_Buffs.Count;
            for (int i = buffcnt - 1; i >= 0; i--)
            {
                if (self.m_Buffs[i].TheUnitFrom.Id == unitId)
                {
                    self.OnRemoveBuffItem(self.m_Buffs[i]);
                    self.m_Buffs.RemoveAt(i);
                }
            }
        }

        public static void OnRemoveBuffItem(this BuffManagerComponent self, BuffHandler buffHandler)
        {
            M2C_UnitBuffRemove m2C_UnitBuffUpdate = self.m2C_UnitBuffRemove;
            m2C_UnitBuffUpdate.UnitIdBelongTo = self.GetParent<Unit>().Id;
            m2C_UnitBuffUpdate.BuffID = buffHandler.mBuffConfig.Id;
            MessageHelper.BroadcastBuff(self.GetParent<Unit>(), m2C_UnitBuffUpdate, buffHandler.mBuffConfig, self.SceneType);

            //移除目标buff
            buffHandler.BuffState = BuffState.Finished;
            ObjectPool.Instance.Recycle(buffHandler);
            buffHandler.OnFinished();
        }

        //移除状态的所有buff 
        public static void OnRemoveBuffByState(this BuffManagerComponent self, long state)
        {
            //移除buff要保持倒序移除
            int buffcnt = self.m_Buffs.Count;
            for (int i = buffcnt - 1; i >= 0; i--)
            {
                //判断当前状态是否为暴击状态的buff
                if (self.m_Buffs[i].mBuffConfig.BuffType != 2 )
                {
                    continue;
                }
                long curState = 1 << self.m_Buffs[i].mBuffConfig.buffParameterType;
                if (state == curState)
                {
                    self.OnRemoveBuffItem(self.m_Buffs[i]);
                    self.m_Buffs.RemoveAt(i);
                }
            }
        }

        //移除暴击状态的所有buff 
        public static void OnRemoveBuffCriState(this BuffManagerComponent self)
        {
            //移除buff要保持倒序移除
            int buffcnt = self.m_Buffs.Count;
            for (int i = buffcnt - 1; i >= 0; i--) 
            {
                //判断当前状态是否为暴击状态的buff
                if (self.m_Buffs[i].mBuffConfig.BuffType == 2 && self.m_Buffs[i].mBuffConfig.buffParameterType==13)
                {
                    self.OnRemoveBuffItem(self.m_Buffs[i]);
                    self.m_Buffs.RemoveAt(i);
                }
            }
        }

        public static void OnRevive(this BuffManagerComponent self)
        {
            self.InitBaoShiBuff();
            self.InitDonationBuff();
            self.InitMaoXianJiaBuff();

            //99002003
            BuffData buffData_2 = new BuffData();
            buffData_2.SkillId = 67000278;
            buffData_2.BuffId = 99002003;
            self.BuffFactory(buffData_2, self.GetParent<Unit>(), null);
        }

        public static void OnDead(this BuffManagerComponent self)
        {
            int buffcnt = self.m_Buffs.Count;
            for (int i = buffcnt - 1; i >= 0; i--)
            {
                BuffHandler buffHandler = self.m_Buffs[i];
                buffHandler.OnFinished();
                ObjectPool.Instance.Recycle(buffHandler);
                self.m_Buffs.RemoveAt(i);
            }
            TimerComponent.Instance?.Remove(ref self.Timer);
        }

        public static void BuffRemoveList(this BuffManagerComponent self, List<int> buffIist)
        {
            //判断玩家身上是否有相同的buff,如果有就注销此Buff
            int buffcnt = self.m_Buffs.Count;
            for (int i = buffcnt - 1; i >= 0; i--)
            {
                if (buffIist.Contains(  self.m_Buffs[i].mBuffConfig.Id ) )
                {
                    self.OnRemoveBuffItem(self.m_Buffs[i]);
                    self.m_Buffs.RemoveAt(i);
                }
            }
        }

        /// <summary>
        /// removetype 1移动  2被攻击[目前用来移除沉睡buff]
        /// </summary>
        /// <param name="self"></param>
        /// <param name="removetype"></param>
        public static void BuffRemoveType(this BuffManagerComponent self, int removetype)
        {
            int buffcnt = self.m_Buffs.Count;
            for (int i = buffcnt - 1; i >= 0; i--)
            {
                if (self.m_Buffs[i].mBuffConfig.Remove == removetype)
                {
                    self.OnRemoveBuffItem(self.m_Buffs[i]);
                    self.m_Buffs.RemoveAt(i);
                }
            }
        }

        public static void BuffRemove(this BuffManagerComponent self, int buffId)
        {
            //判断玩家身上是否有相同的buff,如果有就注销此Buff
            int buffcnt = self.m_Buffs.Count;
            for (int i = buffcnt - 1; i >=0 ; i--)
            {
                if (self.m_Buffs[i].mBuffConfig.Id == buffId)
                {
                    self.OnRemoveBuffItem(self.m_Buffs[i]);
                    self.m_Buffs.RemoveAt(i);
                }
            }
        }

        public static void BuffRemoveBySkillid(this BuffManagerComponent self, int skillid)
        {
            //判断玩家身上是否有相同的buff,如果有就注销此Buff
            List<BuffHandler> nowAllBuffList = self.m_Buffs;
            for (int i = nowAllBuffList.Count - 1; i >= 0; i--)
            {
                if (nowAllBuffList[i].mSkillConf.Id == skillid)
                {
                    self.OnRemoveBuffItem(self.m_Buffs[i]);
                    self.m_Buffs.RemoveAt(i);
                }
            }
        }

        public static void AddTimer(this BuffManagerComponent self)
        {
            if (self.Timer == 0)
            {
                self.Timer = TimerComponent.Instance.NewRepeatedTimer(500, TimerType.BuffTimer, self);
            }
        }

        public static void BuffFactory(this BuffManagerComponent self, BuffData buffData, Unit from, SkillHandler skillHandler, bool notice = true)
        {
            Unit unit =self.GetParent<Unit>();
            SkillBuffConfig skillBuffConfig = SkillBuffConfigCategory.Instance.Get(buffData.BuffId);
            float now_DiKangPro = unit.GetComponent<NumericComponent>().GetAsFloat(NumericType.Now_DiKangPro);
            if (RandomHelper.RandFloat01() < now_DiKangPro && skillBuffConfig.BuffBenefitType == 2)
            {
                //抵抗,添加瓢字
                return;
            }
            StateComponent stateComponent = unit.GetComponent<StateComponent>();
            long newState = skillBuffConfig.buffParameterType;
            if (skillBuffConfig.BuffType == 2)
            {
                newState = (1 << skillBuffConfig.buffParameterType);
            }
            if (stateComponent.StateTypeGet(StateTypeEnum.SilenceImmune) && newState == StateTypeEnum.Silence)
            {
                return;
            }
            if (stateComponent.StateTypeGet(StateTypeEnum.DizzinessImmune) && newState == StateTypeEnum.Dizziness)
            {
                return;
            }

            //霸体状态和无敌状态免疫眩晕和沉默的buff
            if (stateComponent.StateTypeGet(StateTypeEnum.BaTi) || stateComponent.StateTypeGet(StateTypeEnum.WuDi))
            {
                if (newState == StateTypeEnum.Shackle || newState == StateTypeEnum.Dizziness)
                {
                    //免疫
                    M2C_UnitBuffStatus m2C_UnitBuffStatus = new M2C_UnitBuffStatus();
                    m2C_UnitBuffStatus.UnitID = unit.Id;
                    m2C_UnitBuffStatus.FlyType = 12;
                    m2C_UnitBuffStatus.BuffID = buffData.BuffId;
                    //当前场景内的玩家全部广播
                    MessageHelper.Broadcast(self.GetParent<Unit>(), m2C_UnitBuffStatus);
                    return;
                }
            }

            //眩晕抵抗
            float now_DizzinessPro = unit.GetComponent<NumericComponent>().GetAsFloat(NumericType.Now_Resistance_Dizziness_Pro);
            if (RandomHelper.RandFloat01() <now_DizzinessPro)
            {
                if (newState == StateTypeEnum.Dizziness)
                {
                    //眩晕抵抗
                    M2C_UnitBuffStatus m2C_UnitBuffStatus = new M2C_UnitBuffStatus();
                    m2C_UnitBuffStatus.UnitID = unit.Id;
                    m2C_UnitBuffStatus.FlyType = 11;
                    m2C_UnitBuffStatus.BuffID = buffData.BuffId;
                    //全部广播
                    MessageHelper.Broadcast(self.GetParent<Unit>(), m2C_UnitBuffStatus);
                    return;
                }
            }

            int addBufStatus = 1;   //1新增buff  2 移除 3 重置 4同状态返回
            BuffHandler buffHandler = null;
            List<BuffHandler> nowAllBuffList = self.m_Buffs;

            //判断叠加上限
            if (skillBuffConfig.BuffAddClassMax != 0)
            {
                int curNumber = 0;
                for (int i = nowAllBuffList.Count - 1; i >= 0; i--)
                {
                    buffHandler = nowAllBuffList[i];
                    SkillBuffConfig tempBuffConfig = buffHandler.mBuffConfig;
                    if (tempBuffConfig.Id == skillBuffConfig.Id)
                    {
                        curNumber++;
                    }
                }
                if (curNumber >= skillBuffConfig.BuffAddClassMax)
                {
                    return;
                }
            }

            string[] weiyiBuffId = new string[0];
            List<int> weiyiBuffList = new List<int>();
            if (!ComHelp.IfNull(skillBuffConfig.WeiYiBuffID))
            {
                weiyiBuffId = skillBuffConfig.WeiYiBuffID.Split(";");
            }
            for (int w = 0; w < weiyiBuffId.Length; w++)
            {
                weiyiBuffList.Add(int.Parse(weiyiBuffId[w]));
            }
            //先移除互斥
            for (int i = nowAllBuffList.Count - 1; i >=0 ; i--)
            {
                bool remove = false;
                buffHandler = nowAllBuffList[i];
                SkillBuffConfig tempBuffConfig = buffHandler.mBuffConfig;
                if (tempBuffConfig.Id == skillBuffConfig.Id && skillBuffConfig.BuffAddClass == 0)
                {
                    remove = true;
                }

                //互斥Buff直接移除
                if (weiyiBuffList.Contains(tempBuffConfig.Id))
                {
                    remove = true;
                }

                //操作同状态的Buff
                if (tempBuffConfig.BuffType == 2 && tempBuffConfig.BuffType == skillBuffConfig.BuffType
                    && tempBuffConfig.buffParameterType == skillBuffConfig.buffParameterType)   
                {
                    long newEndTime = TimeHelper.ServerNow() + skillBuffConfig.BuffTime;
                    if (newEndTime < buffHandler.BuffEndTime)
                    {
                        addBufStatus = 4;
                    }
                    else
                    {
                        remove = true;
                    }
                }

                if (remove)
                {
                    M2C_UnitBuffRemove m2C_UnitBuffUpdate = self.m2C_UnitBuffRemove;
                    m2C_UnitBuffUpdate.UnitIdBelongTo = unit.Id;
                    m2C_UnitBuffUpdate.BuffID = tempBuffConfig.Id;
                    MessageHelper.BroadcastBuff(self.GetParent<Unit>(), m2C_UnitBuffUpdate, tempBuffConfig, self.SceneType);
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
                string BuffClassScript = skillBuffConfig.BuffScript;
                if (MongoHelper.NoRecovery)
                {
                    buffHandler = (BuffHandler)ObjectPool.Instance.Fetch2(BuffDispatcherComponent.Instance.BuffTypes[BuffClassScript]); ;
                }
                else
                {
                    buffHandler = (BuffHandler)ObjectPool.Instance.Fetch(BuffDispatcherComponent.Instance.BuffTypes[BuffClassScript]);
                }
               
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
                m2C_UnitBuffUpdate.BuffID = skillBuffConfig.Id;
                m2C_UnitBuffUpdate.BuffOperateType = addBufStatus;
                m2C_UnitBuffUpdate.BuffEndTime = buffHandler.BuffEndTime;
                m2C_UnitBuffUpdate.TargetPostion.Clear();
                m2C_UnitBuffUpdate.TargetPostion.Add(buffHandler.TargetPosition.x);
                m2C_UnitBuffUpdate.TargetPostion.Add(buffHandler.TargetPosition.y);
                m2C_UnitBuffUpdate.TargetPostion.Add(buffHandler.TargetPosition.z);
                m2C_UnitBuffUpdate.Spellcaster = from.GetComponent<UnitInfoComponent>().UnitName;
                m2C_UnitBuffUpdate.UnitType = from.Type;
                m2C_UnitBuffUpdate.UnitConfigId = from.ConfigId;    
                m2C_UnitBuffUpdate.SkillId = buffData.SkillId;
                if (unit.GetComponent<AOIEntity>() == null)
                {
                    Log.Error($"unit.GetComponent<AOIEntity>() == null  {unit.Type} {unit.ConfigId}  {unit.Id}  {unit.IsDisposed}");
                    return;
                }
                MessageHelper.BroadcastBuff(unit, m2C_UnitBuffUpdate, skillBuffConfig, self.SceneType);
            }
        }

        public static void Check(this BuffManagerComponent self)
        {
            int buffcnt = self.m_Buffs.Count;
            for (int i = buffcnt - 1; i >= 0; i--)
            {
                self.m_Buffs[i].OnUpdate();
                if (self.m_Buffs.Count == 0)
                {
                    Unit unit = self.GetParent<Unit>();
                    LogHelper.LogDebug($"BuffManager[m_Buffs.Count == 0]:  {unit.Type} {unit.ConfigId} {unit.InstanceId}");
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
            }
            if (self.m_Buffs.Count == 0)
            {
                TimerComponent.Instance?.Remove(ref self.Timer);
            }
        }

        public static void OnMaoXianJiaUpdate(this BuffManagerComponent self)
        {
            Unit unit = self.GetParent<Unit>();

            int jifen = unit.GetMaoXianExp();
            int activityid = unit.GetComponent<ActivityComponent>().GetMaxActivityId(jifen);
            if (activityid == 0)
            {
                return;
            }

            //移除之前的
            for (int i = 30001; i < activityid; i++)
            {
                List<int> buffidsold = ActivityConfigCategory.Instance.GetBuffIds(i);
                self.BuffRemoveList(buffidsold);
            }

            self.InitMaoXianJiaBuff();
        }

        public static void InitMaoXianJiaBuff(this BuffManagerComponent self)
        {
            Unit unit = self.GetParent<Unit>();
            if (unit.Type != UnitType.Player)
            {
                return;
            }

            int jifen = unit.GetMaoXianExp();
            int activityid = unit.GetComponent<ActivityComponent>().GetMaxActivityId(jifen);
            if (activityid == 0)
            {
                return;
            }

            List<int> buffids = ActivityConfigCategory.Instance.GetBuffIds(activityid);
            for (int i = 0; i < buffids.Count; i++)
            {
                BuffData buffData_2 = new BuffData();
                buffData_2.SkillId = 67000278;
                buffData_2.BuffId = buffids[i];
                self.BuffFactory(buffData_2, unit, null);
            }
        }

        public static void InitBaoShiBuff(this BuffManagerComponent self)
        {
            Unit unit = self.GetParent<Unit>();
            if (unit.Type != UnitType.Player)
            {
                return;
            }

            //self.BuffRemove(99001042);
            //self.BuffRemove(99001031);
            //self.BuffRemove(99001032);
            //self.BuffRemove(99001011);
            self.BuffRemoveList(SkillHelp.BaoShiBuff);

            UserInfoComponent userInfoComponent = unit.GetComponent<UserInfoComponent>();
            if (userInfoComponent.UserInfo.BaoShiDu >= 80)
            {
                BuffData buffData_2 = new BuffData();
                buffData_2.SkillId = 67000278;
                buffData_2.BuffId = 99001041;
                self.BuffFactory(buffData_2, unit, null);

                buffData_2 = new BuffData();
                buffData_2.SkillId = 67000278;
                buffData_2.BuffId = 99001042;
                self.BuffFactory(buffData_2, unit, null);
            }

            if (userInfoComponent.UserInfo.BaoShiDu >= 60 && userInfoComponent.UserInfo.BaoShiDu < 80)
            {
                BuffData buffData_2 = new BuffData();
                buffData_2.SkillId = 67000278;
                buffData_2.BuffId = 99001031;
                self.BuffFactory(buffData_2, unit, null);

                buffData_2 = new BuffData();
                buffData_2.SkillId = 67000278;
                buffData_2.BuffId = 99001032;
                self.BuffFactory(buffData_2, unit, null);
            }

            if (userInfoComponent.UserInfo.BaoShiDu >= 20 && userInfoComponent.UserInfo.BaoShiDu < 60)
            {
                BuffData buffData_2 = new BuffData();
                buffData_2.SkillId = 67000278;
                buffData_2.BuffId = 99001021;
                self.BuffFactory(buffData_2, unit, null);
            }

            if (userInfoComponent.UserInfo.BaoShiDu < 20)
            {
                BuffData buffData_2 = new BuffData();
                buffData_2.SkillId = 67000278;
                buffData_2.BuffId = 99001011;
                self.BuffFactory(buffData_2, unit, null);
            }
        }

        public static void InitBuff(this BuffManagerComponent self, int sceneType)
        {
            Unit unit = self.GetParent<Unit>();
            UnitInfoComponent unitInfoComponent = unit.GetComponent<UnitInfoComponent>();
            for (int i = 0; i < unitInfoComponent.Buffs.Count; i++)
            {
                BuffData buffData_1 = new BuffData();
                buffData_1.SkillId = 67000278;
                buffData_1.BuffId = unitInfoComponent.Buffs[i].KeyId;
                buffData_1.BuffEndTime = long.Parse(unitInfoComponent.Buffs[i].Value2);
                self.BuffFactory(buffData_1, self.GetParent<Unit>(), null, true);
            }
            unitInfoComponent.Buffs.Clear();

            self.InitBaoShiBuff();
            self.InitDonationBuff();
            self.InitSoloBuff(sceneType);
            self.InitMaoXianJiaBuff();
        }

        public static void InitSoloBuff(this BuffManagerComponent self, int sceneType)
        {
            if (sceneType != SceneTypeEnum.Solo)
            {
                return;
            }

            Unit unit = self.GetParent<Unit>();
            if (unit.Type != UnitType.Player)
            {
                return;
            }

            for (int i = 0; i < ConfigHelper.SoloBuffIds.Count; i++)
            {
                BuffData buffData_2 = new BuffData();
                buffData_2.SkillId = 67000278;
                buffData_2.BuffId = ConfigHelper.SoloBuffIds[i];
                self.BuffFactory(buffData_2, unit, null);
            }

            //恢复血量
            NumericComponent numericComponent = unit.GetComponent<NumericComponent>();
            long max_hp = numericComponent.GetAsLong(NumericType.Now_MaxHp);
            numericComponent.NumericDic[NumericType.Now_Hp] = 0;
            numericComponent.ApplyChange(null, NumericType.Now_Hp, max_hp, 0);
        }

        public static void InitDonationBuff(this BuffManagerComponent self)
        {
            //移除之前的buff
            //self.BuffRemove(99003011);
            //self.BuffRemove(99003012);
            //self.BuffRemove(99003013);
            //self.BuffRemove(99003021);
            //self.BuffRemove(99003022);
            //self.BuffRemove(99003023);
            //self.BuffRemove(99003031);
            //self.BuffRemove(99003032);
            //self.BuffRemove(99003033);
            //self.BuffRemove(99003041);
            //self.BuffRemove(99003042);
            //self.BuffRemove(99003043);
            //self.BuffRemove(99003051);
            //self.BuffRemove(99003052);
            //self.BuffRemove(99003053);
            //self.BuffRemove(99003061);
            //self.BuffRemove(99003062);
            //self.BuffRemove(99003063);
            //self.BuffRemove(99003064);
            self.BuffRemoveList(SkillHelp.DonationBuff);

            int rankid = self.GetParent<Unit>().GetComponent<NumericComponent>().GetAsInt(NumericType.RaceDonationRankID);
            if (rankid == 0)
            {
                return;
            }
            else if (rankid == 1)
            {
                BuffData buffData_2 = new BuffData();
                buffData_2.SkillId = 67000278;
                buffData_2.BuffId = 99003061;
                self.BuffFactory(buffData_2, self.GetParent<Unit>(), null);
                buffData_2 = new BuffData();
                buffData_2.SkillId = 67000278;
                buffData_2.BuffId = 99003062;
                self.BuffFactory(buffData_2, self.GetParent<Unit>(), null);
                buffData_2 = new BuffData();
                buffData_2.SkillId = 67000278;
                buffData_2.BuffId = 99003063;
                self.BuffFactory(buffData_2, self.GetParent<Unit>(), null);
                buffData_2 = new BuffData();
                buffData_2.SkillId = 67000278;
                buffData_2.BuffId = 99003064;
                self.BuffFactory(buffData_2, self.GetParent<Unit>(), null);
            }
            else if (rankid == 2)
            {
                BuffData buffData_2 = new BuffData();
                buffData_2.SkillId = 67000278;
                buffData_2.BuffId = 99003051;
                self.BuffFactory(buffData_2, self.GetParent<Unit>(), null);
                buffData_2 = new BuffData();
                buffData_2.SkillId = 67000278;
                buffData_2.BuffId = 99003052;
                self.BuffFactory(buffData_2, self.GetParent<Unit>(), null);
                buffData_2 = new BuffData();
                buffData_2.SkillId = 67000278;
                buffData_2.BuffId = 99003053;
                self.BuffFactory(buffData_2, self.GetParent<Unit>(), null);
            }
            else if (rankid == 3)
            {
                BuffData buffData_2 = new BuffData();
                buffData_2.SkillId = 67000278;
                buffData_2.BuffId = 99003041;
                self.BuffFactory(buffData_2, self.GetParent<Unit>(), null);
                buffData_2 = new BuffData();
                buffData_2.SkillId = 67000278;
                buffData_2.BuffId = 99003042;
                self.BuffFactory(buffData_2, self.GetParent<Unit>(), null);
                buffData_2 = new BuffData();
                buffData_2.SkillId = 67000278;
                buffData_2.BuffId = 99003043;
                self.BuffFactory(buffData_2, self.GetParent<Unit>(), null);
            }
            else if (rankid >= 4&& rankid <= 5)
            {
                BuffData buffData_2 = new BuffData();
                buffData_2.SkillId = 67000278;
                buffData_2.BuffId = 99003031;
                self.BuffFactory(buffData_2, self.GetParent<Unit>(), null);
                buffData_2 = new BuffData();
                buffData_2.SkillId = 67000278;
                buffData_2.BuffId = 99003032;
                self.BuffFactory(buffData_2, self.GetParent<Unit>(), null);
                buffData_2 = new BuffData();
                buffData_2.SkillId = 67000278;
                buffData_2.BuffId = 99003033;
                self.BuffFactory(buffData_2, self.GetParent<Unit>(), null);
            }
            else if (rankid >= 6 && rankid <= 10)
            {
                BuffData buffData_2 = new BuffData();
                buffData_2.SkillId = 67000278;
                buffData_2.BuffId = 99003021;
                self.BuffFactory(buffData_2, self.GetParent<Unit>(), null);
                buffData_2 = new BuffData();
                buffData_2.SkillId = 67000278;
                buffData_2.BuffId = 99003022;
                self.BuffFactory(buffData_2, self.GetParent<Unit>(), null);
                buffData_2 = new BuffData();
                buffData_2.SkillId = 67000278;
                buffData_2.BuffId = 99003023;
                self.BuffFactory(buffData_2, self.GetParent<Unit>(), null);
            }
            else
            {
                BuffData buffData_2 = new BuffData();
                buffData_2.SkillId = 67000278;
                buffData_2.BuffId = 99003011;
                self.BuffFactory(buffData_2, self.GetParent<Unit>(), null);
                buffData_2 = new BuffData();
                buffData_2.SkillId = 67000278;
                buffData_2.BuffId = 99003012;
                self.BuffFactory(buffData_2, self.GetParent<Unit>(), null);
                buffData_2 = new BuffData();
                buffData_2.SkillId = 67000278;
                buffData_2.BuffId = 99003013;
                self.BuffFactory(buffData_2, self.GetParent<Unit>(), null);
            }


        }

        public static List<KeyValuePair> GetMessageBuff(this BuffManagerComponent self)
        {
            List<KeyValuePair> Buffs = new List<KeyValuePair>();
            for (int i = 0; i < self.m_Buffs.Count; i++)
            {
                BuffHandler buffHandler = self.m_Buffs[i];
                SkillBuffConfig skillBuffConfig = buffHandler.mBuffConfig;
                if (skillBuffConfig == null || skillBuffConfig.Id < 10) //子弹
                {
                    continue;
                }
                Buffs.Add(new KeyValuePair() {
                    KeyId = skillBuffConfig.Id,
                    Value = $"{buffHandler.BuffData.SkillId}_{buffHandler.BuffData.Spellcaster}",
                    Value2 = buffHandler.BuffEndTime.ToString() }); ;
            }
            return Buffs;
        }

        public static void BeforeTransfer(this BuffManagerComponent self)
        {
            UnitInfoComponent unitInfoComponent = self.GetParent<Unit>().GetComponent<UnitInfoComponent>();
            unitInfoComponent.Buffs.Clear();
            int buffcnt = self.m_Buffs.Count;
            for (int i = buffcnt - 1; i >= 0; i--)
            {
                BuffHandler buffHandler = self.m_Buffs[i];
                buffHandler.OnFinished();
                ObjectPool.Instance.Recycle(buffHandler);
                self.m_Buffs.RemoveAt(i);
                if (buffHandler.mBuffConfig.Transfer != 1)
                {
                    continue;
                }
                unitInfoComponent.Buffs.Add(new KeyValuePair() { KeyId = buffHandler.mBuffConfig.Id, Value2 = buffHandler.BuffEndTime.ToString() });
            }
        }
    }
}