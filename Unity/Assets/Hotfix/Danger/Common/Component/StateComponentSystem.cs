namespace ET
{

    [ObjectSystem]
    public class StateComponentAwakeSystem : AwakeSystem<StateComponent>
    {
        public override void Awake(StateComponent self)
        {
            self.Awake();
        }
    }

    [ObjectSystem]
    public class StateComponentDeserializeSystem : DeserializeSystem<StateComponent>
    {
        public override void Deserialize(StateComponent self)
        {
            self.CurrentStateType = StateTypeEnum.None;
            self.RigidityEndTime = 0;
        }
    }

    public static class StateComponentSystem
    {
        public static void Awake(this StateComponent self)
        {
            self.CurrentStateType = StateTypeEnum.None;
            self.RigidityEndTime = 0;
        }

        public static void Reset(this StateComponent self)
        {
            self.CurrentStateType = StateTypeEnum.None;
        }

        public static bool IsRigidity(this StateComponent self)
        {
            return  TimeHelper.ServerNow() <  self.RigidityEndTime;
        }

        public static bool CanUseSkill(this StateComponent self)
        {
            //判断当前是否是眩晕状态
            if (self.StateTypeGet(StateTypeEnum.NetWait)
                || self.StateTypeGet(StateTypeEnum.Dizziness)
                || self.StateTypeGet(StateTypeEnum.JiTui)
                || self.StateTypeGet(StateTypeEnum.Silence))
            {
                return false;                                                                                                          
            }
            if (self.Parent.GetComponent<NumericComponent>().GetAsInt(NumericType.Now_Dead) == 1)
            {
                return false;
            }

            return true;
        }

        public static bool CanMove(this StateComponent self)
        { 
            //判断当前是否是眩晕状态
            if (self.StateTypeGet(StateTypeEnum.NetWait)
                || self.StateTypeGet(StateTypeEnum.Dizziness)
                || self.StateTypeGet(StateTypeEnum.JiTui)
                || self.StateTypeGet(StateTypeEnum.Shackle))
            {
                return false;
            }
            if (self.IsRigidity())
            {
                return false;
            }

            if (self.Parent.GetComponent<NumericComponent>().GetAsInt(NumericType.Now_Dead) == 1)
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// 增加某个状态
        /// </summary>
        /// <param name="nowStateType"></param>
        public static void StateTypeAdd(this StateComponent self, long nowStateType, string stateValue ="0")
        {
            self.CurrentStateType = self.CurrentStateType | nowStateType;
#if SERVER
            //发送改变属性的相关消息
            MessageHelper.Broadcast(self.GetParent<Unit>(), new M2C_UnitStateUpdate() { UnitId = self.Parent.Id, StateType = (long)nowStateType, StateValue = stateValue, StateOperateType = 1, StateTime = 0 });
            //眩晕状态停止当前移动(服务器代码)
            if (!self.CanMove())
            {
                self.GetParent<Unit>().Stop(-1);        //停止当前移动
            }
#else
            Unit unit = self.GetParent<Unit>();
            if (unit.MainHero && !self.CanMove())
            {
                self.SilenceCheckTime = TimeHelper.ServerNow();
            }
            if (unit.MainHero && (nowStateType == StateTypeEnum.Dizziness || nowStateType == StateTypeEnum.Shackle))
            {
                self.ZoneScene().GetComponent<AttackComponent>().RemoveTimer();
            }
#endif
        }

        /// <summary>
        /// 移除某个状态
        /// </summary>
        /// <param name="nowStateType"></param>
        public static void StateTypeRemove(this StateComponent self, long nowStateType)
        {
            self.CurrentStateType = self.CurrentStateType & ~nowStateType;

#if SERVER
            //发送改变属性的相关消息
            Unit unit = self.GetParent<Unit>();
            if (unit == null || unit.IsDisposed)
                return;
            MessageHelper.Broadcast(self.GetParent<Unit>(), new M2C_UnitStateUpdate() { UnitId = self.Parent.Id, StateType = (long)nowStateType, StateOperateType = 2, StateTime = 0 });
#else
            Unit unit = self.GetParent<Unit>();
            if (unit.MainHero && self.CanMove())
            {
                self.SilenceCheckTime = 0;
            }
#endif
        }

        /// <summary>
        /// 获取某个状态是否存在
        /// </summary>
        /// <param name="nowStateType"></param>
        public static bool StateTypeGet(this StateComponent self, long nowStateType)
        {
            long state = (self.CurrentStateType & nowStateType);
            //Log.Debug("nowStateTypes = " + nowStateTypes + " state = " + state);
            // 0 表示没有状态   大于0表示有状态
            if (state > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 获取当前状态
        /// </summary>
        /// <returns></returns>
        public static long GetNowStateType(this StateComponent self)
        {
            return self.CurrentStateType;
        }

#if !SERVER
        /// <summary>
        /// 
        /// </summary>
        public static void CheckSilence(this StateComponent self)
        {
            if (self.SilenceCheckTime == 0)
            {
                return;
            }
            if (self.SilenceCheckTime < TimeHelper.ServerNow() - 5000)
            {
                self.SilenceCheckTime = 0;
                //self.StateTypeRemove(StateTypeEnum.Dizziness);
                //self.StateTypeRemove(StateTypeEnum.Silence);
                //self.StateTypeRemove(StateTypeEnum.Shackle);
                self.Reset();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="zoneScene"></param>
        /// <param name="operatype">1新增  2移除</param>
        /// <param name="stateType"></param>
        /// <param name="stateValue"></param>
        public static void SendUpdateState(this StateComponent self, int operatype, long stateType, string stateValue)
        {
            C2M_UnitStateUpdate c2M_UnitStateUpdate = self.c2M_UnitStateUpdate;
            c2M_UnitStateUpdate.StateOperateType = operatype;
            c2M_UnitStateUpdate.StateType = stateType;
            c2M_UnitStateUpdate.StateValue = stateValue;
            self.ZoneScene().GetComponent<SessionComponent>().Session.Send(c2M_UnitStateUpdate);
        }
#endif

    }
}