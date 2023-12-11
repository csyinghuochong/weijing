using System;

namespace ET
{
    [ActorMessageHandler]
    public class C2U_UnionKeJiActiteHandler : AMActorRpcHandler<Scene, C2U_UnionKeJiActiteRequest, U2C_UnionKeJiActiteResponse>
    {
        protected override async ETTask Run(Scene scene, C2U_UnionKeJiActiteRequest request, U2C_UnionKeJiActiteResponse response, Action reply)
        {
            DBUnionInfo dBUnionInfo = await scene.GetComponent<UnionSceneComponent>().GetDBUnionInfo(request.UnionId);
            if (dBUnionInfo == null)
            {
                response.Error = ErrorCode.ERR_Union_Not_Exist;
                reply();
                return;
            }

            int keijiId = dBUnionInfo.UnionInfo.UnionKeJiList[request.Position];
            UnionKeJiConfig unionKeJiConfig = UnionKeJiConfigCategory.Instance.Get(keijiId);
            if (unionKeJiConfig.NextID == 0)
            {
                response.Error = ErrorCode.ERR_Union_NotActive;
                reply();
                return;
            }

            if (dBUnionInfo.UnionInfo.KeJiActiteTime != 0)
            {
                response.UnionInfo = dBUnionInfo.UnionInfo;
                response.Error = ErrorCode.ERR_Union_HavActive;
                reply();
                return;
            }

            dBUnionInfo.UnionInfo.KeJiActitePos = request.Position;
            dBUnionInfo.UnionInfo.KeJiActiteTime = TimeHelper.ServerNow();
            response.UnionInfo = dBUnionInfo.UnionInfo;
            DBHelper.SaveComponent(scene.DomainZone(), request.UnionId, dBUnionInfo).Coroutine();
            reply();
        }
    }
}
