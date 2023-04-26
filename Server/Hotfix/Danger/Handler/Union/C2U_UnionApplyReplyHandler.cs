using System;

namespace ET
{

    [ActorMessageHandler]
    public class C2U_UnionApplyReplyHandler : AMActorRpcHandler<Scene, C2U_UnionApplyReplyRequest, U2C_UnionApplyReplyResponse>
    {

        protected override async ETTask Run(Scene scene, C2U_UnionApplyReplyRequest request, U2C_UnionApplyReplyResponse response, Action reply)
        {
            using (await CoroutineLockComponent.Instance.Wait(CoroutineLockType.UnionOperate, request.UnionId))
            {
                response.Error = await scene.GetComponent<UnionSceneComponent>().OnJoinUinon(request.UnionId, request.UserId, request.ReplyCode);
            }
            reply();
        }
    }
}
