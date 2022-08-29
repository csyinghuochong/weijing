using System;


namespace ET
{

    [ActorMessageHandler]
    public  class A2R_DeleteRoleDataHandler : AMActorRpcHandler<Scene, A2R_DeleteRoleData, R2A_DeleteRoleData>
    {

        protected override async ETTask Run(Scene scene, A2R_DeleteRoleData request, R2A_DeleteRoleData response, Action reply)
        {
            RankSceneComponent rankScene = scene.GetComponent<RankSceneComponent>();
            rankScene.OnDeleteRole(rankScene.DBRankInfo.rankingInfos, request.DeleUserID);
            rankScene.OnDeleteRole(rankScene.DBRankInfo.rankingCamp1, request.DeleUserID);
            rankScene.OnDeleteRole(rankScene.DBRankInfo.rankingCamp2, request.DeleUserID);

            reply();
            await ETTask.CompletedTask;
        }
    }
}
