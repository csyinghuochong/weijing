using System;


namespace ET
{

    [ActorMessageHandler]
    public class U2M_UnionOperationHandler : AMActorRpcHandler<Scene, U2M_UnionOperationRequest, M2U_UnionOperationResponse>
    {
        protected override async ETTask Run(Scene scene, U2M_UnionOperationRequest request, M2U_UnionOperationResponse response, Action reply)
        {
            using (await CoroutineLockComponent.Instance.Wait(CoroutineLockType.UnionOperate, request.UnionId))
            {
                DBUnionInfo dBUnionInfo = await scene.GetComponent<UnionSceneComponent>().GetDBUnionInfo(request.UnionId);
                if (dBUnionInfo == null)
                {
                    reply();
                    return;
                }

                switch (request.OperateType)
                {
                    case 1:
                        if (dBUnionInfo.UnionInfo.Level == 0)
                        {
                            dBUnionInfo.UnionInfo.Level = 1;
                        }
                        int level = dBUnionInfo.UnionInfo.Level;
                        dBUnionInfo.UnionInfo.Exp += int.Parse(request.Par);
                        UnionConfig unionConfig = UnionConfigCategory.Instance.Get(level);
                        if (dBUnionInfo.UnionInfo.Exp >= unionConfig.Exp && UnionConfigCategory.Instance.Contain(level + 1))
                        {
                            dBUnionInfo.UnionInfo.Level++;
                            dBUnionInfo.UnionInfo.Exp -= unionConfig.Exp;
                        }
                        DBHelper.SaveComponent(scene.DomainZone(), request.UnionId, dBUnionInfo).Coroutine();
                        break;
                    case 2:
                        response.Par = dBUnionInfo.UnionInfo.Level.ToString();
                        break;
                }
            }

            reply();
            await ETTask.CompletedTask;
        }
    }
}
