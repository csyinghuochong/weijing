using System;


namespace ET
{

    [ActorMessageHandler]
    public class C2R_RankShowLieHandler : AMActorRpcHandler<Scene, C2R_RankShowLieRequest, R2C_RankShowLieResponse>
    {
        protected override async ETTask Run(Scene scene, C2R_RankShowLieRequest request, R2C_RankShowLieResponse response, Action reply)
        {
            for (int i = 10; i >= 1; i--)
            {
                response.RankList.Add(new RankShouLieInfo() { UnitID = i, PlayerName = "玩家：" + i.ToString(), KillNumber = i });
            }

            reply();
            await ETTask.CompletedTask;
        }
    }
}
