using System;

namespace ET
{

    /// <summary>
    /// 查找装备所在拍卖行那一页(待实现)
    /// </summary>
    [ActorMessageHandler]
    public class C2P_PaiMaiFindHandler : AMActorRpcHandler<Scene, C2P_PaiMaiFindRequest, P2C_PaiMaiFindResponse>
    {
        protected override async ETTask Run(Scene scene, C2P_PaiMaiFindRequest request, P2C_PaiMaiFindResponse response, Action reply)
        {
            response.Page = 1;

            reply();
            await ETTask.CompletedTask;
        }
    }
}