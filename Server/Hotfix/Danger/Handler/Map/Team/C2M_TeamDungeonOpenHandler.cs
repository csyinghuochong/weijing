using System;

namespace ET
{
    [ActorMessageHandler]
    public class C2M_TeamDungeonOpenHandler : AMActorLocationRpcHandler<Unit, C2M_TeamDungeonOpenRequest, M2C_TeamDungeonOpenResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_TeamDungeonOpenRequest request, M2C_TeamDungeonOpenResponse response, Action reply)
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
                bagComponent.OnCostItemData($"{ComHelp.ShenYuanCostId};1");
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
            T2M_TeamDungeonOpenResponse createResponse = (T2M_TeamDungeonOpenResponse)await MessageHelper.CallActor(teamServerId, new M2T_TeamDungeonOpenRequest()
            {
                UserID = unit.Id,
                FubenType = request.FubenType,
            });

            if (createResponse.Error != ErrorCore.ERR_Success)
            {
                Log.Warning($"T2M_TeamDungeonOpenResponse:{createResponse.Error}");
                bagComponent.OnAddItemData($"{ComHelp.ShenYuanCostId};1", "0");
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
