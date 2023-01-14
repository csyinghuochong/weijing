using System;

namespace ET
{
    /// <summary>
    /// 获取玩家数值
    /// </summary>
    [ActorMessageHandler]
    public class C2M_UnitInfoHandler : AMActorLocationRpcHandler<Unit, C2M_UnitInfoRequest, M2C_UnitInfoResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_UnitInfoRequest request, M2C_UnitInfoResponse response, Action reply)
        {

            reply();
            await ETTask.CompletedTask;
        }
    }
}
