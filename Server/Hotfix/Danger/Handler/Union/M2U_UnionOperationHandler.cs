using System;


namespace ET
{

    [ActorMessageHandler]
    public class M2U_UnionOperationHandler : AMActorRpcHandler<Scene, M2U_UnionOperationRequest, U2M_UnionOperationResponse>
    {
        protected override async ETTask Run(Scene scene, M2U_UnionOperationRequest request, U2M_UnionOperationResponse response, Action reply)
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

                            MailInfo mailInfo = new MailInfo();
                            mailInfo.Title = "家族升级";
                            for (int i = 0; i < dBUnionInfo.UnionInfo.UnionPlayerList.Count; i++)
                            {
                                MailHelp.SendUserMail(scene.DomainZone(), dBUnionInfo.UnionInfo.UnionPlayerList[i].UserID, mailInfo).Coroutine();
                            }
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
