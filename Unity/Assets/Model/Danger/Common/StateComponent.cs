
namespace ET
{
    public class StateComponent : Entity, IAwake, ITransfer, IDeserialize
    {
        //当前携带状态标志
        public long CurrentStateType;

        public long RigidityEndTime;

        /// <summary>
        /// 沉默, 避免前后端不同步出现玩家不能移动的情况
        /// </summary>
        public long SilenceCheckTime;
#if !SERVER
        public C2M_UnitStateUpdate c2M_UnitStateUpdate = new C2M_UnitStateUpdate();
#endif
    }

}
