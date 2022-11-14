using System;
using System.Collections.Generic;

namespace ET
{

    [ActorMessageHandler]
    public class M2E_EMailReceiveHandler : AMActorRpcHandler<Scene, M2E_EMailReceiveRequest, E2M_EMailReceiveResponse>
    {

        protected override async ETTask Run(Scene scene, M2E_EMailReceiveRequest request, E2M_EMailReceiveResponse response, Action reply)
        {
            long dbCacheId = DBHelper.GetDbCacheId(scene.DomainZone());
            D2G_GetComponent d2GGetUnit = (D2G_GetComponent)await ActorMessageSenderComponent.Instance.Call(dbCacheId, new G2D_GetComponent() { UnitId = request.Id, Component = DBHelper.DBMailInfo });
            DBMailInfo dBMailInfo = d2GGetUnit.Component as DBMailInfo;

            for (int i = dBMailInfo.MailInfoList.Count - 1; i >= 0; i--)
            {
                if (dBMailInfo.MailInfoList[i].MailId == request.MailId)
                {
                    MailInfo mailInfo = dBMailInfo.MailInfoList[i];
                    dBMailInfo.MailInfoList.RemoveAt(i);
                    response.MailInfo = mailInfo;
                    break;
                }
            }
         
            D2M_SaveComponent d2GSave = (D2M_SaveComponent)await ActorMessageSenderComponent.Instance.Call(dbCacheId, new M2D_SaveComponent() { UnitId = request.Id, Component = dBMailInfo, ComponentType = DBHelper.DBMailInfo });
            reply();
        }
    }
}
