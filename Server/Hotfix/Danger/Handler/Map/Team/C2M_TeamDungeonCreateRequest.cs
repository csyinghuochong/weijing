using System;
using System.Collections.Generic;


namespace ET
{
    [ActorMessageHandler]
    public class C2M_TeamDungeonCreateHandler : AMActorLocationRpcHandler<Unit, C2M_TeamDungeonCreateRequest, M2C_TeamDungeonCreateResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_TeamDungeonCreateRequest request, M2C_TeamDungeonCreateResponse response, Action reply)
        {
            BagComponent bagComponent = unit.GetComponent<BagComponent>();
            if (request.FubenType == TeamFubenType.ShenYuan)
            {
                if (bagComponent.GetItemNumber(ComHelp.ShenYuanCostId) < 1)
                {
                    response.Error = ErrorCore.ERR_ItemNotEnoughError;
                    reply();
                    return;
                }
            }
            if (request.FubenType == TeamFubenType.Normal)
            {
                float value = RandomHelper.RandFloat01();
                if (value <= 0.05f)
                {
                    request.FubenType = TeamFubenType.ShenYuan;
                }
            }

            long teamServerId = DBHelper.GetTeamServerId(unit.DomainZone());
            T2M_TeamDungeonCreateResponse createResponse = (T2M_TeamDungeonCreateResponse)await MessageHelper.CallActor(teamServerId, new M2T_TeamDungeonCreateRequest()
            {
                FubenId = request.FubenId,
                TeamPlayerInfo = request.TeamPlayerInfo,
                FubenType = request.FubenType,
            });

            if (createResponse.Error != ErrorCore.ERR_Success)
            {
                response.Error = createResponse.Error;
                reply();
                return;
            }
            response.FubenType = request.FubenType;
            reply();
            await ETTask.CompletedTask;
        }
    }
}
