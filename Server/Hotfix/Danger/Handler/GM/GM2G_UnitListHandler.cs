using System;

namespace ET
{
    [ActorMessageHandler]
    public class GM2G_UnitListHandler : AMActorRpcHandler<Scene, G2G_UnitListRequest, G2G_UnitListResponse>
    {
        protected override async ETTask Run(Scene scene, G2G_UnitListRequest request, G2G_UnitListResponse response, Action reply)
        {
            Player[] players = scene.GetComponent<PlayerComponent>().GetAll();
            for(int i = 0; i < players.Length; i++)
            {
                if (players[i].RemoteAddress.Contains("127.0.0.1"))
                {
                    response.OnLineRobot++;
                }
                else
                {
                    response.OnLinePlayer++;
                }
            }

            reply();
            await ETTask.CompletedTask;
        }

    }
}
