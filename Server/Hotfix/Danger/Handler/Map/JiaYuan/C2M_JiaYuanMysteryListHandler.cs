using System;

namespace ET
{
    [ActorMessageHandler]
    public class C2M_JiaYuanMysteryListHandler : AMActorLocationRpcHandler<Unit, C2M_JiaYuanMysteryListRequest, M2C_JiaYuanMysteryListResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_JiaYuanMysteryListRequest request, M2C_JiaYuanMysteryListResponse response, Action reply)
        {
            //家园商店
            if (request.NpcID == 30000001)
            {
                response.MysteryItemInfos = unit.GetComponent<JiaYuanComponent>().PlantGoods_7;
            }
            //牧场商店
            if (request.NpcID == 30000013)
            {
                response.MysteryItemInfos = unit.GetComponent<JiaYuanComponent>().JiaYuanStore;
            }

            unit.GetComponent<JiaYuanComponent>().NowOpenNpcId = request.NpcID;

            reply();
            await ETTask.CompletedTask;
        }
    }
}
