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

    public static class StateComponentSystem
    {
        public static void Awake(this StateComponent self)
        {
            self.CurrentStateDatas = StateTypeData.None;
        }

        public static void Reset(this StateComponent self)
        {
            self.CurrentStateDatas = StateTypeData.None;
        }

        public static bool CanUseSkill(this StateComponent self)
        {
            //判断当前是否是眩晕状态
            if (self.CurrentStateDatas.HasFlag(StateTypeData.Dizziness)
                || self.CurrentStateDatas.HasFlag(StateTypeData.JiTui)
                || self.CurrentStateDatas.HasFlag(StateTypeData.ChuanSong) )
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
            if (self.CurrentStateDatas.HasFlag(StateTypeData.SkillRigidity)
                || self.CurrentStateDatas.HasFlag(StateTypeData.Dizziness)
                || self.CurrentStateDatas.HasFlag(StateTypeData.ChuanSong)
                || self.CurrentStateDatas.HasFlag(StateTypeData.JiTui))
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
        public static void StateTypeAdd(this StateComponent self, StateTypeData nowStateType, string stateValue ="0")
        {
            self.CurrentStateDatas = self.CurrentStateDatas | nowStateType;
#if SERVER
            //发送改变属性的相关消息
            MessageHelper.Broadcast(self.GetParent<Unit>(), new M2C_UnitStateUpdate() { UnitId = self.Parent.Id, StateType = (long)nowStateType, StateValue = stateValue, StateOperateType = 1, StateTime = 0 });
            //眩晕状态停止当前移动(服务器代码)
            if (nowStateType == StateTypeData.Dizziness
                || nowStateType == StateTypeData.JiTui)
            {
                self.GetParent<Unit>().Stop(0);        //停止当前移动
            }
#else

#endif
        }

        /// <summary>
        /// 移除某个状态
        /// </summary>
        /// <param name="nowStateType"></param>
        public static void StateTypeRemove(this StateComponent self, StateTypeData nowStateType)
        {
            self.CurrentStateDatas = self.CurrentStateDatas & ~nowStateType;

#if SERVER
            //发送改变属性的相关消息
            Unit unit = self.GetParent<Unit>();
            if (unit == null || unit.IsDisposed)
                return;
            MessageHelper.Broadcast(self.GetParent<Unit>(), new M2C_UnitStateUpdate() { UnitId = self.Parent.Id, StateType = (long)nowStateType, StateOperateType = 2, StateTime = 0 });
#else

#endif
        }

        /// <summary>
        /// 获取某个状态是否存在
        /// </summary>
        /// <param name="nowStateType"></param>
        public static bool StateTypeGet(this StateComponent self, StateTypeData nowStateType)
        {
            int state = (int)(self.CurrentStateDatas & nowStateType);
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
        public static StateTypeData GetNowStateType(this StateComponent self)
        {
            return self.CurrentStateDatas;
        }

#if SERVER
        public static void BeAttacking(this StateComponent self, Unit attack)
        {
            if (self.StateTypeGet(StateTypeData.Singing))
            {
                self.StateTypeRemove(StateTypeData.Singing);
            }
        }
#endif

#if !SERVER
        //移动或者释放技能
        public static void BeginOperation(this StateComponent self)
        {
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            if (unit.GetComponent<StateComponent>().StateTypeGet(StateTypeData.Singing))
            {
                //打打断吟唱
                MapHelper.SendUpdateState(self.ZoneScene(), 2, (long)StateTypeData.Singing, "0");
            }
        }
#endif

    }
}