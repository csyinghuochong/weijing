using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{

    [ActorMessageHandler]
    public class G2Rank_EnterRankHandler : AMActorRpcHandler<Scene, G2Rank_EnterRank, Rank2G_EnterRank>
    {
        protected override async ETTask Run(Scene scene, G2Rank_EnterRank request, Rank2G_EnterRank response, Action reply)
        {
            RankSceneComponent rankSceneComponent = scene.GetComponent<RankSceneComponent>();
            response.RankId = rankSceneComponent.GetCombatRank(request.UnitId);
            response.PetRankId = rankSceneComponent.GetPetRank(request.UnitId);
            reply();
            await ETTask.CompletedTask;
        }
    }
}
