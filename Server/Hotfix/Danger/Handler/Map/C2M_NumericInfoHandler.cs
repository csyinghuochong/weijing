using System;

namespace ET
{
    /// <summary>
    /// 获取玩家数值
    /// </summary>
    [ActorMessageHandler]
    public class C2M_NumericInfoHandler : AMActorLocationRpcHandler<Unit, C2M_NumericInfoRequest, M2C_NumericInfoResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_NumericInfoRequest request, M2C_NumericInfoResponse response, Action reply)
        {


            reply();
            await ETTask.CompletedTask;
        }
    }
}
