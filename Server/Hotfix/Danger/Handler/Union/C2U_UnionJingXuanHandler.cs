using System;

namespace ET
{
    [ActorMessageHandler]
    public class C2U_UnionJingXuanHandler : AMActorRpcHandler<Scene, C2U_UnionJingXuanRequest, U2C_UnionJingXuanResponse>
    {
        protected override async ETTask Run(Scene scene, C2U_UnionJingXuanRequest request, U2C_UnionJingXuanResponse response, Action reply)
        {
            long dbCacheId = DBHelper.GetDbCacheId(scene.DomainZone());
            DBUnionInfo dBUnionInfo = await scene.GetComponent<UnionSceneComponent>().GetDBUnionInfo(request.UnionId);
            if (dBUnionInfo == null)
            {
                response.Error = ErrorCode.ERR_Union_Not_Exist;
                reply();
                return;
            }
            if (dBUnionInfo.UnionInfo.JingXuanEndTime == 0)
            {
                response.Error = ErrorCode.ERR_AlreadyFinish;
                reply();
                return;
            }

            if (request.OperateType == 0 && dBUnionInfo.UnionInfo.JingXuanList.Contains(request.UnitId))
            {
                dBUnionInfo.UnionInfo.JingXuanList.Remove(request.UnitId);
            }
            if (request.OperateType == 1 && !dBUnionInfo.UnionInfo.JingXuanList.Contains(request.UnitId))
            {
                dBUnionInfo.UnionInfo.JingXuanList.Add(request.UnitId);
            }

            if (dBUnionInfo.UnionInfo.LeaderId == request.UnitId)
            {
                dBUnionInfo.UnionInfo.JingXuanList.Clear();
                dBUnionInfo.UnionInfo.JingXuanEndTime = 0;
            }
            response.JingXuanList = dBUnionInfo.UnionInfo.JingXuanList;
            response.JingXuanEndTime = dBUnionInfo.UnionInfo.JingXuanEndTime;
            DBHelper.SaveComponent(scene.DomainZone(), request.UnionId, dBUnionInfo).Coroutine();
            reply();
            await ETTask.CompletedTask;
        }
    }
}
