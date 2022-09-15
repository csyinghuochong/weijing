
namespace ET
{

    public class StateComponent : Entity, IAwake, ITransfer
    {
        //当前携带状态标志
        public long CurrentStateType;
    }

}
