using System;

namespace ET
{
    [ActorMessageHandler]
    public class C2M_TeamDungeonOpenHandler : AMActorLocationRpcHandler<Unit, C2M_TeamDungeonOpenRequest, M2C_TeamDungeonOpenResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_TeamDungeonOpenRequest request, M2C_TeamDungeonOpenResponse response, Action reply)
        {
            long teamServerId = DBHelper.GetTeamServerId(unit.DomainZone());
            T2M_TeamDungeonOpenResponse createResponse = (T2M_TeamDungeonOpenResponse)await MessageHelper.CallActor(teamServerId, new M2T_TeamDungeonOpenRequest()
            {
                UserID = unit.Id,
                FubenType = request.FubenType,
            });

            if (createResponse.Error != ErrorCore.ERR_Success)
            {
                LogHelper.LogDebug($"T2M_TeamDungeonOpenResponse:{createResponse.Error}");
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
