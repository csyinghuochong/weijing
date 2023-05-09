using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    [ActorMessageHandler]
    public class C2P_PaiMaiAuctionRecordHandler : AMActorRpcHandler<Scene, C2P_PaiMaiAuctionRecordRequest, P2C_PaiMaiAuctionRecordResponse>
    {
        protected override async ETTask Run(Scene scene, C2P_PaiMaiAuctionRecordRequest request, P2C_PaiMaiAuctionRecordResponse response, Action reply)
        {
            response.RecordList = scene.GetComponent<PaiMaiSceneComponent>().AuctionRecords;

            reply();
            await ETTask.CompletedTask;
        }
    }
}
