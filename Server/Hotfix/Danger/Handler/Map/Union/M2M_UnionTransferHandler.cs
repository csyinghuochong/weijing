using System;

namespace ET
{

    [ActorMessageHandler]
    public class M2M_UnionTransferHandler : AMActorLocationHandler<Unit, M2M_UnionTransferMessage>
    {
        protected override async ETTask Run(Unit unit, M2M_UnionTransferMessage message)
        {
            NumericComponent numericComponent = unit.GetComponent<NumericComponent>();
            numericComponent.ApplyValue( NumericType.UnionLeader, 1, true );
            await ETTask.CompletedTask;
        }
    }
}
