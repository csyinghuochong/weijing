
namespace ET
{
    public class StateComponent : Entity, IAwake, ITransfer, IDeserialize
    {
        //当前携带状态标志
        public long CurrentStateType;

        public long RigidityEndTime;

#if !SERVER
        public C2M_UnitStateUpdate c2M_UnitStateUpdate = new C2M_UnitStateUpdate();
#endif
    }

}
