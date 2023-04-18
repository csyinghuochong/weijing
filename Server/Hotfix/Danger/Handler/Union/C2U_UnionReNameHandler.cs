using System;

namespace ET
{

    [ActorMessageHandler]
    public class C2U_UnionReNameHandler : AMActorRpcHandler<Scene, C2U_UnionOperatateRequest, U2C_UnionOperatateResponse>
    {

        protected override async ETTask Run(Scene scene, C2U_UnionOperatateRequest request, U2C_UnionOperatateResponse response, Action reply)
        {
            DBUnionInfo dBUnionInfo = await scene.GetComponent<UnionSceneComponent>().GetDBUnionInfo(request.UnionId);

            if (request.Operatate == 1)
            {
                dBUnionInfo.UnionInfo.UnionName = request.Value;
            }
            if (request.Operatate == 2)
            {
                dBUnionInfo.UnionInfo.UnionPurpose = request.Value;
            }
            DBHelper.SaveComponent(scene.DomainZone(), request.UnionId, dBUnionInfo).Coroutine();
            reply();
            await ETTask.CompletedTask;
        }

    }
}
