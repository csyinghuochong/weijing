using System;
using System.Collections.Generic;

namespace ET
{
    [ActorMessageHandler]
    public class M2U_UnionKeJiLearnHandler : AMActorRpcHandler<Scene, M2U_UnionKeJiLearnRequest, U2M_UnionKeJiLearnResponse>
    {
        protected override async ETTask Run(Scene scene, M2U_UnionKeJiLearnRequest request, U2M_UnionKeJiLearnResponse response, Action reply)
        {
            DBUnionInfo dBUnionInfo = await scene.GetComponent<UnionSceneComponent>().GetDBUnionInfo(request.UnionId);
            if (dBUnionInfo == null)
            {
                response.Error = ErrorCode.ERR_Union_Not_Exist;
                reply();
                return;
            }

            if (request.KeJiId > dBUnionInfo.UnionInfo.UnionKeJiList[request.Position])
            {
                response.Error = ErrorCode.ERR_LevelIsNot;
                reply();
                return;
            }

            UnionKeJiConfig unionKeJiConfig = UnionKeJiConfigCategory.Instance.Get(request.KeJiId);
            if (unionKeJiConfig.NeedUnionLv > dBUnionInfo.UnionInfo.Level)
            {
                response.Error = ErrorCode.ERR_LevelIsNot;
                reply();
                return;
            }

            reply();
            await ETTask.CompletedTask;
        }
    }
}
