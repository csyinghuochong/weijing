using System;

namespace ET
{

    [ActorMessageHandler]
    public class L2M_WeChatOABindResultHandler : AMActorRpcHandler<Unit, L2M_WeChatOABindResult, M2L_WeChatOABindResult>
    {

        protected override async ETTask Run(Unit unit, L2M_WeChatOABindResult request, M2L_WeChatOABindResult response, Action reply)
        {
            Console.WriteLine($"L2M_WeChatOABindResult:  {unit.Id}");

            NumericComponent numericComponent = unit.GetComponent<NumericComponent>();
            numericComponent.ApplyValue(NumericType.WeChatOABind, 1);

            reply();    
            await ETTask.CompletedTask;
        }
    }
}
