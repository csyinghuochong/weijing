using System;
using System.Collections.Generic;

namespace ET
{

    [ActorMessageHandler]
    public class C2E_MailGetAllHandler : AMActorRpcHandler<Scene, C2E_GetAllMailRequest, E2C_GetAllMailResponse>
    {
        protected override async ETTask Run(Scene scene, C2E_GetAllMailRequest request, E2C_GetAllMailResponse response, Action reply)
        {
            long dbCacheId = DBHelper.GetDbCacheId(scene.DomainZone());
            D2G_GetComponent d2GGetUnit = (D2G_GetComponent)await ActorMessageSenderComponent.Instance.Call(dbCacheId, new G2D_GetComponent() { CharacterId = request.ActorId, Component = DBHelper.DBMailInfo });
            if (d2GGetUnit.Component != null)
            {
                response.MailInfos = (d2GGetUnit.Component as DBMailInfo).MailInfoList;
            }
            reply();
        }

    }
}
