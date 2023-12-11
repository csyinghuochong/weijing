using System;

namespace ET
{
    [ActorMessageHandler]
    public class C2U_UnionKeJiQuickHandler : AMActorRpcHandler<Scene, C2U_UnionKeJiQuickRequest, U2C_UnionKeJiQuickResponse>
    {
        protected override async ETTask Run(Scene scene, C2U_UnionKeJiQuickRequest request, U2C_UnionKeJiQuickResponse response, Action reply)
        {
            DBUnionInfo dBUnionInfo = await scene.GetComponent<UnionSceneComponent>().GetDBUnionInfo(request.UnionId);
            if (dBUnionInfo == null)
            {
                response.Error = ErrorCode.ERR_Union_Not_Exist;
                reply();
                return;
            }

            if (dBUnionInfo.UnionInfo.KeJiActiteTime == 0)
            {
                response.Error = ErrorCode.ERR_Union_NotActive;
                reply();
                return;
            }

            int keijiId = dBUnionInfo.UnionInfo.UnionKeJiList[dBUnionInfo.UnionInfo.KeJiActitePos];
            if (!UnionKeJiConfigCategory.Instance.Contain(keijiId + 1))
            {
                response.Error = ErrorCode.ERR_Union_NotActive;
                reply();
                return;
            }

            ////需要向游戏服发送协议扣除钻石
            long passTime = (dBUnionInfo.UnionInfo.KeJiActiteTime - TimeHelper.ServerNow()) / 1000;
            if (passTime >= UnionKeJiConfigCategory.Instance.Get(keijiId + 1).NeedTime)
            {
                dBUnionInfo.UnionInfo.UnionKeJiList[dBUnionInfo.UnionInfo.KeJiActitePos] = keijiId + 1;
                dBUnionInfo.UnionInfo.KeJiActitePos = -1;
                dBUnionInfo.UnionInfo.KeJiActiteTime = 0;
            }

            DBHelper.SaveComponent(scene.DomainZone(), request.UnionId, dBUnionInfo).Coroutine();
            reply();
        }
    }
}
