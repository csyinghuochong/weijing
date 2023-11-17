
namespace ET
{
#if SERVER
    public class StateComponent : Entity, IAwake, ITransfer, IDeserialize
#else
    public class StateComponent : Entity, IAwake
#endif

    {
        //当前携带状态标志
        public long CurrentStateType;

        public long RigidityEndTime;

        public long NetWaitEndTime;

        public int ObstructStatus;

#if !SERVER

        public C2M_UnitStateUpdate c2M_UnitStateUpdate = null;

        /// <summary>
        /// 沉默, 避免前后端不同步出现玩家不能移动的情况
        /// </summary>
        public long SilenceCheckTime;
#endif
    }

}
