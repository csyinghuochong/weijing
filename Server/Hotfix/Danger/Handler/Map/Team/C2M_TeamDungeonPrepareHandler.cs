using System;

namespace ET
{

    [ActorMessageHandler]
    public class C2M_TeamDungeonPrepareHandler : AMActorLocationRpcHandler<Unit, C2M_TeamDungeonPrepareRequest, M2C_TeamDungeonPrepareResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_TeamDungeonPrepareRequest request, M2C_TeamDungeonPrepareResponse response, Action reply)
        {
			int sceneid = request.TeamInfo.SceneId;
			if (sceneid == 0)
			{
				reply();
				return;
			}

			UserInfoComponent userInfoComponent = unit.GetComponent<UserInfoComponent>();
			SceneConfig sceneConfig = SceneConfigCategory.Instance.Get(sceneid);
			if (sceneConfig.DayEnterNum > 0 && sceneConfig.DayEnterNum <= userInfoComponent.GetSceneFubenTimes(sceneid))
			{
				response.Error = ErrorCore.ERR_TimesIsNot;
				reply();
				return;
			}

			int errorcode = ErrorCore.ERR_Success;
			//判断队长是否有深渊票
			Unit leader = unit.GetParent<UnitComponent>().Get(request.TeamInfo.TeamId);
			if (leader != null)
			{
				BagComponent bagComponent = leader.GetComponent<BagComponent>();
				if (request.TeamInfo.FubenType == TeamFubenType.ShenYuan && bagComponent.GetItemNumber(ComHelp.ShenYuanCostId) < 1)
				{
					errorcode = ErrorCore.Err_ShenYuanItemError;
				}
                //if (request.FubenType == TeamFubenType.Normal)
                //{
                //    float value = RandomHelper.RandFloat01();
                //    if (value <= 0.05f)
                //    {
                //        request.FubenType = TeamFubenType.ShenYuan;
                //    }
                //}
            }

			//判断副本次数
			long teamServerId = DBHelper.GetTeamServerId(unit.DomainZone());
			T2M_TeamDungeonPrepareResponse createResponse = (T2M_TeamDungeonPrepareResponse)await MessageHelper.CallActor(teamServerId, new M2T_TeamDungeonPrepareRequest()
			{
				TeamId = request.TeamInfo.TeamId,
				UnitID = unit.Id,
				Prepare = request.Prepare,
				ErrorCode = errorcode
			});

			reply();
			await ETTask.CompletedTask;
        }
    }
}
